using System.Text.Json;

namespace CoreSchool.Models;

internal class Course
{
	public Guid Id { get; }
	public required string Name { get; set; }
	public required Shift Shift { get; set; }

	public Course() => Id = Guid.NewGuid();

	public override string ToString() => JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
}
