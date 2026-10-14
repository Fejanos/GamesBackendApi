using Microsoft.EntityFrameworkCore;

public static class DataExtensions
{
    public static void MigrateDb(this WebApplication app)
    {
        var scope = app.Services.CreateScope();
        var DbContext = scope.ServiceProvider.GetService<GameStoreContext>();
        DbContext.Database.Migrate();
    }
}