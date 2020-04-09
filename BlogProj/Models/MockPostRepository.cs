using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProj.Models
{
    public class MockPostRepository : IPostRepository
    {
        
        public IEnumerable<Post> PostList => new List<Post>
        {
            new Post()
                {
                    Id = 1,
                    Title = "First Post",
                    RecipeImageSource = "demo.jpg",
                    DatePosted = new DateTimeOffset(2020, 03, 20, 12, 30, 00, TimeSpan.Zero),
                    Description = " Et partem ullamcorper mei, eam in quis saperet, his te nusquam adolescens. Dicam epicuri pro et, vel dicant alterum definitionem ne. Ius deleniti epicurei ne, facer detracto officiis qui an, an viris democritum honestatis quo. Eros laoreet conceptam id duo, cum cu democritum dissentias. Ut timeam virtute legimus nam."
                },
            new Post()
                {
                    Id = 2,
                    Title = "Second Post",
                    RecipeImageSource = "demo.jpg",
                    DatePosted = new DateTimeOffset(2020, 03, 20, 01, 30, 00, TimeSpan.Zero),
                    Description = " Et partem ullamcorper mei, eam in quis saperet, his te nusquam adolescens. Dicam epicuri pro et, vel dicant alterum definitionem ne. Ius deleniti epicurei ne, facer detracto officiis qui an, an viris democritum honestatis quo. Eros laoreet conceptam id duo, cum cu democritum dissentias. Ut timeam virtute legimus nam."
                }
        };

        public void AddPost(Post postToAdd)
        {
            if (postToAdd != null)
            {
                PostList.Append(postToAdd);
            }
        }

        public void EditPost(Post post)
        {
            var postToEdit = PostList.FirstOrDefault(x => x.Id == post.Id);
        }

        public int Commit()
        {
            return 1;
        }
    }
}
