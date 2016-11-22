using System;

using UIKit;
using static System.Console;

namespace Maxtsuka.iOS
{
	public partial class MyLoginViewController : UIViewController
	{
		public MyLoginViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			btnLogin.TouchUpInside += (object sender, EventArgs e) => 
			{

				WriteLine($"TouchUpInside");

			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

