using System.Text.Json;

namespace CoreSchool.Models;

internal class Evaluation
{
	private float _score;

	public Guid Id { get; } = Guid.NewGuid();
	public required string Name { get; set; }
	public required Student Student { get; set; }
	public required Subject Subject { get; set; }
	public required float Score
	{
		get => _score;
		set
		{
			if (Convert.ToDecimal(value) is not (> 0 and < 10))
				throw new ArgumentException("Score must be between 0 and 10 (Decimal allowed).");

			if (value as decimal)
				Console.Write("A");

			_score = value;
		}
	}
}
