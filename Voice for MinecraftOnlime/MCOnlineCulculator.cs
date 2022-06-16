using System;

namespace Voice_for_MinecraftOnlime
{
    internal class MCOnlineCulculator
    {
        public static void Run()
        {
            Console.Title = "MC_ONLINE Culculator";
            Console.SetWindowSize(68, 34);

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            do
            {
                Screen.StartScreen();

                if (Profile.manager.GetPrivateString("Profile", "saving_settings") == "false")
                {
                    Screen.LanguageSelection();
                    Screen.EnteringNickname();
                    Screen.StatusSelection();
                    Screen.EnteringBalance();
                }

                do
                {
                    Screen.MainScreen();
                    switch (Controls.cursor_position)
                    {
                        case 0:
                            Screen.EnteringBalance();
                            break;
                        case 1:
                            do
                            {
                                Screen.SettingsMenu();
                            } while (Controls.back);
                            Controls.back = true;
                            break;
                    }
                } while (Controls.reset);
                Controls.reset = true;

            } while (true);
        }
    }
}
