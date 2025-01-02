namespace DolarPy.Views;

public partial class ProvidersPage : ContentPage
{
    ProvidersViewModel ViewModel;

    public ProvidersPage(ProvidersViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = ViewModel = viewModel;
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        await ViewModel.LoadDataAsync();
    }
}