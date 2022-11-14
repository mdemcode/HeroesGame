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
using System.Windows.Shapes;

namespace HeroesGame.Helpers 
{
    public partial class InputBox : Window {
        public InputBox(string info) {
            InitializeComponent();
            TbInfo.Text = info;
        }

        public string WpisanyTekst { get; private set; }

        private void YesButton_Click(object sender, RoutedEventArgs e) {
            WpisanyTekst = InputTextBox.Text;
            Close();
        }
    }
}
