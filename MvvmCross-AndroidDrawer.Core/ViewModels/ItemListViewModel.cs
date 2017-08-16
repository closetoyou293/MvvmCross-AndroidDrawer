using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCrossAndroidDrawer.Core.Models;

namespace MvvmCrossAndroidDrawer.Core.ViewModels
{
    public class ItemListViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public ItemListViewModel(IMvxNavigationService navigationService)
        {
			_navigationService = navigationService;

            ShowItemDetailsCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<ItemDetailsViewModel, Item>(new Item { Id = 1, Name = "Test" }));
		}

		public IMvxCommand ShowItemDetailsCommand { get; private set; }
    }
}
