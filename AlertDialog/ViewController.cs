using Foundation;
using System;
using UIKit;

namespace AlertDialog
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            BtnX.TouchUpInside += AlertMe;
          
        }

        void AlertMe(object sender, EventArgs e)
        {
            var okAlertController = UIAlertController.Create("title","mi mensaje",UIAlertControllerStyle.Alert);
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            okAlertController.AddAction(UIAlertAction.Create("OK2", UIAlertActionStyle.Default, null));
            okAlertController.AddAction(UIAlertAction.Create("OK3", UIAlertActionStyle.Default, null));
            okAlertController.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Default, null));
            PresentViewController(okAlertController, true, null);
        }

       

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

    }
}