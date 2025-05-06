using _2DGAMELIB;

namespace SlaveMatrix;

public class 前髪_上げ長2 : 前髪
{
	public Par X0Y0_髪基;

	public Par X0Y0_髪左1;

	public Par X0Y0_髪左2;

	public Par X0Y0_ハイライト左;

	public Par X0Y0_髪右1;

	public Par X0Y0_髪右2;

	public Par X0Y0_ハイライト右;

	public Par X0Y0_髪左根1;

	public Par X0Y0_髪左根2;

	public Par X0Y0_編み左_編節1_髪節;

	public Par X0Y0_編み左_編節1_髪編目;

	public Par X0Y0_編み左_編節2_髪節;

	public Par X0Y0_編み左_編節2_髪編目;

	public Par X0Y0_編み左_編節3_髪節;

	public Par X0Y0_編み左_編節3_髪編目;

	public Par X0Y0_髪ハネ左;

	public Par X0Y0_髪左3;

	public Par X0Y0_髪左4;

	public Par X0Y0_髪右根1;

	public Par X0Y0_髪右根2;

	public Par X0Y0_編み右_編節1_髪節;

	public Par X0Y0_編み右_編節1_髪編目;

	public Par X0Y0_編み右_編節2_髪節;

	public Par X0Y0_編み右_編節2_髪編目;

	public Par X0Y0_編み右_編節3_髪節;

	public Par X0Y0_編み右_編節3_髪編目;

	public Par X0Y0_髪ハネ右;

	public Par X0Y0_髪右3;

	public Par X0Y0_髪右4;

	public ColorD 髪基CD;

	public ColorD 髪左1CD;

	public ColorD 髪左2CD;

	public ColorD ハイライト左CD;

	public ColorD 髪右1CD;

	public ColorD 髪右2CD;

	public ColorD ハイライト右CD;

	public ColorD 髪左根1CD;

	public ColorD 髪左根2CD;

	public ColorD 編み左_編節1_髪節CD;

	public ColorD 編み左_編節1_髪編目CD;

	public ColorD 編み左_編節2_髪節CD;

	public ColorD 編み左_編節2_髪編目CD;

	public ColorD 編み左_編節3_髪節CD;

	public ColorD 編み左_編節3_髪編目CD;

	public ColorD 髪ハネ左CD;

	public ColorD 髪左3CD;

	public ColorD 髪左4CD;

	public ColorD 髪右根1CD;

	public ColorD 髪右根2CD;

	public ColorD 編み右_編節1_髪節CD;

	public ColorD 編み右_編節1_髪編目CD;

	public ColorD 編み右_編節2_髪節CD;

	public ColorD 編み右_編節2_髪編目CD;

	public ColorD 編み右_編節3_髪節CD;

	public ColorD 編み右_編節3_髪編目CD;

	public ColorD 髪ハネ右CD;

	public ColorD 髪右3CD;

	public ColorD 髪右4CD;

	public ColorP X0Y0_髪基CP;

	public ColorP X0Y0_髪左1CP;

	public ColorP X0Y0_髪左2CP;

	public ColorP X0Y0_ハイライト左CP;

	public ColorP X0Y0_髪右1CP;

	public ColorP X0Y0_髪右2CP;

	public ColorP X0Y0_ハイライト右CP;

	public ColorP X0Y0_髪左根1CP;

	public ColorP X0Y0_髪左根2CP;

	public ColorP X0Y0_編み左_編節1_髪節CP;

	public ColorP X0Y0_編み左_編節1_髪編目CP;

	public ColorP X0Y0_編み左_編節2_髪節CP;

	public ColorP X0Y0_編み左_編節2_髪編目CP;

	public ColorP X0Y0_編み左_編節3_髪節CP;

	public ColorP X0Y0_編み左_編節3_髪編目CP;

	public ColorP X0Y0_髪ハネ左CP;

	public ColorP X0Y0_髪左3CP;

	public ColorP X0Y0_髪左4CP;

	public ColorP X0Y0_髪右根1CP;

	public ColorP X0Y0_髪右根2CP;

	public ColorP X0Y0_編み右_編節1_髪節CP;

	public ColorP X0Y0_編み右_編節1_髪編目CP;

	public ColorP X0Y0_編み右_編節2_髪節CP;

