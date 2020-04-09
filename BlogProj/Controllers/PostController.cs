using BlogProj.Models;
using BlogProj.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace BlogProj.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PostController(IPostRepository postRepository, IWebHostEnvironment webHostEnvironment)
        {
            _postRepository = postRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public ViewResult AddPost()
        {
            return View();
        }

        public IActionResult PostAdded(Post postToAdd)
        {
            if (postToAdd != null)
            {
                if (postToAdd.RecipeImageUpload != null)
                {
                    var processor = new ImageProcessor(_webHostEnvironment);
                    var imageFileName = processor.ProcessImage(postToAdd.RecipeImageUpload);
                    postToAdd.RecipeImageSource = "/uploads/" + imageFileName;
                }

                _postRepository.AddPost(postToAdd);
                //TempData["Message"] = "Post added";
            }

            _postRepository.Commit();
            return RedirectToAction("Index", "Home", _postRepository.PostList);
        }
    }
}
