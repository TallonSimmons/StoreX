using MediatR;

namespace Simple_Shop.Web.State.Mutations
{
    public abstract class StoreXMutationHandler<T> : AsyncRequestHandler<T> 
        where T : StoreXMutation
    {
    }
}
