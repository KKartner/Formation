using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class SpeakingClock
    {
        public static string GoodDay(int heure)
        {
            if (heure >= 0 && heure < 6)
            {
                Console.WriteLine("Merveilleuse Nuit");
            }
            if (heure >= 6 && heure < 12)
            {
                Console.WriteLine("Bonne matinée");
            }
            if (heure == 12)
            {
                Console.WriteLine("Bon appetit");
            }
            if (heure >= 13 && heure < 18)
            {
                Console.WriteLine("Profitez de votre après-midi");
            }
            if (heure > 18)
            {
                Console.WriteLine("Passez une bonne soirée");
            }
            return string.Empty;
        }
    }
}
