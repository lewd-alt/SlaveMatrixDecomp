using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 耳_尖 : 耳
    {
    	public Par X0Y0_耳;

    	public Par X0Y0_耳線;

    	public Par X0Y1_耳;

    	public Par X0Y1_耳線;

    	public Par X0Y2_耳;

    	public Par X0Y2_耳線;

    	public Par X1Y0_耳;

    	public Par X1Y0_耳線;

    	public Par X1Y1_耳;

    	public Par X1Y1_耳線;

    	public Par X1Y2_耳;

    	public Par X1Y2_耳線;

    	public ColorD 耳CD;

    	public ColorD 耳線CD;

    	public ColorP X0Y0_耳CP;

    	public ColorP X0Y0_耳線CP;

    	public ColorP X0Y1_耳CP;

    	public ColorP X0Y1_耳線CP;

    	public ColorP X0Y2_耳CP;

    	public ColorP X0Y2_耳線CP;

    	public ColorP X1Y0_耳CP;

    	public ColorP X1Y0_耳線CP;

    	public ColorP X1Y1_耳CP;

    	public ColorP X1Y1_耳線CP;

    	public ColorP X1Y2_耳CP;

    	public ColorP X1Y2_耳線CP;

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

    	public bool 耳_表示
    	{
    		get
    		{
    			return X0Y0_耳.Dra;
    		}
    		set
    		{
    			X0Y0_耳.Dra = value;
    			X0Y1_耳.Dra = value;
    			X0Y2_耳.Dra = value;
    			X1Y0_耳.Dra = value;
    			X1Y1_耳.Dra = value;
    			X1Y2_耳.Dra = value;
    			X0Y0_耳.Hit = value;
    			X0Y1_耳.Hit = value;
    			X0Y2_耳.Hit = value;
    			X1Y0_耳.Hit = value;
    			X1Y1_耳.Hit = value;
    			X1Y2_耳.Hit = value;
    		}
    	}

    	public bool 耳線_表示
    	{
    		get
    		{
    			return X0Y0_耳線.Dra;
    		}
    		set
    		{
    			X0Y0_耳線.Dra = value;
    			X0Y1_耳線.Dra = value;
    			X0Y2_耳線.Dra = value;
    			X1Y0_耳線.Dra = value;
    			X1Y1_耳線.Dra = value;
    			X1Y2_耳線.Dra = value;
    			X0Y0_耳線.Hit = value;
    			X0Y1_耳線.Hit = value;
    			X0Y2_耳線.Hit = value;
    			X1Y0_耳線.Hit = value;
    			X1Y1_耳線.Hit = value;
    			X1Y2_耳線.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 耳_表示;
    		}
    		set
    		{
    			耳_表示 = value;
    			耳線_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 耳CD.不透明度;
    		}
    		set
    		{
    			耳CD.不透明度 = value;
    			耳線CD.不透明度 = value;
    		}
    	}

    	public 耳_尖(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 耳_尖D e)
    	{
    		ThisType = GetType();
    		本体 = new Difs();
    		本体.Tag = "尖";
    		本体.Add(new Dif(Sta.肢左["耳"][2]));
    		本体.Add(new Dif(Sta.肢左["耳"][3]));
    		Pars pars = 本体[0][0];
    		X0Y0_耳 = pars["耳"].ToPar();
    		X0Y0_耳線 = pars["耳線"].ToPar();
    		pars = 本体[0][1];
    		X0Y1_耳 = pars["耳"].ToPar();
    		X0Y1_耳線 = pars["耳線"].ToPar();
    		pars = 本体[0][2];
    		X0Y2_耳 = pars["耳"].ToPar();
    		X0Y2_耳線 = pars["耳線"].ToPar();
    		pars = 本体[1][0];
    		X1Y0_耳 = pars["耳"].ToPar();
    		X1Y0_耳線 = pars["耳線"].ToPar();
    		pars = 本体[1][1];
    		X1Y1_耳 = pars["耳"].ToPar();
    		X1Y1_耳線 = pars["耳線"].ToPar();
    		pars = 本体[1][2];
    		X1Y2_耳 = pars["耳"].ToPar();
    		X1Y2_耳線 = pars["耳線"].ToPar();
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
    		耳_表示 = e.耳_表示;
    		耳線_表示 = e.耳線_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_耳CP = new ColorP(X0Y0_耳, 耳CD, DisUnit, abj: true);
    		X0Y0_耳線CP = new ColorP(X0Y0_耳線, 耳線CD, DisUnit, abj: true);
    		X0Y1_耳CP = new ColorP(X0Y1_耳, 耳CD, DisUnit, abj: true);
    		X0Y1_耳線CP = new ColorP(X0Y1_耳線, 耳線CD, DisUnit, abj: true);
    		X0Y2_耳CP = new ColorP(X0Y2_耳, 耳CD, DisUnit, abj: true);
    		X0Y2_耳線CP = new ColorP(X0Y2_耳線, 耳線CD, DisUnit, abj: true);
    		X1Y0_耳CP = new ColorP(X1Y0_耳, 耳CD, DisUnit, abj: true);
    		X1Y0_耳線CP = new ColorP(X1Y0_耳線, 耳線CD, DisUnit, abj: true);
    		X1Y1_耳CP = new ColorP(X1Y1_耳, 耳CD, DisUnit, abj: true);
    		X1Y1_耳線CP = new ColorP(X1Y1_耳線, 耳線CD, DisUnit, abj: true);
    		X1Y2_耳CP = new ColorP(X1Y2_耳, 耳CD, DisUnit, abj: true);
    		X1Y2_耳線CP = new ColorP(X1Y2_耳線, 耳線CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_耳.AngleBase = num * -325.0;
    		X0Y1_耳.AngleBase = num * -337.0;
    		X0Y2_耳.AngleBase = num * -350.0;
    		X1Y0_耳.AngleBase = num * -325.0;
    		X1Y1_耳.AngleBase = num * -337.0;
    		X1Y2_耳.AngleBase = num * -350.0;
    		本体.JoinPAall();
    	}

    	public override void 色更新()
    	{
    		if (本体.IndexX == 0)
    		{
    			switch (本体.IndexY)
    			{
    			case 0:
    				X0Y0_耳CP.Update();
    				X0Y0_耳線CP.Update();
    				break;
    			case 1:
    				X0Y1_耳CP.Update();
    				X0Y1_耳線CP.Update();
    				break;
    			default:
    				X0Y2_耳CP.Update();
    				X0Y2_耳線CP.Update();
    				break;
    			}
    		}
    		else
    		{
    			switch (本体.IndexY)
    			{
    			case 0:
    				X1Y0_耳CP.Update();
    				X1Y0_耳線CP.Update();
    				break;
    			case 1:
    				X1Y1_耳CP.Update();
    				X1Y1_耳線CP.Update();
    				break;
    			default:
    				X1Y2_耳CP.Update();
    				X1Y2_耳線CP.Update();
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
    		耳CD = new ColorD(ref Col.Black, ref 体配色.人肌O);
    		耳線CD = new ColorD(ref Col.Black, ref Color2.Empty);
    	}
    }
}
