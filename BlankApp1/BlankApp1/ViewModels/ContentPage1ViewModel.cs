using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace BlankApp1.ViewModels
{
	public class ContentPage1ViewModel : ViewModelBase
	{
        public ContentPage1ViewModel(INavigationService navigationService) : base(navigationService)
		{
			Title = "ContentPage";
		}

		public override void OnNavigatedTo(NavigationParameters parameters)
		{
			base.OnNavigatedTo(parameters);
		}
	}
}
