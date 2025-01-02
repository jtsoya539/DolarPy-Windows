namespace DolarPy.Views;

public partial class InfoPage : ContentPage
{
    InfoViewModel ViewModel;

    public InfoPage(InfoViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = ViewModel = viewModel;
    }
}