	public ColorP X0Y0_編み右_編節2_髪編目CP;

	public ColorP X0Y0_編み右_編節3_髪節CP;

	public ColorP X0Y0_編み右_編節3_髪編目CP;

	public ColorP X0Y0_髪ハネ右CP;

	public ColorP X0Y0_髪右3CP;

	public ColorP X0Y0_髪右4CP;

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

	public bool 髪基_表示
	{
		get
		{
			return X0Y0_髪基.Dra;
		}
		set
		{
			X0Y0_髪基.Dra = value;
			X0Y0_髪基.Hit = value;
		}
	}

	public bool 髪左1_表示
	{
		get
		{
			return X0Y0_髪左1.Dra;
		}
		set
		{
			X0Y0_髪左1.Dra = value;
			X0Y0_髪左1.Hit = value;
		}
	}

	public bool 髪左2_表示
	{
		get
		{
			return X0Y0_髪左2.Dra;
		}
		set
		{
			X0Y0_髪左2.Dra = value;
			X0Y0_髪左2.Hit = value;
		}
	}

	public bool ハイライト左_表示
	{
		get
		{
			return X0Y0_ハイライト左.Dra;
		}
		set
		{
			X0Y0_ハイライト左.Dra = value;
			X0Y0_ハイライト左.Hit = value;
		}
	}

	public bool 髪右1_表示
	{
		get
		{
			return X0Y0_髪右1.Dra;
		}
		set
		{
			X0Y0_髪右1.Dra = value;
			X0Y0_髪右1.Hit = value;
		}
	}

	public bool 髪右2_表示
	{
		get
		{
			return X0Y0_髪右2.Dra;
		}
		set
		{
			X0Y0_髪右2.Dra = value;
			X0Y0_髪右2.Hit = value;
		}
	}

	public bool ハイライト右_表示
	{
		get
		{
			return X0Y0_ハイライト右.Dra;
		}
		set
		{
			X0Y0_ハイライト右.Dra = value;
			X0Y0_ハイライト右.Hit = value;
		}
	}

	public bool 髪左根1_表示
	{
		get
		{
			return X0Y0_髪左根1.Dra;
		}
		set
		{
			X0Y0_髪左根1.Dra = value;
			X0Y0_髪左根1.Hit = value;
		}
	}

	public bool 髪左根2_表示
	{
		get
		{
			return X0Y0_髪左根2.Dra;
		}
		set
		{
			X0Y0_髪左根2.Dra = value;
			X0Y0_髪左根2.Hit = value;
		}
	}

	public bool 編み左_編節1_髪節_表示
	{
		get
		{
			return X0Y0_編み左_編節1_髪節.Dra;
		}
		set
		{
			X0Y0_編み左_編節1_髪節.Dra = value;
			X0Y0_編み左_編節1_髪節.Hit = value;
		}
	}

	public bool 編み左_編節1_髪編目_表示
	{
		get
		{
			return X0Y0_編み左_編節1_髪編目.Dra;
		}
		set
		{
			X0Y0_編み左_編節1_髪編目.Dra = value;
			X0Y0_編み左_編節1_髪編目.Hit = value;
		}
	}

	public bool 編み左_編節2_髪節_表示
	{
		get
		{
			return X0Y0_編み左_編節2_髪節.Dra;
		}
		set
		{
			X0Y0_編み左_編節2_髪節.Dra = value;
			X0Y0_編み左_編節2_髪節.Hit = value;
		}
	}

	public bool 編み左_編節2_髪編目_表示
	{
		get
		{
			return X0Y0_編み左_編節2_髪編目.Dra;
		}
		set
		{
			X0Y0_編み左_編節2_髪編目.Dra = value;
			X0Y0_編み左_編節2_髪編目.Hit = value;
		}
	}

	public bool 編み左_編節3_髪節_表示
	{
		get
		{
			return X0Y0_編み左_編節3_髪節.Dra;
		}
		set
		{
			X0Y0_編み左_編節3_髪節.Dra = value;
			X0Y0_編み左_編節3_髪節.Hit = value;
		}
	}

	public bool 編み左_編節3_髪編目_表示
	{
		get
		{
			return X0Y0_編み左_編節3_髪編目.Dra;
		}
		set
		{
			X0Y0_編み左_編節3_髪編目.Dra = value;
			X0Y0_編み左_編節3_髪編目.Hit = value;
		}
	}

