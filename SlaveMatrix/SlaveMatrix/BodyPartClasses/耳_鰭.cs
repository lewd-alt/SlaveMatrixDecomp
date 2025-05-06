using _2DGAMELIB;

namespace SlaveMatrix;

public class 耳_鰭 : 耳
{
	public Par X0Y0_鰭耳3_鰭膜;

	public Par X0Y0_鰭耳3_鰭条;

	public Par X0Y0_鰭耳1_鰭膜;

	public Par X0Y0_鰭耳1_鰭条;

	public Par X0Y0_鰭耳2_鰭膜;

	public Par X0Y0_鰭耳2_鰭条;

	public Par X0Y1_鰭耳3_鰭膜;

	public Par X0Y1_鰭耳3_鰭条;

	public Par X0Y1_鰭耳1_鰭膜;

	public Par X0Y1_鰭耳1_鰭条;

	public Par X0Y1_鰭耳2_鰭膜;

	public Par X0Y1_鰭耳2_鰭条;

	public Par X0Y2_鰭耳3_鰭膜;

	public Par X0Y2_鰭耳3_鰭条;

	public Par X0Y2_鰭耳1_鰭膜;

	public Par X0Y2_鰭耳1_鰭条;

	public Par X0Y2_鰭耳2_鰭膜;

	public Par X0Y2_鰭耳2_鰭条;

	public Par X1Y0_鰭耳3_鰭膜;

	public Par X1Y0_鰭耳3_鰭条;

	public Par X1Y0_鰭耳1_鰭膜;

	public Par X1Y0_鰭耳1_鰭条;

	public Par X1Y0_鰭耳2_鰭膜;

	public Par X1Y0_鰭耳2_鰭条;

	public Par X1Y1_鰭耳3_鰭膜;

	public Par X1Y1_鰭耳3_鰭条;

	public Par X1Y1_鰭耳1_鰭膜;

	public Par X1Y1_鰭耳1_鰭条;

	public Par X1Y1_鰭耳2_鰭膜;

	public Par X1Y1_鰭耳2_鰭条;

	public Par X1Y2_鰭耳3_鰭膜;

	public Par X1Y2_鰭耳3_鰭条;

	public Par X1Y2_鰭耳1_鰭膜;

	public Par X1Y2_鰭耳1_鰭条;

	public Par X1Y2_鰭耳2_鰭膜;

	public Par X1Y2_鰭耳2_鰭条;

	public ColorD 鰭耳3_鰭膜CD;

	public ColorD 鰭耳3_鰭条CD;

	public ColorD 鰭耳1_鰭膜CD;

	public ColorD 鰭耳1_鰭条CD;

	public ColorD 鰭耳2_鰭膜CD;

	public ColorD 鰭耳2_鰭条CD;

	public ColorP X0Y0_鰭耳3_鰭膜CP;

	public ColorP X0Y0_鰭耳3_鰭条CP;

	public ColorP X0Y0_鰭耳1_鰭膜CP;

	public ColorP X0Y0_鰭耳1_鰭条CP;

	public ColorP X0Y0_鰭耳2_鰭膜CP;

	public ColorP X0Y0_鰭耳2_鰭条CP;

	public ColorP X0Y1_鰭耳3_鰭膜CP;

	public ColorP X0Y1_鰭耳3_鰭条CP;

	public ColorP X0Y1_鰭耳1_鰭膜CP;

	public ColorP X0Y1_鰭耳1_鰭条CP;

	public ColorP X0Y1_鰭耳2_鰭膜CP;

	public ColorP X0Y1_鰭耳2_鰭条CP;

	public ColorP X0Y2_鰭耳3_鰭膜CP;

	public ColorP X0Y2_鰭耳3_鰭条CP;

	public ColorP X0Y2_鰭耳1_鰭膜CP;

	public ColorP X0Y2_鰭耳1_鰭条CP;

	public ColorP X0Y2_鰭耳2_鰭膜CP;

	public ColorP X0Y2_鰭耳2_鰭条CP;

	public ColorP X1Y0_鰭耳3_鰭膜CP;

	public ColorP X1Y0_鰭耳3_鰭条CP;

	public ColorP X1Y0_鰭耳1_鰭膜CP;

	public ColorP X1Y0_鰭耳1_鰭条CP;

