using League.Repositories;
using Xamarin.Forms;

namespace League
{
    public partial class App : Application
    {
        public static TeamRepository TeamRepo { get; private set; }

        public App(string dbPath)
        {
            InitializeComponent();

            TeamRepo = new TeamRepository(dbPath);

            MainPage = new NavigationPage(new HomePage());
        }
    }
}
