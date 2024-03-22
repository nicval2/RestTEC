using System.Text.Json;
using API.Models;

namespace API.Services;

public class ProyectionServices
{
    private List<ProyectionDto> _proyectionsDto = new List<ProyectionDto>();
    public ProyectionDto Save(ProyectionDto dtoC)
        {
            _proyectionsDto.Add(dtoC);
            WriteArchive(_proyectionsDto);
            return dtoC;
        }

        public ProyectionDto Element(int id)
        {
            _proyectionsDto = LoadArchive();
            int i = 0;
            ProyectionDto target = null;
            while (i<_proyectionsDto.Count())
            {
                if (_proyectionsDto.ElementAt(i).IdProyection == id)
                {
                    target = _proyectionsDto.ElementAt(i);
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
            _proyectionsDto = LoadArchive();
            return _proyectionsDto.Count();
        }

        public ProyectionDto Search(int id)
        {
            _proyectionsDto = LoadArchive();
            try
            {
                ProyectionDto target = null;
                foreach (ProyectionDto dto in _proyectionsDto)
                {
                    if (dto.IdProyection == id)
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
            _proyectionsDto = LoadArchive();
            var i = 0;
            while (i < _proyectionsDto.Count)
            {
                if (_proyectionsDto.ElementAt(i).IdProyection==id)
                {
                    _proyectionsDto.RemoveAt(i);
                    WriteArchive(_proyectionsDto);
                    break;
                }

                i++;
            }
        }

        public ProyectionDto Update(ProyectionDto dtoC, int ssn)
        {
            Delete(ssn);
            _proyectionsDto.Add(dtoC);
            WriteArchive(_proyectionsDto);
            return dtoC;
        }

        private void WriteArchive(List<ProyectionDto> classificationsDto)
        {
            StreamWriter stream = new StreamWriter("./Proyection.txt",true);
            foreach (ProyectionDto dto in this._proyectionsDto)
            {
                string jsonString = JsonSerializer.Serialize(dto);
                stream.WriteLine(jsonString);
            }
            stream.Close();
        }
        

        public List<ProyectionDto> LoadArchive()
        {
            var lines = File.ReadAllLines("./Proyection.txt");
            
            _proyectionsDto.Clear();
            ProyectionDto dto;
            foreach (var line in lines)
            {
                try
                {
                    dto = JsonSerializer.Deserialize<ProyectionDto>(line);
                
                    _proyectionsDto.Add(dto);
                    Console.WriteLine(dto.IdProyection);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return _proyectionsDto;
        }
}