	public ColorP X1Y0_鰭耳2_鰭膜CP;

	public ColorP X1Y0_鰭耳2_鰭条CP;

	public ColorP X1Y1_鰭耳3_鰭膜CP;

	public ColorP X1Y1_鰭耳3_鰭条CP;

	public ColorP X1Y1_鰭耳1_鰭膜CP;

	public ColorP X1Y1_鰭耳1_鰭条CP;

	public ColorP X1Y1_鰭耳2_鰭膜CP;

	public ColorP X1Y1_鰭耳2_鰭条CP;

	public ColorP X1Y2_鰭耳3_鰭膜CP;

	public ColorP X1Y2_鰭耳3_鰭条CP;

	public ColorP X1Y2_鰭耳1_鰭膜CP;

	public ColorP X1Y2_鰭耳1_鰭条CP;

	public ColorP X1Y2_鰭耳2_鰭膜CP;

	public ColorP X1Y2_鰭耳2_鰭条CP;

	public Par[] Pars1;

	public Par[] Pars2;

	public Par[] Pars3;

	public Par[] Pars4;

	public Par[] Pars5;

	public Par[] Pars6;

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
			本体.IndexX = (欠損_ ? 1 : 0);
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

	public bool 鰭耳3_鰭膜_表示
	{
		get
		{
			return X0Y0_鰭耳3_鰭膜.Dra;
		}
		set
		{
			X0Y0_鰭耳3_鰭膜.Dra = value;
			X0Y1_鰭耳3_鰭膜.Dra = value;
			X0Y2_鰭耳3_鰭膜.Dra = value;
			X1Y0_鰭耳3_鰭膜.Dra = value;
			X1Y1_鰭耳3_鰭膜.Dra = value;
			X1Y2_鰭耳3_鰭膜.Dra = value;
			X0Y0_鰭耳3_鰭膜.Hit = value;
			X0Y1_鰭耳3_鰭膜.Hit = value;
			X0Y2_鰭耳3_鰭膜.Hit = value;
			X1Y0_鰭耳3_鰭膜.Hit = value;
			X1Y1_鰭耳3_鰭膜.Hit = value;
			X1Y2_鰭耳3_鰭膜.Hit = value;
		}
	}

	public bool 鰭耳3_鰭条_表示
	{
		get
		{
			return X0Y0_鰭耳3_鰭条.Dra;
		}
		set
		{
			X0Y0_鰭耳3_鰭条.Dra = value;
			X0Y1_鰭耳3_鰭条.Dra = value;
			X0Y2_鰭耳3_鰭条.Dra = value;
			X1Y0_鰭耳3_鰭条.Dra = value;
			X1Y1_鰭耳3_鰭条.Dra = value;
			X1Y2_鰭耳3_鰭条.Dra = value;
			X0Y0_鰭耳3_鰭条.Hit = value;
			X0Y1_鰭耳3_鰭条.Hit = value;
			X0Y2_鰭耳3_鰭条.Hit = value;
			X1Y0_鰭耳3_鰭条.Hit = value;
			X1Y1_鰭耳3_鰭条.Hit = value;
			X1Y2_鰭耳3_鰭条.Hit = value;
		}
	}

	public bool 鰭耳1_鰭膜_表示
	{
		get
		{
			return X0Y0_鰭耳1_鰭膜.Dra;
		}
		set
		{
			X0Y0_鰭耳1_鰭膜.Dra = value;
			X0Y1_鰭耳1_鰭膜.Dra = value;
			X0Y2_鰭耳1_鰭膜.Dra = value;
			X1Y0_鰭耳1_鰭膜.Dra = value;
			X1Y1_鰭耳1_鰭膜.Dra = value;
			X1Y2_鰭耳1_鰭膜.Dra = value;
			X0Y0_鰭耳1_鰭膜.Hit = value;
			X0Y1_鰭耳1_鰭膜.Hit = value;
			X0Y2_鰭耳1_鰭膜.Hit = value;
			X1Y0_鰭耳1_鰭膜.Hit = value;
			X1Y1_鰭耳1_鰭膜.Hit = value;
			X1Y2_鰭耳1_鰭膜.Hit = value;
		}
	}

