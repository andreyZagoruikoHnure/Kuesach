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
        string[] lines;

        public Form2(string[] lines)
        {
            InitializeComponent();
            this.lines = lines;
        }


        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            lines[0] = textBox1.Text + " " + textBox2.Text;            
            this.Close();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1(lines);
            form1.Show();
        }
    }
}
