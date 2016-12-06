using League.ViewModels;
using System;
using Xamarin.Forms;

namespace League
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        void GoToStandings(object sender, EventArgs args)
        {
            Navigation.PushAsync(new StandingsPage(new StandingsViewModel()));
        }
    }
}
