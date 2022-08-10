using System.Text.Json;

namespace CoreSchool.Models;

public class School
{
	public Guid Id { get; } = Guid.NewGuid();
	public required string Name { get; set; }
	public required int CreationYear { get; set; }
	public string Country { get; set; } = "Guatemala";
	public string City { get; set; } = "Quetzaltenango";
	public required SchoolType SchoolType { get; set; }
	public required Course[] Courses { get; set; } = Array.Empty<Course>();
}
