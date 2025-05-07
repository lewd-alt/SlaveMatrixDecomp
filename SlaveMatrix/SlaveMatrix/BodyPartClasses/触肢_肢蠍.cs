using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 触肢_肢蠍 : 触肢
    {
    	public Par X0Y0_爪2;

    	public Par X0Y0_爪1;

    	public Par X0Y0_輪2_革;

    	public Par X0Y0_輪2_金具1;

    	public Par X0Y0_輪2_金具2;

    	public Par X0Y0_輪2_金具3;

    	public Par X0Y0_輪2_金具左;

    	public Par X0Y0_輪2_金具右;

    	public Par X0Y0_転節;

    	public Par X0Y0_腿節;

    	public Par X0Y0_膝節;

    	public Par X0Y0_輪1_革;

    	public Par X0Y0_輪1_金具1;

    	public Par X0Y0_輪1_金具2;

    	public Par X0Y0_輪1_金具3;

    	public Par X0Y0_輪1_金具左;

    	public Par X0Y0_輪1_金具右;

    	public ColorD 爪2CD;

    	public ColorD 爪1CD;

    	public ColorD 転節CD;

    	public ColorD 腿節CD;

    	public ColorD 膝節CD;

    	public ColorD 輪1_革CD;

    	public ColorD 輪1_金具1CD;

    	public ColorD 輪1_金具2CD;

    	public ColorD 輪1_金具3CD;

    	public ColorD 輪1_金具左CD;

    	public ColorD 輪1_金具右CD;

    	public ColorD 輪2_革CD;

    	public ColorD 輪2_金具1CD;

    	public ColorD 輪2_金具2CD;

    	public ColorD 輪2_金具3CD;

    	public ColorD 輪2_金具左CD;

    	public ColorD 輪2_金具右CD;

    	public ColorP X0Y0_爪2CP;

    	public ColorP X0Y0_爪1CP;

    	public ColorP X0Y0_輪2_革CP;

    	public ColorP X0Y0_輪2_金具1CP;

    	public ColorP X0Y0_輪2_金具2CP;

    	public ColorP X0Y0_輪2_金具3CP;

    	public ColorP X0Y0_輪2_金具左CP;

    	public ColorP X0Y0_輪2_金具右CP;

    	public ColorP X0Y0_転節CP;

    	public ColorP X0Y0_腿節CP;

    	public ColorP X0Y0_膝節CP;

    	public ColorP X0Y0_輪1_革CP;

    	public ColorP X0Y0_輪1_金具1CP;

    	public ColorP X0Y0_輪1_金具2CP;

    	public ColorP X0Y0_輪1_金具3CP;

    	public ColorP X0Y0_輪1_金具左CP;

    	public ColorP X0Y0_輪1_金具右CP;

    	public 拘束鎖 鎖1;

    	public 拘束鎖 鎖2;

    	public 拘束鎖 鎖3;

    	public 拘束鎖 鎖4;

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
    			輪1表示 = 拘束_;
    			輪2表示 = 拘束_;
    		}
    	}

    	public bool 爪2_表示
    	{
    		get
    		{
    			return X0Y0_爪2.Dra;
    		}
    		set
    		{
    			X0Y0_爪2.Dra = value;
    			X0Y0_爪2.Hit = value;
    		}
    	}

    	public bool 爪1_表示
    	{
    		get
    		{
    			return X0Y0_爪1.Dra;
    		}
    		set
    		{
    			X0Y0_爪1.Dra = value;
    			X0Y0_爪1.Hit = value;
    		}
    	}

    	public bool 輪2_革_表示
    	{
    		get
    		{
    			return X0Y0_輪2_革.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_革.Dra = value;
    			X0Y0_輪2_革.Hit = value;
    		}
    	}

    	public bool 輪2_金具1_表示
    	{
    		get
    		{
    			return X0Y0_輪2_金具1.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_金具1.Dra = value;
    			X0Y0_輪2_金具1.Hit = value;
    		}
    	}

    	public bool 輪2_金具2_表示
    	{
    		get
    		{
    			return X0Y0_輪2_金具2.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_金具2.Dra = value;
    			X0Y0_輪2_金具2.Hit = value;
    		}
    	}

    	public bool 輪2_金具3_表示
    	{
    		get
    		{
    			return X0Y0_輪2_金具3.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_金具3.Dra = value;
    			X0Y0_輪2_金具3.Hit = value;
    		}
    	}

    	public bool 輪2_金具左_表示
    	{
    		get
    		{
    			return X0Y0_輪2_金具左.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_金具左.Dra = value;
    			X0Y0_輪2_金具左.Hit = value;
    		}
    	}

    	public bool 輪2_金具右_表示
    	{
    		get
    		{
    			return X0Y0_輪2_金具右.Dra;
    		}
    		set
    		{
    			X0Y0_輪2_金具右.Dra = value;
    			X0Y0_輪2_金具右.Hit = value;
    		}
    	}

    	public bool 転節_表示
    	{
    		get
    		{
    			return X0Y0_転節.Dra;
    		}
    		set
    		{
    			X0Y0_転節.Dra = value;
    			X0Y0_転節.Hit = value;
    		}
    	}

    	public bool 腿節_表示
    	{
    		get
    		{
    			return X0Y0_腿節.Dra;
    		}
    		set
    		{
    			X0Y0_腿節.Dra = value;
    			X0Y0_腿節.Hit = value;
    		}
    	}

    	public bool 膝節_表示
    	{
    		get
    		{
    			return X0Y0_膝節.Dra;
    		}
    		set
    		{
    			X0Y0_膝節.Dra = value;
    			X0Y0_膝節.Hit = value;
    		}
    	}

    	public bool 輪1_革_表示
    	{
    		get
    		{
    			return X0Y0_輪1_革.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_革.Dra = value;
    			X0Y0_輪1_革.Hit = value;
    		}
    	}

    	public bool 輪1_金具1_表示
    	{
    		get
    		{
    			return X0Y0_輪1_金具1.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_金具1.Dra = value;
    			X0Y0_輪1_金具1.Hit = value;
    		}
    	}

    	public bool 輪1_金具2_表示
    	{
    		get
    		{
    			return X0Y0_輪1_金具2.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_金具2.Dra = value;
    			X0Y0_輪1_金具2.Hit = value;
    		}
    	}

    	public bool 輪1_金具3_表示
    	{
    		get
    		{
    			return X0Y0_輪1_金具3.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_金具3.Dra = value;
    			X0Y0_輪1_金具3.Hit = value;
    		}
    	}

    	public bool 輪1_金具左_表示
    	{
    		get
    		{
    			return X0Y0_輪1_金具左.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_金具左.Dra = value;
    			X0Y0_輪1_金具左.Hit = value;
    		}
    	}

    	public bool 輪1_金具右_表示
    	{
    		get
    		{
    			return X0Y0_輪1_金具右.Dra;
    		}
    		set
    		{
    			X0Y0_輪1_金具右.Dra = value;
    			X0Y0_輪1_金具右.Hit = value;
    		}
    	}

    	public bool 輪1表示
    	{
    		get
    		{
    			return 輪1_革_表示;
    		}
    		set
    		{
    			輪1_革_表示 = value;
    			輪1_金具1_表示 = value;
    			輪1_金具2_表示 = value;
    			輪1_金具3_表示 = value;
    			輪1_金具左_表示 = value;
    			輪1_金具右_表示 = value;
    		}
    	}

    	public bool 輪2表示
    	{
    		get
    		{
    			return 輪2_革_表示;
    		}
    		set
    		{
    			輪2_革_表示 = value;
    			輪2_金具1_表示 = value;
    			輪2_金具2_表示 = value;
    			輪2_金具3_表示 = value;
    			輪2_金具左_表示 = value;
    			輪2_金具右_表示 = value;
    		}
    	}

    	public bool 鎖表示
    	{
    		get
    		{
    			return 鎖1.表示;
    		}
    		set
    		{
    			鎖1.表示 = value;
    			鎖2.表示 = value;
    			鎖3.表示 = value;
    			鎖4.表示 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 爪2_表示;
    		}
    		set
    		{
    			爪2_表示 = value;
    			爪1_表示 = value;
    			輪2_革_表示 = value;
    			輪2_金具1_表示 = value;
    			輪2_金具2_表示 = value;
    			輪2_金具3_表示 = value;
    			輪2_金具左_表示 = value;
    			輪2_金具右_表示 = value;
    			転節_表示 = value;
    			腿節_表示 = value;
    			膝節_表示 = value;
    			輪1_革_表示 = value;
    			輪1_金具1_表示 = value;
    			輪1_金具2_表示 = value;
    			輪1_金具3_表示 = value;
    			輪1_金具左_表示 = value;
    			輪1_金具右_表示 = value;
    			鎖1.表示 = value;
    			鎖2.表示 = value;
    			鎖3.表示 = value;
    			鎖4.表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 爪2CD.不透明度;
    		}
    		set
    		{
    			爪2CD.不透明度 = value;
    			爪1CD.不透明度 = value;
    			転節CD.不透明度 = value;
    			腿節CD.不透明度 = value;
    			膝節CD.不透明度 = value;
    			輪1_革CD.不透明度 = value;
    			輪1_金具1CD.不透明度 = value;
    			輪1_金具2CD.不透明度 = value;
    			輪1_金具3CD.不透明度 = value;
    			輪1_金具左CD.不透明度 = value;
    			輪1_金具右CD.不透明度 = value;
    			輪2_革CD.不透明度 = value;
    			輪2_金具1CD.不透明度 = value;
    			輪2_金具2CD.不透明度 = value;
    			輪2_金具3CD.不透明度 = value;
    			輪2_金具左CD.不透明度 = value;
    			輪2_金具右CD.不透明度 = value;
    		}
    	}

    	public JointS 鎖1_接続点 => new JointS(本体, X0Y0_輪1_金具左, 0);

    	public JointS 鎖2_接続点 => new JointS(本体, X0Y0_輪1_金具右, 0);

    	public JointS 鎖3_接続点 => new JointS(本体, X0Y0_輪2_金具左, 0);

    	public JointS 鎖4_接続点 => new JointS(本体, X0Y0_輪2_金具右, 0);

    	public 触肢_肢蠍(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 触肢_肢蠍D e)
    	{
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "触肢蠍";
    		dif.Add(new Pars(Sta.肢左["節足"][0][3]));
    		本体 = new Difs();
    		本体.Tag = dif.Tag;
    		本体.Add(dif);
    		Pars pars = 本体[0][0];
    		X0Y0_爪2 = pars["爪2"].ToPar();
    		X0Y0_爪1 = pars["爪1"].ToPar();
    		Pars pars2 = pars["輪2"].ToPars();
    		X0Y0_輪2_革 = pars2["革"].ToPar();
    		X0Y0_輪2_金具1 = pars2["金具1"].ToPar();
    		X0Y0_輪2_金具2 = pars2["金具2"].ToPar();
    		X0Y0_輪2_金具3 = pars2["金具3"].ToPar();
    		X0Y0_輪2_金具左 = pars2["金具左"].ToPar();
    		X0Y0_輪2_金具右 = pars2["金具右"].ToPar();
    		X0Y0_転節 = pars["転節"].ToPar();
    		X0Y0_腿節 = pars["腿節"].ToPar();
    		X0Y0_膝節 = pars["膝節"].ToPar();
    		pars2 = pars["輪1"].ToPars();
    		X0Y0_輪1_革 = pars2["革"].ToPar();
    		X0Y0_輪1_金具1 = pars2["金具1"].ToPar();
    		X0Y0_輪1_金具2 = pars2["金具2"].ToPar();
    		X0Y0_輪1_金具3 = pars2["金具3"].ToPar();
    		X0Y0_輪1_金具左 = pars2["金具左"].ToPar();
    		X0Y0_輪1_金具右 = pars2["金具右"].ToPar();
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
    		爪2_表示 = e.爪2_表示;
    		爪1_表示 = e.爪1_表示;
    		輪2_革_表示 = e.輪2_革_表示;
    		輪2_金具1_表示 = e.輪2_金具1_表示;
    		輪2_金具2_表示 = e.輪2_金具2_表示;
    		輪2_金具3_表示 = e.輪2_金具3_表示;
    		輪2_金具左_表示 = e.輪2_金具左_表示;
    		輪2_金具右_表示 = e.輪2_金具右_表示;
    		転節_表示 = e.転節_表示;
    		腿節_表示 = e.腿節_表示;
    		膝節_表示 = e.膝節_表示;
    		輪1_革_表示 = e.輪1_革_表示;
    		輪1_金具1_表示 = e.輪1_金具1_表示;
    		輪1_金具2_表示 = e.輪1_金具2_表示;
    		輪1_金具3_表示 = e.輪1_金具3_表示;
    		輪1_金具左_表示 = e.輪1_金具左_表示;
    		輪1_金具右_表示 = e.輪1_金具右_表示;
    		輪1表示 = e.輪1表示;
    		輪2表示 = e.輪2表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_爪2CP = new ColorP(X0Y0_爪2, 爪2CD, DisUnit, abj: true);
    		X0Y0_爪1CP = new ColorP(X0Y0_爪1, 爪1CD, DisUnit, abj: true);
    		X0Y0_輪2_革CP = new ColorP(X0Y0_輪2_革, 輪2_革CD, DisUnit, abj: true);
    		X0Y0_輪2_金具1CP = new ColorP(X0Y0_輪2_金具1, 輪2_金具1CD, DisUnit, abj: true);
    		X0Y0_輪2_金具2CP = new ColorP(X0Y0_輪2_金具2, 輪2_金具2CD, DisUnit, abj: true);
    		X0Y0_輪2_金具3CP = new ColorP(X0Y0_輪2_金具3, 輪2_金具3CD, DisUnit, abj: true);
    		X0Y0_輪2_金具左CP = new ColorP(X0Y0_輪2_金具左, 輪2_金具左CD, DisUnit, abj: true);
    		X0Y0_輪2_金具右CP = new ColorP(X0Y0_輪2_金具右, 輪2_金具右CD, DisUnit, abj: true);
    		X0Y0_転節CP = new ColorP(X0Y0_転節, 転節CD, DisUnit, abj: true);
    		X0Y0_腿節CP = new ColorP(X0Y0_腿節, 腿節CD, DisUnit, abj: true);
    		X0Y0_膝節CP = new ColorP(X0Y0_膝節, 膝節CD, DisUnit, abj: true);
    		X0Y0_輪1_革CP = new ColorP(X0Y0_輪1_革, 輪1_革CD, DisUnit, abj: true);
    		X0Y0_輪1_金具1CP = new ColorP(X0Y0_輪1_金具1, 輪1_金具1CD, DisUnit, abj: true);
    		X0Y0_輪1_金具2CP = new ColorP(X0Y0_輪1_金具2, 輪1_金具2CD, DisUnit, abj: true);
    		X0Y0_輪1_金具3CP = new ColorP(X0Y0_輪1_金具3, 輪1_金具3CD, DisUnit, abj: true);
    		X0Y0_輪1_金具左CP = new ColorP(X0Y0_輪1_金具左, 輪1_金具左CD, DisUnit, abj: true);
    		X0Y0_輪1_金具右CP = new ColorP(X0Y0_輪1_金具右, 輪1_金具右CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    		鎖1 = new 拘束鎖(DisUnit, 右: false, 配色指定, 体配色, Xasix);
    		鎖2 = new 拘束鎖(DisUnit, 右: true, 配色指定, 体配色, Xasix);
    		鎖3 = new 拘束鎖(DisUnit, 右: false, 配色指定, 体配色, Xasix);
    		鎖4 = new 拘束鎖(DisUnit, 右: true, 配色指定, 体配色, Xasix);
    		鎖2.反転Y = true;
    		鎖4.反転Y = true;
    		鎖1.接続(鎖1_接続点);
    		鎖2.接続(鎖2_接続点);
    		鎖3.接続(鎖3_接続点);
    		鎖4.接続(鎖4_接続点);
    		int num = (右 ? (-10) : 10);
    		鎖1.角度B -= num;
    		鎖2.角度B += num;
    		鎖3.角度B -= num;
    		鎖4.角度B += num;
    		鎖表示 = e.鎖表示;
    	}

    	public override void 描画0(Are Are)
    	{
    		Are.Draw(X0Y0_爪2);
    		Are.Draw(X0Y0_爪1);
    		Are.Draw(X0Y0_輪2_革);
    		Are.Draw(X0Y0_輪2_金具1);
    		Are.Draw(X0Y0_輪2_金具2);
    		Are.Draw(X0Y0_輪2_金具3);
    		Are.Draw(X0Y0_輪2_金具左);
    		Are.Draw(X0Y0_輪2_金具右);
    		鎖3.描画0(Are);
    		鎖4.描画0(Are);
    		Are.Draw(X0Y0_転節);
    		Are.Draw(X0Y0_腿節);
    		Are.Draw(X0Y0_膝節);
    		Are.Draw(X0Y0_輪1_革);
    		Are.Draw(X0Y0_輪1_金具1);
    		Are.Draw(X0Y0_輪1_金具2);
    		Are.Draw(X0Y0_輪1_金具3);
    		Are.Draw(X0Y0_輪1_金具左);
    		Are.Draw(X0Y0_輪1_金具右);
    		鎖1.描画0(Are);
    		鎖2.描画0(Are);
    	}

    	public override void Dispose()
    	{
    		base.Dispose();
    		鎖1.Dispose();
    		鎖2.Dispose();
    		鎖3.Dispose();
    		鎖4.Dispose();
    	}

    	public override void SetAngle0()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_転節.AngleBase = num * -30.0;
    		X0Y0_腿節.AngleBase = num * -45.0;
    		X0Y0_膝節.AngleBase = num * 84.0;
    		X0Y0_爪1.AngleBase = num * 76.0;
    		X0Y0_爪2.AngleBase = num * -15.0;
    		本体.JoinPAall();
    	}

    	public override void SetRestraintAngle()
    	{
    		double num = (右 ? (-1.0) : 1.0);
    		X0Y0_爪1.AngleBase = num * 76.0;
    		X0Y0_爪2.AngleBase = num * 0.0;
    		本体.JoinPAall();
    	}

    	public override bool Is革(Par p)
    	{
    		if (p != X0Y0_輪2_革 && p != X0Y0_輪2_金具1 && p != X0Y0_輪2_金具2 && p != X0Y0_輪2_金具3 && p != X0Y0_輪2_金具左 && p != X0Y0_輪2_金具右 && p != X0Y0_輪1_革 && p != X0Y0_輪1_金具1 && p != X0Y0_輪1_金具2 && p != X0Y0_輪1_金具3 && p != X0Y0_輪1_金具左)
    		{
    			return p == X0Y0_輪1_金具右;
    		}
    		return true;
    	}

    	public override void 色更新()
    	{
    		X0Y0_爪2CP.Update();
    		X0Y0_爪1CP.Update();
    		X0Y0_輪2_革CP.Update();
    		X0Y0_輪2_金具1CP.Update();
    		X0Y0_輪2_金具2CP.Update();
    		X0Y0_輪2_金具3CP.Update();
    		X0Y0_輪2_金具左CP.Update();
    		X0Y0_輪2_金具右CP.Update();
    		X0Y0_転節CP.Update();
    		X0Y0_腿節CP.Update();
    		X0Y0_膝節CP.Update();
    		X0Y0_輪1_革CP.Update();
    		X0Y0_輪1_金具1CP.Update();
    		X0Y0_輪1_金具2CP.Update();
    		X0Y0_輪1_金具3CP.Update();
    		X0Y0_輪1_金具左CP.Update();
    		X0Y0_輪1_金具右CP.Update();
    		鎖1.接続PA();
    		鎖2.接続PA();
    		鎖3.接続PA();
    		鎖4.接続PA();
    		鎖1.色更新();
    		鎖2.色更新();
    		鎖3.色更新();
    		鎖4.色更新();
    	}

    	private void 配色(体配色 体配色)
    	{
    		switch (配色指定)
    		{
    		case 配色指定.N0:
    			配色N0(体配色);
    			break;
    		case 配色指定.T0:
    			配色T0(体配色);
    			break;
    		case 配色指定.T1:
    			配色T1(体配色);
    			break;
    		default:
    			配色N0(体配色);
    			break;
    		}
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		爪2CD = new ColorD(ref Col.Black, ref 体配色.甲0R);
    		爪1CD = new ColorD(ref Col.Black, ref 体配色.甲0R);
    		転節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		腿節CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		膝節CD = new ColorD(ref Col.Black, ref 体配色.甲0R);
    		輪1_革CD = new ColorD();
    		輪1_金具1CD = new ColorD();
    		輪1_金具2CD = new ColorD();
    		輪1_金具3CD = new ColorD();
    		輪1_金具左CD = new ColorD();
    		輪1_金具右CD = new ColorD();
    		輪2_革CD = new ColorD();
    		輪2_金具1CD = new ColorD();
    		輪2_金具2CD = new ColorD();
    		輪2_金具3CD = new ColorD();
    		輪2_金具左CD = new ColorD();
    		輪2_金具右CD = new ColorD();
    	}

    	private void 配色T0(体配色 体配色)
    	{
    		爪2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		爪1CD = new ColorD(ref Col.Black, ref 体配色.甲0R);
    		転節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		腿節CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		膝節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		輪1_革CD = new ColorD();
    		輪1_金具1CD = new ColorD();
    		輪1_金具2CD = new ColorD();
    		輪1_金具3CD = new ColorD();
    		輪1_金具左CD = new ColorD();
    		輪1_金具右CD = new ColorD();
    		輪2_革CD = new ColorD();
    		輪2_金具1CD = new ColorD();
    		輪2_金具2CD = new ColorD();
    		輪2_金具3CD = new ColorD();
    		輪2_金具左CD = new ColorD();
    		輪2_金具右CD = new ColorD();
    	}

    	private void 配色T1(体配色 体配色)
    	{
    		爪2CD = new ColorD(ref Col.Black, ref 体配色.甲0R);
    		爪1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		転節CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		腿節CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		膝節CD = new ColorD(ref Col.Black, ref 体配色.甲0R);
    		輪1_革CD = new ColorD();
    		輪1_金具1CD = new ColorD();
    		輪1_金具2CD = new ColorD();
    		輪1_金具3CD = new ColorD();
    		輪1_金具左CD = new ColorD();
    		輪1_金具右CD = new ColorD();
    		輪2_革CD = new ColorD();
    		輪2_金具1CD = new ColorD();
    		輪2_金具2CD = new ColorD();
    		輪2_金具3CD = new ColorD();
    		輪2_金具左CD = new ColorD();
    		輪2_金具右CD = new ColorD();
    	}

    	public void 輪1配色(拘束具色 配色)
    	{
    		輪1_革CD.色 = 配色.革部色;
    		輪1_金具1CD.色 = 配色.金具色;
    		輪1_金具2CD.色 = 輪1_金具1CD.色;
    		輪1_金具3CD.色 = 輪1_金具1CD.色;
    		輪1_金具左CD.色 = 輪1_金具1CD.色;
    		輪1_金具右CD.色 = 輪1_金具1CD.色;
    	}

    	public void 輪2配色(拘束具色 配色)
    	{
    		輪2_革CD.色 = 配色.革部色;
    		輪2_金具1CD.色 = 配色.金具色;
    		輪2_金具2CD.色 = 輪2_金具1CD.色;
    		輪2_金具3CD.色 = 輪2_金具1CD.色;
    		輪2_金具左CD.色 = 輪2_金具1CD.色;
    		輪2_金具右CD.色 = 輪2_金具1CD.色;
    	}

    	public void 鎖配色(鎖色 配色)
    	{
    		鎖1.配色鎖(配色);
    		鎖2.配色鎖(配色);
    		鎖3.配色鎖(配色);
    		鎖4.配色鎖(配色);
    	}
    }
}
