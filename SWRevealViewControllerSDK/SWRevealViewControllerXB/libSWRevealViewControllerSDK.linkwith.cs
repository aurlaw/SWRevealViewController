using System;
using ObjCRuntime;

[assembly: LinkWith ("libSWRevealViewControllerSDK.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64, SmartLink = true, ForceLoad = true)]
