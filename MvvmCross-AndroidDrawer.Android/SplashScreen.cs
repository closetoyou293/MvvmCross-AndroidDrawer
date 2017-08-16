using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace MvvmCrossAndroidDrawer.Android
{
    [Activity(
        Label = "MvvmCross Drawer"
        , MainLauncher = true
        , Theme = "@style/AppTheme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.splash_screen)
        {
        }
    }
}
