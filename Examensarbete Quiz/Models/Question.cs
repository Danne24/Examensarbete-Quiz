using System.ComponentModel.DataAnnotations;

namespace Examensarbete_Quiz.Models
{
    public class Question
    {
        [Key]
        public int QuestionID { get; set; }

        public string QuestionText { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string CorrectOption { get; set; }
        public int Point { get; set; }
    }
}
