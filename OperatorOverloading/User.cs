using Shared;

namespace OperatorOverloading
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

        public User()
        {
            Id = Guid.NewGuid();
            Password = Security.GeneratePassword();
        }

        // Method overloading
        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }


        // Operator overloading
        public static bool operator ==(User user, string id)
        {
            return user.Id.ToString().ToLower() == id.ToLower();
        }

        public static bool operator !=(User user, string id)
        {
            return user.Id.ToString().ToLower() != id.ToLower();
        }

    }
}