using System.Text.Json;
using CoreSchool.Controllers;

SchoolController schoolController = new();
Console.WriteLine("School:");
Console.WriteLine(JsonSerializer.Serialize(schoolController, new JsonSerializerOptions { WriteIndented = true }));
