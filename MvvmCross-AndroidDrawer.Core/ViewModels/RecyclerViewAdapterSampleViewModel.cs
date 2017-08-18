using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvvmCrossAndroidDrawer.Core.ViewModels
{
    public class RecyclerViewAdapterSampleViewModel : MvxViewModel
	{
		private readonly IMvxNavigationService _navigationService;

		public RecyclerViewAdapterSampleViewModel(IMvxNavigationService navigationService)
		{
			_navigationService = navigationService;
        }
	}
}
