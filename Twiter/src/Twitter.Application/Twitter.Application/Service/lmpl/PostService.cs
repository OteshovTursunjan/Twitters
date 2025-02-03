using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.DataAccess.DTO;

namespace Twitter.Application.Service.lmpl
{
    public class PostService : IPostService
    {
        public Task<PostDTO> AddPostAsync(PostDTO commentDTO)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePostAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PostDTO> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PostDTO> UpdatePostAsync(Guid id, PostDTO commentDTO)
        {
            throw new NotImplementedException();
        }
    }
}
