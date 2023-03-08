using Ardalis.Specification;
using Atos.EFCore.Repository;

namespace Application.Interfaces
{
    public interface IRepositoryAsync : IRepositoryBase<Guid, Guid>
    {
    }
    
}
