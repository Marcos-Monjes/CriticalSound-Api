using web_api.dto.login;
using entities_library.login;

namespace web_api.mock;

public class UserMock
{
    private static UserMock? instance;

    private UserMock() { }

    public static UserMock Instance 
    {
        get
        {
            if(instance == null) instance = new UserMock();
            return instance;
        }
    }

    public List<User> Users { get; set; } = new List<User>();

    public long CreateUser(
        string Name, 
        string Username, 
        string Mail, 
        DateTime? Birthdate, 
        string Password)
    {
        User user = new User
        {
            Name = Name,
            Username = Username,
            Mail = Mail,
            Birthdate = Birthdate,
            UserStatus = UserStatus.Active
        };

        user.Encrypt(Password);
        user.Id = this.Users.Count + 1;
        this.Users.Add(user);

        return user.Id;
    }
}