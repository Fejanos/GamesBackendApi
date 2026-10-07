public static class GamesEndpoints
{
    // =======================================================
    const string GetGameEndpoint = "GetGame";
    // =======================================================

    private static readonly List<GameDto> games = [
        new (1, "Hello Kitty Online", "Simulation, RPG", 6000,new DateOnly(2009, 7, 1)),
        new (2, "World of Warcraft", "MMORPG", 12000, new DateOnly(2004, 11, 4))
    ];

    public static void MapGamesEndpoints(this WebApplication app)
    {
        
        // Útvonal csoport
        var group = app.MapGroup("/games");

        // GET /games -> ÖSSZES
        //app.MapGet("/games", () => games);
        group.MapGet("/", () => games);

        // pl. 1 játék lekérése 
        group.MapGet("/{id}", (int id) =>
        {
            var game = games.Find(game => game.Id == id);

            //if (game is null ){}
            // game null ? true : false
            return game is null ? Results.NotFound() : Results.Ok(game);

        }).WithName(GetGameEndpoint);

        // POST game
        group.MapPost("/", (CreateGameDto newGame) =>
        {
            // Új játék
            GameDto game = new (
                // id = lista számossága + 1
                games.Count + 1,
                newGame.Name,
                newGame.Genre,
                newGame.Price,
                newGame.ReleaseDate
            );

            // Listához adom
            games.Add(game);

            // Válasz
            return Results.CreatedAtRoute(GetGameEndpoint, new {id = game.Id}, game);
        });

        // PUT
        group.MapPut("/{id}", (int id, UpdateGameDto updatedGame) =>
        {
            var index = games.FindIndex(game => game.Id == id);

            if (index == -1)
            {
                return Results.NotFound();
            }

            games[index] = new GameDto (
                id,
                updatedGame.Name,
                updatedGame.Genre,
                updatedGame.Price,
                updatedGame.ReleaseDate
            );

            return Results.NoContent();
        });

        // DELETE
        group.MapDelete("/{id}", (int id) =>
        {
            games.RemoveAll(game => game.Id == id);

            return Results.NoContent();
        });
    }
}