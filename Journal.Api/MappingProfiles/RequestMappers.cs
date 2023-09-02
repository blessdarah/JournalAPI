using AutoMapper;
using Journal.Entities.Models;
using Journal.Entities.Requests.Category;

namespace Journal.Api.MappingProfiles;

public class RequestMappers : Profile
{
    public RequestMappers()
    {
        CreateMap<CreateCategoryRequest, Category>();
    }
}
