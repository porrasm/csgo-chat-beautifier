using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CSGO_Chat_Beautifier {
    class CFGSaver {

        private StringBuilder cfg;
        private int cfgIndex;

        public void SaveToCFG(List<string[]> wordsToSave) {

            string path = Settings.cfgFolder + "/" + Settings.aliasName + ".cfg";
            string toSave = StringToSave(wordsToSave);

            File.WriteAllText(path, toSave);
        }

        private string StringToSave(List<string[]> wordsToSave) {

            InitializeCFG();

            for (int i = 0; i < wordsToSave.Count; i++) {

                bool last = i == wordsToSave.Count - 1;

                AppendNext(wordsToSave[i], last);
                if (!last) {
                    AppendEmptyLine(wordsToSave[i]);
                }
            }

            return cfg.ToString();
        }

        private void InitializeCFG() {
            cfg = new StringBuilder();
            cfgIndex = 0;

            cfg.Append($"bind \"{Settings.updateBind}\" \"{Settings.updateName}\"\n");
            cfg.Append($"alias \"{Settings.updateName}\" \"exec {Settings.aliasName}\"\n");

            cfg.Append($"bind \"{Settings.bind}\" \"{Settings.aliasName}\"\n");
            cfg.Append($"alias \"{Settings.aliasName}\" \"{Settings.aliasName}{cfgIndex}\"\n");
        }
        private void AppendNext(string[] stringLines, bool last) {

            for (int i = 0; i < 4; i++) {
                cfg.Append($"alias \"{Settings.aliasName}{cfgIndex}\" \"say {stringLines[i]}; alias {Settings.aliasName} {Settings.aliasName}{cfgIndex + 1}\"\n");
                cfgIndex++;
            }

            if (last) {
                cfg.Append($"alias \"{Settings.aliasName}{cfgIndex}\" \"say {stringLines[4]}; alias {Settings.aliasName} {Settings.aliasName}{0}\"\n");
            } else {
                cfg.Append($"alias \"{Settings.aliasName}{cfgIndex}\" \"say {stringLines[4]}; alias {Settings.aliasName} {Settings.aliasName}{cfgIndex + 1}\"\n");
                cfgIndex++;
            }
        }
        private void AppendEmptyLine(string[] stringLines) {
            int length = stringLines[0].Length;
            string emptyLine = "";

            for (int i = 0; i < length; i++) {
                emptyLine += Settings.empty;
            }

            cfg.Append($"alias \"{Settings.aliasName}{cfgIndex}\" \"say {emptyLine}; alias {Settings.aliasName} {Settings.aliasName}{cfgIndex + 1}\"\n");
            cfgIndex++;
        }
    }
}
