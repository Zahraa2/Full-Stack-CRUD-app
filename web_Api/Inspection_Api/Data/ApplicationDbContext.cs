using Microsoft.EntityFrameworkCore;
using Inspection_Api.Models;

namespace Inspection_Api.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<InspectionType> InspectionTypes { get; set; }
        public DbSet<Status> statuses { get; set; }
    }
}
