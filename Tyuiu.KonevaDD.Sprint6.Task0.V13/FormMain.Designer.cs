namespace Tyuiu.KonevaDD.Sprint6.Task0.V13
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTask = new Label();
            labelFormula = new Label();
            labelX = new Label();
            textBoxX = new TextBox();
            labelResult = new Label();
            textBoxResult = new TextBox();
            buttonDone = new Button();
            SuspendLayout();
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(12, 9);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(493, 20);
            labelTask.TabIndex = 0;
            labelTask.Text = "Условие: Вычислить значение при x = 3, результат вывести в TextBox.";
            // 
            // labelFormula
            // 
            labelFormula.AutoSize = true;
            labelFormula.Location = new Point(12, 32);
            labelFormula.Name = "labelFormula";
            labelFormula.Size = new Size(219, 20);
            labelFormula.TabIndex = 1;
            labelFormula.Text = "Выражение: y = x^3 / (x^2 - 1)";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(12, 65);
            labelX.Name = "labelX";
            labelX.Size = new Size(127, 20);
            labelX.TabIndex = 2;
            labelX.Text = "Ввод значения x:";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(136, 62);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 27);
            textBoxX.TabIndex = 3;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(12, 105);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(78, 20);
            labelResult.TabIndex = 4;
            labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(136, 102);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(100, 27);
            textBoxResult.TabIndex = 5;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(136, 145);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(100, 35);
            buttonDone.TabIndex = 6;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 407);
            Controls.Add(buttonDone);
            Controls.Add(textBoxResult);
            Controls.Add(labelResult);
            Controls.Add(textBoxX);
            Controls.Add(labelX);
            Controls.Add(labelFormula);
            Controls.Add(labelTask);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelFormula;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonDone;
    }
}
