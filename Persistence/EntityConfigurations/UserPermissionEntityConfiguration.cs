using Atos.EFCore.Extensions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations
{
    public class UserPermissionEntityConfiguration : IEntityTypeConfiguration<UserPermission>
    {
        //Todo: Lograr que las llaves sean identidad 1:1
        public void Configure(EntityTypeBuilder<UserPermission> builder)
        {
            builder.ConfigurationBase<Guid, Guid, UserPermission>("UserPermissions");
            builder.Property(p => p.Id).HasDefaultValueSql("NEWID()");

            builder.HasOne(x => x.Permission).WithMany(x => x.UserPermission).HasForeignKey(x => x.PermissionId);
            builder.HasOne(x => x.User).WithMany(x => x.UserPermissions).HasForeignKey(x => x.UserId);
        }
    }
}
