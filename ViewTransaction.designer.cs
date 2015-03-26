// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CoreAnimationXamarin.ios
{
	[Register ("ViewTransaction")]
	partial class ViewTransaction
	{
		[Outlet]
		UIKit.UIImageView image1 { get; set; }

		[Outlet]
		UIKit.UIImageView image2 { get; set; }

		[Outlet]
		UIKit.UIView view1 { get; set; }

		[Outlet]
		UIKit.UIView view2 { get; set; }

		[Action ("btn_swipe:")]
		partial void btn_swipe (Foundation.NSObject sender);

		void ReleaseDesignerOutlets ()
		{
			if (image1 != null) {
				image1.Dispose ();
				image1 = null;
			}

			if (image2 != null) {
				image2.Dispose ();
				image2 = null;
			}

			if (view1 != null) {
				view1.Dispose ();
				view1 = null;
			}

			if (view2 != null) {
				view2.Dispose ();
				view2 = null;
			}
		}
	}
}
