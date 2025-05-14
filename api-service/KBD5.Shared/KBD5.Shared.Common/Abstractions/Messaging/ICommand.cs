using KBD5.Shared.Common.Results;
using MediatR;

namespace KBD5.Shared.Common.Abstractions.Messaging;

public interface ICommand : IRequest<Result>, IBaseCommand;

public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand;

public interface IBaseCommand;