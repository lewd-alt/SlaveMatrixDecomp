using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2DGAMELIB
{
    public class AreM : Are
    {
    	private double strength;

    	private double unitS;

    	public AreM(double Unit, double XRatio, double YRatio, double Size, double DisMag, double HitMag, double Strength)
    	{
    		Setting(Unit, XRatio, YRatio, Size, DisMag, HitMag, Strength);
    	}

    	private void Setting(double Unit, double XRatio, double YRatio, double Size, double DisMag, double HitMag, double Strength)
    	{
    		SetXYRatio(XRatio, YRatio);
    		base.Size = Size;
    		unit = Unit;
    		strength = Strength;
    		disUnit = Unit * DisMag;
    		double num = 1.0 - Strength;
    		unitS = disUnit * num;
    		WH.Width = (int)(base.LocalWidth * Unit);
    		WH.Height = (int)(base.LocalHeight * Unit);
    		WHA.Width = (int)(base.LocalWidth * disUnit);
    		WHA.Height = (int)(base.LocalHeight * disUnit);
    		Dis = new Bitmap((int)((double)WH.Width * DisMag * num), (int)((double)WH.Height * DisMag * num));
    		gd = Graphics.FromImage(Dis);
    		gd.SmoothingMode = SmoothingMode.None;
    		gd.PixelOffsetMode = PixelOffsetMode.None;
    		hitUnit = Unit * HitMag;
    		WHH.Width = (int)(base.LocalWidth * hitUnit);
    		WHH.Height = (int)(base.LocalHeight * hitUnit);
    		Hit = new Bitmap(WHH.Width, WHH.Height);
    		gh = Graphics.FromImage(Hit);
    		gh.SmoothingMode = SmoothingMode.None;
    		gh.PixelOffsetMode = PixelOffsetMode.None;
    	}

    	public new void Draw(ParT ParT)
    	{
    		ParT.Draw(unitS, gd);
    		if (gh != null)
    		{
    			ParT.DrawH(hitUnit, gh);
    		}
    	}

    	public new void Draw(Pars Pars)
    	{
    		Pars.Draw(unitS, gd);
    		if (gh != null)
    		{
    			Pars.DrawH(hitUnit, gh);
    		}
    	}
    	public new void Draw(Graphics GD)
    	{
    		im = GD.InterpolationMode;
    		GD.InterpolationMode = InterpolationMode.NearestNeighbor;
    		p = GetPosition();
    		GD.DrawImage(Dis, (int)(p.X * unit), (int)(p.Y * unit), WH.Width, WH.Height);
    		GD.InterpolationMode = im;
    	}

    	public new void Draw(Graphics GD, double Opacity)
    	{
    		im = GD.InterpolationMode;
    		GD.InterpolationMode = InterpolationMode.NearestNeighbor;
    		cm.Matrix33 = (float)Opacity;
    		ia.SetColorMatrix(cm);
    		p = GetPosition();
    		r.X = (int)(p.X * unit);
    		r.Y = (int)(p.Y * unit);
    		r.Width = WH.Width;
    		r.Height = WH.Height;
    		GD.DrawImage(Dis, r, 0, 0, Dis.Width, Dis.Height, GraphicsUnit.Pixel, ia);
    		GD.InterpolationMode = im;
    	}

    }
}
