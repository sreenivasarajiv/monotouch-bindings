using System;
using ObjCRuntime;

[assembly: LinkWith ("libTestFairy.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator | LinkTarget.Simulator64, Frameworks = "OpenGLES CoreMedia CoreMotion SystemConfiguration AVFoundation CoreGraphics", IsCxx = true, ForceLoad = true)]
