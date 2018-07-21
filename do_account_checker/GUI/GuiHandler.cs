using do_account_checker.DarkOrbit;

namespace do_account_checker.GUI
{
    public class GuiHandler
    {
        private readonly MainForm _form;
        private UserHandler _userHandler;

        public GuiHandler(MainForm form)
        {
            _form = form;
            _userHandler = new UserHandler();
            LoadAccounts();
        }
        public void LoginSelected(int index)
        {
            var user = _userHandler.Users[index];
            var status = LoginUser(user);

            _form.SetLoginStatusList(status, index);
        }

        public void Login(string username, string password, bool saveCredentials)
        {
            _form.ResetLoginStatus();
            var user = new User(username, password);
            var status = LoginUser(user);
            _form.SetLoginStatus(status);

            if (!status || !saveCredentials) return;
            AddAccount(user);
        }

        private bool LoginUser(User user)
        {
            var status = user.Login();

            if (status)
                LoadAccountInformation(user);
            return status;
        }

        private void AddAccount(User user)
        {
            _userHandler.Add(user);
            LoadAccounts(); //Reload credentials
        }

        private void LoadAccounts()
        {
            _form.ClearList();
            _userHandler = new UserHandler();
            _form.AddToList(_userHandler.Users);
        }

        private void LoadAccountInformation(User user)
        {
            _form.SetUridium(user.Uridium);
            _form.SetUserId(user.UserId);
            _form.SetCredits(user.Credits);
            _form.SetServer(user.Server);
            _form.SetLevel(user.Level);
            _form.SetExperience(user.Experience);
            _form.SetHonor(user.Honor);
        }

        public void CollectDailySelected(int index)
        {
            var user = _userHandler.Users[index];
            var status = user.CollectDaily();
            _form.SetDailyStatusList(status, index);
        }
    }
}