using EFCore02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Data.Configuration;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.HasKey(d => d.Id);

        builder
            .Property(d => d.Name)
            .HasColumnType("varchar")
            .HasMaxLength(100).IsRequired();

        builder.HasOne(d => d.Instructor)
            .WithMany(i => i.Departments)
            .HasForeignKey(d => d.InstructorId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
