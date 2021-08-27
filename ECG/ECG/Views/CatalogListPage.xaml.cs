using ECG.Utility;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ECG.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatalogListPage : ContentPage
    {
        public CatalogListPage()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.CalalogListViewModel;
        }
    }
}