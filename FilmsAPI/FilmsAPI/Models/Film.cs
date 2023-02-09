namespace FilmsAPI.Models
{
    public class Film
    {
        public Guid Id { get; set; }
        public string FilmTitle { get; set; }
        public string FilmDirector { get; set; }
        public int FilmYear { get; set; }
        public int FilmRate { get; set; }
    }
}
