using KBD5.Shared.Common.Results;
using MediatR;

namespace KBD5.Shared.Common.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>;