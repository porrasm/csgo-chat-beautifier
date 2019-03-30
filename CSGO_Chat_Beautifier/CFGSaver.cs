using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CSGO_Chat_Beautifier {
    class CFGSaver {

        private string cfgFolder = "C:/Program Files (x86)/Steam/steamapps/common/Counter-Strike Global Offensive/csgo/cfg";
        private string bind = "F1";
        private string aliasName = "beautifiedChat";
        private string updateName = "beautifiedChatUpdate";
        private string updateBind = "F2";

        public void SaveToCFG(string[] stringLines) {

            string path = cfgFolder + "/" + aliasName + ".cfg";
            string toSave = StringToSave(stringLines);

            File.WriteAllText(path, toSave);
        }

        private string StringToSave(string[] stringLines) {

            StringBuilder cfg = new StringBuilder();

            cfg.Append($"bind \"{updateBind}\" \"{updateName}\"\n");
            cfg.Append($"alias \"{updateName}\" \"exec {aliasName}\"\n");

            cfg.Append($"bind \"{bind}\" \"{aliasName}\"\n");
            cfg.Append($"alias \"{aliasName}\" \"{aliasName}0\"\n");

            for (int i = 0; i < 4; i++) {
                cfg.Append($"alias \"{aliasName}{i}\" \"say {stringLines[i]}; alias {aliasName} {aliasName}{i + 1}\"\n");
            }
            cfg.Append($"alias \"{aliasName}{4}\" \"say {stringLines[4]}; alias {aliasName} {aliasName}{0}\"\n");

            return cfg.ToString();
        }
    }
}
