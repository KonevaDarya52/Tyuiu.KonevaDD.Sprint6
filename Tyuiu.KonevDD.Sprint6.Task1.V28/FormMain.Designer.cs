namespace Tyuiu.KonevDD.Sprint6.Task1.V28
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            ButtonResultSAA = new Button();
            TextBoxResultSAA = new TextBox();
            TextBoxStartStepSAA = new TextBox();
            groupBoxConditionSAA = new GroupBox();
            pictureBoxFormulaSAA = new PictureBox();
            labelConditionSAA = new Label();
            groupBoxVarsSAA = new GroupBox();
            labelEnd = new Label();
            TextBoxStopStepSAA = new TextBox();
            labelStart = new Label();
            groupBoxOutput = new GroupBox();
            buttonHelp = new Button();
            groupBoxConditionSAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormulaSAA).BeginInit();
            groupBoxVarsSAA.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonResultSAA
            // 
            ButtonResultSAA.BackColor = SystemColors.ActiveCaption;
            ButtonResultSAA.Location = new Point(375, 493);
            ButtonResultSAA.Margin = new Padding(3, 4, 3, 4);
            ButtonResultSAA.Name = "ButtonResultSAA";
            ButtonResultSAA.Size = new Size(229, 80);
            ButtonResultSAA.TabIndex = 0;
            ButtonResultSAA.Text = "Выполнить";
            ButtonResultSAA.UseVisualStyleBackColor = false;
            ButtonResultSAA.Click += buttonResult_Click;
            // 
            // TextBoxResultSAA
            // 
            TextBoxResultSAA.BackColor = SystemColors.ControlLight;
            TextBoxResultSAA.Location = new Point(6, 29);
            TextBoxResultSAA.Margin = new Padding(3, 4, 3, 4);
            TextBoxResultSAA.Multiline = true;
            TextBoxResultSAA.Name = "TextBoxResultSAA";
            TextBoxResultSAA.ReadOnly = true;
            TextBoxResultSAA.Size = new Size(284, 527);
            TextBoxResultSAA.TabIndex = 5;
            TextBoxResultSAA.Text = "Результат";
            TextBoxResultSAA.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxStartStepSAA
            // 
            TextBoxStartStepSAA.Location = new Point(7, 56);
            TextBoxStartStepSAA.Margin = new Padding(3, 4, 3, 4);
            TextBoxStartStepSAA.Name = "TextBoxStartStepSAA";
            TextBoxStartStepSAA.Size = new Size(114, 27);
            TextBoxStartStepSAA.TabIndex = 0;
            // 
            // groupBoxConditionSAA
            // 
            groupBoxConditionSAA.Controls.Add(pictureBoxFormulaSAA);
            groupBoxConditionSAA.Controls.Add(labelConditionSAA);
            groupBoxConditionSAA.Location = new Point(55, 52);
            groupBoxConditionSAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxConditionSAA.Name = "groupBoxConditionSAA";
            groupBoxConditionSAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxConditionSAA.Size = new Size(528, 181);
            groupBoxConditionSAA.TabIndex = 7;
            groupBoxConditionSAA.TabStop = false;
            groupBoxConditionSAA.Text = "Условие";
            // 
            // pictureBoxFormulaSAA
            // 
            pictureBoxFormulaSAA.Image = (Image)resources.GetObject("pictureBoxFormulaSAA.Image");
            pictureBoxFormulaSAA.Location = new Point(6, 77);
            pictureBoxFormulaSAA.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFormulaSAA.Name = "pictureBoxFormulaSAA";
            pictureBoxFormulaSAA.Size = new Size(505, 76);
            pictureBoxFormulaSAA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFormulaSAA.TabIndex = 10;
            pictureBoxFormulaSAA.TabStop = false;
            pictureBoxFormulaSAA.Click += pictureBoxFormulaSAA_Click;
            // 
            // labelConditionSAA
            // 
            labelConditionSAA.AutoSize = true;
            labelConditionSAA.Location = new Point(7, 25);
            labelConditionSAA.Name = "labelConditionSAA";
            labelConditionSAA.Size = new Size(260, 20);
            labelConditionSAA.TabIndex = 0;
            labelConditionSAA.Text = "Вычислить выражение по формуле.\r\n";
            // 
            // groupBoxVarsSAA
            // 
            groupBoxVarsSAA.Controls.Add(labelEnd);
            groupBoxVarsSAA.Controls.Add(TextBoxStopStepSAA);
            groupBoxVarsSAA.Controls.Add(labelStart);
            groupBoxVarsSAA.Controls.Add(TextBoxStartStepSAA);
            groupBoxVarsSAA.Location = new Point(14, 476);
            groupBoxVarsSAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxVarsSAA.Name = "groupBoxVarsSAA";
            groupBoxVarsSAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxVarsSAA.Size = new Size(365, 97);
            groupBoxVarsSAA.TabIndex = 8;
            groupBoxVarsSAA.TabStop = false;
            groupBoxVarsSAA.Text = "Входные данные:";
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(155, 32);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(91, 20);
            labelEnd.TabIndex = 12;
            labelEnd.Text = "Конец шага";
            // 
            // TextBoxStopStepSAA
            // 
            TextBoxStopStepSAA.Location = new Point(155, 56);
            TextBoxStopStepSAA.Margin = new Padding(3, 4, 3, 4);
            TextBoxStopStepSAA.Name = "TextBoxStopStepSAA";
            TextBoxStopStepSAA.Size = new Size(114, 27);
            TextBoxStopStepSAA.TabIndex = 1;
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(7, 32);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(85, 20);
            labelStart.TabIndex = 2;
            labelStart.Text = "Старт шага";
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(TextBoxResultSAA);
            groupBoxOutput.Location = new Point(610, 16);
            groupBoxOutput.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput.Size = new Size(290, 568);
            groupBoxOutput.TabIndex = 9;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных:";
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(297, 500);
            buttonHelp.Margin = new Padding(3, 4, 3, 4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(57, 67);
            buttonHelp.TabIndex = 10;
            buttonHelp.Text = " ?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxVarsSAA);
            Controls.Add(groupBoxConditionSAA);
            Controls.Add(ButtonResultSAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 28 | Конева Д.Д.";
            Load += FormMain_Load;
            groupBoxConditionSAA.ResumeLayout(false);
            groupBoxConditionSAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormulaSAA).EndInit();
            groupBoxVarsSAA.ResumeLayout(false);
            groupBoxVarsSAA.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonResultSAA;
        private TextBox TextBoxResultSAA;
        private TextBox TextBoxStartStepSAA;
        private GroupBox groupBoxConditionSAA;
        private Label labelConditionSAA;
        private GroupBox groupBoxVarsSAA;
        private Label labelStart;
        private GroupBox groupBoxOutput;
        private PictureBox pictureBoxFormulaSAA;
        private Button buttonHelp;
        private Label labelEnd;
        private TextBox TextBoxStopStepSAA;
    }
}