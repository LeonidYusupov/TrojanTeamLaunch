namespace TrojanTeamLaunch
{
    partial class win_launchIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(win_launchIcon));
            but_launchOrDownloadGame = new Button();
            but_EXIT = new PictureBox();
            pic_folderForGame = new PictureBox();
            pic_help = new PictureBox();
            lab_hasnGame = new Label();
            lab_hasGame = new Label();
            openFileDialog = new OpenFileDialog();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)but_EXIT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_folderForGame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_help).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // but_launchOrDownloadGame
            // 
            but_launchOrDownloadGame.FlatStyle = FlatStyle.Flat;
            but_launchOrDownloadGame.Font = new Font("Escapists", 36F, FontStyle.Bold, GraphicsUnit.Point);
            but_launchOrDownloadGame.ForeColor = SystemColors.ButtonHighlight;
            but_launchOrDownloadGame.Location = new Point(496, 449);
            but_launchOrDownloadGame.Name = "but_launchOrDownloadGame";
            but_launchOrDownloadGame.Size = new Size(355, 72);
            but_launchOrDownloadGame.TabIndex = 0;
            but_launchOrDownloadGame.Text = "...";
            but_launchOrDownloadGame.UseVisualStyleBackColor = true;
            but_launchOrDownloadGame.Click += but_launchOrDownloadGame_Click;
            but_launchOrDownloadGame.MouseLeave += but_launchOrDownloadGame_MouseLeave;
            but_launchOrDownloadGame.MouseMove += but_launchOrDownloadGame_MouseMove;
            // 
            // but_EXIT
            // 
            but_EXIT.Image = (Image)resources.GetObject("but_EXIT.Image");
            but_EXIT.Location = new Point(824, 12);
            but_EXIT.Name = "but_EXIT";
            but_EXIT.Size = new Size(21, 21);
            but_EXIT.SizeMode = PictureBoxSizeMode.AutoSize;
            but_EXIT.TabIndex = 1;
            but_EXIT.TabStop = false;
            but_EXIT.Click += pictureBox1_Click;
            but_EXIT.MouseLeave += but_EXIT_MouseLeave;
            but_EXIT.MouseMove += but_EXIT_MouseMove;
            // 
            // pic_folderForGame
            // 
            pic_folderForGame.BackColor = Color.Black;
            pic_folderForGame.Image = (Image)resources.GetObject("pic_folderForGame.Image");
            pic_folderForGame.Location = new Point(469, 449);
            pic_folderForGame.Name = "pic_folderForGame";
            pic_folderForGame.Size = new Size(21, 21);
            pic_folderForGame.SizeMode = PictureBoxSizeMode.AutoSize;
            pic_folderForGame.TabIndex = 2;
            pic_folderForGame.TabStop = false;
            pic_folderForGame.Click += pic_folderForGame_Click;
            pic_folderForGame.MouseLeave += pic_folderForGame_MouseLeave;
            pic_folderForGame.MouseMove += pic_folderForGame_MouseMove;
            // 
            // pic_help
            // 
            pic_help.Image = (Image)resources.GetObject("pic_help.Image");
            pic_help.Location = new Point(469, 476);
            pic_help.Name = "pic_help";
            pic_help.Size = new Size(21, 21);
            pic_help.SizeMode = PictureBoxSizeMode.AutoSize;
            pic_help.TabIndex = 3;
            pic_help.TabStop = false;
            pic_help.MouseLeave += pic_help_MouseLeave;
            pic_help.MouseMove += pic_help_MouseMove;
            // 
            // lab_hasnGame
            // 
            lab_hasnGame.AutoSize = true;
            lab_hasnGame.Font = new Font("Escapists", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lab_hasnGame.ForeColor = Color.Gray;
            lab_hasnGame.Location = new Point(496, 412);
            lab_hasnGame.Name = "lab_hasnGame";
            lab_hasnGame.Size = new Size(349, 34);
            lab_hasnGame.TabIndex = 4;
            lab_hasnGame.Text = "Похоже, что этой игры нет на вашем компьютере. Вы \r\nможете начать скачивание с помощью кнопки ниже!\r\n";
            // 
            // lab_hasGame
            // 
            lab_hasGame.AutoSize = true;
            lab_hasGame.Font = new Font("Escapists", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lab_hasGame.ForeColor = Color.Gray;
            lab_hasGame.Location = new Point(490, 429);
            lab_hasGame.Name = "lab_hasGame";
            lab_hasGame.Size = new Size(319, 17);
            lab_hasGame.TabIndex = 5;
            lab_hasGame.Text = "Игра готова к запуску! Спасибо за Ваше внимание.";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.InitialDirectory = "C:\\Users\\user\\source\\repos\\TrojanTeamLaunch\\Games";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 414);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 485);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(54, 485);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            pictureBox2.MouseMove += pictureBox2_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Escapists", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(452, 125);
            label1.Name = "label1";
            label1.Size = new Size(399, 66);
            label1.TabIndex = 14;
            label1.Text = "Artificial Ethics";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Escapists", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(465, 191);
            label2.Name = "label2";
            label2.Size = new Size(386, 187);
            label2.TabIndex = 15;
            label2.Text = resources.GetString("label2.Text");
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Escapists", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(395, 504);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 16;
            label3.Text = "DEV. alpha 6.3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Escapists", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 12);
            label4.Name = "label4";
            label4.Size = new Size(536, 66);
            label4.TabIndex = 17;
            label4.Text = "TrojanTeam Games";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Escapists", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(153, 191);
            label5.Name = "label5";
            label5.Size = new Size(187, 44);
            label5.TabIndex = 18;
            label5.Text = "Новости..?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Escapists", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(158, 235);
            label6.Name = "label6";
            label6.Size = new Size(242, 17);
            label6.TabIndex = 19;
            label6.Text = "Ну, в планах, они тут должны быть :)\r\n";
            // 
            // win_launchIcon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(860, 530);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(lab_hasGame);
            Controls.Add(lab_hasnGame);
            Controls.Add(pic_help);
            Controls.Add(pic_folderForGame);
            Controls.Add(but_EXIT);
            Controls.Add(but_launchOrDownloadGame);
            FormBorderStyle = FormBorderStyle.None;
            Name = "win_launchIcon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrojanTeam Launcher!";
            Load += win_launchIcon_Load_1;
            MouseMove += win_launchIcon_MouseMove;
            ((System.ComponentModel.ISupportInitialize)but_EXIT).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_folderForGame).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_help).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but_launchOrDownloadGame;
        private PictureBox but_EXIT;
        private PictureBox pic_folderForGame;
        private PictureBox pic_help;
        private Label lab_hasnGame;
        private Label lab_hasGame;
        private OpenFileDialog openFileDialog;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}