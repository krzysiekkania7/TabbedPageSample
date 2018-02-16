using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace BlankApp1.ViewModels
{
	public class Tab1ContentPage1ViewModel : TabbedChildBaseViewModel
	{
        public Tab1ContentPage1ViewModel(INavigationService navigationService) : base(navigationService)
        {
	        Title = "Tab1ContentPage";
			GoCommand = new DelegateCommand(GoCommandExecute);
        }

		public DelegateCommand GoCommand { get; }

		private async void GoCommandExecute()
		{
			try
			{
				await NavigationService.NavigateAsync($"BlnakApp1:///Main?{KnownNavigationParameters.SelectedTab}=Tab2/Content");
			}
			catch (Exception e)
			{
				throw e;
			}

		}
	}
}
