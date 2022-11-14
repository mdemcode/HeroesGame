using System.Collections.Generic;
using System.Windows;

namespace HeroesGame.Helpers {
    public partial class WybierzZListy : Window {
        public WybierzZListy(IEnumerable<string> listaWyboru, string info) {
            InitializeComponent();
            TbInfo.Text = info;
            CbWybor.ItemsSource = listaWyboru;
        }

        public string WybranaPozycja { get; private set; } = string.Empty;

        private void YesButton_Click(object sender, RoutedEventArgs e) {
            if (CbWybor.SelectedItem is not null) 
                WybranaPozycja = CbWybor.SelectedItem?.ToString() ?? string.Empty;
            Close();
        }
    }
}
