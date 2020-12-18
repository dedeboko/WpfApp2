using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ensemble x;
        ligneDeBus i;
        public MainWindow()
        {
            InitializeComponent();
            x = new Ensemble();
            createlineStation();
            cbBusLines.ItemsSource = x;
            cbBusLines.DisplayMemberPath = "numberLine";
            cbBusLines.SelectedIndex = 0;
            cbBusLines.SelectionChanged += CbBusLines_SelectionChanged;

        }

        private void CbBusLines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            int index = cb.SelectedIndex;
            i = x[index];
            affichage();
        }

        public void affichage() 
        {
            txt.Text = i.ToString();
        }

        private void createlineStation()
        {
            Random r = new Random();
            ligneDeBus newligne;
            autobusStation newstation;
            lineStation newlast;
            for (int i = 0; i < 10; i++)
            {
                newlast = new lineStation((float)r.NextDouble(), (float)r.NextDouble(), r.Next());
                newstation = new autobusStation(r.Next());
                newligne = new ligneDeBus(r.Next(),newstation,newlast);
                x.addKav(newligne);
            }
            lineStation line;
            for(int i = 0; i < 100; i++)
            {
                line = new lineStation((float)r.NextDouble(), (float)r.NextDouble(), r.Next());
                x[r.Next(0, 9)].addStation(line);
                x[r.Next(0, 9)].addStation(line);
                x[r.Next(0, 9)].addStation(line);
            }
            
        }
    }
}
