﻿
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace CoreAnimationXamarin.ios
{
	public partial class FirstViewController : UIViewController
	{
		public FirstViewController () : base ("FirstViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
		partial void btn_trans (NSObject sender)
		{
			SecondViewController second= new SecondViewController{
				ModalTransitionStyle = UIModalTransitionStyle.CrossDissolve
			};
			PresentViewController(second,true,null);
		}
	}
}

