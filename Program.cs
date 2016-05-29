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
            string[] lines = File.ReadAllLines(@"D:\Games\Курсач\TheDairyKursovaya\BDForK.txt");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (lines[0]=="0")
            {
                Application.Run(new Form2());
                Application.Run(new Form1());

            }
            else {
                Application.Run(new Form1());
            }
        }
    }
}
