using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using Newtonsoft.Json;

namespace _2DGAMELIB
{
    // renders text
    [Serializable]
    public class ParT : Par
    {
    	[NonSerialized, JsonIgnore]
    	private Font font = new Font("", 1f);

    	private double fontSize = 1.0;

    	private bool EditF = true;

    	[NonSerialized, JsonIgnore]
    	private Brush brusht = new SolidBrush(Color.Black);

    	private const double Shift = 1.0;

    	[NonSerialized, JsonIgnore]
    	private Brush brushs;

    	[NonSerialized, JsonIgnore]
    	private StringFormat stringformat = new StringFormat();

    	private Vector2D positionT = Dat.Vec2DZero;

    	private Vector2D rectSize = Dat.Vec2DOne;

    	public string Text = "";

    	private RectangleF rect;

    	private double us;

    	private double usx;

    	private double usy;

    	private Vector2D bp;

    	private Vector2D p;

    	private Vector2D v;

    	private double a0;

    	private double a1;

    	private double M11;

    	private double M12;

    	private float af;

    	private float xf;

    	private float yf;

    	private bool EditT = true;

    	private bool EditTS = true;

    	private CharacterRange[] crr = new CharacterRange[1];

    	private CharacterRange[] cre = new CharacterRange[1];

    	public Font Font
    	{
    		get
    		{
    			return font;
    		}
    		set
    		{
    			if (font != value && font != null)
    			{
    				font.Dispose();
    			}
    			font = value;
    			EditF = true;
    		}
    	}

    	public double FontSize
    	{
    		get
    		{
    			return fontSize;
    		}
    		set
    		{
    			fontSize = value;
    			EditF = true;
    		}
    	}

    	public Brush TextBrush
    	{
    		get
    		{
    			return brusht;
    		}
    		set
    		{
    			if (brusht != value && brusht != null)
    			{
    				brusht.Dispose();
    			}
    			brusht = value;
    		}
    	}

    	public Color TextColor
    	{
    		get
    		{
    			return ((SolidBrush)brusht).Color;
    		}
    		set
    		{
    			((SolidBrush)brusht).Color = value;
    		}
    	}

    	public Brush ShadBrush
    	{
    		get
    		{
    			return brushs;
    		}
    		set
    		{
    			if (brushs != value && brushs != null)
    			{
    				brushs.Dispose();
    			}
    			brushs = value;
    		}
    	}

    	public Color ShadColor
    	{
    		get
    		{
    			return ((SolidBrush)brushs).Color;
    		}
    		set
    		{
    			((SolidBrush)brushs).Color = value;
    		}
    	}

    	public StringFormat StringFormat
    	{
    		get
    		{
    			return stringformat;
    		}
    		set
    		{
    			if (stringformat != value && stringformat != null)
    			{
    				stringformat.Dispose();
    			}
    			stringformat = value;
    		}
    	}

    	public Vector2D PositionT
    	{
    		get
    		{
    			return positionT;
    		}
    		set
    		{
    			positionT = value;
    			EditT = true;
    		}
    	}

    	public Vector2D RectSize
    	{
    		get
    		{
    			return rectSize;
    		}
    		set
    		{
    			rectSize = value;
    			EditT = true;
    		}
    	}

    	public new void SetDefault()
    	{
    		base.SetDefault();
    		font = new Font("", 1f);
    		brusht = new SolidBrush(Color.Black);
    		brushs = null;
    		stringformat = new StringFormat();
    	}

    	public ParT()
    	{
    	}


    	public ParT(ParT ParT)
    	{
    		CopyT(ParT);
    	}

    	private void CopyT(ParT ParT)
    	{
    		Copy(ParT);
    		fontSize = ParT.fontSize;
    		if (ParT.font != null)
    		{
    			Font = ParT.font.Copy();
    		}
    		if (ParT.brusht != null)
    		{
    			TextBrush = ParT.brusht.Copy();
    		}
    		if (ParT.brushs != null)
    		{
    			ShadBrush = ParT.brushs.Copy();
    		}
    		if (ParT.stringformat != null)
    		{
    			StringFormat = ParT.stringformat.Copy();
    		}
    		positionT = ParT.positionT;
    		rectSize = ParT.rectSize;
    		Text = ParT.Text;
    	}

    	public new void Draw(double Unit, Graphics Graphics)
    	{
    		if (Edit)
    		{
    			EditT = true;
    		}
    		if (EditS || EditPS)
    		{
    			EditTS = true;
    		}
    		base.Draw(Unit, Graphics);
    		DrawString(Unit, Graphics);
    	}

