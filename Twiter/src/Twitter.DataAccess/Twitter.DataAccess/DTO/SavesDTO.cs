using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitters.Core.Enitites;

namespace Twitter.DataAccess.DTO
{
    public  class SavesDTO
    {
        public User User { get; set; }
        public Guid UserId { get; set; }
        public Post Post { get; set; }
        public Guid PostId { get; set; }
    }
}
