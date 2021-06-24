using Microservice.Api.Entities;
using Microservice.API.Entitites;
using Microsoft.EntityFrameworkCore;

namespace Microservice.API.Database
{
    public interface IDatabaseContext
    {
        DbSet<Commentary> Commentary { get; set; }
        DbSet<Users> Users { get; set; }
        DbSet<Post> Post { get; set; }
        DbSet<Place> Place { get; set; }

        void Save();
    }
}
