namespace Tyuiu.KonevaDD.Sprint6.Task6.V8
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
            this.components = new System.ComponentModel.Container();
            this.panelTools_V8 = new System.Windows.Forms.Panel();
            this.buttonFormAbout_V8 = new System.Windows.Forms.Button();
            this.buttonOutput_V8 = new System.Windows.Forms.Button();
            this.buttonFindFile_V8 = new System.Windows.Forms.Button();
            this.groupBoxInfoExit_V8 = new System.Windows.Forms.GroupBox();
            this.textBoxOut_V8 = new System.Windows.Forms.TextBox();
            this.groupBoxInfoEnter_V8 = new System.Windows.Forms.GroupBox();
            this.textBoxIn_V8 = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_V8 = new System.Windows.Forms.OpenFileDialog();
            this.toolTipHelp_V8 = new System.Windows.Forms.ToolTip(this.components);
            this.panelQuestion_V8 = new System.Windows.Forms.Panel();
            this.groupBoxTask_V8 = new System.Windows.Forms.GroupBox();
            this.textBoxTask_V8 = new System.Windows.Forms.TextBox();
            this.splitContainerTask_V8 = new System.Windows.Forms.SplitContainer();
            this.panelTools_V8.SuspendLayout();
            this.groupBoxInfoExit_V8.SuspendLayout();
            this.groupBoxInfoEnter_V8.SuspendLayout();
            this.panelQuestion_V8.SuspendLayout();
            this.groupBoxTask_V8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTask_V8)).BeginInit();
            this.splitContainerTask_V8.Panel1.SuspendLayout();
            this.splitContainerTask_V8.Panel2.SuspendLayout();
            this.splitContainerTask_V8.SuspendLayout();
            this.SuspendLayout();
            //
            // panelTools_V8
            //
            this.panelTools_V8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTools_V8.Controls.Add(this.buttonFindFile_V8);
            this.panelTools_V8.Controls.Add(this.buttonOutput_V8);
            this.panelTools_V8.Controls.Add(this.buttonFormAbout_V8);
            this.panelTools_V8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTools_V8.Location = new System.Drawing.Point(0, 0);
            this.panelTools_V8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTools_V8.Name = "panelTools_V8";
            this.panelTools_V8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTools_V8.Size = new System.Drawing.Size(831, 72);
            this.panelTools_V8.TabIndex = 0;
            //
            // buttonFormAbout_V8
            //
            this.buttonFormAbout_V8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFormAbout_V8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFormAbout_V8.Location = new System.Drawing.Point(743, 4);
            this.buttonFormAbout_V8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFormAbout_V8.Name = "buttonFormAbout_V8";
            this.buttonFormAbout_V8.Size = new System.Drawing.Size(82, 63);
            this.buttonFormAbout_V8.TabIndex = 0;
            this.toolTipHelp_V8.SetToolTip(this.buttonFormAbout_V8, "Нажмите, чтобы узнать о разработчике программы");
            this.buttonFormAbout_V8.UseVisualStyleBackColor = true;
            this.buttonFormAbout_V8.Click += new System.EventHandler(this.buttonFormAbout_V8_Click);
            //
            // buttonOutput_V8
            //
            this.buttonOutput_V8.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOutput_V8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOutput_V8.Enabled = false;
            this.buttonOutput_V8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutput_V8.Location = new System.Drawing.Point(117, 4);
            this.buttonOutput_V8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOutput_V8.Name = "buttonOutput_V8";
            this.buttonOutput_V8.Size = new System.Drawing.Size(107, 63);
            this.buttonOutput_V8.TabIndex = 0;
            this.toolTipHelp_V8.SetToolTip(this.buttonOutput_V8, "Провести действие и вывести результат");
            this.buttonOutput_V8.UseVisualStyleBackColor = false;
            this.buttonOutput_V8.Click += new System.EventHandler(this.buttonOutput_V8_Click);
            //
            // buttonFindFile_V8
            //
            this.buttonFindFile_V8.BackColor = System.Drawing.SystemColors.Control;
            this.buttonFindFile_V8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFindFile_V8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindFile_V8.Location = new System.Drawing.Point(5, 4);
            this.buttonFindFile_V8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFindFile_V8.Name = "buttonFindFile_V8";
            this.buttonFindFile_V8.Size = new System.Drawing.Size(107, 63);
            this.buttonFindFile_V8.TabIndex = 0;
            this.toolTipHelp_V8.SetToolTip(this.buttonFindFile_V8, "Выбрать файл для вводных данных");
            this.buttonFindFile_V8.UseVisualStyleBackColor = false;
            this.buttonFindFile_V8.Click += new System.EventHandler(this.buttonFindFile_V8_Click);
            //
            // groupBoxInfoExit_V8
            //
            this.groupBoxInfoExit_V8.Controls.Add(this.textBoxOut_V8);
            this.groupBoxInfoExit_V8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInfoExit_V8.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInfoExit_V8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInfoExit_V8.Name = "groupBoxInfoExit_V8";
            this.groupBoxInfoExit_V8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInfoExit_V8.Size = new System.Drawing.Size(406, 249);
            this.groupBoxInfoExit_V8.TabIndex = 2;
            this.groupBoxInfoExit_V8.TabStop = false;
            this.groupBoxInfoExit_V8.Text = "Вывод";
            //
            // textBoxOut_V8
            //
            this.textBoxOut_V8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_V8.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOut_V8.Location = new System.Drawing.Point(3, 18);
            this.textBoxOut_V8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOut_V8.Multiline = true;
            this.textBoxOut_V8.Name = "textBoxOut_V8";
            this.textBoxOut_V8.ReadOnly = true;
            this.textBoxOut_V8.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOut_V8.Size = new System.Drawing.Size(400, 229);
            this.textBoxOut_V8.TabIndex = 0;
            //
            // groupBoxInfoEnter_V8
            //
            this.groupBoxInfoEnter_V8.Controls.Add(this.textBoxIn_V8);
            this.groupBoxInfoEnter_V8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInfoEnter_V8.Location = new System.Drawing.Point(3, 3);
            this.groupBoxInfoEnter_V8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInfoEnter_V8.Name = "groupBoxInfoEnter_V8";
            this.groupBoxInfoEnter_V8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInfoEnter_V8.Size = new System.Drawing.Size(409, 249);
            this.groupBoxInfoEnter_V8.TabIndex = 1;
            this.groupBoxInfoEnter_V8.TabStop = false;
            this.groupBoxInfoEnter_V8.Text = "Ввод";
            //
            // textBoxIn_V8
            //
            this.textBoxIn_V8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIn_V8.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIn_V8.Location = new System.Drawing.Point(3, 18);
            this.textBoxIn_V8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIn_V8.Multiline = true;
            this.textBoxIn_V8.Name = "textBoxIn_V8";
            this.textBoxIn_V8.ReadOnly = true;
            this.textBoxIn_V8.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxIn_V8.Size = new System.Drawing.Size(403, 229);
            this.textBoxIn_V8.TabIndex = 0;
            //
            // openFileDialogTask_V8
            //
            this.openFileDialogTask_V8.FileName = "openFileDialog1";
            //
            // toolTipHelp_V8
            //
            this.toolTipHelp_V8.ToolTipTitle = "Подсказка";
            //
            // panelQuestion_V8
            //
            this.panelQuestion_V8.Controls.Add(this.groupBoxTask_V8);
            this.panelQuestion_V8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuestion_V8.Location = new System.Drawing.Point(0, 72);
            this.panelQuestion_V8.Name = "panelQuestion_V8";
            this.panelQuestion_V8.Size = new System.Drawing.Size(831, 67);
            this.panelQuestion_V8.TabIndex = 2;
            //
            // groupBoxTask_V8
            //
            this.groupBoxTask_V8.Controls.Add(this.textBoxTask_V8);
            this.groupBoxTask_V8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_V8.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_V8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTask_V8.Name = "groupBoxTask_V8";
            this.groupBoxTask_V8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTask_V8.Size = new System.Drawing.Size(831, 67);
            this.groupBoxTask_V8.TabIndex = 0;
            this.groupBoxTask_V8.TabStop = false;
            this.groupBoxTask_V8.Text = "Условие";
            //
            // textBoxTask_V8
            //
            this.textBoxTask_V8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_V8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_V8.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask_V8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTask_V8.Multiline = true;
            this.textBoxTask_V8.Name = "textBoxTask_V8";
            this.textBoxTask_V8.ReadOnly = true;
            this.textBoxTask_V8.Size = new System.Drawing.Size(825, 47);
            this.textBoxTask_V8.TabIndex = 0;
            this.textBoxTask_V8.Text = "Дан файл InPutFileTask6V8.txt который может находиться в любом месте на диске. Загрузить файл в textBoxIn через openFileDialog. Вывести слова в которых встречается z в результарующею строку и вывести ее в textBoxOut.";
            //
            // splitContainerTask_V8
            //
            this.splitContainerTask_V8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainerTask_V8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTask_V8.Location = new System.Drawing.Point(0, 139);
            this.splitContainerTask_V8.Name = "splitContainerTask_V8";
            //
            // splitContainerTask_V8.Panel1
            //
            this.splitContainerTask_V8.Panel1.Controls.Add(this.groupBoxInfoEnter_V8);
            this.splitContainerTask_V8.Panel1.Padding = new System.Windows.Forms.Padding(3);
            //
            // splitContainerTask_V8.Panel2
            //
            this.splitContainerTask_V8.Panel2.Controls.Add(this.groupBoxInfoExit_V8);
            this.splitContainerTask_V8.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainerTask_V8.Size = new System.Drawing.Size(831, 255);
            this.splitContainerTask_V8.SplitterDistance = 415;
            this.splitContainerTask_V8.TabIndex = 3;
            //
            // FormMain
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 394);
            this.Controls.Add(this.splitContainerTask_V8);
            this.Controls.Add(this.panelQuestion_V8);
            this.Controls.Add(this.panelTools_V8);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(847, 433);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 8 | Конева Д.Д.";
            this.panelTools_V8.ResumeLayout(false);
            this.groupBoxInfoExit_V8.ResumeLayout(false);
            this.groupBoxInfoExit_V8.PerformLayout();
            this.groupBoxInfoEnter_V8.ResumeLayout(false);
            this.groupBoxInfoEnter_V8.PerformLayout();
            this.panelQuestion_V8.ResumeLayout(false);
            this.groupBoxTask_V8.ResumeLayout(false);
            this.groupBoxTask_V8.PerformLayout();
            this.splitContainerTask_V8.Panel1.ResumeLayout(false);
            this.splitContainerTask_V8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTask_V8)).EndInit();
            this.splitContainerTask_V8.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTools_V8;
        private System.Windows.Forms.GroupBox groupBoxInfoExit_V8;
        private System.Windows.Forms.GroupBox groupBoxInfoEnter_V8;
        private System.Windows.Forms.TextBox textBoxOut_V8;
        private System.Windows.Forms.TextBox textBoxIn_V8;
        private System.Windows.Forms.Button buttonFindFile_V8;
        private System.Windows.Forms.Button buttonOutput_V8;
        private System.Windows.Forms.Button buttonFormAbout_V8;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_V8;
        private System.Windows.Forms.ToolTip toolTipHelp_V8;
        private System.Windows.Forms.Panel panelQuestion_V8;
        private System.Windows.Forms.GroupBox groupBoxTask_V8;
        private System.Windows.Forms.TextBox textBoxTask_V8;
        private System.Windows.Forms.SplitContainer splitContainerTask_V8;
    }
}
