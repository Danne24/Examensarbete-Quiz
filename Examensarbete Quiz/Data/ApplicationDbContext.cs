using Examensarbete_Quiz.Models;
using Microsoft.EntityFrameworkCore;

namespace Examensarbete_Quiz.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(new User
            {
                UserID = 1,
                UserFirstName = "Daniel",
                UserLastName = "Gyrén",
                UserAge = 26,
                UserGender = "Male"
            });



            modelBuilder.Entity<Question>().HasData(new Question
            {
                QuestionID = 1,
                QuestionText = "Vad är 1+1?",
                Option1 = "1",
                Option2 = "2",
                Option3 = "3",
                Option4 = "4",
                CorrectOption = "2",
                Point = 0,
            });

            modelBuilder.Entity<Question>().HasData(new Question
            {
                QuestionID = 2,
                QuestionText = "Vad är 2+2?",
                Option1 = "2",
                Option2 = "4",
                Option3 = "6",
                Option4 = "8",
                CorrectOption = "4",
                Point = 0,
            });

            modelBuilder.Entity<Question>().HasData(new Question
            {
                QuestionID = 3,
                QuestionText = "Vad är 3+3?",
                Option1 = "3",
                Option2 = "6",
                Option3 = "9",
                Option4 = "12",
                CorrectOption = "6",
                Point = 0,
            });
        }
    }
}
