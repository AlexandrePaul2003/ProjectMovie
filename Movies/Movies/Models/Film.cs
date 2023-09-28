namespace Movies.Models
{
    public class Film
    {
        public string titre;
        public DateTime dateSortie;
        public int duree;
        public string synopsis;
        public List<Acteur> acteurs;
        public Realisateur realisateur;

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
        public Film(string titre, DateTime dateSortie, int duree, string synopsis,Realisateur real,List<Acteur> acteurs)
        {
            Titre = titre;
            DateSortie = dateSortie;
            Duree = duree;
            Synopsis = synopsis;
            this.acteurs = acteurs;
            this.realisateur = real;

        }
    }
}
