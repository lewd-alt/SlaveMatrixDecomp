using _2DGAMELIB;

namespace SlaveMatrix;

public class 手_蝙 : 翼手
{
	public Par X0Y0_獣翼手;

	public Par X0Y0_小指_指1;

	public Par X0Y0_小指_指2;

	public Par X0Y0_小指_指3;

	public Par X0Y0_薬指_指1;

	public Par X0Y0_薬指_指2;

	public Par X0Y0_薬指_指3;

	public Par X0Y0_中指_指1;

	public Par X0Y0_中指_指2;

	public Par X0Y0_中指_指3;

	public Par X0Y0_人指_指1;

	public Par X0Y0_人指_指2;

	public Par X0Y0_人指_指3;

	public Par X0Y0_親指_指1;

	public Par X0Y0_親指_指2;

	public Par X0Y0_親指_指3;

	public 飛膜_先 飛膜;

	public ColorD 獣翼手CD;

	public ColorD 小指_指1CD;

	public ColorD 小指_指2CD;

	public ColorD 小指_指3CD;

	public ColorD 薬指_指1CD;

	public ColorD 薬指_指2CD;

	public ColorD 薬指_指3CD;

	public ColorD 中指_指1CD;

	public ColorD 中指_指2CD;

	public ColorD 中指_指3CD;

	public ColorD 人指_指1CD;

	public ColorD 人指_指2CD;

	public ColorD 人指_指3CD;

	public ColorD 親指_指1CD;

	public ColorD 親指_指2CD;

	public ColorD 親指_指3CD;

	public ColorP X0Y0_獣翼手CP;

	public ColorP X0Y0_小指_指1CP;

	public ColorP X0Y0_小指_指2CP;

	public ColorP X0Y0_小指_指3CP;

	public ColorP X0Y0_薬指_指1CP;

	public ColorP X0Y0_薬指_指2CP;

	public ColorP X0Y0_薬指_指3CP;

	public ColorP X0Y0_中指_指1CP;

	public ColorP X0Y0_中指_指2CP;

	public ColorP X0Y0_中指_指3CP;

	public ColorP X0Y0_人指_指1CP;

	public ColorP X0Y0_人指_指2CP;

	public ColorP X0Y0_人指_指3CP;

	public ColorP X0Y0_親指_指1CP;

	public ColorP X0Y0_親指_指2CP;

	public ColorP X0Y0_親指_指3CP;

	public bool カーブ;

	public Par[] Pars1;

	public Par[] Pars2;

	public Par[] Pars3;

	public Par[] Pars4;

