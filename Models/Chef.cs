using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int Id {get;set;}

        [Required]
        [Display(Name="First Name")]
        public string FirstName {get;set;}
        
        [Required]
        [Display(Name="Last Name")]
        public string LastName {get;set;}

        public List<Dish> CreatedDishes {get;set;}
    }
}