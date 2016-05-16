using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TheDairyKursovaya
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string[] lines = File.ReadAllLines(@"D:\Games\Курсач\TheDairyKursovaya\BDForK.txt");
            Application.Run(new Form1(lines));
        }
    }
}
