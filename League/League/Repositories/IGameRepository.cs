using League.Models;
using System.Collections.Generic;

namespace League.Repositories
{
    public interface IGameRepository
    {
        List<Game> GetGamesByTeamId(int teamId);
        void Reset();
    }
}
