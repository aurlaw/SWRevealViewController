using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;
using CoreGraphics;

namespace SWRevealViewControllerXB {

	// @interface SWRevealViewController : UIViewController
	[BaseType (typeof (UIViewController))]
	public partial interface SWRevealViewController {

		// -(id)initWithRearViewController:(UIViewController *)rearViewController frontViewController:(UIViewController *)frontViewController;
		[Export ("initWithRearViewController:frontViewController:")]
		IntPtr Constructor (UIViewController rearViewController, UIViewController frontViewController);

		// @property (nonatomic) UIViewController * rearViewController;
		[Export ("rearViewController")]
		UIViewController RearViewController { get; set; }

		// @property (nonatomic) UIViewController * rightViewController;
		[Export ("rightViewController")]
		UIViewController RightViewController { get; set; }

		// @property (nonatomic) UIViewController * frontViewController;
		[Export ("frontViewController")]
		UIViewController FrontViewController { get; set; }

		// @property (nonatomic) FrontViewPosition frontViewPosition;
		[Export ("frontViewPosition")]
		FrontViewPosition FrontViewPosition { get; set; }

		// @property (nonatomic) CGFloat rearViewRevealWidth;
		[Export ("rearViewRevealWidth")]
		nfloat RearViewRevealWidth { get; set; }

		// @property (nonatomic) CGFloat rightViewRevealWidth;
		[Export ("rightViewRevealWidth")]
		nfloat RightViewRevealWidth { get; set; }

		// @property (nonatomic) CGFloat rearViewRevealOverdraw;
		[Export ("rearViewRevealOverdraw")]
		nfloat RearViewRevealOverdraw { get; set; }

		// @property (nonatomic) CGFloat rightViewRevealOverdraw;
		[Export ("rightViewRevealOverdraw")]
		nfloat RightViewRevealOverdraw { get; set; }

		// @property (nonatomic) CGFloat rearViewRevealDisplacement;
		[Export ("rearViewRevealDisplacement")]
		nfloat RearViewRevealDisplacement { get; set; }

		// @property (nonatomic) CGFloat rightViewRevealDisplacement;
		[Export ("rightViewRevealDisplacement")]
		nfloat RightViewRevealDisplacement { get; set; }

		// @property (nonatomic) CGFloat draggableBorderWidth;
		[Export ("draggableBorderWidth")]
		nfloat DraggableBorderWidth { get; set; }

		// @property (nonatomic) BOOL bounceBackOnOverdraw;
		[Export ("bounceBackOnOverdraw")]
		bool BounceBackOnOverdraw { get; set; }

		// @property (nonatomic) BOOL bounceBackOnLeftOverdraw;
		[Export ("bounceBackOnLeftOverdraw")]
		bool BounceBackOnLeftOverdraw { get; set; }

		// @property (nonatomic) BOOL stableDragOnOverdraw;
		[Export ("stableDragOnOverdraw")]
		bool StableDragOnOverdraw { get; set; }

		// @property (nonatomic) BOOL stableDragOnLeftOverdraw;
		[Export ("stableDragOnLeftOverdraw")]
		bool StableDragOnLeftOverdraw { get; set; }

		// @property (nonatomic) BOOL presentFrontViewHierarchically;
		[Export ("presentFrontViewHierarchically")]
		bool PresentFrontViewHierarchically { get; set; }

		// @property (nonatomic) CGFloat quickFlickVelocity;
		[Export ("quickFlickVelocity")]
		nfloat QuickFlickVelocity { get; set; }

		// @property (nonatomic) NSTimeInterval toggleAnimationDuration;
		[Export ("toggleAnimationDuration")]
		double ToggleAnimationDuration { get; set; }

		// @property (nonatomic) SWRevealToggleAnimationType toggleAnimationType;
		[Export ("toggleAnimationType")]
		SWRevealToggleAnimationType ToggleAnimationType { get; set; }

