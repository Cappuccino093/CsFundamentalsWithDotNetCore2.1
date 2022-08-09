using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace CoreSchool.Models;

internal class School
{
	internal required string Name { get; set; }
	internal required int CreationYear { get; set; }
	internal string Country { get; set; } = "Guatemala";
	internal string City { get; set; } = "Quetzaltenango";
	internal required SchoolType SchoolType { get; set; }
	internal required Course[] Courses { get; set; } = Array.Empty<Course>();

	public override string ToString() => JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
}
