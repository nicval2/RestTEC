namespace API.Repository
{
    public interface DataManager
    {
        IEnumerable<T>LoadData<T>(string file);
        void Save<T>(IEnumerable<T> data, string fileName);
        void Add<T>(T newObject, string fileName);
        void Delete<T>(IEnumerable<T> data, Func<T, bool> predicate, string fileName);
        void Update<T>(T updatedObject, Func<T, bool> predicate, string fileName);
    }
}