		// @property (nonatomic) CGFloat springDampingRatio;
		[Export ("springDampingRatio")]
		nfloat SpringDampingRatio { get; set; }

		// @property (nonatomic) NSTimeInterval replaceViewAnimationDuration;
		[Export ("replaceViewAnimationDuration")]
		double ReplaceViewAnimationDuration { get; set; }

		// @property (nonatomic) CGFloat frontViewShadowRadius;
		[Export ("frontViewShadowRadius")]
		nfloat FrontViewShadowRadius { get; set; }

		// @property (nonatomic) CGSize frontViewShadowOffset;
		[Export ("frontViewShadowOffset")]
		CGSize FrontViewShadowOffset { get; set; }

		// @property (nonatomic) CGFloat frontViewShadowOpacity;
		[Export ("frontViewShadowOpacity")]
		nfloat FrontViewShadowOpacity { get; set; }

		// @property (nonatomic) UIColor * frontViewShadowColor;
		[Export ("frontViewShadowColor")]
		UIColor FrontViewShadowColor { get; set; }

		// @property (nonatomic) BOOL clipsViewsToBounds;
		[Export ("clipsViewsToBounds")]
		bool ClipsViewsToBounds { get; set; }

		// @property (nonatomic) BOOL extendsPointInsideHit;
		[Export ("extendsPointInsideHit")]
		bool ExtendsPointInsideHit { get; set; }

		// @property (nonatomic, weak) id<SWRevealViewControllerDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) id<SWRevealViewControllerDelegate> delegate;
		[Wrap ("WeakDelegate")]
		SWRevealViewControllerDelegate Delegate { get; set; }

		// -(void)setRearViewController:(UIViewController *)rearViewController animated:(BOOL)animated;
		[Export ("setRearViewController:animated:")]
		void SetRearViewController (UIViewController rearViewController, bool animated);

		// -(void)setRightViewController:(UIViewController *)rightViewController animated:(BOOL)animated;
		[Export ("setRightViewController:animated:")]
		void SetRightViewController (UIViewController rightViewController, bool animated);

		// -(void)setFrontViewController:(UIViewController *)frontViewController animated:(BOOL)animated;
		[Export ("setFrontViewController:animated:")]
		void SetFrontViewController (UIViewController frontViewController, bool animated);

		// -(void)pushFrontViewController:(UIViewController *)frontViewController animated:(BOOL)animated;
		[Export ("pushFrontViewController:animated:")]
		void PushFrontViewController (UIViewController frontViewController, bool animated);

		// -(void)setFrontViewPosition:(FrontViewPosition)frontViewPosition animated:(BOOL)animated;
		[Export ("setFrontViewPosition:animated:")]
		void SetFrontViewPosition (FrontViewPosition frontViewPosition, bool animated);

		// -(void)revealToggle:(id)sender;
		[Export ("revealToggle:")]
		void RevealToggle (NSObject sender);

		// -(void)rightRevealToggle:(id)sender;
		[Export ("rightRevealToggle:")]
		void RightRevealToggle (NSObject sender);

		// -(void)revealToggleAnimated:(BOOL)animated;
		[Export ("revealToggleAnimated:")]
		void RevealToggleAnimated (bool animated);

		// -(void)rightRevealToggleAnimated:(BOOL)animated;
		[Export ("rightRevealToggleAnimated:")]
		void RightRevealToggleAnimated (bool animated);

		// -(UIPanGestureRecognizer *)panGestureRecognizer;
		[Export ("panGestureRecognizer")]
		UIPanGestureRecognizer PanGestureRecognizer ();

		// -(UITapGestureRecognizer *)tapGestureRecognizer;
		[Export ("tapGestureRecognizer")]
		UITapGestureRecognizer TapGestureRecognizer ();
	}

	// @protocol SWRevealViewControllerDelegate <NSObject>
	[BaseType (typeof (NSObject))]
	[Model]
	public partial interface SWRevealViewControllerDelegate {

