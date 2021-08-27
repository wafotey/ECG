using ECG.Models;
using ECG.Services;
using ECG.Utility;
using System.Windows.Input;
using Xamarin.Forms;

namespace ECG.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly ILoginService _loginService;
        public Login Login { get; set; }
        public ICommand LoginCommand { get; private set; }
        public LoginViewModel(INavigationService navigationService,ILoginService loginService)
        {
            _navigationService = navigationService;
            _loginService = loginService;
            Login = _loginService.GetLogin();
            LoginCommand = new Command(OnLogin);
         
        }

        public void OnLogin()
        {
            _navigationService.NavigateTo(ViewName.CatalogListPage);     
        }
    }
}
