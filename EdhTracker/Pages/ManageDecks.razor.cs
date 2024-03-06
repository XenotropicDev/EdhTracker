namespace EdhTracker.Pages;

public partial class ManageDecks : IDisposable
{
    public void Dispose()
    {
        DataContext.Dispose();
    }
}
