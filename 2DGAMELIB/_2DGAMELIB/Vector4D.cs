using System;
using System.Globalization;

namespace _2DGAMELIB;

[Serializable]
public struct Vector4D
{
	public double X;

	public double Y;

	public double Z;

	public double W;

	public double this[int index]
	{
		get
		{
			return index switch
			{
				0 => X, 
				1 => Y, 
				2 => Z, 
				3 => W, 
				_ => throw new ArgumentOutOfRangeException("index", "Indices for Vector4D run from 0 to 3, inclusive."), 
			};
		}
		set
		{
			switch (index)
			{
			case 0:
				X = value;
				break;
			case 1:
				Y = value;
				break;
			case 2:
				Z = value;
				break;
			case 3:
				W = value;
				break;
			default:
				throw new ArgumentOutOfRangeException("index", "Indices for Vector4D run from 0 to 3, inclusive.");
			}
		}
	}

	public Vector4D(double value)
	{
		X = value;
		Y = value;
		Z = value;
		W = value;
	}

	public Vector4D(Vector2D value, double z, double w)
	{
		X = value.X;
		Y = value.Y;
		Z = z;
		W = w;
	}

	public Vector4D(ref Vector2D value, double z, double w)
	{
		X = value.X;
		Y = value.Y;
		Z = z;
		W = w;
	}

	public Vector4D(Vector3D value, double w)
	{
		X = value.X;
		Y = value.Y;
		Z = value.Z;
		W = w;
	}

	public Vector4D(ref Vector3D value, double w)
	{
		X = value.X;
		Y = value.Y;
		Z = value.Z;
		W = w;
	}

	public Vector4D(double x, double y, double z, double w)
	{
		X = x;
		Y = y;
		Z = z;
		W = w;
	}

	public double Length()
	{
		return System.Math.Sqrt(X * X + Y * Y + Z * Z + W * W);
	}

	public double LengthSquared()
	{
		return X * X + Y * Y + Z * Z + W * W;
	}

	public void Normalize()
	{
		double num = Length();
		if (num != 0.0)
		{
			double num2 = 1.0 / num;
			X *= num2;
			Y *= num2;
			Z *= num2;
			W *= num2;
		}
	}

	public static Vector4D operator +(Vector4D left, Vector4D right)
	{
		return new Vector4D(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
	}

	public static Vector4D operator -(Vector4D left, Vector4D right)
	{
		return new Vector4D(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
	}

	public static Vector4D operator -(Vector4D value)
	{
		return new Vector4D(0.0 - value.X, 0.0 - value.Y, 0.0 - value.Z, 0.0 - value.W);
	}

	public static Vector4D operator *(Vector4D value, double scale)
	{
		return new Vector4D(value.X * scale, value.Y * scale, value.Z * scale, value.W * scale);
	}

	public static Vector4D operator *(double scale, Vector4D value)
	{
		return new Vector4D(value.X * scale, value.Y * scale, value.Z * scale, value.W * scale);
	}

	public static Vector4D operator /(Vector4D value, double scale)
	{
		return new Vector4D(value.X / scale, value.Y / scale, value.Z / scale, value.W / scale);
	}

	public static bool operator ==(Vector4D left, Vector4D right)
	{
		if (left.X == right.X && left.Y == right.Y && left.Z == right.Z)
		{
			return left.W == right.W;
		}
		return false;
	}

	public static bool operator !=(Vector4D left, Vector4D right)
	{
		if (left.X == right.X && left.Y == right.Y && left.Z == right.Z)
		{
			return left.W != right.W;
		}
		return true;
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1} Z:{2} W:{3}", X.ToString(CultureInfo.CurrentCulture), Y.ToString(CultureInfo.CurrentCulture), Z.ToString(CultureInfo.CurrentCulture), W.ToString(CultureInfo.CurrentCulture));
	}

	public override int GetHashCode()
	{
		return X.GetHashCode() + Y.GetHashCode() + Z.GetHashCode() + W.GetHashCode();
	}

	public override bool Equals(object value)
	{
		if (value == null)
		{
			return false;
		}
		if (value.GetType() != GetType())
		{
			return false;
		}
		return Equals((Vector4D)value);
	}

	public bool Equals(Vector4D value)
	{
		if (X == value.X && Y == value.Y && Z == value.Z)
		{
			return W == value.W;
		}
		return false;
	}

	public bool Equals(ref Vector4D value)
	{
		if (X == value.X && Y == value.Y && Z == value.Z)
		{
			return W == value.W;
		}
		return false;
	}
}
