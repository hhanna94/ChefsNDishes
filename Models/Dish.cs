using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int Id {get;set;}

        [Required]
        [Display(Name="Name of Dish")]
        public string Name {get;set;}

        [Required]
        // [RequiredGreaterThanZero]
        [Display(Name="# of Calories")]
        public int? NumCalories {get;set;}

        [Required]
        public string Description {get;set;}

        [Required]
        public int? Tastiness {get;set;}

        [Required]
        [Display(Name="Chef")]
        public int? ChefId {get;set;}

        public Chef Chef {get;set;}
    }
}