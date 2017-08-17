using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCrossAndroidDrawer.Core.Models;

namespace MvvmCrossAndroidDrawer.Core.ViewModels
{
    public class ItemType1DetailsViewModel : MvxViewModel<ItemType1>
    {
        private readonly IMvxNavigationService _navigationService;

        private ItemType1 _itemType1;

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }

        public ItemType1DetailsViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override Task Initialize(ItemType1 parameter)
        {
			_itemType1 = parameter;
			Name = _itemType1.Name;
			return Task.FromResult(0);
        }
    }
}
