namespace API.Models
{
    public class MovieDto
    {
        public int IdMovie { set; get; }
        
        public ClassificationDto IdClassification { set; get; }
        
        public DirectorDto IdDirector { set; get; }
        
        public ProtagonistDto IdProtagonist { set; get; }
        
        public string OriginalName { set; get; }
        
        public string CommercialName { set; get; }
        
        //public static Image Image { set; get; }

        public int RunTime { set; get; }
    }
}
