using Caliburn.Micro;

namespace GettingStarted
{
    class AppViewModel : PropertyChangedBase
    {
        private int _count = 50;

        // Data binding (property)
        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                NotifyOfPropertyChange(() => Count);
                NotifyOfPropertyChange(() => CanIncrementCount);
            }
        }

        // Action guard (property)
        public bool CanIncrementCount
        {
            get
            {
                return Count < 100;
            }
        }

        // Handling event
        public void IncrementCount(int delta)
        {
            Count += delta;
        }

    }
}
