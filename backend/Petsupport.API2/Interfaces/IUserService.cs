using System.Collections.Generic;
using Petsupport.API2.Dtos.InDtos;
using Petsupport.API2.Dtos.OutDtos;

namespace PetSupport.Core.Services
{
    public interface IUserService
    {
        IEnumerable<PetsitterProfileDTO> GetAllPetsitters();
        PetsitterListDTO GetUserById(int id);

    }
}