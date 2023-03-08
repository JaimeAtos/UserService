using Ardalis.Specification.EntityFrameworkCore;
using Application.Interfaces;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class ArdalisRepositoryAsync<T> : RepositoryBase<T>, IArdalisRepositoryAsync<T> where T : class
    {
        private readonly UserServiceDbContext _dbContext;

        public ArdalisRepositoryAsync(UserServiceDbContext dbContext) : base(dbContext)
        {
            _dbContext=dbContext;
        }
    }
}
