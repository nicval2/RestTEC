using System.Text.Json;
using API.Models;

namespace API.Services;

public class ClientServices
{
    private List<ClientDto> _clientsDto = new List<ClientDto>();

        public ClientDto Save(ClientDto dtoC)
        {
            _clientsDto.Add(dtoC);
            WriteArchive(_clientsDto);
            return dtoC;
        }

        public ClientDto Element(int ssn)
        {
            _clientsDto = LoadArchive();
            int i = 0;
            ClientDto target = null;
            while (i<_clientsDto.Count())
            {
                if (_clientsDto.ElementAt(i).Ssn == ssn)
                {
                    target = _clientsDto.ElementAt(i);
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
            _clientsDto = LoadArchive();
            return _clientsDto.Count();
        }

        public ClientDto Search(int pos)
        {
            _clientsDto = LoadArchive();
            try
            {
                ClientDto target = null;
                foreach (ClientDto dto in _clientsDto)
                {
                    if (dto.Ssn == pos)
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

        public void Delete(int ssn)
        {
            _clientsDto = LoadArchive();
            var i = 0;
            while (i < _clientsDto.Count)
            {
                if (_clientsDto.ElementAt(i).Ssn==ssn)
                {
                    _clientsDto.RemoveAt(i);
                    WriteArchive(_clientsDto);
                    break;
                }

                i++;
            }
        }

        public ClientDto Update(ClientDto dtoC, int ssn)
        {
            Delete(ssn);
            _clientsDto.Add(dtoC);
            WriteArchive(_clientsDto);
            return dtoC;
        }

        public int Age(ClientDto dtoC)
        {
            DateTime today = DateTime.Today;
            DateTime bDay = dtoC.BirthDate;
            TimeSpan dif = today.Subtract(bDay);
            DateTime firstDay = new DateTime(1, 1, 1);
            int age = (firstDay + dif).Year - 1;
            return age;
        }

        private void WriteArchive(List<ClientDto> clientsDto)
        {
            StreamWriter stream = new StreamWriter("./Client.txt",true);
            foreach (ClientDto dto in this._clientsDto)
            {
                string jsonString = JsonSerializer.Serialize(dto);
                stream.WriteLine(jsonString);
            }
            stream.Close();
        }
        

        public List<ClientDto> LoadArchive()
        {
            var lines = File.ReadAllLines("./Client.txt");
            
            _clientsDto.Clear();
            ClientDto dto;
            foreach (var line in lines)
            {
                try
                {
                    dto = JsonSerializer.Deserialize<ClientDto>(line);
                
                    _clientsDto.Add(dto);
                    Console.WriteLine(dto.Ssn);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return _clientsDto;
        }
}