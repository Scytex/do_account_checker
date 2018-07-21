using System.Collections.Generic;
using System.IO;

namespace do_account_checker.DarkOrbit
{
    public class UserHandler
    {
        private const char Seperator = (char) 11;
        private List<User> _users;
        public User[] Users => _users.ToArray();

        private void Add(User user)
        {
            _users.Add(user);
            SaveToDisc();
        }

        private void SaveToDisc()
        {
            
        }

        private List<User> LoadFromDisc()
        {
            var users = new List<User>();
            var accountText = File.ReadAllText("accounts.do");

            using (var reader = new StringReader(accountText))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var info = line.Split(Seperator);
                    users.Add(new User(info[0], info[1]));
                }
            }

            return users;
        }

        public UserHandler()
        {
            _users = LoadFromDisc();
        }
    }
}