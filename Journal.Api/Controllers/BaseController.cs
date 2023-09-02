using AutoMapper;
using Journal.Persistence.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Journal.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BaseController : Controller
{
    protected readonly IMapper _mapper;
    protected readonly IUnitOfWork _unitOfWork;

    public BaseController(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
}
