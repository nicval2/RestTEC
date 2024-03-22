using System.Text.Json;
using API.Models;

namespace API.Services;

public class MovieServices
{
    private List<MovieDto> _moviesDto = new List<MovieDto>();
    public MovieDto Save(MovieDto dtoC)
        {
            _moviesDto.Add(dtoC);
            WriteArchive(_moviesDto);
            return dtoC;
        }

        public MovieDto Element(int id)
        {
            _moviesDto = LoadArchive();
            int i = 0;
            MovieDto target = null;
            while (i<_moviesDto.Count())
            {
                if (_moviesDto.ElementAt(i).IdMovie == id)
                {
                    target = _moviesDto.ElementAt(i);
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
            _moviesDto = LoadArchive();
            return _moviesDto.Count();
        }

        public MovieDto Search(int id)
        {
            _moviesDto = LoadArchive();
            try
            {
                MovieDto target = null;
                foreach (MovieDto dto in _moviesDto)
                {
                    if (dto.IdMovie == id)
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
            _moviesDto = LoadArchive();
            var i = 0;
            while (i < _moviesDto.Count)
            {
                if (_moviesDto.ElementAt(i).IdMovie==id)
                {
                    _moviesDto.RemoveAt(i);
                    WriteArchive(_moviesDto);
                    break;
                }

                i++;
            }
        }

        public MovieDto Update(MovieDto dtoC, int ssn)
        {
            Delete(ssn);
            _moviesDto.Add(dtoC);
            WriteArchive(_moviesDto);
            return dtoC;
        }

        private void WriteArchive(List<MovieDto> classificationsDto)
        {
            StreamWriter stream = new StreamWriter("./Movie.txt",true);
            foreach (MovieDto dto in this._moviesDto)
            {
                string jsonString = JsonSerializer.Serialize(dto);
                stream.WriteLine(jsonString);
            }
            stream.Close();
        }
        

        public List<MovieDto> LoadArchive()
        {
            var lines = File.ReadAllLines("./Movie.txt");
            
            _moviesDto.Clear();
            MovieDto dto;
            foreach (var line in lines)
            {
                try
                {
                    dto = JsonSerializer.Deserialize<MovieDto>(line);
                
                    _moviesDto.Add(dto);
                    Console.WriteLine(dto.IdMovie);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return _moviesDto;
        }
}