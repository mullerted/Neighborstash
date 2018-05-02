using MvvmCross.Core.ViewModels;

namespace Neighborstash.Core.ViewModel
{
    public class MainViewModel
        : MvxViewModel
    {
        private string _hello = "Welcome to NeighborStasher";
        public string Hello
        {
            get => _hello;
            set => SetProperty(ref _hello, value);
        }
    }
}
