using Microsoft.AspNetCore.Mvc;
using Twitter.Application.Service;
using Twitter.DataAccess.DTO;

namespace Twitter.Controllers
{
    public class PostLikeController : Controller
    {
        public readonly IPostLikeService _postLikeService;
        public PostLikeController(IPostLikeService postLikeService)
        {
            _postLikeService = postLikeService;
        }
        [HttpPost("PutLikes")]
        public async Task<IActionResult> CreateLike(PostLikeDTO postLikeDTO)
        {
            if (postLikeDTO == null)
            {
                return BadRequest(postLikeDTO);
            }
            var like = await _postLikeService.AddLikeAsync(postLikeDTO);
            return Ok(like);
        }
        [HttpGet("GetLikes{id}")]
        public async Task<IActionResult> GetLikes([FromRoute]Guid id)
        {
            var res = await _postLikeService.GetAllAsync(id);
            return Ok(res);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
