using System.Collections.Generic;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Views;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using MvvmCrossAndroidDrawer.Core.ViewModels;

namespace MvvmCrossAndroidDrawer.Android.Views
{
	[MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
	[Register("mvvmcrossandroiddrawer.android.views.RecyclerViewAdapterSampleFragment")]
	public class RecyclerViewAdapterSampleFragment : BaseStateFragment<RecyclerViewAdapterSampleViewModel>
	{
        protected override int FragmentId => Resource.Layout.fragment_recyclerviewadaptersample;

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = base.OnCreateView(inflater, container, savedInstanceState);

			var viewPager = view.FindViewById<ViewPager>(Resource.Id.viewpager);
			if (viewPager != null)
			{
				var fragments = new List<MvxCachingFragmentStatePagerAdapter.FragmentInfo>
				{
					new MvxCachingFragmentStatePagerAdapter.FragmentInfo("List 1", typeof(ItemType2ListFragment),
																		 typeof(ItemType2ListViewModel)),
					new MvxCachingFragmentStatePagerAdapter.FragmentInfo("List 2", typeof(ItemType2ListFragment),
																		 typeof(ItemType2ListViewModel)),
					new MvxCachingFragmentStatePagerAdapter.FragmentInfo("List 3", typeof(ItemType2ListFragment),
																		 typeof(ItemType2ListViewModel)),
					new MvxCachingFragmentStatePagerAdapter.FragmentInfo("List 4", typeof(ItemType2ListFragment),
																		 typeof(ItemType2ListViewModel)),
					new MvxCachingFragmentStatePagerAdapter.FragmentInfo("List 5", typeof(ItemType2ListFragment),
																		 typeof(ItemType2ListViewModel))
				};
				viewPager.Adapter = new MvxCachingFragmentStatePagerAdapter(Activity, ChildFragmentManager, fragments);
			}

			var tabLayout = view.FindViewById<TabLayout>(Resource.Id.tabs);
			tabLayout.SetupWithViewPager(viewPager);

			return view;
		}
	}
}
