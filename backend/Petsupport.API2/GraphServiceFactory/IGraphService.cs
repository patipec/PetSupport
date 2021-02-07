using Microsoft.Graph;

namespace Petsupport.API2.GraphServiceFactory
{
    public interface IGraphService
    {
        public GraphServiceClient GraphClient { get; }
        public AzureOptions AzureOptions { get; }
    }
}