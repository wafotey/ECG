using ECG.Utility;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ECG.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.LoginViewModel;
        }
    }
}