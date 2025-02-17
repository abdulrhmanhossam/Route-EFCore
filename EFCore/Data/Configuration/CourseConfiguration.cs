using EFCore02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Data.Configuration;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
            .HasColumnType("varchar")
            .HasMaxLength(100).IsRequired();

        builder.Property(c => c.Description)
            .HasColumnType("varchar")
            .HasMaxLength(500);

        builder.HasOne(c => c.Topic)
           .WithMany(t => t.Courses)
           .HasForeignKey(c => c.TopicId);
    }
}
