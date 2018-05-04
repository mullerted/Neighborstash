using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;

namespace Neighborstash.Core.ViewModel
{
    public class MainViewModel
        : MvxViewModel
    {

        public override Task Initialize()
        {
            // Async initialization, YEY!

            return base.Initialize();
        }

        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);

        private void ResetText()
        {
            Hello = "Hello from NeighborStash";
        }

        private string _hello = "Hello from NeighborStash";
        public string Hello
        {
            get { return _hello; }
            set { SetProperty(ref _hello, value); }
        }
    }
}
