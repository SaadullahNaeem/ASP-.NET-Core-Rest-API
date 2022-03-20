using System.Collections.Generic;
using Blogger.Models;

namespace Blogger.Data
{
    public interface IPostRepo
    {
        IEnumerable<Post> GetPostList();
        
        Post GetPost(int id);
        
    }
    
}