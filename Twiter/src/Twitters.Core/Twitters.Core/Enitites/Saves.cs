using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitters.Core.Common;

namespace Twitters.Core.Enitites
{
    public  class Saves : BaseEntity,IAuditedEnity
    {
        public User User { get; set; }
        public Guid UserId { get; set; }
        public Post Post { get; set; }
        public Guid PostId { get; set; }
        public string? CreatBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public string? UpdateBY { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
