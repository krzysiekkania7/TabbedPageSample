using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace BlankApp1.ViewModels
{
	public class Tab2ContentPageViewModel : TabbedChildBaseViewModel
	{
        public Tab2ContentPageViewModel(INavigationService navigationService) : base(navigationService)
		{
			Title = "Tab2ContentPage";
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
			base.OnNavigatedTo(parameters);
		}
	}
}
