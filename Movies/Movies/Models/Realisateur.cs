namespace Movies.Models
{
    public class Realisateur : Personne
    {
        public List<Film> films;
        public Realisateur(string nom,string prenom) : base(nom, prenom)
        {
            films = new List<Film>();
        }
    }
}
