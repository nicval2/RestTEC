using System.Text.Json;
using API.Models;

namespace API.Services;

public class ScreenServices
{
    private List<ScreenDto> _screensDto = new List<ScreenDto>();
    public ScreenDto Save(ScreenDto dtoC)
        {
            _screensDto.Add(dtoC);
            WriteArchive(_screensDto);
            return dtoC;
        }

        public ScreenDto Element(int id)
        {
            _screensDto = LoadArchive();
            int i = 0;
            ScreenDto target = null;
            while (i<_screensDto.Count())
            {
                if (_screensDto.ElementAt(i).IdScreen == id)
                {
                    target = _screensDto.ElementAt(i);
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
            _screensDto = LoadArchive();
            return _screensDto.Count();
        }

        public ScreenDto Search(int id)
        {
            _screensDto = LoadArchive();
            try
            {
                ScreenDto target = null;
                foreach (ScreenDto dto in _screensDto)
                {
                    if (dto.IdScreen == id)
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
            _screensDto = LoadArchive();
            var i = 0;
            while (i < _screensDto.Count)
            {
                if (_screensDto.ElementAt(i).IdScreen==id)
                {
                    _screensDto.RemoveAt(i);
                    WriteArchive(_screensDto);
                    break;
                }

                i++;
            }
        }

        public ScreenDto Update(ScreenDto dtoC, int ssn)
        {
            Delete(ssn);
            _screensDto.Add(dtoC);
            WriteArchive(_screensDto);
            return dtoC;
        }

        public int Capacity(ScreenDto dto)
        {
            return dto.Column * dto.Row;
        }

        private void WriteArchive(List<ScreenDto> classificationsDto)
        {
            StreamWriter stream = new StreamWriter("./Screen.txt",true);
            foreach (ScreenDto dto in this._screensDto)
            {
                string jsonString = JsonSerializer.Serialize(dto);
                stream.WriteLine(jsonString);
            }
            stream.Close();
        }
        

        public List<ScreenDto> LoadArchive()
        {
            var lines = File.ReadAllLines("./Screen.txt");
            
            _screensDto.Clear();
            ScreenDto dto;
            foreach (var line in lines)
            {
                try
                {
                    dto = JsonSerializer.Deserialize<ScreenDto>(line);
                
                    _screensDto.Add(dto);
                    Console.WriteLine(dto.IdScreen);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return _screensDto;
        }
}