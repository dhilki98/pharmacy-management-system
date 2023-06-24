namespace PharmacyManagementSystem.DataModels
{
    public class UserContext
    {
        public enum Role { Administrator, Pharmacist }

        private string username;

        private string fullname;

        private Role userRole;

        private int userId;

        public UserContext(string un, Role ur, string fn, int id)
        {
            userId = id;
            username = un;
            userRole = ur;
            fullname = fn;
        }

        public int getUserId()
        {
            return userId;
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
