using System.Collections.Generic;
using Petsupport.API2.Dtos.InDtos;
using Petsupport.API2.Dtos.OutDtos;

namespace PetSupport.Core.Services
{
    public interface IUserService
    {
        IEnumerable<PetsitterProfileListDTO> GetAllPetsitters();
        PetsitterBriefDtoDTO GetUserById(int id);

    }
}