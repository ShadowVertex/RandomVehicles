using System.Drawing;
using GTA.UI;

namespace RandomVehicles
{
    class GUI
    {
        private TextElement debugUIText = new TextElement("", new Point(40, 20), 0.5f, Color.White, GTA.UI.Font.ChaletLondon, Alignment.Left, true, true);
        private TextElement debugUIText2 = new TextElement("", new Point(40, 40), 0.5f, Color.White, GTA.UI.Font.ChaletLondon, Alignment.Left, true, true);

        public GUI() { }


        public void Draw(string debugText, string debugText2)
        {

            debugUIText.Caption = debugText;
            debugUIText.Draw();

            debugUIText2.Caption = debugText2;
            debugUIText2.Draw();

        }

    }
}
