using ECG.Models;
using ECG.Services;
using System.Collections.ObjectModel;

namespace ECG.ViewModels
{
    public class CatalogListViewModel: BaseViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly ICatalogService _catalogService;
        public ObservableCollection<Catalog> Catalogs { get; set; }

        public CatalogListViewModel(INavigationService navigationService,ICatalogService catalogService)
        {
            _catalogService = catalogService;
            _navigationService = navigationService;
            Catalogs = new ObservableCollection<Catalog>(_catalogService.GetCatalogs());
        }

    }
}