	public bool 髪ハネ左_表示
	{
		get
		{
			return X0Y0_髪ハネ左.Dra;
		}
		set
		{
			X0Y0_髪ハネ左.Dra = value;
			X0Y0_髪ハネ左.Hit = value;
		}
	}

	public bool 髪左3_表示
	{
		get
		{
			return X0Y0_髪左3.Dra;
		}
		set
		{
			X0Y0_髪左3.Dra = value;
			X0Y0_髪左3.Hit = value;
		}
	}

	public bool 髪左4_表示
	{
		get
		{
			return X0Y0_髪左4.Dra;
		}
		set
		{
			X0Y0_髪左4.Dra = value;
			X0Y0_髪左4.Hit = value;
		}
	}

	public bool 髪右根1_表示
	{
		get
		{
			return X0Y0_髪右根1.Dra;
		}
		set
		{
			X0Y0_髪右根1.Dra = value;
			X0Y0_髪右根1.Hit = value;
		}
	}

	public bool 髪右根2_表示
	{
		get
		{
			return X0Y0_髪右根2.Dra;
		}
		set
		{
			X0Y0_髪右根2.Dra = value;
			X0Y0_髪右根2.Hit = value;
		}
	}

	public bool 編み右_編節1_髪節_表示
	{
		get
		{
			return X0Y0_編み右_編節1_髪節.Dra;
		}
		set
		{
			X0Y0_編み右_編節1_髪節.Dra = value;
			X0Y0_編み右_編節1_髪節.Hit = value;
		}
	}

	public bool 編み右_編節1_髪編目_表示
	{
		get
		{
			return X0Y0_編み右_編節1_髪編目.Dra;
		}
		set
		{
			X0Y0_編み右_編節1_髪編目.Dra = value;
			X0Y0_編み右_編節1_髪編目.Hit = value;
		}
	}

	public bool 編み右_編節2_髪節_表示
	{
		get
		{
			return X0Y0_編み右_編節2_髪節.Dra;
		}
		set
		{
			X0Y0_編み右_編節2_髪節.Dra = value;
			X0Y0_編み右_編節2_髪節.Hit = value;
		}
	}

	public bool 編み右_編節2_髪編目_表示
	{
		get
		{
			return X0Y0_編み右_編節2_髪編目.Dra;
		}
		set
		{
			X0Y0_編み右_編節2_髪編目.Dra = value;
			X0Y0_編み右_編節2_髪編目.Hit = value;
		}
	}

	public bool 編み右_編節3_髪節_表示
	{
		get
		{
			return X0Y0_編み右_編節3_髪節.Dra;
		}
		set
		{
			X0Y0_編み右_編節3_髪節.Dra = value;
			X0Y0_編み右_編節3_髪節.Hit = value;
		}
	}

	public bool 編み右_編節3_髪編目_表示
	{
		get
		{
			return X0Y0_編み右_編節3_髪編目.Dra;
		}
		set
		{
			X0Y0_編み右_編節3_髪編目.Dra = value;
			X0Y0_編み右_編節3_髪編目.Hit = value;
		}
	}

	public bool 髪ハネ右_表示
	{
		get
		{
			return X0Y0_髪ハネ右.Dra;
		}
		set
		{
			X0Y0_髪ハネ右.Dra = value;
			X0Y0_髪ハネ右.Hit = value;
		}
	}

	public bool 髪右3_表示
	{
		get
		{
			return X0Y0_髪右3.Dra;
		}
		set
		{
			X0Y0_髪右3.Dra = value;
			X0Y0_髪右3.Hit = value;
		}
	}

	public bool 髪右4_表示
	{
		get
		{
			return X0Y0_髪右4.Dra;
		}
		set
		{
			X0Y0_髪右4.Dra = value;
			X0Y0_髪右4.Hit = value;
		}
	}

	public bool 編み左表示
	{
		get
		{
			return 編み左_編節1_髪節_表示;
		}
		set
		{
			編み左_編節1_髪節_表示 = value;
			編み左_編節1_髪編目_表示 = value;
			編み左_編節2_髪節_表示 = value;
			編み左_編節2_髪編目_表示 = value;
			編み左_編節3_髪節_表示 = value;
			編み左_編節3_髪編目_表示 = value;
		}
	}

