using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace BlinkStickInterop
{
	/// <summary>
	/// BlinkStick finder interface
	/// </summary>
	[Guid("779b4d12-8d16-4218-b39c-897a0c05bf6a")]
	public interface IBlinkStickFinder
	{
		/// <summary>
		/// Finds first BlinkStick
		/// </summary>
		/// <returns>First BlinkStick device found on the OS</returns>
		IBlinkStick FindFirst ();

		/// <summary>
		/// Find by Serial
		/// </summary>
		/// <returns>Finds BlinkStick device by serial number.</returns>
		/// <param name="serial">Serial number of the device</param>
		IBlinkStick FindBySerial (String serial);

		/// <summary>
		/// Find serial numbers of all connected BlinkStick devices
		/// </summary>
		/// <returns>Array of serial numbers.</returns>
        string[] FindSerials();
	}

	/// <summary>
	/// BlinkStick finder class
	/// </summary>
	[Guid("2646e9b6-4716-4f29-966c-b5c10832b64a")]
	[ClassInterface(ClassInterfaceType.None)]
	public class BlinkStickFinder : IBlinkStickFinder
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BlinkStickInterop.BlinkStickFinder"/> class.
		/// </summary>
		public BlinkStickFinder ()
		{
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStickFinder.FindFirst"/>.
		/// </summary>
		public IBlinkStick FindFirst ()
		{
			BlinkStickDotNet.BlinkStick blinkStick = BlinkStickDotNet.BlinkStick.FindFirst ();

			if (blinkStick != null && blinkStick.OpenDevice()) {
				return new BlinkStick (blinkStick);
			}

			return null;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStickFinder.FindBySerial"/>.
		/// </summary>
		public IBlinkStick FindBySerial (String serial)
		{
			BlinkStickDotNet.BlinkStick blinkStick = BlinkStickDotNet.BlinkStick.FindBySerial (serial);

			if (blinkStick != null && blinkStick.OpenDevice()) {
				return new BlinkStick (blinkStick);
			}

			return null;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStickFinder.FindSerials"/>.
		/// </summary>
		public string[] FindSerials ()
		{
            List<string> serials = new List<string>();

            foreach (BlinkStickDotNet.BlinkStick blinkStick in BlinkStickDotNet.BlinkStick.FindAll())
            {
                serials.Add(blinkStick.Serial);
            }

			return serials.ToArray();
		}
	}
}

