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
            Controls.screen_key = 1;

            Grafics.Table(46, 3);
            Grafics.Table(46, 5, 0, 4);
            do
            {
                Console.SetCursorPosition(15, 1);
                Console.Write("                  ");

                Console.SetCursorPosition(Grafics.TextCentered(Controls.cursor_position - 5, Text.language_selection), 1);
                Console.WriteLine(Text.language_selection[Controls.cursor_position - 5]);

                Grafics.SelectItem(5, 7, Text.language);
            } while (Controls.control(5, 7));
            Console.Clear();
        }

        public static void EnteringNickname()
        {
            Controls.screen_key = 2;

            Grafics.Table(46, 3);
            Grafics.Table(46, 3, 0, 4);

            Console.SetCursorPosition(Grafics.TextCentered(Profile.lang_id, Text.entering_nickname), 1);
            Console.WriteLine(Text.entering_nickname[Profile.lang_id]);

            Console.SetCursorPosition(22, 5);
            Profile.nickname = Console.ReadLine();
            Console.Clear();
        }

        public static void StatusSelection()
        {
            Controls.screen_key = 3;

            Grafics.Table(46, 3);
            Grafics.Table(46, 11, 0, 4);

            Console.SetCursorPosition(Grafics.TextCentered(Profile.lang_id, Text.status_selection), 1);
            Console.WriteLine(Text.status_selection[Profile.lang_id]);
            do
            {
                Grafics.SelectItem(5, 13, Text.status);
            } while (Controls.control(5, 13));
            Console.Clear();
        }

        public static void EnteringBalance()
        {
            Controls.screen_key = 4;

            Grafics.Table(46, 3);
            Grafics.Table(46, 3, 0, 4);

            Console.SetCursorPosition(Grafics.TextCentered(Profile.lang_id, Text.entering_balance), 1);
            Console.WriteLine(Text.entering_balance[Profile.lang_id]);

            Console.SetCursorPosition(22, 5);
            Balance.set = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }

        public static void MainScreen()
        {
            Controls.screen_key = 5;

            Grafics.Table(68, 3);
            Grafics.Table(68, 3, 0, 3);
            Grafics.Table(68, 3, 0, 23);
            Grafics.Table(68, 3, 0, 27);
            Grafics.Table(68, 3, 0, 30);

            Grafics.Line(21, 30, 43, 30);
            Grafics.Line(21, 32, 43, 32);
            Grafics.Line(21, 30, 21, 32);
            Grafics.Line(43, 30, 43, 32);

            string str = Text.greeting[Profile.lang_id] + ", " + Profile.nickname + '!';
            Console.SetCursorPosition(Grafics.TextCentered(Profile.lang_id, str, 68), 1);
            Console.WriteLine(str);
            Console.SetCursorPosition(Grafics.TextCentered(Profile.lang_id, Grafics.TokensToDay(), 68), 4);
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

            int tokens;
            if (Profile.stat_id == 0)
            {
                tokens = Text.Preis[Profile.stat_id];
                str = "После покупки " + Text.status[Profile.stat_id + 1] + " Kit " + '-' + tokens + " tokens";
            }
            else if (Profile.stat_id != 8)
            {
                tokens = Text.Preis[Profile.stat_id] - Text.Preis[Profile.stat_id - 1];
                str = "После покупки " + Text.status[Profile.stat_id + 1] + " Kit " + '-' + tokens + " tokens";
            }
            else
            {
                str = "Вы преобрели максимальный статус!";
            }
            Console.SetCursorPosition(Grafics.TextCentered(Profile.lang_id, str, 50) + 19, 8);
            Console.Write(str);

            int j = Profile.stat_id;

            Grafics.DrawPreis(13, j++, "ОК");
            Grafics.DrawPreis(20, j++);
            Grafics.DrawPreis(27, j++);
            Grafics.DrawPreis(34, j++);
            Grafics.DrawPreis(41, j++);
            Grafics.DrawPreis(48, j++);
            Grafics.DrawPreis(55, j++);
            Grafics.DrawPreis(62, j++);

            Console.ReadKey();
        }
    }
}
