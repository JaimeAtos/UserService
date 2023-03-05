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
    public class EmailEntityConfiguration : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.ConfigurationBase<Guid,Guid,Email>("Email");
            builder.Property(p => p.Id).HasDefaultValueSql("NEWID()");

            builder.HasOne(p => p.User).WithMany(p => p.Emails).HasForeignKey(p => p.Id);
        }
    }
}
