using System;
using System.Runtime.InteropServices;

namespace BlinkStickInterop
{
	[Guid("dfcaeff9-c582-43ca-8169-6c559516f6ab")]
	public interface IBlinkStick
	{
		void SetColor (byte r, byte g, byte b);
		void SetColorCSS (String cssColor);
	}

	[Guid("fef50ef1-729a-49bf-8342-bd6ec3a63427")]
	[ClassInterface(ClassInterfaceType.None)]
	public class BlinkStick : IBlinkStick
	{
		private BlinkStickDotNet.BlinkStick led;

		public BlinkStick ()
		{
		}

		public BlinkStick(BlinkStickDotNet.BlinkStick blinkStick)
		{
			led = blinkStick;
		}

		public void SetColor (byte r, byte g, byte b)
		{
			led.SetColor (r, g, b);
		}

		public void SetColorCSS (String cssColor)
		{
			led.SetColor (cssColor);
		}
	}
}

