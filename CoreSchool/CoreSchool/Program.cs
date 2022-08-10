using CoreSchool.Models;

School school = new()
{
	Name = "Platzi",
	CreationYear = 2002,
	SchoolType = SchoolType.Elementary,
	Courses = new Course[]
	{
		new()
		{
			Name = "101",
			Shift = Shift.Morning
		},
		new()
		{
			Name = "102",
			Shift = Shift.Evening
		},
		new()
		{
			Name = "103",
			Shift = Shift.Night
		}
	}
};

Console.WriteLine("School:");
Console.WriteLine(school);
Console.WriteLine("\nCourses:");
foreach (Course course in school.Courses)
{
	Console.WriteLine(course);
}
