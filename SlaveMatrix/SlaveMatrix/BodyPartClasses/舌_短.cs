using _2DGAMELIB;

namespace SlaveMatrix;

public class 舌_短 : 舌
{
	public Par X0Y0_舌1;

	public Par X0Y0_舌2;

	public Par X0Y0_舌3;

	public Par X0Y0_舌4;

	public Par X0Y0_舌5;

	public ColorD 舌1CD;

	public ColorD 舌2CD;

	public ColorD 舌3CD;

	public ColorD 舌4CD;

	public ColorD 舌5CD;

	public ColorP X0Y0_舌1CP;

	public ColorP X0Y0_舌2CP;

	public ColorP X0Y0_舌3CP;

	public ColorP X0Y0_舌4CP;

	public ColorP X0Y0_舌5CP;

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

	public bool 舌1_表示
	{
		get
		{
			return X0Y0_舌1.Dra;
		}
		set
		{
			X0Y0_舌1.Dra = value;
			X0Y0_舌1.Hit = value;
		}
	}

	public bool 舌2_表示
	{
		get
		{
			return X0Y0_舌2.Dra;
		}
		set
		{
			X0Y0_舌2.Dra = value;
			X0Y0_舌2.Hit = value;
		}
	}

	public bool 舌3_表示
	{
		get
		{
			return X0Y0_舌3.Dra;
		}
		set
		{
			X0Y0_舌3.Dra = value;
			X0Y0_舌3.Hit = value;
		}
	}

	public bool 舌4_表示
	{
		get
		{
			return X0Y0_舌4.Dra;
		}
		set
		{
			X0Y0_舌4.Dra = value;
			X0Y0_舌4.Hit = value;
		}
	}

	public bool 舌5_表示
	{
		get
		{
			return X0Y0_舌5.Dra;
		}
		set
		{
			X0Y0_舌5.Dra = value;
			X0Y0_舌5.Hit = value;
		}
	}

	public override bool 表示
	{
		get
		{
			return 舌1_表示;
		}
		set
		{
			舌1_表示 = value;
			舌2_表示 = value;
			舌3_表示 = value;
			舌4_表示 = value;
			舌5_表示 = value;
		}
	}

	public override double 濃度
	{
		get
		{
			return 舌1CD.不透明度;
		}
		set
		{
			舌1CD.不透明度 = value;
			舌2CD.不透明度 = value;
			舌3CD.不透明度 = value;
			舌4CD.不透明度 = value;
			舌5CD.不透明度 = value;
		}
	}

	public 舌_短(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 舌_短D e)
	{
		ThisType = GetType();
		Dif dif = new Dif();
		dif.Tag = "短";
		dif.Add(new Pars(Sta.胴体["舌"][0][0]));
		本体 = new Difs();
		本体.Tag = dif.Tag;
		本体.Add(dif);
		Pars pars = 本体[0][0];
		X0Y0_舌1 = pars["舌1"].ToPar();
		X0Y0_舌2 = pars["舌2"].ToPar();
		X0Y0_舌3 = pars["舌3"].ToPar();
		X0Y0_舌4 = pars["舌4"].ToPar();
		X0Y0_舌5 = pars["舌5"].ToPar();
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
		舌1_表示 = e.舌1_表示;
		舌2_表示 = e.舌2_表示;
		舌3_表示 = e.舌3_表示;
		舌4_表示 = e.舌4_表示;
		舌5_表示 = e.舌5_表示;
		欠損 = e.欠損;
		筋肉 = e.筋肉;
		拘束 = e.拘束;
		if (!e.表示)
		{
			表示 = false;
		}
		base.配色指定 = 配色指定;
		配色(体配色);
		Pars = new Par[5] { X0Y0_舌1, X0Y0_舌2, X0Y0_舌3, X0Y0_舌4, X0Y0_舌5 };
		X0Y0_舌1CP = new ColorP(X0Y0_舌1, 舌1CD, DisUnit, abj: true);
		X0Y0_舌2CP = new ColorP(X0Y0_舌2, 舌2CD, DisUnit, abj: true);
		X0Y0_舌3CP = new ColorP(X0Y0_舌3, 舌3CD, DisUnit, abj: true);
		X0Y0_舌4CP = new ColorP(X0Y0_舌4, 舌4CD, DisUnit, abj: true);
		X0Y0_舌5CP = new ColorP(X0Y0_舌5, 舌5CD, DisUnit, abj: true);
		濃度 = e.濃度;
	}

	public override void 色更新()
	{
		Pars.GetMiY_MaY(out mm);
		X0Y0_舌1CP.Update(mm);
		X0Y0_舌2CP.Update(mm);
		X0Y0_舌3CP.Update(mm);
		X0Y0_舌4CP.Update(mm);
		X0Y0_舌5CP.Update(mm);
	}

	private void 配色(体配色 体配色)
	{
		配色N0(体配色);
	}

	private void 配色N0(体配色 体配色)
	{
		舌1CD = new ColorD(ref 体配色.粘膜線, ref 体配色.舌);
		舌2CD = new ColorD(ref 体配色.粘膜線, ref 体配色.舌);
		舌3CD = new ColorD(ref 体配色.粘膜線, ref 体配色.舌);
		舌4CD = new ColorD(ref 体配色.粘膜線, ref 体配色.舌);
		舌5CD = new ColorD(ref 体配色.粘膜線, ref 体配色.舌);
	}
}
