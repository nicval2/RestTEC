namespace API.Models
{
    public class Menu
    {
        public int IdMenu { set; get; }
        
        public string Nombre_Menu { set; get; }
        
        public double Precio { set; get; }
        
        public int Calorias {set; get;}

        public TiposPlatos IDTipoPlato {set; get;}
        
        
    }
}
