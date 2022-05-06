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
            return "Баланс на " + DateTime.Now + " равен: " + Balance.get + " tokens";
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
        public static void SelectItem<T>(int start_position, int end_position, List<T> list) // рисует курсор
        {

            foreach (var lang in list)
            {
                for (int j = start_position; j <= end_position; j++)
                {
                    Console.SetCursorPosition(18, j);
                    Console.Write(' ');
                }
                Console.SetCursorPosition(18, Controls.cursor_position);
                Console.Write('>');
                Console.SetCursorPosition(20, start_position++);
                Console.WriteLine(lang);
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
    }
}
