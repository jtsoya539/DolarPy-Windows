namespace DolarPy.Views;

public partial class ExampleFontAwesomeUsagePage : ContentPage
{
	public ExampleFontAwesomeUsagePage(ExampleFontAwesomeUsageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
