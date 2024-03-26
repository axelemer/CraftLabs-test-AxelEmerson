
namespace CraftLabs.DataAccess.Implementations
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public abstract IQueryable<T> GetAll();
    }
}
