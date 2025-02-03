using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitters.Core.Common;

namespace Twitters.Core.Enitites
{
    public  class Post : BaseEntity, IAuditedEnity
    
    {
        public required CreatePost CreatePost { get; set; }
        public Guid CreatePostId { get; set; }
        public int Likes { get; set; }
        public  required  WriteComment WriteComment { get; set; }
        public Guid WriteCommentId { get; set; }
        public string? CreatBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public string? UpdateBY { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
