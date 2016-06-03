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
            button1.BackColor = Color.Violet;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Blue;
            button5.BackColor = Color.LawnGreen;
        }

        public string[] Sort(string[] array)
        {
            int loop = array.Length;
            int counter = 6;
            int currentBiggerNumber = 1;
            int sortedLength = (array.Length - 2) / 5;
            string[] theBigest = new string[5] { array[1], array[2], array[3], array[4], array[5] };
            int year, month, day, year2, month2, day2;
            year = int.Parse(theBigest[0].Substring(6, 2));
            month = int.Parse(theBigest[0].Substring(3, 2));
            day = int.Parse(theBigest[0].Substring(0, 2));
            year2 = int.Parse(array[counter].Substring(6, 2));
            month2 = int.Parse(array[counter].Substring(3, 2));
            day2 = int.Parse(array[counter].Substring(0, 2));
            while ((counter - 1) / 5 <= sortedLength)
            {
                if (year < year2)
                {
                    currentBiggerNumber = counter;
                    theBigest[0] = array[counter];
                    theBigest[1] = array[counter + 1];
                    theBigest[2] = array[counter + 2];
                    theBigest[3] = array[counter + 3];
                    theBigest[4] = array[counter + 4];
                    year = int.Parse(theBigest[0].Substring(6, 2));
                    month = int.Parse(theBigest[0].Substring(3, 2));
                    day = int.Parse(theBigest[0].Substring(0, 2));
                }
                else if (year == year2)
                {
                    if (month < month2)
                    {
                        currentBiggerNumber = counter;
                        theBigest[0] = array[counter];
                        theBigest[1] = array[counter + 1];
                        theBigest[2] = array[counter + 2];
                        theBigest[3] = array[counter + 3];
                        theBigest[4] = array[counter + 4];
                        year = int.Parse(theBigest[0].Substring(6, 2));
                        month = int.Parse(theBigest[0].Substring(3, 2));
                        day = int.Parse(theBigest[0].Substring(0, 2));
                    }
                    else if (month == month2)
                    {
                        if (day < day2)
                        {
                            currentBiggerNumber = counter;
                            theBigest[0] = array[counter];
                            theBigest[1] = array[counter + 1];
                            theBigest[2] = array[counter + 2];
                            theBigest[3] = array[counter + 3];
                            theBigest[4] = array[counter + 4];
                            year = int.Parse(theBigest[0].Substring(6, 2));
                            month = int.Parse(theBigest[0].Substring(3, 2));
                            day = int.Parse(theBigest[0].Substring(0, 2));
                        }
                        else if (day == day2)
                        {
                            currentBiggerNumber = counter;
                            theBigest[0] = array[counter];
                            theBigest[1] = array[counter + 1];
                            theBigest[2] = array[counter + 2];
                            theBigest[3] = array[counter + 3];
                            theBigest[4] = array[counter + 4];
                            year = int.Parse(theBigest[0].Substring(6, 2));
                            month = int.Parse(theBigest[0].Substring(3, 2));
                            day = int.Parse(theBigest[0].Substring(0, 2));
                        }
                    }
                }
                if (counter + 5 == loop)
                {

                    array[currentBiggerNumber] = array[counter];
                    array[currentBiggerNumber + 1] = array[counter + 1];
                    array[currentBiggerNumber + 2] = array[counter + 2];
                    array[currentBiggerNumber + 3] = array[counter + 3];
                    array[currentBiggerNumber + 4] = array[counter + 4];

                    array[counter] = theBigest[0];
                    array[counter + 1] = theBigest[1];
                    array[counter + 2] = theBigest[2];
                    array[counter + 3] = theBigest[3];
                    array[counter + 4] = theBigest[4];

                    /////////////////////eliminate all the values
                    theBigest[0] = array[1];
                    theBigest[1] = array[2];
                    theBigest[2] = array[3];
                    theBigest[3] = array[4];
                    theBigest[4] = array[5];

                    counter = 6;
                    currentBiggerNumber = 1;
                    --sortedLength;
                    loop -= 5;

                    year = int.Parse(theBigest[0].Substring(6, 2));
                    month = int.Parse(theBigest[0].Substring(3, 2));
                    day = int.Parse(theBigest[0].Substring(0, 2));
                    year2 = int.Parse(array[counter].Substring(6, 2));
                    month2 = int.Parse(array[counter].Substring(3, 2));
                    day2 = int.Parse(array[counter].Substring(0, 2));
                }
                else
                {
                    counter += 5;
                    if (counter < array.Length)
                    {
                        year2 = int.Parse(array[counter].Substring(6, 2));
                        month2 = int.Parse(array[counter].Substring(3, 2));
                        day2 = int.Parse(array[counter].Substring(0, 2));

                    }
                }
            }
            return array;
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
            dataGridView1.Rows[i].Cells[0].Value = i;
            dataGridView1.Rows[i].Cells[1].Value = textBox1.Text;
            dataGridView1.Rows[i].Cells[2].Value = textBox2.Text;
            dataGridView1.Rows[i].Cells[3].Value = textBox3.Text;
            dataGridView1.Rows[i].Cells[4].Value = textBox4.Text;
            dataGridView1.Rows[i].Cells[5].Value = textBox5.Text;
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
        }

        public void DeleteAnRemind(int chosenRow)
        {
            dataGridView1.Rows.RemoveAt(chosenRow);
            --i;
            int count = 0;
            while (count < i)
            {
                if (count % 2 == 0)
                {
                    dataGridView1.Rows[count].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                }
                else
                {
                    dataGridView1.Rows[count].DefaultCellStyle.BackColor = Color.PaleTurquoise;
                }

                dataGridView1.Rows[count].Cells[0].Value = count.ToString();
                ++count;
            }
            //int currentRow = 0;
            //while (currentRow <= i)
            //{

            //}
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
                dataGridView1.Rows[i].Cells[0].Value = i;
                dataGridView1.Rows[i].Cells[1].Value = lines[m];
                dataGridView1.Rows[i].Cells[2].Value = lines[m + 1];
                dataGridView1.Rows[i].Cells[3].Value = lines[m + 2];
                dataGridView1.Rows[i].Cells[4].Value = lines[m + 3];
                dataGridView1.Rows[i].Cells[5].Value = lines[m + 4];
                if (i % 2 == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DeepSkyBlue;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.PaleTurquoise;
                }
                m = m + 5;
                ++i;
            }
        }

        public void Change(int index)
        {
            int nextCell = 0;
            while (nextCell<=i)
            {
                if (index == i)
                {

                }
                ++nextCell;
            }
        }

        public void Search()
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        //public void AlertOfTheClosest()
        //{
        //    DateTime thisDay = DateTime.Today;
        //    string currentData = thisDay.ToString("d");
        //    string closestData = 
        //    if ()
        //    {

        //    }

        //    MessageBox.Show(currentData);
        //}
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
                lines = Sort(lines);
                CreateAGrid(lines);
                //AlertOfTheClosest();
            }
        }
        //Search
        private void button1_Click(object sender, EventArgs e)
        {
            Search();
        }
        //Change
        private void button3_Click(object sender, EventArgs e)
        {
            Change(int.Parse(textBox7.Text));
        }
        //Add
        private void button5_Click(object sender, EventArgs e)
        {
            AddARemind();
            newLines[0] = lines[0];
        }
        //Delete
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button4.Visible = true;
            textBox6.Visible = true;
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
                for (int t = 1; t < lines.Length; ++t)
                {
                    if (lines[t] != " " || lines[t] != "" || lines[t] != "0" || lines[t] != null)
                    {
                        newLines[a] = lines[t];
                        ++a;
                    }
                }
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\Games\Курсач\TheDairyKursovaya\BDForK.txt"))
                    for (int r = 0; r < a; ++r)
                    {
                        file.WriteLine(newLines[r]);

                    }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button4.Visible = false;
            textBox6.Visible = false;
            DeleteAnRemind(int.Parse(textBox6.Text));
        }
    }
}
