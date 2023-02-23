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
    public class RolePermissionEntityConfiguration : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.ConfigurationBase<Guid, Guid, RolePermission>("RolePermission");
            builder.Property(p => p.Id).HasDefaultValueSql("NEWID()");

            builder.Property(x => x.RoleName).HasColumnType("varchar(32)").IsRequired();

            builder.HasOne(x => x.Permission).WithMany(x => x.RolePermissions).HasForeignKey(x => x.PermissionId);
            builder.HasOne(x => x.User).WithMany(x => x.RolePermissions).HasForeignKey(x => x.UserId);
        }
    }
}
