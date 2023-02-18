namespace SistemaGestion_final.Models
{
    public class User
    {
        private long id;
        private string name;
        private string lastname;
        private string username;
        private string password;
        private string email;


        public User(long id, string name, string lastname, string username, string password, string email)
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
            this.username = username;
            this.password = password;
            this.email = email;
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
    }
}
