using GLFW;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;

namespace _2DGAMELIB;

public class Med
{
	public static object obj;

	private WPFImage baseControl;

	public double Unit = 1762.4;

	public Rect Base = new Rect(4.0, 3.0, 0.4);

	public double DisQuality = 1.0;

	public double HitAccuracy = 0.5;

	public Bitmap BD;

	public Graphics GD;

	public Bitmap BH;

	public Graphics GH;

	private Color ClearColor = Color.Transparent;

	public bool Drive = true;

	private Size BaseSize = Size.Empty;

	private double resMag = 1.0;

	private Vector2D resVector = Dat.Vec2DZero;

	private Sce Sce;

	private string mode;

	public string Modeb;

	private Dictionary<string, Module> Modes;

	private Func<Med, Dictionary<string, Module>> GetModes;

	private int WidthM;

	private int HeightM;

	public static double FPS;

	public FPS FPSF = new FPS(FPS);

	private bool cur = true;

	public HashSet<Color> HitColors = new HashSet<Color>
	{
		Color.Transparent,
		Color.Black
	};

	private const int LOGPIXELSX = 88;

	private const int LOGPIXELSY = 90;

	public static double dpiX;

	public static double dpiY;

	public static double DpiX;

	public static double DpiY;

	public string UITitle;

	public bool ShowFPS;

	public Control BaseControlC => baseControl;

	public WPFImage BaseControl => baseControl;

	public double ResMag => resMag;

	public Vector2D ResVector => resVector;

	public string Mode
	{
		get
		{
			return mode;
		}
		set
		{
			Modes[mode].Up(MouseButtons.None, Dat.Vec2DZero, Color.Empty);
			Modes[mode].Move(MouseButtons.None, Dat.Vec2DZero, Color.Empty);
			Modeb = mode;
			mode = value;
			Modes[mode].Move(MouseButtons.None, Dat.Vec2DZero, Color.Empty);
			Modes[mode].Setting();
		}
	}

	public Vector2D CursorPosition => ToBasePosition(baseControl.PointToClient(System.Windows.Forms.Cursor.Position));

	public Med()
	{
		Point dpi = GetDpi();
		dpiX = dpi.X;
		dpiY = dpi.Y;
		DpiX = 96.0 / dpiX;
		DpiY = 96.0 / dpiY;
	}

	public void FadeIn(double Rate)
	{
		Sce.TransformAlpha(GD, Rate);
	}

	public void FadeOut(double Rate)
	{
		Sce.TransD(GD, Rate);
	}

	public void DrawStart(Are Are)
	{
		Sce.DrawStart(Are);
	}

	public void DrawEnd(Are Are)
	{
		Sce.DrawEnd(Are);
	}

	public void ClearSta(Color ClearColor)
	{
		Sce.ClearStart(ref ClearColor);
	}

	public void InitializeModes(string Mode, Func<Med, Dictionary<string, Module>> GetModes)
	{
		mode = Mode;
		this.GetModes = GetModes;
	}

