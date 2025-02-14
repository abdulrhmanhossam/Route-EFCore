using EFCore02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Data.Configuration;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(s => s.Id);

        builder
            .Property(s => s.FName)
            .HasColumnType("varchar")
            .HasMaxLength(50).IsRequired();

        builder
            .Property(s => s.LName)
            .HasColumnType("varchar")
            .HasMaxLength(50).IsRequired();

        builder
            .Property(s => s.Address)
            .HasColumnType("varchar")
            .HasMaxLength(255);

        builder
            .HasOne(s => s.Department)
            .WithMany(d => d.Students)
            .HasForeignKey(s => s.DepartmentId);
    }
}
