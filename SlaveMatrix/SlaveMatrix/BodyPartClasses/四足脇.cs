using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 四足脇 : Ele
    {
    	public Par X0Y0_脇;

    	public Par X0Y0_筋肉;

    	public ColorD 脇CD;

    	public ColorD 筋肉CD;

    	public ColorP X0Y0_脇CP;

    	public ColorP X0Y0_筋肉CP;

    	public Ele[] 上腕_接続;

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
    			筋肉_表示 = 筋肉_;
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

    	public bool 脇_表示
    	{
    		get
    		{
    			return X0Y0_脇.Dra;
    		}
    		set
    		{
    			X0Y0_脇.Dra = value;
    			X0Y0_脇.Hit = value;
    		}
    	}

    	public bool 筋肉_表示
    	{
    		get
    		{
    			return X0Y0_筋肉.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉.Dra = value;
    			X0Y0_筋肉.Hit = value;
    		}
    	}

    	public double 筋肉濃度
    	{
    		get
    		{
    			return 筋肉CD.不透明度;
    		}
    		set
    		{
    			筋肉CD.不透明度 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 脇_表示;
    		}
    		set
    		{
    			脇_表示 = value;
    			筋肉_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 脇CD.不透明度;
    		}
    		set
    		{
    			脇CD.不透明度 = value;
    			筋肉CD.不透明度 = value;
    		}
    	}

    	public JointS 上腕_接続点 => new JointS(本体, X0Y0_脇, 0);

    	public 四足脇(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 四足脇D e)
    	{
    		四足脇 四足脇2 = this;
    		ThisType = GetType();
    		本体 = new Difs(Sta.肩左["四足脇"]);
    		Pars pars = 本体[0][0];
    		X0Y0_脇 = pars["脇"].ToPar();
    		X0Y0_筋肉 = pars["筋肉"].ToPar();
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
    		脇_表示 = e.脇_表示;
    		筋肉_表示 = e.筋肉_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		if (e.上腕_接続.Count > 0)
    		{
    			Ele f;
    			上腕_接続 = e.上腕_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足脇2;
    				f.ConnectionType = ConnectionInfo.四足脇_上腕_接続;
    				f.接続(四足脇2.上腕_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_脇CP = new ColorP(X0Y0_脇, 脇CD, DisUnit, abj: true);
    		X0Y0_筋肉CP = new ColorP(X0Y0_筋肉, 筋肉CD, DisUnit, abj: true);
    		筋肉濃度 = e.筋肉濃度;
    		濃度 = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_脇CP.Update();
    		X0Y0_筋肉CP.Update();
    	}

    	private void 配色(体配色 体配色)
    	{
    		switch (配色指定)
    		{
    		case 配色指定.N0:
    			配色N0(体配色);
    			break;
    		case 配色指定.H0:
    			配色H0(体配色);
    			break;
    		default:
    			配色N0(体配色);
    			break;
    		}
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		脇CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		筋肉CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    	}

    	private void 配色H0(体配色 体配色)
    	{
    		脇CD = new ColorD(ref Col.Black, ref 体配色.柄O);
    		筋肉CD = new ColorD(ref Col.Black, ref 体配色.柄O);
    	}
    }
}
