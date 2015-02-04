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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DSegueCallback1 (IntPtr block, IntPtr segue, IntPtr svc, IntPtr dvc);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDSegueCallback1 {
			static internal readonly DSegueCallback1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DSegueCallback1))]
			static unsafe void Invoke (IntPtr block, IntPtr segue, IntPtr svc, IntPtr dvc) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::SWRevealViewControllerXB.SegueCallback1) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<SWRevealViewControllerXB.SWRevealViewControllerSegueSetController> (segue),  Runtime.GetNSObject<UIKit.UIViewController> (svc),  Runtime.GetNSObject<UIKit.UIViewController> (dvc));
			}
		} /* class SDSegueCallback1 */
		
		internal class NIDSegueCallback1 {
			IntPtr blockPtr;
			DSegueCallback1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDSegueCallback1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DSegueCallback1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDSegueCallback1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::SWRevealViewControllerXB.SegueCallback1 Create (IntPtr block)
			{
				return new NIDSegueCallback1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::SWRevealViewControllerXB.SWRevealViewControllerSegueSetController segue, global::UIKit.UIViewController svc, global::UIKit.UIViewController dvc)
			{
				invoker (blockPtr, segue == null ? IntPtr.Zero : segue.Handle, svc == null ? IntPtr.Zero : svc.Handle, dvc == null ? IntPtr.Zero : dvc.Handle);
			}
		} /* class NIDSegueCallback1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DSegueCallback2 (IntPtr block, IntPtr segue, IntPtr svc, IntPtr dvc);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDSegueCallback2 {
			static internal readonly DSegueCallback2 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DSegueCallback2))]
			static unsafe void Invoke (IntPtr block, IntPtr segue, IntPtr svc, IntPtr dvc) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::SWRevealViewControllerXB.SegueCallback2) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<SWRevealViewControllerXB.SWRevealViewControllerSeguePushController> (segue),  Runtime.GetNSObject<UIKit.UIViewController> (svc),  Runtime.GetNSObject<UIKit.UIViewController> (dvc));
			}
		} /* class SDSegueCallback2 */
		
		internal class NIDSegueCallback2 {
			IntPtr blockPtr;
			DSegueCallback2 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDSegueCallback2 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DSegueCallback2> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDSegueCallback2 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::SWRevealViewControllerXB.SegueCallback2 Create (IntPtr block)
			{
				return new NIDSegueCallback2 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::SWRevealViewControllerXB.SWRevealViewControllerSeguePushController segue, global::UIKit.UIViewController svc, global::UIKit.UIViewController dvc)
			{
				invoker (blockPtr, segue == null ? IntPtr.Zero : segue.Handle, svc == null ? IntPtr.Zero : svc.Handle, dvc == null ? IntPtr.Zero : dvc.Handle);
			}
		} /* class NIDSegueCallback2 */
	}
}
