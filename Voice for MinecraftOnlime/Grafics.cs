using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voice_for_MinecraftOnlime
{
    class Grafics
    {
        Grafics()
        {
        }

        static char[,] mas = new char[100, 100];

        public static void Logo()
        {
            Console.WriteLine("Minecraft Online");
            Console.WriteLine(' ');
        }

        public static string TokensToDay()
        {
            return "Баланс на " + DateTime.Now.ToLongDateString() + " равен: " + Balance.get + ' ' + Text.TokenRu(Balance.get);
        }
        public static void Rectangle(int width, int height, int x = 0, int y = 0)
        {
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height - 1)
                {
                    Console.Write('+');
                }
                else
                {
                    Console.Write('|');
                }

                if (i == 0 || i == height - 1)
                {
                    for (int j = 0; j < width - 2; j++)
                    {
                        Console.Write('-');
                    }
                }
                else
                {
                    for (int j = 0; j < width - 2; j++)
                    {
                        Console.Write(' ');
                    }
                }

                if (i == 0 || i == height - 1)
                {
                    Console.WriteLine('+');
                }
                else
                {
                    Console.WriteLine('|');
                }
            }
        }
        public static void SelectItem<T>(int start_position, int end_position, List<T> list, string direction = "vertically", int start_line = 18) // рисует курсор
        {

            foreach (var lang in list)
            {
                if (direction == "vertically")
                {
                    for (int j = start_position; j <= end_position; j++)
                    {
                        Console.SetCursorPosition(start_line, j);
                        Console.Write(' ');
                    }
                    Console.SetCursorPosition(start_line, Controls.cursor_position);
                    Console.Write('>');
                    Console.SetCursorPosition(start_line + 2, start_position++);
                    Console.WriteLine(lang);
                }
                else if (direction == "horizontally") // переписать
                {
                    Console.SetCursorPosition(7, 28);
                    Console.Write(' ');
                    Console.SetCursorPosition(47, 28);
                    Console.Write(' ');

                    switch (Controls.cursor_position)
                    {
                        case 0:
                            Console.SetCursorPosition(7, 28);
                            Console.Write('>');
                            break;
                        case 1:
                            Console.SetCursorPosition(47, 28);
                            Console.Write('>');
                            break;
                    }

                }

            }
        }
        public static int TextCentered<String>(int number, List<String> list, int size_block = 46) // пишет текст по центру блока
        {
            int centre = (size_block - Convert.ToString(list[number]).Length) / 2 + 1;

            return centre;
        }
        public static int TextCentered(string str, int size_block = 46) // пишет текст по центру блока
        {
            int centre = (size_block - str.Length) / 2 + 1;

            return centre;
        }
        public static void Line(int x1, int y1, int x2, int y2)
        {
            for (int i = x1; i < x2 + 1; i++)
            {
                for (int j = y1; j < y2 + 1; j++)
                {
                    if (y1 == y2)
                    {
                        if (mas[i, j] == '|')
                        {
                            mas[i, j] = '+';
                        }
                        else
                        {
                            mas[i, j] = '-';
                        }
                    }
                    else
                    {
                        if (mas[i, j] == '-')
                        {
                            mas[i, j] = '+';
                        }
                        else
                        {
                            mas[i, j] = '|';
                        }
                    }

                    Console.SetCursorPosition(i, j);
                    Console.Write(mas[i, j]); // бугагага я превзошел себя. Сделал машинально проверку и только потом подумал что надо сделать проверку!!!
                }
            }
        }

        public static void DrawPreis(int x, int offset, string text = " ")
        {
            bool key = true;

            for (int i = offset; i <= 8; i++)
            {
                if (x == 13 && key)
                {
                    i = 0;
                    key = false;
                }

                Console.SetCursorPosition(x, i + 10);

                if (i < Profile.stat_id)
                {
                    Console.Write(text);
                }
                else if (offset < 8 && i != 8)
                {
                    Console.Write(Text.Preis[i + 1] - Text.Preis[offset]);
                }
            }
        }

        public static void BasicScreen(string direction = "vertically", bool frame = true)
        {
            if (frame)
            {
                Grafics.Rectangle(68, 3);
                Grafics.Rectangle(68, 27, 0, 3);
            }

            Grafics.Rectangle(68, 3, 0, 30);

            Grafics.Line(22, 30, 44, 30);
            Grafics.Line(22, 32, 44, 32);
            Grafics.Line(22, 30, 22, 32);
            Grafics.Line(44, 30, 44, 32);

            if (direction == "vertically")
            {
                Console.SetCursorPosition(Grafics.TextCentered("влево  <", 21), 31);
                Console.Write("вверх ↑");

                Console.SetCursorPosition(Grafics.TextCentered("вправо  >", 23) + 21, 31);
                Console.Write("вниз  ↓");

                Console.SetCursorPosition(Grafics.TextCentered("ок  Enter", 21) + 45, 31);
                Console.Write("ок  Enter");
            }
            else if (direction == "horizontally")
            {
                Console.SetCursorPosition(Grafics.TextCentered("влево  <", 21), 31);
                Console.Write("влево  ←");

                Console.SetCursorPosition(Grafics.TextCentered("вправо  >", 23) + 21, 31);
                Console.Write("вправо  →");

                Console.SetCursorPosition(Grafics.TextCentered("ок  Enter", 21) + 45, 31);
                Console.Write("ок  Enter");
            }
            else if (direction == "text")
            {
                //Console.SetCursorPosition(Grafics.TextCentered("влево  <", 21), 31);
                //Console.Write("влево  ←");

                //Console.SetCursorPosition(Grafics.TextCentered("вправо  >", 23) + 21, 31);
                //Console.Write("вправо  →");

                Line(20, 15, 48, 15);
                Line(20, 17, 48, 17);

                Console.SetCursorPosition(Grafics.TextCentered("ок  Enter", 23) + 21, 31);
                Console.Write("ок  Enter");
            }
        }

        public static void DrawDays()
        {
            int days;
            string str = null;
            string[] words;
            int x = 1;

            DateTime date = new DateTime();


            for (int i = Profile.stat_id + 1; i < 8; i++)
            {
                if (Balance.get < Text.Preis[i])
                {
                    if (Profile.stat_id == 0)
                    {
                        days = (Text.Preis[i] - Balance.get) / 2;
                    }

                    else
                    {
                        days = (Text.Preis[i] - Text.Preis[i - 1] - Balance.get) / 2;
                    }
                }
                else days = 0;

                date = DateTime.Now;

                str = Convert.ToString(date.AddDays(days).ToShortDateString());

                words = str.Split(new char[] { '.' });

                for (int j = 0; j < 3; j++)
                {
                    if (j != 2)
                    {
                        Console.SetCursorPosition(14 + x * 7, 19 + j);
                    }
                    else
                    {
                        Console.SetCursorPosition(13 + x * 7, 19 + j);
                    }

                    Console.Write(words[j]);
                }

                x++;
            }
        }
    }
}
