﻿
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace CoreAnimationXamarin.ios
{
	public partial class SecondViewController : UIViewController
	{
		public SecondViewController () : base ("SecondViewController", null)
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
			FirstViewController first= new FirstViewController{
				ModalTransitionStyle = UIModalTransitionStyle.FlipHorizontal
			};
			PresentViewController(first,true,null);
		}
	}
}

