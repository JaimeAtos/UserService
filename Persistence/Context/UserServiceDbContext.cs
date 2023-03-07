using Application.Interfaces;
using Atos.EFCore.Extensions;
using Core.Commons;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;


namespace Persistence.Context
{
    public class UserServiceDbContext : DbContext
    {
        private readonly IDateTimeService _dateTime;

        public UserServiceDbContext([NotNull] DbContextOptions options, IDateTimeService dateTime) : base(options)
        {
            _dateTime=dateTime;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.RegisterEntityConfigurations<UserServiceDbContext>();
        }
        public DbSet<User> User { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<UserPermission> UserPermission { get; set; }
        public DbSet<RolePermission> RolePermission { get; set; }
        public DbSet<Email> Email { get; set; }

        //TODO: comentar a Daniel acerca de que este metodo forsozamente nos pide un int como retorno, en vez de un guid
        public override Task<int> SaveChangesAsync(CancellationToken cancellation = new CancellationToken())
        {
            //TODO: agregar despues la AuditableEntityBase
            foreach (var entry in base.ChangeTracker.Entries<Core.Commons.AppEntityBase<Guid, Guid>>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = _dateTime.NowUtc;
                        entry.Entity.State = true;
                        break;
                    //case EntityState.Modified:
                    //    break;
                    default:
                        break;
                }
            }
            return base.SaveChangesAsync(cancellation);
        }

    }
}
