using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.DataAccess.DTO;

namespace Twitter.Application.Service.lmpl
{
    public class SavesService : ISavesService
    {
        public Task<SavesDTO> AddSavesAsync(SavesDTO commentDTO)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSavesAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SavesDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SavesDTO> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<SavesDTO> UpdateSavesAsync(Guid id, SavesDTO commentDTO)
        {
            throw new NotImplementedException();
        }
    }
}
