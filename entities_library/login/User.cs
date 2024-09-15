using entities_library.ban;
namespace entities_library.login;


public class User : Person
{

    #region Atributtes

    public required string Username { get; set; }

    public required string Password { get; set; }

    public UserBan UserBan { get; set; } = UserBan.Active;
    #endregion

    #region Methods
    public void Encrypt(string password)
    {
        this.Password = this.encrypt(password);
    }

    public bool IsPassword(string password)
    {
        return this.encrypt(password) == this.Password;
    }

    private string encrypt(string password)
    {
        //TODO - Marcos: completar el encriptamiento cuando el profe lo publique.
        return password;
    }
    #endregion
}
