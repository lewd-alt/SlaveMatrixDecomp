using System;
using System.Globalization;

namespace _2DGAMELIB
{
    [Serializable]
    public struct MatrixD
    {
    	public double M11;

    	public double M12;

    	public double M13;

    	public double M14;

    	public double M21;

    	public double M22;

    	public double M23;

    	public double M24;

    	public double M31;

    	public double M32;

    	public double M33;

    	public double M34;

    	public double M41;

    	public double M42;

    	public double M43;

    	public double M44;

    	public double this[int row, int col]
    	{
    		get
    		{
    			switch (row)
    			{
    			case 0:
    				switch (col)
    				{
    				case 0:
    					return M11;
    				case 1:
    					return M12;
    				case 2:
    					return M13;
    				case 3:
    					return M14;
    				default:
    					error(row, col);
    					return 0.0;
    				}
    			case 1:
    				switch (col)
    				{
    				case 0:
    					return M21;
    				case 1:
    					return M22;
    				case 2:
    					return M23;
    				case 3:
    					return M24;
    				default:
    					error(row, col);
    					return 0.0;
    				}
    			case 2:
    				switch (col)
    				{
    				case 0:
    					return M31;
    				case 1:
    					return M32;
    				case 2:
    					return M33;
    				case 3:
    					return M34;
    				default:
    					error(row, col);
    					return 0.0;
    				}
    			case 3:
    				switch (col)
    				{
    				case 0:
    					return M41;
    				case 1:
    					return M42;
    				case 2:
    					return M43;
    				case 3:
    					return M44;
    				default:
    					error(row, col);
    					return 0.0;
    				}
    			default:
    				error(row, col);
    				return 0.0;
    			}
    		}
    		set
    		{
    			switch (row)
    			{
    			case 0:
    				switch (col)
    				{
    				case 0:
    					M11 = value;
    					break;
    				case 1:
    					M12 = value;
    					break;
    				case 2:
    					M13 = value;
    					break;
    				case 3:
    					M14 = value;
    					break;
    				default:
    					error(row, col);
    					break;
    				}
    				break;
    			case 1:
    				switch (col)
    				{
    				case 0:
    					M21 = value;
    					break;
    				case 1:
    					M22 = value;
    					break;
    				case 2:
    					M23 = value;
    					break;
    				case 3:
    					M24 = value;
    					break;
    				default:
    					error(row, col);
    					break;
    				}
    				break;
    			case 2:
    				switch (col)
    				{
    				case 0:
    					M31 = value;
    					break;
    				case 1:
    					M32 = value;
    					break;
    				case 2:
    					M33 = value;
    					break;
    				case 3:
    					M34 = value;
    					break;
    				default:
    					error(row, col);
    					break;
    				}
    				break;
    			case 3:
    				switch (col)
    				{
    				case 0:
    					M41 = value;
    					break;
    				case 1:
    					M42 = value;
    					break;
    				case 2:
    					M43 = value;
    					break;
    				case 3:
    					M44 = value;
    					break;
    				default:
    					error(row, col);
    					break;
    				}
    				break;
    			default:
    				error(row, col);
    				break;
    			}
    		}
    	}

    	public static MatrixD Identity
    	{
    		get
    		{
    			MatrixD result = default(MatrixD);
    			result.M11 = 1.0;
    			result.M22 = 1.0;
    			result.M33 = 1.0;
    			result.M44 = 1.0;
    			return result;
    		}
    	}

    	public bool IsIdentity
    	{
    		get
    		{
    			if (M11 != 1.0 || M22 != 1.0 || M33 != 1.0 || M44 != 1.0)
    			{
    				return false;
    			}
    			if (M12 != 0.0 || M13 != 0.0 || M14 != 0.0 || M21 != 0.0 || M23 != 0.0 || M24 != 0.0 || M31 != 0.0 || M32 != 0.0 || M34 != 0.0 || M41 != 0.0 || M42 != 0.0 || M43 != 0.0)
    			{
    				return false;
    			}
    			return true;
    		}
    	}

