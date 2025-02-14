using EFCore.Entities;

namespace EFCore02.Entities;
public class Instructor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Address { get; set; }
    public decimal HourRate { get; set; }
    public decimal Bouns { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;
    public ICollection<Department> Departments { get; set; } = new HashSet<Department>();
    public ICollection<CourseInstructor> CourseInstructors { get; set; } = new HashSet<CourseInstructor>();
}
