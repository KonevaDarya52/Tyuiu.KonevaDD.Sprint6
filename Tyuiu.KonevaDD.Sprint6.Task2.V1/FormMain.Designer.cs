namespace Tyuiu.KonevaDD.Sprint6.Task2.V1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxOne_ZNA = new GroupBox();
            labelCondition_ZNA = new Label();
            groupBoxTwo_ZNA = new GroupBox();
            buttonPerform_ZNA = new Button();
            buttonReference_ZNA = new Button();
            textBoxInputEnd_ZNA = new TextBox();
            textBoxInputStart_ZNA = new TextBox();
            labelEnd_ZNA = new Label();
            labelStart_ZNA = new Label();
            groupBoxThree_ZNA = new GroupBox();
            textBoxResult_ZNA = new TextBox();
            labelResult_ZNA = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxOne_ZNA.SuspendLayout();
            groupBoxTwo_ZNA.SuspendLayout();
            groupBoxThree_ZNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOne_ZNA
            // 
            groupBoxOne_ZNA.Controls.Add(chart1);
            groupBoxOne_ZNA.Controls.Add(labelCondition_ZNA);
            groupBoxOne_ZNA.Location = new Point(14, 16);
            groupBoxOne_ZNA.Margin = new Padding(3, 4, 3, 4);
            groupBoxOne_ZNA.Name = "groupBoxOne_ZNA";
            groupBoxOne_ZNA.Padding = new Padding(3, 4, 3, 4);
            groupBoxOne_ZNA.Size = new Size(622, 455);
            groupBoxOne_ZNA.TabIndex = 0;
            groupBoxOne_ZNA.TabStop = false;
            groupBoxOne_ZNA.Text = "Условие";
            // 
            // labelCondition_ZNA
            // 
            labelCondition_ZNA.AutoSize = true;
            labelCondition_ZNA.Location = new Point(7, 33);
            labelCondition_ZNA.Name = "labelCondition_ZNA";
            labelCondition_ZNA.Size = new Size(604, 20);
            labelCondition_ZNA.TabIndex = 0;
            labelCondition_ZNA.Text = "Табулировать функцию F(x) = cos(x) + sin(x)/(2-2x) - 4x на диапазоне [-5; 5] с шагом 1.";
            // 
            // groupBoxTwo_ZNA
            // 
            groupBoxTwo_ZNA.Controls.Add(buttonPerform_ZNA);
            groupBoxTwo_ZNA.Controls.Add(buttonReference_ZNA);
            groupBoxTwo_ZNA.Controls.Add(textBoxInputEnd_ZNA);
            groupBoxTwo_ZNA.Controls.Add(textBoxInputStart_ZNA);
            groupBoxTwo_ZNA.Controls.Add(labelEnd_ZNA);
            groupBoxTwo_ZNA.Controls.Add(labelStart_ZNA);
            groupBoxTwo_ZNA.Location = new Point(14, 479);
            groupBoxTwo_ZNA.Margin = new Padding(3, 4, 3, 4);
            groupBoxTwo_ZNA.Name = "groupBoxTwo_ZNA";
            groupBoxTwo_ZNA.Padding = new Padding(3, 4, 3, 4);
            groupBoxTwo_ZNA.Size = new Size(611, 105);
            groupBoxTwo_ZNA.TabIndex = 1;
            groupBoxTwo_ZNA.TabStop = false;
            groupBoxTwo_ZNA.Text = "Вывод данных";
            // 
            // buttonPerform_ZNA
            // 
            buttonPerform_ZNA.BackColor = Color.Green;
            buttonPerform_ZNA.Location = new Point(435, 24);
            buttonPerform_ZNA.Margin = new Padding(3, 4, 3, 4);
            buttonPerform_ZNA.Name = "buttonPerform_ZNA";
            buttonPerform_ZNA.Size = new Size(169, 73);
            buttonPerform_ZNA.TabIndex = 6;
            buttonPerform_ZNA.Text = "Выполнить";
            buttonPerform_ZNA.UseVisualStyleBackColor = false;
            buttonPerform_ZNA.Click += buttonPerform_ZNA_Click;
            // 
            // buttonReference_ZNA
            // 
            buttonReference_ZNA.BackColor = Color.FromArgb(0, 192, 192);
            buttonReference_ZNA.Location = new Point(336, 24);
            buttonReference_ZNA.Margin = new Padding(3, 4, 3, 4);
            buttonReference_ZNA.Name = "buttonReference_ZNA";
            buttonReference_ZNA.Size = new Size(93, 73);
            buttonReference_ZNA.TabIndex = 5;
            buttonReference_ZNA.Text = "Справка";
            buttonReference_ZNA.UseVisualStyleBackColor = false;
            buttonReference_ZNA.Click += buttonReference_ZNA_Click;
            // 
            // textBoxInputEnd_ZNA
            // 
            textBoxInputEnd_ZNA.Location = new Point(173, 65);
            textBoxInputEnd_ZNA.Margin = new Padding(3, 4, 3, 4);
            textBoxInputEnd_ZNA.Multiline = true;
            textBoxInputEnd_ZNA.Name = "textBoxInputEnd_ZNA";
            textBoxInputEnd_ZNA.Size = new Size(138, 39);
            textBoxInputEnd_ZNA.TabIndex = 3;
            // 
            // textBoxInputStart_ZNA
            // 
            textBoxInputStart_ZNA.Location = new Point(0, 65);
            textBoxInputStart_ZNA.Margin = new Padding(3, 4, 3, 4);
            textBoxInputStart_ZNA.Multiline = true;
            textBoxInputStart_ZNA.Name = "textBoxInputStart_ZNA";
            textBoxInputStart_ZNA.Size = new Size(141, 39);
            textBoxInputStart_ZNA.TabIndex = 2;
            // 
            // labelEnd_ZNA
            // 
            labelEnd_ZNA.AutoSize = true;
            labelEnd_ZNA.Location = new Point(173, 37);
            labelEnd_ZNA.Name = "labelEnd_ZNA";
            labelEnd_ZNA.Size = new Size(94, 20);
            labelEnd_ZNA.TabIndex = 1;
            labelEnd_ZNA.Text = "Конец шага:";
            // 
            // labelStart_ZNA
            // 
            labelStart_ZNA.AutoSize = true;
            labelStart_ZNA.Location = new Point(7, 33);
            labelStart_ZNA.Name = "labelStart_ZNA";
            labelStart_ZNA.Size = new Size(88, 20);
            labelStart_ZNA.TabIndex = 0;
            labelStart_ZNA.Text = "Старт шага:";
            // 
            // groupBoxThree_ZNA
            // 
            groupBoxThree_ZNA.Controls.Add(textBoxResult_ZNA);
            groupBoxThree_ZNA.Controls.Add(labelResult_ZNA);
            groupBoxThree_ZNA.Location = new Point(642, 16);
            groupBoxThree_ZNA.Margin = new Padding(3, 4, 3, 4);
            groupBoxThree_ZNA.Name = "groupBoxThree_ZNA";
            groupBoxThree_ZNA.Padding = new Padding(3, 4, 3, 4);
            groupBoxThree_ZNA.Size = new Size(258, 568);
            groupBoxThree_ZNA.TabIndex = 1;
            groupBoxThree_ZNA.TabStop = false;
            groupBoxThree_ZNA.Text = "Вывод данных";
            // 
            // textBoxResult_ZNA
            // 
            textBoxResult_ZNA.Location = new Point(7, 65);
            textBoxResult_ZNA.Margin = new Padding(3, 4, 3, 4);
            textBoxResult_ZNA.Multiline = true;
            textBoxResult_ZNA.Name = "textBoxResult_ZNA";
            textBoxResult_ZNA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ZNA.Size = new Size(244, 493);
            textBoxResult_ZNA.TabIndex = 1;
            // 
            // labelResult_ZNA
            // 
            labelResult_ZNA.AutoSize = true;
            labelResult_ZNA.Location = new Point(7, 33);
            labelResult_ZNA.Name = "labelResult_ZNA";
            labelResult_ZNA.Size = new Size(78, 20);
            labelResult_ZNA.TabIndex = 0;
            labelResult_ZNA.Text = "Результат:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(274, 82);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(337, 334);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBoxTwo_ZNA);
            Controls.Add(groupBoxThree_ZNA);
            Controls.Add(groupBoxOne_ZNA);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            groupBoxOne_ZNA.ResumeLayout(false);
            groupBoxOne_ZNA.PerformLayout();
            groupBoxTwo_ZNA.ResumeLayout(false);
            groupBoxTwo_ZNA.PerformLayout();
            groupBoxThree_ZNA.ResumeLayout(false);
            groupBoxThree_ZNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        private GroupBox groupBoxOne_ZNA;
        private Label labelCondition_ZNA;
        private GroupBox groupBoxTwo_ZNA;
        private GroupBox groupBoxThree_ZNA;
        private Label labelResult_ZNA;
        private Label labelEnd_ZNA;
        private Label labelStart_ZNA;
        private Button buttonPerform_ZNA;
        private Button buttonReference_ZNA;
        private TextBox textBoxInputEnd_ZNA;
        private TextBox textBoxInputStart_ZNA;
        private TextBox textBoxResult_ZNA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
