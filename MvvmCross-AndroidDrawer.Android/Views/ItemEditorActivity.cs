using Android.App;
using Android.Support.V7.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCrossAndroidDrawer.Core.ViewModels;

namespace MvvmCrossAndroidDrawer.Android.Views
{
    [Activity(Name = "mvvmcrossandroiddrawer.android.views.ItemEditorActivity",
              Theme = "@style/AppTheme")]
    public class ItemEditorActivity : MvxAppCompatActivity<ItemEditorViewModel>
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.activity_itemeditor);
            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
        }
    }
}
