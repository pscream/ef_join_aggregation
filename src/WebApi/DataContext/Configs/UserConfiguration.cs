using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApi.Models.Database;

namespace WebApi.DataContext.Configs
{

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {


        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.ToTable("Users");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.UserName).HasColumnType("nvarchar(50)");

        }

    }

}