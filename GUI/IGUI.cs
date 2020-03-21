using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomVehicles.GUI
{
    interface IGUI
    {
        void ShowSubtitle(string text, int time);
        void ShowNotification(string message);
        void Draw(string debugText, string debugText2);
        void ShowStartupMessages();
        void AddStartupMessage(int type, string message);
    }
}
