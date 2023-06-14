using System.ComponentModel.DataAnnotations;

namespace Examensarbete_Quiz.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "UserFirstname")]
        [StringLength(50, MinimumLength = 1)]
        public string UserFirstName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "UserLastname")]
        [StringLength(50, MinimumLength = 1)]
        public string UserLastName { get; set; }
        public int UserAge { get; set; }
        public string UserGender { get; set; }
    }
}
