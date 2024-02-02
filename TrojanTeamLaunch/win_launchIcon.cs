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
    public partial class win_launchIcon : Form
    {
        public win_launchIcon()
        {
            InitializeComponent();


            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(pic_help, "Чтобы Вам установить игру после скачивание,\nпожалуйста, разорхивируйте папку с игрой (целиком) в папку,\nоткрывающееся иконкой выше.");
            toolTip.SetToolTip(pic_folderForGame, "Папка с играми.");
            //toolTip.SetToolTip(but_launchOrDownloadGame, "Папка с играми.");
            toolTip.InitialDelay = 1;
        }

        private void but_launchOrDownloadGame_Click(object sender, EventArgs e)
        {
            string pathToExe = @"C:\Users\user\source\repos\TrojanTeamLaunch\Games\Artificial Ethics\DronesMurder.exe";

            if (File.Exists(pathToExe))
            {
                Process.Start(pathToExe);
                //lab_hasGame.Visible = true;
                //lab_hasnGame.Visible = false;
            }
            else
            {
                string url = "https://docs.google.com/uc?export=download&id=1Uj86L12XL465XPIL-pep9BIK6bZFJHT8";
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
                //lab_hasGame.Visible = false;
                //lab_hasnGame.Visible = true;
            }



        }

        private void win_launchIcon_Load(object sender, EventArgs e)
        {
        }

        private void win_launchIcon_MouseMove(object sender, MouseEventArgs e)
        {
            string pathToExe = @"C:\Users\user\source\repos\TrojanTeamLaunch\Games\Artificial Ethics\DronesMurder.exe";

            if (File.Exists(pathToExe))
            {
                but_launchOrDownloadGame.Text = "ИГРАШИТЬ!";
                lab_hasGame.Visible = true;
                lab_hasnGame.Visible = false;
            }
            else
            {
                but_launchOrDownloadGame.Text = "А НУ-КА, ПОГОДИТЕ!";
                lab_hasnGame.Visible = true;
                lab_hasGame.Visible = false;
            }
        }

        private void win_launchIcon_Load_1(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void but_launchOrDownloadGame_MouseMove(object sender, MouseEventArgs e)
        {
            lab_hasGame.ForeColor = Color.White;
            lab_hasnGame.ForeColor = Color.White;

            but_launchOrDownloadGame.BackColor = Color.DimGray;
        }

        private void but_launchOrDownloadGame_MouseLeave(object sender, EventArgs e)
        {
            lab_hasGame.ForeColor = Color.Gray;
            lab_hasnGame.ForeColor = Color.Gray;

            but_launchOrDownloadGame.BackColor = Color.Black;
        }

        private void pic_folderForGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\user\source\repos\TrojanTeamLaunch\Games";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //    ЭТО ПРОСТО КОСТЫЛЬ, ЧТОБЫ МОЖНО ОТКРЫТЬ ПАПОЧКУ - Я УСТАЛ!
            }
        }

        private void but_EXIT_MouseMove(object sender, MouseEventArgs e)
        {
            but_EXIT.BackColor = Color.DimGray;
        }

        private void but_EXIT_MouseLeave(object sender, EventArgs e)
        {
            but_EXIT.BackColor = Color.Black;
        }

        private void pic_folderForGame_MouseMove(object sender, MouseEventArgs e)
        {
            pic_folderForGame.BackColor = Color.DimGray;
        }

        private void pic_folderForGame_MouseLeave(object sender, EventArgs e)
        {
            pic_folderForGame.BackColor = Color.Black;
        }

        private void pic_help_MouseMove(object sender, MouseEventArgs e)
        {
            pic_help.BackColor = Color.DimGray;
        }

        private void pic_help_MouseLeave(object sender, EventArgs e)
        {
            pic_help.BackColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            string url = "https://vk.com/trojanteamgames";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string url = "https://discord.gg/bRuMhGHmNE";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.DimGray;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.DimGray;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Black;
        }
    }
}
