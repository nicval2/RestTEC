using System.Text.Json;
using API.Models;

namespace API.Services;

public class MenuServices
{
    private List<Menu> _menuServices = new List<Menu>();
    public Menu Save(Menu M)
        {
            _menuServices.Add(M);
            WriteArchive(_menuServices);
            return M;
        }

    private void WriteArchive(List<Menu> menuServices)
    {
        throw new NotImplementedException();
    }

    public Menu Element(int id)
        {
            _menuServices = LoadArchive();
            int i = 0;
            Menu target = null;
            while (i<_menuServices.Count())
            {
                if (_menuServices.ElementAt(i).IdMenu == id)
                {
                    target = _menuServices.ElementAt(i);
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
            _menuServices = LoadArchive();
            return _menuServices.Count();
        }

        public Menu Search(int id)
        {
            _menuServices = LoadArchive();
            try
            {
                Menu target = null;
                foreach (Menu me in _menuServices)
                {
                    if (me.IdMenu == id)
                    {
                        return me ;
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
            _menuServices = LoadArchive();
            var i = 0;
            while (i < _menuServices.Count)
            {
                if (_menuServices.ElementAt(i).IdMenu==id)
                {
                    _menuServices.RemoveAt(i);
                    WriteArchive(_menuServices);
                    break;
                }

                i++;
            }
        }

        public Menu Update(Menu M, int ssn)
        {
            Delete(ssn);
            _menuServices.Add(M);
            WriteArchive(_menuServices);
            return M;
        }

        private void WriteArchive(List<TiposPlatos> classifications)
        {
            StreamWriter stream = new StreamWriter("./Menu.txt",true);
            foreach (Menu me in this._menuServices)
            {
                string jsonString = JsonSerializer.Serialize(me);
                stream.WriteLine(jsonString);
            }
            stream.Close();
        }
        

        public List<Menu> LoadArchive()
        {
            var lines = File.ReadAllLines("./Menu.txt");
            
            _menuServices.Clear();
            Menu me ;
            foreach (var line in lines)
            {
                try
                {
                    me = JsonSerializer.Deserialize<Menu>(line);
                
                    _menuServices.Add(me);
                    Console.WriteLine(me.IdMenu);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return _menuServices;
        }
}