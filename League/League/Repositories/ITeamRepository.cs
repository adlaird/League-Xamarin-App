using System.Collections.Generic;
using League.Models;

namespace League.Repositories
{
    public interface ITeamRepository
    {
        List<Team> GetAllTeams();
        void Reset();
    }
}