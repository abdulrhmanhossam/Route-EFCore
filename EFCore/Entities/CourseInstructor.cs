using EFCore02.Entities;

namespace EFCore.Entities;

public class CourseInstructor
{
    public int InstructorId { get; set; }
    public int CourseId { get; set; }
    public string Evaluate { get; set; }
    public Instructor Instructor { get; set; } = null!;
    public Course Course { get; set; } = null!;
}
