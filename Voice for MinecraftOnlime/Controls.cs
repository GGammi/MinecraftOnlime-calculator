using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voice_for_MinecraftOnlime
{
    class Controls
    {
        static Controls()
        {
            cursor_position = 6;
        }

        public static int cursor_position;
        public static int screen_key;
        public static bool reset = true;
        public static bool back = true;

        public static bool control(int upper_bound, int lower_bound, string direction = "vertically")
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (direction == "vertically")
            {
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        cursor_position++;
                        break;
                    case ConsoleKey.UpArrow:
                        cursor_position--;
                        break;
                    case ConsoleKey.Enter:
                        Enter();
                        return false;
                }
            }
            else if (direction == "horizontally")
            {
                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        cursor_position++;
                        break;
                    case ConsoleKey.LeftArrow:
                        cursor_position--;
                        break;
                    case ConsoleKey.Enter:
                        Enter();
                        return false;
                }
            }
           
            if (cursor_position == upper_bound - 1)
            {
                cursor_position = lower_bound;
            }

            else if (cursor_position == lower_bound + 1)
            {
                cursor_position = upper_bound;
            }
            return true;
        }

        static void Enter()
        {
            switch (screen_key)
            {
                case 1:
                    Profile.lang_id = cursor_position - 5;
                    break;
                case 3:
                    Profile.stat_id = cursor_position - 5;
                    break;
                case 6:
                    switch (cursor_position)
                    {
                        case 14:
                            Screen.LanguageSelection();
                            break;
                        case 15:
                            Screen.EnteringNickname();
                            break;
                        case 16:
                            Screen.StatusSelection();
                            break;
                        case 17:
                            // об авторе
                            break;
                        case 18:
                            back = false;
                            reset = false;
                            break;
                        case 19:
                            back = false;
                            break;
                    }
                    break;
            }
        }
    }
}
