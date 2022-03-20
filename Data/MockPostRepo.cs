using System.Collections.Generic;
using Blogger.Models;

namespace Blogger.Data
{
    public class MockPostRepo : IPostRepo
    {
        public Post GetPost(int id)
        {
            return new Post{Id=1, Title="sunt aut facere repellat provident occaecati excepturi optio reprehenderit", Description="quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"};
        }

        public IEnumerable<Post> GetPostList()
        {

            var posts = new List<Post>{
                new Post{Id=1, Title="sunt aut facere repellat provident occaecati excepturi optio reprehenderit", Description="quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"},
                new Post{Id=2, Title="qui est esse", Description="est rerum tempore vitae\nsequi sint nihil reprehenderit"},
                new Post{Id=3, Title="occaecati excepturi optio", Description="et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut"}
            };

            return posts;
        }
    }

}