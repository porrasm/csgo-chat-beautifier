﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGO_Chat_Beautifier {
    static class Program {

        [STAThread]
        static void Main() {
            Loop loop = new Loop();
            loop.StartLoop();
        }
    }
}
