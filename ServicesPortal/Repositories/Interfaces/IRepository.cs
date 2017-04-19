namespace ServicesPortal.Repositories.Interfaces
{
    /// <summary>
    /// Intefejs bazowy
    /// </summary>
    public interface IRepository<T>
    {
        void Add(T category);
        void Delete(T category);
        void SaveChanges();
    }
}
