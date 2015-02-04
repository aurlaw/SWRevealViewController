using System;
using ObjCRuntime;

namespace SWRevealViewControllerXB {

	[Native]
	public enum FrontViewPosition : long /* nint */ {
		LeftSideMostRemoved,
		LeftSideMost,
		LeftSide,
		Left,
		Right,
		RightMost,
		RightMostRemoved
	}

	[Native]
	public enum SWRevealToggleAnimationType : long /* nint */ {
		Spring,
		EaseOut
	}

	public enum SWRevealControllerOperation : uint {
		SWRevealControllerOperationNone,
		SWRevealControllerOperationReplaceRearController,
		SWRevealControllerOperationReplaceFrontController,
		SWRevealControllerOperationReplaceRightController
	}
}

