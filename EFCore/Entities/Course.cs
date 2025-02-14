using EFCore.Entities;

namespace EFCore02.Entities;

public class Course
{
    public int Id { get; set; }
    public int Duration { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public int TopicId { get; set; }
    public Topic Topic { get; set; } = null!;
    public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
    public ICollection<CourseInstructor> CourseInstructors { get; set; } = new HashSet<CourseInstructor>();
}
