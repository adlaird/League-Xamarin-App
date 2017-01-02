using League.DTOs;
using League.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace League.Services
{
    public class TeamService : ITeamService
    {
        public List<TeamDTO> GetAllTeams()
        {
            return App.TeamRepo.GetAllTeams().Select((team) => team.ConvertToDTO()).ToList<TeamDTO>();
        }
    }
}
