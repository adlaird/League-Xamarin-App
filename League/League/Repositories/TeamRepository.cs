using League.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;

namespace League.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly SQLiteConnection conn;

        public TeamRepository(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Team>();

            var allTeams = conn.Table<Team>().ToList();
            if (allTeams.Count == 0)
            {
                CreateInitializationData();
            }
        }

        public void Reset()
        {
            conn.DeleteAll<Team>();
            CreateInitializationData();
        }

        public List<Team> GetAllTeams()
        {
            return conn.Table<Team>().ToList();
        }

        private void CreateInitializationData()
        {
            var team1 = new Team() { Id = 1, Name = "Steelers", Wins = 1, Losses = 0 };
            var team2 = new Team() { Id = 1, Name = "Ravens", Wins = 0, Losses = 1 };

            var teamList = new List<Team> { team1, team2 };

            conn.InsertAll(teamList);
        }
    }
}