    	private void Calculation(double Unit)
    	{
    		us = Unit * base.Size;
    		usx = us * base.SizeX;
    		usy = us * base.SizeY;
    		bp = base.BasePoint;
    		bp.X *= usx;
    		bp.Y *= usy;
    		a0 = base.Angle;
            a1 = System.Math.PI * a0 / 180.0;
            M11 = System.Math.Cos(a1);
            M12 = System.Math.Sin(a1);
    		v.X = bp.X * M11 + bp.Y * (0.0 - M12);
    		v.Y = bp.X * M12 + bp.Y * M11;
    		p = base.Position;
    		bp.X = p.X * Unit - v.X;
    		bp.Y = p.Y * Unit - v.Y;
    		rect.X = (float)(positionT.X * us);
    		rect.Y = (float)(positionT.Y * us);
    		rect.Width = (float)(rectSize.X * us);
    		rect.Height = (float)(rectSize.Y * us);
    	}

    	private void DrawString(double Unit, Graphics Graphics)
    	{
    		if (EditT)
    		{
    			Calculation(Unit);
    			EditT = false;
    		}
    		if (EditF || EditTS)
    		{
    			Font = new Font(font.FontFamily, (float)(us * fontSize * Med.DpiY));
    			EditF = false;
    			EditTS = false;
    		}
    		af = (float)a0;
    		xf = (float)base.SizeX;
    		yf = (float)base.SizeY;
    		if (brushs != null)
    		{
    			Graphics.TranslateTransform((float)(bp.X + 1.0), (float)(bp.Y + 1.0));
    			Graphics.RotateTransform(af);
    			Graphics.ScaleTransform(xf, yf);
    			Graphics.DrawString(Text, font, brushs, rect, stringformat);
    			Graphics.ResetTransform();
    		}
    		Graphics.TranslateTransform((float)bp.X, (float)bp.Y);
    		Graphics.RotateTransform(af);
    		Graphics.ScaleTransform(xf, yf);
    		Graphics.DrawString(Text, font, brusht, rect, stringformat);
            Graphics.ResetTransform();
    	}

    	public Vector2D_2 GetStringRect(double Unit, Graphics Graphics)
    	{
    		double num = Unit * base.Size;
    		if (EditF || EditS || EditPS || EditTS)
    		{
    			Font = new Font(font.FontFamily, (float)(num * fontSize * Med.DpiY));
    			EditF = false;
    			EditTS = false;
    		}
    		crr[0] = new CharacterRange(0, Text.Length);
    		stringformat.SetMeasurableCharacterRanges(crr);
    		RectangleF bounds = Graphics.MeasureCharacterRanges(Text, font, new RectangleF((float)(positionT.X * num), (float)(positionT.Y * num), (float)(rectSize.X * num), (float)(rectSize.Y * num)), stringformat)[0].GetBounds(Graphics);
    		return new Vector2D_2(new Vector2D((double)bounds.X / num, (double)bounds.Y / num), new Vector2D((double)bounds.Width / num, (double)bounds.Height / num));
    	}

    	public Vector2D[] GetStringRectPoints(double Unit, Graphics Graphics)
    	{
    		Vector2D_2 stringRect = GetStringRect(Unit, Graphics);
    		stringRect.v2.X *= 1.07;
    		return new Vector2D[4]
    		{
    			stringRect.v1,
    			new Vector2D(stringRect.v2.X, stringRect.v1.Y),
    			stringRect.v2,
    			new Vector2D(stringRect.v1.X, stringRect.v2.Y)
    		};
    	}
    	public void SetStringRectOutline(double Unit, Graphics Graphics)
    	{
    		Vector2D[] stringRectPoints = GetStringRectPoints(Unit, Graphics);
    		Out @out = new Out
    		{
    			Tension = 0f
    		};
    		Vector2D vector2D = Dat.Vec2DZero - stringRectPoints[0];
    		double x = 0.05;
    		double num = 0.025;
    		@out.ps.Add(stringRectPoints[0].AddY(0.0 - num) + vector2D);
    		@out.ps.Add(stringRectPoints[1].AddXY(x, 0.0 - num) + vector2D);
    		@out.ps.Add(stringRectPoints[2].AddXY(x, num) + vector2D);
    		@out.ps.Add(stringRectPoints[3].AddY(num) + vector2D);
    		base.OP.Add(@out);
    	}
    	public new void Dispose()
    	{
    		base.Dispose();
    		if (font != null)
    		{
    			font.Dispose();
    		}
    		if (brusht != null)
    		{
    			brusht.Dispose();
    		}
    		if (brushs != null)
    		{
    			brushs.Dispose();
    		}
    		if (stringformat != null)
    		{
    			stringformat.Dispose();
    		}
    	}
    }
}
