using MediatR;
namespace SomnosSuite.Application.Abstractions
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
        
    }
}