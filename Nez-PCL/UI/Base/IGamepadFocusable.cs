﻿using System;


namespace Nez.UI
{
	/// <summary>
	/// interface applied to any Element that wants to take part in gamepad focus. By default, the Button class implements this which cascades
	/// down to Checkbox and TextButton. When using the properties you must set shouldUseExplicitFocusableControl to true. If you want a direction
	/// to not change focus make that direction null. If shouldUseExplicitFocusableControl the Stage will attempt to find the next focusable
	/// in the direction pressed.
	/// </summary>
	public interface IGamepadFocusable
	{
		bool shouldUseExplicitFocusableControl { get; set; }
		IGamepadFocusable gamepadUpElement { get; set; }
		IGamepadFocusable gamepadDownElement { get; set; }
		IGamepadFocusable gamepadLeftElement { get; set; }
		IGamepadFocusable gamepadRightElement { get; set; }

		/// <summary>
		/// called when gamepad focuses on the Element
		/// </summary>
		void onFocused();

		/// <summary>
		/// called when gamepad focus is removed from the Element
		/// </summary>
		void onUnfocused();

		/// <summary>
		/// called when the action button is pressed while the Element is focused
		/// </summary>
		void onActionButtonPressed();

		/// <summary>
		/// called when the action button is released while the Element is focused
		/// </summary>
		void onActionButtonReleased();
	}
}

