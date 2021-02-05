namespace PetSupport.Core.Interfaces
{
    public interface IUriService
{
    public Uri GetPageUri(PaginationFilter filter, string route);
}
}