using League.Repositories;
using League.Services;
using League.Views;
using SQLite;
using Xamarin.Forms;

namespace League
{
    public partial class App : Application
    {
        public static ITeamService TeamService { get; private set; }

        public App(string dbPath)
        {
            InitializeComponent();

            var connection = new SQLiteConnection(dbPath);

            var teamRepo = new TeamRepository(connection);
            TeamService = new TeamService(teamRepo);

            MainPage = new NavigationPage(new HomePage());
        }
    }
}
