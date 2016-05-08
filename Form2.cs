using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            MessageBox.Show(lines[0]);
            this.Close();
            string myName = textBox1.Text + " " + textBox2.Text;
            MessageBox.Show(myName);
            
        }
    }
}
