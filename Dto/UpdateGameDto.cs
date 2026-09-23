
public record UpdateGameDto(
    string Name,
    string Genre,
    int Price,
    DateOnly ReleaseDate
);