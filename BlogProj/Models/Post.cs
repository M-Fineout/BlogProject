using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProj.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a title.")]
        [MaxLength(50, ErrorMessage = "The title cannot be more than 50 characters long.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        [MaxLength(500, ErrorMessage = "The description cannot be more than 50 characters long.")]
        public string Description { get; set; }

        [NotMapped]
        [Display(Name = "Recipe Image")]
        public IFormFile RecipeImageUpload { get; set; }

        public string RecipeImageSource { get; set; }

        //public string RecipeLink { get; set; }

        public DateTimeOffset DatePosted { get; set; }
    }
}
