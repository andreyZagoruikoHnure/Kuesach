using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace TheDairyKursovaya
{
    public partial class Form2 : Form
    {
        string[] lines = File.ReadAllLines(@"D:\Games\Курсач\TheDairyKursovaya\BDForK.txt");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lines[0] = textBox1.Text + " " + textBox2.Text;
            File.WriteAllLines(@"D:\Games\Курсач\TheDairyKursovaya\BDForK.txt", lines);
            this.Close();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}

