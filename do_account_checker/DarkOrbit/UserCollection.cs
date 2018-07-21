using System.Collections.Generic;

namespace do_account_checker.DarkOrbit
{
    public class UserCollection
    {
        private List<User> users;
        public User[] Users => users.ToArray();

        private void Add(User user)
        {
            users.Add(user);
        }
    }
}