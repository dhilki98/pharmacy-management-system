namespace PharmacyManagementSystem.DataModels
{
    public class UserContext
    {
        public enum Role { Administrator, Pharmacist }

        private string username;

        private string fullname;

        private Role userRole;

        public UserContext(string un, Role ur, string fn)
        {
            username = un;
            userRole = ur;
            fullname = fn;
        }

        public Role getUserRole()
        {
            return userRole;
        }

        public string getUsername()
        {
            return username;
        }

        public string getFullname()
        {
            return fullname;
        }
    }
}
