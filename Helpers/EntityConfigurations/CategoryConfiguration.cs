using fronttaskApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace fronttaskApi.Helpers.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
    
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(m => m.Name)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
