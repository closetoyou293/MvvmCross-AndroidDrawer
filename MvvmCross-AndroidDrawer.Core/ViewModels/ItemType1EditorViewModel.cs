using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCrossAndroidDrawer.Core.Models;

namespace MvvmCrossAndroidDrawer.Core.ViewModels
{
    public class ItemType1EditorViewModel : MvxViewModel<ItemType1>
	{
		private readonly IMvxNavigationService _navigationService;

		private ItemType1 _itemType1;

		public ItemType1EditorViewModel(IMvxNavigationService navigationService)
		{
			_navigationService = navigationService;
		}

        public override Task Initialize(ItemType1 parameter)
		{
			_itemType1 = parameter;
			return Task.FromResult(0);
        }
    }
}
