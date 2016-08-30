using Caliburn.Micro;

namespace GettingStarted
{
    class AppViewModel : PropertyChangedBase
    {
        private int _count = 50;

        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                NotifyOfPropertyChange(() => Count);
                //NotifyOfPropertyChange(nameof(Count));
            }
        }
    }
}
