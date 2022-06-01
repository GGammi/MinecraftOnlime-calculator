using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voice_for_MinecraftOnlime
{
    class Screen
    {
        public static void LanguageSelection()
        {
            Console.Clear();

            Controls.screen_key = 1;
            Controls.cursor_position = 14;

            Grafics.BasicScreen();
            do
            {
                Console.SetCursorPosition(Grafics.TextCentered("                    ", 68), 1);
                Console.Write("                    ");

                Console.SetCursorPosition(Grafics.TextCentered(Controls.cursor_position - 14, Text.language_selection, 68), 1);
                Console.WriteLine(Text.language_selection[Controls.cursor_position - 14]);

                Grafics.SelectItem(14, 16, Text.language, "vertically", 29);
            } while (Controls.control(14, 16));
        }

        public static void EnteringNickname()
        {
            Console.Clear();

            Controls.screen_key = 2;

            Grafics.BasicScreen("text");

            Console.SetCursorPosition(Grafics.TextCentered(Profile.lang_id, Text.entering_nickname, 68), 1);
            Console.WriteLine(Text.entering_nickname[Profile.lang_id]);

            Console.SetCursorPosition(30, 16);
            Profile.nickname = Console.ReadLine();
        }

        public static void StatusSelection()
        {
            Console.Clear();

            Controls.cursor_position = 12;
            Controls.screen_key = 3;

            Grafics.BasicScreen();

            Console.SetCursorPosition(Grafics.TextCentered(Profile.lang_id, Text.status_selection, 68), 1);
            Console.WriteLine(Text.status_selection[Profile.lang_id]);
            do
            {
                Grafics.SelectItem(12, 20, Text.status, "vertically", 29);
            } while (Controls.control(12, 20));
        }

        public static void EnteringBalance()
        {
            Console.Clear();

            Controls.screen_key = 4;

            Grafics.BasicScreen("text");

            Console.SetCursorPosition(Grafics.TextCentered(Profile.lang_id, Text.entering_balance, 68), 1);
            Console.WriteLine(Text.entering_balance[Profile.lang_id]);

            Console.SetCursorPosition(30, 16);
            Balance.set = Convert.ToInt32(Console.ReadLine());
        }

        public static void MainScreen()
        {
            Console.Clear();

            string text;
            int tokens = 0;
            int j = Profile.stat_id;
            int days;

            Controls.screen_key = 5;
            Controls.cursor_position = 0;

            Grafics.BasicScreen("horizontally", false);

            Grafics.Rectangle(68, 3);
            Grafics.Rectangle(68, 3, 0, 3);
            Grafics.Rectangle(68, 3, 0, 23);
            Grafics.Rectangle(68, 3, 0, 27);


            text = Text.greeting[Profile.lang_id] + ", " + Profile.nickname + '!';
            Console.SetCursorPosition(Grafics.TextCentered(text, 68), 1);
            Console.WriteLine(text);
            Console.SetCursorPosition(Grafics.TextCentered(Grafics.TokensToDay(), 68), 4);
            Console.WriteLine(Grafics.TokensToDay());

            Grafics.Line(0, 7, 67, 7);
            Grafics.Line(0, 22, 67, 22);
            Grafics.Line(0, 7, 0, 22);
            Grafics.Line(67, 7, 67, 22);

            Grafics.Line(0, 9, 67, 9);
            Grafics.Line(0, 18, 67, 18);

            Grafics.Line(11, 7, 11, 22);
            Grafics.Line(18, 7, 18, 22);

            Grafics.Line(25, 9, 25, 22);
            Grafics.Line(32, 9, 32, 22);
            Grafics.Line(39, 9, 39, 22);
            Grafics.Line(46, 9, 46, 22);
            Grafics.Line(53, 9, 53, 22);
            Grafics.Line(60, 9, 60, 22);

            Console.SetCursorPosition(3, 8);
            Console.Write("Kit");

            Console.SetCursorPosition(13, 8);
            Console.Write("Tok");

            Console.SetCursorPosition(13, 20);
            Console.Write("Now");

            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(3, i + 10);
                Console.Write(Text.status[i + 1]);
            }

            if (Profile.stat_id == 0)
            {
                tokens = Text.Preis[Profile.stat_id + 1];
                text = "После покупки " + Text.status[Profile.stat_id + 1] + " Kit " + '-' + tokens + ' ' + Text.TokenRu(tokens);
            }
            else if (Profile.stat_id != 8)
            {
                tokens = Text.Preis[Profile.stat_id + 1] - Text.Preis[Profile.stat_id];
                text = "После покупки " + Text.status[Profile.stat_id + 1] + " Kit " + '-' + tokens + ' ' + Text.TokenRu(tokens);
            }
            else
            {
                text = "Вы преобрели максимальный статус!";
            }
            Console.SetCursorPosition(Grafics.TextCentered(text, 50) + 19, 8);
            Console.Write(text);

            Grafics.DrawPreis(13, j++, "ОК");
            Grafics.DrawPreis(20, j++);
            Grafics.DrawPreis(27, j++);
            Grafics.DrawPreis(34, j++);
            Grafics.DrawPreis(41, j++);
            Grafics.DrawPreis(48, j++);
            Grafics.DrawPreis(55, j++);
            Grafics.DrawPreis(62, j);

            Grafics.DrawDays();

            if (Balance.get >= tokens)
            {
                if (Profile.stat_id != 8)
                {
                    text = "Вы можете купить " + Text.status[Profile.stat_id + 1] + " Kit ";
                }
                else
                {
                    text = "Поздравляю, у вас максимальный статус!";
                }
            }
            else
            {
                tokens = tokens - Balance.get;
                days = (tokens + 2 - 1) / 2;

                text = "До " + Text.status[Profile.stat_id + 1] + " Kit " + days + ' ' + Text.DayRu(days) + " или же " + tokens + ' ' + Text.TokenRu(tokens);
            }
            Console.SetCursorPosition(Grafics.TextCentered(text, 68), 24);
            Console.Write(text);

            Console.SetCursorPosition(9, 28);
            Console.Write("обновить баланс");

            Console.SetCursorPosition(49, 28);
            Console.Write("настройки");

            do
            {
                Grafics.SelectItem(0, 1, Text.status, "horizontally");
            } while (Controls.control(0, 1, "horizontally"));
        }

        public static void SettingsMenu()
        {
            Console.Clear();

            Controls.screen_key = 6;

            Controls.cursor_position = 16;
            
            Grafics.Rectangle(68, 3);
            Grafics.Rectangle(68, 27, 0, 3);
            Grafics.BasicScreen();

            Console.SetCursorPosition(Grafics.TextCentered("Настройки", 68), 1);
            Console.Write("Настройки");

            do
            {
                Grafics.SelectItem(14, 19, Text.SettingsRu, "vertically", 30);
            } while (Controls.control(14, 19));
        }

        public static void StartScreen()
        {
            Grafics.BasicScreen("text");

            Console.SetCursorPosition(Grafics.TextCentered("MCONLINE", 68), 1);
            Console.WriteLine("MC_ONLINE");

            Console.SetCursorPosition(Grafics.TextCentered("MINECRAFT ONLINE", 68), 13);
            Console.WriteLine("MINECRAFT ONLINE");
            Console.SetCursorPosition(Grafics.TextCentered("calculator", 68), 14);
            Console.WriteLine("calculator");
            Console.SetCursorPosition(Grafics.TextCentered("PRESS ENTER", 68), 16);
            Console.WriteLine("PRESS ENTER");

            Console.ReadKey();
        }

        public static void AboutTheAuthor()
        {
            Grafics.BasicScreen("text");

            Console.SetCursorPosition(Grafics.TextCentered("Об авторе", 68), 1);
            Console.WriteLine("Об авторе");

            Console.SetCursorPosition(Grafics.TextCentered("Никнейм в игре: GGammi", 68), 13);
            Console.WriteLine("Никнейм в игре: GGammi");
            Console.SetCursorPosition(Grafics.TextCentered("какой-то текст", 68), 14);
            Console.WriteLine("какой-то текст");
            Console.SetCursorPosition(Grafics.TextCentered("и еще немного текста", 68), 16);
            Console.WriteLine("и еще немного текста");

            Console.ReadKey();
        }
    }
}
