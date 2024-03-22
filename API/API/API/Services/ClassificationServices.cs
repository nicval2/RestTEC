using System.Text.Json;
using API.Models;

namespace API.Services;
public class ClassificationServices
{
    private List<ClassificationDto> _classificationDto = new List<ClassificationDto>();
    public ClassificationDto Save(ClassificationDto dtoC)
        {
            _classificationDto.Add(dtoC);
            WriteArchive(_classificationDto);
            return dtoC;
        }

        public ClassificationDto Element(int id)
        {
            _classificationDto = LoadArchive();
            int i = 0;
            ClassificationDto target = null;
            while (i<_classificationDto.Count())
            {
                if (_classificationDto.ElementAt(i).IdClassification == id)
                {
                    target = _classificationDto.ElementAt(i);
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
            _classificationDto = LoadArchive();
            return _classificationDto.Count();
        }

        public ClassificationDto Search(int id)
        {
            _classificationDto = LoadArchive();
            try
            {
                ClassificationDto target = null;
                foreach (ClassificationDto dto in _classificationDto)
                {
                    if (dto.IdClassification == id)
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
            _classificationDto = LoadArchive();
            var i = 0;
            while (i < _classificationDto.Count)
            {
                if (_classificationDto.ElementAt(i).IdClassification==id)
                {
                    _classificationDto.RemoveAt(i);
                    WriteArchive(_classificationDto);
                    break;
                }

                i++;
            }
        }

        public ClassificationDto Update(ClassificationDto dtoC, int ssn)
        {
            Delete(ssn);
            _classificationDto.Add(dtoC);
            WriteArchive(_classificationDto);
            return dtoC;
        }

        private void WriteArchive(List<ClassificationDto> classificationsDto)
        {
            StreamWriter stream = new StreamWriter("./Client.txt",true);
            foreach (ClassificationDto dto in this._classificationDto)
            {
                string jsonString = JsonSerializer.Serialize(dto);
                stream.WriteLine(jsonString);
            }
            stream.Close();
        }
        

        public List<ClassificationDto> LoadArchive()
        {
            var lines = File.ReadAllLines("./Client.txt");
            
            _classificationDto.Clear();
            ClassificationDto dto;
            foreach (var line in lines)
            {
                try
                {
                    dto = JsonSerializer.Deserialize<ClassificationDto>(line);
                
                    _classificationDto.Add(dto);
                    Console.WriteLine(dto.IdClassification);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return _classificationDto;
        }
}