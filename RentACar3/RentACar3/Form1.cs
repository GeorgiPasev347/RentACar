using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pr = 0;
            var r = comboBox1.Text;
            if (r == "Audi A4") { pictureBox1.Image = Image.FromFile("a4.jpg"); }
            if (r == "Audi A6") { pictureBox1.Image = Image.FromFile("a6.jpg"); }
            if (r == "Audi A7") { pictureBox1.Image = Image.FromFile("2018_Audi_A7_S_Line_40_TDi_S-A_2.0"); }
            if (r == "Audi A8") { pictureBox1.Image = Image.FromFile("a8.jpg"); }

            DateTime d1, d2;
            d1 = dateTimePicker1.Value;
            d2 = dateTimePicker2.Value;
            int dni = (d2 - d1).Days;
            label10.Text = dni.ToString();


            if (r == "Audi A4") { pr = (pr + 130) * dni; }
            if (r == "Audi A6") { pr = (pr + 140) * dni; }
            if (r == "Audi A7") { pr = (pr + 150) * dni; }
            if (r == "Audi A8") { pr = (pr + 160) * dni; }

            if (checkBox1.Checked) { pr = pr + 10; }
            if (checkBox2.Checked) { pr = pr + 20; }
            if (checkBox3.Checked) { pr = pr + 30; }
            label11.Text = pr.ToString();
            MessageBox.Show("Име: " + textBox1.Text + "\n" + "Фамилия: " + textBox2.Text + "\n" + "Адрес: " + textBox3.Text + "\n" + "Автомобил: " + comboBox1.Text + "\n" + "Сума: " + label11.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
