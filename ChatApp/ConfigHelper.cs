using IniParser.Model;
using IniParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace ChatApp
{
    public static class ConfigHelper
    {
        public static IniData DICS = new IniData();

        public static List<string> LANGS = new List<string>()
        {
            "en", "vn"
        };

        public static string CURRENT_LANG = "en";

        private static FileIniDataParser parser = new FileIniDataParser();

        static ConfigHelper()
        {
            if (!File.Exists("configs.ini"))
                return;
            DICS = parser.ReadFile("configs.ini");
            CURRENT_LANG = DICS
                .Sections["settings"]["LANG"];
        }

        // string input = (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6")
        public static Color C(string key)
        {
            if (DICS.Sections["settings"] != null)
            {
                var data = DICS.Sections["settings"].GetKeyData(key);
                if (data != null && data.Value != null)
                {
                    return Color.FromArgb(Convert.ToInt32(data.Value, 16));
                }    
            }

            // Màu mặc định
            string code = "0000F1";
            Color color = Color.FromArgb(Convert.ToInt32(code, 16));
            return color;
        }

        public static bool SET_C(string key, Color color)
        {
            if (DICS.Sections["settings"] != null)
            {
                var data = DICS.Sections["settings"]
                    .GetKeyData(key);
                if (data != null && data.Value != null)
                {
                    data.Value = (color.ToArgb()).ToString("X6");
                    return true;
                }
            }

            return false;
        }

        public static string L(string key)
        {
            if (DICS.Sections[CURRENT_LANG] != null)
            {
                var data = DICS.Sections[CURRENT_LANG].GetKeyData(key);
                if (data != null && data.Value != null)
                    return data.Value;
            }

            return string.Format("L({0})", key);
        }

        public static void Save()
        {
            // Lưu lại backup file câu hinh
            File.Copy("configs.ini", string.Format("configs_{0}.ini"
                , DateTimeOffset.UtcNow.ToUnixTimeSeconds()));
            DICS["settings"]["LANG"] = CURRENT_LANG;
            parser.WriteFile("configs.ini", DICS);
        }
    }
}
