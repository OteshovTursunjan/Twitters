using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.DataAccess.DTO;

namespace Twitter.Application.Service
{
    public  interface IWriteCommonService
    {
        Task<CommentDTO> GetByIdAsync(Guid id);
        Task<List<CommentDTO>> GetAllAsync(Guid id);
        Task<CommentDTO> AddGenresAsync(CommentDTO commentDTO);
        Task<CommentDTO> UpdateGenresAsync(Guid id, CommentDTO commentDTO);
        Task<bool> DeleteGenresAsync(Guid id);
    }
}
