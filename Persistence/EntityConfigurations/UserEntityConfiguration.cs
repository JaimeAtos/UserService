using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
using Atos.EFCore.Extensions;
using static System.Net.Mime.MediaTypeNames;

namespace Persistence.EntityConfigurations
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ConfigurationBase<Guid, Guid, User>("Users");
            builder.Property(p => p.Id).HasDefaultValueSql("NEWID()");
            builder.Property(p => p.Name).HasColumnType("varchar(120)").IsRequired();
        }

        
    }
}
