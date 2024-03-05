using EdhTracker.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor;

namespace EdhTracker.Pages;

public partial class PlayGroupDisplay : IDisposable
{
    public void Dispose()
    {
        DataContext.Dispose();
    }
}