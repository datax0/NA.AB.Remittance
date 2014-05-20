// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace RemittanceAdvice
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		RemittanceAdvice.TextButton LoLoginScene { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UITextField PayTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		RemittanceAdvice.TextButton ToRegisterScreen { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (LoLoginScene != null) {
				LoLoginScene.Dispose ();
				LoLoginScene = null;
			}
			if (PayTextField != null) {
				PayTextField.Dispose ();
				PayTextField = null;
			}
			if (ToRegisterScreen != null) {
				ToRegisterScreen.Dispose ();
				ToRegisterScreen = null;
			}
		}
	}
}
