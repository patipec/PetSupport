using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetSupport.Core.Interfaces;

namespace Petsupport.API2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IClientRepository _clientRepository;

        
        public ClientsController(IClientRepository clientRepository, IMapper mapper)
        {
            this._mapper = mapper;
            this._clientRepository = clientRepository;
        }

        
    }
}