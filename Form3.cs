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
    public partial class Form3 : Form
    {
        string[] lines = File.ReadAllLines(@"D:\Games\Курсач\TheDairyKursovaya\BDForK.txt");
        public Form3()
        {
            InitializeComponent();
        }

        public void findTheRemind()
        {
            bool exist = false;
            int i = 1;
            int year = int.Parse(textBox1.Text.Substring(6,2));
            int month = int.Parse(textBox1.Text.Substring(3, 2));
            int day = int.Parse(textBox1.Text.Substring(0, 2));
            int daycomp, monthcomp, yearcomp;
            yearcomp = int.Parse(lines[i].Substring(6, 2));
            monthcomp = int.Parse(lines[i].Substring(3, 2));
            daycomp = int.Parse(lines[i].Substring(0, 2));
            while (i <= (lines.Length - 1))
            {
                if (day ==daycomp && month == monthcomp && year == yearcomp)
                {
                    MessageBox.Show(textBox1.Text + " " + lines[i + 1] + " " + lines[i + 2] + " " + lines[i + 3] + " " + lines[i + 4]);
                    exist = true;
                }
                i += 5;
                if (i < (lines.Length - 4))
                {
                    yearcomp = int.Parse(lines[i].Substring(6, 2));
                    monthcomp = int.Parse(lines[i].Substring(3, 2));
                    daycomp = int.Parse(lines[i].Substring(0, 2));
                }
            }
            if (!exist)
            {
                MessageBox.Show("Search gave no results!");
            }
        }

        //public void findTheRemind2()
        //{
        //    bool exist = false;
        //    int i = 1;
        //    string data = textBox1.Text;
        //    string datacomp = lines[i];
        //    {
        //        if (data == datacomp)
        //        {
        //            MessageBox.Show(textBox1.Text + " " + lines[i + 1] + " " + lines[i + 2] + " " + lines[i + 3] + " " + lines[i + 4]);
        //            exist = true;
        //        }
        //        i += 5;
        //        if (i < (lines.Length - 4))
        //        {
        //            datacomp = lines[i];
        //        }
        //    }
        //    if (!exist)
        //    {
        //        MessageBox.Show("Search gave no results!");
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            findTheRemind();        
        }
    }
}
