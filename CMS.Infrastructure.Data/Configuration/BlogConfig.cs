using CMS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Infrastructure.Data.Configuration
{
    internal class BlogConfig : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(x => x.CreateDateTime)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder.HasMany(x => x.Tags)
                .WithMany(x => x.Blogs)
                .UsingEntity("BlogTag");
        }
    }
}
