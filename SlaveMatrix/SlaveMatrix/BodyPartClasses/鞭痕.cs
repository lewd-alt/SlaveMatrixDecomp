using _2DGAMELIB;

namespace SlaveMatrix;

public class 鞭痕 : Ele
{
	public Par X0Y0_鞭痕;

	public ColorD 鞭痕CD;

	public ColorP X0Y0_鞭痕CP;

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

	public bool 鞭痕_表示
	{
		get
		{
			return X0Y0_鞭痕.Dra;
		}
		set
		{
			X0Y0_鞭痕.Dra = value;
			X0Y0_鞭痕.Hit = value;
		}
	}

	public override bool 表示
	{
		get
		{
			return 鞭痕_表示;
		}
		set
		{
			鞭痕_表示 = value;
		}
	}

	public override double 濃度
	{
		get
		{
			return 鞭痕CD.不透明度;
		}
		set
		{
			鞭痕CD.不透明度 = value;
		}
	}

	public 鞭痕(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 鞭痕D e)
	{
		ThisType = GetType();
		本体 = new Difs(Sta.スタンプ["鞭痕"]);
		Pars pars = 本体[0][0];
		X0Y0_鞭痕 = pars["鞭痕"].ToPar();
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
		鞭痕_表示 = e.鞭痕_表示;
		欠損 = e.欠損;
		筋肉 = e.筋肉;
		拘束 = e.拘束;
		if (!e.表示)
		{
			表示 = false;
		}
		base.配色指定 = 配色指定;
		配色(体配色);
		X0Y0_鞭痕CP = new ColorP(X0Y0_鞭痕, 鞭痕CD, DisUnit, abj: true);
		濃度 = e.濃度;
	}

	public override void 色更新()
	{
		X0Y0_鞭痕CP.Update();
	}

	private void 配色(体配色 体配色)
	{
		配色N0(体配色);
	}

	private void 配色N0(体配色 体配色)
	{
		鞭痕CD = new ColorD(ref Col.Empty, ref 体配色.粘膜);
	}
}
