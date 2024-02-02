namespace TrojanTeamLaunch
{
    partial class win_authQuestIcon
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
            inp_answrOfAuthQuest = new TextBox();
            lab_questForAuth = new Label();
            but_regLogInQuest = new Button();
            SuspendLayout();
            // 
            // inp_answrOfAuthQuest
            // 
            inp_answrOfAuthQuest.Location = new Point(12, 27);
            inp_answrOfAuthQuest.Multiline = true;
            inp_answrOfAuthQuest.Name = "inp_answrOfAuthQuest";
            inp_answrOfAuthQuest.Size = new Size(226, 48);
            inp_answrOfAuthQuest.TabIndex = 5;
            // 
            // lab_questForAuth
            // 
            lab_questForAuth.AutoSize = true;
            lab_questForAuth.Location = new Point(99, 9);
            lab_questForAuth.Name = "lab_questForAuth";
            lab_questForAuth.Size = new Size(48, 15);
            lab_questForAuth.TabIndex = 7;
            lab_questForAuth.Text = "ЛОГИН";
            lab_questForAuth.Click += lab_questForAuth_Click;
            // 
            // but_regLogInQuest
            // 
            but_regLogInQuest.Location = new Point(12, 81);
            but_regLogInQuest.Name = "but_regLogInQuest";
            but_regLogInQuest.Size = new Size(226, 31);
            but_regLogInQuest.TabIndex = 11;
            but_regLogInQuest.UseVisualStyleBackColor = true;
            but_regLogInQuest.Click += but_regLogInQuest_Click;
            // 
            // win_authQuestIcon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 124);
            Controls.Add(but_regLogInQuest);
            Controls.Add(lab_questForAuth);
            Controls.Add(inp_answrOfAuthQuest);
            Name = "win_authQuestIcon";
            Text = "win_authQuestIcon";
            Load += win_authQuestIcon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inp_answrOfAuthQuest;
        private Label lab_questForAuth;
        private Button but_regLogInQuest;
    }
}