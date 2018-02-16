using System;
using Prism;
using Prism.Ioc;
using BlankApp1.ViewModels;
using BlankApp1.Views;
using Prism.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;

namespace BlankApp1
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

			await NavigationService.NavigateAsync($"Main?{KnownNavigationParameters.SelectedTab}=Tab1");
		}

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
			containerRegistry.RegisterForNavigation<BaseNavigationPage, BaseNavigationPageViewModel>("Base");
			containerRegistry.RegisterForNavigation<MainTabbedPage, MainTabbedPageViewModel>("Main");
			containerRegistry.RegisterForNavigation<Tab1ContentPage1, Tab1ContentPage1ViewModel>("Tab1");
	        containerRegistry.RegisterForNavigation<Tab2ContentPage, Tab2ContentPageViewModel>("Tab2");
			containerRegistry.RegisterForNavigation<ContentPage1, ContentPage1ViewModel>("Content");

		}
    }
}