	public Size Setting(WPFImage BaseControl)
	{
		baseControl = BaseControl;
		BaseSize = new Size((int)(Base.LocalWidth * Unit), (int)(Base.LocalHeight * Unit));
		BD = new Bitmap(BaseSize.Width, BaseSize.Height);
		GD = Graphics.FromImage(BD);
		GD.InterpolationMode = InterpolationMode.HighQualityBilinear;
		BH = new Bitmap((int)((double)BaseSize.Width * HitAccuracy), (int)((double)BaseSize.Height * HitAccuracy));
		GH = Graphics.FromImage(BH);
		GH.InterpolationMode = InterpolationMode.Bilinear;
		WidthM = BH.Width - 1;
		HeightM = BH.Height - 1;
		Clear();
		Sce = new Sce(BaseSize.Width, BaseSize.Height);
		Modes = GetModes(this);


		BaseControl.Image.MouseDown += delegate(object s, System.Windows.Input.MouseButtonEventArgs e)
		{
			Point Position5 = baseControl.PointToClient(System.Windows.Forms.Cursor.Position);
			MouseButtons arg2 = MouseButtons.None;
			switch (e.ChangedButton)
			{
			case System.Windows.Input.MouseButton.Left:
				arg2 = MouseButtons.Left;
				break;
			case System.Windows.Input.MouseButton.Middle:
				arg2 = MouseButtons.Middle;
				break;
			case System.Windows.Input.MouseButton.Right:
				arg2 = MouseButtons.Right;
				break;
			case System.Windows.Input.MouseButton.XButton1:
				arg2 = MouseButtons.XButton1;
				break;
			case System.Windows.Input.MouseButton.XButton2:
				arg2 = MouseButtons.XButton2;
				break;
			}
			Modes[mode].Down(arg2, ToBasePosition(Position5), GetHitColor(ref Position5));
		};

        BaseControl.Image.MouseUp += delegate(object s, System.Windows.Input.MouseButtonEventArgs e)
		{
			Point Position4 = baseControl.PointToClient(System.Windows.Forms.Cursor.Position);
			MouseButtons arg = MouseButtons.None;
			switch (e.ChangedButton)
			{
			case System.Windows.Input.MouseButton.Left:
				arg = MouseButtons.Left;
				break;
			case System.Windows.Input.MouseButton.Middle:
				arg = MouseButtons.Middle;
				break;
			case System.Windows.Input.MouseButton.Right:
				arg = MouseButtons.Right;
				break;
			case System.Windows.Input.MouseButton.XButton1:
				arg = MouseButtons.XButton1;
				break;
			case System.Windows.Input.MouseButton.XButton2:
				arg = MouseButtons.XButton2;
				break;
			}
			Modes[mode].Up(arg, ToBasePosition(Position4), GetHitColor(ref Position4));
		};


        BaseControl.gl_img.Click = delegate (IntPtr window, GLFW.MouseButton button, InputState state, GLFW.ModifierKeys modifiers)
        {
			double x, y;
			Glfw.GetCursorPosition(GlImage.PtrToWindow(window), out x, out y);
            Point Position5 = new Point((int)x, (int)y);
            MouseButtons arg2 = MouseButtons.None;
            switch (button)
            {
                case GLFW.MouseButton.Left:
                    arg2 = MouseButtons.Left;
                    break;
                case GLFW.MouseButton.Middle:
                    arg2 = MouseButtons.Middle;
                    break;
                case GLFW.MouseButton.Right:
                    arg2 = MouseButtons.Right;
                    break;
                case GLFW.MouseButton.Button4:
                    arg2 = MouseButtons.XButton1;
                    break;
                case GLFW.MouseButton.Button5:
                    arg2 = MouseButtons.XButton2;
                    break;
			}


			(state == InputState.Press ? Modes[mode].Down : Modes[mode].Up)(arg2, ToBasePosition(Position5), GetHitColor(ref Position5));
		};


        BaseControl.Image.MouseMove += delegate
		{
			Point Position3 = baseControl.PointToClient(System.Windows.Forms.Cursor.Position);
			Modes[mode].Move(Control.MouseButtons, ToBasePosition(Position3), GetHitColor(ref Position3));
		};

		BaseControl.gl_img.Move = delegate (IntPtr window, double x, double y)
		{
			Point Position3 = new Point((int)x, (int)y);
			Modes[mode].Move(Control.MouseButtons, ToBasePosition(Position3), GetHitColor(ref Position3));
		};


		BaseControl.Image.MouseLeave += delegate
		{
			Point Position2 = baseControl.PointToClient(System.Windows.Forms.Cursor.Position);
			Modes[mode].Leave(Control.MouseButtons, ToBasePosition(Position2), GetHitColor(ref Position2));
		};

		BaseControl.gl_img.Leave = delegate (IntPtr window, bool entered)
		{
			if (!entered)
			{
				double x, y;
				Glfw.GetCursorPosition(GlImage.PtrToWindow(window), out x, out y);
				Point Position2 = new Point((int)x, (int)y);
				Modes[mode].Leave(Control.MouseButtons, ToBasePosition(Position2), GetHitColor(ref Position2));
			}
		};

		BaseControl.Image.MouseWheel += delegate(object s, MouseWheelEventArgs e)
		{
			Point Position = baseControl.PointToClient(System.Windows.Forms.Cursor.Position);
			Modes[mode].Wheel(Control.MouseButtons, ToBasePosition(Position), e.Delta, GetHitColor(ref Position));
		};

		BaseControl.gl_img.Scroll = delegate (IntPtr window, double xo, double yo)
		{
            double x, y;
            Glfw.GetCursorPosition(GlImage.PtrToWindow(window), out x, out y);
			Point Position = new Point((int)x, (int)y);
			//Note: yo may be inverted
            Modes[mode].Wheel(Control.MouseButtons, ToBasePosition(Position), (int)yo, GetHitColor(ref Position));
        };


		((Control)BaseControl).Resize += delegate
		{
			if (BaseSize.Width >= BaseSize.Height)
			{
				double num = (double)BaseSize.Width / (double)BaseSize.Height;
				if ((double)baseControl.ClientSize.Width / (double)baseControl.ClientSize.Height <= num)
				{
					resMag = (double)BaseSize.Width / (double)baseControl.ClientSize.Width;
					resVector.X = 0.0;
					resVector.Y = ((double)baseControl.ClientSize.Height - (double)BaseSize.Height / resMag) * 0.5;
				}
				else
				{
					resMag = (double)BaseSize.Height / (double)baseControl.ClientSize.Height;
					resVector.X = ((double)baseControl.ClientSize.Width - (double)BaseSize.Width / resMag) * 0.5;
					resVector.Y = 0.0;
				}
			}
			else
			{
				double num2 = (double)BaseSize.Height / (double)BaseSize.Width;
				if ((double)baseControl.ClientSize.Height / (double)baseControl.ClientSize.Width <= num2)
				{
					resMag = (double)BaseSize.Height / (double)baseControl.ClientSize.Height;
					resVector.X = ((double)baseControl.ClientSize.Width - (double)BaseSize.Width / resMag) * 0.5;
					resVector.Y = 0.0;
				}
				else
				{
					resMag = (double)BaseSize.Width / (double)baseControl.ClientSize.Width;
					resVector.X = 0.0;
					resVector.Y = ((double)baseControl.ClientSize.Height - (double)BaseSize.Height / resMag) * 0.5;
				}
			}
		};

		BaseControl.gl_img.Resize = delegate (IntPtr window, int width, int height)
		{
			//TODO mess with viewport
            if (BaseSize.Width >= BaseSize.Height)
            {
                double num = (double)BaseSize.Width / (double)BaseSize.Height;
                if ((double)width / (double)height <= num)
                {
                    resMag = (double)BaseSize.Width / (double)width;
                    resVector.X = 0.0;
                    resVector.Y = ((double)height - (double)BaseSize.Height / resMag) * 0.5;
                }
                else
                {
                    resMag = (double)BaseSize.Height / (double)height;
                    resVector.X = ((double)width - (double)BaseSize.Width / resMag) * 0.5;
                    resVector.Y = 0.0;
                }
            }
            else
            {
                double num2 = (double)BaseSize.Height / (double)BaseSize.Width;
                if ((double)height / (double)width <= num2)
                {
                    resMag = (double)BaseSize.Height / (double)height;
                    resVector.X = ((double)width - (double)BaseSize.Width / resMag) * 0.5;
                    resVector.Y = 0.0;
                }
                else
                {
                    resMag = (double)BaseSize.Width / (double)width;
                    resVector.X = 0.0;
                    resVector.Y = ((double)height - (double)BaseSize.Height / resMag) * 0.5;
                }
            }
        };

		return BaseSize;
	}

