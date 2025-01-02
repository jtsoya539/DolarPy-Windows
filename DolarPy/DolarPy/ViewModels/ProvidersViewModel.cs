namespace DolarPy.ViewModels
{
    public partial class ProvidersViewModel : BaseViewModel
    {
        readonly DolarPyService _dolarPyService;

        [ObservableProperty]
        bool isRefreshing;

        [ObservableProperty]
        ObservableCollection<ProviderDetail>? items;

        public ProvidersViewModel(DolarPyService dolarPyService)
        {
            _dolarPyService = dolarPyService;
        }

        [RelayCommand]
        private async Task OnRefreshing()
        {
            IsRefreshing = true;

            try
            {
                await LoadDataAsync();
            }
            finally
            {
                IsRefreshing = false;
            }
        }

        [RelayCommand]
        public async Task LoadMore()
        {
            if (Items is null)
            {
                await LoadDataAsync();
            }
        }

        public async Task LoadDataAsync()
        {
            Items = new ObservableCollection<ProviderDetail>(await _dolarPyService.GetItems());
        }

        [RelayCommand]
        private async Task GoToDetails(SampleItem item)
        {
            await Shell.Current.GoToAsync(nameof(ListDetailDetailPage), true, new Dictionary<string, object>
            {
                { "Item", item }
            });
        }
    }
}
