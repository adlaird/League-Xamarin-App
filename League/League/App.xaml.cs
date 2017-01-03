using League.Repositories;
using League.Services;
using League.Views;
using SQLite;
using Xamarin.Forms;

namespace League
{
    public partial class App : Application
    {
        public static ITeamRepository TeamRepo { get; private set; }
        public static ITeamService TeamService { get; private set; }

        public App(string dbPath)
        {
            InitializeComponent();

            var connection = new SQLiteConnection(dbPath);

            TeamRepo = new TeamRepository(connection);
            TeamService = new TeamService();

            MainPage = new NavigationPage(new HomePage());
        }
    }
}
