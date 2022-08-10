using System.Text.Json;

namespace CoreSchool.Models;

public class Subject
{
	public Guid Id { get; } = Guid.NewGuid();
	public required string Name { get; set; }
}
