using Atos.EFCore.Extensions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;


namespace Persistence.Context
{
    public class UserServiceDbContext : DbContext
    {
        public UserServiceDbContext([NotNull] DbContextOptions options) : base(options) { }

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

    }
}
