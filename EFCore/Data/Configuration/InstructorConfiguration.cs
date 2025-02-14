using EFCore02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Data.Configuration;

public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
{

    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        builder.HasKey(i => i.Id);

        builder.Property(i => i.Name)
            .HasColumnType("varchar")
            .HasMaxLength(100).IsRequired();

        builder.Property(i => i.Address)
            .HasColumnType("varchar")
            .HasMaxLength(100);

        builder.HasOne(i => i.Department)
            .WithMany(d => d.Instructors)
            .HasForeignKey(i => i.DepartmentId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
