namespace ScreenSound.Models;

internal class Rating
{
	public Rating(int rating)
	{
        Value = rating;
	}

	public int Value { get; }

	public static Rating Parse(string text)
	{
        int rating = int.Parse(text);
		return new Rating(rating);
    }
}

