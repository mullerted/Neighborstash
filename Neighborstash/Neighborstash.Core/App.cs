using MvvmCross.Core.ViewModels;
using MvvmCross.Localization;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using Neighborstash.Core.ViewModel;

namespace Neighborstash.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            // Register Repositories
            CreatableTypes()
                .EndingWith("Repository")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            //Mvx.RegisterSingleton<IMvxTextProvider>(new ResxTextProvider());

            //RegisterAppStart<MainViewModel>();
            RegisterAppStart(new AppStart());

            
        }
    }
}