	public bool 鰭耳1_鰭条_表示
	{
		get
		{
			return X0Y0_鰭耳1_鰭条.Dra;
		}
		set
		{
			X0Y0_鰭耳1_鰭条.Dra = value;
			X0Y1_鰭耳1_鰭条.Dra = value;
			X0Y2_鰭耳1_鰭条.Dra = value;
			X1Y0_鰭耳1_鰭条.Dra = value;
			X1Y1_鰭耳1_鰭条.Dra = value;
			X1Y2_鰭耳1_鰭条.Dra = value;
			X0Y0_鰭耳1_鰭条.Hit = value;
			X0Y1_鰭耳1_鰭条.Hit = value;
			X0Y2_鰭耳1_鰭条.Hit = value;
			X1Y0_鰭耳1_鰭条.Hit = value;
			X1Y1_鰭耳1_鰭条.Hit = value;
			X1Y2_鰭耳1_鰭条.Hit = value;
		}
	}

	public bool 鰭耳2_鰭膜_表示
	{
		get
		{
			return X0Y0_鰭耳2_鰭膜.Dra;
		}
		set
		{
			X0Y0_鰭耳2_鰭膜.Dra = value;
			X0Y1_鰭耳2_鰭膜.Dra = value;
			X0Y2_鰭耳2_鰭膜.Dra = value;
			X1Y0_鰭耳2_鰭膜.Dra = value;
			X1Y1_鰭耳2_鰭膜.Dra = value;
			X1Y2_鰭耳2_鰭膜.Dra = value;
			X0Y0_鰭耳2_鰭膜.Hit = value;
			X0Y1_鰭耳2_鰭膜.Hit = value;
			X0Y2_鰭耳2_鰭膜.Hit = value;
			X1Y0_鰭耳2_鰭膜.Hit = value;
			X1Y1_鰭耳2_鰭膜.Hit = value;
			X1Y2_鰭耳2_鰭膜.Hit = value;
		}
	}

	public bool 鰭耳2_鰭条_表示
	{
		get
		{
			return X0Y0_鰭耳2_鰭条.Dra;
		}
		set
		{
			X0Y0_鰭耳2_鰭条.Dra = value;
			X0Y1_鰭耳2_鰭条.Dra = value;
			X0Y2_鰭耳2_鰭条.Dra = value;
			X1Y0_鰭耳2_鰭条.Dra = value;
			X1Y1_鰭耳2_鰭条.Dra = value;
			X1Y2_鰭耳2_鰭条.Dra = value;
			X0Y0_鰭耳2_鰭条.Hit = value;
			X0Y1_鰭耳2_鰭条.Hit = value;
			X0Y2_鰭耳2_鰭条.Hit = value;
			X1Y0_鰭耳2_鰭条.Hit = value;
			X1Y1_鰭耳2_鰭条.Hit = value;
			X1Y2_鰭耳2_鰭条.Hit = value;
		}
	}

	public override bool 表示
	{
		get
		{
			return 鰭耳3_鰭膜_表示;
		}
		set
		{
			鰭耳3_鰭膜_表示 = value;
			鰭耳3_鰭条_表示 = value;
			鰭耳1_鰭膜_表示 = value;
			鰭耳1_鰭条_表示 = value;
			鰭耳2_鰭膜_表示 = value;
			鰭耳2_鰭条_表示 = value;
		}
	}

	public override double 濃度
	{
		get
		{
			return 鰭耳3_鰭膜CD.不透明度;
		}
		set
		{
			鰭耳3_鰭膜CD.不透明度 = value;
			鰭耳3_鰭条CD.不透明度 = value;
			鰭耳1_鰭膜CD.不透明度 = value;
			鰭耳1_鰭条CD.不透明度 = value;
			鰭耳2_鰭膜CD.不透明度 = value;
			鰭耳2_鰭条CD.不透明度 = value;
		}
	}

