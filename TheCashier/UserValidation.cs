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
