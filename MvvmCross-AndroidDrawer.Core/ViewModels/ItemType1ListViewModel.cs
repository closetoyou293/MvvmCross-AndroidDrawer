using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCrossAndroidDrawer.Core.Models;

namespace MvvmCrossAndroidDrawer.Core.ViewModels
{
    public class ItemType1ListViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        private MvxObservableCollection<ItemType1> _itemType1List;
        public MvxObservableCollection<ItemType1> ItemType1List
        {
            get
            {
                return _itemType1List;
            }
            set
            {
                _itemType1List = value;
                RaisePropertyChanged(() => ItemType1List);
            }
        }

        public ItemType1ListViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            ItemType1List = new MvxObservableCollection<ItemType1>();
            for (int i = 1; i <= 50; i++)
            {
                ItemType1List.Add(new ItemType1 { Id = i, Name = string.Format("Item type 1 no. {0}", i) });
            }

            ItemType1SelectedCommand = new MvxAsyncCommand<ItemType1>(async (item) => await _navigationService.Navigate<ItemType1DetailsViewModel, ItemType1>(item));
        }

        public IMvxCommand<ItemType1> ItemType1SelectedCommand { get; private set; }
    }
}
