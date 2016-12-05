using League.Models;
using System.Collections.Generic;

namespace League.ViewModels
{
    public class StandingsViewModel
    {
        public StandingsViewModel()
        {
            var allTeams = App.TeamRepo.GetAllTeams();

            Standings = allTeams;
        }

        public List<Team> Standings { get; set; }

    }
}
