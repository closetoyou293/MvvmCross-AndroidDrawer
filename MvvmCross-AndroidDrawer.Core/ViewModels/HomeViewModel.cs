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

			ShowItemEditorCommand = new MvxAsyncCommand(async () => await _navigationService.Navigate<ItemType1EditorViewModel, ItemType1>(new ItemType1 { Id = 1, Name = "Test" }));
		}

		public IMvxCommand ShowItemEditorCommand { get; private set; }
    }
}
