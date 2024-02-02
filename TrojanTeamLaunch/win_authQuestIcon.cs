using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace TrojanTeamLaunch
{
    public partial class win_authQuestIcon : Form
    {

        public win_authQuestIcon()
        {
            InitializeComponent();
        }

        private void win_authQuestIcon_Load(object sender, EventArgs e)
        {

        }

        public void win_authQuestIcon_quest(string type) {
            lab_questForAuth.Text = type;
        }

        private void lab_questForAuth_Click(object sender, EventArgs e)
        {

        }

        private void but_regLogInQuest_Click(object sender, EventArgs e)
        {

        }
    }
}
