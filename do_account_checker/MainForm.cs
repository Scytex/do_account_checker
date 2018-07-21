using System;
using System.Drawing;
using System.Windows.Forms;
using do_account_checker.GUI;

namespace do_account_checker
{
    public partial class MainForm : Form
    {
        private readonly GuiHandler _guiHandler;
        public MainForm()
        {
            InitializeComponent();
            _guiHandler = new GuiHandler(this);
        }

        public void SetLoginStatus(bool status)
        {
            pnlStatus.BackColor = status ? Color.Green : Color.Red;
        }

        public void ResetLoginStatus()
        {
            pnlStatus.BackColor = Color.Orange;
        }

        public void SetUridium(string uridium)
        {
            lblUridium.Text = uridium;
        }

        public void SetUserId(string userId)
        {
            lblUserId.Text = userId;
        }

        public void SetCredits(string credits)
        {
            lblCredits.Text = credits;
        }

        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            _guiHandler.Login(txtUsername.Text, txtPassword.Text, true);
        }

        private void BtnSingleLogin_Click(object sender, EventArgs e)
        {
            _guiHandler.Login(txtUsername.Text, txtPassword.Text, false);
        }
    }
}
