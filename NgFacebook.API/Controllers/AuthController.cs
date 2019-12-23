using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NgFacebook.API.Data;
using NgFacebook.API.Dtos;
using NgFacebook.API.Helpers;
using NgFacebook.API.Models;

namespace NgFacebook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]        
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;
        private IMapper _mapper;
        public AuthController(IAuthRepository repo, IConfiguration config)
        {
            _repo = repo;
            _config = config;
            
            var mapConfig = new MapperConfiguration(cfg => {
                cfg.AddProfile<MyMap>();
            });

            _mapper = new Mapper(mapConfig);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            // Validate the request
            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

            if (await _repo.UserExists(userForRegisterDto.Username))
                return BadRequest("Username already exists!");    

            var userToCreate = _mapper.Map<UserForRegisterDto, User>(userForRegisterDto);

            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Password);

            var userToReturn = _mapper.Map<User, UserForDetailedDto>(createdUser);

            return Ok();
            // return CreatedAtRoute("GetUser", new {controller = "User", Id = createdUser.Id}, userToReturn);
        }
    }
}