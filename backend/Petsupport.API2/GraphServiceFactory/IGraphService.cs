using Microsoft.Graph;

namespace Petsupport.API2.GraphServicesFactory
{
    public interface IGraphService
    {
        public GraphServiceClient GraphClient { get; }
        public AzureOptions AzureOptions { get; }
    }
}