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
    }
}
