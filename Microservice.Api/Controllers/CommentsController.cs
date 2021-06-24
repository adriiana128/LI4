using AutoMapper;
using Microservice.Api.Database;
using Microservice.Api.Entities;
using Microservice.Api.Models;
using Microservice.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Microservice.Api.Controllers
{
    [Route("api/posts/{postId}/commentaries")]
    [ApiController]
    public class CommentsController : ControllerBase
    {

        #region Fields
        private readonly IPhotoTravelRepository _repository;
        private readonly IMapper _mapper;
        #endregion 

        #region Ctor
        public CommentsController(IPhotoTravelRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        #endregion

        #region API
        [HttpGet]
        public ActionResult GetCommentsForPost(int postId)
        {
            if (!_repository.PostExists(postId))
            {
                return NotFound();
            }

            var movies = _repository.GetAllCommentaries(postId);
            var moviesForAuthor = _mapper.Map<IEnumerable<CommentaryDTO>>(movies);

            return Ok(moviesForAuthor);
        }

        [HttpGet("{commentId:int}", Name = "GetComment")]
        public ActionResult GetCommentaryForPost(int postId, int commentId)
        {
            if (!_repository.PostExists(postId))
            {
                return NotFound();
            }
            var commentary = _repository.GetCommentaryById(postId, commentId);
            var commentForPost = _mapper.Map<CommentaryDTO>(commentary);

            return Ok(commentForPost);
        }

        [HttpPost]
        public IActionResult Post(int postId, CreateCommentaryDTO model)
        {
            try
            {
                if (!_repository.PostExists(postId))
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    var comment = _mapper.Map<Commentary>(model);

                    _repository.AddCommentary(postId, comment);

                    if (_repository.Save())
                    {
                        var newComment = _mapper.Map<CommentaryDTO>(comment);

                        return CreatedAtRoute("GetComment", new { postId = postId, commentId = newComment.Id }, newComment);
                    }
                }
            }
            catch
            {
                return StatusCode(500);
            }

            return BadRequest();
        }

        [HttpDelete("{commentId:int}")]
        public IActionResult Delete(int postId, int commentId)
        {
            try
            {
                Commentary comment = _repository.GetCommentaryById(postId, commentId);

                if (comment == null) return NotFound();

                _repository.DeleteCommentary(postId, comment);

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
        #endregion
    }
}