	public bool 編み右表示
	{
		get
		{
			return 編み右_編節1_髪節_表示;
		}
		set
		{
			編み右_編節1_髪節_表示 = value;
			編み右_編節1_髪編目_表示 = value;
			編み右_編節2_髪節_表示 = value;
			編み右_編節2_髪編目_表示 = value;
			編み右_編節3_髪節_表示 = value;
			編み右_編節3_髪編目_表示 = value;
		}
	}

	public bool ハイライト表示
	{
		get
		{
			return ハイライト左_表示;
		}
		set
		{
			ハイライト左_表示 = value;
			ハイライト右_表示 = value;
		}
	}

	public double ハイライト濃度
	{
		get
		{
			return ハイライト左CD.不透明度;
		}
		set
		{
			ハイライト左CD.不透明度 = value;
			ハイライト右CD.不透明度 = value;
		}
	}

	public override bool 表示
	{
		get
		{
			return 髪基_表示;
		}
		set
		{
			髪基_表示 = value;
			髪左1_表示 = value;
			髪左2_表示 = value;
			ハイライト左_表示 = value;
			髪右1_表示 = value;
			髪右2_表示 = value;
			ハイライト右_表示 = value;
			髪左根1_表示 = value;
			髪左根2_表示 = value;
			編み左_編節1_髪節_表示 = value;
			編み左_編節1_髪編目_表示 = value;
			編み左_編節2_髪節_表示 = value;
			編み左_編節2_髪編目_表示 = value;
			編み左_編節3_髪節_表示 = value;
			編み左_編節3_髪編目_表示 = value;
			髪ハネ左_表示 = value;
			髪左3_表示 = value;
			髪左4_表示 = value;
			髪右根1_表示 = value;
			髪右根2_表示 = value;
			編み右_編節1_髪節_表示 = value;
			編み右_編節1_髪編目_表示 = value;
			編み右_編節2_髪節_表示 = value;
			編み右_編節2_髪編目_表示 = value;
			編み右_編節3_髪節_表示 = value;
			編み右_編節3_髪編目_表示 = value;
			髪ハネ右_表示 = value;
			髪右3_表示 = value;
			髪右4_表示 = value;
		}
	}

	public override double 濃度
	{
		get
		{
			return 髪基CD.不透明度;
		}
		set
		{
			髪基CD.不透明度 = value;
			髪左1CD.不透明度 = value;
			髪左2CD.不透明度 = value;
			ハイライト左CD.不透明度 = value;
			髪右1CD.不透明度 = value;
			髪右2CD.不透明度 = value;
			ハイライト右CD.不透明度 = value;
			髪左根1CD.不透明度 = value;
			髪左根2CD.不透明度 = value;
			編み左_編節1_髪節CD.不透明度 = value;
			編み左_編節1_髪編目CD.不透明度 = value;
			編み左_編節2_髪節CD.不透明度 = value;
			編み左_編節2_髪編目CD.不透明度 = value;
			編み左_編節3_髪節CD.不透明度 = value;
			編み左_編節3_髪編目CD.不透明度 = value;
			髪ハネ左CD.不透明度 = value;
			髪左3CD.不透明度 = value;
			髪左4CD.不透明度 = value;
			髪右根1CD.不透明度 = value;
			髪右根2CD.不透明度 = value;
			編み右_編節1_髪節CD.不透明度 = value;
			編み右_編節1_髪編目CD.不透明度 = value;
			編み右_編節2_髪節CD.不透明度 = value;
			編み右_編節2_髪編目CD.不透明度 = value;
			編み右_編節3_髪節CD.不透明度 = value;
			編み右_編節3_髪編目CD.不透明度 = value;
			髪ハネ右CD.不透明度 = value;
			髪右3CD.不透明度 = value;
			髪右4CD.不透明度 = value;
		}
	}

	public double 髪長
	{
		set
		{
			double num = 0.9 + 0.2 * value;
			X0Y0_髪左3.SizeYBase *= num;
			X0Y0_髪左4.SizeYBase *= num;
			X0Y0_髪右3.SizeYBase *= num;
			X0Y0_髪右4.SizeYBase *= num;
		}
	}

