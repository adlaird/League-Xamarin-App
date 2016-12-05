using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace League
{
    public partial class StandingsPage : ContentPage
    {
        public StandingsPage()
        {
            InitializeComponent();

            var allTeams = App.TeamRepo.GetAllTeams();

            BindingContext = allTeams;
        }
    }
}
