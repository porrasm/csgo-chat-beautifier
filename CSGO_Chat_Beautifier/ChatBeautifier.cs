using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO_Chat_Beautifier {
    class ChatBeautifier {

        private CharToLines charToLines;
        private int maxLength = 40;

        private char empty = '░';
        private char filled = '█';

        private string[] stringLines;

        public ChatBeautifier() {
            charToLines = new CharToLines();
        }

        public string[] Beautify(string input) {

            stringLines = EmptyStringLines();

            foreach (Char c in input) {
                HandleChar(c);
            }

            return stringLines;
        }
        private void HandleChar(char c) {

            Lines lines = charToLines.GetLinesByCharacter(c);
            AppendStringLines(GetStringsFromLines(lines));
            AppendStringLines(Whitespace());
        }

        private void AppendStringLines(string[] newStringLines) {

            if (stringLines[0].Length + newStringLines[0].Length > maxLength) {
                return;
            }
            for (int i = 0; i < 5; i++) {
                stringLines[i] += newStringLines[i];
            }
        }

        private string[] GetStringsFromLines(Lines lines) {

            if (lines.Character == ' ') {
                return Whitespace();
            }

            string[] strings = EmptyStringLines();

            for (int i = 0; i < lines.LinesArray.GetLength(0); i++) {

                string line = "";

                for (int j = 0; j < lines.LinesArray.GetLength(1); j++) {

                    if (lines.LinesArray[i, j]) {
                        line += filled;
                    } else {
                        line += empty;
                    }
                }

                strings[i] = line;
            }

            return strings;
        }
        public string[] Whitespace() {

            string[] s = new string[5];
            for (int i = 0; i < 5; i++) {
                s[i] = "" + empty;
            }

            return s;
        }

        private string[] EmptyStringLines() {
            string[] stringLines = new string[5];

            for (int i = 0; i < 5; i++) {
                stringLines[i] = "";
            }

            return stringLines;
        }
    }
}
