using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 膣基_獣 : 膣基
    {
    	public Par X0Y0_膣基;

    	public ColorD 膣基CD;

    	public ColorP X0Y0_膣基CP;

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

    	public bool 膣基_表示
    	{
    		get
    		{
    			return X0Y0_膣基.Dra;
    		}
    		set
    		{
    			X0Y0_膣基.Dra = value;
    			X0Y0_膣基.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 膣基_表示;
    		}
    		set
    		{
    			膣基_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 膣基CD.不透明度;
    		}
    		set
    		{
    			膣基CD.不透明度 = value;
    		}
    	}

    	public 膣基_獣(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 膣基_獣D e)
    	{
    		ThisType = GetType();
    		本体 = new Difs(Sta.半身["四足膣基"]);
    		Pars pars = 本体[0][0];
    		X0Y0_膣基 = pars["膣基"].ToPar();
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
    		膣基_表示 = e.膣基_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_膣基CP = new ColorP(X0Y0_膣基, 膣基CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_膣基CP.Update();
    	}

    	private void 配色(体配色 体配色)
    	{
    		配色N0(体配色);
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		Col.Alpha(ref 体配色.粘膜, 160, out var ret);
    		膣基CD = new ColorD(ref 体配色.粘膜線, ref ret);
    	}
    }
}
