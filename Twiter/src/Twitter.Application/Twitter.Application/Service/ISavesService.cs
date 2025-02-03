using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.DataAccess.DTO;

namespace Twitter.Application.Service
{
    public  interface ISavesService
    {
        Task<SavesDTO> GetByIdAsync(Guid id);
        Task<List<SavesDTO>> GetAllAsync();
        Task<SavesDTO> AddSavesAsync(SavesDTO commentDTO);
        Task<SavesDTO> UpdateSavesAsync(Guid id, SavesDTO commentDTO);
        Task<bool> DeleteSavesAsync(Guid id);
    }
}
