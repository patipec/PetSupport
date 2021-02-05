using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph;
using Microsoft.Graph.Auth;
using Petsupport.API2.GraphServicesFactory;


namespace Petsupport.API2.Controllers
{
    [Route("api/petsitters/register")]
    [ApiController]
    public class AzureManagementController : ControllerBase
    {
        private readonly IGraphService _graphService;

        public AzureManagementController(IGraphService graphService)
        {
            _graphService = graphService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser()
        {
            var user = new User
            {
                AccountEnabled = true,
                DisplayName = "Adele Vance",
                Identities = new List<ObjectIdentity>
                {
                    new ObjectIdentity()
                    {
                        SignInType = "emailAddress",
                        Issuer = _graphService.AzureOptions.Domain,
                        IssuerAssignedId = "zdulaczek@gmail.com"
                    }
                },
                PasswordPolicies = "DisablePasswordExpiration",
                PasswordProfile = new PasswordProfile
                {
                    ForceChangePasswordNextSignIn = false,
                    Password = "xWwvJ]6NMw+bWH-d"
                }
            };

            await _graphService.GraphClient.Users
                .Request()
                .AddAsync(user);
            return StatusCode(StatusCodes.Status201Created);
        }

    }
}
