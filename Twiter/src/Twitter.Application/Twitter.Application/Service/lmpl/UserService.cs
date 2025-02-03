using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitter.DataAccess.Authentication;
using Twitter.DataAccess.DTO;
using Twitter.DataAccess.Repository;
using Twitters.Core.Enitites;

namespace Twitter.Application.Service.lmpl
{
    public class UserService : IUserService
    {
     
        private readonly IUserRepositoryRepository _users;

        private readonly IPasswordHasher _passwordHasher;
        public UserService(IUserRepositoryRepository userRepository,
            IPasswordHasher passwordHasher)
        {
            _users = userRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<UserReturnDTO> GetByIdAsync(Guid id)
        {
            var user = await _users.GetFirstAsync(u => u.Id == id);


            if (user == null)
                return null;

            return new UserReturnDTO {
                Email = user.Email, 
                Name = user.Name,
                UserName = user.UserName
            };
        }

    

        public async Task<List<UserReturnDTO>> GetAllAsync()
        {
            var users = await _users.GetAllAsync(u => true);
            return users.Select(user => new UserReturnDTO
            {
                Name = user.Name,
                Email = user.Email,
                UserName = user.UserName
            }).ToList();
        }
        private static readonly Random _random = new Random();

        public async Task<User> AddUserAsync(UserDTO userForCreationDTO)
        {
            if (userForCreationDTO == null)
                throw new ArgumentNullException(nameof(userForCreationDTO));

            string randomSalt = Guid.NewGuid().ToString();
       
            User user = new User()
            {
                Name = userForCreationDTO.Name,
                Email = userForCreationDTO.Email,
                UserName= userForCreationDTO.UserName,

                Salt = randomSalt,
                Password = _passwordHasher.Encrypt(
                    password: userForCreationDTO.Password,
                    salt: randomSalt),

                
            };
            var res = await _users.AddAsync(user);

            return user;
        }

        public async Task<User> UpdateUserAsync(Guid id, UserDTO userDto)
        {

            if (userDto == null)
                throw new ArgumentNullException(nameof(userDto), "UserDTO cannot be null.");


            var user = await _users.GetFirstAsync(u => u.Id == id);

            if (user == null)
                return null;


            user.Name = userDto.Name;
            user.Email = userDto.Email;
            user.UserName = userDto.UserName;


            await _users.UpdateAsync(user);

            return user;
        }


        public async Task<bool> DeleteUserAsync(Guid id)
        {
            var user = await _users.GetFirstAsync(u => u.Id == id);

            if (user == null)
                return false;

            await _users.DeleteAsync(user);
            return true;
        }
    }
}
