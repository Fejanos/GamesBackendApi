var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
// =======================================================
// "BODY"


app.MapGet("/", () => "Hello World!");



// =======================================================
app.Run();
