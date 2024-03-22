using System.Text.Json;
using API.Models;

namespace API.Services;

public class ProtagonistServices
{
    private List<ProtagonistDto> _protagonistsDto = new List<ProtagonistDto>();
    public ProtagonistDto Save(ProtagonistDto dtoC)
        {
            _protagonistsDto.Add(dtoC);
            WriteArchive(_protagonistsDto);
            return dtoC;
        }

        public ProtagonistDto Element(int id)
        {
            _protagonistsDto = LoadArchive();
            int i = 0;
            ProtagonistDto target = null;
            while (i<_protagonistsDto.Count())
            {
                if (_protagonistsDto.ElementAt(i).IdProtagonist == id)
                {
                    target = _protagonistsDto.ElementAt(i);
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
            _protagonistsDto = LoadArchive();
            return _protagonistsDto.Count();
        }

        public ProtagonistDto Search(int id)
        {
            _protagonistsDto = LoadArchive();
            try
            {
                ProtagonistDto target = null;
                foreach (ProtagonistDto dto in _protagonistsDto)
                {
                    if (dto.IdProtagonist == id)
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
            _protagonistsDto = LoadArchive();
            var i = 0;
            while (i < _protagonistsDto.Count)
            {
                if (_protagonistsDto.ElementAt(i).IdProtagonist==id)
                {
                    _protagonistsDto.RemoveAt(i);
                    WriteArchive(_protagonistsDto);
                    break;
                }

                i++;
            }
        }

        public ProtagonistDto Update(ProtagonistDto dtoC, int ssn)
        {
            Delete(ssn);
            _protagonistsDto.Add(dtoC);
            WriteArchive(_protagonistsDto);
            return dtoC;
        }

        private void WriteArchive(List<ProtagonistDto> classificationsDto)
        {
            StreamWriter stream = new StreamWriter("./Protagonist.txt",true);
            foreach (ProtagonistDto dto in this._protagonistsDto)
            {
                string jsonString = JsonSerializer.Serialize(dto);
                stream.WriteLine(jsonString);
            }
            stream.Close();
        }
        

        public List<ProtagonistDto> LoadArchive()
        {
            var lines = File.ReadAllLines("./Protagonist.txt");
            
            _protagonistsDto.Clear();
            ProtagonistDto dto;
            foreach (var line in lines)
            {
                try
                {
                    dto = JsonSerializer.Deserialize<ProtagonistDto>(line);
                
                    _protagonistsDto.Add(dto);
                    Console.WriteLine(dto.IdProtagonist);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return _protagonistsDto;
        }
}