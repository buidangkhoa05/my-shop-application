using KBD5.Shared.Common.Results;
using MediatR;

namespace KBD5.Shared.Common.Abstractions.Messaging;

public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>;