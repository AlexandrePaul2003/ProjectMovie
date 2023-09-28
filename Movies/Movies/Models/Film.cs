using Movies.Models.DAL.Interfaces;

namespace Movies.Models
{
    public class Film
    {
        public int id;
        public string titre;
        public DateTime dateSortie;
        public int duree;
        public string synopsis;
        public List<Acteur> acteurs;
        public Realisateur realisateur;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }
        public DateTime DateSortie
        {
            get { return dateSortie; }
            set { dateSortie = value; }
        }
        public int Duree
        {
            get { return duree; }
            set { duree = value; }
        }
        public string Synopsis
        {
            get { return synopsis; }
            set {synopsis = value; }
        }
        public Film(int id, string titre, DateTime dateSortie, int duree, string synopsis,Realisateur real,List<Acteur> acteurs)
        {
            Id = id;
            Titre = titre;
            DateSortie = dateSortie;
            Duree = duree;
            Synopsis = synopsis;
            this.acteurs = acteurs;
            this.realisateur = real;
        }
        public void Delete(Film film, IMovieDAL movieDAL)
        {
            movieDAL.deleteMovie(film);
        }
    }
}
