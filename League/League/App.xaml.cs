using League.Repositories;
using League.Services;
using Xamarin.Forms;

namespace League
{
    public partial class App : Application
    {
        public static TeamRepository TeamRepo { get; private set; }
        public static TeamService TeamService { get; private set; }

        public App(string dbPath)
        {
            InitializeComponent();

            TeamRepo = new TeamRepository(dbPath);
            TeamService = new TeamService();

            MainPage = new NavigationPage(new HomePage());
        }
    }
}
