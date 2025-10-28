using Engine;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SuperAdventure
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Player _player;

        public MainWindow()
        {
            InitializeComponent();

            _player = new Player(10, 10, 20, 0, 1);

            

            lblHitPoints.Content = _player.CurrentHitPoints.ToString();
            lblGold.Content = _player.Gold.ToString();
            lblExperience.Content = _player.ExperiencePoints.ToString();
            lblLevel.Content = _player.Level.ToString();

            Location location = new Location(1, "Home", "This is your house.");
            
        }


       
    }
}