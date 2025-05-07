using GLFW;
using OpenGL;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace _2DGAMELIB;

public class GlImage
{

	//yeah this is a little bit sketchy
    public static unsafe GLFW.Window PtrToWindow(IntPtr source)
    {
        var sourceRef = __makeref(source);
        var dest = default(GLFW.Window);
        var destRef = __makeref(dest);
        *(IntPtr*)&destRef = *(IntPtr*)&sourceRef;
        return __refvalue(destRef, GLFW.Window);
    }

    public GLFW.Window window;
	private uint shader_program;
	private uint texture;
	private uint vertex_buf;
	private uint vao;


    public GlImage() { }

    public void ImageSetting() { }

	public System.Drawing.Point GetCursorPoint() {
		double x, y;
		Glfw.GetCursorPosition(window, out x, out y);
		return new System.Drawing.Point((int)x, (int)y);
	}

	public delegate void ShouldCloseCallback();

	public ShouldCloseCallback Closing = delegate () { };
	public MouseButtonCallback Click = delegate (IntPtr window, MouseButton button, InputState state, ModifierKeys modifiers) { };
	public MouseCallback Move = delegate (IntPtr window, double x, double y) { };
	public SizeCallback Resize = delegate (IntPtr window, int width, int height) { };
	public MouseCallback Scroll = delegate (IntPtr window, double x, double y) { };
	public MouseEnterCallback Leave = delegate (IntPtr window, bool entered) { };

    public void PollEvents() {
		Glfw.PollEvents();
		if (Glfw.WindowShouldClose(window))
			Closing();
	} 
    public void SetBitmap(Bitmap bmp)
    {
        Gl.UseProgram(shader_program);
        Gl.Viewport(0, 0, bmp.Width, bmp.Height);

        Gl.ActiveTexture(TextureUnit.Texture0);
		Gl.BindTexture(TextureTarget.Texture2d, texture);

        BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
		Gl.TexImage2D(TextureTarget.Texture2d, 0, InternalFormat.Rgba8, bmp.Width, bmp.Height, 0, OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);
        bmp.UnlockBits(data);

        int res_pos = Gl.GetUniformLocation(shader_program, "res");
		Gl.Uniform2(res_pos, (float)bmp.Width, (float)bmp.Height);

        Gl.BindBuffer(BufferTarget.ArrayBuffer, vertex_buf);
        uint vert_pos = (uint)Gl.GetAttribLocation(shader_program, "vertPos");
        Gl.EnableVertexAttribArray(vert_pos);

		Gl.BindVertexArray(vao);
        Gl.VertexAttribPointer(
            vert_pos,
            2,
            VertexAttribType.Float,
            false,
            0,
            IntPtr.Zero
        );

        Gl.DrawArrays(PrimitiveType.TriangleStrip, 0, 4);
        Glfw.SwapBuffers(window);
    }

	public void BitmapSetting(Bitmap bmp)
	{
		Glfw.WindowHint(Hint.ClientApi, ClientApi.OpenGL);
		Glfw.WindowHint(Hint.ContextVersionMajor, 3);
		Glfw.WindowHint(Hint.ContextVersionMinor, 3);
		Glfw.WindowHint(Hint.OpenglProfile, Profile.Core);
		Glfw.WindowHint(Hint.Doublebuffer, true);
		Glfw.WindowHint(Hint.Decorated, true);
		Glfw.WindowHint(Hint.OpenglForwardCompatible, true);

		window = Glfw.CreateWindow(bmp.Width, bmp.Height, "yayy", Monitor.None, GLFW.Window.None);

        Glfw.SetWindowSizeCallback(window, Resize);
        Glfw.SetMouseButtonCallback(window, Click);
        Glfw.SetCursorPositionCallback(window, Move);
		Glfw.SetScrollCallback(window, Scroll);
		Glfw.SetCursorEnterCallback(window, Leave);

		GCHandle handle = GCHandle.Alloc(this);
		Glfw.SetWindowUserPointer(window, GCHandle.ToIntPtr(handle));

        Gl.Initialize();
		Glfw.MakeContextCurrent(window);


		string[] vertexShaderSource = {
@"
#version 100
precision mediump float;

attribute vec2 vertPos;

void main()
{
    gl_Position = vec4(vertPos, 0.0, 1.0);
}
"
        };

		string[] fragmentShaderSource = {
@"
#version 100
precision mediump float;

uniform sampler2D sTexture;
uniform vec2 res;

void main()
{
	vec2 tc = gl_FragCoord.xy / res;
	tc.y = 1.0 - tc.y;

    gl_FragColor = texture2D(sTexture, tc);
}
"
        };

        uint vertexShader = Gl.CreateShader(ShaderType.VertexShader);
        Gl.ShaderSource(vertexShader, vertexShaderSource);
        Gl.CompileShader(vertexShader);

        uint fragmentShader = Gl.CreateShader(ShaderType.FragmentShader);
        Gl.ShaderSource(fragmentShader, fragmentShaderSource);
        Gl.CompileShader(fragmentShader);

        shader_program = Gl.CreateProgram();
        Gl.AttachShader(shader_program, vertexShader);
        Gl.AttachShader(shader_program, fragmentShader);
        Gl.LinkProgram(shader_program);

        int length;
        StringBuilder stringBuilder = new StringBuilder(10000);
        Gl.GetShaderInfoLog(fragmentShader, 10000, out length, stringBuilder);
		System.Diagnostics.Debug.WriteLine(stringBuilder);
		stringBuilder.Clear();
        Gl.GetShaderInfoLog(vertexShader, 10000, out length, stringBuilder);
        System.Diagnostics.Debug.WriteLine(stringBuilder);
        stringBuilder.Clear();
        Gl.GetProgramInfoLog(shader_program, 10000, out length, stringBuilder);
        System.Diagnostics.Debug.WriteLine(stringBuilder);
		stringBuilder.Clear();

        Gl.UseProgram(shader_program);

        Gl.Uniform1(Gl.GetUniformLocation(shader_program, "sTexture"), 0);


        texture = Gl.GenTexture();

        Gl.ActiveTexture(TextureUnit.Texture0);
        Gl.BindTexture(TextureTarget.Texture2d, texture);
        Gl.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureWrapS, TextureWrapMode.ClampToEdge);
        Gl.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureWrapT, TextureWrapMode.ClampToEdge);
		Gl.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, TextureMagFilter.Nearest);
		Gl.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureMinFilter, TextureMagFilter.Nearest);


        float[] buf = { 1.0f, 1.0f,  -1.0f, 1.0f,  1.0f, -1.0f,   -1.0f, -1.0f };
        vertex_buf = Gl.GenBuffer();
        Gl.BindBuffer(BufferTarget.ArrayBuffer, vertex_buf);
        Gl.BufferData(BufferTarget.ArrayBuffer, (uint)(sizeof(float) * buf.Length), buf, BufferUsage.StaticDraw);

		vao = Gl.GenVertexArray();
    }
}

/*
public class WPFImage : ElementHost
{
	public GlImage gl_img;

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

        gl_img = new GlImage();
    }

	public void PollEvents() {
		gl_img.PollEvents();
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

		gl_img.SetBitmap(bmp);
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

		gl_img.BitmapSetting(bmp);
    }

}
*/