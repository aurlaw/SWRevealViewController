namespace SWRevealViewController {

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

	public enum <unamed-C-enum> : uint {
		SWRevealControllerOperationNone,
		SWRevealControllerOperationReplaceRearController,
		SWRevealControllerOperationReplaceFrontController,
		SWRevealControllerOperationReplaceRightController
	}
}
