var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
// =======================================================
// "BODY"

GameDto game = new GameDto(
    1, "Hello Kitty Online", "Simulation, RPG", 6000,
    new DateOnly(2000, 10, 17)
);

List<GameDto> games = [
    game,
    new (2, "World of Warcraft", "MMORPG", 12000, new DateOnly(2004, 11, 4))
];

//app.MapGet("/", () => "Hello World!");
// GET /games
app.MapGet("/games", () => games);



// =======================================================
app.Run();
