using AutoMapper;
using Microservice.Api.Database;
using Microservice.Api.Entities;
using Microservice.Api.Models;
using Microservice.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Microservice.Api.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        #region Fields

        private readonly IPhotoTravelRepository _repository;
        private readonly IMapper _mapper;

        #endregion

        #region Ctor

        public PostsController(IPhotoTravelRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #endregion

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Post> posts = _repository.GetAllPosts().ToList();

                var mappedResults = _mapper.Map<IEnumerable<PostDTO>>(posts);

                return Ok(mappedResults);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{postId:int}", Name = "GetPost")]
        public IActionResult GetPost(int postId)
        {
            Post post = _repository.GetPostById(postId);

            if (post == null) return NotFound();

            return Ok(_mapper.Map<PostDTO>(post));
        }

        [HttpPost]
        public IActionResult Post(CreatePostDTO model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var post = _mapper.Map<Post>(model);

                    _repository.AddPost(post);

                    if (_repository.Save())
                    {
                        var newPost = _mapper.Map<PostDTO>(post);

                        return CreatedAtRoute("GetPost", new { postId = newPost.Id }, newPost);
                    }
                }
            }
            catch
            {
                return StatusCode(500);
            }

            return BadRequest();
        }

        [HttpDelete("{postId:int}")]
        public IActionResult Delete(int authorId)
        {
            try
            {
                Post post = _repository.GetPostById(authorId);

                if (post == null) return NotFound();

                _repository.DeletePost(post);

                if (_repository.Save())
                {
                    return Ok();
                }
                else
                {
                    return StatusCode(500);
                }
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
