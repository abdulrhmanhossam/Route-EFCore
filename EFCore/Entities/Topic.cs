namespace EFCore02.Entities;
public class Topic
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
}
