using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.DataAccess.DTO;
using Twitters.Core.Enitites;

namespace Twitter.Application.Service
{
     public  interface IUserService
    {
        Task<UserReturnDTO> GetByIdAsync(Guid id);
        Task<List<UserReturnDTO>> GetAllAsync();
        Task<User> AddUserAsync(UserDTO userForCreationDTO);
        Task<User> UpdateUserAsync(Guid id, UserDTO userDto);
        Task<bool> DeleteUserAsync(Guid id);
    }
}
