using HeroesGame.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesGame.Model 
{
    internal class Gracz {
         
        public Gracz(string imie) {
            Imie = imie;
        }

        public string Imie { get; set; }
        public List<Bohater> Bohaterowie { get; } = new();
        public List<Zamek> ZajeteZamki { get; } = new();

        public Zamek? WybierzZamekPoczatkowy() {
            WybierzZListy oknoWyboru = new(Enum.GetNames(typeof(TypZamku)), "Wybierz zamek dla tego gracza:");
            oknoWyboru.ShowDialog();
            if (oknoWyboru.WybranaPozycja is null) return null;
            Zamek zamekGracza = new (oknoWyboru.WybranaPozycja, this);
            ZajeteZamki.Add(zamekGracza);
            return zamekGracza;
        }
        public Bohater? WybierzBohateraPoczatkowego(TypZamku typZamku) {
            IEnumerable<string>? bohDoWyboru = Bohater.BohaterowieZamku(typZamku)?.Select(b => $"{b.imie}-{b.typ}").ToList();
            if(bohDoWyboru is null) return null;
            WybierzZListy oknoWyboru = new(bohDoWyboru, "Wybierz bohatera początkowego:");
            oknoWyboru.ShowDialog();
            if (oknoWyboru.WybranaPozycja is null) return null;
            string[] wybPoz = oknoWyboru.WybranaPozycja.Split("-");
            Bohater wybranyBohater = new(wybPoz[0], wybPoz[1]);
            Bohaterowie.Add(wybranyBohater);
            return wybranyBohater;
        }
    }

}