	public 耳_鰭(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 耳_鰭D e)
	{
		ThisType = GetType();
		本体 = new Difs();
		本体.Tag = "鰭";
		本体.Add(new Dif(Sta.肢左["耳"][6]));
		本体.Add(new Dif(Sta.肢左["耳"][7]));
		Pars pars = 本体[0][0];
		Pars pars2 = pars["鰭耳3"].ToPars();
		X0Y0_鰭耳3_鰭膜 = pars2["鰭膜"].ToPar();
		X0Y0_鰭耳3_鰭条 = pars2["鰭条"].ToPar();
		pars2 = pars["鰭耳1"].ToPars();
		X0Y0_鰭耳1_鰭膜 = pars2["鰭膜"].ToPar();
		X0Y0_鰭耳1_鰭条 = pars2["鰭条"].ToPar();
		pars2 = pars["鰭耳2"].ToPars();
		X0Y0_鰭耳2_鰭膜 = pars2["鰭膜"].ToPar();
		X0Y0_鰭耳2_鰭条 = pars2["鰭条"].ToPar();
		Pars pars3 = 本体[0][1];
		pars2 = pars3["鰭耳3"].ToPars();
		X0Y1_鰭耳3_鰭膜 = pars2["鰭膜"].ToPar();
		X0Y1_鰭耳3_鰭条 = pars2["鰭条"].ToPar();
		pars2 = pars3["鰭耳1"].ToPars();
		X0Y1_鰭耳1_鰭膜 = pars2["鰭膜"].ToPar();
		X0Y1_鰭耳1_鰭条 = pars2["鰭条"].ToPar();
		pars2 = pars3["鰭耳2"].ToPars();
		X0Y1_鰭耳2_鰭膜 = pars2["鰭膜"].ToPar();
		X0Y1_鰭耳2_鰭条 = pars2["鰭条"].ToPar();
		Pars pars4 = 本体[0][2];
		pars2 = pars4["鰭耳3"].ToPars();
		X0Y2_鰭耳3_鰭膜 = pars2["鰭膜"].ToPar();
		X0Y2_鰭耳3_鰭条 = pars2["鰭条"].ToPar();
		pars2 = pars4["鰭耳1"].ToPars();
		X0Y2_鰭耳1_鰭膜 = pars2["鰭膜"].ToPar();
		X0Y2_鰭耳1_鰭条 = pars2["鰭条"].ToPar();
		pars2 = pars4["鰭耳2"].ToPars();
		X0Y2_鰭耳2_鰭膜 = pars2["鰭膜"].ToPar();
		X0Y2_鰭耳2_鰭条 = pars2["鰭条"].ToPar();
		Pars pars5 = 本体[1][0];
		pars2 = pars5["鰭耳3"].ToPars();
		X1Y0_鰭耳3_鰭膜 = pars2["鰭膜"].ToPar();
		X1Y0_鰭耳3_鰭条 = pars2["鰭条"].ToPar();
		pars2 = pars5["鰭耳1"].ToPars();
		X1Y0_鰭耳1_鰭膜 = pars2["鰭膜"].ToPar();
		X1Y0_鰭耳1_鰭条 = pars2["鰭条"].ToPar();
		pars2 = pars5["鰭耳2"].ToPars();
		X1Y0_鰭耳2_鰭膜 = pars2["鰭膜"].ToPar();
		X1Y0_鰭耳2_鰭条 = pars2["鰭条"].ToPar();
		Pars pars6 = 本体[1][1];
		pars2 = pars6["鰭耳3"].ToPars();
		X1Y1_鰭耳3_鰭膜 = pars2["鰭膜"].ToPar();
		X1Y1_鰭耳3_鰭条 = pars2["鰭条"].ToPar();
		pars2 = pars6["鰭耳1"].ToPars();
		X1Y1_鰭耳1_鰭膜 = pars2["鰭膜"].ToPar();
		X1Y1_鰭耳1_鰭条 = pars2["鰭条"].ToPar();
		pars2 = pars6["鰭耳2"].ToPars();
		X1Y1_鰭耳2_鰭膜 = pars2["鰭膜"].ToPar();
		X1Y1_鰭耳2_鰭条 = pars2["鰭条"].ToPar();
		Pars pars7 = 本体[1][2];
		pars2 = pars7["鰭耳3"].ToPars();
		X1Y2_鰭耳3_鰭膜 = pars2["鰭膜"].ToPar();
		X1Y2_鰭耳3_鰭条 = pars2["鰭条"].ToPar();
		pars2 = pars7["鰭耳1"].ToPars();
		X1Y2_鰭耳1_鰭膜 = pars2["鰭膜"].ToPar();
		X1Y2_鰭耳1_鰭条 = pars2["鰭条"].ToPar();
		pars2 = pars7["鰭耳2"].ToPars();
		X1Y2_鰭耳2_鰭膜 = pars2["鰭膜"].ToPar();
		X1Y2_鰭耳2_鰭条 = pars2["鰭条"].ToPar();
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
		鰭耳3_鰭膜_表示 = e.鰭耳3_鰭膜_表示;
		鰭耳3_鰭条_表示 = e.鰭耳3_鰭条_表示;
		鰭耳1_鰭膜_表示 = e.鰭耳1_鰭膜_表示;
		鰭耳1_鰭条_表示 = e.鰭耳1_鰭条_表示;
		鰭耳2_鰭膜_表示 = e.鰭耳2_鰭膜_表示;
		鰭耳2_鰭条_表示 = e.鰭耳2_鰭条_表示;
		欠損 = e.欠損;
		筋肉 = e.筋肉;
		拘束 = e.拘束;
		if (!e.表示)
		{
			表示 = false;
		}
		base.配色指定 = 配色指定;
		配色(体配色);
		Pars1 = new Par[3] { X0Y0_鰭耳3_鰭膜, X0Y0_鰭耳1_鰭膜, X0Y0_鰭耳2_鰭膜 };
		X0Y0_鰭耳3_鰭膜CP = new ColorP(X0Y0_鰭耳3_鰭膜, 鰭耳3_鰭膜CD, DisUnit, abj: true);
		X0Y0_鰭耳3_鰭条CP = new ColorP(X0Y0_鰭耳3_鰭条, 鰭耳3_鰭条CD, DisUnit, abj: true);
		X0Y0_鰭耳1_鰭膜CP = new ColorP(X0Y0_鰭耳1_鰭膜, 鰭耳1_鰭膜CD, DisUnit, abj: true);
		X0Y0_鰭耳1_鰭条CP = new ColorP(X0Y0_鰭耳1_鰭条, 鰭耳1_鰭条CD, DisUnit, abj: true);
		X0Y0_鰭耳2_鰭膜CP = new ColorP(X0Y0_鰭耳2_鰭膜, 鰭耳2_鰭膜CD, DisUnit, abj: true);
		X0Y0_鰭耳2_鰭条CP = new ColorP(X0Y0_鰭耳2_鰭条, 鰭耳2_鰭条CD, DisUnit, abj: true);
		Pars2 = new Par[3] { X0Y1_鰭耳3_鰭膜, X0Y1_鰭耳1_鰭膜, X0Y1_鰭耳2_鰭膜 };
		X0Y1_鰭耳3_鰭膜CP = new ColorP(X0Y1_鰭耳3_鰭膜, 鰭耳3_鰭膜CD, DisUnit, abj: true);
		X0Y1_鰭耳3_鰭条CP = new ColorP(X0Y1_鰭耳3_鰭条, 鰭耳3_鰭条CD, DisUnit, abj: true);
		X0Y1_鰭耳1_鰭膜CP = new ColorP(X0Y1_鰭耳1_鰭膜, 鰭耳1_鰭膜CD, DisUnit, abj: true);
		X0Y1_鰭耳1_鰭条CP = new ColorP(X0Y1_鰭耳1_鰭条, 鰭耳1_鰭条CD, DisUnit, abj: true);
		X0Y1_鰭耳2_鰭膜CP = new ColorP(X0Y1_鰭耳2_鰭膜, 鰭耳2_鰭膜CD, DisUnit, abj: true);
		X0Y1_鰭耳2_鰭条CP = new ColorP(X0Y1_鰭耳2_鰭条, 鰭耳2_鰭条CD, DisUnit, abj: true);
		Pars3 = new Par[3] { X0Y2_鰭耳3_鰭膜, X0Y2_鰭耳1_鰭膜, X0Y2_鰭耳2_鰭膜 };
		X0Y2_鰭耳3_鰭膜CP = new ColorP(X0Y2_鰭耳3_鰭膜, 鰭耳3_鰭膜CD, DisUnit, abj: true);
		X0Y2_鰭耳3_鰭条CP = new ColorP(X0Y2_鰭耳3_鰭条, 鰭耳3_鰭条CD, DisUnit, abj: true);
		X0Y2_鰭耳1_鰭膜CP = new ColorP(X0Y2_鰭耳1_鰭膜, 鰭耳1_鰭膜CD, DisUnit, abj: true);
		X0Y2_鰭耳1_鰭条CP = new ColorP(X0Y2_鰭耳1_鰭条, 鰭耳1_鰭条CD, DisUnit, abj: true);
		X0Y2_鰭耳2_鰭膜CP = new ColorP(X0Y2_鰭耳2_鰭膜, 鰭耳2_鰭膜CD, DisUnit, abj: true);
		X0Y2_鰭耳2_鰭条CP = new ColorP(X0Y2_鰭耳2_鰭条, 鰭耳2_鰭条CD, DisUnit, abj: true);
		Pars4 = new Par[3] { X1Y0_鰭耳3_鰭膜, X1Y0_鰭耳1_鰭膜, X1Y0_鰭耳2_鰭膜 };
		X1Y0_鰭耳3_鰭膜CP = new ColorP(X1Y0_鰭耳3_鰭膜, 鰭耳3_鰭膜CD, DisUnit, abj: true);
		X1Y0_鰭耳3_鰭条CP = new ColorP(X1Y0_鰭耳3_鰭条, 鰭耳3_鰭条CD, DisUnit, abj: true);
		X1Y0_鰭耳1_鰭膜CP = new ColorP(X1Y0_鰭耳1_鰭膜, 鰭耳1_鰭膜CD, DisUnit, abj: true);
		X1Y0_鰭耳1_鰭条CP = new ColorP(X1Y0_鰭耳1_鰭条, 鰭耳1_鰭条CD, DisUnit, abj: true);
		X1Y0_鰭耳2_鰭膜CP = new ColorP(X1Y0_鰭耳2_鰭膜, 鰭耳2_鰭膜CD, DisUnit, abj: true);
		X1Y0_鰭耳2_鰭条CP = new ColorP(X1Y0_鰭耳2_鰭条, 鰭耳2_鰭条CD, DisUnit, abj: true);
		Pars5 = new Par[3] { X1Y1_鰭耳3_鰭膜, X1Y1_鰭耳1_鰭膜, X1Y1_鰭耳2_鰭膜 };
		X1Y1_鰭耳3_鰭膜CP = new ColorP(X1Y1_鰭耳3_鰭膜, 鰭耳3_鰭膜CD, DisUnit, abj: true);
		X1Y1_鰭耳3_鰭条CP = new ColorP(X1Y1_鰭耳3_鰭条, 鰭耳3_鰭条CD, DisUnit, abj: true);
		X1Y1_鰭耳1_鰭膜CP = new ColorP(X1Y1_鰭耳1_鰭膜, 鰭耳1_鰭膜CD, DisUnit, abj: true);
		X1Y1_鰭耳1_鰭条CP = new ColorP(X1Y1_鰭耳1_鰭条, 鰭耳1_鰭条CD, DisUnit, abj: true);
		X1Y1_鰭耳2_鰭膜CP = new ColorP(X1Y1_鰭耳2_鰭膜, 鰭耳2_鰭膜CD, DisUnit, abj: true);
		X1Y1_鰭耳2_鰭条CP = new ColorP(X1Y1_鰭耳2_鰭条, 鰭耳2_鰭条CD, DisUnit, abj: true);
		Pars6 = new Par[3] { X1Y2_鰭耳3_鰭膜, X1Y2_鰭耳1_鰭膜, X1Y2_鰭耳2_鰭膜 };
		X1Y2_鰭耳3_鰭膜CP = new ColorP(X1Y2_鰭耳3_鰭膜, 鰭耳3_鰭膜CD, DisUnit, abj: true);
		X1Y2_鰭耳3_鰭条CP = new ColorP(X1Y2_鰭耳3_鰭条, 鰭耳3_鰭条CD, DisUnit, abj: true);
		X1Y2_鰭耳1_鰭膜CP = new ColorP(X1Y2_鰭耳1_鰭膜, 鰭耳1_鰭膜CD, DisUnit, abj: true);
		X1Y2_鰭耳1_鰭条CP = new ColorP(X1Y2_鰭耳1_鰭条, 鰭耳1_鰭条CD, DisUnit, abj: true);
		X1Y2_鰭耳2_鰭膜CP = new ColorP(X1Y2_鰭耳2_鰭膜, 鰭耳2_鰭膜CD, DisUnit, abj: true);
		X1Y2_鰭耳2_鰭条CP = new ColorP(X1Y2_鰭耳2_鰭条, 鰭耳2_鰭条CD, DisUnit, abj: true);
		濃度 = e.濃度;
	}

