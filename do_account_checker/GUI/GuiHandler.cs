using do_account_checker.DarkOrbit;

namespace do_account_checker.GUI
{
    public class GuiHandler
    {
        private readonly MainForm _form;

        public GuiHandler(MainForm form)
        {
            _form = form;
        }

        public void Login(string username, string password, bool saveCredentials)
        {
            _form.ResetLoginStatus();
            var user = new User(username, password);
            var status = LoginUser(user);
            _form.SetLoginStatus(status);

            if (!status || !saveCredentials) return;
            AddAccount();
        }

        private bool LoginUser(User user)
        {
            var status = user.Login();

            if (status)
                LoadAccountInformation(user);
            return status;
        }

        private void AddAccount()
        {
            //TODO Save information to File
            LoadAccounts(); //Reload credentials
        }

        private void LoadAccounts()
        {
            _form.ClearList();
            var userCollec = new UserCollection();
            _form.AddToList(userCollec.Users);
        }

        private void LoadAccountInformation(User user)
        {
            _form.SetUridium(user.Uridium);
            _form.SetUserId(user.UserId);
            _form.SetCredits(user.Credits);
        }
    }
}