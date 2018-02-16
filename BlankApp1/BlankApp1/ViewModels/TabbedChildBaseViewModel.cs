using System;
using System.Collections.Generic;
using System.Text;
using Prism;
using Prism.Navigation;

namespace BlankApp1.ViewModels
{
	public class TabbedChildBaseViewModel : ViewModelBase, IActiveAware
	{
		public TabbedChildBaseViewModel(INavigationService navigationService) :base(navigationService)
		{}

		private bool _isActive;

		public event EventHandler IsActiveChanged;

		public bool IsActive
		{
			get { return _isActive; }
			set { SetProperty(ref _isActive, value, () => IsActiveChanged?.Invoke(this, EventArgs.Empty)); }
		}

	}
}
