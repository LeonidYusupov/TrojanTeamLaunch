namespace TrojanTeamLaunch
{
    partial class main_mainForm
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 45);
            label1.TabIndex = 0;
            label1.Text = "Мне очень жаль, но это должно\r\nбыть секретиком :(\r\nЯ написал эту всю шляпу за одну ночь.";
            label1.Click += label1_Click_1;
            // 
            // main_mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(243, 63);
            Controls.Add(label1);
            Cursor = Cursors.No;
            ForeColor = SystemColors.ControlText;
            Name = "main_mainForm";
            Text = "Бл@дский цирк";
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
