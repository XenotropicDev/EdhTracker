using EdhTracker.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor;

namespace EdhTracker.Pages;
public partial class GameDisplay : IDisposable
{
    protected override async Task OnInitializedAsync()
    {
        DataContext = await DataContextFactory.CreateDbContextAsync();
    }

    private DataContext DataContext;

    [Parameter]
    public Guid GameId { get; set; }

    [Inject]
    public IDbContextFactory<DataContext> DataContextFactory { get; set; }

    [Inject]
    public IDialogService DialogService { get; set; }

    public Game Game { get => DataContext.Games.Find(GameId)!; }

    public void Dispose()
    {
        DataContext.Dispose();
    }

    public void OpenAddGameDialog()
    {
        var options = new DialogOptions { CloseOnEscapeKey = true };
    }

}