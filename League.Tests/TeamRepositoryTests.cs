using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using League.Repositories;

namespace League.Tests
{
    [TestFixture]
    public class TeamRepositoryTests
    {
        [Test]
        public void Reset_deletes_all_teams_in_db_and_reinitializes_data()
        {
            var teamRepo = new TeamRepository("fake path");

            teamRepo.Reset();
        }
    }
}
