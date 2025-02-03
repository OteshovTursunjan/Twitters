using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitters.Core.Enitites;

namespace Twitter.DataAccess.Repository.lmpl
{
    public  class WriteCommentRepository : BaseRepository<WriteComment> ,IWriteCommentRepository
    {
        public WriteCommentRepository(DatabaseContext context) : base(context) { }
    }
}