	public 前髪_上げ長2(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 前髪_上げ長2D e)
	{
		ThisType = GetType();
		Dif dif = new Dif();
		dif.Tag = "上げ長2";
		dif.Add(new Pars(Sta.胴体["前髪"][0][15]));
		本体 = new Difs();
		本体.Tag = dif.Tag;
		本体.Add(dif);
		Pars pars = 本体[0][0];
		X0Y0_髪基 = pars["髪基"].ToPar();
		X0Y0_髪左1 = pars["髪左1"].ToPar();
		X0Y0_髪左2 = pars["髪左2"].ToPar();
		X0Y0_ハイライト左 = pars["ハイライト左"].ToPar();
		X0Y0_髪右1 = pars["髪右1"].ToPar();
		X0Y0_髪右2 = pars["髪右2"].ToPar();
		X0Y0_ハイライト右 = pars["ハイライト右"].ToPar();
		X0Y0_髪左根1 = pars["髪左根1"].ToPar();
		X0Y0_髪左根2 = pars["髪左根2"].ToPar();
		Pars pars2 = pars["編み左"].ToPars();
		Pars pars3 = pars2["編節1"].ToPars();
		X0Y0_編み左_編節1_髪節 = pars3["髪節"].ToPar();
		X0Y0_編み左_編節1_髪編目 = pars3["髪編目"].ToPar();
		pars3 = pars2["編節2"].ToPars();
		X0Y0_編み左_編節2_髪節 = pars3["髪節"].ToPar();
		X0Y0_編み左_編節2_髪編目 = pars3["髪編目"].ToPar();
		pars3 = pars2["編節3"].ToPars();
		X0Y0_編み左_編節3_髪節 = pars3["髪節"].ToPar();
		X0Y0_編み左_編節3_髪編目 = pars3["髪編目"].ToPar();
		X0Y0_髪ハネ左 = pars["髪ハネ左"].ToPar();
		X0Y0_髪左3 = pars["髪左3"].ToPar();
		X0Y0_髪左4 = pars["髪左4"].ToPar();
		X0Y0_髪右根1 = pars["髪右根1"].ToPar();
		X0Y0_髪右根2 = pars["髪右根2"].ToPar();
		Pars pars4 = pars["編み右"].ToPars();
		pars3 = pars4["編節1"].ToPars();
		X0Y0_編み右_編節1_髪節 = pars3["髪節"].ToPar();
		X0Y0_編み右_編節1_髪編目 = pars3["髪編目"].ToPar();
		pars3 = pars4["編節2"].ToPars();
		X0Y0_編み右_編節2_髪節 = pars3["髪節"].ToPar();
		X0Y0_編み右_編節2_髪編目 = pars3["髪編目"].ToPar();
		pars3 = pars4["編節3"].ToPars();
		X0Y0_編み右_編節3_髪節 = pars3["髪節"].ToPar();
		X0Y0_編み右_編節3_髪編目 = pars3["髪編目"].ToPar();
		X0Y0_髪ハネ右 = pars["髪ハネ右"].ToPar();
		X0Y0_髪右3 = pars["髪右3"].ToPar();
		X0Y0_髪右4 = pars["髪右4"].ToPar();
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
		髪基_表示 = e.髪基_表示;
		髪左1_表示 = e.髪左1_表示;
		髪左2_表示 = e.髪左2_表示;
		ハイライト左_表示 = e.ハイライト左_表示;
		髪右1_表示 = e.髪右1_表示;
		髪右2_表示 = e.髪右2_表示;
		ハイライト右_表示 = e.ハイライト右_表示;
		髪左根1_表示 = e.髪左根1_表示;
		髪左根2_表示 = e.髪左根2_表示;
		編み左_編節1_髪節_表示 = e.編み左_編節1_髪節_表示;
		編み左_編節1_髪編目_表示 = e.編み左_編節1_髪編目_表示;
		編み左_編節2_髪節_表示 = e.編み左_編節2_髪節_表示;
		編み左_編節2_髪編目_表示 = e.編み左_編節2_髪編目_表示;
		編み左_編節3_髪節_表示 = e.編み左_編節3_髪節_表示;
		編み左_編節3_髪編目_表示 = e.編み左_編節3_髪編目_表示;
		髪ハネ左_表示 = e.髪ハネ左_表示;
		髪左3_表示 = e.髪左3_表示;
		髪左4_表示 = e.髪左4_表示;
		髪右根1_表示 = e.髪右根1_表示;
		髪右根2_表示 = e.髪右根2_表示;
		編み右_編節1_髪節_表示 = e.編み右_編節1_髪節_表示;
		編み右_編節1_髪編目_表示 = e.編み右_編節1_髪編目_表示;
		編み右_編節2_髪節_表示 = e.編み右_編節2_髪節_表示;
		編み右_編節2_髪編目_表示 = e.編み右_編節2_髪編目_表示;
		編み右_編節3_髪節_表示 = e.編み右_編節3_髪節_表示;
		編み右_編節3_髪編目_表示 = e.編み右_編節3_髪編目_表示;
		髪ハネ右_表示 = e.髪ハネ右_表示;
		髪右3_表示 = e.髪右3_表示;
		髪右4_表示 = e.髪右4_表示;
		編み左表示 = e.編み左表示;
		編み右表示 = e.編み右表示;
		ハイライト表示 = e.ハイライト表示;
		髪長 = e.髪長;
		欠損 = e.欠損;
		筋肉 = e.筋肉;
		拘束 = e.拘束;
		if (!e.表示)
		{
			表示 = false;
		}
		base.配色指定 = 配色指定;
		配色(体配色);
		X0Y0_髪基CP = new ColorP(X0Y0_髪基, 髪基CD, DisUnit, abj: false);
		X0Y0_髪左1CP = new ColorP(X0Y0_髪左1, 髪左1CD, DisUnit, abj: false);
		X0Y0_髪左2CP = new ColorP(X0Y0_髪左2, 髪左2CD, DisUnit, abj: false);
		X0Y0_ハイライト左CP = new ColorP(X0Y0_ハイライト左, ハイライト左CD, DisUnit, abj: false);
		X0Y0_髪右1CP = new ColorP(X0Y0_髪右1, 髪右1CD, DisUnit, abj: false);
		X0Y0_髪右2CP = new ColorP(X0Y0_髪右2, 髪右2CD, DisUnit, abj: false);
		X0Y0_ハイライト右CP = new ColorP(X0Y0_ハイライト右, ハイライト右CD, DisUnit, abj: false);
		X0Y0_髪左根1CP = new ColorP(X0Y0_髪左根1, 髪左根1CD, DisUnit, abj: false);
		X0Y0_髪左根2CP = new ColorP(X0Y0_髪左根2, 髪左根2CD, DisUnit, abj: false);
		X0Y0_編み左_編節1_髪節CP = new ColorP(X0Y0_編み左_編節1_髪節, 編み左_編節1_髪節CD, DisUnit, abj: false);
		X0Y0_編み左_編節1_髪編目CP = new ColorP(X0Y0_編み左_編節1_髪編目, 編み左_編節1_髪編目CD, DisUnit, abj: false);
		X0Y0_編み左_編節2_髪節CP = new ColorP(X0Y0_編み左_編節2_髪節, 編み左_編節2_髪節CD, DisUnit, abj: false);
		X0Y0_編み左_編節2_髪編目CP = new ColorP(X0Y0_編み左_編節2_髪編目, 編み左_編節2_髪編目CD, DisUnit, abj: false);
		X0Y0_編み左_編節3_髪節CP = new ColorP(X0Y0_編み左_編節3_髪節, 編み左_編節3_髪節CD, DisUnit, abj: false);
		X0Y0_編み左_編節3_髪編目CP = new ColorP(X0Y0_編み左_編節3_髪編目, 編み左_編節3_髪編目CD, DisUnit, abj: false);
		X0Y0_髪ハネ左CP = new ColorP(X0Y0_髪ハネ左, 髪ハネ左CD, DisUnit, abj: false);
		X0Y0_髪左3CP = new ColorP(X0Y0_髪左3, 髪左3CD, DisUnit, abj: false);
		X0Y0_髪左4CP = new ColorP(X0Y0_髪左4, 髪左4CD, DisUnit, abj: false);
		X0Y0_髪右根1CP = new ColorP(X0Y0_髪右根1, 髪右根1CD, DisUnit, abj: false);
		X0Y0_髪右根2CP = new ColorP(X0Y0_髪右根2, 髪右根2CD, DisUnit, abj: false);
		X0Y0_編み右_編節1_髪節CP = new ColorP(X0Y0_編み右_編節1_髪節, 編み右_編節1_髪節CD, DisUnit, abj: false);
		X0Y0_編み右_編節1_髪編目CP = new ColorP(X0Y0_編み右_編節1_髪編目, 編み右_編節1_髪編目CD, DisUnit, abj: false);
		X0Y0_編み右_編節2_髪節CP = new ColorP(X0Y0_編み右_編節2_髪節, 編み右_編節2_髪節CD, DisUnit, abj: false);
		X0Y0_編み右_編節2_髪編目CP = new ColorP(X0Y0_編み右_編節2_髪編目, 編み右_編節2_髪編目CD, DisUnit, abj: false);
		X0Y0_編み右_編節3_髪節CP = new ColorP(X0Y0_編み右_編節3_髪節, 編み右_編節3_髪節CD, DisUnit, abj: false);
		X0Y0_編み右_編節3_髪編目CP = new ColorP(X0Y0_編み右_編節3_髪編目, 編み右_編節3_髪編目CD, DisUnit, abj: false);
		X0Y0_髪ハネ右CP = new ColorP(X0Y0_髪ハネ右, 髪ハネ右CD, DisUnit, abj: false);
		X0Y0_髪右3CP = new ColorP(X0Y0_髪右3, 髪右3CD, DisUnit, abj: false);
		X0Y0_髪右4CP = new ColorP(X0Y0_髪右4, 髪右4CD, DisUnit, abj: false);
		ハイライト濃度 = e.ハイライト濃度;
		濃度 = e.濃度;
	}

