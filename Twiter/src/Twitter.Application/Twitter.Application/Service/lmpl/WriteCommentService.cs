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
    public class WriteCommentService : IWriteCommonService
    {
        private readonly IWriteCommentRepository repository;
        public WriteCommentService(IWriteCommentRepository repository)
        {
            this.repository = repository;
        }
        public async Task<CommentDTO> AddGenresAsync(CommentDTO commentDTO)
        {
           if(commentDTO == null) throw new ArgumentNullException(nameof(commentDTO));
            WriteComment writeComment = new WriteComment()
            {
                UserId = commentDTO.UserId,
                CreatePostId = commentDTO.CreatePostId,
                Commnet = commentDTO.Commnet,
            }
            ;
            await repository.AddAsync(writeComment);
            return commentDTO;
        }

        public async Task<bool> DeleteGenresAsync(Guid id)
        {
          var comment = await repository.GetFirstAsync(u => u.Id == id);
           
            await repository.DeleteAsync(comment);
            return true;
        }

        public Task<List<CommentDTO>> GetAllAsync(Guid id)
        {
           
        }

        public Task<CommentDTO> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CommentDTO> UpdateGenresAsync(Guid id, CommentDTO commentDTO)
        {
            throw new NotImplementedException();
        }
    }
}
