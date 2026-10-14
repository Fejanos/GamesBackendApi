// Munkamenet az API és a DB között

using Microsoft.EntityFrameworkCore;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) 
: DbContext(options)
{
    //public GameStoreContext()
    // Set -> Halmaz -> NINCS duplikáció
    public DbSet<Game> Games => Set<Game>();
   
   /* public DbSet<Game> Games
    {
        get
        {
            return Set<Games>();
        }
    }
    */
    public DbSet<Genre> Genres => Set<Genre>();
}