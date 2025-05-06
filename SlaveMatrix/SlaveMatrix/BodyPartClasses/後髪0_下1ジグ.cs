using _2DGAMELIB;

namespace SlaveMatrix;

public class 後髪0_下1ジグ : お下げ1
{
	public Par X0Y0_髪基;

	public Par X0Y0_お下げ_髪節;

	public Par X0Y0_お下げ_髪縛1;

	public Par X0Y0_お下げ_髪縛2;

	public Par X0Y0_お下げ_髪左2;

	public Par X0Y0_お下げ_髪左1;

	public Par X0Y0_お下げ_髪右2;

	public Par X0Y0_お下げ_髪右1;

	public Par X0Y0_お下げ_髪根;

	public ColorD 髪基CD;

	public ColorD お下げ_髪節CD;

	public ColorD お下げ_髪縛1CD;

	public ColorD お下げ_髪縛2CD;

	public ColorD お下げ_髪左2CD;

	public ColorD お下げ_髪左1CD;

	public ColorD お下げ_髪右2CD;

	public ColorD お下げ_髪右1CD;

	public ColorD お下げ_髪根CD;

	public ColorP X0Y0_髪基CP;

	public ColorP X0Y0_お下げ_髪節CP;

	public ColorP X0Y0_お下げ_髪縛1CP;

	public ColorP X0Y0_お下げ_髪縛2CP;

	public ColorP X0Y0_お下げ_髪左2CP;

	public ColorP X0Y0_お下げ_髪左1CP;

	public ColorP X0Y0_お下げ_髪右2CP;

	public ColorP X0Y0_お下げ_髪右1CP;

	public ColorP X0Y0_お下げ_髪根CP;

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

	public bool 髪基_表示
	{
		get
		{
			return X0Y0_髪基.Dra;
		}
		set
		{
			X0Y0_髪基.Dra = value;
			X0Y0_髪基.Hit = value;
		}
	}

	public bool お下げ_髪節_表示
	{
		get
		{
			return X0Y0_お下げ_髪節.Dra;
		}
		set
		{
			X0Y0_お下げ_髪節.Dra = value;
			X0Y0_お下げ_髪節.Hit = value;
		}
	}

	public override bool お下げ_髪縛1_表示
	{
		get
		{
			return X0Y0_お下げ_髪縛1.Dra;
		}
		set
		{
			X0Y0_お下げ_髪縛1.Dra = value;
			X0Y0_お下げ_髪縛1.Hit = value;
		}
	}

	public override bool お下げ_髪縛2_表示
	{
		get
		{
			return X0Y0_お下げ_髪縛2.Dra;
		}
		set
		{
			X0Y0_お下げ_髪縛2.Dra = value;
			X0Y0_お下げ_髪縛2.Hit = value;
		}
	}

	public bool お下げ_髪左2_表示
	{
		get
		{
			return X0Y0_お下げ_髪左2.Dra;
		}
		set
		{
			X0Y0_お下げ_髪左2.Dra = value;
			X0Y0_お下げ_髪左2.Hit = value;
		}
	}

	public bool お下げ_髪左1_表示
	{
		get
		{
			return X0Y0_お下げ_髪左1.Dra;
		}
		set
		{
			X0Y0_お下げ_髪左1.Dra = value;
			X0Y0_お下げ_髪左1.Hit = value;
		}
	}

	public bool お下げ_髪右2_表示
	{
		get
		{
			return X0Y0_お下げ_髪右2.Dra;
		}
		set
		{
			X0Y0_お下げ_髪右2.Dra = value;
			X0Y0_お下げ_髪右2.Hit = value;
		}
	}

	public bool お下げ_髪右1_表示
	{
		get
		{
			return X0Y0_お下げ_髪右1.Dra;
		}
		set
		{
			X0Y0_お下げ_髪右1.Dra = value;
			X0Y0_お下げ_髪右1.Hit = value;
		}
	}

