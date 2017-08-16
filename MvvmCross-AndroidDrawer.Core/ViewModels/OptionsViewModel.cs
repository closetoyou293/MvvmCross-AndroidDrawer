using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvvmCrossAndroidDrawer.Core.ViewModels
{
    public class OptionsViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public OptionsViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
		}
    }
}
