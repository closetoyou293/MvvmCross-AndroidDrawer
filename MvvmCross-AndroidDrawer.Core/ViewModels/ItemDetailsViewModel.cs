using System;
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

        public ItemDetailsViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override Task Initialize(Item parameter)
        {
            _item = parameter;
            return Task.FromResult(0);
        }
    }
}
