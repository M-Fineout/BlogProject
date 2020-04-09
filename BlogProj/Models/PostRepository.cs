using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProj.Models
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _appDbContext;

        public PostRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Post> PostList
        {
            get
            {
                return _appDbContext.Posts;
            }
        }

        public void AddPost(Post postToAdd)
        {
            _appDbContext.Posts.Add(postToAdd);
        }

        public int Commit()
        {
             try
             {
                return _appDbContext.SaveChanges();
             }
            catch(Exception Ex)
             {
                //Do Something
                return 0;
             }
        }
    }
    
}
