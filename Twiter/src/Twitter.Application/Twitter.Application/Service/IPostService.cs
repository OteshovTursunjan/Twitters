using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.DataAccess.DTO;

namespace Twitter.Application.Service
{
   public   interface IPostService
    {
        Task<PostDTO> GetByIdAsync(Guid id);
        Task<List<PostDTO>> GetAllAsync();
        Task<PostDTO> AddPostAsync(PostDTO commentDTO);
        Task<PostDTO> UpdatePostAsync(Guid id, PostDTO commentDTO);
        Task<bool> DeletePostAsync(Guid id);
    }
}
