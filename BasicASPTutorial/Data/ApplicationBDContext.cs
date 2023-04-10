using BasicASPTutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicASPTutorial.Data
{
    public class ApplicationBDContext:DbContext
    {
        public ApplicationBDContext(DbContextOptions<ApplicationBDContext> options) :base(options) { 
        
        }
        public DbSet<Student> Students { get; set; }
    }
}
