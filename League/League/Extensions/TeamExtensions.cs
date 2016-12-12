using League.DTOs;
using League.Models;

namespace League.Extensions
{
    public static class TeamExtensions
    {
        public static TeamDTO ConvertToDTO(this Team team)
        {
            TeamDTO teamDTO = new TeamDTO();

            teamDTO.Name = team.Name;
            teamDTO.Record = team.Wins + "-" + team.Losses;

            return teamDTO;
        }
    }
}
