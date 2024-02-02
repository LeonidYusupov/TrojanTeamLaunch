namespace TrojanTeamLaunch
{
    partial class win_regIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(win_regIcon));
            label2 = new Label();
            label1 = new Label();
            inp_regPswrFr = new TextBox();
            inp_regLogin = new TextBox();
            label3 = new Label();
            inp_regPswrSc = new TextBox();
            but_regLogIn = new Button();
            lab_errors = new Label();
            but_EXIT = new PictureBox();
            lab_acces = new Label();
            ((System.ComponentModel.ISupportInitialize)but_EXIT).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Escapists", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(98, 91);
            label2.Name = "label2";
            label2.Size = new Size(108, 33);
            label2.TabIndex = 7;
            label2.Text = "ПАРОЛЬ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Escapists", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 33);
            label1.TabIndex = 6;
            label1.Text = "ЛОГИН";
            label1.Click += label1_Click;
            // 
            // inp_regPswrFr
            // 
            inp_regPswrFr.Font = new Font("Escapists", 36F, FontStyle.Regular, GraphicsUnit.Point);
            inp_regPswrFr.Location = new Point(12, 128);
            inp_regPswrFr.MaxLength = 10;
            inp_regPswrFr.Name = "inp_regPswrFr";
            inp_regPswrFr.PasswordChar = '■';
            inp_regPswrFr.Size = new Size(275, 40);
            inp_regPswrFr.TabIndex = 5;
            inp_regPswrFr.TextAlign = HorizontalAlignment.Center;
            // 
            // inp_regLogin
            // 
            inp_regLogin.Font = new Font("Escapists", 36F, FontStyle.Regular, GraphicsUnit.Point);
            inp_regLogin.Location = new Point(12, 44);
            inp_regLogin.MaxLength = 15;
            inp_regLogin.Name = "inp_regLogin";
            inp_regLogin.Size = new Size(275, 40);
            inp_regLogin.TabIndex = 4;
            inp_regLogin.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Escapists", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 175);
            label3.Name = "label3";
            label3.Size = new Size(264, 33);
            label3.TabIndex = 9;
            label3.Text = "ПОВТОРИТЕ ПАРОЛЬ";
            // 
            // inp_regPswrSc
            // 
            inp_regPswrSc.Font = new Font("Escapists", 36F, FontStyle.Regular, GraphicsUnit.Point);
            inp_regPswrSc.Location = new Point(12, 212);
            inp_regPswrSc.MaxLength = 10;
            inp_regPswrSc.Name = "inp_regPswrSc";
            inp_regPswrSc.PasswordChar = '■';
            inp_regPswrSc.Size = new Size(275, 40);
            inp_regPswrSc.TabIndex = 8;
            inp_regPswrSc.TextAlign = HorizontalAlignment.Center;
            // 
            // but_regLogIn
            // 
            but_regLogIn.FlatStyle = FlatStyle.Flat;
            but_regLogIn.Font = new Font("Escapists", 36F, FontStyle.Bold, GraphicsUnit.Point);
            but_regLogIn.ForeColor = Color.White;
            but_regLogIn.Location = new Point(12, 258);
            but_regLogIn.Name = "but_regLogIn";
            but_regLogIn.Size = new Size(275, 48);
            but_regLogIn.TabIndex = 10;
            but_regLogIn.Text = "ЗАРЕГА-ТЬСЯ";
            but_regLogIn.UseVisualStyleBackColor = true;
            but_regLogIn.Click += but_regLogIn_Click;
            but_regLogIn.MouseLeave += but_regLogIn_MouseLeave;
            but_regLogIn.MouseMove += but_regLogIn_MouseMove;
            // 
            // lab_errors
            // 
            lab_errors.AutoSize = true;
            lab_errors.Font = new Font("Escapists", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lab_errors.ForeColor = Color.Red;
            lab_errors.Location = new Point(12, 329);
            lab_errors.Name = "lab_errors";
            lab_errors.Size = new Size(228, 17);
            lab_errors.TabIndex = 11;
            lab_errors.Text = "Тут явно что-то будет начиркано.\r\n";
            lab_errors.Click += lab_errors_Click;
            lab_errors.MouseMove += lab_errors_MouseMove;
            // 
            // but_EXIT
            // 
            but_EXIT.Image = (Image)resources.GetObject("but_EXIT.Image");
            but_EXIT.Location = new Point(266, 12);
            but_EXIT.Name = "but_EXIT";
            but_EXIT.Size = new Size(21, 21);
            but_EXIT.SizeMode = PictureBoxSizeMode.AutoSize;
            but_EXIT.TabIndex = 12;
            but_EXIT.TabStop = false;
            but_EXIT.Click += pictureBox1_Click;
            but_EXIT.MouseLeave += but_EXIT_MouseLeave;
            but_EXIT.MouseMove += pictureBox1_MouseMove;
            // 
            // lab_acces
            // 
            lab_acces.AutoSize = true;
            lab_acces.Font = new Font("Escapists", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lab_acces.ForeColor = Color.Lime;
            lab_acces.Location = new Point(12, 329);
            lab_acces.Name = "lab_acces";
            lab_acces.Size = new Size(218, 17);
            lab_acces.TabIndex = 13;
            lab_acces.Text = "О, кажется, это успех! Спасибо! :)\r\n";
            lab_acces.Visible = false;
            lab_acces.MouseMove += lab_acces_MouseMove;
            // 
            // win_regIcon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(299, 353);
            Controls.Add(lab_acces);
            Controls.Add(but_EXIT);
            Controls.Add(lab_errors);
            Controls.Add(but_regLogIn);
            Controls.Add(label3);
            Controls.Add(inp_regPswrSc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inp_regPswrFr);
            Controls.Add(inp_regLogin);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 500);
            Name = "win_regIcon";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Регистрация, пользователь";
            Load += win_regIcon_Load;
            ((System.ComponentModel.ISupportInitialize)but_EXIT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox inp_regPswrFr;
        private TextBox inp_regLogin;
        private Label label3;
        private TextBox inp_regPswrSc;
        private Button but_regLogIn;
        private Label lab_errors;
        private PictureBox but_EXIT;
        private Label lab_acces;
    }
}