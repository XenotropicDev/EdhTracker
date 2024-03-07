using EdhTracker.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using MudBlazor.Services;
using Serilog;
using Serilog.Settings.Configuration;

var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
builder.Services.AddDbContextFactory<DataContext>();
builder.Services.AddControllersWithViews();

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Services.AddLogging(lb => lb.AddSerilog(dispose: true));

var app = builder.Build();

SetupDb();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

static void SetupDb()
{
    var tempContext = new DataContext();
    //tempContext.Database.EnsureDeleted();
    tempContext.Database.EnsureCreated();

    if (!tempContext.PlayGroups.Any())
    {
        var group = new PlayGroup() { Name = "Test Group", Id = Guid.Parse("da65fcf4-4b9c-4f0f-ae08-a5e25ddc42bd") };

        var p1 = new Player() { Name = "Dom" };
        var p2 = new Player() { Name = "Matt" };
        var p3 = new Player() { Name = "Griffin" };
        var p4 = new Player() { Name = "Reti" };

        group.Players.Add(p1);
        group.Players.Add(p2);
        group.Players.Add(p3);
        group.Players.Add(p4);

        //group.Decks.Add(new Deck() { Player = p1, Commander = new Commander { Name = "Wrexial" } });
        //group.Decks.Add(new Deck() { Player = p2, Commander = new Commander { Name = "Magada" } });
        //group.Decks.Add(new Deck() { Player = p3, Commander = new Commander { Name = "Sharuum" } });
        //group.Decks.Add(new Deck() { Player = p4, Commander = new Commander { Name = "Korvold" } });

        //var game = new Game { Seats = [
        //    new() { Deck = group.Decks[0], Result = GameResult.Win }, 
        //    new() { Deck = group.Decks[1], Result = GameResult.Loss },
        //    new() { Deck = group.Decks[2], Result = GameResult.Loss },
        //    new() { Deck = group.Decks[3], Result = GameResult.Loss }
        //]};
        //group.GameHistory.Add(game);

        tempContext.PlayGroups.Add(group);
        tempContext.SaveChanges();
    }
}