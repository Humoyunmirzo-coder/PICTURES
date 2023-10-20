using Aplication.Services;
using Domain.Models;
using Domain.Models.UserDTO;
using Domain.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Picture.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _user;

        public UserController(IUser user)
        {
            _user = user;
        }
        //[HttpGet ]
        //public IActionResult Get()
        //{
        //    return Ok( );
        //}
        [HttpGet]
        public  async IAsyncEnumerable<IActionResult> GetById(int id )
        {
             User userEntity = await _user.GetByIdAsync( id );
            UserDTO userDTO = new UserDTO
            {
             
                Id=userEntity.ID,
                Email = userEntity.Email,
                Login = userEntity.Login,
                Name = userEntity.Name,
                Password = userEntity.Password,
                Friend = userEntity.Friend,
                FriendsID = userEntity.FriendsID,
                ImageID = new List<int > { userEntity.ImageID }

            };
            yield return Ok ( userDTO );
        }
        [HttpGet]
        public async Task<ResponsModels<IEnumerable<UserDTO>>> GettAll()
        {

            IEnumerable<UserDTO> user =
               (await _user.GetAllAsync())
               .Select(x => new UserDTO
               {
                   Id = x.Id,
                   Name = x.Name,
                   Password = x.Password,
                   Login = x.Login,
                   Friend = x.Friend,
                   Email = x.Email,
                   FriendsID = x.FriendsID,
                   ImageID = new List<int>()

               }) ;

            return new(user);
        }
       
    }
}
