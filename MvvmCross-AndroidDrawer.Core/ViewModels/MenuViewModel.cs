using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvvmCrossAndroidDrawer.Core.ViewModels
{
    public class MenuViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MenuViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

			ShowHomeCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<HomeViewModel>());
			ShowItemType2ListCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<ItemType2ListViewModel>());
            ShowOptionsCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<OptionsViewModel>());
        }

		public IMvxCommand ShowHomeCommand { get; private set; }
		public IMvxAsyncCommand ShowItemType2ListCommand { get; private set; }
        public IMvxCommand ShowOptionsCommand { get; private set; }
    }
}
