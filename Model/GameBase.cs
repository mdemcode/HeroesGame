using HeroesGame.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesGame.Model {
    internal class GameBase {
        private GameBase() { }

        public Gracz[] Gracze { get; set; } = new Gracz[5];
        public ICollection<Zamek> Zamki { get; private set; } = new List<Zamek>();
        //
        public int Tura { get; private set; }
        public DayOfWeek DzienTygodnia { get; private set; }
        public string DzienTygodniaTxt => DzienTygodnia.DayOfWeekToPolish();

        // factory
        internal static GameBase Create() {
            GameBase nowaGra = new() {
                Tura = 1,
                DzienTygodnia = DayOfWeek.Monday
            };
            //ICollection<Gracz> dodawaniGracze = new List<Gracz>();
            //ICollection<Zamek> dodawaneZamki = new List<Zamek>();
            int i = 0;
            while (true) {
                InputBox ib = new($"Podaj imię gracza {++i}:");
                ib.ShowDialog();
                string imie = ib.WpisanyTekst;
                if (string.IsNullOrEmpty(imie)) break;
                Gracz nowyGracz = new(imie);
                Zamek? zamekGracza = nowyGracz.WybierzZamekPoczatkowy();
                if (zamekGracza is null) break;
                Bohater? bohPoczatkowy = nowyGracz.WybierzBohateraPoczatkowego(zamekGracza.Typ);
                if (bohPoczatkowy is null) break;
                //
                nowaGra.Gracze[i - 1] = nowyGracz;
                nowaGra.Zamki.Add(zamekGracza);
                //dodawaniGracze.Add(nowyGracz);
                //dodawaneZamki.Add(zamekGracza);
            }
            if (i < 5) {
                for (int j = i - 1; j < 5; j++) {
                    nowaGra.Gracze[j] = new Gracz("Pusty");
                }
            }
            //nowaGra.Gracze = dodawaniGracze.ToArray();
            //nowaGra.Zamki = dodawaneZamki.ToArray();
            return nowaGra;
        }

        internal void NastepnyDzien() {
            Tura++;
            DzienTygodnia++;
            // ToDo ...
        }
        
    }

}
