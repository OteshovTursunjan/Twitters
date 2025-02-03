using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitters.Core.Enitites;

namespace Twitter.DataAccess.DTO
{
    public  class PostDTO
    {
        public required CreatePost CreatePost { get; set; }
        public Guid CreatePostId { get; set; }
        public int Likes { get; set; }
        public required WriteComment WriteComment { get; set; }
        public Guid WriteCommentId { get; set; }
    }
}
