using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.DataAccess.DTO;
using Twitter.DataAccess.Repository;
using Twitters.Core.Enitites;

namespace Twitter.Application.Service.lmpl
{
    public class PostLikeService : IPostLikeService
    {
        public readonly IPostLikesRepository _postLikesRepository;
         public PostLikeService(IPostLikesRepository postLikesRepository)
        {
            _postLikesRepository = postLikesRepository;
        }
        public async Task<bool> AddLikeAsync(PostLikeDTO commentDTO)
        {
           if(commentDTO == null) 
                throw new ArgumentNullException(nameof(commentDTO));
            PostLikes postLikes = new PostLikes()
            {
                CreatePostId = commentDTO.CreatePostId,
                UserId = commentDTO.UserId,

            };
            await _postLikesRepository.AddAsync(postLikes);
            return true;
        }

        public async Task<bool> DeleteLikeAsync(Guid id)
        {
            var like = await _postLikesRepository.GetFirstAsync(u => u.Id == id);
            await _postLikesRepository.DeleteAsync(like);
            return true;
        }

        public async Task<List<PostLikeDTO>> GetAllAsync(Guid id)
        {
           var likes = await _postLikesRepository.GetAllAsync(u => u.UserId == id);

         //   var post = await _createPostRepository.GetAllAsync(u => u.Id != null);
            return likes.Select(user => new PostLikeDTO
            {
              CreatePostId = user.CreatePostId,
            }).ToList();
        }

        public Task<PostLikeDTO> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PostLikeDTO> UpdateLikeAsync(Guid id, PostLikeDTO commentDTO)
        {
            throw new NotImplementedException();
        }
    }
}