		// @optional -(void)revealController:(SWRevealViewController *)revealController willMoveToPosition:(FrontViewPosition)position;
		[Export ("revealController:willMoveToPosition:")]
		void WillMoveToPosition (SWRevealViewController revealController, FrontViewPosition position);

		// @optional -(void)revealController:(SWRevealViewController *)revealController didMoveToPosition:(FrontViewPosition)position;
		[Export ("revealController:didMoveToPosition:")]
		void DidMoveToPosition (SWRevealViewController revealController, FrontViewPosition position);

		// @optional -(void)revealController:(SWRevealViewController *)revealController animateToPosition:(FrontViewPosition)position;
		[Export ("revealController:animateToPosition:")]
		void AnimateToPosition (SWRevealViewController revealController, FrontViewPosition position);

		// @optional -(BOOL)revealControllerPanGestureShouldBegin:(SWRevealViewController *)revealController;
		[Export ("revealControllerPanGestureShouldBegin:")]
		bool RevealControllerPanGestureShouldBegin (SWRevealViewController revealController);

		// @optional -(BOOL)revealControllerTapGestureShouldBegin:(SWRevealViewController *)revealController;
		[Export ("revealControllerTapGestureShouldBegin:")]
		bool RevealControllerTapGestureShouldBegin (SWRevealViewController revealController);

		// @optional -(BOOL)revealController:(SWRevealViewController *)revealController panGestureRecognizerShouldRecognizeSimultaneouslyWithGestureRecognizer:(UIGestureRecognizer *)otherGestureRecognizer;
		[Export ("revealController:panGestureRecognizerShouldRecognizeSimultaneouslyWithGestureRecognizer:")]
		bool PanGestureRecognizerShouldRecognizeSimultaneouslyWithGestureRecognizer (SWRevealViewController revealController, UIGestureRecognizer otherGestureRecognizer);

		// @optional -(BOOL)revealController:(SWRevealViewController *)revealController tapGestureRecognizerShouldRecognizeSimultaneouslyWithGestureRecognizer:(UIGestureRecognizer *)otherGestureRecognizer;
		[Export ("revealController:tapGestureRecognizerShouldRecognizeSimultaneouslyWithGestureRecognizer:")]
		bool TapGestureRecognizerShouldRecognizeSimultaneouslyWithGestureRecognizer (SWRevealViewController revealController, UIGestureRecognizer otherGestureRecognizer);

		// @optional -(void)revealControllerPanGestureBegan:(SWRevealViewController *)revealController;
		[Export ("revealControllerPanGestureBegan:")]
		void RevealControllerPanGestureBegan (SWRevealViewController revealController);

		// @optional -(void)revealControllerPanGestureEnded:(SWRevealViewController *)revealController;
		[Export ("revealControllerPanGestureEnded:")]
		void RevealControllerPanGestureEnded (SWRevealViewController revealController);

		// @optional -(void)revealController:(SWRevealViewController *)revealController panGestureBeganFromLocation:(CGFloat)location progress:(CGFloat)progress overProgress:(CGFloat)overProgress;
		[Export ("revealController:panGestureBeganFromLocation:progress:overProgress:")]
		void PanGestureBeganFromLocation (SWRevealViewController revealController, nfloat location, nfloat progress, nfloat overProgress);

		// @optional -(void)revealController:(SWRevealViewController *)revealController panGestureMovedToLocation:(CGFloat)location progress:(CGFloat)progress overProgress:(CGFloat)overProgress;
		[Export ("revealController:panGestureMovedToLocation:progress:overProgress:")]
		void PanGestureMovedToLocation (SWRevealViewController revealController, nfloat location, nfloat progress, nfloat overProgress);