	public override void 色更新()
	{
		if (本体.IndexX == 0)
		{
			switch (本体.IndexY)
			{
			case 0:
				Pars1.GetMiY_MaY(out mm);
				X0Y0_鰭耳3_鰭膜CP.Update(mm);
				X0Y0_鰭耳3_鰭条CP.Update();
				X0Y0_鰭耳1_鰭膜CP.Update(mm);
				X0Y0_鰭耳1_鰭条CP.Update();
				X0Y0_鰭耳2_鰭膜CP.Update(mm);
				X0Y0_鰭耳2_鰭条CP.Update();
				break;
			case 1:
				Pars2.GetMiY_MaY(out mm);
				X0Y1_鰭耳3_鰭膜CP.Update(mm);
				X0Y1_鰭耳3_鰭条CP.Update();
				X0Y1_鰭耳1_鰭膜CP.Update(mm);
				X0Y1_鰭耳1_鰭条CP.Update();
				X0Y1_鰭耳2_鰭膜CP.Update(mm);
				X0Y1_鰭耳2_鰭条CP.Update();
				break;
			default:
				Pars3.GetMiY_MaY(out mm);
				X0Y2_鰭耳3_鰭膜CP.Update(mm);
				X0Y2_鰭耳3_鰭条CP.Update();
				X0Y2_鰭耳1_鰭膜CP.Update(mm);
				X0Y2_鰭耳1_鰭条CP.Update();
				X0Y2_鰭耳2_鰭膜CP.Update(mm);
				X0Y2_鰭耳2_鰭条CP.Update();
				break;
			}
		}
		else
		{
			switch (本体.IndexY)
			{
			case 0:
				Pars4.GetMiY_MaY(out mm);
				X1Y0_鰭耳3_鰭膜CP.Update(mm);
				X1Y0_鰭耳3_鰭条CP.Update();
				X1Y0_鰭耳1_鰭膜CP.Update(mm);
				X1Y0_鰭耳1_鰭条CP.Update();
				X1Y0_鰭耳2_鰭膜CP.Update(mm);
				X1Y0_鰭耳2_鰭条CP.Update();
				break;
			case 1:
				Pars5.GetMiY_MaY(out mm);
				X1Y1_鰭耳3_鰭膜CP.Update(mm);
				X1Y1_鰭耳3_鰭条CP.Update();
				X1Y1_鰭耳1_鰭膜CP.Update(mm);
				X1Y1_鰭耳1_鰭条CP.Update();
				X1Y1_鰭耳2_鰭膜CP.Update(mm);
				X1Y1_鰭耳2_鰭条CP.Update();
				break;
			default:
				Pars6.GetMiY_MaY(out mm);
				X1Y2_鰭耳3_鰭膜CP.Update(mm);
				X1Y2_鰭耳3_鰭条CP.Update();
				X1Y2_鰭耳1_鰭膜CP.Update(mm);
				X1Y2_鰭耳1_鰭条CP.Update();
				X1Y2_鰭耳2_鰭膜CP.Update(mm);
				X1Y2_鰭耳2_鰭条CP.Update();
				break;
			}
		}
	}

	private void 配色(体配色 体配色)
	{
		配色N0(体配色);
	}

	private void 配色N0(体配色 体配色)
	{
		鰭耳3_鰭膜CD = new ColorD(ref Col.Black, ref 体配色.膜O);
		鰭耳3_鰭条CD = new ColorD(ref Col.Black, ref 体配色.爪O);
		鰭耳1_鰭膜CD = new ColorD(ref Col.Black, ref 体配色.膜O);
		鰭耳1_鰭条CD = new ColorD(ref Col.Black, ref 体配色.爪O);
		鰭耳2_鰭膜CD = new ColorD(ref Col.Black, ref 体配色.膜O);
		鰭耳2_鰭条CD = new ColorD(ref Col.Black, ref 体配色.爪O);
	}
}
