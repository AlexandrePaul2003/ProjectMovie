using Movies.Models.DAL.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace Movies.Models.DAL
{
    public class MovieDAL : IMovieDAL
    {
        private string connectionstring;
        public MovieDAL(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }
        public void deleteMovie(Film film)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                SqlCommand command = new SqlCommand("DELETE FROM Movies WHERE movie_id = @id", connection);
                command.Parameters.AddWithValue("id", film.Id);
                connection.Open();
            }
        }
    }
}
