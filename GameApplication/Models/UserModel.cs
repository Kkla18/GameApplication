namespace GameApplication.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        // Parameterless constructor
        public UserModel()
        {
        }

        public UserModel(int id, string firstName, string lastName, string sex, int age, string state, string email, string username, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            Age = age;
            State = state;
            Email = email;
            Username = username;
            Password = password;

        }
    }
}
