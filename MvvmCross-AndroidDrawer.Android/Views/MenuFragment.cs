﻿using System;
using System.Threading.Tasks;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using MvvmCrossAndroidDrawer.Core.ViewModels;

namespace MvvmCrossAndroidDrawer.Android.Views
{
	[MvxFragment(typeof(MainViewModel), Resource.Id.navigation_frame)]
	[Register("mvvmcrossandroiddrawer.android.views.MenuFragment")]
	public class MenuFragment : MvxFragment<MenuViewModel>, NavigationView.IOnNavigationItemSelectedListener
	{
		private NavigationView _navigationView;
		private IMenuItem _previousMenuItem;

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var ignore = base.OnCreateView(inflater, container, savedInstanceState);

			var view = this.BindingInflate(Resource.Layout.fragment_navigation, null);

			_navigationView = view.FindViewById<NavigationView>(Resource.Id.navigation_view);
			_navigationView.SetNavigationItemSelectedListener(this);
            _navigationView.Menu.FindItem(Resource.Id.nav_home).SetChecked(true);

			return view;
		}

		public bool OnNavigationItemSelected(IMenuItem item)
		{
			if (_previousMenuItem != null)
				_previousMenuItem.SetChecked(false);

			item.SetCheckable(true);
			item.SetChecked(true);

			_previousMenuItem = item;

			Navigate(item.ItemId);

			return true;
		}

		private async Task Navigate(int itemId)
		{
            ((MainActivity)Activity).DrawerLayout.CloseDrawers();
			await Task.Delay(TimeSpan.FromMilliseconds(250));

			switch (itemId)
			{
                case Resource.Id.nav_home:
					ViewModel.ShowHomeCommand.Execute(null);
					break;
                case Resource.Id.nav_recyclerviewadaptersample:
                    ViewModel.ShowRecyclerViewAdapterSampleCommand.Execute(null);
					break;
                case Resource.Id.nav_options:
					ViewModel.ShowOptionsCommand.Execute(null);
					break;
			}
		}
	}
}