	public Par[] Pars5;

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
			飛膜.欠損 = value;
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
			飛膜.筋肉 = value;
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
			飛膜.拘束 = value;
		}
	}

	public bool 獣翼手_表示
	{
		get
		{
			return X0Y0_獣翼手.Dra;
		}
		set
		{
			X0Y0_獣翼手.Dra = value;
			X0Y0_獣翼手.Hit = value;
		}
	}

	public bool 小指_指1_表示
	{
		get
		{
			return X0Y0_小指_指1.Dra;
		}
		set
		{
			X0Y0_小指_指1.Dra = value;
			X0Y0_小指_指1.Hit = value;
		}
	}

	public bool 小指_指2_表示
	{
		get
		{
			return X0Y0_小指_指2.Dra;
		}
		set
		{
			X0Y0_小指_指2.Dra = value;
			X0Y0_小指_指2.Hit = value;
		}
	}

	public bool 小指_指3_表示
	{
		get
		{
			return X0Y0_小指_指3.Dra;
		}
		set
		{
			X0Y0_小指_指3.Dra = value;
			X0Y0_小指_指3.Hit = value;
		}
	}

	public bool 薬指_指1_表示
	{
		get
		{
			return X0Y0_薬指_指1.Dra;
		}
		set
		{
			X0Y0_薬指_指1.Dra = value;
			X0Y0_薬指_指1.Hit = value;
		}
	}

	public bool 薬指_指2_表示
	{
		get
		{
			return X0Y0_薬指_指2.Dra;
		}
		set
		{
			X0Y0_薬指_指2.Dra = value;
			X0Y0_薬指_指2.Hit = value;
		}
	}

	public bool 薬指_指3_表示
	{
		get
		{
			return X0Y0_薬指_指3.Dra;
		}
		set
		{
			X0Y0_薬指_指3.Dra = value;
			X0Y0_薬指_指3.Hit = value;
		}
	}

	public bool 中指_指1_表示
	{
		get
		{
			return X0Y0_中指_指1.Dra;
		}
		set
		{
			X0Y0_中指_指1.Dra = value;
			X0Y0_中指_指1.Hit = value;
		}
	}

	public bool 中指_指2_表示
	{
		get
		{
			return X0Y0_中指_指2.Dra;
		}
		set
		{
			X0Y0_中指_指2.Dra = value;
			X0Y0_中指_指2.Hit = value;
		}
	}

	public bool 中指_指3_表示
	{
		get
		{
			return X0Y0_中指_指3.Dra;
		}
		set
		{
			X0Y0_中指_指3.Dra = value;
			X0Y0_中指_指3.Hit = value;
		}
	}

	public bool 人指_指1_表示
	{
		get
		{
			return X0Y0_人指_指1.Dra;
		}
		set
		{
			X0Y0_人指_指1.Dra = value;
			X0Y0_人指_指1.Hit = value;
		}
	}

	public bool 人指_指2_表示
	{
		get
		{
			return X0Y0_人指_指2.Dra;
		}
		set
		{
			X0Y0_人指_指2.Dra = value;
			X0Y0_人指_指2.Hit = value;
		}
	}

	public bool 人指_指3_表示
	{
		get
		{
			return X0Y0_人指_指3.Dra;
		}
		set
		{
			X0Y0_人指_指3.Dra = value;
			X0Y0_人指_指3.Hit = value;
		}
	}

	public bool 親指_指1_表示
	{
		get
		{
			return X0Y0_親指_指1.Dra;
		}
		set
		{
			X0Y0_親指_指1.Dra = value;
			X0Y0_親指_指1.Hit = value;
		}
	}

	public bool 親指_指2_表示
	{
		get
		{
			return X0Y0_親指_指2.Dra;
		}
		set
		{
			X0Y0_親指_指2.Dra = value;
			X0Y0_親指_指2.Hit = value;
		}
	}

	public bool 親指_指3_表示
	{
		get
		{
			return X0Y0_親指_指3.Dra;
		}
		set
		{
			X0Y0_親指_指3.Dra = value;
			X0Y0_親指_指3.Hit = value;
		}
	}

	public bool 飛膜_表示
	{
		get
		{
			return 飛膜.飛膜_表示;
		}
		set
		{
			飛膜.飛膜_表示 = value;
			飛膜.飛膜_表示 = value;
		}
	}

	public override bool 表示
	{
		get
		{
			return 獣翼手_表示;
		}
		set
		{
			獣翼手_表示 = value;
			小指_指1_表示 = value;
			小指_指2_表示 = value;
			小指_指3_表示 = value;
			薬指_指1_表示 = value;
			薬指_指2_表示 = value;
			薬指_指3_表示 = value;
			中指_指1_表示 = value;
			中指_指2_表示 = value;
			中指_指3_表示 = value;
			人指_指1_表示 = value;
			人指_指2_表示 = value;
			人指_指3_表示 = value;
			親指_指1_表示 = value;
			親指_指2_表示 = value;
			親指_指3_表示 = value;
			飛膜_表示 = value;
		}
	}

	public override double 濃度
	{
		get
		{
			return 獣翼手CD.不透明度;
		}
		set
		{
			獣翼手CD.不透明度 = value;
			小指_指1CD.不透明度 = value;
			小指_指2CD.不透明度 = value;
			小指_指3CD.不透明度 = value;
			薬指_指1CD.不透明度 = value;
			薬指_指2CD.不透明度 = value;
			薬指_指3CD.不透明度 = value;
			中指_指1CD.不透明度 = value;
			中指_指2CD.不透明度 = value;
			中指_指3CD.不透明度 = value;
			人指_指1CD.不透明度 = value;
			人指_指2CD.不透明度 = value;
			人指_指3CD.不透明度 = value;
			親指_指1CD.不透明度 = value;
			親指_指2CD.不透明度 = value;
			親指_指3CD.不透明度 = value;
			飛膜.飛膜CD.不透明度 = value;
		}
	}

	public override double 展開
	{
		set
		{
			double num = value.Inverse();
			double num2 = (右 ? (-1.0) : 1.0);
			X0Y0_獣翼手.AngleCont = num2 * -74.0 * num;
			X0Y0_小指_指1.AngleCont = num2 * 10.0 * num;
			X0Y0_小指_指2.AngleCont = num2 * 0.0 * num;
			X0Y0_小指_指3.AngleCont = num2 * -1.0 * num;
			X0Y0_薬指_指1.AngleCont = num2 * -38.0 * num;
			X0Y0_薬指_指2.AngleCont = num2 * 2.0 * num;
			X0Y0_薬指_指3.AngleCont = num2 * 4.0 * num;
			X0Y0_中指_指1.AngleCont = num2 * -63.0 * num;
			X0Y0_中指_指2.AngleCont = num2 * -20.0 * num;
			X0Y0_中指_指3.AngleCont = num2 * 12.0 * num;
			X0Y0_人指_指1.AngleCont = num2 * -83.0 * num;
			X0Y0_人指_指2.AngleCont = num2 * 9.0 * num;
			X0Y0_人指_指3.AngleCont = num2 * 4.0 * num;
			X0Y0_親指_指1.AngleCont = num2 * -10.0 * num;
			X0Y0_親指_指2.AngleCont = num2 * -22.0 * num;
			X0Y0_親指_指3.AngleCont = num2 * -45.0 * num;
		}
	}

	public double シャープ
	{
		set
		{
			X0Y0_小指_指1.SizeXBase *= 1.0 - 0.4 * value;
			X0Y0_小指_指2.SizeXBase *= 1.0 - 0.4 * value;
			X0Y0_小指_指3.SizeXBase *= 1.0 - 0.4 * value;
			X0Y0_薬指_指1.SizeXBase *= 1.0 - 0.25 * value;
			X0Y0_薬指_指2.SizeXBase *= 1.0 - 0.25 * value;
			X0Y0_薬指_指3.SizeXBase *= 1.0 - 0.25 * value;
		}
	}

	public bool 下部_外線
	{
		get
		{
			return X0Y0_獣翼手.OP[(!右) ? 1 : 5].Outline;
		}
		set
		{
			X0Y0_獣翼手.OP[(!右) ? 1 : 5].Outline = value;
			X0Y0_小指_指1.OP[(!右) ? 3 : 0].Outline = value;
			X0Y0_小指_指2.OP[(!右) ? 3 : 0].Outline = value;
			X0Y0_小指_指3.OP[(!右) ? 2 : 0].Outline = value;
			X0Y0_薬指_指1.OP[(!右) ? 3 : 0].Outline = value;
			X0Y0_薬指_指2.OP[(!右) ? 3 : 0].Outline = value;
			X0Y0_薬指_指3.OP[(!右) ? 2 : 0].Outline = value;
			X0Y0_中指_指1.OP[(!右) ? 3 : 0].Outline = value;
			X0Y0_中指_指2.OP[(!右) ? 3 : 0].Outline = value;
			X0Y0_中指_指3.OP[(!右) ? 2 : 0].Outline = value;
			X0Y0_人指_指1.OP[(!右) ? 3 : 0].Outline = value;
			X0Y0_人指_指2.OP[(!右) ? 3 : 0].Outline = value;
			X0Y0_人指_指3.OP[(!右) ? 2 : 0].Outline = value;
		}
	}

	public bool 接部_外線
	{
		get
		{
			return 飛膜.接部_外線;
		}
		set
		{
			飛膜.接部_外線 = value;
		}
	}

	public override double 尺度B
	{
		get
		{
			return base.尺度B;
		}
		set
		{
			base.尺度B = value;
			飛膜.尺度B = value;
		}
	}

	public override double 尺度C
	{
		get
		{
			return base.尺度C;
		}
		set
		{
			base.尺度C = value;
			飛膜.尺度C = value;
		}
	}

	public override double 尺度XB
	{
		get
		{
			return base.尺度XB;
		}
		set
		{
			base.尺度XB = value;
			飛膜.尺度XB = value;
		}
	}

	public override double 尺度XC
	{
		get
		{
			return base.尺度XC;
		}
		set
		{
			base.尺度XC = value;
			飛膜.尺度XC = value;
		}
	}

	public override double 尺度YB
	{
		get
		{
			return base.尺度YB;
		}
		set
		{
			base.尺度YB = value;
			飛膜.尺度YB = value;
		}
	}

	public override double 尺度YC
	{
		get
		{
			return base.尺度YC;
		}
		set
		{
			base.尺度YC = value;
			飛膜.尺度YC = value;
		}
	}

	public override double 肥大
	{
		set
		{
			base.肥大 = value;
			飛膜.肥大 = value;
		}
	}

	public override double 身長
	{
		set
		{
			base.身長 = value;
			飛膜.身長 = value;
		}
	}

	public override bool 右
	{
		get
		{
			return base.右;
		}
		set
		{
			base.右 = value;
			飛膜.右 = value;
		}
	}

	public override bool 反転X
	{
		get
		{
			return base.反転X;
		}
		set
		{
			base.反転X = value;
			飛膜.反転X = value;
		}
	}

	public override bool 反転Y
	{
		get
		{
			return base.反転Y;
		}
		set
		{
			base.反転Y = value;
			飛膜.反転Y = value;
		}
	}

	public override double Xv
	{
		get
		{
			return base.Xv;
		}
		set
		{
			base.Xv = value;
			飛膜.Xv = value;
		}
	}

	public override double Yv
	{
		get
		{
			return base.Yv;
		}
		set
		{
			base.Yv = value;
			飛膜.Yv = value;
		}
	}

	public override int Xi
	{
		get
		{
			return base.Xi;
		}
		set
		{
			base.Xi = value;
			飛膜.Xi = value;
		}
	}

	public override int Yi
	{
		get
		{
			return base.Yi;
		}
		set
		{
			base.Yi = value;
			飛膜.Yi = value;
		}
	}

	public override double サイズ
	{
		get
		{
			return サイズ_;
		}
		set
		{
			base.サイズ = value;
			飛膜.サイズ = value;
		}
	}

	public override double サイズX
	{
		get
		{
			return サイズX_;
		}
		set
		{
			base.サイズX = value;
			飛膜.サイズX = value;
		}
	}

	public override double サイズY
	{
		get
		{
			return サイズY_;
		}
		set
		{
			base.サイズY = value;
			飛膜.サイズY = value;
		}
	}

	public 手_蝙(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 手_蝙D e)
	{
		飛膜 = new 飛膜_先(DisUnit, 配色指定, 体配色);
		飛膜.Par = this;
		ThisType = GetType();
		本体 = new Difs(Sta.腕左["獣翼手"]);
		Pars pars = 本体[0][0];
		X0Y0_獣翼手 = pars["獣翼手"].ToPar();
		Pars pars2 = pars["小指"].ToPars();
		X0Y0_小指_指1 = pars2["指1"].ToPar();
		X0Y0_小指_指2 = pars2["指2"].ToPar();
		X0Y0_小指_指3 = pars2["指3"].ToPar();
		pars2 = pars["薬指"].ToPars();
		X0Y0_薬指_指1 = pars2["指1"].ToPar();
		X0Y0_薬指_指2 = pars2["指2"].ToPar();
		X0Y0_薬指_指3 = pars2["指3"].ToPar();
		pars2 = pars["中指"].ToPars();
		X0Y0_中指_指1 = pars2["指1"].ToPar();
		X0Y0_中指_指2 = pars2["指2"].ToPar();
		X0Y0_中指_指3 = pars2["指3"].ToPar();
		pars2 = pars["人指"].ToPars();
		X0Y0_人指_指1 = pars2["指1"].ToPar();
		X0Y0_人指_指2 = pars2["指2"].ToPar();
		X0Y0_人指_指3 = pars2["指3"].ToPar();
		pars2 = pars["親指"].ToPars();
		X0Y0_親指_指1 = pars2["指1"].ToPar();
		X0Y0_親指_指2 = pars2["指2"].ToPar();
		X0Y0_親指_指3 = pars2["指3"].ToPar();
		Xasix = false;
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
		獣翼手_表示 = e.獣翼手_表示;
		小指_指1_表示 = e.小指_指1_表示;
		小指_指2_表示 = e.小指_指2_表示;
		小指_指3_表示 = e.小指_指3_表示;
		薬指_指1_表示 = e.薬指_指1_表示;
		薬指_指2_表示 = e.薬指_指2_表示;
		薬指_指3_表示 = e.薬指_指3_表示;
		中指_指1_表示 = e.中指_指1_表示;
		中指_指2_表示 = e.中指_指2_表示;
		中指_指3_表示 = e.中指_指3_表示;
		人指_指1_表示 = e.人指_指1_表示;
		人指_指2_表示 = e.人指_指2_表示;
		人指_指3_表示 = e.人指_指3_表示;
		親指_指1_表示 = e.親指_指1_表示;
		親指_指2_表示 = e.親指_指2_表示;
		親指_指3_表示 = e.親指_指3_表示;
		飛膜_表示 = e.飛膜_表示;
		展開 = e.展開;
		シャープ = e.シャープ;
		下部_外線 = e.下部_外線;
		接部_外線 = e.接部_外線;
		カーブ = e.カーブ;
		欠損 = e.欠損;
		筋肉 = e.筋肉;
		拘束 = e.拘束;
		if (!e.表示)
		{
			表示 = false;
		}
		base.配色指定 = 配色指定;
		配色(体配色);
		X0Y0_獣翼手CP = new ColorP(X0Y0_獣翼手, 獣翼手CD, DisUnit, abj: true);
		Pars1 = new Par[3] { X0Y0_小指_指1, X0Y0_小指_指2, X0Y0_小指_指3 };
		X0Y0_小指_指1CP = new ColorP(X0Y0_小指_指1, 小指_指1CD, DisUnit, abj: true);
		X0Y0_小指_指2CP = new ColorP(X0Y0_小指_指2, 小指_指2CD, DisUnit, abj: true);
		X0Y0_小指_指3CP = new ColorP(X0Y0_小指_指3, 小指_指3CD, DisUnit, abj: true);
		Pars2 = new Par[3] { X0Y0_薬指_指1, X0Y0_薬指_指2, X0Y0_薬指_指3 };
		X0Y0_薬指_指1CP = new ColorP(X0Y0_薬指_指1, 薬指_指1CD, DisUnit, abj: true);
		X0Y0_薬指_指2CP = new ColorP(X0Y0_薬指_指2, 薬指_指2CD, DisUnit, abj: true);
		X0Y0_薬指_指3CP = new ColorP(X0Y0_薬指_指3, 薬指_指3CD, DisUnit, abj: true);
		Pars3 = new Par[3] { X0Y0_中指_指1, X0Y0_中指_指2, X0Y0_中指_指3 };
		X0Y0_中指_指1CP = new ColorP(X0Y0_中指_指1, 中指_指1CD, DisUnit, abj: true);
		X0Y0_中指_指2CP = new ColorP(X0Y0_中指_指2, 中指_指2CD, DisUnit, abj: true);
		X0Y0_中指_指3CP = new ColorP(X0Y0_中指_指3, 中指_指3CD, DisUnit, abj: true);
		Pars4 = new Par[3] { X0Y0_人指_指1, X0Y0_人指_指2, X0Y0_人指_指3 };
		X0Y0_人指_指1CP = new ColorP(X0Y0_人指_指1, 人指_指1CD, DisUnit, abj: true);
		X0Y0_人指_指2CP = new ColorP(X0Y0_人指_指2, 人指_指2CD, DisUnit, abj: true);
		X0Y0_人指_指3CP = new ColorP(X0Y0_人指_指3, 人指_指3CD, DisUnit, abj: true);
		Pars5 = new Par[2] { X0Y0_親指_指1, X0Y0_親指_指2 };
		X0Y0_親指_指1CP = new ColorP(X0Y0_親指_指1, 親指_指1CD, DisUnit, abj: true);
		X0Y0_親指_指2CP = new ColorP(X0Y0_親指_指2, 親指_指2CD, DisUnit, abj: true);
		X0Y0_親指_指3CP = new ColorP(X0Y0_親指_指3, 親指_指3CD, DisUnit, abj: true);
		尺度B = 1.02;
		濃度 = e.濃度;
	}

	public override void SetAngle0()
	{
		double num = (右 ? (-1.0) : 1.0);
		X0Y0_獣翼手.AngleBase = num * -31.0000000000001;
		X0Y0_小指_指1.AngleBase = num * -79.3474786285473;
		X0Y0_小指_指2.AngleBase = num * -6.63284583292149;
		X0Y0_小指_指3.AngleBase = num * -5.51444226587368;
		X0Y0_薬指_指1.AngleBase = num * -29.8986006733114;
		X0Y0_薬指_指2.AngleBase = num * -9.09381595653455;
		X0Y0_薬指_指3.AngleBase = num * -15.3232033633539;
		X0Y0_中指_指1.AngleBase = num * -2.25244077487218;
		X0Y0_中指_指2.AngleBase = num * -349.728279240711;
		X0Y0_中指_指3.AngleBase = num * 330.298790583483;
		X0Y0_人指_指1.AngleBase = num * -340.637781414332;
		X0Y0_人指_指2.AngleBase = num * -14.7669119107363;
		X0Y0_人指_指3.AngleBase = num * 347.37149883769;
		X0Y0_親指_指1.AngleBase = num * -257.575894274218;
		X0Y0_親指_指2.AngleBase = num * 328.764949390357;
		X0Y0_親指_指3.AngleBase = num * 15.8109448838614;
		本体.JoinPAall();
	}

	public override void 描画0(Are Are)
	{
		Are.Draw(X0Y0_獣翼手);
		Are.Draw(X0Y0_小指_指1);
		Are.Draw(X0Y0_薬指_指1);
		Are.Draw(X0Y0_中指_指1);
		Are.Draw(X0Y0_人指_指1);
		Are.Draw(X0Y0_人指_指2);
		Are.Draw(X0Y0_親指_指1);
		Are.Draw(X0Y0_親指_指2);
		Are.Draw(X0Y0_親指_指3);
	}

	public void 指先描画(Are Are)
	{
		Are.Draw(X0Y0_小指_指2);
		Are.Draw(X0Y0_小指_指3);
		Are.Draw(X0Y0_薬指_指2);
		Are.Draw(X0Y0_薬指_指3);
		Are.Draw(X0Y0_中指_指2);
		Are.Draw(X0Y0_中指_指3);
		Are.Draw(X0Y0_人指_指3);
	}

	public override void Dispose()
	{
		base.Dispose();
		飛膜.Dispose();
	}

	public void 接続(上腕_蝙 上腕, 下腕_蝙 下腕, bool カーブ)
	{
		飛膜.接続(上腕, 下腕, this, カーブ);
	}

	public override void 色更新()
	{
		X0Y0_獣翼手CP.Update();
		Pars1.GetMiY_MaY(out mm);
		X0Y0_小指_指1CP.Update(mm);
		X0Y0_小指_指2CP.Update(mm);
		X0Y0_小指_指3CP.Update(mm);
		Pars2.GetMiY_MaY(out mm);
		X0Y0_薬指_指1CP.Update(mm);
		X0Y0_薬指_指2CP.Update(mm);
		X0Y0_薬指_指3CP.Update(mm);
		Pars3.GetMiY_MaY(out mm);
		X0Y0_中指_指1CP.Update(mm);
		X0Y0_中指_指2CP.Update(mm);
		X0Y0_中指_指3CP.Update(mm);
		Pars4.GetMiY_MaY(out mm);
		X0Y0_人指_指1CP.Update(mm);
		X0Y0_人指_指2CP.Update(mm);
		X0Y0_人指_指3CP.Update(mm);
		Pars5.GetMiY_MaY(out mm);
		X0Y0_親指_指1CP.Update(mm);
		X0Y0_親指_指2CP.Update(mm);
		X0Y0_親指_指3CP.Update();
	}

	private void 配色(体配色 体配色)
	{
		配色N0(体配色);
	}

	private void 配色N0(体配色 体配色)
	{
		獣翼手CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
		小指_指1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
		小指_指2CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
		小指_指3CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
		薬指_指1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
		薬指_指2CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
		薬指_指3CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
		中指_指1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
		中指_指2CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
		中指_指3CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
		人指_指1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
		人指_指2CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
		人指_指3CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
		親指_指1CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
		親指_指2CD = new ColorD(ref Col.Black, ref 体配色.毛0R);
		親指_指3CD = new ColorD(ref Col.Black, ref 体配色.爪O);
	}
}
