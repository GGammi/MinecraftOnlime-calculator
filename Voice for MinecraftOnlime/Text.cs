using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voice_for_MinecraftOnlime
{
    class Text
    {
        public static List<string> language = new List<string>()
        {
            "Русский",
            "English",
            "Deutsch"
        };

        public static List<string> language_selection = new List<string>()
        {
            "Выбор языка",
            "Language selection",
            "Sprachauswahl"
        };

        public static List<string> entering_nickname = new List<string>()
        {
            "Введите свой ник",
            "Enter your nickname",
            "Geben Sie Ihren Spitznamen ein"
        };

        public static List<string> status_selection = new List<string>()
        {
            "Какой у вас сейчас статус?",
            "What is your current status?",
            "Was ist dein aktueller Status?"
        };
        public static List<string> status = new List<string>()
        {
            "None",
            "Wood",
            "Stone",
            "Iron",
            "Gold",
            "Diamond",
            "Obsidian",
            "Nether",
            "Aether",
        };

        public static List<int> Preis = new List<int>()
        {
            {0},
            {14},
            {28},
            {56},
            {126},
            {546},
            {728},
            {910},
            {1092}

        };

        public static List<string> entering_balance = new List<string>()
        {
            "Введите текущий баланс токенов",
            "Enter the current tokens balance",
            "Geben Sie den aktuellen Token-Saldo ein"
        };

        public static List<string> greeting = new List<string>()
        {
            "Привет",
            "Hi",
            "Hallo"
        };

        public static string DayRu(int number = 1)
        {
            if (number > 20 && number < 100) // 21 -99
            {
                number = int.Parse(number.ToString().Remove(0, 1));
            }
            else if(number > 99 && number < 1000) // 100 - 999
            {
                number = int.Parse(number.ToString().Remove(0, 2));
            }
            else if (number > 999 && number < 10000) // 1000 - 9999
            {
                number = int.Parse(number.ToString().Remove(0, 3));
            }

            if (number == 1)
            {
                return "день";
            }
            else if (number >= 2 && number <= 4)
            {
                return "дня";
            }
            else if (number >= 5 && number <= 20 || number == 0)
            {
                return "дней";
            }
            return "NONE";
        }
    }
}
