using System.Collections.Generic;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCrossAndroidDrawer.Core.Models;

namespace MvvmCrossAndroidDrawer.Core.ViewModels
{
    public class ItemType2ListViewModel : MvxViewModel
	{
		private readonly IMvxNavigationService _navigationService;

		private MvxObservableCollection<ItemType2> _itemType2List;
		public MvxObservableCollection<ItemType2> ItemType2List
		{
			get
			{
				return _itemType2List;
			}
			set
			{
				_itemType2List = value;
                RaisePropertyChanged(() => ItemType2List);
			}
		}

		public ItemType2ListViewModel(IMvxNavigationService navigationService)
		{
			_navigationService = navigationService;

			ItemType2List = new MvxObservableCollection<ItemType2>();
			for (int i = 1; i <= 50; i++)
			{
                ItemType2List.Add(new ItemType2
                {
                    Id = i,
                    Name = string.Format("Item type 2 no. {0}", i),
                    ItemType1List = new List<ItemType1>
                    {
						new ItemType1 { Id = 1, Name = "Item type 1 no. 1" },
						new ItemType1 { Id = 2, Name = "Item type 1 no. 2" },
						new ItemType1 { Id = 3, Name = "Item type 1 no. 3" },
						new ItemType1 { Id = 4, Name = "Item type 1 no. 4" },
						new ItemType1 { Id = 5, Name = "Item type 1 no. 5" },
                    }
                });
			}

            ItemType2SelectedCommand = new MvxAsyncCommand<ItemType2>(async (itemType2) =>
            {
                
            });
		}

        public IMvxCommand<ItemType2> ItemType2SelectedCommand { get; private set; }
    }
}
