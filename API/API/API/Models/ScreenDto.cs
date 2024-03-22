namespace API.Models
{
    public class ScreenDto
    {
        public int IdScreen { get; set; }
        public string Name { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public int Capacity { get; set; }
        public ProyectionDto ProyectionDto { get; set; }
        public LocationDto LocationDto { get; set; }


    }
}
