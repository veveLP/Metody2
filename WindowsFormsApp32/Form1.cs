using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp32
{
    public partial class Form1 : Form
    {
        public bool JePrvocislo(int i)
        {
            if (i > 1)
            {
                return Enumerable.Range(1, i).Where(x => i % x == 0).SequenceEqual(new[] { 1, i });
            }

            return false;
            
        }
        public void Prepis(TextBox textbox, ListBox listbox,string line) { listbox.Items.Add(line); }

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Controls[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] pole = new string[(int)numericUpDown1.Value];
            Random rng = new Random();
            for (int i = 0; i < (int)numericUpDown1.Value; i++)
            {
                pole[i] = rng.Next(2, 16).ToString();
            }
            textBox1.Lines = pole;
            foreach(string line in textBox1.Lines)
            {
                if (JePrvocislo(Int32.Parse(line))) { Prepis(textBox1, listBox1, line); }
            }
        }
    }
}
