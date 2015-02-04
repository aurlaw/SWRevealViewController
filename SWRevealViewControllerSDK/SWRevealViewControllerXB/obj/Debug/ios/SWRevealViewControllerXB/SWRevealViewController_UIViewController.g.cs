//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using MapKit;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using NewsstandKit;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;

namespace SWRevealViewControllerXB {
	public unsafe static partial class SWRevealViewController_UIViewController  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::UIKit.UIViewController");
		
		[Export ("revealViewController")]
		[CompilerGenerated]
		public static SWRevealViewController RevealViewController (this global::UIKit.UIViewController This)
		{
			return  Runtime.GetNSObject<SWRevealViewController> (ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("revealViewController")));
		}
		
	} /* class SWRevealViewController_UIViewController */
}