    	public MatrixD(double M11, double M12, double M13, double M14, double M21, double M22, double M23, double M24, double M31, double M32, double M33, double M34, double M41, double M42, double M43, double M44)
    	{
    		this.M11 = M11;
    		this.M12 = M12;
    		this.M13 = M13;
    		this.M14 = M14;
    		this.M21 = M21;
    		this.M22 = M22;
    		this.M23 = M23;
    		this.M24 = M24;
    		this.M31 = M31;
    		this.M32 = M32;
    		this.M33 = M33;
    		this.M34 = M34;
    		this.M41 = M41;
    		this.M42 = M42;
    		this.M43 = M43;
    		this.M44 = M44;
    	}

    	private void error(int row, int col)
    	{
    		if (row < 0 || row > 3)
    		{
    			throw new ArgumentOutOfRangeException("row", "Rows and columns for matrices run from 0 to 3, inclusive.");
    		}
    		if (col < 0 || col > 3)
    		{
    			throw new ArgumentOutOfRangeException("col", "Rows and columns for matrices run from 0 to 3, inclusive.");
    		}
    	}

    	public Vector4D GetRow(int row)
    	{
    		return new Vector4D(this[row, 0], this[row, 1], this[row, 2], this[row, 3]);
    	}

    	public void SetRow(int row, Vector4D value)
    	{
    		this[row, 0] = value.X;
    		this[row, 1] = value.Y;
    		this[row, 2] = value.Z;
    		this[row, 3] = value.W;
    	}

    	public void SetRow(int row, ref Vector4D value)
    	{
    		this[row, 0] = value.X;
    		this[row, 1] = value.Y;
    		this[row, 2] = value.Z;
    		this[row, 3] = value.W;
    	}

    	public Vector4D GetCol(int column)
    	{
    		return new Vector4D(this[0, column], this[1, column], this[2, column], this[3, column]);
    	}

    	public void SetCol(int column, Vector4D value)
    	{
    		this[0, column] = value.X;
    		this[1, column] = value.Y;
    		this[2, column] = value.Z;
    		this[3, column] = value.W;
    	}

    	public void SetCol(int column, ref Vector4D value)
    	{
    		this[0, column] = value.X;
    		this[1, column] = value.Y;
    		this[2, column] = value.Z;
    		this[3, column] = value.W;
    	}

    	public double[] ToArray()
    	{
    		return new double[16]
    		{
    			M11, M12, M13, M14, M21, M22, M23, M24, M31, M32,
    			M33, M34, M41, M42, M43, M44
    		};
    	}

    	public void Invert()
    	{
    		MatrixD matDIdentity = Dat.MatDIdentity;
    		for (int i = 0; i < 4; i++)
    		{
    			double num = 1.0 / this[i, i];
    			for (int j = 0; j < 4; j++)
    			{
    				this[i, j] *= num;
    				matDIdentity[i, j] *= num;
    			}
    			for (int j = 0; j < 4; j++)
    			{
    				if (i != j)
    				{
    					num = this[j, i];
    					for (int k = 0; k < 4; k++)
    					{
    						this[j, k] -= this[i, k] * num;
    						matDIdentity[j, k] -= matDIdentity[i, k] * num;
    					}
    				}
    			}
    		}
    		this = matDIdentity;
    	}

    	public double Determinant()
    	{
    		double num = M33 * M44 - M34 * M43;
    		double num2 = M32 * M44 - M34 * M42;
    		double num3 = M32 * M43 - M33 * M42;
    		double num4 = M31 * M44 - M34 * M41;
    		double num5 = M31 * M43 - M33 * M41;
    		double num6 = M31 * M42 - M32 * M41;
    		return M11 * (M22 * num - M23 * num2 + M24 * num3) - M12 * (M21 * num - M23 * num4 + M24 * num5) + M13 * (M21 * num2 - M22 * num4 + M24 * num6) - M14 * (M21 * num3 - M22 * num5 + M23 * num6);
    	}

