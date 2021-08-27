using ECG.Services;
using ECG.Utility;
using ECG.Views;
using Xamarin.Forms;

namespace ECG
{
    public partial class App : Application
    {
        public static NavigationService NavigationService { get; } = new NavigationService();
        public static ICatalogService CatalogService = new CatalogService();
        public static ILoginService LoginService = new LoginService();
      
        public App()
        {
            NavigationService.Configure(ViewName.CatalogListPage, typeof(CatalogListPage));
            NavigationService.Configure(ViewName.LoginPage, typeof(LoginPage));
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
            //MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
