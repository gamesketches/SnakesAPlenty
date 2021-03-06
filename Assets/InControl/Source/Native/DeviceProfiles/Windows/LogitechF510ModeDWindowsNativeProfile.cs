namespace InControl.NativeProfile
{
	using System;


	// @cond nodoc
	[AutoDiscover]
	public class LogitechF510ModeDWindowsNativeProfile : NativeInputDeviceProfile
	{
		public LogitechF510ModeDWindowsNativeProfile()
		{
			Name = "Logitech F510 Mode D Controller";
			Meta = "Logitech F510 Mode D Controller on Windows";
			// Link = "http://www.amazon.com/Logitech-940-000106-Rumble-Gamepad-F510/dp/B003VAM392";

			IncludePlatforms = new[] {
				"Windows"
			};

			Matchers = new[] {
				new NativeInputDeviceMatcher {
					VendorID = 0x46d,
					ProductID = 0xc218,
					// VersionNumber = 0x0,
				},
			};

			ButtonMappings = new[] {
				new InputControlMapping {
					Handle = "X",
					Target = InputControlType.Action3,
					Source = Button( 0 ),
				},
				new InputControlMapping {
					Handle = "A",
					Target = InputControlType.Action1,
					Source = Button( 1 ),
				},
				new InputControlMapping {
					Handle = "B",
					Target = InputControlType.Action2,
					Source = Button( 2 ),
				},
				new InputControlMapping {
					Handle = "Y",
					Target = InputControlType.Action4,
					Source = Button( 3 ),
				},
				new InputControlMapping {
					Handle = "Left Bumper",
					Target = InputControlType.LeftBumper,
					Source = Button( 4 ),
				},
				new InputControlMapping {
					Handle = "Right Bumper",
					Target = InputControlType.RightBumper,
					Source = Button( 5 ),
				},
				new InputControlMapping {
					Handle = "Left Trigger",
					Target = InputControlType.LeftTrigger,
					Source = Button( 6 ),
				},
				new InputControlMapping {
					Handle = "Right Trigger",
					Target = InputControlType.RightTrigger,
					Source = Button( 7 ),
				},
				new InputControlMapping {
					Handle = "Back",
					Target = InputControlType.Back,
					Source = Button( 8 ),
				},
				new InputControlMapping {
					Handle = "Start",
					Target = InputControlType.Start,
					Source = Button( 9 ),
				},
				new InputControlMapping {
					Handle = "Left Stick Button",
					Target = InputControlType.LeftStickButton,
					Source = Button( 10 ),
				},
				new InputControlMapping {
					Handle = "Right Stick Button",
					Target = InputControlType.RightStickButton,
					Source = Button( 11 ),
				},
			};

			AnalogMappings = new[] {
				new InputControlMapping {
					Handle = "Right Stick Up",
					Target = InputControlType.RightStickUp,
					Source = Analog( 0 ),
					SourceRange = InputRange.ZeroToMinusOne,
					TargetRange = InputRange.ZeroToOne,
				},
				new InputControlMapping {
					Handle = "Right Stick Down",
					Target = InputControlType.RightStickDown,
					Source = Analog( 0 ),
					SourceRange = InputRange.ZeroToOne,
					TargetRange = InputRange.ZeroToOne,
				},
				new InputControlMapping {
					Handle = "Right Stick Left",
					Target = InputControlType.RightStickLeft,
					Source = Analog( 1 ),
					SourceRange = InputRange.ZeroToMinusOne,
					TargetRange = InputRange.ZeroToOne,
				},
				new InputControlMapping {
					Handle = "Right Stick Right",
					Target = InputControlType.RightStickRight,
					Source = Analog( 1 ),
					SourceRange = InputRange.ZeroToOne,
					TargetRange = InputRange.ZeroToOne,
				},
				new InputControlMapping {
					Handle = "Left Stick Up",
					Target = InputControlType.LeftStickUp,
					Source = Analog( 2 ),
					SourceRange = InputRange.ZeroToMinusOne,
					TargetRange = InputRange.ZeroToOne,
				},
				new InputControlMapping {
					Handle = "Left Stick Down",
					Target = InputControlType.LeftStickDown,
					Source = Analog( 2 ),
					SourceRange = InputRange.ZeroToOne,
					TargetRange = InputRange.ZeroToOne,
				},
				new InputControlMapping {
					Handle = "Left Stick Left",
					Target = InputControlType.LeftStickLeft,
					Source = Analog( 3 ),
					SourceRange = InputRange.ZeroToMinusOne,
					TargetRange = InputRange.ZeroToOne,
				},
				new InputControlMapping {
					Handle = "Left Stick Right",
					Target = InputControlType.LeftStickRight,
					Source = Analog( 3 ),
					SourceRange = InputRange.ZeroToOne,
					TargetRange = InputRange.ZeroToOne,
				},
				new InputControlMapping {
					Handle = "DPad Left",
					Target = InputControlType.DPadLeft,
					Source = Analog( 4 ),
					SourceRange = InputRange.ZeroToMinusOne,
					TargetRange = InputRange.ZeroToOne,
				},
				new InputControlMapping {
					Handle = "DPad Right",
					Target = InputControlType.DPadRight,
					Source = Analog( 4 ),
					SourceRange = InputRange.ZeroToOne,
					TargetRange = InputRange.ZeroToOne,
				},
				new InputControlMapping {
					Handle = "DPad Up",
					Target = InputControlType.DPadUp,
					Source = Analog( 5 ),
					SourceRange = InputRange.ZeroToOne,
					TargetRange = InputRange.ZeroToOne,
				},
				new InputControlMapping {
					Handle = "DPad Down",
					Target = InputControlType.DPadDown,
					Source = Analog( 5 ),
					SourceRange = InputRange.ZeroToMinusOne,
					TargetRange = InputRange.ZeroToOne,
				},
			};
		}
	}
	// @endcond
}

