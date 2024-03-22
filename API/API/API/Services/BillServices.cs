using System.Text.Json;
using API.Models;

namespace API.Services;

public class BillServices
{
    private List<BillDto> _billsDto = new List<BillDto>();
    
    public BillDto Save(BillDto dtoC)
        {
            _billsDto.Add(dtoC);
            WriteArchive(_billsDto);
            return dtoC;
        }

        public BillDto Element(int id)
        {
            _billsDto = LoadArchive();
            int i = 0;
            BillDto target = null;
            while (i<_billsDto.Count())
            {
                if (_billsDto.ElementAt(i).IdBill == id)
                {
                    target = _billsDto.ElementAt(i);
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
            _billsDto = LoadArchive();
            return _billsDto.Count();
        }

        public BillDto Search(int id)
        {
            _billsDto = LoadArchive();
            try
            {
                BillDto target = null;
                foreach (BillDto dto in _billsDto)
                {
                    if (dto.IdBill == id)
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
            _billsDto = LoadArchive();
            var i = 0;
            while (i < _billsDto.Count)
            {
                if (_billsDto.ElementAt(i).IdBill==id)
                {
                    _billsDto.RemoveAt(i);
                    WriteArchive(_billsDto);
                    break;
                }

                i++;
            }
        }

        public BillDto Update(BillDto dtoC, int ssn)
        {
            Delete(ssn);
            _billsDto.Add(dtoC);
            WriteArchive(_billsDto);
            return dtoC;
        }

        public int Total(BillDto dto)
        {
            return dto.Price * dto.NumSeats;
        }

        private void WriteArchive(List<BillDto> classificationsDto)
        {
            StreamWriter stream = new StreamWriter("./Bill.txt",true);
            foreach (BillDto dto in this._billsDto)
            {
                string jsonString = JsonSerializer.Serialize(dto);
                stream.WriteLine(jsonString);
            }
            stream.Close();
        }
        

        public List<BillDto> LoadArchive()
        {
            var lines = File.ReadAllLines("./Bill.txt");
            
            _billsDto.Clear();
            BillDto dto;
            foreach (var line in lines)
            {
                try
                {
                    dto = JsonSerializer.Deserialize<BillDto>(line);
                
                    _billsDto.Add(dto);
                    Console.WriteLine(dto.IdBill);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return _billsDto;
        }
}