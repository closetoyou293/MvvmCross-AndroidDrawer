using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using MvvmCrossAndroidDrawer.Core.ViewModels;

namespace MvvmCrossAndroidDrawer.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<MainViewModel>();
        }
    }
}
