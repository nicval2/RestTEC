namespace API.Models
{
    public class ClientDto
    {
        public int Ssn { get; set; }
        
        public string Name { get; set; }
        
        public int CellPhone { get; set; }
        
        public string Email { get; set; }
        
        public DateTime BirthDate { get; set; }
        
        public string Direction {get; set;}
    }
}
