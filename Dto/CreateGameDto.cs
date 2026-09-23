
public record CreateGameDto(
    string Name,
    string Genre,
    int Price,
    DateOnly ReleaseDate
);