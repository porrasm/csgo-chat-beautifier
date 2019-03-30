using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGO_Chat_Beautifier {
    static class Program {

        [STAThread]
        static void Main() {

            ChatBeautifier chatBeautifier = new ChatBeautifier();
            CFGSaver cfg = new CFGSaver();

            while(true) {

                System.Threading.Thread.Sleep(50);

                string clipboard = Clipboard.GetText();

                if (clipboard.Length <= 1) {
                    continue;
                }

                if (clipboard.ToCharArray()[0] == '.') {

                    Console.WriteLine("Recognized command: " + clipboard);
                    Clipboard.SetText("empty");

                    string text = clipboard.Substring(1);
                    cfg.SaveToCFG(chatBeautifier.Beautify(text));
                } else if (clipboard.ToCharArray()[0] == '!') {
                    break;
                }

                
            }
        }
    }
}
