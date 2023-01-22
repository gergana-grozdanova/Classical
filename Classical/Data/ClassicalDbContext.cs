using Classical.Models;
using Microsoft.EntityFrameworkCore;

namespace Classical.Data
{
    public class ClassicalDbContext : DbContext
    {
        public virtual DbSet<Element> Element { get; set; }


        public ClassicalDbContext(DbContextOptions<ClassicalDbContext> options)
            : base(options)
        { }

     
    }
}
