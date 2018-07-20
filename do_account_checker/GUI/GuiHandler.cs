using do_account_checker.Http;

namespace do_account_checker.GUI
{
    public class GuiHandler
    {
        private readonly WebRequestHandler _webRequestHandler = new WebRequestHandler();
        private readonly MainForm _form;

        public GuiHandler(MainForm form)
        {
            _form = form;
        }

        public void AddAccount(string username, string password)
        {
            var status = Login(username, password);
            _form.SetLoginStatus(status);

        }

        public bool Login(string username, string password)
        {
            var status = _webRequestHandler.LoginToAccount(username, password);

            if (status)
                LoadAccountInformations();
            return status;
        }

        private void LoadAccountInformations()
        {
            _form.SetUridium(_webRequestHandler.GetUridium());
        }
    }
}