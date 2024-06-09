using GameApplication.Models;

namespace GameApplication.Services
{
    public class SecurityService
    {
        SecurityDAO securityDAO = new SecurityDAO();
        public bool IsValid(UserModel user)
        {
            return securityDAO.FindsUserByNamePassword(user);
        }
    }
}
