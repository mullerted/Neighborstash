using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Neighborstash.Core.ViewModel;

namespace Neighborstash.Core
{
    public class AppStart: MvxNavigatingObject,IMvxAppStart
    {
        //public async void Start(object hint = null)
        public void Start(object hint = null)
        {

            // Applicaton setup code goes here
            // check if user is login successfully 
            // show Main view; otherwise show login page

            //var fbService = Mvx.Resolve<IFBService>() >
            //                await fbService.Auth.Login("username", "password");


            ShowViewModel<MainViewModel>();
        }
    }
}
