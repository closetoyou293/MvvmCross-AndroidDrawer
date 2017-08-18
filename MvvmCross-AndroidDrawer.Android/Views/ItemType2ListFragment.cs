using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCrossAndroidDrawer.Android.Views.Adapters;
using MvvmCrossAndroidDrawer.Core.ViewModels;

namespace MvvmCrossAndroidDrawer.Android.Views
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("mvvmcrossandroiddrawer.android.views.ItemType2ListFragment")]
    public class ItemType2ListFragment : MvxFragment<ItemType2ListViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.fragment_itemtype1list, null);

			var adapter = new ItemType2RecyclerViewAdapter((IMvxAndroidBindingContext)this.BindingContext);
			var set = this.CreateBindingSet<ItemType2ListFragment, ItemType2ListViewModel>();
			set.Bind(adapter)
			   .For(x => x.ItemsSource)
			   .To(x => x.ItemType2List);
			set.Apply();

			var recyclerView = view.FindViewById<MvxRecyclerView>(Resource.Id.itemtype1list_recyclerview);
            recyclerView.Adapter = adapter;

            return view;
        }
    }
}
