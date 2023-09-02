using AutoMapper;
using Journal.Entities.Response.Category;
using Journal.Persistence.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Journal.Api.Controllers;

public class CategoriesController : BaseController
{
    public CategoriesController(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
    { }

    [HttpGet]
    public async Task<IEnumerable<CategoryResponse>> Get()
    {
        var categories = await _unitOfWork.Categories.All();
        await _unitOfWork.CompleteAsync();
        var result = _mapper.Map<IEnumerable<CategoryResponse>>(categories);
        return result;
    }
}
