var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// "BODY"

app.MapGamesEndpoints();

// =======================================================
app.Run();
