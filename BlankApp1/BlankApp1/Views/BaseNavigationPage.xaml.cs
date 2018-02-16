using Xamarin.Forms;

namespace BlankApp1.Views
{
    public partial class BaseNavigationPage : NavigationPage
    {
	    public bool ClearNavigationStackOnNavigation
	    {
		    get { return true; }
	    }

	    public BaseNavigationPage()
	    {
		    InitializeComponent();
		    //NavigationPage.SetTitleIcon(this, "logo.png");
	    }

	    public BaseNavigationPage(Page root) : base(root)
	    {
		    InitializeComponent();
	    }
	}
}
