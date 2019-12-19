using System;

namespace Simple_Shop.Web.State
{ 
    public abstract class StoreXStore
    {
        public event Action OnStoreMutated;

        protected void NotifyStoreMutated() => OnStoreMutated?.Invoke();
    }
}
