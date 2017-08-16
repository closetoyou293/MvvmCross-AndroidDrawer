using Android.App;
using Android.Support.V7.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCrossAndroidDrawer.Core.ViewModels;

namespace MvvmCrossAndroidDrawer.Android.Views
{
    [Activity(Name = "mvvmcrossandroiddrawer.android.views.ItemDetailsActivity",
              Theme = "@style/AppTheme")]
    public class ItemDetailsActivity : MvxAppCompatActivity<ItemDetailsViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.activity_itemdetails);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
        }
    }
}
