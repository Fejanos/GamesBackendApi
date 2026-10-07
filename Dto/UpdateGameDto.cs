
using System.ComponentModel.DataAnnotations;

public record UpdateGameDto(
    [Required][StringLength(50)]string Name,
    [Required][StringLength(20)]string Genre,
    [Range(1, 50000)]int Price,
    DateOnly ReleaseDate
);