using System.Text.Json;
using API.Models;

namespace API.Services;

public class TiposPlatosServices
{
    private List<TiposPlatos> _TiposPlatosServices = new List<TiposPlatos>();
    public TiposPlatos Save(TiposPlatos C)
        {
            _TiposPlatosServices.Add(C);
            WriteArchive(_TiposPlatosServices);
            return C;
        }

        public TiposPlatos Element(int id)
        {
            _TiposPlatosServices = LoadArchive();
            int i = 0;
            TiposPlatos target = null;
            while (i<_TiposPlatosServices.Count())
            {
                if (_TiposPlatosServices.ElementAt(i).IdTipos == id)
                {
                    target = _TiposPlatosServices.ElementAt(i);
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
            _TiposPlatosServices = LoadArchive();
            return _TiposPlatosServices.Count();
        }

        public TiposPlatos Search(int id)
        {
            _TiposPlatosServices = LoadArchive();
            try
            {
                TiposPlatos target = null;
                foreach (TiposPlatos pl in _TiposPlatosServices)
                {
                    if (pl.IdTipos == id)
                    {
                        return pl ;
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
            _TiposPlatosServices = LoadArchive();
            var i = 0;
            while (i < _TiposPlatosServices.Count)
            {
                if (_TiposPlatosServices.ElementAt(i).IdTipos==id)
                {
                    _TiposPlatosServices.RemoveAt(i);
                    WriteArchive(_TiposPlatosServices);
                
                    break;
                }

                i++;
            }
        }

        public TiposPlatos Update(TiposPlatos C, int ssn)
        {
            Delete(ssn);
            _TiposPlatosServices.Add(C);
            WriteArchive(_TiposPlatosServices);
            return C;
        }

        private void WriteArchive(List<TiposPlatos> TiposPlatosServices)
        {
            StreamWriter stream = new StreamWriter("./TiposPlatos.txt",true);
            foreach (TiposPlatos pl in this._TiposPlatosServices)
            {
                string jsonString = JsonSerializer.Serialize(pl);
                stream.WriteLine(jsonString);
            }
            stream.Close();
        }
        

        public List<TiposPlatos> LoadArchive()
        {
            var lines = File.ReadAllLines("./TiposPlatos.txt");
            
            _TiposPlatosServices.Clear();
            TiposPlatos pl ;
            foreach (var line in lines)
            {
                try
                {
                    pl = JsonSerializer.Deserialize<TiposPlatos>(line);
                
                    _TiposPlatosServices.Add(pl);
                    Console.WriteLine(pl.IdTipos);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return _TiposPlatosServices;
        }
}