var builder = WebApplication.CreateBuilder(args);

// DataAnnotations - [Required] és ezek...
builder.Services.AddValidation();

var app = builder.Build();

// "BODY"

app.MapGamesEndpoints();

// =======================================================
app.Run();
