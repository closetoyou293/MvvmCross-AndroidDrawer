using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCrossAndroidDrawer.Core.ViewModels;

namespace MvvmCrossAndroidDrawer.Android.Views
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("mvvmcrossandroiddrawer.android.views.ItemType1ListFragment")]
    public class ItemType1ListFragment : MvxFragment<ItemType1ListViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.fragment_itemtype1list, null);

            var recyclerView = view.FindViewById<MvxRecyclerView>(Resource.Id.itemtype1list_recyclerview);
            if (recyclerView != null)
            {
                recyclerView.HasFixedSize = true;
                var layoutManager = new LinearLayoutManager(Activity);
                recyclerView.SetLayoutManager(layoutManager);
                (recyclerView.Adapter as IMvxRecyclerAdapterBindableHolder).MvxViewHolderBound += (args) =>
                {
                    var item = args.Holder.ItemView;
                    // you can access bound holder item here.
                };
            }

            return view;
        }
    }
}
