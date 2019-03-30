using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO_Chat_Beautifier {
    class Settings {

        public static char empty = '░';
        public static char filled = '█';

        public static char whitespaceChar = ';';
        public static char lineBreakChar = ' ';

        public static string cfgFolder = "C:/Program Files (x86)/Steam/steamapps/common/Counter-Strike Global Offensive/csgo/cfg";
        public static string bind = "F1";
        public static string aliasName = "beautifiedChat";
        public static string updateName = "beautifiedChatUpdate";
        public static string updateBind = "F2";

        public static void ParseSettings() {

        }
    }
}