		// @optional -(void)revealController:(SWRevealViewController *)revealController panGestureEndedToLocation:(CGFloat)location progress:(CGFloat)progress overProgress:(CGFloat)overProgress;
		[Export ("revealController:panGestureEndedToLocation:progress:overProgress:")]
		void PanGestureEndedToLocation (SWRevealViewController revealController, nfloat location, nfloat progress, nfloat overProgress);

		// @optional -(void)revealController:(SWRevealViewController *)revealController willAddViewController:(UIViewController *)viewController forOperation:(SWRevealControllerOperation)operation animated:(BOOL)animated;
		[Export ("revealController:willAddViewController:forOperation:animated:")]
		void WillAddViewController (SWRevealViewController revealController, UIViewController viewController,  SWRevealControllerOperation operation, bool animated);

		// @optional -(void)revealController:(SWRevealViewController *)revealController didAddViewController:(UIViewController *)viewController forOperation:(SWRevealControllerOperation)operation animated:(BOOL)animated;
		[Export ("revealController:didAddViewController:forOperation:animated:")]
		void DidAddViewController (SWRevealViewController revealController, UIViewController viewController, SWRevealControllerOperation operation, bool animated);

		// @optional -(id<UIViewControllerAnimatedTransitioning>)revealController:(SWRevealViewController *)revealController animationControllerForOperation:(SWRevealControllerOperation)operation fromViewController:(UIViewController *)fromVC toViewController:(UIViewController *)toVC;
		[Export ("revealController:animationControllerForOperation:fromViewController:toViewController:")]
		UIViewControllerAnimatedTransitioning AnimationControllerForOperation (SWRevealViewController revealController,  SWRevealControllerOperation operation, UIViewController fromVC, UIViewController toVC);

		// @optional -(void)revealController:(SWRevealViewController *)revealController panGestureBeganFromLocation:(CGFloat)location progress:(CGFloat)progress;
		[Export ("revealController:panGestureBeganFromLocation:progress:")]
		void PanGestureBeganFromLocation (SWRevealViewController revealController, nfloat location, nfloat progress);

		// @optional -(void)revealController:(SWRevealViewController *)revealController panGestureMovedToLocation:(CGFloat)location progress:(CGFloat)progress;
		[Export ("revealController:panGestureMovedToLocation:progress:")]
		void PanGestureMovedToLocation (SWRevealViewController revealController, nfloat location, nfloat progress);

		// @optional -(void)revealController:(SWRevealViewController *)revealController panGestureEndedToLocation:(CGFloat)location progress:(CGFloat)progress;
		[Export ("revealController:panGestureEndedToLocation:progress:")]
		void PanGestureEndedToLocation (SWRevealViewController revealController, nfloat location, nfloat progress);
	}

	// @interface SWRevealViewController (UIViewController)
	[Category]
	[BaseType (typeof (UIViewController))]
	public partial interface SWRevealViewController_UIViewController {

		// -(SWRevealViewController *)revealViewController;
		[Export ("revealViewController")]
		SWRevealViewController RevealViewController ();
	}
	public delegate void SegueCallback1(SWRevealViewControllerSegueSetController segue, UIViewController svc, UIViewController dvc);
	public delegate void SegueCallback2(SWRevealViewControllerSeguePushController segue, UIViewController svc, UIViewController dvc);

	// @interface SWRevealViewControllerSegueSetController : UIStoryboardSegue
	[BaseType (typeof (UIStoryboardSegue))]
	public partial interface SWRevealViewControllerSegueSetController {
		[Export ("performBlock", ArgumentSemantic.Retain)]
		SegueCallback1 PerformDelegate { get; set; }
	}

	// @interface SWRevealViewControllerSeguePushController : UIStoryboardSegue
	[BaseType (typeof (UIStoryboardSegue))]
	public partial interface SWRevealViewControllerSeguePushController {
		[Export ("performBlock", ArgumentSemantic.Retain)]
		SegueCallback2 PerformDelegate { get; set; }
	}
}

