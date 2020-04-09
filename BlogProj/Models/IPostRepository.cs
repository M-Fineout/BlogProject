using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProj.Models
{
    public interface IPostRepository
    {
        IEnumerable<Post> PostList { get; }

        void AddPost(Post postToAdd);

        int Commit();
    }
}
