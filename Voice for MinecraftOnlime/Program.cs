﻿using System;
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
            do
            {
                Screen.LanguageSelection();
                Screen.EnteringNickname();
                Screen.StatusSelection();
                Screen.EnteringBalance();
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
