using FilmsAPI.Data;
using FilmsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilmsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmsController : Controller
    {
        private readonly FilmsAPIDbContext dbContext;

        public FilmsController(FilmsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetFilms()
        {
            return Ok(await dbContext.Films.ToListAsync());
            
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetFilm([FromRoute] Guid id)
        {
            var film = await dbContext.Films.FindAsync(id);

            if(film == null)
            {
                return NotFound();
            }

            return Ok(film);
        }

        [HttpPost]
        public async Task<IActionResult> AddFilm(AddFilmRequest addFilmRequest)
        {
            var film = new Film()
            {
                Id = Guid.NewGuid(),
                FilmTitle = addFilmRequest.FilmTitle,
                FilmDirector = addFilmRequest.FilmDirector,
                FilmYear = addFilmRequest.FilmYear,
                FilmRate = addFilmRequest.FilmRate,
            };

            await dbContext.Films.AddAsync(film);
            await dbContext.SaveChangesAsync();

            return Ok(film);
        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateFilm([FromRoute] Guid id, UpdateFilmRequest updateFilmRequest)
        {
            var film = await dbContext.Films.FindAsync(id);

            if(film != null)
            {
                film.FilmTitle = updateFilmRequest.FilmTitle;
                film.FilmDirector = updateFilmRequest.FilmDirector;
                film.FilmYear = updateFilmRequest.FilmYear;
                film.FilmRate = updateFilmRequest.FilmRate;

                await dbContext.SaveChangesAsync();

                return Ok(film);
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteFilm([FromRoute] Guid id)
        {
            var film = await dbContext.Films.FindAsync(id);

            if(film != null)
            {
                dbContext.Remove(film);
                await dbContext.SaveChangesAsync();
                return Ok(film);
            }

            return NotFound();
        }
    }
}
