using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.DataAccess.DTO;

namespace Twitter.Application.Service
{
    public  interface ICreatePostService
    {
        Task<CreatePostDTO> GetByIdAsync(Guid id);
        Task<List<CreatePostDTO>> GetAllAsync();
        Task<CreatePostDTO> AddCreatePostAsync(CreatePostDTO commentDTO);
        Task<CreatePostUpdate> UpdateCreatePostAsync(Guid id, CreatePostUpdate commentDTO);
        Task<bool> DeleteCreatePostAsync(Guid id);
    }
}
