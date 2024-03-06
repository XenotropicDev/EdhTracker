using Microsoft.EntityFrameworkCore;

namespace EdhTracker.Data;

public class DataContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Application.db")
            .UseLazyLoadingProxies();
    }

    public DbSet<Player> Players { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Deck> Decks { get; set; }
    public DbSet<PlayGroup> PlayGroups { get; set; }
}

public record Player
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public virtual PlayGroup PlayGroup { get; set; }
}

public record Game
{
    public Guid Id { get; set; }
    public virtual List<PlayerSeat> Seats { get; set; } = new List<PlayerSeat>();
    public DateTime PlayTime { get; set; } = DateTime.Now;
}

public record Deck
{
    public Deck()
    {
        Commander = new();    
    }

    public Guid Id { get; set; }
    public virtual Commander Commander { get; set; }
    public virtual Player Player { get; set; }
    public string? Archetype { get; set; }
    public string? ColorIdentity { get; set; }
    public Uri? Decklist { get; set; }
    public Uri? Icon { get; set; }
}

public record Commander
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public virtual List<Card> Commanders { get; set; } = new();
    public virtual List<Deck> Decks { get; set; } = new();
}

public record Card
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public Uri? Scryfall { get; set; }
    public Uri? ImageUri { get; set; }
}

public record PlayerSeat
{
    public Guid Id { get; set; }
    public GameResult? Result { get; set; }
    public virtual Deck Deck { get; set; }
    public virtual Player Pilot { get; set; }
}

public record PlayGroup
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public virtual List<Game> GameHistory { get; set; } = new();
    public virtual List<Deck> Decks { get; set; } = new();
    public virtual List<Player> Players { get; set; } = new();

    public override string ToString()
    {
        return Name;
    }
}

public enum GameResult
{
    Win,
    Loss,
    Draw
}
