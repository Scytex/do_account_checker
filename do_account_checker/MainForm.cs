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

        public void SetUridium(string uridium)
        {
            lblUridium.Text = uridium;
        }

        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            _guiHandler.AddAccount(txtUsername.Text, txtPassword.Text);
        }
    }
}
