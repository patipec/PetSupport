using System.Collections.Generic;
using AutoMapper;
using Microsoft.Graph;
using Petsupport.API2.Dtos.InDtos;
using Petsupport.API2.GraphServiceFactory;

namespace Petsupport.API2.Profiles
{
    public class CreatePetsitterDTOToUserConverter : ITypeConverter<CreatePetsitterDTO, User>
    {
        private readonly AzureOptions _azureOptions;
        public CreatePetsitterDTOToUserConverter(IGraphService graphService)
        {
            _azureOptions = graphService.AzureOptions;
        }
        public User Convert(CreatePetsitterDTO source, User user, ResolutionContext context)
        {
            user = new User
            {
                AccountEnabled = true,
                GivenName = source.BasicInfoDto.Name,
                Surname = source.BasicInfoDto.Surname,
                DisplayName = source.BasicInfoDto.Name + " " + source.BasicInfoDto.Surname,
                Identities = new List<ObjectIdentity>
                {
                    new ObjectIdentity()
                    {
                        SignInType = "emailAddress",
                        Issuer = _azureOptions.Domain,
                        IssuerAssignedId = source.BasicInfoDto.Email
                    }
                },
                PasswordPolicies = "DisablePasswordExpiration",
                PasswordProfile = new PasswordProfile
                {
                    ForceChangePasswordNextSignIn = false,
                    Password = source.BasicInfoDto.Password
                }
            };

            return user;
        }
    }
}