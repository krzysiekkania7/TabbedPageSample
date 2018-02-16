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
			GoCommand = new DelegateCommand(GoCommandExecute);
		}

		public DelegateCommand GoCommand { get; }

		private async void GoCommandExecute()
		{
			try
			{
				await NavigationService.NavigateAsync("Content");
			}
			catch (Exception e)
			{
				throw e;
			}

		}
	}
}
