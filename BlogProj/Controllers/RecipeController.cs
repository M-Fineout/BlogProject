using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProj.Controllers
{
    public class RecipeController : Controller
    {
        public RecipeController()
        {

        }

        public IActionResult Recipes()
        {
            return View();
        }
    }
}
