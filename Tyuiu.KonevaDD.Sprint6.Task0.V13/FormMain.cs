using Tyuiu.KonevaDD.Sprint6.Task0.V13.Lib;
using System;
using System.Windows.Forms;

namespace Tyuiu.KonevaDD.Sprint6.Task0.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxX.Text))
                {
                    MessageBox.Show("Поле должно быть заполнено.");
                    return;
                }

                int x = Convert.ToInt32(textBoxX.Text);

                DataService ds = new DataService();
                double result = ds.Calculate(x);

                textBoxResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное число.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void labelX_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
