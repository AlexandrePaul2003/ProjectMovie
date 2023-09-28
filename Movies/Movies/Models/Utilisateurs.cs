namespace Movies.Models
{
    public class Utilisateurs
    {
        public string nomUti;
        public string password;

        public string NomUti
        {
            get { return nomUti; }
            set { nomUti = value; }
        }
        public string Password
        {
            set { password = value; }
        }
    }
}
