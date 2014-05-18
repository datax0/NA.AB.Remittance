using MonoTouch.UIKit;
using System;
using MonoTouch.Foundation;
using System.Drawing;

namespace RemittanceAdvice
{
	public partial class MainViewController : UIViewController
	{
		const float JVFieldHeight = 44.0f;
		const float JVFieldHMargin = 10.0f;
		const float JVFieldFontSize = 16.0f;
		const float JVFieldFloatingLabelFontSize = 11.0f;

		public MainViewController (IntPtr handle) : base (handle)
		{
			// Custom initialization
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
	
			base.ViewDidLoad ();
			Title = "Aktif Transfer";
			View.BackgroundColor = UIColor.White;
			/*
			float topOffset = UIApplication.SharedApplication.StatusBarFrame.Size.Height; //+ NavigationController.NavigationBar.Frame.Size.Height;
			UIColor floatingLabelColor = UIColor.Gray, floatingLabelActiveColor = UIColor.Blue;

			PayTextField = new JVFloatLabeledTextField(new RectangleF(JVFieldHMargin, topOffset, 
				View.Frame.Size.Width - 2 * JVFieldHMargin, 
				JVFieldHeight))
			{
				Placeholder = "YEARLY CONTRACT REVENUE: *",
				Font = UIFont.SystemFontOfSize(JVFieldFontSize),
				ClearButtonMode = UITextFieldViewMode.WhileEditing,
				FloatingLabelFont = UIFont.BoldSystemFontOfSize(JVFieldFloatingLabelFontSize),
				FloatingLabelTextColor = floatingLabelColor,
				FloatingLabelActiveTextColor = floatingLabelActiveColor,
				KeyboardType = UIKeyboardType.DecimalPad
			};
			View.AddSubview(PayTextField);
			*/
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion

		partial void showInfo (NSObject sender)
		{
		}
	}
}

