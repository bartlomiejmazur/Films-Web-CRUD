namespace FilmsAPI.Models
{
    public class UpdateFilmRequest
    {
        public string FilmTitle { get; set; }
        public string FilmDirector { get; set; }
        public int FilmYear { get; set; }
        public int FilmRate { get; set; }
    }
}
