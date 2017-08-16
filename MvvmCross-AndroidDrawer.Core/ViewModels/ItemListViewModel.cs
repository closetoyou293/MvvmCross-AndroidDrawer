using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCrossAndroidDrawer.Core.Models;

namespace MvvmCrossAndroidDrawer.Core.ViewModels
{
    public class ItemListViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        private MvxObservableCollection<Item> _items;
        public MvxObservableCollection<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                RaisePropertyChanged(() => Items);
            }
        }

        public ItemListViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            Items = new MvxObservableCollection<Item>();
            for (int i = 1; i <= 50; i++)
            {
                Items.Add(new Item { Id = i, Name = string.Format("Item {0}", i) });
            }

            ItemSelectedCommand = new MvxAsyncCommand<Item>(async (item) => await _navigationService.Navigate<ItemDetailsViewModel, Item>(item));
        }

        public IMvxCommand<Item> ItemSelectedCommand { get; private set; }
    }
}
