using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGO_Chat_Beautifier {
    class Lines {

        private bool[,] linesArray;
        private char character;

        public Lines() {
            linesArray = new bool[5, 5];
        }

        public bool[,] LinesArray { get => linesArray; }
        public char Character { get => character; }

        public void SetRow(int row, string values) {

            foreach (char c in values) {

                int index = int.Parse("" + c) - 1;
                linesArray[row, index] = true;
            }
        }

        public void SetCharacter(char c) {
            this.character = c;
        }

        public override bool Equals(object obj) {
            
            if (obj.GetType() != this.GetType()) {
                return false;
            }

            Lines other = (Lines)obj;

            return character == other.character;
        }
    }
}
