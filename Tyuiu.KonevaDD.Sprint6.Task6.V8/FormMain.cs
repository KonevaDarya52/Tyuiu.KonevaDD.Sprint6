using Tyuiu.KonevaDD.Sprint6.Task6.V8.Lib;
namespace Tyuiu.KonevaDD.Sprint6.Task6.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonOutput_V8_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\konev\source\repos\Tyuiu.KonevaDD.Sprint6\Tyuiu.KonevaDD.Sprint6.Task6.V8\bin\Debug\net8.0-windows\InPutDataFileTask6V8.txt";
            textBoxOut_V8.Text = ds.CollectTextFromFile(path);
        }

        private void buttonFormAbout_V8_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonFindFile_V8_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_V8.ShowDialog();
                string openFilePath = openFileDialogTask_V8.FileName;
                foreach (string line in File.ReadLines(openFilePath))
                {
                    textBoxIn_V8.AppendText(line + Environment.NewLine);
                }
                groupBoxInfoEnter_V8.Text += " " + openFilePath;
                buttonOutput_V8.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Îøèáêà ïðè îòêðûòèè ôàéëà", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
