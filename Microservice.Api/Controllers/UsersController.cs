using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microservice.Api.Database;
using Microservice.Api.Entities;
using Microservice.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IPhotoTravelRepository _repository;
        private readonly IMapper _mapper;

        public UsersController(IPhotoTravelRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("{userId:int}", Name = "GetUser")]
        public IActionResult GetPost(int userId)
        {
            Users user = _repository.GetUserById(userId);

            if (user == null) return NotFound();

            return Ok(_mapper.Map<UserDTO>(user));
        }

        [HttpPost]
        public IActionResult Post(CreateUserDTO model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = _mapper.Map<Users>(model);

                    _repository.AddUser(user);

                    if (_repository.Save())
                    {
                        var newUser = _mapper.Map<UserDTO>(user);

                        return CreatedAtRoute("GetUser", new { userId = newUser.Id }, newUser);
                    }
                }
            }
            catch
            {
                return StatusCode(500);
            }

            return BadRequest();
        }
    }
}
