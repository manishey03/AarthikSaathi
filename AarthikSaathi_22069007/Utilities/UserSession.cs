using AarthikSaathi_22069007.Models;

namespace AarthikSaathi_22069007.Utilities
{
    public static class UserSession
    {
        private static User? _currentUser;

        public static User? CurrentUser => _currentUser;

        public static void Login(User user)
        {
            _currentUser = user;
        }

        public static void Logout()
        {
            _currentUser = null;
        }

        public static bool IsLoggedIn() => _currentUser != null;
    }
}
