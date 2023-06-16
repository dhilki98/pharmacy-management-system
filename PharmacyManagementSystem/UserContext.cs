
namespace PharmacyManagementSystem
{
    public class UserContext
    {
        public enum Role { Administrator, Pharmacist }

        private string username;

        private Role userRole;

        public UserContext(string un, Role ur) {
            username= un;
            userRole= ur;
        }

        public Role getUserRole()
        {
            return userRole;
        }

        public string getUsername()
        {
            return username;
        }
    }
}
