using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitters.Core.Enitites;

namespace Twitter.DataAccess.Repository.lmpl
{
    public  class PostLikesRepository : BaseRepository<PostLikes>, IPostLikesRepository
    {
        public PostLikesRepository(DatabaseContext context) : base(context) { }
    }
}
