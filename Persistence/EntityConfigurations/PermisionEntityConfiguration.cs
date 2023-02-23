using Atos.EFCore.Extensions;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class PermisionEntityConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            /// Nombre de la tabla
            builder.ConfigurationBase<Guid, Guid, Permission>("Permission");
            builder.Property(p => p.Id).HasDefaultValueSql("NEWID()");

            builder.Property(x => x.Name).HasColumnType("varchar(64)").IsRequired();
            builder.Property(x => x.Description).HasColumnType("varchar(512)").IsRequired();
            builder.Property(x => x.Controller).HasColumnType("varchar(32)").IsRequired();
            builder.Property(x => x.Action).HasColumnType("varchar(32)").IsRequired();
        }
    }
}
