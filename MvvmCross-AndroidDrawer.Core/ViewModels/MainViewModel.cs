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
            ShowMenuViewModelCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<MenuViewModel>());
            ShowOptionsViewModelCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<OptionsViewModel>());
            ShowRecyclerViewAdapterViewModelSampleCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<RecyclerViewAdapterSampleViewModel>());
        }

        public override void Start()
        {
            base.Start();
        }

		public IMvxAsyncCommand ShowHomeViewModelCommand { get; private set; }
        public IMvxAsyncCommand ShowMenuViewModelCommand { get; private set; }
        public IMvxAsyncCommand ShowOptionsViewModelCommand { get; private set; }
        public IMvxAsyncCommand ShowRecyclerViewAdapterViewModelSampleCommand { get; private set; }
    }
}
