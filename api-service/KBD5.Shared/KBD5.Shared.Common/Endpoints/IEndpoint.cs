using Microsoft.AspNetCore.Routing;

namespace KBD5.Shared.Common.Endpoints;

public interface IEndpoint
{
    void MapEndpoint(IEndpointRouteBuilder app);
}