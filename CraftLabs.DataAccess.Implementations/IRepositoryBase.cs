namespace CraftLabs.DataAccess.Implementations
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> GetAll();
    }
}
