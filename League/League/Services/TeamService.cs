using League.DTOs;
using League.Extensions;
using League.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;

namespace League.Services
{
    public class TeamService : ITeamService
    {
        private ITeamRepository TeamRepo;

        public TeamService(ITeamRepository teamRepo)
        {
            TeamRepo = teamRepo;
        }

        public List<TeamDTO> GetAllTeams()
        {
            return TeamRepo.GetAllTeams().Select((team) => team.ConvertToDTO()).ToList<TeamDTO>();
        }

        public void Reset()
        {
            TeamRepo.Reset();
        }
    }
}