    	public static MatrixD operator +(MatrixD left, MatrixD right)
    	{
    		MatrixD result = default(MatrixD);
    		result.M11 = left.M11 + right.M11;
    		result.M12 = left.M12 + right.M12;
    		result.M13 = left.M13 + right.M13;
    		result.M14 = left.M14 + right.M14;
    		result.M21 = left.M21 + right.M21;
    		result.M22 = left.M22 + right.M22;
    		result.M23 = left.M23 + right.M23;
    		result.M24 = left.M24 + right.M24;
    		result.M31 = left.M31 + right.M31;
    		result.M32 = left.M32 + right.M32;
    		result.M33 = left.M33 + right.M33;
    		result.M34 = left.M34 + right.M34;
    		result.M41 = left.M41 + right.M41;
    		result.M42 = left.M42 + right.M42;
    		result.M43 = left.M43 + right.M43;
    		result.M44 = left.M44 + right.M44;
    		return result;
    	}

    	public static MatrixD operator -(MatrixD left, MatrixD right)
    	{
    		MatrixD result = default(MatrixD);
    		result.M11 = left.M11 - right.M11;
    		result.M12 = left.M12 - right.M12;
    		result.M13 = left.M13 - right.M13;
    		result.M14 = left.M14 - right.M14;
    		result.M21 = left.M21 - right.M21;
    		result.M22 = left.M22 - right.M22;
    		result.M23 = left.M23 - right.M23;
    		result.M24 = left.M24 - right.M24;
    		result.M31 = left.M31 - right.M31;
    		result.M32 = left.M32 - right.M32;
    		result.M33 = left.M33 - right.M33;
    		result.M34 = left.M34 - right.M34;
    		result.M41 = left.M41 - right.M41;
    		result.M42 = left.M42 - right.M42;
    		result.M43 = left.M43 - right.M43;
    		result.M44 = left.M44 - right.M44;
    		return result;
    	}

    	public static MatrixD operator -(MatrixD matrix)
    	{
    		MatrixD result = default(MatrixD);
    		result.M11 = 0.0 - matrix.M11;
    		result.M12 = 0.0 - matrix.M12;
    		result.M13 = 0.0 - matrix.M13;
    		result.M14 = 0.0 - matrix.M14;
    		result.M21 = 0.0 - matrix.M21;
    		result.M22 = 0.0 - matrix.M22;
    		result.M23 = 0.0 - matrix.M23;
    		result.M24 = 0.0 - matrix.M24;
    		result.M31 = 0.0 - matrix.M31;
    		result.M32 = 0.0 - matrix.M32;
    		result.M33 = 0.0 - matrix.M33;
    		result.M34 = 0.0 - matrix.M34;
    		result.M41 = 0.0 - matrix.M41;
    		result.M42 = 0.0 - matrix.M42;
    		result.M43 = 0.0 - matrix.M43;
    		result.M44 = 0.0 - matrix.M44;
    		return result;
    	}

    	public static MatrixD operator *(MatrixD left, MatrixD right)
    	{
    		MatrixD result = default(MatrixD);
    		result.M11 = left.M11 * right.M11 + left.M12 * right.M21 + left.M13 * right.M31 + left.M14 * right.M41;
    		result.M12 = left.M11 * right.M12 + left.M12 * right.M22 + left.M13 * right.M32 + left.M14 * right.M42;
    		result.M13 = left.M11 * right.M13 + left.M12 * right.M23 + left.M13 * right.M33 + left.M14 * right.M43;
    		result.M14 = left.M11 * right.M14 + left.M12 * right.M24 + left.M13 * right.M34 + left.M14 * right.M44;
    		result.M21 = left.M21 * right.M11 + left.M22 * right.M21 + left.M23 * right.M31 + left.M24 * right.M41;
    		result.M22 = left.M21 * right.M12 + left.M22 * right.M22 + left.M23 * right.M32 + left.M24 * right.M42;
    		result.M23 = left.M21 * right.M13 + left.M22 * right.M23 + left.M23 * right.M33 + left.M24 * right.M43;
    		result.M24 = left.M21 * right.M14 + left.M22 * right.M24 + left.M23 * right.M34 + left.M24 * right.M44;
    		result.M31 = left.M31 * right.M11 + left.M32 * right.M21 + left.M33 * right.M31 + left.M34 * right.M41;
    		result.M32 = left.M31 * right.M12 + left.M32 * right.M22 + left.M33 * right.M32 + left.M34 * right.M42;
    		result.M33 = left.M31 * right.M13 + left.M32 * right.M23 + left.M33 * right.M33 + left.M34 * right.M43;
    		result.M34 = left.M31 * right.M14 + left.M32 * right.M24 + left.M33 * right.M34 + left.M34 * right.M44;
    		result.M41 = left.M41 * right.M11 + left.M42 * right.M21 + left.M43 * right.M31 + left.M44 * right.M41;
    		result.M42 = left.M41 * right.M12 + left.M42 * right.M22 + left.M43 * right.M32 + left.M44 * right.M42;
    		result.M43 = left.M41 * right.M13 + left.M42 * right.M23 + left.M43 * right.M33 + left.M44 * right.M43;
    		result.M44 = left.M41 * right.M14 + left.M42 * right.M24 + left.M43 * right.M34 + left.M44 * right.M44;
    		return result;
    	}

