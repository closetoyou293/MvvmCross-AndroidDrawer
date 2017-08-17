using Android.App;
using Android.Support.V7.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCrossAndroidDrawer.Core.ViewModels;

namespace MvvmCrossAndroidDrawer.Android.Views
{
    [Activity(Name = "mvvmcrossandroiddrawer.android.views.ItemType1EditorActivity",
              Theme = "@style/AppTheme")]
    public class ItemType1EditorActivity : MvxAppCompatActivity<ItemType1EditorViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.activity_itemtype1editor);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
        }
    }
}
