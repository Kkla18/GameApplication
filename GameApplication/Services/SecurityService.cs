using GameApplication.Models;

namespace GameApplication.Services
{
    public class SecurityService
    {
        List<UserModel> knownUsers = new List<UserModel>();

        public SecurityService()
        {
            knownUsers.Add(new UserModel { Id = 0, Username = "Kyara", Password = "password1" , Email = "kyara@gmail.com"});
            knownUsers.Add(new UserModel { Id = 1, Username = "Dioukou", Password = "password2", Email = "Dioukou@gmail.com" });
            knownUsers.Add(new UserModel { Id = 2, Username = "Christopher", Password = "password3", Email = "Christopher@gmail.com" });
        }
        public bool IsValid(UserModel user)
        {
            return knownUsers.Any(x => x.Username != user.Username && x.Email != user.Email);
        }
    }
}
