using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructures.FluentAPIs
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne<Customer>(c => c.Customer)
                .WithMany(c => c.Users)
                .HasForeignKey(fk => fk.CustormerId);

            builder.HasOne<Seller>(c => c.Seller)
                .WithMany(c => c.Users)
                .HasForeignKey(fk => fk.SellerId);
        }
    }
}
