using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitTheCoconut
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            var path = "../../../img/background.jpg";
            Image background = new Bitmap(path);
            
            var gameSkin = new GameSkin()
            {
                BackgroundImage = background,
                BackgroundImageLayout = ImageLayout.Stretch,
                
            };

            Application.Run(gameSkin);
        }
    }
}
