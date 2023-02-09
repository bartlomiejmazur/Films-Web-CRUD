using FilmsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmsAPI.Data
{
    //klasa dziedziczy z kontekstu bazy danych
    public class FilmsAPIDbContext : DbContext
    {
        //opcje przekazywane 
        public FilmsAPIDbContext(DbContextOptions options) : base(options)
        {
        }
        //właściwości działające jako tabele dla encji
        public DbSet<Film> Films { get; set; }
    }
}
