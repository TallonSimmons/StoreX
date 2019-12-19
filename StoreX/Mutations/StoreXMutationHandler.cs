using MediatR;

namespace StoreX
{
    public abstract class StoreXMutationHandler<T> : AsyncRequestHandler<T> 
        where T : StoreXMutation
    {
    }
}
