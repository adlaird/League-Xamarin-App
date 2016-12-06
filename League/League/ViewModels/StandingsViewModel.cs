using League.Models;
using System.Collections.Generic;
using System.Linq;

namespace League.ViewModels
{
    public class StandingsViewModel
    {
        private List<Team> Teams;

        public List<TeamViewModel> Standings {
            get
            {
                return Teams.Select(t => new TeamViewModel(t)).ToList();
            }
        }

        public StandingsViewModel()
        {
            var allTeams = App.TeamRepo.GetAllTeams();

            Teams = allTeams;
        }
    }
}
