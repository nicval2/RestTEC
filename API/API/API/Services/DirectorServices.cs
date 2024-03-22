using System.Text.Json;
using API.Models;

namespace API.Services;

public class DirectorServices
{
     private List<DirectorDto> _directorsDto = new List<DirectorDto>();
    public DirectorDto Save(DirectorDto dtoC)
        {
            _directorsDto.Add(dtoC);
            WriteArchive(_directorsDto);
            return dtoC;
        }

        public DirectorDto Element(int id)
        {
            _directorsDto = LoadArchive();
            int i = 0;
            DirectorDto target = null;
            while (i<_directorsDto.Count())
            {
                if (_directorsDto.ElementAt(i).IdDirector == id)
                {
                    target = _directorsDto.ElementAt(i);
                    break;
                }
                i++;
            }

            try
            {
                return target;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int Size()
        {
            _directorsDto = LoadArchive();
            return _directorsDto.Count();
        }

        public DirectorDto Search(int id)
        {
            _directorsDto = LoadArchive();
            try
            {
                DirectorDto target = null;
                foreach (DirectorDto dto in _directorsDto)
                {
                    if (dto.IdDirector == id)
                    {
                        return dto;
                    }
                }

                return target;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Delete(int id)
        {
            _directorsDto = LoadArchive();
            var i = 0;
            while (i < _directorsDto.Count)
            {
                if (_directorsDto.ElementAt(i).IdDirector==id)
                {
                    _directorsDto.RemoveAt(i);
                    WriteArchive(_directorsDto);
                    break;
                }

                i++;
            }
        }

        public DirectorDto Update(DirectorDto dtoC, int ssn)
        {
            Delete(ssn);
            _directorsDto.Add(dtoC);
            WriteArchive(_directorsDto);
            return dtoC;
        }

        private void WriteArchive(List<DirectorDto> classificationsDto)
        {
            StreamWriter stream = new StreamWriter("./Director.txt",true);
            foreach (DirectorDto dto in this._directorsDto)
            {
                string jsonString = JsonSerializer.Serialize(dto);
                stream.WriteLine(jsonString);
            }
            stream.Close();
        }
        

        public List<DirectorDto> LoadArchive()
        {
            var lines = File.ReadAllLines("./Director.txt");
            
            _directorsDto.Clear();
            DirectorDto dto;
            foreach (var line in lines)
            {
                try
                {
                    dto = JsonSerializer.Deserialize<DirectorDto>(line);
                
                    _directorsDto.Add(dto);
                    Console.WriteLine(dto.IdDirector);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return _directorsDto;
        }
}