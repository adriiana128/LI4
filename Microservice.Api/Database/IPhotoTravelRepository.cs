using Microservice.Api.Entities;
using System.Collections.Generic;

namespace Microservice.Api.Database
{
    public interface IPhotoTravelRepository
    {
        IEnumerable<Post> GetAllPosts();
        Post GetPostById(int id);
        void AddPost(Post entity);
        void DeletePost(Post entity);
        void UpdatePost(Post entity);
        bool PostExists(int id);

        IEnumerable<Place> GetAllPlaces();
        Place GetPlaceById(int id);
        void AddPlace(Place entity);
        void DeletePlace(Place entity);
        void UpdatePlace(Place entity);
        bool PlaceExists(int id);

        bool Save();

        IEnumerable<Users> GetAllUsers();
        Users GetUserById(int userId);
        void AddUser(Users entity);
        void DeleteUser(Users entity);
        void UpdateUser(Users entity);
        bool UserExists(int id);

        IEnumerable<Commentary> GetAllCommentaries(int postId);
        Commentary GetCommentaryById(int postId, int commentId);
        void AddCommentary(int postId, Commentary commentary);
        void DeleteCommentary(int postId, Commentary commentary);
        void UpdateCommentary(int postId, Commentary commentary);
        bool CommentaryExists(int postId, int commentId);
    }
}
