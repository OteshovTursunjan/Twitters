using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitters.Core.Enitites;

namespace Twitter.DataAccess.DTO
{
    public  class PostLikeDTO
    {
     
        public Guid UserId { get; set; }
        public Guid CreatePostId { get; set; }
    }
}
