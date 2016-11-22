// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Maxtsuka.iOS
{
	[Register ("MyWebViewController")]
	partial class MyWebViewController
	{
		[Outlet]
		UIKit.UIButton btngo { get; set; }

		[Outlet]
		UIKit.UITextField txtinput { get; set; }

		[Outlet]
		UIKit.UIWebView webview { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btngo != null) {
				btngo.Dispose ();
				btngo = null;
			}

			if (txtinput != null) {
				txtinput.Dispose ();
				txtinput = null;
			}

			if (webview != null) {
				webview.Dispose ();
				webview = null;
			}
		}
	}
}
