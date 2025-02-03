using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitters.Core.Enitites;

namespace Twitter.DataAccess.DTO
{
    public  class CreatePostDTO
    {
      
        public Guid UserID { get; set; }
        public string Text { get; set; }
    }
}
