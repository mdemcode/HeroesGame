using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesGame.Model {
    internal class Bohater {
        internal Bohater(string imie, string typ) {
            Imie = imie;
            Typ = typ switch {
                "Zlodziej" => TypBohatera.Zlodziej,
                "Wojownik" => TypBohatera.Wojownik,
                "Czarnoksieznik" => TypBohatera.Czarnoksieznik,
                "Podroznik" => TypBohatera.Podroznik,
                _ => throw new ArgumentOutOfRangeException(nameof(typ), typ, "Nie obsługiwany typ bohatera!")
            };
        }

        public string Imie { get; }
        public TypBohatera Typ { get; }

        public static IEnumerable<(string imie, TypBohatera typ)>? BohaterowieZamku(TypZamku typZamku) {
            return typZamku switch {
                TypZamku.Fort => new[] { ("Hieronim", TypBohatera.Podroznik), ("Kraken", TypBohatera.Zlodziej), ("Atena", TypBohatera.Wojownik) },
                TypZamku.Jaskinia => new[] { ("Lizzie", TypBohatera.Zlodziej), ("Travis", TypBohatera.Podroznik), ("Harold", TypBohatera.Wojownik) },
                TypZamku.Cmentarz => new[] { ("Raven", TypBohatera.Podroznik), ("Mortis", TypBohatera.Wojownik), ("Myron", TypBohatera.Czarnoksieznik) },
                TypZamku.Puszcza => new[] { ("Gloria", TypBohatera.Podroznik), ("Bilbo", TypBohatera.Zlodziej), ("Elza", TypBohatera.Czarnoksieznik) },
                TypZamku.Stodola => new[] { ("Chuck", TypBohatera.Czarnoksieznik), ("Emma", TypBohatera.Zlodziej), ("Peter", TypBohatera.Wojownik) },
                _ => null,
            };
        }
    }

    public enum TypBohatera {
        Zlodziej,
        Wojownik,
        Czarnoksieznik,
        Podroznik
    }


}
