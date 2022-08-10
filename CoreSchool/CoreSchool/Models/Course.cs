using System.Text.Json;

namespace CoreSchool.Models;

public class Course
{
	public Guid Id { get; } = Guid.NewGuid();
	public required string Name { get; set; }
	public required Shift Shift { get; set; }
	public Subject[] Subjects { get; set; } = Array.Empty<Subject>();
	public Student[] Students { get; set; } = Array.Empty<Student>(); 
}
