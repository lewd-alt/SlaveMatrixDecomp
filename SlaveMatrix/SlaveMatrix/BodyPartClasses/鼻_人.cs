using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix;

public class 鼻_人 : 鼻
{
	public Par X0Y0_鼻;

	public ColorD 鼻CD;

	public ColorP X0Y0_鼻CP;

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

	public bool 鼻_表示
	{
		get
		{
			return X0Y0_鼻.Dra;
		}
		set
		{
			X0Y0_鼻.Dra = value;
			X0Y0_鼻.Hit = value;
		}
	}

	public override bool 表示
	{
		get
		{
			return 鼻_表示;
		}
		set
		{
			鼻_表示 = value;
		}
	}

	public override double 濃度
	{
		get
		{
			return 鼻CD.不透明度;
		}
		set
		{
			鼻CD.不透明度 = value;
		}
	}

	public JointS 鼻水左_接続点 => new JointS(本体, X0Y0_鼻, 0);

	public JointS 鼻水右_接続点 => new JointS(本体, X0Y0_鼻, 1);

	public 鼻_人(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 鼻_人D e)
	{
		鼻_人 鼻_人2 = this;
		ThisType = GetType();
		Dif dif = new Dif();
		dif.Tag = "人";
		dif.Add(new Pars(Sta.胴体["鼻"][0][0]));
		本体 = new Difs();
		本体.Tag = dif.Tag;
		本体.Add(dif);
		Pars pars = 本体[0][0];
		X0Y0_鼻 = pars["鼻"].ToPar();
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
		鼻_表示 = e.鼻_表示;
		欠損 = e.欠損;
		筋肉 = e.筋肉;
		拘束 = e.拘束;
		if (!e.表示)
		{
			表示 = false;
		}
		Ele f;
		if (e.鼻水左_接続.Count > 0)
		{
			鼻水左_接続 = e.鼻水左_接続.Select(delegate(EleD g)
			{
				f = g.GetEle(DisUnit, Med, 体配色);
				f.Par = 鼻_人2;
				f.ConnectionType = ConnectionInfo.鼻_人_鼻水左_接続;
				f.接続(鼻_人2.鼻水左_接続点);
				return f;
			}).ToArray();
		}
		if (e.鼻水右_接続.Count > 0)
		{
			鼻水右_接続 = e.鼻水右_接続.Select(delegate(EleD g)
			{
				f = g.GetEle(DisUnit, Med, 体配色);
				f.Par = 鼻_人2;
				f.ConnectionType = ConnectionInfo.鼻_人_鼻水右_接続;
				f.接続(鼻_人2.鼻水右_接続点);
				return f;
			}).ToArray();
		}
		base.配色指定 = 配色指定;
		配色(体配色);
		X0Y0_鼻CP = new ColorP(X0Y0_鼻, 鼻CD, DisUnit, abj: true);
		濃度 = e.濃度;
	}

	public override void 色更新()
	{
		X0Y0_鼻CP.Update();
	}

	private void 配色(体配色 体配色)
	{
		配色N0(体配色);
	}

	private void 配色N0(体配色 体配色)
	{
		鼻CD = new ColorD(ref Col.Black, ref Color2.Empty);
	}
}
