using System.Collections.Generic;

namespace do_account_checker.DarkOrbit
{
    public class UserHandler
    {
        private List<User> users;
        public User[] Users => users.ToArray();

        private void Add(User user)
        {
            users.Add(user);
            SaveToDisc();
        }

        private void SaveToDisc()
        {
            
        }

        private List<User> LoadFromDisc()
        {
            
        }

        public UserHandler()
        {
            users = LoadFromDisc();
        }
    }
}