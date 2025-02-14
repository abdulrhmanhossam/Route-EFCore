using EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Data.Configuration;

public class CourseInstructorConfiguration : IEntityTypeConfiguration<CourseInstructor>
{
    public void Configure(EntityTypeBuilder<CourseInstructor> builder)
    {
        // Composite primary key
        builder.HasKey(ci => new { ci.InstructorId, ci.CourseId });

        // Configure Evaluate column
        builder.Property(ci => ci.Evaluate)
            .IsUnicode(false)
            .HasMaxLength(1000);

        // Relationships
        builder.HasOne(ci => ci.Instructor)
            .WithMany(i => i.CourseInstructors)
            .HasForeignKey(ci => ci.InstructorId);

        builder.HasOne(ci => ci.Course)
            .WithMany(c => c.CourseInstructors)
            .HasForeignKey(ci => ci.CourseId);
    }
}
