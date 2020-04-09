using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProj.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public int postId { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public string Instructions { get; set; }
        public DateTimeOffset DatePosted { get; set; }

    }
}
