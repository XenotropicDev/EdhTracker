using EdhTracker.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
builder.Services.AddDbContextFactory<DataContext>();
builder.Services.AddControllersWithViews();

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

        group.Players.Add(new Player() { Name = "Dom" });

        tempContext.PlayGroups.Add(group);
        tempContext.SaveChanges();
    }
}