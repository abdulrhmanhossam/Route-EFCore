namespace EFCore02.Entities;
public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime HiringDate { get; set; }
    public int? InstructorId { get; set; }
    public Instructor Instructor { get; set; } = null!;
    public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
    public ICollection<Student> Students { get; set; } = new HashSet<Student>();
}
