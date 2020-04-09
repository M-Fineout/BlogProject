using BlogProj.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProj.Controllers
{
    public class HomeController : Controller
    {
        private string Message { get;  set; }

        private readonly IPostRepository _postRepository;
        public HomeController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public IActionResult Index()
        {
            return View(_postRepository.PostList);
        }

        public ViewResult About()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }
    }
}
