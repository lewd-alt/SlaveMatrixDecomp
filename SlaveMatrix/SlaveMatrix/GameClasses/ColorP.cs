using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using _2DGAMELIB;

namespace SlaveMatrix;

[Serializable]
public class ColorP
{
	public Par Par;

	public ColorD ColorD;

	public double Unit;

	public bool abj;

	private Action p;

	private Action b;

	private LinearGradientBrush LGB;

	private double u0;

	private double u1;

	private float f0;

	private float f1;

	public ColorP(Par Par, ColorD ColorD, double Unit, bool abj)
	{
		this.Par = Par;
		this.ColorD = ColorD;
		this.Unit = Unit;
		this.abj = abj;
		Setting();
	}

	public void Setting()
	{
		Par.Brush = new SolidBrush(Color.LightGray);
		u0 = Unit * 0.99009900990099;
		u1 = Unit * 1.01;
		if (ColorD.線 == Col.Empty)
		{
			Par.Pen = null;
			p = delegate
			{
			};
		}
		else
		{
			if (abj)
			{
				Par.GetAlpha(out var ret);
				ColorD.線 = Color.FromArgb(ret, ColorD.線);
			}
			p = delegate
			{
				Par.PenColor = ColorD.線;
			};
			UpdateLine();
		}
		if (ColorD.色.Col1 == Col.Empty)
		{
			Par.Brush = null;
			b = delegate
			{
			};
		}
		else
		{
			if (ColorD.色.Col2 == Col.Empty)
			{
				b = delegate
				{
					Par.BrushColor = ColorD.色.Col1;
				};
			}
			else
			{
				Vector2D[] MM;
				float f0;
				float f1;
				b = delegate
				{
					Par.GetMiY_MaY(out MM);
					f0 = (float)(MM[0].Y * u0);
					f1 = (float)(MM[1].Y * u1);
					if (f0 >= 0f || f1 >= 0f)
					{
						LGB = new LinearGradientBrush(new PointF(0f, f0), new PointF(0f, f1), ColorD.色.Col1, ColorD.色.Col2);
						LGB.GammaCorrection = true;
						Par.Brush = LGB;
					}
				};
			}
			UpdateColor();
		}
		if (Par.Pen == null && Par.Brush == null)
		{
			Par.Dra = false;
			Par.Hit = false;
		}
	}

	public void UpdateLine()
	{
		p();
	}

	public void UpdateColor()
	{
		b();
	}

	public void Update()
	{
		if (Par.Dra)
		{
			p();
			b();
		}
	}

	public void Update(Vector2D[] mm)
	{
		if (Par.Dra)
		{
			p();
			f0 = (float)(mm[0].Y * u0);
			f1 = (float)(mm[1].Y * u1);
			if (f0 >= 0f || f1 >= 0f)
			{
				LGB = new LinearGradientBrush(new PointF(0f, f0), new PointF(0f, f1), ColorD.色.Col1, ColorD.色.Col2);
				LGB.GammaCorrection = true;
				Par.Brush = LGB;
			}
		}
	}
}