	public bool お下げ_髪根_表示
	{
		get
		{
			return X0Y0_お下げ_髪根.Dra;
		}
		set
		{
			X0Y0_お下げ_髪根.Dra = value;
			X0Y0_お下げ_髪根.Hit = value;
		}
	}

	public override bool 表示
	{
		get
		{
			return 髪基_表示;
		}
		set
		{
			髪基_表示 = value;
			お下げ_髪節_表示 = value;
			お下げ_髪縛1_表示 = value;
			お下げ_髪縛2_表示 = value;
			お下げ_髪左2_表示 = value;
			お下げ_髪左1_表示 = value;
			お下げ_髪右2_表示 = value;
			お下げ_髪右1_表示 = value;
			お下げ_髪根_表示 = value;
		}
	}

	public override double 濃度
	{
		get
		{
			return 髪基CD.不透明度;
		}
		set
		{
			髪基CD.不透明度 = value;
			お下げ_髪節CD.不透明度 = value;
			お下げ_髪縛1CD.不透明度 = value;
			お下げ_髪縛2CD.不透明度 = value;
			お下げ_髪左2CD.不透明度 = value;
			お下げ_髪左1CD.不透明度 = value;
			お下げ_髪右2CD.不透明度 = value;
			お下げ_髪右1CD.不透明度 = value;
			お下げ_髪根CD.不透明度 = value;
		}
	}

	public double 髪長0
	{
		set
		{
			double num = 0.7 + 0.3 * value;
			X0Y0_髪基.SizeYBase *= num;
		}
	}

	public double 髪長1
	{
		set
		{
			double num = 0.5 + 0.9 * value;
			X0Y0_お下げ_髪節.SizeYBase *= num;
			X0Y0_お下げ_髪右2.SizeYBase *= num;
			X0Y0_お下げ_髪右1.SizeYBase *= num;
			X0Y0_お下げ_髪左2.SizeYBase *= num;
			X0Y0_お下げ_髪左1.SizeYBase *= num;
			X0Y0_お下げ_髪根.SizeYBase *= num;
		}
	}

	public double 毛量
	{
		set
		{
			double num = 1.0 + 0.5 * value;
			X0Y0_お下げ_髪節.SizeXBase *= num;
			X0Y0_お下げ_髪縛1.SizeBase *= num;
			X0Y0_お下げ_髪縛2.SizeBase *= num;
			X0Y0_お下げ_髪左2.SizeXBase *= num;
			X0Y0_お下げ_髪左1.SizeXBase *= num;
			X0Y0_お下げ_髪右2.SizeXBase *= num;
			X0Y0_お下げ_髪右1.SizeXBase *= num;
			X0Y0_お下げ_髪根.SizeXBase *= num;
		}
	}

	public double 広がり
	{
		set
		{
			X0Y0_お下げ_髪左2.AngleBase = 1.5 * value;
			X0Y0_お下げ_髪左1.AngleBase = 1.5 * value;
			X0Y0_お下げ_髪右2.AngleBase = -1.5 * value;
			X0Y0_お下げ_髪右1.AngleBase = -1.5 * value;
		}
	}

