using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitters.Core.Common;

namespace Twitters.Core.Enitites
{
    public  class CreatePost : BaseEntity, IAuditedEnity
    {
        public User User { get; set; }
        public Guid UserID { get; set; }
        public string Text { get; set; }
        public string? CreatBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public string? UpdateBY { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
