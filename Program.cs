var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
// =======================================================
// "BODY"

GameDto game = new GameDto(
    1, "Hello Kitty Online", "Simulation, RPG", 6000,
    new DateOnly(2009, 7, 1)
);

List<GameDto> games = [
    game,
    new (2, "World of Warcraft", "MMORPG", 12000, new DateOnly(2004, 11, 4))
];

//app.MapGet("/", () => "Hello World!");
// GET /games -> ÖSSZES
app.MapGet("/games", () => games);

// pl. 1 játék lekérése 
app.MapGet("/games/{id}", 
        (int id) => games.Find(games => games.Id == id));



// =======================================================
app.Run();
