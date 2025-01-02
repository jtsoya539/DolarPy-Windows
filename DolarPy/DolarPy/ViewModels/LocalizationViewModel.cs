namespace DolarPy.ViewModels;

public partial class LocalizationViewModel : BaseViewModel
{
	public string LocalizedText => DolarPy.Resources.Strings.AppResources.HelloMessage;
}
