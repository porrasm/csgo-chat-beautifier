using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGO_Chat_Beautifier {
    class Loop {

        ChatBeautifier chatBeautifier;
        CFGSaver cfg;

        public Loop() {
            chatBeautifier = new ChatBeautifier();
            cfg = new CFGSaver();
        }

        public void StartLoop() {

            while (true) {

                System.Threading.Thread.Sleep(50);

                string clipboard = Clipboard.GetText();

                if (clipboard.Length <= 1) {
                    continue;
                }

                if (clipboard.ToCharArray()[0] == '.') {

                    Console.WriteLine("Recognized command: " + clipboard);
                    HandleCommand(clipboard.Substring(1));
                } else if (clipboard.ToCharArray()[0] == '!') {
                    break;
                }
            }
        }

        private void HandleCommand(string text) {

            Clipboard.SetText("empty");

            string[] words = text.Split(Settings.lineBreakChar);

            List<string[]> wordsToSave = new List<string[]>();

            foreach (string word in words) {
                wordsToSave.Add(chatBeautifier.Beautify(word));
            }

            cfg.SaveToCFG(wordsToSave);
        }
    }
}
