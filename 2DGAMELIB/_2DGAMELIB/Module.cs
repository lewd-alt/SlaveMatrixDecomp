using System;
using System.Drawing;

namespace _2DGAMELIB;

public class Module
{
	public Action<MouseButtons, Vector2D, Color> Down = delegate
	{
	};

	public Action<MouseButtons, Vector2D, Color> Up = delegate
	{
	};

	public Action<MouseButtons, Vector2D, Color> Move = delegate
	{
	};

	public Action<MouseButtons, Vector2D, Color> Leave = delegate
	{
	};

	public Action<MouseButtons, Vector2D, int, Color> Wheel = delegate
	{
	};

	public Action<FPS> Draw = delegate
	{
	};

	public Action Dispose = delegate
	{
	};

	public Action Setting = delegate
	{
	};
}
