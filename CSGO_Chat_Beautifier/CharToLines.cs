using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO_Chat_Beautifier {
    class CharToLines {

        private List<Lines> chars;

        public CharToLines() {
            InitializeChars();
        }

        // All chars
        private void InitializeChars() {

            chars = new List<Lines>();

            // A
            Lines lines = new Lines();
            lines.SetCharacter('a');
            lines.SetRow(0, "234");
            lines.SetRow(1, "15");
            lines.SetRow(2, "15");
            lines.SetRow(3, "12345");
            lines.SetRow(4, "15");
            chars.Add(lines);

            // B
            lines = new Lines();
            lines.SetCharacter('b');
            lines.SetRow(0, "1234");
            lines.SetRow(1, "15");
            lines.SetRow(2, "1234");
            lines.SetRow(3, "15");
            lines.SetRow(4, "1234");
            chars.Add(lines);

            // C
            lines = new Lines();
            lines.SetCharacter('c');
            lines.SetRow(0, "234");
            lines.SetRow(1, "15");
            lines.SetRow(2, "1");
            lines.SetRow(3, "15");
            lines.SetRow(4, "234");
            chars.Add(lines);

            // D
            lines = new Lines();
            lines.SetCharacter('d');
            lines.SetRow(0, "1234");
            lines.SetRow(1, "15");
            lines.SetRow(2, "15");
            lines.SetRow(3, "15");
            lines.SetRow(4, "1234");
            chars.Add(lines);

            // E
            lines = new Lines();
            lines.SetCharacter('e');
            lines.SetRow(0, "12345");
            lines.SetRow(1, "1");
            lines.SetRow(2, "1234");
            lines.SetRow(3, "1");
            lines.SetRow(4, "12345");
            chars.Add(lines);

            // F
            lines = new Lines();
            lines.SetCharacter('f');
            lines.SetRow(0, "12345");
            lines.SetRow(1, "1");
            lines.SetRow(2, "1234");
            lines.SetRow(3, "1");
            lines.SetRow(4, "1");
            chars.Add(lines);

            // G
            lines = new Lines();
            lines.SetCharacter('g');
            lines.SetRow(0, "2345");
            lines.SetRow(1, "1");
            lines.SetRow(2, "1345");
            lines.SetRow(3, "15");
            lines.SetRow(4, "2345");
            chars.Add(lines);

            // H
            lines = new Lines();
            lines.SetCharacter('h');
            lines.SetRow(0, "15");
            lines.SetRow(1, "15");
            lines.SetRow(2, "12345");
            lines.SetRow(3, "15");
            lines.SetRow(4, "15");
            chars.Add(lines);

            // I
            lines = new Lines();
            lines.SetCharacter('i');
            lines.SetRow(0, "234");
            lines.SetRow(1, "3");
            lines.SetRow(2, "3");
            lines.SetRow(3, "3");
            lines.SetRow(4, "234");
            chars.Add(lines);

            // J
            lines = new Lines();
            lines.SetCharacter('j');
            lines.SetRow(0, "2345");
            lines.SetRow(1, "5");
            lines.SetRow(2, "5");
            lines.SetRow(3, "15");
            lines.SetRow(4, "234");
            chars.Add(lines);

            // K
            lines = new Lines();
            lines.SetCharacter('k');
            lines.SetRow(0, "14");
            lines.SetRow(1, "13");
            lines.SetRow(2, "12");
            lines.SetRow(3, "13");
            lines.SetRow(4, "14");
            chars.Add(lines);

            // L
            lines = new Lines();
            lines.SetCharacter('l');
            lines.SetRow(0, "1");
            lines.SetRow(1, "1");
            lines.SetRow(2, "1");
            lines.SetRow(3, "1");
            lines.SetRow(4, "1234");
            chars.Add(lines);

            // M
            lines = new Lines();
            lines.SetCharacter('m');
            lines.SetRow(0, "15");
            lines.SetRow(1, "1245");
            lines.SetRow(2, "135");
            lines.SetRow(3, "15");
            lines.SetRow(4, "15");
            chars.Add(lines);

            // N
            lines = new Lines();
            lines.SetCharacter('n');
            lines.SetRow(0, "14");
            lines.SetRow(1, "124");
            lines.SetRow(2, "134");
            lines.SetRow(3, "14");
            lines.SetRow(4, "14");
            chars.Add(lines);

            // O
            lines = new Lines();
            lines.SetCharacter('o');
            lines.SetRow(0, "234");
            lines.SetRow(1, "15");
            lines.SetRow(2, "15");
            lines.SetRow(3, "15");
            lines.SetRow(4, "234");
            chars.Add(lines);

            // P
            lines = new Lines();
            lines.SetCharacter('p');
            lines.SetRow(0, "1234");
            lines.SetRow(1, "15");
            lines.SetRow(2, "15");
            lines.SetRow(3, "1234");
            lines.SetRow(4, "1");
            chars.Add(lines);

            // Q
            lines = new Lines();
            lines.SetCharacter('q');
            lines.SetRow(0, "234");
            lines.SetRow(1, "15");
            lines.SetRow(2, "15");
            lines.SetRow(3, "145");
            lines.SetRow(4, "2345");
            chars.Add(lines);

            // R
            lines = new Lines();
            lines.SetCharacter('r');
            lines.SetRow(0, "1234");
            lines.SetRow(1, "15");
            lines.SetRow(2, "15");
            lines.SetRow(3, "1234");
            lines.SetRow(4, "15");
            chars.Add(lines);

            // S
            lines = new Lines();
            lines.SetCharacter('s');
            lines.SetRow(0, "2345");
            lines.SetRow(1, "1");
            lines.SetRow(2, "234");
            lines.SetRow(3, "5");
            lines.SetRow(4, "1234");
            chars.Add(lines);

            // T
            lines = new Lines();
            lines.SetCharacter('t');
            lines.SetRow(0, "12345");
            lines.SetRow(1, "3");
            lines.SetRow(2, "3");
            lines.SetRow(3, "3");
            lines.SetRow(4, "3");
            chars.Add(lines);

            // U
            lines = new Lines();
            lines.SetCharacter('u');
            lines.SetRow(0, "15");
            lines.SetRow(1, "15");
            lines.SetRow(2, "15");
            lines.SetRow(3, "15");
            lines.SetRow(4, "234");
            chars.Add(lines);

            // V
            lines = new Lines();
            lines.SetCharacter('v');
            lines.SetRow(0, "15");
            lines.SetRow(1, "15");
            lines.SetRow(2, "24");
            lines.SetRow(3, "24");
            lines.SetRow(4, "3");
            chars.Add(lines);

            // W
            lines = new Lines();
            lines.SetCharacter('w');
            lines.SetRow(0, "15");
            lines.SetRow(1, "15");
            lines.SetRow(2, "15");
            lines.SetRow(3, "135");
            lines.SetRow(4, "24");
            chars.Add(lines);

            // X
            lines = new Lines();
            lines.SetCharacter('x');
            lines.SetRow(0, "15");
            lines.SetRow(1, "24");
            lines.SetRow(2, "3");
            lines.SetRow(3, "24");
            lines.SetRow(4, "15");
            chars.Add(lines);

            // Y
            lines = new Lines();
            lines.SetCharacter('y');
            lines.SetRow(0, "15");
            lines.SetRow(1, "24");
            lines.SetRow(2, "3");
            lines.SetRow(3, "3");
            lines.SetRow(4, "3");
            chars.Add(lines);

            // Z
            lines = new Lines();
            lines.SetCharacter('z');
            lines.SetRow(0, "12345");
            lines.SetRow(1, "5");
            lines.SetRow(2, "234");
            lines.SetRow(3, "1");
            lines.SetRow(4, "12345");
            chars.Add(lines);
        }

        public Lines GetLinesByCharacter(char c) {

            foreach (Lines l in chars) {

                if (l.Character == c) {
                    return l;
                }
            }

            Lines lines = new Lines();
            lines.SetCharacter(' ');

            return lines;
        }
        
    }
}
