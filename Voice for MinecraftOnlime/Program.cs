using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voice_for_MinecraftOnlime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Balance.set = 140;
            //Grafics.Logo();
            //Grafics.TokensToDay();
            Screen.LanguageSelection();
            Screen.EnteringNickname();
            Screen.StatusSelection();
            Screen.EnteringBalance();
            Screen.MainScreen();
            Console.ReadKey();
        }
    }
}
