using EFCore02.Entities;

namespace EFCore.Entities;

public class StudentCourse
{
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public int Grade { get; set; }
    public Student Student { get; set; } = null!;
    public Course Course { get; set; } = null!;
}
