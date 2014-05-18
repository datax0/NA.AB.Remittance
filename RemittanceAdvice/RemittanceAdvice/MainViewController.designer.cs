// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;
using MonoTouch.UIKit;

namespace RemittanceAdvice
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		UITextField PayTextField { get; set; }

		[Action ("showInfo:")]
		partial void showInfo (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (PayTextField != null) {
				PayTextField.Dispose ();
				PayTextField = null;
			}
		}
	}
}
