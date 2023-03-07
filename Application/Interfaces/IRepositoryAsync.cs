using Atos.EFCore.Repository;
using System;

namespace Application.Interfaces
{
    public interface IRepositoryAsync : IRepositoryBase<Guid,Guid>
    {
    }
}
