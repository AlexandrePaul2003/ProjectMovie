namespace Movies.Models
{
    public class Acteur : Personne 
    {

        public List<Film> films;
        public Acteur(string nom,string prenom) : base(nom, prenom)
        {
            films = new List<Film>();
        }
    }
}
