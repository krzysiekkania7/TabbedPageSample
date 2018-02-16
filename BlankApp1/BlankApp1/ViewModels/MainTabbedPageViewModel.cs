using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace BlankApp1.ViewModels
{
	public class MainTabbedPageViewModel : ViewModelBase
	{
        public MainTabbedPageViewModel(INavigationService navigationService): base(navigationService)
        {
	        Title = "tab";
        }
	}
}
