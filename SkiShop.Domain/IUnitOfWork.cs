namespace SkiShop.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> CompleteAsync();
    }
}
