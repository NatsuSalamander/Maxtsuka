using Android.App;
using Android.Widget;
using Android.OS;

namespace Maxtsuka.Droid
{
	[Activity(Label = "Maxtsuka", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		private EditText _txtAccount;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			//ios XCode Custom Class
			//View - Controller Binding
			SetContentView(Resource.Layout.loginflow_loginview);

			//View's Element - Controller's UI Control Binding
			_txtAccount = FindViewById<EditText>(Resource.Id.loginflow_loginview_txtaccount);

			var txtPassword = FindViewById<EditText>(Resource.Id.loginflow_loginview_txtpassword);

			var btnlogin = FindViewById<Button>(Resource.Id.loginflow_loginview_btnlogin);
			btnlogin.Click += (sender, e) => { };
		}
	}
}