    	public static MatrixD operator *(MatrixD left, double right)
    	{
    		MatrixD result = default(MatrixD);
    		result.M11 = left.M11 * right;
    		result.M12 = left.M12 * right;
    		result.M13 = left.M13 * right;
    		result.M14 = left.M14 * right;
    		result.M21 = left.M21 * right;
    		result.M22 = left.M22 * right;
    		result.M23 = left.M23 * right;
    		result.M24 = left.M24 * right;
    		result.M31 = left.M31 * right;
    		result.M32 = left.M32 * right;
    		result.M33 = left.M33 * right;
    		result.M34 = left.M34 * right;
    		result.M41 = left.M41 * right;
    		result.M42 = left.M42 * right;
    		result.M43 = left.M43 * right;
    		result.M44 = left.M44 * right;
    		return result;
    	}

    	public static MatrixD operator *(double right, MatrixD left)
    	{
    		MatrixD result = default(MatrixD);
    		result.M11 = left.M11 * right;
    		result.M12 = left.M12 * right;
    		result.M13 = left.M13 * right;
    		result.M14 = left.M14 * right;
    		result.M21 = left.M21 * right;
    		result.M22 = left.M22 * right;
    		result.M23 = left.M23 * right;
    		result.M24 = left.M24 * right;
    		result.M31 = left.M31 * right;
    		result.M32 = left.M32 * right;
    		result.M33 = left.M33 * right;
    		result.M34 = left.M34 * right;
    		result.M41 = left.M41 * right;
    		result.M42 = left.M42 * right;
    		result.M43 = left.M43 * right;
    		result.M44 = left.M44 * right;
    		return result;
    	}

    	public static MatrixD operator /(MatrixD left, MatrixD right)
    	{
    		MatrixD result = default(MatrixD);
    		result.M11 = left.M11 / right.M11;
    		result.M12 = left.M12 / right.M12;
    		result.M13 = left.M13 / right.M13;
    		result.M14 = left.M14 / right.M14;
    		result.M21 = left.M21 / right.M21;
    		result.M22 = left.M22 / right.M22;
    		result.M23 = left.M23 / right.M23;
    		result.M24 = left.M24 / right.M24;
    		result.M31 = left.M31 / right.M31;
    		result.M32 = left.M32 / right.M32;
    		result.M33 = left.M33 / right.M33;
    		result.M34 = left.M34 / right.M34;
    		result.M41 = left.M41 / right.M41;
    		result.M42 = left.M42 / right.M42;
    		result.M43 = left.M43 / right.M43;
    		result.M44 = left.M44 / right.M44;
    		return result;
    	}

    	public static MatrixD operator /(MatrixD left, double right)
    	{
    		MatrixD result = default(MatrixD);
    		result.M11 = left.M11 / right;
    		result.M12 = left.M12 / right;
    		result.M13 = left.M13 / right;
    		result.M14 = left.M14 / right;
    		result.M21 = left.M21 / right;
    		result.M22 = left.M22 / right;
    		result.M23 = left.M23 / right;
    		result.M24 = left.M24 / right;
    		result.M31 = left.M31 / right;
    		result.M32 = left.M32 / right;
    		result.M33 = left.M33 / right;
    		result.M34 = left.M34 / right;
    		result.M41 = left.M41 / right;
    		result.M42 = left.M42 / right;
    		result.M43 = left.M43 / right;
    		result.M44 = left.M44 / right;
    		return result;
    	}

