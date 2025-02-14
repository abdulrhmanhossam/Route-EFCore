using EFCore.Entities;

namespace EFCore02.Entities;
public class Student
{
    public int Id { get; set; }
    public string FName { get; set; }    
    public string LName { get; set; }    
    public string Address { get; set; }    
    public int Age { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;
    public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
}
