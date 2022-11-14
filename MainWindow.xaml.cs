using HeroesGame.Helpers;
using HeroesGame.Model;
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

namespace HeroesGame 
{
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            _bazaGry = GameBase.Create();
            DataContext = _bazaGry;
            Player1.DataContext = _bazaGry.Gracze[0];
            Player2.DataContext = _bazaGry.Gracze[1];
            Player3.DataContext = _bazaGry.Gracze[2];
            Player4.DataContext = _bazaGry.Gracze[3];
            Player5.DataContext = _bazaGry.Gracze[4];
        }

        private GameBase _bazaGry;

    }
}
