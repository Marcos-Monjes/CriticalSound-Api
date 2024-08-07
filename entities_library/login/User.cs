namespace entities_library.login;

public class User : Person
{

    #region Atributtes
    public required string Password { get; set; }

    public UserStatus UserStatus { get; set; } = UserStatus.Active;
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
