using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrojanTeamLaunch
{
    public partial class win_authIcon : Form
    {

        private bool user_is_authed = false;
        private main_mainForm to_mainWin;
        private DBWorker dbworker;


        public win_authIcon(main_mainForm to_mainWin, DBWorker dbworker)
        {
            InitializeComponent();
            this.to_mainWin = to_mainWin;
            this.dbworker = dbworker;
            lab_errors.Visible = false;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void win_authIcon_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!user_is_authed)
            {
                dbworker.DisconnetToMyDB();
                Application.Exit();
            }
        }
        /*private void win_authIcon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!user_is_authed)
            {
                dbworker.DisconnetToMyDB();
                Application.Exit();
            }
        } // Выход из окна авторизации - прекращение работы программы.*/

        private void but_authLogIn_Click(object sender, EventArgs e)
        {
            //string user = "user";
            //string pswrd = "123";
            string inp_login = inp_authLogin.Text;
            string inp_pswrd = inp_authPswrd.Text;
            if (!inp_login.Contains('\'') || !inp_login.Contains('-'))
            {
                if (dbworker.authUser(inp_login, inp_pswrd) == true)
                {
                    to_mainWin.UserIsAuthed();
                    user_is_authed = true;
                    this.Close();
                }
                else
                {
                    // MessageBox.Show("А тут ты ошибся, прохиндей!"); 
                    if (inp_login != "") { lab_errors.Text = "Неверный логин или пароль."; }
                    else
                    {
                        lab_errors.Text = "По-серьёзнее, пожалуйста.";
                        lab_errors.Visible = true;
                    }
                    lab_errors.Visible = true;
                }
            }
            else
            {
                lab_errors.Text = "*Недовольные тарахтения аппарата.*";
                lab_errors.Visible = true;
            }
        }


        private void lin_authNeedacc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            win_regIcon win_RegIcon = new win_regIcon(dbworker);
            win_RegIcon.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lab_errors_Leave(object sender, EventArgs e)
        {
            //lab_errors.Visible = false;
        }

        private void lab_errors_MouseClick(object sender, MouseEventArgs e)
        {
            lab_errors.Visible = false;
        }

        private void win_authIcon_Leave(object sender, EventArgs e)
        {
            lab_errors.Visible = false;
        }

        private void lab_errors_Click(object sender, EventArgs e)
        {

        }

        private void lab_errors_MouseMove(object sender, MouseEventArgs e)
        {
            lab_errors.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            win_regIcon win_RegIcon = new win_regIcon(dbworker);
            win_RegIcon.ShowDialog();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void but_authLogIn_MouseMove(object sender, MouseEventArgs e)
        {
            lab_forNewAcc.ForeColor = Color.Silver;
            but_authLogIn.BackColor = Color.DimGray;
        }

        private void but_authLogIn_MouseLeave(object sender, EventArgs e)
        {
            lab_forNewAcc.ForeColor = Color.Gray;
            but_authLogIn.BackColor = Color.Black;
        }

        private void lab_forNewAcc_MouseMove(object sender, MouseEventArgs e)
        {
            lab_forNewAcc.ForeColor = Color.White;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            but_EXIT.BackColor = Color.DimGray;
        }

        private void but_EXIT_MouseLeave(object sender, EventArgs e)
        {
            but_EXIT.BackColor = Color.Black;
        }

        private void inp_authLogin_TextChanged(object sender, EventArgs e)
        {
            string inp_login = inp_authLogin.Text;
            if (inp_login == "since" || inp_login == "Since" || inp_login == "SINCE") {
                string url = "https://www.youtube.com/watch?v=1k6K85YPiIQ";
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });

                Application.Exit();
            }
        }
    }
}
