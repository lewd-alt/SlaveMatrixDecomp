using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix;

public class 腿_蹄 : 獣腿
{
	public Par X0Y0_腿;

	public Par X0Y0_筋;

	public ColorD 腿CD;

	public ColorD 筋CD;

	public ColorP X0Y0_腿CP;

	public ColorP X0Y0_筋CP;

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
			筋_表示 = 筋肉_;
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

	public bool 腿_表示
	{
		get
		{
			return X0Y0_腿.Dra;
		}
		set
		{
			X0Y0_腿.Dra = value;
			X0Y0_腿.Hit = value;
		}
	}

	public bool 筋_表示
	{
		get
		{
			return X0Y0_筋.Dra;
		}
		set
		{
			X0Y0_筋.Dra = value;
			X0Y0_筋.Hit = value;
		}
	}

	public override bool 表示
	{
		get
		{
			return 腿_表示;
		}
		set
		{
			腿_表示 = value;
			筋_表示 = value;
		}
	}

	public override double 濃度
	{
		get
		{
			return 腿CD.不透明度;
		}
		set
		{
			腿CD.不透明度 = value;
			筋CD.不透明度 = value;
		}
	}

	public JointS 脚_接続点 => new JointS(本体, X0Y0_腿, 0);

	public 腿_蹄(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 腿_蹄D e)
	{
		腿_蹄 腿_蹄2 = this;
		ThisType = GetType();
		Dif dif = new Dif(Sta.脚左["四足腿"][1]);
		本体 = new Difs();
		本体.Tag = dif.Tag;
		本体.Add(dif);
		Pars pars = 本体[0][0];
		X0Y0_腿 = pars["腿"].ToPar();
		X0Y0_筋 = pars["筋"].ToPar();
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
		腿_表示 = e.腿_表示;
		筋_表示 = e.筋_表示;
		欠損 = e.欠損;
		筋肉 = e.筋肉;
		拘束 = e.拘束;
		if (!e.表示)
		{
			表示 = false;
		}
		if (e.脚_接続.Count > 0)
		{
			Ele f;
			脚_接続 = e.脚_接続.Select(delegate(EleD g)
			{
				f = g.GetEle(DisUnit, Med, 体配色);
				f.Par = 腿_蹄2;
				f.ConnectionType = ConnectionInfo.腿_蹄_脚_接続;
				f.接続(腿_蹄2.脚_接続点);
				return f;
			}).ToArray();
		}
		base.配色指定 = 配色指定;
		配色(体配色);
		X0Y0_腿CP = new ColorP(X0Y0_腿, 腿CD, DisUnit, abj: true);
		X0Y0_筋CP = new ColorP(X0Y0_筋, 筋CD, DisUnit, abj: false);
		濃度 = e.濃度;
	}

	public override void SetAngle0()
	{
		double num = (右 ? (-1.0) : 1.0);
		X0Y0_腿.AngleBase = num * 144.0;
		本体.JoinPAall();
	}

	public override void 色更新()
	{
		X0Y0_腿CP.Update();
		X0Y0_筋CP.Update();
	}

	private void 配色(体配色 体配色)
	{
		配色N0(体配色);
	}

	private void 配色N0(体配色 体配色)
	{
		腿CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
		筋CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
	}
}
