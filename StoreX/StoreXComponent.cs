using MediatR;
using Microsoft.AspNetCore.Components;

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
    }
}