	public Vector2D ToBasePosition(Point Position)
	{
		return new Vector2D(((double)Position.X - resVector.X) / Unit * resMag, ((double)Position.Y - resVector.Y) / Unit * resMag);
	}

	public Point FromBasePosition(Vector2D Position)
	{
		return new Point((int)(Position.X / resMag * Unit + resVector.X), (int)(Position.Y / resMag * Unit + resVector.Y));
	}

	public Color GetHitColor(Point Position)
	{
		double num = HitAccuracy * resMag;
		Point point = ((Position.ToVector2D() - resVector) * num).ToPoint();
		if (point.X < 0)
		{
			point.X = 0;
		}
		if (point.Y < 0)
		{
			point.Y = 0;
		}
		if (point.X > WidthM)
		{
			point.X = WidthM;
		}
		if (point.Y > HeightM)
		{
			point.Y = HeightM;
		}
		return BH.GetPixel(point.X, point.Y);
	}

	public Color GetHitColor(ref Point Position)
	{
		double num = HitAccuracy * resMag;
		Point point = ((Position.ToVector2D() - resVector) * num).ToPoint();
		if (point.X < 0)
		{
			point.X = 0;
		}
		if (point.Y < 0)
		{
			point.Y = 0;
		}
		if (point.X > WidthM)
		{
			point.X = WidthM;
		}
		if (point.Y > HeightM)
		{
			point.Y = HeightM;
		}
		return BH.GetPixel(point.X, point.Y);
	}

