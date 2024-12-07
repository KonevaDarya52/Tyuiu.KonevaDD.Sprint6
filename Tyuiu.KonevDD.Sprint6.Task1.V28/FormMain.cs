﻿using Tyuiu.KonevDD.Sprint6.Task1.V28.Lib;
namespace Tyuiu.KonevDD.Sprint6.Task1.V28
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.AcceptButton = ButtonResultSAA;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        private void buttonResult_Click(object sender, EventArgs e)
        {

            try
            {
                int startStep = Convert.ToInt32(TextBoxStartStepSAA.Text);
                int stopStep = Convert.ToInt32(TextBoxStopStepSAA.Text);

                double[] res = ds.GetMassFunction(startStep, stopStep);
                string line;
                TextBoxResultSAA.Text = "";
                TextBoxResultSAA.AppendText("+-------+--------+" + Environment.NewLine);
                TextBoxResultSAA.AppendText("|    x       |       f(x)  |" + Environment.NewLine);
                TextBoxResultSAA.AppendText("+-------+--------+" + Environment.NewLine);
                for (int i = 0; i < res.Length; i++)
                {
                    Console.WriteLine(res[i]);
                    line = String.Format("|{0,5:d}       |   {1,5:f2}     |", startStep + i, res[i]);
                    TextBoxResultSAA.AppendText(line + Environment.NewLine);
                }
                TextBoxResultSAA.AppendText("+-------+--------+" + Environment.NewLine);

            }
            catch
            {

                MessageBox.Show("Ó âàñ îøèáêà, ñýð", "Âû îøèáëèñü!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //private void textBoxVar_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
        //    {
        //        e.Handled = true;
        //    }
        //}

        private void buttonHelp_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Таск 1 выполнила студентка группы АСОиУБ-24-1 Конева Дарья Денисовна", "О программе");


        }

        private void pictureBoxFormulaSAA_Click(object sender, EventArgs e)
        {

        }
    }
}