	public override void 色更新()
	{
		X0Y0_髪基CP.Update();
		X0Y0_髪左1CP.Update();
		X0Y0_髪左2CP.Update();
		X0Y0_ハイライト左CP.Update();
		X0Y0_髪右1CP.Update();
		X0Y0_髪右2CP.Update();
		X0Y0_ハイライト右CP.Update();
		X0Y0_髪左根1CP.Update();
		X0Y0_髪左根2CP.Update();
		X0Y0_編み左_編節1_髪節CP.Update();
		X0Y0_編み左_編節1_髪編目CP.Update();
		X0Y0_編み左_編節2_髪節CP.Update();
		X0Y0_編み左_編節2_髪編目CP.Update();
		X0Y0_編み左_編節3_髪節CP.Update();
		X0Y0_編み左_編節3_髪編目CP.Update();
		X0Y0_髪ハネ左CP.Update();
		X0Y0_髪左3CP.Update();
		X0Y0_髪左4CP.Update();
		X0Y0_髪右根1CP.Update();
		X0Y0_髪右根2CP.Update();
		X0Y0_編み右_編節1_髪節CP.Update();
		X0Y0_編み右_編節1_髪編目CP.Update();
		X0Y0_編み右_編節2_髪節CP.Update();
		X0Y0_編み右_編節2_髪編目CP.Update();
		X0Y0_編み右_編節3_髪節CP.Update();
		X0Y0_編み右_編節3_髪編目CP.Update();
		X0Y0_髪ハネ右CP.Update();
		X0Y0_髪右3CP.Update();
		X0Y0_髪右4CP.Update();
	}

	private void 配色(体配色 体配色)
	{
		配色N0(体配色);
	}

	private void 配色N0(体配色 体配色)
	{
		髪基CD = new ColorD(ref Col.Empty, ref Color2.Empty);
		髪左1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		髪左2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		ハイライト左CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
		髪右1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		髪右2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		ハイライト右CD = new ColorD(ref Col.Empty, ref 体配色.ハイライト2O);
		髪左根1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		髪左根2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		編み左_編節1_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		編み左_編節1_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		編み左_編節2_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		編み左_編節2_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		編み左_編節3_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		編み左_編節3_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		髪ハネ左CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		髪左3CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		髪左4CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		髪右根1CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		髪右根2CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		編み右_編節1_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		編み右_編節1_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		編み右_編節2_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		編み右_編節2_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		編み右_編節3_髪節CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		編み右_編節3_髪編目CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		髪ハネ右CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		髪右3CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
		髪右4CD = new ColorD(ref 体配色.髪線, ref 体配色.髪O);
	}
}
