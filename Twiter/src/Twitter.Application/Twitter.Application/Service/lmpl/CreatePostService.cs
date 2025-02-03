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
    public class CreatePostService : ICreatePostService
    {
        public readonly ICreatePostRepository _createPostRepository;
        public CreatePostService(ICreatePostRepository createPostRepository)
        {
            _createPostRepository = createPostRepository;
        }
        public async Task<CreatePostDTO> AddCreatePostAsync(CreatePostDTO commentDTO)
        {
            if (commentDTO == null)
            {
                throw new ArgumentNullException("Error");
            }
            CreatePost createPost = new CreatePost()
            {
                UserID = commentDTO.UserID,
                Text = commentDTO.Text,
            };
            await _createPostRepository.AddAsync(createPost);
            return commentDTO;
        }

        public async Task<bool> DeleteCreatePostAsync(Guid id)
        {
           var res = await _createPostRepository.GetFirstAsync(u => u.UserID == id);    
           
           await _createPostRepository.DeleteAsync(res);
           
           return true;
        }

        public async Task<List<CreatePostDTO>> GetAllAsync()
        {
            var post = await _createPostRepository.GetAllAsync(u => u.Id != null);
            return post.Select(user => new CreatePostDTO
            {
               UserID =user.UserID,
               Text = user.Text
            }).ToList();
        }

        public async Task<CreatePostDTO> GetByIdAsync(Guid id)
        {
            var post = await _createPostRepository.GetFirstAsync(u => u.Id == id);
            CreatePostDTO createPostDTO = new CreatePostDTO()
            {
                UserID = id,
                Text = post.Text
            };
            return createPostDTO;

        }

        public async Task<CreatePostUpdate> UpdateCreatePostAsync(Guid id, CreatePostUpdate commentDTO)
        {
            var post = await _createPostRepository.GetFirstAsync(u => u.Id == id);
            post.Text = commentDTO.Text;
            CreatePost createPost = new CreatePost()
            {
                UserID = post.UserID,
                Text = commentDTO.Text,
            };
            await _createPostRepository.UpdateAsync(post);
            return commentDTO;
        }
    }
}
