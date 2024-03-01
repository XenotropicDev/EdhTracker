using Microsoft.EntityFrameworkCore;

namespace EdhTracker.Data;

public class DataContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Application.db");
    }

    public DbSet<Player> Players { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Deck> Decks { get; set; }
    public DbSet<PlayGroup> Pods { get; set; }
}

public record Player
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}

public record Game
{
    public Guid Id { get; set; }
    public List<PlayerSeat> Seats { get; set; } = new List<PlayerSeat>();
    public DateTime PlayTime { get; set; }
}

public record Deck
{
    public Guid Id { get; set; }
    public Commander Commander { get; set; }
    public Player Player { get; set; }
    public string? Archetype { get; set; }
    public string? ColorIdentity { get; set; }
    public Uri? Decklist { get; set; }
    public Uri? Icon { get; set; }
}

public record Commander
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Card> Commanders { get; set; } = new();
}
public record Card
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public Uri? Scryfall { get; set; }
}

public record PlayerSeat
{
    public Guid Id { get; set; }
    public GameResult? Result { get; set; }
    public Deck Deck { get; set; }
    public Player Pilot { get; set; }
}

public record PlayGroup
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<Game> GameHistory { get; set; } = new();

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
