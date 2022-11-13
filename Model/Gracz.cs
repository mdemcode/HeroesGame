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
        public List<Bohater> Bohaterowie { get; } = new List<Bohater>();


    }

}
