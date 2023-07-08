namespace ScreenSound.Models;

internal interface IRating
{
    void AddRating(Rating value);

    double Average { get; }
}

