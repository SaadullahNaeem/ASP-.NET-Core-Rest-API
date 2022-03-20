using System.Collections.Generic;
using Blogger.Data;
using Blogger.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogger.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostsController: ControllerBase
    {
        private readonly IPostRepo _repo;

        public PostsController(IPostRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Post>> GetPostList(){
            var postList = _repo.GetPostList();
            return Ok(postList);
        }

        [HttpGet("{id}")]
        public ActionResult<Post> GetPost(int id){
            var postItem = _repo.GetPost(id);
            return Ok(postItem);
        }
        
    }

}