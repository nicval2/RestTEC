namespace API.Models
{
    public class ProyectionDto
    {
        public int IdProyection { set; get; }
        
        public ScreenDto IdScreen { set; get; }
        
        public MovieDto IdMovie { set; get; }
        
        public DateTime Schedule { set; get; }
        
        public DateTime StartDate { set; get; }
        
        public DateTime EndDate { set; get; }
    }
}
