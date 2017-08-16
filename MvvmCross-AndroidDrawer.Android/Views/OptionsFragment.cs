using Android.Runtime;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCrossAndroidDrawer.Core.ViewModels;

namespace MvvmCrossAndroidDrawer.Android.Views
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("mvvmcrossandroiddrawer.android.views.OptionsFragment")]
    public class OptionsFragment : BaseFragment<OptionsViewModel>
    {
        protected override int FragmentId => Resource.Layout.fragment_options;
    }
}
