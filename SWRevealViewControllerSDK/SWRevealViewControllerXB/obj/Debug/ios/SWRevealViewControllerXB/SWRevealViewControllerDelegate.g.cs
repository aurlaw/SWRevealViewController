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
	[Register("SWRevealViewControllerDelegate", true)]
	[Model]
	public unsafe partial class SWRevealViewControllerDelegate : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SWRevealViewControllerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SWRevealViewControllerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SWRevealViewControllerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("revealController:animateToPosition:")]
		[CompilerGenerated]
		public virtual void AnimateToPosition (SWRevealViewController revealController, FrontViewPosition position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:animationControllerForOperation:fromViewController:toViewController:")]
		[CompilerGenerated]
		public virtual global::UIKit.UIViewControllerAnimatedTransitioning AnimationControllerForOperation (SWRevealViewController revealController, SWRevealControllerOperation operation, global::UIKit.UIViewController fromVC, global::UIKit.UIViewController toVC)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:didAddViewController:forOperation:animated:")]
		[CompilerGenerated]
		public virtual void DidAddViewController (SWRevealViewController revealController, global::UIKit.UIViewController viewController, SWRevealControllerOperation operation, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:didMoveToPosition:")]
		[CompilerGenerated]
		public virtual void DidMoveToPosition (SWRevealViewController revealController, FrontViewPosition position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureBeganFromLocation:progress:overProgress:")]
		[CompilerGenerated]
		public virtual void PanGestureBeganFromLocation (SWRevealViewController revealController, global::System.nfloat location, global::System.nfloat progress, global::System.nfloat overProgress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureBeganFromLocation:progress:")]
		[CompilerGenerated]
		public virtual void PanGestureBeganFromLocation (SWRevealViewController revealController, global::System.nfloat location, global::System.nfloat progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureEndedToLocation:progress:overProgress:")]
		[CompilerGenerated]
		public virtual void PanGestureEndedToLocation (SWRevealViewController revealController, global::System.nfloat location, global::System.nfloat progress, global::System.nfloat overProgress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureEndedToLocation:progress:")]
		[CompilerGenerated]
		public virtual void PanGestureEndedToLocation (SWRevealViewController revealController, global::System.nfloat location, global::System.nfloat progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureMovedToLocation:progress:overProgress:")]
		[CompilerGenerated]
		public virtual void PanGestureMovedToLocation (SWRevealViewController revealController, global::System.nfloat location, global::System.nfloat progress, global::System.nfloat overProgress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureMovedToLocation:progress:")]
		[CompilerGenerated]
		public virtual void PanGestureMovedToLocation (SWRevealViewController revealController, global::System.nfloat location, global::System.nfloat progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:panGestureRecognizerShouldRecognizeSimultaneouslyWithGestureRecognizer:")]
		[CompilerGenerated]
		public virtual bool PanGestureRecognizerShouldRecognizeSimultaneouslyWithGestureRecognizer (SWRevealViewController revealController, global::UIKit.UIGestureRecognizer otherGestureRecognizer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealControllerPanGestureBegan:")]
		[CompilerGenerated]
		public virtual void RevealControllerPanGestureBegan (SWRevealViewController revealController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealControllerPanGestureEnded:")]
		[CompilerGenerated]
		public virtual void RevealControllerPanGestureEnded (SWRevealViewController revealController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealControllerPanGestureShouldBegin:")]
		[CompilerGenerated]
		public virtual bool RevealControllerPanGestureShouldBegin (SWRevealViewController revealController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealControllerTapGestureShouldBegin:")]
		[CompilerGenerated]
		public virtual bool RevealControllerTapGestureShouldBegin (SWRevealViewController revealController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:tapGestureRecognizerShouldRecognizeSimultaneouslyWithGestureRecognizer:")]
		[CompilerGenerated]
		public virtual bool TapGestureRecognizerShouldRecognizeSimultaneouslyWithGestureRecognizer (SWRevealViewController revealController, global::UIKit.UIGestureRecognizer otherGestureRecognizer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:willAddViewController:forOperation:animated:")]
		[CompilerGenerated]
		public virtual void WillAddViewController (SWRevealViewController revealController, global::UIKit.UIViewController viewController, SWRevealControllerOperation operation, bool animated)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("revealController:willMoveToPosition:")]
		[CompilerGenerated]
		public virtual void WillMoveToPosition (SWRevealViewController revealController, FrontViewPosition position)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class SWRevealViewControllerDelegate */
}
