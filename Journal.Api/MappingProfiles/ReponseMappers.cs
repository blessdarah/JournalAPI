using AutoMapper;
using Journal.Entities.Models;
using Journal.Entities.Response.Category;

namespace Journal.Api.MappingProfiles;

public class ResponseMappers : Profile
{
    public ResponseMappers()
    {
        CreateMap<Category, CategoryResponse>();
    }
}
