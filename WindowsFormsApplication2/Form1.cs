using System;
using System.Windows.Forms;
using Zirpl.CalcEngine;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            F_function func = new F_function(Integral.Text, BotLim.Text, UpperLim.Text);

            
            if (func.ExampleCalculation() == "error")
                MessageBox.Show("Неправильно составленно выражение. Воспользуетесь 'Справкой'");
            else
                textBox1.Text = func.ExampleCalculation();

            if (func.ExampleCalculation() == "error_ODZ")
                MessageBox.Show("Гранцы интегрирования не соответствуют ОДЗ заданной фнкции");
            else
                textBox1.Text = func.ExampleCalculation();

            if (func.ExampleCalculation() == "error_Lim")
                MessageBox.Show("Гранцы интегрирования не указаны");
            else
                textBox1.Text = func.ExampleCalculation();
        }      

        private void Integral_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpperLim_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotLim_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Clear_Click(object sender, EventArgs e)
        {
            Integral.Text = "";
            UpperLim.Text = "";
            BotLim.Text = "";
            textBox1.Text = "";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        Form2 newForm;

        private void button1_Click(object sender, EventArgs e)
        {
            if (newForm == null || newForm.IsDisposed)
            {
                newForm = new Form2();
                newForm.Show();
            }
        }
    }
}
