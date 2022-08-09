namespace School;

class School
{
	internal string? name;
	internal string? address;
	internal int? fundationAge;
	internal string? ceo = "Freddy Vega";

	internal static void Ring() => Console.Beep();
}

class Program
{
	static void Main()
	{
		School school = new();
		school.name = "Platzi Academy";
		school.address = "Internet";
		school.fundationAge = 2002;
		School.Ring();
	}
}