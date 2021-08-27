using ECG.ViewModels;

namespace ECG.Utility
{
    public static class ViewModelLocator
    {
        public static LoginViewModel LoginViewModel =  new LoginViewModel(App.NavigationService,App.LoginService);
        public static CatalogListViewModel CalalogListViewModel = new CatalogListViewModel(App.NavigationService,App.CatalogService);
    }
}
