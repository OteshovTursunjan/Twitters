using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.DataAccess.DTO
{
    public  class UserReturnDTO
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string UserName { get; set; }
    }
}
