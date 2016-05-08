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
    public partial class Form1 : Form
    {
        public string[] lines = System.IO.File.ReadAllLines(@"D:\Games\Курсач\TheDairyKursovaya\BDForK.txt");

        public Form1()
        {
            InitializeComponent();
            //button1
            this.button1.Size = new System.Drawing.Size(130, 98);
            ///////////////////////////////////////////////////////
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(4, 4, 40, 40);// сам поэксперементируй.
            Region rgn = new Region(path);
            button1.Region = rgn;
            button1.BackColor = Color.Red;
            //button1,2
            this.button2.Size = new System.Drawing.Size(130, 98);
            ///////////////////////////////////////////////////////
            System.Drawing.Drawing2D.GraphicsPath path2 = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(4, 4, 40, 40);// сам поэксперементируй.
            Region rgn2 = new Region(path);
            button2.Region = rgn;
            button2.BackColor = Color.DeepPink;
            //button2,3
            this.button3.Size = new System.Drawing.Size(130, 98);
            ///////////////////////////////////////////////////////
            System.Drawing.Drawing2D.GraphicsPath path3 = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(4, 4, 40, 40);// сам поэксперементируй.
            Region rgn3 = new Region(path);
            button3.Region = rgn;
            button3.BackColor = Color.Blue;
            //button3,4
            this.button4.Size = new System.Drawing.Size(130, 98);
            ///////////////////////////////////////////////////////
            System.Drawing.Drawing2D.GraphicsPath path4 = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(4, 4, 40, 40);// сам поэксперементируй.
            Region rgn4 = new Region(path);
            button4.Region = rgn;
            button4.BackColor = Color.Yellow;
            //button4,5
            this.button5.Size = new System.Drawing.Size(130, 98);
            ///////////////////////////////////////////////////////
            System.Drawing.Drawing2D.GraphicsPath path5 = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(4, 4, 40, 40);// сам поэксперементируй.
            Region rgn5 = new Region(path);
            button5.Region = rgn;
            button5.BackColor = Color.Green;
            //button5
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (lines[0] == "0")
            {
                Form2 form = new Form2(lines);
                form.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button works!");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
