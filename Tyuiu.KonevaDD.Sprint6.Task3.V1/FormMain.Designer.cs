namespace Tyuiu.KonevaDD.Sprint6.Task3.V1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxInputData = new GroupBox();
            dataGridViewMatrix = new DataGridView();
            labelCondition = new Label();
            groupBoxOutputData = new GroupBox();
            dataGridViewResult = new DataGridView();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxInputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            groupBoxOutputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInputData
            // 
            groupBoxInputData.Controls.Add(dataGridViewMatrix);
            groupBoxInputData.Controls.Add(labelCondition);
            groupBoxInputData.Location = new Point(2, 13);
            groupBoxInputData.Margin = new Padding(3, 4, 3, 4);
            groupBoxInputData.Name = "groupBoxInputData";
            groupBoxInputData.Padding = new Padding(3, 4, 3, 4);
            groupBoxInputData.Size = new Size(665, 475);
            groupBoxInputData.TabIndex = 0;
            groupBoxInputData.TabStop = false;
            groupBoxInputData.Text = " Условие ";
            groupBoxInputData.Enter += groupBoxInputData_Enter;
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(386, 26);
            dataGridViewMatrix.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.ReadOnly = true;
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.RowTemplate.Height = 24;
            dataGridViewMatrix.Size = new Size(261, 301);
            dataGridViewMatrix.TabIndex = 1;
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(7, 28);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(0, 20);
            labelCondition.TabIndex = 0;
            // 
            // groupBoxOutputData
            // 
            groupBoxOutputData.Controls.Add(dataGridViewResult);
            groupBoxOutputData.Location = new Point(676, 16);
            groupBoxOutputData.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutputData.Name = "groupBoxOutputData";
            groupBoxOutputData.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutputData.Size = new Size(294, 392);
            groupBoxOutputData.TabIndex = 1;
            groupBoxOutputData.TabStop = false;
            groupBoxOutputData.Text = "Вывод данных";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(6, 28);
            dataGridViewResult.Margin = new Padding(3, 4, 3, 4);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.RowTemplate.Height = 24;
            dataGridViewResult.Size = new Size(260, 300);
            dataGridViewResult.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(776, 416);
            buttonHelp.Margin = new Padding(3, 4, 3, 4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(56, 72);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(838, 416);
            buttonDone.Margin = new Padding(3, 4, 3, 4);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(132, 72);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 504);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxOutputData);
            Controls.Add(groupBoxInputData);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 1 | Конева Д.Д.";
            Load += FormMain_Load;
            groupBoxInputData.ResumeLayout(false);
            groupBoxInputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            groupBoxOutputData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.GroupBox groupBoxOutputData;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.DataGridView dataGridViewResult;
    }
}

