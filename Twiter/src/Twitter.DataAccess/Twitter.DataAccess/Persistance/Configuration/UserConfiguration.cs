using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Twitters.Core.Enitites;

namespace Twitter.DataAccess.Persistance.Configuration
{
    public  class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(ti => ti.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(ti => ti.Name)
                .HasMaxLength(1000)
                .IsRequired();
        }
    }
}
