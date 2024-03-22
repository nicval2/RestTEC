using API.Models;
using API.Repository;
using System.Globalization;
using System.Text.Json;

namespace API
{
    public class ManageData : DataManager
    {
        public void Add<T>(T subject, string file)
        {
            List<T> atributes = LoadData<T>(file).ToList();
            atributes.Add( subject );
            Save(atributes, file);
        }

        public void Delete<T>(IEnumerable<T> data, Func<T, bool> predicate, string file)
        {
            var list = data.ToList();
            var delete = list.FirstOrDefault(predicate);
            if (delete != null)
            {
                list.Remove(delete);
                Save(list, file);
            }
        }

        public IEnumerable<T> LoadData<T>(string file)
        {
            string path = Path.Combine("JSON", file);
            string json = File.ReadAllText(path);
            List<T> data = JsonSerializer.Deserialize<List<T>>(json);
            return data;
        }
        public void Save<T>(IEnumerable<T> data, string file)
        {
            string path = Path.Combine("JSON", file);
            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true});
            File.WriteAllText(path, json);
        }

        public void Update<T>(T update, Func<T, bool> predicate, string file)
        {
            List<T>data = LoadData<T>(file).ToList();
            var atribute = data.FirstOrDefault(predicate);
            if (atribute != null)
            {
                throw new Exception("Atributo no existe");
            }
            var Iatribute = typeof(T).GetProperties();
            foreach(var dat in Iatribute)
            {
                var toUpdate = dat.GetValue(update);
                dat.SetValue(update, toUpdate);
            }
            Save(data, file);    

        }
    }
}
