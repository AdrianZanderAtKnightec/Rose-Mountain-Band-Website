using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoseMountainBandWebsite.Models;

namespace RoseMountainBandWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //public DbSet<RoseMountainBandWebsite.ViewModel.TourConcertViewModel> TCVM { get; set; } = default!;
        public DbSet<RoseMountainBandWebsite.Models.Tour> Tour { get; set; } = default!;
        public DbSet<RoseMountainBandWebsite.Models.Concert> Concert { get; set; } = default!;
        public DbSet<RoseMountainBandWebsite.Models.Message> Message { get; set; } = default!;
    }
}
