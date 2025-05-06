using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace _2DGAMELIB;

public class WPFImage : ElementHost
{
	private int ByteSize;

	private Rectangle rect1;

	private Int32Rect rect2;

	private BitmapData data;

	public WriteableBitmap wb;

	private bool HighQuality;

	private string ConfigPath = Directory.GetCurrentDirectory() + "\\Config.ini";

	public System.Windows.Controls.Image Image => (System.Windows.Controls.Image)base.Child;

	public WPFImage()
	{
		System.Windows.Controls.Image child = new System.Windows.Controls.Image
		{
			Stretch = Stretch.Uniform
		};
		base.Child = child;
	}

	public void ImageSetting()
	{
		try
		{
			if (!File.Exists(ConfigPath))
			{
				HighQuality = false;
			}
			else
			{
				string[] source = ConfigPath.ReadLines();
				HighQuality = source.First((string s) => s.StartsWith("AntiAliasing:")).Last() == '1';
			}
		}
		catch
		{
			HighQuality = false;
		}
		if (HighQuality)
		{
			RenderOptions.SetBitmapScalingMode(Image, BitmapScalingMode.LowQuality);
		}
		else
		{
			RenderOptions.SetBitmapScalingMode(Image, BitmapScalingMode.NearestNeighbor);
		}
		RenderOptions.SetEdgeMode(Image, EdgeMode.Aliased);
	}

    [DllImport("Kernel32.dll")]
    public static extern void CopyMemory(IntPtr Destination, IntPtr Source, int ByteSize);


	//the guy that gets called to update a frame
    public void SetBitmap(Bitmap bmp)
	{
		data = bmp.LockBits(rect1, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
		wb.Lock();
		CopyMemory(wb.BackBuffer, data.Scan0, ByteSize);
		wb.AddDirtyRect(rect2);
		wb.Unlock();
		bmp.UnlockBits(data);
	}

	public void BitmapSetting(Bitmap bmp)
	{
		int pixelWidth = bmp.Width;
		int num = bmp.Height;
		rect1 = new Rectangle(0, 0, pixelWidth, num);
		rect2 = new Int32Rect(0, 0, pixelWidth, num);
		wb = new WriteableBitmap(pixelWidth, num, bmp.HorizontalResolution, bmp.VerticalResolution, PixelFormats.Bgra32, null);
		ByteSize = wb.BackBufferStride * num;
		Image.Source = wb;
	}

}
