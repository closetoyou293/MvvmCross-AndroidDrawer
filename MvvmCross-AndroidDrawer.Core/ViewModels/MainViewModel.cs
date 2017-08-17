using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvvmCrossAndroidDrawer.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

			ShowHomeViewModelCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<HomeViewModel>());
            ShowItemType2ListViewModelCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<ItemType2ListViewModel>());
            ShowOptionsViewModelCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<OptionsViewModel>());
            ShowMenuViewModelCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<MenuViewModel>());
        }

        public override void Start()
        {
            base.Start();
        }

		public IMvxAsyncCommand ShowHomeViewModelCommand { get; private set; }
		public IMvxAsyncCommand ShowItemType2ListViewModelCommand { get; private set; }
        public IMvxAsyncCommand ShowOptionsViewModelCommand { get; private set; }
        public IMvxAsyncCommand ShowMenuViewModelCommand { get; private set; }
    }
}
