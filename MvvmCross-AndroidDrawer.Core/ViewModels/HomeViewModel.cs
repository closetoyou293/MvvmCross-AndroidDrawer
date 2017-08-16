using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCrossAndroidDrawer.Core.Models;

namespace MvvmCrossAndroidDrawer.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
	{
		private readonly IMvxNavigationService _navigationService;

		public HomeViewModel(IMvxNavigationService navigationService)
		{
			_navigationService = navigationService;

			ShowItemEditorCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<ItemEditorViewModel, Item>(new Item { Id = 1, Name = "Test" }));
		}

		public IMvxCommand ShowItemEditorCommand { get; private set; }
    }
}