	public 後髪0_下1ジグ(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 後髪0_下1ジグD e)
	{
		ThisType = GetType();
		Dif dif = new Dif();
		dif.Tag = "下げ1ジグ";
		dif.Add(new Pars(Sta.胴体["後髪0"][0][4]));
		本体 = new Difs();
		本体.Tag = dif.Tag;
		本体.Add(dif);
		Pars pars = 本体[0][0];
		X0Y0_髪基 = pars["髪基"].ToPar();
		Pars pars2 = pars["お下げ"].ToPars();
		X0Y0_お下げ_髪節 = pars2["髪節"].ToPar();
		X0Y0_お下げ_髪縛1 = pars2["髪縛1"].ToPar();
		X0Y0_お下げ_髪縛2 = pars2["髪縛2"].ToPar();
		X0Y0_お下げ_髪左2 = pars2["髪左2"].ToPar();
		X0Y0_お下げ_髪左1 = pars2["髪左1"].ToPar();
		X0Y0_お下げ_髪右2 = pars2["髪右2"].ToPar();
		X0Y0_お下げ_髪右1 = pars2["髪右1"].ToPar();
		X0Y0_お下げ_髪根 = pars2["髪根"].ToPar();
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
		髪基_表示 = e.髪基_表示;
		お下げ_髪節_表示 = e.お下げ_髪節_表示;
		お下げ_髪縛1_表示 = e.お下げ_髪縛1_表示;
		お下げ_髪縛2_表示 = e.お下げ_髪縛2_表示;
		お下げ_髪左2_表示 = e.お下げ_髪左2_表示;
		お下げ_髪左1_表示 = e.お下げ_髪左1_表示;
		お下げ_髪右2_表示 = e.お下げ_髪右2_表示;
		お下げ_髪右1_表示 = e.お下げ_髪右1_表示;
		お下げ_髪根_表示 = e.お下げ_髪根_表示;
		髪長0 = e.髪長0;
		髪長1 = e.髪長1;
		毛量 = e.毛量;
		広がり = e.広がり;
		if (e.スライム)
		{
			スライム();
		}
		欠損 = e.欠損;
		筋肉 = e.筋肉;
		拘束 = e.拘束;
		if (!e.表示)
		{
			表示 = false;
		}
		base.配色指定 = 配色指定;
		配色(体配色);
		X0Y0_髪基CP = new ColorP(X0Y0_髪基, 髪基CD, DisUnit, abj: false);
		X0Y0_お下げ_髪節CP = new ColorP(X0Y0_お下げ_髪節, お下げ_髪節CD, DisUnit, abj: false);
		X0Y0_お下げ_髪縛1CP = new ColorP(X0Y0_お下げ_髪縛1, お下げ_髪縛1CD, DisUnit, abj: true);
		X0Y0_お下げ_髪縛2CP = new ColorP(X0Y0_お下げ_髪縛2, お下げ_髪縛2CD, DisUnit, abj: true);
		X0Y0_お下げ_髪左2CP = new ColorP(X0Y0_お下げ_髪左2, お下げ_髪左2CD, DisUnit, abj: false);
		X0Y0_お下げ_髪左1CP = new ColorP(X0Y0_お下げ_髪左1, お下げ_髪左1CD, DisUnit, abj: false);
		X0Y0_お下げ_髪右2CP = new ColorP(X0Y0_お下げ_髪右2, お下げ_髪右2CD, DisUnit, abj: false);
		X0Y0_お下げ_髪右1CP = new ColorP(X0Y0_お下げ_髪右1, お下げ_髪右1CD, DisUnit, abj: false);
		X0Y0_お下げ_髪根CP = new ColorP(X0Y0_お下げ_髪根, お下げ_髪根CD, DisUnit, abj: false);
		濃度 = e.濃度;
	}

	public override void SetAngle0()
	{
		double num = (右 ? (-1.0) : 1.0);
		X0Y0_お下げ_髪節.AngleBase = num * 30.0;
		X0Y0_お下げ_髪根.AngleBase = num * -25.0;
		本体.JoinPAall();
	}

