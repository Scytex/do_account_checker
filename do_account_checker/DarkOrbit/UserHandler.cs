using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace do_account_checker.DarkOrbit
{
    public class UserHandler
    {
        private const char Seperator = (char) 11;
        private List<User> _users;
        public User[] Users => _users.ToArray();

        public void Add(User user)
        {
            _users.Add(user);
            SaveToDisc();
        }

        private void SaveToDisc()
        {
            var info = _users.Aggregate(string.Empty, (current, user) => current + (user.Username + Seperator + user.Password + Environment.NewLine));
            File.WriteAllText("accounts.do", info);
        }

        private List<User> LoadFromDisc()
        {
            var users = new List<User>();

            try
            {
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
            }
            catch (Exception)
            {
                //TODO handle exception
                // File doesn't exist or whatever
            }

            return users;
        }

        public UserHandler()
        {
            _users = LoadFromDisc();
        }
    }
}