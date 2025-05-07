using System.Drawing;

namespace _2DGAMELIB
{
    public static class _Con
    {
    	public static Vector2D ToVector2D(this Point Point)
    	{
    		return new Vector2D(Point.X, Point.Y);
    	}

    	public static Point ToPoint(this Vector2D Vector)
    	{
    		return new Point((int)Vector.X, (int)Vector.Y);
    	}

    	public static Point ToPoint(ref Vector2D Vector)
    	{
    		return new Point((int)Vector.X, (int)Vector.Y);
    	}

    	public static Vector2D ToVector2D(this PointF Point)
    	{
    		return new Vector2D(Point.X, Point.Y);
    	}

    	public static PointF ToPointF(this Vector2D Vector)
    	{
    		return new PointF((float)Vector.X, (float)Vector.Y);
    	}

    	public static PointF ToPointF(ref Vector2D Vector)
    	{
    		return new PointF((float)Vector.X, (float)Vector.Y);
    	}

    	public static Vector2D ToVector2D(this Size Size)
    	{
    		return new Vector2D(Size.Width, Size.Height);
    	}

    	public static Size ToSize(this Vector2D Vector)
    	{
    		return new Size((int)Vector.X, (int)Vector.Y);
    	}

    	public static Size ToSize(ref Vector2D Vector)
    	{
    		return new Size((int)Vector.X, (int)Vector.Y);
    	}

    	public static Vector2D ToVector2D(this SizeF Size)
    	{
    		return new Vector2D(Size.Width, Size.Height);
    	}

    	public static SizeF ToSizeF(this Vector2D Vector)
    	{
    		return new SizeF((float)Vector.X, (float)Vector.Y);
    	}

    	public static SizeF ToSizeF(ref Vector2D Vector)
    	{
    		return new SizeF((float)Vector.X, (float)Vector.Y);
    	}
    }
}
