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

namespace TheDairyKursovaya
{
    public partial class Form1 : Form
    {
        string[] lines;
        string myName = "unknown";
        public Form1(string [] lines)
        {
            InitializeComponent();
            this.lines = lines;
            //button1
            this.button1.Size = new System.Drawing.Size(130, 98);
            ///////////////////////////////////////////////////////
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(4, 4, 40, 40);
            Region rgn = new Region(path);
            button1.Region = rgn;
            button1.BackColor = Color.Red;
            //button1,2
            this.button2.Size = new System.Drawing.Size(130, 98);
            ///////////////////////////////////////////////////////
            System.Drawing.Drawing2D.GraphicsPath path2 = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(4, 4, 40, 40);
            Region rgn2 = new Region(path);
            button2.Region = rgn;
            button2.BackColor = Color.DeepPink;
            //button2,3
            this.button3.Size = new System.Drawing.Size(130, 98);
            ///////////////////////////////////////////////////////
            System.Drawing.Drawing2D.GraphicsPath path3 = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(4, 4, 40, 40);
            Region rgn3 = new Region(path);
            button3.Region = rgn;
            button3.BackColor = Color.Blue;
            //button3,4
            this.button4.Size = new System.Drawing.Size(130, 98);
            ///////////////////////////////////////////////////////
            System.Drawing.Drawing2D.GraphicsPath path4 = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(4, 4, 40, 40);
            Region rgn4 = new Region(path);
            button4.Region = rgn;
            button4.BackColor = Color.Yellow;
            //button4,5
            this.button5.Size = new System.Drawing.Size(130, 98);
            ///////////////////////////////////////////////////////
            System.Drawing.Drawing2D.GraphicsPath path5 = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(4, 4, 40, 40);
            Region rgn5 = new Region(path);
            button5.Region = rgn;
            button5.BackColor = Color.Green;
            //button5
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (lines[0] == "0")
            {
                Form2 form2 = new Form2(lines);
                form2.Show();
                this.Close();
            }
            else
            {
                myName = lines[0];
                int lengthOfArrey = lines.Length - 2;
                int i = 0;
                int a = 1;
                while (i <= lengthOfArrey / 2)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = lines[a];
                    dataGridView1.Rows[i].Cells[1].Value = lines[a+1];
                    a = a + 2;
                    ++i;
                }
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button works!");
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllLines(@"D:\Games\Курсач\TheDairyKursovaya\BDForK.txt", lines);
        }
    }
}
