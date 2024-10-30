namespace Api.Identity
{
    public class IdentityData
    {
        private string _email;
        private string _password;

        public IdentityData(string email, string password)
        {
            _email = email;
            _password = password;
        }

        public string Email { get { return _email; } }
        public string Password { get { return _password; } }
    }
}
