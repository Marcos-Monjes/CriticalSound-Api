using System.Security.Cryptography;
using System.Text;

namespace entities_library.login
{
    public class User : Person
    {
        #region Atributtes
        public string password { get; set; } = "";
        public required string userName { get; set; }

        public UserStatus userStatus { get; set; } = UserStatus.Active;

        public entities_library.file_system.File? File { get; set; }
       
        #endregion

        #region Methods
        public void Encrypt(string password)
        {
            this.password = this.encrypt(password);
        }

        public bool IsPassword(string password)
        {
            return this.encrypt(password) == this.password;
        }

        private string encrypt(string password)
        {// este es un hash criptográfico que convierte la contraseña en una cadena hexadecimal.
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // convierte la contraseña en bytes en una lista ,usando la codificación UTF-8, luego aplica el hash con SHA256.
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // convierte la lista de bytes a un string hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        #endregion
    }
}
