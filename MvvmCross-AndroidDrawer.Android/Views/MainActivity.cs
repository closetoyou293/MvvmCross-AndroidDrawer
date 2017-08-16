﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Views.InputMethods;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCrossAndroidDrawer.Core.ViewModels;

namespace MvvmCrossAndroidDrawer.Android.Views
{
    [Activity(
		Label = "Examples",
		Theme = "@style/AppTheme",
		LaunchMode = LaunchMode.SingleTop,
		Name = "mvvmcrossandroiddrawer.android.views.MainActivity"
		)]
	public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel>
	{
		public DrawerLayout DrawerLayout { get; set; }

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.activity_main);

			DrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

			if (bundle == null)
			{
				ViewModel.ShowHomeViewModelCommand.Execute(null);
				ViewModel.ShowMenuViewModelCommand.Execute(null);
			}
		}

		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			switch (item.ItemId)
			{
                case Android.Resource.Id.nav_home:
					DrawerLayout.OpenDrawer(GravityCompat.Start);
					return true;
			}
			return base.OnOptionsItemSelected(item);
		}

		public override void OnBackPressed()
		{
			if (DrawerLayout != null && DrawerLayout.IsDrawerOpen(GravityCompat.Start))
				DrawerLayout.CloseDrawers();
			else
				base.OnBackPressed();
		}

		public void HideSoftKeyboard()
		{
			if (CurrentFocus == null)
				return;

			InputMethodManager inputMethodManager = (InputMethodManager)GetSystemService(InputMethodService);
			inputMethodManager.HideSoftInputFromWindow(CurrentFocus.WindowToken, 0);

			CurrentFocus.ClearFocus();
		}
	}
}
