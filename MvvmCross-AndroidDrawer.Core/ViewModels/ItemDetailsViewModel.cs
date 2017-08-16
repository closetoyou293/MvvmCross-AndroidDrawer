using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCrossAndroidDrawer.Core.Models;

namespace MvvmCrossAndroidDrawer.Core.ViewModels
{
    public class ItemDetailsViewModel : MvxViewModel<Item>
    {
        private readonly IMvxNavigationService _navigationService;

        private Item _item;

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

        public ItemDetailsViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override Task Initialize(Item parameter)
        {
			_item = parameter;
			Name = _item.Name;
			return Task.FromResult(0);
        }
    }
}
