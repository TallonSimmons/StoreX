using MediatR;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace StoreX
{
    public class StoreXComponent<TStore> : ComponentBase
        where TStore : StoreXStore
    {
        [Inject]
        public IMediator Mediator { private get; set; }
        [Inject]
        public TStore Store { get; set; }

        protected override void OnInitialized()
        {
            Store.OnStoreMutated += StateHasChanged;
            base.OnInitialized();
        }

        public async Task CommitStoreXMutation(StoreXMutation mutation)
        {
            await Mediator.Send(mutation);
        }
    }
}
