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

        public void AddAccount(string username, string password)
        {
            _user = new User(username, password);
            var status = Login();
            _form.SetLoginStatus(status);

        }

        public bool Login()
        {
            var status = _user.Login();

            if (status)
                LoadAccountInformations();
            return status;
        }

        private void LoadAccountInformations()
        {
            _form.SetUridium(_user.Uridium);
        }
    }
}