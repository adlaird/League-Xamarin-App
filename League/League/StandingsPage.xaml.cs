using League.ViewModels;
using Xamarin.Forms;

namespace League
{
    public partial class StandingsPage : ContentPage
    {
        public StandingsPage(StandingsViewModel vm)
        {
            InitializeComponent();

            BindingContext = vm;
        }
    }
}
