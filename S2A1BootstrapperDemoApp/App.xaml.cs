using System;
using System.Threading.Tasks;
using Template10.Common;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Data;

namespace S2A1BootstrapperDemoApp
{
    /// Documentation on APIs used in this page:
    /// https://github.com/Windows-XAML/Template10/wiki

    [Bindable]
    sealed partial class App : Template10.Common.BootStrapper
    {
        public App()
        {
            InitializeComponent();
            SplashFactory = e => { return null; }; 
        }

        public override Task OnInitializeAsync(IActivatedEventArgs args)
        {
            //return base.OnInitializeAsync(args);
            return Task.CompletedTask;
        }

        //public override Task OnPrelaunchAsync(IActivatedEventArgs args, out bool runOnStartAsync)
        //{
        //return base.OnPrelaunchAsync(args, out runOnStartAsync);
        //    runOnStartAsync = false;
        //    return Task.CompletedTask;
        //}

        public override Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            //throw new NotImplementedException();
            //if (startKind == StartKind.Launch) { }
            //var e = args as ProtocolActivatedEventArgs;
            //args.Kind = ActivationKind.LockScreenCall;
            NavigationService.Navigate(typeof(Views.MainPage));
            return Task.CompletedTask;
        }
    }
}

