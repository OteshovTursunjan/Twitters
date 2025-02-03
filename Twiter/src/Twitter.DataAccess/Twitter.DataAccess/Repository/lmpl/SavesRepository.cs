using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitters.Core.Enitites;

namespace Twitter.DataAccess.Repository.lmpl
{
    public  class SavesRepository : BaseRepository<Saves>, ISavesRepository
    {
        public SavesRepository(DatabaseContext context) : base(context) { }
    }
}
