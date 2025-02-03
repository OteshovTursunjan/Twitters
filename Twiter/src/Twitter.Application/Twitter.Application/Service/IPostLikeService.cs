using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.DataAccess.DTO;

namespace Twitter.Application.Service
{
    public  interface IPostLikeService 
    {
        Task<PostLikeDTO> GetByIdAsync(Guid id);
        Task<List<PostLikeDTO>> GetAllAsync(Guid id );
        Task<bool> AddLikeAsync(PostLikeDTO commentDTO);
        Task<PostLikeDTO> UpdateLikeAsync(Guid id, PostLikeDTO commentDTO);
        Task<bool> DeleteLikeAsync(Guid id);
    }
}
