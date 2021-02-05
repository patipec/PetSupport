using Microsoft.Extensions.Configuration;
using Microsoft.Graph;
using Microsoft.Graph.Auth;
using Microsoft.Identity.Client;

namespace Petsupport.API2.GraphServicesFactory
{
    public class GraphService : IGraphService
    {
        public GraphServiceClient GraphClient { get; }
        public AzureOptions AzureOptions { get; }

        public GraphService(IConfiguration configuration)
        {
            AzureOptions = new AzureOptions();
            configuration.Bind("AzureAdB2C", AzureOptions);
            // Initialize the client credential auth provider
            var confidentialClientApplication = ConfidentialClientApplicationBuilder
                .Create(AzureOptions.ClientId)
                .WithTenantId(AzureOptions.Domain)
                .WithClientSecret(AzureOptions.ClientSecret)
                .Build();
            var authProvider = new ClientCredentialProvider(confidentialClientApplication);

            // Set up the Microsoft Graph service client with client credentials
            GraphClient = new GraphServiceClient(authProvider);
        }
    }
}