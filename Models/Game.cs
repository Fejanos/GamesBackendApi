public class Game
{
    // Tulajdonságok
    public int Id { get; set; }
    public required string Name { get; set; } // KÖTELEZŐ - not null
    public Genre? Genre { get; set; } // nullable
    public int GenreId { get; set; } // FK
    public int Price { get; set; }
    public DateOnly ReleaseDate { get; set; }
}