using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesGame.Helpers 
{
    internal static class Tools {

        #region ROZSZERZENIA
        internal static string DayOfWeekToPolish(this DayOfWeek day) {
            return day switch {
                DayOfWeek.Sunday => "Niedziela",
                DayOfWeek.Monday => "Poniedziałek",
                DayOfWeek.Tuesday => "Wtorek",
                DayOfWeek.Wednesday => "Środa",
                DayOfWeek.Thursday => "Czwartek",
                DayOfWeek.Friday => "Piątek",
                DayOfWeek.Saturday => "Sobota",
                _ => throw new ArgumentOutOfRangeException(nameof(day), day, "Błędny dzień tygodnia!")
            };
        }
        #endregion
    }
}
