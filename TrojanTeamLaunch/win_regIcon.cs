using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrojanTeamLaunch
{
    public partial class win_regIcon : Form
    {
        private DBWorker dbworker;
        public win_regIcon(DBWorker dbworker)
        {
            InitializeComponent();
            this.dbworker = dbworker;
            lab_errors.Visible = false;
            lab_acces.Visible = false;
        }

        private void win_regIcon_Load(object sender, EventArgs e)
        {

        }

        private void but_regLogIn_Click(object sender, EventArgs e)
        {
            string login = inp_regLogin.Text;
            string pswrd1 = inp_regPswrFr.Text;
            string pswrd2 = inp_regPswrSc.Text;
            // string typeQuest = cmbx_categoryQuest.Text;
            // string answrQuest = inp_answr.Text;
            if (!login.Contains('\'') || !login.Contains('-'))
            {
                if (login != "" && (pswrd1 != "" || pswrd2 != ""))
                {
                    if (login.Length >= 3)
                    {
                        if (pswrd1 != pswrd2)
                        {
                            lab_errors.Text = "Введённые пароли не совпадают.";
                            lab_errors.Visible = true;
                            lab_acces.Visible = false;
                        }
                        else
                        {
                            if (dbworker.regNewUser(login, pswrd1) == false)
                            {
                                lab_errors.Text = "Кажется, кого-то так уже зовут.";
                                lab_errors.Visible = true;
                                lab_acces.Visible = false;
                            }
                            else
                            {
                                lab_errors.Visible = false;
                                lab_acces.Visible = true;
                            }
                        }
                    }
                    else {
                        lab_errors.Text = "Придумайте имя длинее, пожалуйста.";
                        lab_errors.Visible = true;
                        lab_acces.Visible = false;
                    }
                }
                else
                {
                    lab_errors.Text = "Давайте-ка не дурачиться.";
                    lab_errors.Visible = true;
                    lab_acces.Visible = false;
                }
            }
            else
            {
                lab_errors.Text = "Вы же знаете, что тут не так.";
                lab_errors.Visible = true;
                lab_acces.Visible = false;
            }
        }

        private void cmbx_categoryQuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lab_quest.Text = cmbx_categoryQuest.Text;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_regLogIn_MouseMove(object sender, MouseEventArgs e)
        {
            but_regLogIn.BackColor = Color.DimGray;
        }

        private void but_regLogIn_MouseLeave(object sender, EventArgs e)
        {
            but_regLogIn.BackColor = Color.Black;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            but_EXIT.BackColor = Color.DimGray;
        }

        private void but_EXIT_MouseLeave(object sender, EventArgs e)
        {
            but_EXIT.BackColor = Color.Black;
        }

        private void lab_acces_MouseMove(object sender, MouseEventArgs e)
        {
        }
    }
}
