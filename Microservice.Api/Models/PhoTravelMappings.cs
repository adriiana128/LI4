using AutoMapper;
using Microservice.Api.Entities;
using Microservice.API.Models;

namespace Microservice.Api.Models
{
    public class PhoTravelMappings : Profile
    {
        public PhoTravelMappings()
        {
            CreateMap<Post, PostDTO>()
                .ReverseMap();

            CreateMap<Commentary, CommentaryDTO>()
                .ReverseMap();

            CreateMap<Post, CreatePostDTO>()
                .ReverseMap();
        }
    }
}
