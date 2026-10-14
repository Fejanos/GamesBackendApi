var builder = WebApplication.CreateBuilder(args);

// DataAnnotations - [Required] és ezek...
builder.Services.AddValidation();


// Db string
var connString = "Data Source=GameStore.db";
builder.Services.AddSqlite<GameStoreContext>(connString);



var app = builder.Build();

// "BODY"

app.MapGamesEndpoints();

app.MigrateDb();

// =======================================================
app.Run();
