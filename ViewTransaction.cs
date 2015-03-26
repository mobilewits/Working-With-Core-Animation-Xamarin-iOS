
using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace CoreAnimationXamarin.ios
{
	public partial class ViewTransaction : UIViewController
	{
		public ViewTransaction () : base ("ViewTransaction", null)
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
			image1.Image = UIImage.FromFile ("Images/dog.png");
			image2.Image = UIImage.FromFile ("Images/Myimage.png");
			// Perform any additional setup after loading the view, typically from a nib.
		}
		partial void btn_swipe (NSObject sender)
		{
			UIView.Transition (
				fromView: view1,
				toView: view2,
				duration: 1,
				options: UIViewAnimationOptions.TransitionFlipFromTop |
				UIViewAnimationOptions.CurveEaseInOut,
				completion: () => { Console.WriteLine ("transition complete"); });
		}

	}
}

