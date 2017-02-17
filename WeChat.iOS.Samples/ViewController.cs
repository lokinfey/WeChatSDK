using System;

using UIKit;

namespace WeChat.iOS.Samples
{
	public partial class ViewController : UIViewController
	{

		WeChatAPI we;

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			we = new WeChatAPI();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void UIButton3_TouchUpInside(UIButton sender)
		{
			we.SendText("Hello Xamarin@WeChat");
		}
	}
}
