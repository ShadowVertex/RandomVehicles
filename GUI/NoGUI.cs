using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomVehicles.GUI
{
    class NoGUI : IGUI
    {
        public void ShowSubtitle(string text, int time) { }
        public void ShowNotification(string message) { }
        public void Draw(string debugText, string debugText2) { }
        public void ShowStartupMessages() { }
        public void AddStartupMessage(int type, string message) { }
    }
}
