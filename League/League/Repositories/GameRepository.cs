using League.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace League.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly SQLiteConnection conn;

        public GameRepository(SQLiteConnection conn)
        {
            conn.CreateTable<Game>();

            var allGames = conn.Table<Game>().ToList();
            if (allGames.Count == 0)
            {
                CreateInitializationData();
            }
        }

        public List<Game> GetGamesByTeamId(int teamId)
        {
            return conn.Table<Game>().Where(g => g.AwayTeam == teamId || g.HomeTeam == teamId).ToList();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        private void CreateInitializationData()
        {
            var game1 = new Game { Id = 0, HomeTeam = 0, AwayTeam = 1, HomeScore = 21, AwayScore = 7, Completed = true, Week = 1};

            var gameList = new List<Game> { game1 };

            conn.InsertAll(gameList);
        }
    }
}
