using Tyuiu.KonevaDD.Sprint6.Task4.V6.Lib;
namespace Tyuiu.KonevaDD.Sprint6.Task4.V6
{
    public partial class FormMain : Form
    {
        DataService service = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxInputFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(int.TryParse(e.KeyChar.ToString(), out int number) | e.KeyChar == '-' | Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������� ��������� ��������� ������ ������ 24-1", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            chartFunction.Series[0].Points.Clear();
            chartFunction.Titles.Clear();

            chartFunction.ChartAreas[0].AxisX.Title = "��� X";
            chartFunction.ChartAreas[0].AxisY.Title = "��� Y";

            textBoxOutput.Clear();

            int start = Convert.ToInt32(textBoxInputFrom.Text);
            int stop = Convert.ToInt32(textBoxInputTo.Text);
            double[] array = service.GetMassFunction(start, stop);
            for (int i = start, j = 0; i <= stop; i++, j++)
            {
                chartFunction.Series[0].Points.AddXY(i, array[j]);
            }
            textBoxOutput.Text = String.Join(Environment.NewLine, array);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            chartFunction.Titles.Add("������� F(x)");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutputFile.txt";
                File.WriteAllText(path, textBoxOutput.Text);

                DialogResult dialogResult = MessageBox.Show("���� " + path + " �������� �������!\n�������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("���� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
