using System;
using System.Globalization;

namespace _2DGAMELIB;

[Serializable]
public struct Vector3D
{
	public double X;

	public double Y;

	public double Z;

	public double this[int index]
	{
		get
		{
			return index switch
			{
				0 => X, 
				1 => Y, 
				2 => Z, 
				_ => throw new ArgumentOutOfRangeException("index", "Indices for Vector3D run from 0 to 2, inclusive."), 
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
			default:
				throw new ArgumentOutOfRangeException("index", "Indices for Vector3D run from 0 to 2, inclusive.");
			}
		}
	}

	public Vector3D(double value)
	{
		X = value;
		Y = value;
		Z = value;
	}

	public Vector3D(Vector2D value, double z)
	{
		X = value.X;
		Y = value.Y;
		Z = z;
	}

	public Vector3D(ref Vector2D value, double z)
	{
		X = value.X;
		Y = value.Y;
		Z = z;
	}

	public Vector3D(double x, double y, double z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public double Length()
	{
		return System.Math.Sqrt(X * X + Y * Y + Z * Z);
	}

	public double LengthSquared()
	{
		return X * X + Y * Y + Z * Z;
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
		}
	}

	public static Vector3D operator +(Vector3D left, Vector3D right)
	{
		return new Vector3D(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
	}

	public static Vector3D operator -(Vector3D left, Vector3D right)
	{
		return new Vector3D(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
	}

	public static Vector3D operator -(Vector3D value)
	{
		return new Vector3D(0.0 - value.X, 0.0 - value.Y, 0.0 - value.Z);
	}

	public static Vector3D operator *(Vector3D value, double scale)
	{
		return new Vector3D(value.X * scale, value.Y * scale, value.Z * scale);
	}

	public static Vector3D operator *(double scale, Vector3D value)
	{
		return new Vector3D(value.X * scale, value.Y * scale, value.Z * scale);
	}

	public static Vector3D operator /(Vector3D value, double scale)
	{
		return new Vector3D(value.X / scale, value.Y / scale, value.Z / scale);
	}

	public static bool operator ==(Vector3D left, Vector3D right)
	{
		if (left.X == right.X && left.Y == right.Y)
		{
			return left.Z == right.Z;
		}
		return false;
	}

	public static bool operator !=(Vector3D left, Vector3D right)
	{
		if (left.X == right.X && left.Y == right.Y)
		{
			return left.Z != right.Z;
		}
		return true;
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1} Z:{2}", new object[3]
		{
			X.ToString(CultureInfo.CurrentCulture),
			Y.ToString(CultureInfo.CurrentCulture),
			Z.ToString(CultureInfo.CurrentCulture)
		});
	}

	public override int GetHashCode()
	{
		return X.GetHashCode() + Y.GetHashCode() + Z.GetHashCode();
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
		return Equals((Vector3D)value);
	}

	public bool Equals(Vector3D value)
	{
		if (X == value.X && Y == value.Y)
		{
			return Z == value.Z;
		}
		return false;
	}

	public bool Equals(ref Vector3D value)
	{
		if (X == value.X && Y == value.Y)
		{
			return Z == value.Z;
		}
		return false;
	}
}
