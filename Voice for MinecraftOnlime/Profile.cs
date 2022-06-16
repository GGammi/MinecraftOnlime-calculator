using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voice_for_MinecraftOnlime
{
    class Profile
    {
        Profile()
        {
            lang_id = 0;
            stat_id = 0;
            nickname = "player";
        }

        public static int lang_id;
        public static int stat_id;
        public static string nickname;

        public static INIManager manager = new INIManager(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProfileSettings.ini"));

        public static void SavingSettings()
        {
            manager.WritePrivateString("Profile", "lang_id", Convert.ToString(lang_id));
            manager.WritePrivateString("Profile", "stat_id", Convert.ToString(stat_id));
            manager.WritePrivateString("Profile", "nickname", nickname);
            manager.WritePrivateString("Profile", "balance", Convert.ToString(Balance.get));
            manager.WritePrivateString("Profile", "saving_settings", "true");
        }

        public static void LoadingSettings()
        {
            lang_id = Convert.ToInt32(manager.GetPrivateString("Profile", "lang_id"));
            stat_id = Convert.ToInt32(manager.GetPrivateString("Profile", "stat_id"));
            nickname = manager.GetPrivateString("Profile", "nickname");
            Balance.set = Convert.ToInt32(manager.GetPrivateString("Profile", "balance"));
        }
    }
}
