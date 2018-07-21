using do_account_checker.DarkOrbit;

namespace do_account_checker.GUI
{
    public class GuiHandler
    {
        private User _user;
        private readonly MainForm _form;

        public GuiHandler(MainForm form)
        {
            _form = form;
        }

        public void Login(string username, string password, bool saveCredentials)
        {
            _form.ResetLoginStatus();
            _user = new User(username, password);
            var status = Login();
            _form.SetLoginStatus(status);

            if (!status || !saveCredentials) return;
            AddAccount();
        }

        private bool Login()
        {
            var status = _user.Login();

            if (status)
                LoadAccountInformations();
            return status;
        }

        private void AddAccount()
        {
            
        }

        private void LoadAccountInformations()
        {
            _form.SetUridium(_user.Uridium);
            _form.SetUserId(_user.UserId);
            _form.SetCredits(_user.Credits);
        }
    }
}