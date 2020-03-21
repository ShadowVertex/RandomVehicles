using GTA.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomVehicles.GUI
{
    class TextGUI : IGUI
    {

        private TextElement debugUIText = new TextElement("", new Point(40, 20), 0.5f, Color.White, GTA.UI.Font.ChaletLondon, Alignment.Left, true, true);
        private TextElement debugUIText2 = new TextElement("", new Point(40, 40), 0.5f, Color.White, GTA.UI.Font.ChaletLondon, Alignment.Left, true, true);

        private List<string> startupMessages = new List<string>();
        private string startupSubtitle = "";


        public TextGUI() { }


        public void ShowSubtitle(string text, int time)
        {
            Screen.ShowSubtitle(text, time);
        }

        public void ShowNotification(string message)
        {
            Notification.Show(message);
        }


        public void Draw(string debugText, string debugText2)
        {
            debugUIText.Caption = debugText;
            debugUIText.Draw();

            debugUIText2.Caption = debugText2;
            debugUIText2.Draw();
        }


        public void ShowStartupMessages()
        {
            if (startupSubtitle != null) Screen.ShowSubtitle(startupSubtitle, 5000);

            foreach (string startupMessage in startupMessages)
            {
                Notification.Show(startupMessage);
            }
        }


        public void AddStartupMessage(int type, string message)
        {
            if (type == 0) startupSubtitle = message;
            if (type == 1) startupMessages.Add(message);
        }
    }
}
