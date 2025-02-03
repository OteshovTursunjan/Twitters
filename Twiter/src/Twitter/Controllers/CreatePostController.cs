using Microsoft.AspNetCore.Mvc;
using Twitter.Application.Service;
using Twitter.Application.Service.lmpl;
using Twitter.DataAccess.DTO;
using Twitter.DataAccess.Repository;

namespace Twitter.Controllers
{
    public class CreatePostController : Controller
    {
        public readonly ICreatePostService _createPostService;
        public CreatePostController(ICreatePostService createPostService)
        {
            _createPostService = createPostService;
        }
        [HttpPost("CreatePost")]
        public async Task<IActionResult> CreatePost(CreatePostDTO createPost)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var post = await _createPostService.AddCreatePostAsync(createPost);
            return Ok(post);
        }
        [HttpGet("GetAllPost")]
        public async Task<IActionResult> GetAllPost()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var post = await _createPostService.GetAllAsync();
            return Ok(post);
        }
        [HttpPut("UpdatePost{id}")]
        public async Task<IActionResult> UpdatePost([FromRoute] Guid id, CreatePostUpdate createPost)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var post = await _createPostService.UpdateCreatePostAsync(id, createPost);
            return Ok(post);
        }
        [HttpDelete("DeletePost{id}")]
        public async Task<IActionResult> DeletePost(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var post = await _createPostService.DeleteCreatePostAsync(id);
            return Ok(post);
        }

    }
}
