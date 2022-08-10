﻿using System.Text.Json;

namespace CoreSchool.Models;

public class Student
{
	public Guid Id { get; } = Guid.NewGuid();
	public required string Name { get; set; }
}
