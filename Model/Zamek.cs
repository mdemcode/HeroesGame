using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesGame.Model 
{
    internal class Zamek {
        internal Zamek(string typ, Gracz gracz) {
            Typ = typ switch {
                "Fort" => TypZamku.Fort,
                "Jaskinia" => TypZamku.Jaskinia,
                "Cmentarz" => TypZamku.Cmentarz,
                "Puszcza" => TypZamku.Puszcza,
                "Stodola" => TypZamku.Stodola,
                _ => throw new ArgumentOutOfRangeException(nameof(typ), typ, "Nie obsługiwany typ zamku!")
            };
            NalezyDoGracza = gracz;
        }

        public TypZamku Typ { get; }
        public Gracz NalezyDoGracza { get; private set; }

        internal void ZmienWlasciciela(Gracz nowyWlasciciel) => NalezyDoGracza = nowyWlasciciel;

    }

    internal enum TypZamku {
        Fort,
        Jaskinia,
        Cmentarz,
        Puszcza,
        Stodola
    }
}
