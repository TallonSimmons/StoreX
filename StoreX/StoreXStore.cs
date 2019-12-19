using System;

namespace StoreX
{ 
    public abstract class StoreXStore
    {
        public event Action OnStoreMutated;

        protected void NotifyStoreMutated() => OnStoreMutated?.Invoke();
    }
}
