namespace Tyuiu.KonevaDD.Sprint6.Task6.V8
{
    partial class FormAbout
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
            this.labelInfo_V8 = new System.Windows.Forms.Label();
            this.buttonOk_V8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // labelInfo_V8
            //
            this.labelInfo_V8.AutoSize = true;
            this.labelInfo_V8.Location = new System.Drawing.Point(12, 9);
            this.labelInfo_V8.Name = "labelInfo_V8";
            this.labelInfo_V8.Size = new System.Drawing.Size(480, 130);
            this.labelInfo_V8.TabIndex = 0;
            this.labelInfo_V8.Text = "Программа для выполнения задачи Спринт 6 | Таск 6 | Вариант 8 | Конева Д.Д.\r\n\r\n" +
                "Версия: 1.0\r\n\r\nАвтор: Конева Д.Д.";
            //
            // buttonOk_V8
            //
            this.buttonOk_V8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk_V8.Location = new System.Drawing.Point(434, 150);
            this.buttonOk_V8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOk_V8.Name = "buttonOk_V8";
            this.buttonOk_V8.Size = new System.Drawing.Size(82, 22);
            this.buttonOk_V8.TabIndex = 1;
            this.buttonOk_V8.Text = "ОК";
            this.buttonOk_V8.UseVisualStyleBackColor = true;
            this.buttonOk_V8.Click += new System.EventHandler(this.buttonOk_V8_Click);
            //
            // FormAbout
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 181);
            this.Controls.Add(this.buttonOk_V8);
            this.Controls.Add(this.labelInfo_V8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelInfo_V8;
        private System.Windows.Forms.Button buttonOk_V8;
    }
}