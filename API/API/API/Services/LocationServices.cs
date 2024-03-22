using System.Text.Json;
using API.Models;

namespace API.Services;

public class LocationServices
{
    private List<LocationDto> _locationsDto = new List<LocationDto>();
    public LocationDto Save(LocationDto dtoC)
        {
            _locationsDto.Add(dtoC);
            WriteArchive(_locationsDto);
            Console.WriteLine("Conectado");
            return dtoC;
        }

        public LocationDto Element(int id)
        {
            _locationsDto = LoadArchive();
            int i = 0;
            LocationDto target = null;
            while (i<_locationsDto.Count())
            {
                if (_locationsDto.ElementAt(i).IdLocation == id)
                {
                    target = _locationsDto.ElementAt(i);
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
            _locationsDto = LoadArchive();
            return _locationsDto.Count();
        }

        public LocationDto Search(int id)
        {
            _locationsDto = LoadArchive();
            try
            {
                LocationDto target = null;
                foreach (LocationDto dto in _locationsDto)
                {
                    if (dto.IdLocation == id)
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
            _locationsDto = LoadArchive();
            var i = 0;
            while (i < _locationsDto.Count)
            {
                if (_locationsDto.ElementAt(i).IdLocation==id)
                {
                    _locationsDto.RemoveAt(i);
                    WriteArchive(_locationsDto);
                    break;
                }

                i++;
            }
        }

        public LocationDto Update(LocationDto dtoC, int ssn)
        {
            Delete(ssn);
            _locationsDto.Add(dtoC);
            WriteArchive(_locationsDto);
            return dtoC;
        }

        private void WriteArchive(List<LocationDto> classificationsDto)
        {
            StreamWriter stream = new StreamWriter("./Location.txt",true);
            foreach (LocationDto dto in this._locationsDto)
            {
                string jsonString = JsonSerializer.Serialize(dto);
                stream.WriteLine(jsonString);
            }
            stream.Close();
        }
        

        public List<LocationDto> LoadArchive()
        {
            var lines = File.ReadAllLines("./Location.txt");
            
            _locationsDto.Clear();
            LocationDto dto;
            foreach (var line in lines)
            {
                try
                {
                    dto = JsonSerializer.Deserialize<LocationDto>(line);
                
                    _locationsDto.Add(dto);
                    Console.WriteLine(dto.IdLocation);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return _locationsDto;
        }
}