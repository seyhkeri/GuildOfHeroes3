public class Game 
{
    private string _title = "Без названия";

    public string Title 
    {
        get { return _title; }
        private set 
        {
            if (string.IsNullOrWhiteSpace(value)) 
            {
                _title = "Без названия";
                return;
            }
            _title = value.Trim();
        }
    }

    public string Genre { get; private set; }
    public int ReleaseYear { get; private set; }
    public double Rating { get; private set; }

    public Game(string title, string genre, int releaseYear = 2026, double initialRating = 0.0) 
    {
        Title = title;
        Genre = string.IsNullOrWhiteSpace(genre) ? "Неизвестный жанр" : genre.Trim();
        
        ReleaseYear = releaseYear < 1950 ? 1950 : releaseYear;

        if (initialRating < 0.0) Rating = 0.0;
        else if (initialRating > 10.0) Rating = 10.0;
        else Rating = initialRating;
    }

    public void UpdateRating(double newRating) 
    {
        if (newRating < 0.0 || newRating > 10.0) 
        {
            return;
        }

        Rating = newRating;
    }
}