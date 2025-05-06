using System;

namespace _2DGAMELIB;

public static class Vec
{

	public static void Add(ref Vector2D v1, ref Vector2D v2, out Vector2D r)
	{
		r.X = v1.X + v2.X;
		r.Y = v1.Y + v2.Y;
	}

	public static void Subtract(ref Vector2D v1, ref Vector2D v2, out Vector2D r)
	{
		r.X = v1.X - v2.X;
		r.Y = v1.Y - v2.Y;
	}

	public static double DistanceSquared(this Vector2D v1, Vector2D v2)
	{
		double num = v1.X - v2.X;
		double num2 = v1.Y - v2.Y;
		return num * num + num2 * num2;
	}

	public static void Dot(ref Vector2D v1, ref Vector2D v2, out double r)
	{
		r = v1.X * v2.X + v1.Y * v2.Y;
	}

	public static double Cross(ref Vector2D v1, ref Vector2D v2)
	{
		return v1.X * v2.Y - v1.Y * v2.X;
	}

	public static Vector2D newNormalize(this Vector2D vector)
	{
		vector.Normalize();
		return vector;
	}

	public static double Angle(ref Vector2D v1, ref Vector2D v2)
	{
		Dot(ref v1, ref v2, out var r);
		r /= v1.Length() * v2.Length();
		if (r > 1.0)
		{
			r = 1.0;
		}
		else if (r < -1.0)
		{
			r = -1.0;
		}
		return System.Math.Acos(r);
	}

	public static double Angle02π(this Vector2D v1, Vector2D v2)
	{
		double num = Angle(ref v1, ref v2);
		if (Cross(ref v1, ref v2) < 0.0)
		{
			num = System.Math.PI * 2.0 - num;
		}
		return num;
	}
}
