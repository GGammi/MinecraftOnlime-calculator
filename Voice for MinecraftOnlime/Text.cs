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
            else if (number > 99 && number < 1000) // 100 - 999
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
        public static string TokenRu(int number = 1)
        {
            if (number > 20 && number < 100) // 21 -99
            {
                number = int.Parse(number.ToString().Remove(0, 1));
            }
            else if (number > 99 && number < 1000) // 100 - 999
            {
                number = int.Parse(number.ToString().Remove(0, 2));
            }
            else if (number > 999 && number < 10000) // 1000 - 9999
            {
                number = int.Parse(number.ToString().Remove(0, 3));
            }

            if (number == 1)
            {
                return "токен";
            }
            else if (number >= 2 && number <= 4)
            {
                return "токена";
            }
            else if (number >= 5 && number <= 20 || number == 0)
            {
                return "токенов";
            }
            return "токен";
        }
        public static string TokenEn(int number = 1)
        {

            if (number == 1)
            {
                return "token";
            }
            else
            {
                return "tokens";
            }
        }
        public static string TokenDe()
        {
            return "token";
        }

        public static List<string> SettingsRu = new List<string>()
        {
            "Язык",
            "Ник",
            "Статус",
            "Об авторе",
            "Сбросить все",
            "Назад"
        };

        public static List<string> TextUp = new List<string>()
        {
            "Вверх",
            "Up",
            "Hoch"
        };

        public static List<string> TextDown = new List<string>()
        {
            "Вниз",
            "Down",
            "Nieder"
        };
        public static List<string> TextLeft = new List<string>()
        {
            "Влево",
            "Left",
            "Links"
        };
        public static List<string> TextRight = new List<string>()
        {
            "Вправо",
            "Right",
            "Rechts"
        };
        public static List<string> UpdateBalance = new List<string>()
        {
            "обновить баланс",
            "update balance",
            "balance aktualisieren"
        };
        public static List<string> Settings = new List<string>()
        {
            "настройки",
            "settings",
            "einstellung"
        };

        public static List<string> TheBalanceIsEqualTo_c1 = new List<string>()
        {
            "Баланс на",
            "The balance as of",
            "Die Bilanz für den"
        };

        public static List<string> TheBalanceIsEqualTo_c2 = new List<string>()
        {
            "равен",
            "is equal to",
            "lautet"
        };

        public static string TokenLang(int number = 1)
        {
            string text = null;

            switch (Profile.lang_id)
            {
                case 0:
                    text = TokenRu(number);
                    break;
                case 1:
                    text = TokenEn(number);
                    break;
                case 2:
                    text = TokenDe();
                    break;
            }

            return text;
        }

        public static List<string> AfterThePurchaseOf = new List<string>()
        {
            "После покупки",
            "After the purchase of",
            "Nach dem Kauf von"
        };

        public static List<string> MaximumStatus = new List<string>()
        {
            "Вы преобрели максимальный статус!",
            "You have acquired the maximum status!",
            "Sie haben den maximalen Status erworben!"
        };
    }
}