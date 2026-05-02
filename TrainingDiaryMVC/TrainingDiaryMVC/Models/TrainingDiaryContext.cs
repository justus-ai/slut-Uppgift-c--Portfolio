using Microsoft.EntityFrameworkCore;
using TrainingDiaryMVC.Models;

namespace TrainingDiaryMVC.Models
{
    public class TrainingDiaryContext : DbContext
    {
        public TrainingDiaryContext(DbContextOptions<TrainingDiaryContext> options) : base(options) { }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<WorkoutSession> WorkoutSessions { get; set; }
    }
}
