namespace Infrastructures
{
    public interface IUnitOfWork
    {
        public Task<int> SaveChangeAsync();
    }
}
