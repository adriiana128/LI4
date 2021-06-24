using Microservice.Api.Entities;
using Microservice.API.Database;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Microservice.Api.Database
{
    public class PhotoTravelRepository : IPhotoTravelRepository
    {
        private readonly DatabaseContext _context;

        public PhotoTravelRepository(DatabaseContext context)
        {
            _context = context;
        }

        IEnumerable<Post> IPhotoTravelRepository.GetAllPosts()
        {
            return _context.Post
                .Include(p => p.Commentaries)
                .Include(p => p.Place)
                .ToList();
        }

        Post IPhotoTravelRepository.GetPostById(int id)
        {
            return _context.Post
                .Include(p => p.Commentaries)
                .Include(p => p.Place)
                .SingleOrDefault(e => e.Id == id);
        }

        void IPhotoTravelRepository.AddPost(Post entity)
        {
            foreach (var comment in entity.Commentaries)
            {
                _context.Commentary.Add(comment);
            }
            
            _context.Post.Add(entity);
        }
        void IPhotoTravelRepository.DeletePost(Post entity)
        {
            _context.Post.Remove(entity);
        }

        void IPhotoTravelRepository.UpdatePost(Post entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        bool IPhotoTravelRepository.PostExists(int id)
        {
            return _context.Post.Any(post => post.Id == id);
        }

        IEnumerable<Place> IPhotoTravelRepository.GetAllPlaces()
        {
            return _context.Place.ToList();
        }
        
        Place IPhotoTravelRepository.GetPlaceById(int id)
        {
            return _context.Place
                .SingleOrDefault(e => e.Id == id);
        }

        void IPhotoTravelRepository.AddPlace(Place entity)
        {
            _context.Place.Add(entity);
        }

        void IPhotoTravelRepository.DeletePlace(Place entity)
        {
            _context.Place.Remove(entity);
        }

        void IPhotoTravelRepository.UpdatePlace(Place entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        bool IPhotoTravelRepository.PlaceExists(int id)
        {
            return _context.Place.Any(post => post.Id == id);
        }

        bool IPhotoTravelRepository.Save()
        {
            return _context.SaveChanges() > 0;
        }

        IEnumerable<Users> IPhotoTravelRepository.GetAllUsers()
        {
            return _context.Users
                .Include(e => e.Posts)
                .ToList();
        }

        Users IPhotoTravelRepository.GetUserById(int userId)
        {
            return _context.Users
                .Include(e => e.Posts)
                .SingleOrDefault(e => e.Id == userId);
        }

        void IPhotoTravelRepository.AddUser(Users entity)
        {
            var user = _context.Users.SingleOrDefault(u => u.Email == entity.Email);
            
            if(user == null)
                _context.Users.Add(entity);
        }

        void IPhotoTravelRepository.DeleteUser(Users entity)
        {
            _context.Remove(entity);
        }

        void IPhotoTravelRepository.UpdateUser(Users entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        bool IPhotoTravelRepository.UserExists(int id)
        {
            return _context.Users.Any(user => user.Id == id);
        }

        IEnumerable<Commentary> IPhotoTravelRepository.GetAllCommentaries(int postId)
        {
            return _context.Post
                .Include(a => a.Commentaries)
                .SingleOrDefault(e => e.Id == postId)
                .Commentaries
                .ToList();
        }

        Commentary IPhotoTravelRepository.GetCommentaryById(int postId, int commentId)
        {
            return _context.Post
                .Include(a => a.Commentaries)
                .SingleOrDefault(e => e.Id == postId)
                .Commentaries
                .SingleOrDefault(e => e.Id == commentId);
        }

        void IPhotoTravelRepository.AddCommentary(int postId, Commentary commentary)
        {
            _context.Post
                .Include(a => a.Commentaries)
                .SingleOrDefault(e => e.Id == postId)
                .Commentaries
                .Add(commentary);
        }

        void IPhotoTravelRepository.DeleteCommentary(int postId, Commentary commentary)
        {
            _context.Post
                .Include(a => a.Commentaries)
                .SingleOrDefault(e => e.Id == postId)
                .Commentaries
                .Remove(commentary);
        }

        void IPhotoTravelRepository.UpdateCommentary(int postId, Commentary commentary)
        {
            _context.Entry(commentary).State = EntityState.Modified;
        }

        public bool CommentaryExists(int postId, int commentId)
        {
            return _context.Commentary.Any(c => c.Id == commentId && c.PostId == postId);
        }
    }
}