	public void Drawing()
	{
		baseControl.BitmapSetting(BD);
		Modes[mode].Setting();
		double FPS = 0.0;


		Action action = delegate
		{
			FPS = FPSF.Value;
			if (FPS > 1.0)
			{
				Modes[mode].Draw(FPSF);
			}
			baseControl.SetBitmap(BD);
		};


		while (Drive)
		{
			long frame_start = FPSF.sw.ElapsedMilliseconds;

			FPSF.FPSFixed(action);

            long frame_end = FPSF.sw.ElapsedMilliseconds;

            if (ShowFPS)
			{
                baseControl.Parent.Text = UITitle + " - FPS: " + System.Math.Round(FPSF.Value, 2);
			}
			Application.DoEvents();
			baseControl.PollEvents();

            long frame_update_end = FPSF.sw.ElapsedMilliseconds;

			//System.Diagnostics.Debug.WriteLine("frame time: {0:D}", frame_end - frame_start);
			//System.Diagnostics.Debug.WriteLine("event time: {0:D}", frame_update_end - frame_end);
		}
	}

	public void Clear()
	{
		GD.Clear(ClearColor);
		GH.Clear(ClearColor);
	}

	public void Draw(Are Are)
	{
		Are.Draw(GD, GH);
	}

	public void CursorHide()
	{
		if (cur)
		{
			System.Windows.Forms.Cursor.Hide();
			cur = false;
		}
	}

	public void CursorShow()
	{
		if (!cur)
		{
			System.Windows.Forms.Cursor.Show();
			cur = true;
		}
	}

	public void InvokeL(Action a)
	{
		baseControl.Invoke(a);
	}

	public Color GetUniqueColor()
	{
		Oth.GetRandomColor(out var ret);
		while (HitColors.Contains(ret))
		{
			Oth.GetRandomColor(out ret);
		}
		HitColors.Add(ret);
		return ret;
	}

	public void GetUniqueColor(out Color c)
	{
		Oth.GetRandomColor(out c);
		while (HitColors.Contains(c))
		{
			Oth.GetRandomColor(out c);
		}
		HitColors.Add(c);
	}

	public void SetUniqueColor(IEnumerable<Par> ps)
	{
		foreach (Par p in ps)
		{
			p.HitColor = GetUniqueColor();
		}
	}

	public void RemUniqueColor(Color Color)
	{
		HitColors.Remove(Color);
	}

	public void RemUniqueColor(IEnumerable<Par> ps)
	{
		foreach (Par p in ps)
		{
			HitColors.Remove(p.HitColor);
		}
	}

	public void Dispose()
	{
		Drive = false;
		foreach (Module value in Modes.Values)
		{
			value.Dispose();
		}
		BD.Dispose();
		GD.Dispose();
		BH.Dispose();
		GH.Dispose();
		Sce.Dispose();
	}

	[DllImport("user32.dll")]
	private static extern bool SetProcessDPIAware();

	[DllImport("user32.dll")]
	private static extern IntPtr GetWindowDC(IntPtr hwnd);

	[DllImport("gdi32.dll")]
	private static extern int GetDeviceCaps(IntPtr hdc, int index);

	[DllImport("user32.dll")]
	private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

	public static Point GetDpi()
	{
		SetProcessDPIAware();
		IntPtr windowDC = GetWindowDC(IntPtr.Zero);
		Point result = new Point(GetDeviceCaps(windowDC, 88), GetDeviceCaps(windowDC, 90));
		ReleaseDC(IntPtr.Zero, windowDC);
		return result;
	}

	static Med()
	{
		obj = new object();
		FPS = 60.0;
	}
}
