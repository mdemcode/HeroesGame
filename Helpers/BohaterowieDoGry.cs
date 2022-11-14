using HeroesGame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesGame.Helpers 
{
    internal class BohaterowieDoGry {

        private BohaterowieDoGry() => WczytajBohaterow();

        internal Dictionary<string, Bohater> SlownikBohaterow { get; } = new Dictionary<string, Bohater>();

        private void WczytajBohaterow() {
            //Bohater bohEmma = new("Emma") {
            //    // tu inne właściwości (albo w konstruktorze)
            //};
            //SlownikBohaterow.Add("Emma", bohEmma);

        }

        internal Bohater? WezBohatera(string imie) {
            //if (SlownikBohaterow.TryGetValue(imie, out Bohater? boh)) {
            //    Bohater bohOut = boh.Clone(); //todo
            //    SlownikBohaterow.Remove(imie);
            //    return bohOut;
            //}
            return null;
        }  
        
    }
}
