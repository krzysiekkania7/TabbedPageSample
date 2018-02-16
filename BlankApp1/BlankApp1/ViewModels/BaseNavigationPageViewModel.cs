﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace BlankApp1.ViewModels
{
	public class BaseNavigationPageViewModel : ViewModelBase
	{
        public BaseNavigationPageViewModel(INavigationService navigationService): base(navigationService)
        {

        }

	}
}
