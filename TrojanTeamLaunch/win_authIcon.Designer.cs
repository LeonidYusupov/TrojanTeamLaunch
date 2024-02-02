namespace TrojanTeamLaunch
{
    partial class win_authIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(win_authIcon));
            inp_authLogin = new TextBox();
            inp_authPswrd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            but_authLogIn = new Button();
            lab_errors = new Label();
            lab_forNewAcc = new Label();
            but_EXIT = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)but_EXIT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // inp_authLogin
            // 
            inp_authLogin.Font = new Font("Escapists", 36F, FontStyle.Regular, GraphicsUnit.Point);
            inp_authLogin.Location = new Point(12, 128);
            inp_authLogin.MaxLength = 15;
            inp_authLogin.Name = "inp_authLogin";
            inp_authLogin.Size = new Size(275, 40);
            inp_authLogin.TabIndex = 0;
            inp_authLogin.TextAlign = HorizontalAlignment.Center;
            inp_authLogin.TextChanged += inp_authLogin_TextChanged;
            // 
            // inp_authPswrd
            // 
            inp_authPswrd.Font = new Font("Escapists", 36F, FontStyle.Regular, GraphicsUnit.Point);
            inp_authPswrd.Location = new Point(12, 212);
            inp_authPswrd.MaxLength = 10;
            inp_authPswrd.Name = "inp_authPswrd";
            inp_authPswrd.PasswordChar = '■';
            inp_authPswrd.Size = new Size(275, 40);
            inp_authPswrd.TabIndex = 1;
            inp_authPswrd.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Escapists", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(104, 92);
            label1.Name = "label1";
            label1.Size = new Size(93, 33);
            label1.TabIndex = 2;
            label1.Text = "ЛОГИН";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Escapists", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(102, 176);
            label2.Name = "label2";
            label2.Size = new Size(108, 33);
            label2.TabIndex = 3;
            label2.Text = "ПАРОЛЬ";
            label2.Click += label2_Click;
            // 
            // but_authLogIn
            // 
            but_authLogIn.BackColor = Color.Black;
            but_authLogIn.FlatStyle = FlatStyle.Flat;
            but_authLogIn.Font = new Font("Escapists", 36F, FontStyle.Bold, GraphicsUnit.Point);
            but_authLogIn.ForeColor = SystemColors.Control;
            but_authLogIn.Location = new Point(12, 258);
            but_authLogIn.Name = "but_authLogIn";
            but_authLogIn.Size = new Size(275, 48);
            but_authLogIn.TabIndex = 4;
            but_authLogIn.Text = "ВОЙТИ";
            but_authLogIn.UseVisualStyleBackColor = false;
            but_authLogIn.Click += but_authLogIn_Click;
            but_authLogIn.MouseLeave += but_authLogIn_MouseLeave;
            but_authLogIn.MouseMove += but_authLogIn_MouseMove;
            // 
            // lab_errors
            // 
            lab_errors.AutoSize = true;
            lab_errors.Font = new Font("Escapists", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lab_errors.ForeColor = Color.Red;
            lab_errors.Location = new Point(12, 329);
            lab_errors.Name = "lab_errors";
            lab_errors.Size = new Size(228, 17);
            lab_errors.TabIndex = 6;
            lab_errors.Text = "Тут явно что-то будет начиркано.\r\n";
            lab_errors.Click += lab_errors_Click;
            lab_errors.Leave += lab_errors_Leave;
            lab_errors.MouseClick += lab_errors_MouseClick;
            lab_errors.MouseMove += lab_errors_MouseMove;
            // 
            // lab_forNewAcc
            // 
            lab_forNewAcc.AutoSize = true;
            lab_forNewAcc.Font = new Font("Escapists", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lab_forNewAcc.ForeColor = Color.DimGray;
            lab_forNewAcc.Location = new Point(46, 306);
            lab_forNewAcc.Name = "lab_forNewAcc";
            lab_forNewAcc.Size = new Size(208, 17);
            lab_forNewAcc.TabIndex = 7;
            lab_forNewAcc.Text = "Ещё нет аккаунта в этой дыре?";
            lab_forNewAcc.Click += label3_Click;
            lab_forNewAcc.MouseMove += lab_forNewAcc_MouseMove;
            // 
            // but_EXIT
            // 
            but_EXIT.Image = (Image)resources.GetObject("but_EXIT.Image");
            but_EXIT.Location = new Point(266, 12);
            but_EXIT.Name = "but_EXIT";
            but_EXIT.Size = new Size(21, 21);
            but_EXIT.SizeMode = PictureBoxSizeMode.AutoSize;
            but_EXIT.TabIndex = 8;
            but_EXIT.TabStop = false;
            but_EXIT.Click += pictureBox1_Click;
            but_EXIT.MouseLeave += but_EXIT_MouseLeave;
            but_EXIT.MouseMove += pictureBox1_MouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(239, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(124, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // win_authIcon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(299, 353);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(but_EXIT);
            Controls.Add(lab_forNewAcc);
            Controls.Add(lab_errors);
            Controls.Add(but_authLogIn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inp_authPswrd);
            Controls.Add(inp_authLogin);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(2, 2);
            Name = "win_authIcon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            Load += win_authIcon_Load;
            Leave += win_authIcon_Leave;
            ((System.ComponentModel.ISupportInitialize)but_EXIT).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inp_authLogin;
        private TextBox inp_authPswrd;
        private Label label1;
        private Label label2;
        private Button but_authLogIn;
        private Label lab_errors;
        private Label lab_forNewAcc;
        private PictureBox but_EXIT;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}