	public void スライム()
	{
		X0Y0_髪基.OP[右 ? 1 : 0].Outline = false;
		X0Y0_髪基.OP[(!右) ? 1 : 0].Outline = false;
		X0Y0_お下げ_髪節.OP[右 ? 2 : 0].Outline = false;
		X0Y0_お下げ_髪節.OP[右 ? 1 : 1].Outline = false;
		X0Y0_お下げ_髪節.OP[(!右) ? 2 : 0].Outline = false;
		X0Y0_お下げ_髪縛1.OP[右 ? 0 : 0].Outline = false;
		X0Y0_お下げ_髪縛2.OP[右 ? 0 : 0].Outline = false;
		X0Y0_お下げ_髪左2.OP[右 ? 4 : 0].Outline = false;
		X0Y0_お下げ_髪左2.OP[(!右) ? 1 : 3].Outline = false;
		X0Y0_お下げ_髪左2.OP[右 ? 2 : 2].Outline = false;
		X0Y0_お下げ_髪左2.OP[右 ? 1 : 3].Outline = false;
		X0Y0_お下げ_髪左2.OP[(!右) ? 4 : 0].Outline = false;
		X0Y0_お下げ_髪左1.OP[右 ? 4 : 0].Outline = false;
		X0Y0_お下げ_髪左1.OP[(!右) ? 1 : 3].Outline = false;
		X0Y0_お下げ_髪左1.OP[右 ? 2 : 2].Outline = false;
		X0Y0_お下げ_髪左1.OP[右 ? 1 : 3].Outline = false;
		X0Y0_お下げ_髪左1.OP[(!右) ? 4 : 0].Outline = false;
		X0Y0_お下げ_髪右2.OP[右 ? 4 : 0].Outline = false;
		X0Y0_お下げ_髪右2.OP[(!右) ? 1 : 3].Outline = false;
		X0Y0_お下げ_髪右2.OP[右 ? 2 : 2].Outline = false;
		X0Y0_お下げ_髪右2.OP[右 ? 1 : 3].Outline = false;
		X0Y0_お下げ_髪右2.OP[(!右) ? 4 : 0].Outline = false;
		X0Y0_お下げ_髪右1.OP[右 ? 4 : 0].Outline = false;
		X0Y0_お下げ_髪右1.OP[(!右) ? 1 : 3].Outline = false;
		X0Y0_お下げ_髪右1.OP[右 ? 2 : 2].Outline = false;
		X0Y0_お下げ_髪右1.OP[右 ? 1 : 3].Outline = false;
		X0Y0_お下げ_髪右1.OP[(!右) ? 4 : 0].Outline = false;
		X0Y0_お下げ_髪根.OP[右 ? 4 : 0].Outline = false;
		X0Y0_お下げ_髪根.OP[(!右) ? 1 : 3].Outline = false;
		X0Y0_お下げ_髪根.OP[右 ? 2 : 2].Outline = false;
		X0Y0_お下げ_髪根.OP[右 ? 1 : 3].Outline = false;
		X0Y0_お下げ_髪根.OP[(!右) ? 4 : 0].Outline = false;
	}

	public override bool Is布(Par p)
	{
		if (p != X0Y0_お下げ_髪縛1)
		{
			return p == X0Y0_お下げ_髪縛2;
		}
		return true;
	}

	public override void 色更新()
	{
		X0Y0_髪基CP.Update();
		X0Y0_お下げ_髪節CP.Update();
		X0Y0_お下げ_髪縛1CP.Update();
		X0Y0_お下げ_髪縛2CP.Update();
		X0Y0_お下げ_髪左2CP.Update();
		X0Y0_お下げ_髪左1CP.Update();
		X0Y0_お下げ_髪右2CP.Update();
		X0Y0_お下げ_髪右1CP.Update();
		X0Y0_お下げ_髪根CP.Update();
	}

	private void 配色(体配色 体配色)
	{
		配色N0(体配色);
	}

	private void 配色N0(体配色 体配色)
	{
		髪基CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		お下げ_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		お下げ_髪縛1CD = new ColorD();
		お下げ_髪縛2CD = new ColorD();
		お下げ_髪左2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		お下げ_髪左1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		お下げ_髪右2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		お下げ_髪右1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		お下げ_髪根CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
	}

	public override void 髪留配色(髪留色 配色)
	{
		お下げ_髪縛1CD.色 = 配色.髪留1色;
		お下げ_髪縛2CD.色 = 配色.髪留2色;
	}
}
