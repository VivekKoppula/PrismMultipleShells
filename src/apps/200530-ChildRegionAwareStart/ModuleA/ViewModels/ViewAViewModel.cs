using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using SimplePrism.Core.Prism;

namespace ModuleA.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        public DelegateCommand NavigateCommand { get; set; } = default!;
        public IRegionManager _regionManager { get; set; } = default!;

        private string _welcomeMessage = "Hello from ViewAViewModel";
        public string WelcomeMessage
        {
            get { return _welcomeMessage; }
            set { SetProperty(ref _welcomeMessage, value); }
        }

        public ViewAViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateCommand = new DelegateCommand(Navigate);
        }

        void Navigate()
        {
            _regionManager.RequestNavigate("ContentRegion", "ViewB");
        }
    }
}
