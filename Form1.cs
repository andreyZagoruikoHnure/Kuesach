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
        string[] lines = File.ReadAllLines(@"D:\Games\Курсач\TheDairyKursovaya\BDForK.txt");
        string[] newLines = new string[100];
        int lengthOfArray;
        int i = 0; //Rows
        int a = 1; //newArrays length

        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.Red;
            button2.BackColor = Color.DeepPink;
            button3.BackColor = Color.Blue;
            button4.BackColor = Color.Yellow;
        }

        public void saveToArray()
        {
            newLines[a] = textBox1.Text;
            ++a;
            newLines[a] = textBox2.Text;
            ++a;
            newLines[a] = textBox3.Text;
            ++a;
            newLines[a] = textBox4.Text;
            ++a;
            newLines[a] = textBox5.Text;
            ++a;
        }

        public void AddARemind()
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[i].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[i].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[i].Cells[3].Value = textBox4.Text;
            dataGridView1.Rows[i].Cells[4].Value = textBox5.Text;
            if (i % 2 == 0)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
            }
            saveToArray();
            ++i;
            newLines[0] = lines[0];
        }

        public void DeleteAnRemind()
        {
            int currentRow = 0;
            while (currentRow <= i)
            {
                if (currentRow == 0)
                {
                        lines[(currentRow * 5) + 1] = lines[lines.Length - 5];
                        lines[(currentRow * 5) + 2] = lines[lines.Length - 4];
                        lines[(currentRow * 5) + 3] = lines[lines.Length - 3];
                        lines[(currentRow * 5) + 4] = lines[lines.Length - 2];
                        lines[(currentRow * 5) + 5] = lines[lines.Length - 1];                
                }
                i = 0;
                --lengthOfArray;
                ++currentRow;
                CreateAGrid(lines);
                dataGridView1.Rows.RemoveAt(1);
            }
        }
    
        public void clearTheArraysItem(int item)
        {
            if (item != 0)
            {
                lines[item * 5] = lines[i - 5];
                lines[(item * 5) + 1] = lines[i - 4];
                lines[(item * 5) + 2] = lines[i - 3];
                lines[(item * 5) + 3] = lines[i - 2];
                lines[(item * 5) + 4] = lines[i - 1];
            }
            else
            {
                lines[1] = lines[i - 5];
                lines[2] = lines[i - 4];
                lines[3] = lines[i - 3];
                lines[4] = lines[i - 2];
                lines[5] = lines[i - 1];
            }
        }

        public void CreateAGrid(string[] lines)
        {
            lengthOfArray = lines.Length - 2;
            int m = 1;
            while (i <= lengthOfArray / 5)
            {
                dataGridView1.Rows.Add();   
                dataGridView1.Rows[i].Cells[0].Value = lines[m];
                dataGridView1.Rows[i].Cells[1].Value = lines[m + 1];
                dataGridView1.Rows[i].Cells[2].Value = lines[m + 2];
                dataGridView1.Rows[i].Cells[3].Value = lines[m + 3];
                dataGridView1.Rows[i].Cells[4].Value = lines[m + 4];
                if (i%2==0)
                { 
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                }
                m = m + 5;
                ++i;
            }
        }

        public void AlertOfTheClosest()
        {
            MessageBox.Show("db");
        }
        //OnLoad
        private void Form1_Load(object sender, EventArgs e)
        {
            if (lines[0] == "0")
            {
                MessageBox.Show("What is your name?!");
                this.Close();
            }
            else
            {
                CreateAGrid(lines);
            }
        }
        //Search
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
        //Empty
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        //Add
        private void button5_Click(object sender, EventArgs e)
        {
            AddARemind();
        }
        //Delete
        private void button2_Click(object sender, EventArgs e)
        {
            DeleteAnRemind();
        }
        //Closed
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (newLines[0] == "" || newLines[0] == " " || newLines[0] == "0" || newLines[0] == null)
            {
                File.WriteAllLines(@"D:\Games\Курсач\TheDairyKursovaya\BDForK.txt", lines);
            }
            else
            {
                for (int t = 1; t < lines.Length && lines[t] != ""; ++t, ++a)
                {
                    newLines[a] = lines[t];

                }
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\Games\Курсач\TheDairyKursovaya\BDForK.txt"))
                    for (int r = 0; r < a; ++r)
                    {
                        file.WriteLine(newLines[r]);

                    }
            }
        }
    }
}
