using Ardalis.Specification;

namespace Application.Interfaces
{
    public interface IArdalisRepositoryAsync<T> : IRepositoryBase<T> where T : class
    {
    }
    public interface IArdalisReadRepositoryAsync<T> : IReadRepositoryBase<T> where T : class
    {
    }
}