    	public static bool operator ==(MatrixD left, MatrixD right)
    	{
    		if (left.M11 == right.M11 && left.M12 == right.M12 && left.M13 == right.M13 && left.M14 == right.M14 && left.M21 == right.M21 && left.M22 == right.M22 && left.M23 == right.M23 && left.M24 == right.M24 && left.M31 == right.M31 && left.M32 == right.M32 && left.M33 == right.M33 && left.M34 == right.M34 && left.M41 == right.M41 && left.M42 == right.M42 && left.M43 == right.M43)
    		{
    			return left.M44 == right.M44;
    		}
    		return false;
    	}

    	public static bool operator !=(MatrixD left, MatrixD right)
    	{
    		if (left.M11 == right.M11 && left.M12 == right.M12 && left.M13 == right.M13 && left.M14 == right.M14 && left.M21 == right.M21 && left.M22 == right.M22 && left.M23 == right.M23 && left.M24 == right.M24 && left.M31 == right.M31 && left.M32 == right.M32 && left.M33 == right.M33 && left.M34 == right.M34 && left.M41 == right.M41 && left.M42 == right.M42 && left.M43 == right.M43)
    		{
    			return left.M44 != right.M44;
    		}
    		return true;
    	}

    	public override string ToString()
    	{
    		return string.Format(CultureInfo.CurrentCulture, "[M11:{0} M12:{1} M13:{2} M14:{3}] [M21:{4} M22:{5} M23:{6} M24:{7}] [M31:{8} M32:{9} M33:{10} M34:{11}] [M41:{12} M42:{13} M43:{14} M44:{15}]", M11.ToString(CultureInfo.CurrentCulture), M12.ToString(CultureInfo.CurrentCulture), M13.ToString(CultureInfo.CurrentCulture), M14.ToString(CultureInfo.CurrentCulture), M21.ToString(CultureInfo.CurrentCulture), M22.ToString(CultureInfo.CurrentCulture), M23.ToString(CultureInfo.CurrentCulture), M24.ToString(CultureInfo.CurrentCulture), M31.ToString(CultureInfo.CurrentCulture), M32.ToString(CultureInfo.CurrentCulture), M33.ToString(CultureInfo.CurrentCulture), M34.ToString(CultureInfo.CurrentCulture), M41.ToString(CultureInfo.CurrentCulture), M42.ToString(CultureInfo.CurrentCulture), M43.ToString(CultureInfo.CurrentCulture), M44.ToString(CultureInfo.CurrentCulture));
    	}

    	public override int GetHashCode()
    	{
    		return M11.GetHashCode() + M12.GetHashCode() + M13.GetHashCode() + M14.GetHashCode() + M21.GetHashCode() + M22.GetHashCode() + M23.GetHashCode() + M24.GetHashCode() + M31.GetHashCode() + M32.GetHashCode() + M33.GetHashCode() + M34.GetHashCode() + M41.GetHashCode() + M42.GetHashCode() + M43.GetHashCode() + M44.GetHashCode();
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
    		return Equals((MatrixD)value);
    	}

    	public bool Equals(MatrixD value)
    	{
    		if (M11 == value.M11 && M12 == value.M12 && M13 == value.M13 && M14 == value.M14 && M21 == value.M21 && M22 == value.M22 && M23 == value.M23 && M24 == value.M24 && M31 == value.M31 && M32 == value.M32 && M33 == value.M33 && M34 == value.M34 && M41 == value.M41 && M42 == value.M42 && M43 == value.M43)
    		{
    			return M44 == value.M44;
    		}
    		return false;
    	}

    	public bool Equals(ref MatrixD value)
    	{
    		if (M11 == value.M11 && M12 == value.M12 && M13 == value.M13 && M14 == value.M14 && M21 == value.M21 && M22 == value.M22 && M23 == value.M23 && M24 == value.M24 && M31 == value.M31 && M32 == value.M32 && M33 == value.M33 && M34 == value.M34 && M41 == value.M41 && M42 == value.M42 && M43 == value.M43)
    		{
    			return M44 == value.M44;
    		}
    		return false;
    	}
    }
}
