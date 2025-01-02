namespace DolarPy;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(ListDetailDetailPage), typeof(ListDetailDetailPage));
        Routing.RegisterRoute(nameof(ProviderDetailPage), typeof(ProviderDetailPage));
    }
}
