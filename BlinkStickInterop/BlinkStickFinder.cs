using System;
using System.Runtime.InteropServices;

namespace BlinkStickInterop
{
	[Guid("779b4d12-8d16-4218-b39c-897a0c05bf6a")]
	public interface IBlinkStickFinder
	{
		IBlinkStick FindFirst ();
		IBlinkStick FindBySerial (String serial);
	}

	[Guid("2646e9b6-4716-4f29-966c-b5c10832b64a")]
	[ClassInterface(ClassInterfaceType.None)]
	public class BlinkStickFinder : IBlinkStickFinder
	{
		public BlinkStickFinder ()
		{
		}

		public IBlinkStick FindFirst ()
		{
			BlinkStickDotNet.BlinkStick blinkStick = BlinkStickDotNet.BlinkStick.FindFirst ();

			if (blinkStick != null && blinkStick.OpenDevice()) {
				return new BlinkStick (blinkStick);
			}

			return null;
		}

		public IBlinkStick FindBySerial (String serial)
		{
			BlinkStickDotNet.BlinkStick blinkStick = BlinkStickDotNet.BlinkStick.FindBySerial (serial);

			if (blinkStick != null && blinkStick.OpenDevice()) {
				return new BlinkStick (blinkStick);
			}

			return null;
		}
	}
}

