using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 尾_猫 : 尾
    {
    	public Par X0Y0_尾0;

    	public Par X0Y0_尾1;

    	public Par X0Y0_尾2;

    	public Par X0Y0_尾3;

    	public Par X0Y0_尾4;

    	public Par X0Y0_尾5;

    	public Par X0Y0_尾6;

    	public Par X0Y0_尾7;

    	public Par X0Y0_尾8;

    	public Par X0Y0_尾9;

    	public Par X0Y0_尾10;

    	public Par X0Y0_尾11;

    	public Par X0Y0_尾12;

    	public Par X0Y0_尾13;

    	public ColorD 尾0CD;

    	public ColorD 尾1CD;

    	public ColorD 尾2CD;

    	public ColorD 尾3CD;

    	public ColorD 尾4CD;

    	public ColorD 尾5CD;

    	public ColorD 尾6CD;

    	public ColorD 尾7CD;

    	public ColorD 尾8CD;

    	public ColorD 尾9CD;

    	public ColorD 尾10CD;

    	public ColorD 尾11CD;

    	public ColorD 尾12CD;

    	public ColorD 尾13CD;

    	public ColorP X0Y0_尾0CP;

    	public ColorP X0Y0_尾1CP;

    	public ColorP X0Y0_尾2CP;

    	public ColorP X0Y0_尾3CP;

    	public ColorP X0Y0_尾4CP;

    	public ColorP X0Y0_尾5CP;

    	public ColorP X0Y0_尾6CP;

    	public ColorP X0Y0_尾7CP;

    	public ColorP X0Y0_尾8CP;

    	public ColorP X0Y0_尾9CP;

    	public ColorP X0Y0_尾10CP;

    	public ColorP X0Y0_尾11CP;

    	public ColorP X0Y0_尾12CP;

    	public ColorP X0Y0_尾13CP;

    	public Par[] Pars;

    	private Vector2D[] mm;

    	public override bool 欠損
    	{
    		get
    		{
    			return 欠損_;
    		}
    		set
    		{
    			欠損_ = value;
    		}
    	}

    	public override bool 筋肉
    	{
    		get
    		{
    			return 筋肉_;
    		}
    		set
    		{
    			筋肉_ = value;
    		}
    	}

    	public override bool 拘束
    	{
    		get
    		{
    			return 拘束_;
    		}
    		set
    		{
    			拘束_ = value;
    		}
    	}

    	public bool 尾0_表示
    	{
    		get
    		{
    			return X0Y0_尾0.Dra;
    		}
    		set
    		{
    			X0Y0_尾0.Dra = value;
    			X0Y0_尾0.Hit = value;
    		}
    	}

    	public bool 尾1_表示
    	{
    		get
    		{
    			return X0Y0_尾1.Dra;
    		}
    		set
    		{
    			X0Y0_尾1.Dra = value;
    			X0Y0_尾1.Hit = value;
    		}
    	}

    	public bool 尾2_表示
    	{
    		get
    		{
    			return X0Y0_尾2.Dra;
    		}
    		set
    		{
    			X0Y0_尾2.Dra = value;
    			X0Y0_尾2.Hit = value;
    		}
    	}

    	public bool 尾3_表示
    	{
    		get
    		{
    			return X0Y0_尾3.Dra;
    		}
    		set
    		{
    			X0Y0_尾3.Dra = value;
    			X0Y0_尾3.Hit = value;
    		}
    	}

    	public bool 尾4_表示
    	{
    		get
    		{
    			return X0Y0_尾4.Dra;
    		}
    		set
    		{
    			X0Y0_尾4.Dra = value;
    			X0Y0_尾4.Hit = value;
    		}
    	}

    	public bool 尾5_表示
    	{
    		get
    		{
    			return X0Y0_尾5.Dra;
    		}
    		set
    		{
    			X0Y0_尾5.Dra = value;
    			X0Y0_尾5.Hit = value;
    		}
    	}

    	public bool 尾6_表示
    	{
    		get
    		{
    			return X0Y0_尾6.Dra;
    		}
    		set
    		{
    			X0Y0_尾6.Dra = value;
    			X0Y0_尾6.Hit = value;
    		}
    	}

    	public bool 尾7_表示
    	{
    		get
    		{
    			return X0Y0_尾7.Dra;
    		}
    		set
    		{
    			X0Y0_尾7.Dra = value;
    			X0Y0_尾7.Hit = value;
    		}
    	}

    	public bool 尾8_表示
    	{
    		get
    		{
    			return X0Y0_尾8.Dra;
    		}
    		set
    		{
    			X0Y0_尾8.Dra = value;
    			X0Y0_尾8.Hit = value;
    		}
    	}

    	public bool 尾9_表示
    	{
    		get
    		{
    			return X0Y0_尾9.Dra;
    		}
    		set
    		{
    			X0Y0_尾9.Dra = value;
    			X0Y0_尾9.Hit = value;
    		}
    	}

    	public bool 尾10_表示
    	{
    		get
    		{
    			return X0Y0_尾10.Dra;
    		}
    		set
    		{
    			X0Y0_尾10.Dra = value;
    			X0Y0_尾10.Hit = value;
    		}
    	}

    	public bool 尾11_表示
    	{
    		get
    		{
    			return X0Y0_尾11.Dra;
    		}
    		set
    		{
    			X0Y0_尾11.Dra = value;
    			X0Y0_尾11.Hit = value;
    		}
    	}

    	public bool 尾12_表示
    	{
    		get
    		{
    			return X0Y0_尾12.Dra;
    		}
    		set
    		{
    			X0Y0_尾12.Dra = value;
    			X0Y0_尾12.Hit = value;
    		}
    	}

    	public bool 尾13_表示
    	{
    		get
    		{
    			return X0Y0_尾13.Dra;
    		}
    		set
    		{
    			X0Y0_尾13.Dra = value;
    			X0Y0_尾13.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 尾0_表示;
    		}
    		set
    		{
    			尾0_表示 = value;
    			尾1_表示 = value;
    			尾2_表示 = value;
    			尾3_表示 = value;
    			尾4_表示 = value;
    			尾5_表示 = value;
    			尾6_表示 = value;
    			尾7_表示 = value;
    			尾8_表示 = value;
    			尾9_表示 = value;
    			尾10_表示 = value;
    			尾11_表示 = value;
    			尾12_表示 = value;
    			尾13_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 尾0CD.不透明度;
    		}
    		set
    		{
    			尾0CD.不透明度 = value;
    			尾1CD.不透明度 = value;
    			尾2CD.不透明度 = value;
    			尾3CD.不透明度 = value;
    			尾4CD.不透明度 = value;
    			尾5CD.不透明度 = value;
    			尾6CD.不透明度 = value;
    			尾7CD.不透明度 = value;
    			尾8CD.不透明度 = value;
    			尾9CD.不透明度 = value;
    			尾10CD.不透明度 = value;
    			尾11CD.不透明度 = value;
    			尾12CD.不透明度 = value;
    			尾13CD.不透明度 = value;
    		}
    	}

    	public 尾_猫(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 尾_猫D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "猫尾";
    		dif.Add(new Pars(Sta.尻尾["尾"][0][0]));
    		本体 = new Difs();
    		本体.Tag = dif.Tag;
    		本体.Add(dif);
    		Pars pars = 本体[0][0];
    		X0Y0_尾0 = pars["尾0"].ToPar();
    		X0Y0_尾1 = pars["尾1"].ToPar();
    		X0Y0_尾2 = pars["尾2"].ToPar();
    		X0Y0_尾3 = pars["尾3"].ToPar();
    		X0Y0_尾4 = pars["尾4"].ToPar();
    		X0Y0_尾5 = pars["尾5"].ToPar();
    		X0Y0_尾6 = pars["尾6"].ToPar();
    		X0Y0_尾7 = pars["尾7"].ToPar();
    		X0Y0_尾8 = pars["尾8"].ToPar();
    		X0Y0_尾9 = pars["尾9"].ToPar();
    		X0Y0_尾10 = pars["尾10"].ToPar();
    		X0Y0_尾11 = pars["尾11"].ToPar();
    		X0Y0_尾12 = pars["尾12"].ToPar();
    		X0Y0_尾13 = pars["尾13"].ToPar();
    		本体.SetJoints();
    		接続根 = new JointD(本体);
    		右 = e.右;
    		反転X = e.反転X;
    		反転Y = e.反転Y;
    		基準C = e.基準C;
    		位置C = e.位置C;
    		角度B = e.角度B;
    		角度C = e.角度C;
    		尺度B = e.尺度B;
    		尺度C = e.尺度C;
    		尺度XB = e.尺度XB;
    		尺度XC = e.尺度XC;
    		尺度YB = e.尺度YB;
    		尺度YC = e.尺度YC;
    		肥大 = e.肥大;
    		身長 = e.身長;
    		Xv = e.Xv;
    		Yv = e.Yv;
    		Xi = e.Xi;
    		Yi = e.Yi;
    		サイズ = e.サイズ;
    		サイズX = e.サイズX;
    		サイズY = e.サイズY;
    		尾0_表示 = e.尾0_表示;
    		尾1_表示 = e.尾1_表示;
    		尾2_表示 = e.尾2_表示;
    		尾3_表示 = e.尾3_表示;
    		尾4_表示 = e.尾4_表示;
    		尾5_表示 = e.尾5_表示;
    		尾6_表示 = e.尾6_表示;
    		尾7_表示 = e.尾7_表示;
    		尾8_表示 = e.尾8_表示;
    		尾9_表示 = e.尾9_表示;
    		尾10_表示 = e.尾10_表示;
    		尾11_表示 = e.尾11_表示;
    		尾12_表示 = e.尾12_表示;
    		尾13_表示 = e.尾13_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		Pars = new Par[14]
    		{
    			X0Y0_尾0, X0Y0_尾1, X0Y0_尾2, X0Y0_尾3, X0Y0_尾4, X0Y0_尾5, X0Y0_尾6, X0Y0_尾7, X0Y0_尾8, X0Y0_尾9,
    			X0Y0_尾10, X0Y0_尾11, X0Y0_尾12, X0Y0_尾13
    		};
    		X0Y0_尾0CP = new ColorP(X0Y0_尾0, 尾0CD, DisUnit, abj: true);
    		X0Y0_尾1CP = new ColorP(X0Y0_尾1, 尾1CD, DisUnit, abj: true);
    		X0Y0_尾2CP = new ColorP(X0Y0_尾2, 尾2CD, DisUnit, abj: true);
    		X0Y0_尾3CP = new ColorP(X0Y0_尾3, 尾3CD, DisUnit, abj: true);
    		X0Y0_尾4CP = new ColorP(X0Y0_尾4, 尾4CD, DisUnit, abj: true);
    		X0Y0_尾5CP = new ColorP(X0Y0_尾5, 尾5CD, DisUnit, abj: true);
    		X0Y0_尾6CP = new ColorP(X0Y0_尾6, 尾6CD, DisUnit, abj: true);
    		X0Y0_尾7CP = new ColorP(X0Y0_尾7, 尾7CD, DisUnit, abj: true);
    		X0Y0_尾8CP = new ColorP(X0Y0_尾8, 尾8CD, DisUnit, abj: true);
    		X0Y0_尾9CP = new ColorP(X0Y0_尾9, 尾9CD, DisUnit, abj: true);
    		X0Y0_尾10CP = new ColorP(X0Y0_尾10, 尾10CD, DisUnit, abj: true);
    		X0Y0_尾11CP = new ColorP(X0Y0_尾11, 尾11CD, DisUnit, abj: true);
    		X0Y0_尾12CP = new ColorP(X0Y0_尾12, 尾12CD, DisUnit, abj: true);
    		X0Y0_尾13CP = new ColorP(X0Y0_尾13, 尾13CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		_ = 右;
    		double maxAngle = 20.0;
    		X0Y0_尾0.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾1.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾2.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾3.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾4.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾5.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾6.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾7.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾8.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾9.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾10.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾11.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾12.AngleBase = maxAngle.GetRanAngle();
    		X0Y0_尾13.AngleBase = maxAngle.GetRanAngle();
    		本体.JoinPAall();
    	}

    	public override IEnumerable<Par> Enum軸()
    	{
    		yield return X0Y0_尾0;
    		yield return X0Y0_尾1;
    		yield return X0Y0_尾2;
    		yield return X0Y0_尾3;
    		yield return X0Y0_尾4;
    		yield return X0Y0_尾5;
    		yield return X0Y0_尾6;
    		yield return X0Y0_尾7;
    		yield return X0Y0_尾8;
    		yield return X0Y0_尾9;
    		yield return X0Y0_尾10;
    		yield return X0Y0_尾11;
    		yield return X0Y0_尾12;
    		yield return X0Y0_尾13;
    	}

    	public override void 色更新()
    	{
    		Pars.GetMiY_MaY(out mm);
    		X0Y0_尾0CP.Update(mm);
    		X0Y0_尾1CP.Update(mm);
    		X0Y0_尾2CP.Update(mm);
    		X0Y0_尾3CP.Update(mm);
    		X0Y0_尾4CP.Update(mm);
    		X0Y0_尾5CP.Update(mm);
    		X0Y0_尾6CP.Update(mm);
    		X0Y0_尾7CP.Update(mm);
    		X0Y0_尾8CP.Update(mm);
    		X0Y0_尾9CP.Update(mm);
    		X0Y0_尾10CP.Update(mm);
    		X0Y0_尾11CP.Update(mm);
    		X0Y0_尾12CP.Update(mm);
    		X0Y0_尾13CP.Update(mm);
    	}

    	private void 配色(体配色 体配色)
    	{
    		switch (配色指定)
    		{
    		case 配色指定.N0:
    			配色N0(体配色);
    			break;
    		case 配色指定.T1:
    			配色T1(体配色);
    			break;
    		case 配色指定.T0:
    			配色T0(体配色);
    			break;
    		default:
    			配色N0(体配色);
    			break;
    		}
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		尾0CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		尾1CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		尾2CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		尾3CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		尾4CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		尾5CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		尾6CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		尾7CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		尾8CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		尾9CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		尾10CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		尾11CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		尾12CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		尾13CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    	}

    	private void 配色T1(体配色 体配色)
    	{
    		this.配色T(0, "尾", ref 体配色.毛0O, ref 体配色.刺青O);
    	}

    	private void 配色T0(体配色 体配色)
    	{
    		this.配色T(1, "尾", ref 体配色.毛0O, ref 体配色.刺青O);
    	}
    }
}
