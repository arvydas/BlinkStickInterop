using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BlinkStickInterop
{
	/// <summary>
	/// BlinkStick Interface. A reference to a class implementing this interface is returned by BlinkStickFinder class.
	/// </summary>
	[Guid("dfcaeff9-c582-43ca-8169-6c559516f6ab")]
	public interface IBlinkStick
	{
		/// <summary>
		/// Sets the color of the led.
		/// </summary>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		void SetColor (byte r, byte g, byte b);

		/// <summary>
		/// Sets the color of the led.
		/// </summary>
		/// <param name="color">Must be in #rrggbb format</param>
		void SetColorCSS (String color);

		/// <summary>
		/// Sets the color of the led.
		/// </summary>
		/// <param name="channel">Channel (0 - R, 1 - G, 2 - B)</param>
		/// <param name="index">Index of the LED</param>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		void SetIndexedColor (byte channel, byte index, byte r, byte g, byte b);

		/// <summary>
		/// Sets the color of the led.
		/// </summary>
		/// <param name="channel">Channel (0 - R, 1 - G, 2 - B)</param>
		/// <param name="index">Index of the LED</param>
		/// <param name="color">Must be in #rrggbb format</param>
		void SetIndexedColorCSS (byte channel, byte index, String color);

		/// <summary>
		/// Turn BlinkStick off.
		/// </summary>
		void TurnOff ();

		/// <summary>
		/// Set the number of repeats for Blink and Pulse functions
		/// </summary>
		/// <param name="repeats">Number of repeats. Defaults to 1.</param>
		void SetRepeats (int repeats);

		/// <summary>
		/// Sets the delay for Blink function.
		/// </summary>
		/// <param name="delay">Delay in milliseconds for on/off pulse. Defaults to 500</param>
		void SetDelay (int delay);

		/// <summary>
		/// Sets the duration for Pulse and Morph animations.
		/// </summary>
		/// <param name="duration">Duration in milliseconds. Defaults to 1000</param>
		void SetDuration (int duration);

		/// <summary>
		/// Sets the number of steps for Pulse and Morph animations.
		/// </summary>
		/// <param name="steps">Number of steps for animation. More steps result in smoother transitions between colors. Defaults to 50</param>
		void SetSteps (int steps);

		/// <summary>
		/// Blink the LED. SetRepeats and SetDelay functions control animation parameters.
		/// </summary>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		void Blink (byte r, byte g, byte b);

		/// <summary>
		/// Blink the LED. SetRepeats and SetDelay functions control animation parameters.
		/// </summary>
		/// <param name="color">Must be in #rrggbb format</param>
		void BlinkCSS (String color);

		/// <summary>
		/// Blink an LED on BlinkStick Pro. SetRepeats and SetDelay functions control animation parameters.
		/// </summary>
		/// <param name="channel">Channel (0 - R, 1 - G, 2 - B)</param>
		/// <param name="index">Index of the LED</param>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		void BlinkIndexed (byte channel, byte index, byte r, byte g, byte b);

		/// <summary>
		/// Blink an LED on BlinkStick Pro. SetRepeats and SetDelay functions control animation parameters.
		/// </summary>
		/// <param name="channel">Channel (0 - R, 1 - G, 2 - B)</param>
		/// <param name="index">Index of the LED</param>
		/// <param name="color">Must be in #rrggbb format</param>
		void BlinkIndexedCSS (byte channel, byte index, String color);

		/// <summary>
		/// Pulse specified color. SetDuration and SetSteps control the animation parameters.
		/// </summary>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		void Pulse (byte r, byte g, byte b);

		/// <summary>
		/// Pulse specified color. SetDuration and SetSteps control the animation parameters.
		/// </summary>
		/// <param name="color">Must be in #rrggbb format</param>
		void PulseCSS (String color);

		/// <summary>
		/// Pulse specified color on BlinkStick Pro. SetDuration and SetSteps control the animation parameters.
		/// </summary>
		/// <param name="channel">Channel (0 - R, 1 - G, 2 - B)</param>
		/// <param name="index">Index of the LED</param>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		void PulseIndexed (byte channel, byte index, byte r, byte g, byte b);

		/// <summary>
		/// Pulse specified color on BlinkStick Pro. SetDuration and SetSteps control the animation parameters.
		/// </summary>
		/// <param name="channel">Channel (0 - R, 1 - G, 2 - B)</param>
		/// <param name="index">Index of the LED</param>
		/// <param name="color">Must be in #rrggbb format</param>
		void PulseIndexedCSS (byte channel, byte index, String color);

		/// <summary>
		/// Morph from current color to new color. SetDuration and SetSteps control the animation parameters.
		/// </summary>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		void Morph (byte r, byte g, byte b);

		/// <summary>
		/// Morph from current color to new color. SetDuration and SetSteps control the animation parameters.
		/// </summary>
		/// <param name="color">Must be in #rrggbb format</param>
		void MorphCSS (String color);

		/// <summary>
		/// Morph from current color to new color on BlinkStick Pro. SetDuration and SetSteps control the animation parameters.
		/// </summary>
		/// <param name="channel">Channel (0 - R, 1 - G, 2 - B)</param>
		/// <param name="index">Index of the LED</param>
		/// <param name="r">The red component.</param>
		/// <param name="g">The green component.</param>
		/// <param name="b">The blue component.</param>
		void MorphIndexed (byte channel, byte index, byte r, byte g, byte b);

		/// <summary>
		/// Morph from current color to new color on BlinkStick Pro. SetDuration and SetSteps control the animation parameters.
		/// </summary>
		/// <param name="channel">Channel (0 - R, 1 - G, 2 - B)</param>
		/// <param name="index">Index of the LED</param>
		/// <param name="color">Must be in #rrggbb format</param>
		void MorphIndexedCSS (byte channel, byte index, String color);

		/// <summary>
		/// Send a packet of data to LEDs on BlinkStick Pro
		/// </summary>
		/// <param name="channel">Channel (0 - R, 1 - G, 2 - B)</param>
		/// <param name="colorData">Report data must be a byte array in the following format: [g0, r0, b0, g1, r1, b1, g2, r2, b2 ...]</param>
		void SetColors (byte channel, [In] ref Byte[] colorData);

		/// <summary>
		/// Gets the manufacturer of the BlinkStick device.
		/// </summary>
		/// <returns>The manufacturer name as string.</returns>
		String GetManufacturer();

		/// <summary>
		/// Returns the serial number of BlinkStick.
		/// <pre>
		/// BSnnnnnn-1.0
		/// ||  |    | |- Software minor version
		/// ||  |    |--- Software major version
		/// ||  |-------- Denotes sequential number
		/// ||----------- Denotes BlinkStick device
		/// </pre>
		/// 
		/// Software version defines the capabilities of the device
		/// </summary>
		/// <returns>Returns the serial.</returns>
		String GetSerial();

		/// <summary>
		/// Gets the major version number from serial number.
		/// </summary>
		/// <returns>Returns the major version number.</returns>
		int GetVersionMajor();

		/// <summary>
		/// Gets the minor version number from serial number.
		/// </summary>
		/// <returns>Returns the version minor.</returns>
		int GetVersionMinor();

		/// <summary>
		/// Gets the product name of the device.
		/// </summary>
		/// <returns>Returns the name of the product.</returns>
		String GetProductName();

		/// <summary>
		/// Gets the name of the device (InfoBlock1).
		/// </summary>
		/// <returns>String value of InfoBlock1</returns>
		String GetInfoBlock1();

		/// <summary>
		/// Gets the data on the device (InfoBlock2).
		/// </summary>
		/// <returns>String value of InfoBlock2</returns>
		String GetInfoBlock2();

		/// <summary>
		/// Sets the name of the device (InfoBlock1).
		/// </summary>
		/// <param name="data">String value to set for InfoBlock1</param>
		void SetInfoBlock1 (String data);

		/// <summary>
		/// Sets the data on the device (InfoBlock2).
		/// </summary>
		/// <param name="data">String value to set for InfoBlock2</param>
		void SetInfoBlock2 (String data);


		/// <summary>
		/// Sets the mode on BlinkStick Pro.
		/// </summary>
		/// <param name="mode">0 - Normal, 1 - Inverse, 2 - WS2812, 3 - WS2812 mirror</param>
		void SetMode(byte mode);

		/// <summary>
		/// Gets the mode on BlinkStick Pro.
		/// </summary>
		/// <returns>0 - Normal, 1 - Inverse, 2 - WS2812, 3 - WS2812 mirror</returns>
		byte GetMode();

		/// <summary>
		/// Enables buffered mode for <see cref="BlinkStickInterop.IBlinkStick.SetIndexedColorCSS"/> 
		/// and <see cref="BlinkStickInterop.IBlinkStick.SetIndexedColor"/>. 
		/// Use <see cref="BlinkStickInterop.IBlinkStick.Send"/> function to send the data to LEDs.
		/// In buffered mode channel value is ignored for functions that support it.
		/// </summary>
		/// <param name="ledCount"></param>
		void SetBuffered(int ledCount);

		/// <summary>
		/// Disables buffered mode
		/// </summary>
		void SetUnbuffered();

		/// <summary>
		/// Sends color data to LEDs
		/// </summary>
		/// <param name="channel">Channel to send data to</param>
		void Send(byte channel);

		/// <summary>
		/// Set color to a range of LEDs
		/// </summary>
		/// <param name="from">First index of LED</param>
		/// <param name="to">Last index of LED</param>
		/// <param name="r">R color value</param>
		/// <param name="g">G color value</param>
		/// <param name="b">B color value</param>
		void SetColorRange(byte from, byte to, byte r, byte g, byte b);
	}

	/// <summary>
	/// BlinkStick class wrapper implementing IBlinkStick interface.
	/// </summary>
	[Guid("fef50ef1-729a-49bf-8342-bd6ec3a63427")]
	[ClassInterface(ClassInterfaceType.None)]
	public class BlinkStick : IBlinkStick
	{
		private Byte[] buffer;
		private Boolean buffered = false;

		/// <summary>
		/// Holds reference to BlinkStickDotNet.BlinkStick object
		/// </summary>
		private BlinkStickDotNet.BlinkStick led;

		/// <summary>
		/// Private property which holds the number of repeats for Blink and Pulse animations
		/// </summary>
		private int repeats = 1;

		/// <summary>
		/// Private property which holds the delay of Blink function for on/off animation
		/// </summary>
		private int delay = 500;

		/// <summary>
		/// Private property which holds the duration of Pulse and Morph animations
		/// </summary>
		private int duration = 1000;

		/// <summary>
		/// Private property which holds the number of steps for color transitions of Pulse and Morph animations
		/// </summary>
		private int steps = 50;

		/// <summary>
		/// Initializes a new instance of the <see cref="BlinkStickInterop.BlinkStick"/> class.
		/// </summary>
		public BlinkStick ()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BlinkStickInterop.BlinkStick"/> class.
		/// </summary>
		/// <param name="blinkStick">BlinkStick device from BlinkStickDotNet assembly</param>
		public BlinkStick(BlinkStickDotNet.BlinkStick blinkStick)
		{
			led = blinkStick;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.SetColor"/>.
		/// </summary>
		public void SetColor (byte r, byte g, byte b)
		{
			if (buffered)
			{
				SetBuffer(0, r, g, b);
			}
			else
			{
    			led.SetColor (r, g, b);
			}
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.SetColorCSS"/>.
		/// </summary>
		public void SetColorCSS (String color)
		{
			if (buffered)
			{
				BlinkStickDotNet.RgbColor c = BlinkStickDotNet.RgbColor.FromString(color);
				SetBuffer(0, c.R, c.G, c.B);
			}
			else
			{
    			led.SetColor (color);
			}
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.SetIndexedColor"/>.
		/// </summary>
		public void SetIndexedColor (byte channel, byte index, byte r, byte g, byte b)
		{
			if (buffered)
			{
				SetBuffer(index, r, g, b);
			}
			else
			{
    			led.SetColor (channel, index, r, g, b);
			}
		}


		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.SetIndexedColorCSS"/>.
		/// </summary>
		public void SetIndexedColorCSS (byte channel, byte index, String color)
		{
			if (buffered)
			{
				BlinkStickDotNet.RgbColor c = BlinkStickDotNet.RgbColor.FromString(color);
				SetBuffer(index, c.R, c.G, c.B);
			}
			else
			{
    			led.SetColor (channel, index, color);
			}
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.TurnOff"/>.
		/// </summary>
		public void TurnOff ()
		{
			led.TurnOff ();
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.SetRepeats"/>.
		/// </summary>
		public void SetRepeats (int repeats)
		{
			this.repeats = repeats;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.SetDelay"/>.
		/// </summary>
		public void SetDelay (int delay)
		{
			this.delay = delay;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.SetDuration"/>.
		/// </summary>
		public void SetDuration (int duration)
		{
			this.duration = duration;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.SetSteps"/>.
		/// </summary>
		public void SetSteps (int steps)
		{
			this.steps = steps;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.Blink"/>.
		/// </summary>
		public void Blink (byte r, byte g, byte b)
		{
			led.Blink (r, g, b, repeats, delay);
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.BlinkCSS"/>.
		/// </summary>
		public void BlinkCSS (String color)
		{
			led.Blink (color, repeats, delay);
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.BlinkIndexed"/>.
		/// </summary>
		public void BlinkIndexed (byte channel, byte index, byte r, byte g, byte b)
		{
			led.Blink (channel, index, r, g, b, repeats, delay);
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.BlinkIndexedCSS"/>.
		/// </summary>
		public void BlinkIndexedCSS (byte channel, byte index, String color)
		{
			led.Blink (channel, index, color, repeats, delay);
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.Pulse"/>.
		/// </summary>
		public void Pulse (byte r, byte g, byte b)
		{
			led.Pulse (r, g, b, repeats, duration, steps);
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.PulseCSS"/>.
		/// </summary>
		public void PulseCSS (String color)
		{
			led.Pulse (color, repeats, duration, steps);
		}


		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.PulseIndexed"/>.
		/// </summary>
		public void PulseIndexed (byte channel, byte index, byte r, byte g, byte b)
		{
			led.Pulse (channel, index, r, g, b, repeats, duration, steps);
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.PulseIndexedCSS"/>.
		/// </summary>
		public void PulseIndexedCSS (byte channel, byte index, String color)
		{
			led.Pulse (channel, index, color, repeats, duration, steps);
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.Morph"/>.
		/// </summary>
		public void Morph (byte r, byte g, byte b)
		{
			led.Morph (r, g, b, duration, steps);
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.MorphCSS"/>.
		/// </summary>
		public void MorphCSS (String color)
		{
			led.Morph (color, duration, steps);
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.MorphIndexed"/>.
		/// </summary>
		public void MorphIndexed (byte channel, byte index, byte r, byte g, byte b)
		{
			led.Morph (channel, index, r, g, b, duration, steps);
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.MorphIndexedCSS"/>.
		/// </summary>
		public void MorphIndexedCSS (byte channel, byte index, String color)
		{
			led.Morph (channel, index, color, duration, steps);
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.SetColors"/>.
		/// </summary>
		public void SetColors (byte channel, ref Byte[] colorData)
		{
			led.SetColors (channel, colorData);
		}


		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.GetManufacturer"/>.
		/// </summary>
		public String GetManufacturer ()
		{
			return led.ManufacturerName;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.GetSerial"/>.
		/// </summary>
		public String GetSerial ()
		{
			return led.Serial;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.GetVersionMajor"/>.
		/// </summary>
		public int GetVersionMajor ()
		{
			return led.VersionMajor;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.GetVersionMinor"/>.
		/// </summary>
		public int GetVersionMinor ()
		{
			return led.VersionMinor;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.GetProductName"/>.
		/// </summary>
		public String GetProductName ()
		{
			return led.ProductName;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.GetInfoBlock1"/>.
		/// </summary>
		public String GetInfoBlock1 ()
		{
			return led.InfoBlock1;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.GetInfoBlock2"/>.
		/// </summary>
		public String GetInfoBlock2 ()
		{
			return led.InfoBlock2;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.SetInfoBlock1"/>.
		/// </summary>
		public void SetInfoBlock1 (String data)
		{
			led.InfoBlock1 = data;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.SetInfoBlock2"/>.
		/// </summary>
		public void SetInfoBlock2 (String data)
		{
			led.InfoBlock2 = data;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.SetMode"/>.
		/// </summary>
		public void SetMode (byte mode)
		{
			led.SetMode (mode);
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.GetMode"/>.
		/// </summary>
		public byte GetMode ()
		{
            try
            {
                return (byte)led.GetMode();
            }
            catch
            {
                return 0;
            }
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.SetBuffered"/>.
		/// </summary>
		public void SetBuffered(int ledCount)
		{
			buffer = new Byte[ledCount * 3];
			buffered = true;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.SetUnbuffered"/>.
		/// </summary>
		public void SetUnbuffered()
		{
			buffered = false;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.SetBuffer"/>.
		/// </summary>
		private void SetBuffer(int index, byte r, byte g, byte b)
		{
			if (index * 3 > buffer.Length)
			{
				throw new ArgumentException("Index value is too large");
			}

			buffer[index * 3] = g;
			buffer[index * 3 + 1] = r;
			buffer[index * 3 + 2] = b;
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.Send"/>.
		/// </summary>
		public void Send(byte channel)
		{
			if (buffered)
			{
    			led.SetColors(channel, buffer);
			}
		}

		/// <summary>
		/// See <see cref="BlinkStickInterop.IBlinkStick.SetColorRange"/>.
		/// </summary>
		public void SetColorRange(byte from, byte to, byte r, byte g, byte b)
		{
			for (byte i= from; i <= to; i++)
			{
				SetIndexedColor(0, i, r, g, b);
			}
		}
	}
}

