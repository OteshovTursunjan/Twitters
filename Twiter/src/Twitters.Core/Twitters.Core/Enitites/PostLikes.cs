using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitters.Core.Common;

namespace Twitters.Core.Enitites
{
    public  class PostLikes : BaseEntity,IAuditedEnity
    {
        public User user { get; set; }
        public Guid UserId { get; set; }
        public CreatePost CreatePost { get; set; }
        public Guid CreatePostId { get; set; }
        public string? CreatBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public string? UpdateBY { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }
}
