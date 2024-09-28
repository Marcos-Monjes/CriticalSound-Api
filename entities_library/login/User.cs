using entities_library.ban;

namespace entities_library.login;


public class User : Person
{

    #region Atributtes

    public  string  Mail { get; set; }="";

    public string Password { get; set; } ="";


    public UserStatus UserStatus { get; set; } = UserStatus.Active;

    public entities_library.file_system.Filee? Filee { get; set; }


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
