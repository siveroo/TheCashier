using System;
using System.Collections.Generic;
using System.Text;

namespace TheCashier
{
    class UserValidation
    {
        private User user;
        public UserValidation(User _user)
        {
            this.user = _user;
        }

        public bool isAgeAllowed()
        {
            return this.user.age > 17;
        }
    }
}
