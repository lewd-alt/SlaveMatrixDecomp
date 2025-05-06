using _2DGAMELIB;
using SlaveMatrix.GameClasses;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace SlaveMatrix;

public static class SpeciesDefaults
{
	public static double 葉倍率 = 0.8;

	public static void AdjustScale(this 腰D 腰, 頭D 頭)
	{
		foreach (EleD item in 頭.EnumEleD())
		{
			if (!(item is 後髪0D) && !(item is 後髪1D) && !(item is 横髪D) && !(item is 前髪D))
			{
				item.尺度B *= 0.98;
			}
		}
		foreach (EleD item2 in 腰.EnumEleD())
		{
			item2.尺度B *= 1.065;
		}
	}

	public static void SetLowerHair(this 腰D 腰)
	{
		腰肌D eleD = 腰.肌_接続.GetEleD<腰肌D>();
		if (eleD.獣性_獣毛_表示)
		{
			if (RNG.XS.NextBool())
			{
				eleD.獣性_獣毛_表示 = false;
				eleD.陰毛_表示 = true;
			}
		}
		else if (eleD.陰毛_表示)
		{
			if (0.023.Lot())
			{
				eleD.陰毛_表示 = false;
			}
		}
		else if (0.023.Inverse().Lot())
		{
			eleD.陰毛_表示 = true;
		}
	}

	public static ChaD GetHarpy()
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		switch (RNG.XS.Next(4))
		{
		case 0:
			頭D2.Set耳人();
			break;
		case 1:
			頭D2.Set耳尖();
			break;
		case 2:
			頭D2.Set耳獣();
			break;
		default:
			頭D2.Set耳羽();
			break;
		}
		手_鳥D 手_鳥D2 = new 手_鳥D
		{
			シャープ = RNG.XS.NextDouble()
		};
		下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D
		{
			シャープ = 手_鳥D2.シャープ
		};
		下腕_鳥D2.手接続(手_鳥D2);
		上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D
		{
			シャープ = 下腕_鳥D2.シャープ
		};
		上腕_鳥D2.下腕接続(下腕_鳥D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_鳥D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		胸D2.背中接続(new 背中_羽D());
		足_鳥D e = new 足_鳥D();
		脚_鳥D 脚_鳥D2 = new 脚_鳥D();
		脚_鳥D2.足接続(e);
		腿_鳥D 腿_鳥D2 = new 腿_鳥D();
		腿_鳥D2.脚接続(脚_鳥D2);
		腰D2.腿左接続(腿_鳥D2);
		腰D2.腿右接続(腿_鳥D2.Get逆());
		腰D2.尾接続(new 尾_鳥D());
		bool flag = 頭D2.EnumEleD().IsEleD<耳_羽D>() || 頭D2.EnumEleD().IsEleD<耳_獣D>();
		腰D2.EnumEleD().SetValuesD("獣性", flag);
		腰D2.EnumEleD().SetValuesD<頬肌D>("髭", false);
		if (flag)
		{
			腰D2.EnumEleD().SetValuesD<胸毛D>("表示", RNG.XS.NextBool());
		}
		else
		{
			腰D2.EnumEleD().SetValuesD<胸毛D>("表示", false);
		}
		腰D2.EnumEleD().SetValuesD<腰肌D>("獣性", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getアフール()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻R();
		頭D2.Set口人();
		頭D2.Set舌短();
		EleD eleD2 = new 獣耳D
		{
			尺度B = 1.2
		};
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_蝙D e = new 手_蝙D();
		下腕_蝙D 下腕_蝙D2 = new 下腕_蝙D();
		下腕_蝙D2.手接続(e);
		上腕_蝙D 上腕_蝙D2 = new 上腕_蝙D();
		上腕_蝙D2.下腕接続(下腕_蝙D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_蝙D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		足_獣D e2 = new 足_獣D();
		脚_獣D 脚_獣D2 = new 脚_獣D();
		脚_獣D2.足接続(e2);
		腿_獣D 腿_獣D2 = new 腿_獣D();
		腿_獣D2.脚接続(脚_獣D2);
		obj.腿左接続(腿_獣D2);
		obj.腿右接続(腿_獣D2.Get逆());
		obj.尾接続(new 尾_悪D());
		obj.EnumEleD().SetValuesD("獣性", true);
		obj.EnumEleD().SetValuesD<頬肌D>("髭", false);
		obj.EnumEleD().SetValuesD<胸毛D>("表示", RNG.XS.NextBool());
		obj.EnumEleD().SetValuesD<口_通常D>("牙", true);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: false));
	}

	public static ChaD Getハルピュイア()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		if (RNG.XS.NextBool())
		{
			頭D2.Set耳人();
		}
		else
		{
			頭D2.Set耳尖();
		}
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		手_蝙D e2 = new 手_蝙D
		{
			シャープ = 1.0
		};
		下腕_蝙D 下腕_蝙D2 = new 下腕_蝙D();
		下腕_蝙D2.手接続(e2);
		上腕_蝙D 上腕_蝙D2 = new 上腕_蝙D();
		上腕_蝙D2.下腕接続(下腕_蝙D2);
		obj2.翼上左接続(上腕_蝙D2);
		obj2.翼上右接続(上腕_蝙D2.Get逆());
		長物_鯨D 長物_鯨D2 = new 長物_鯨D();
		obj.半身接続(長物_鯨D2);
		長物_鯨D2.尾接続(new 尾_鯨D());
		obj.EnumEleD().SetValuesD<上腕_人D>("獣毛1", true);
		obj.EnumEleD().SetValuesD<下腕_人D>("獣腕", true);
		obj.EnumEleD().SetValuesD<手_人D>("獣性", true);
		obj.EnumEleD().SetValuesD<手_人D>("肉球", false);
		obj.EnumEleD().SetValuesD<下腕_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD("柄", false);
		obj.EnumEleD().SetValuesD("紋柄", true);
		obj.EnumEleD().SetValuesD<鼻肌D>("紋柄", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD GetPhoenix()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳羽();
		手_鳥D 手_鳥D2 = new 手_鳥D
		{
			シャープ = RNG.XS.NextDouble()
		};
		下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D
		{
			シャープ = 手_鳥D2.シャープ
		};
		下腕_鳥D2.手接続(手_鳥D2);
		上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D
		{
			シャープ = 下腕_鳥D2.シャープ
		};
		上腕_鳥D2.下腕接続(下腕_鳥D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_鳥D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		obj2.背中接続(new 背中_羽D());
		足_鳥D e = new 足_鳥D();
		脚_鳥D 脚_鳥D2 = new 脚_鳥D();
		脚_鳥D2.足接続(e);
		腿_鳥D 腿_鳥D2 = new 腿_鳥D();
		腿_鳥D2.脚接続(脚_鳥D2);
		obj.腿左接続(腿_鳥D2);
		obj.腿右接続(腿_鳥D2.Get逆());
		obj.尾接続(new 鳳凰D());
		obj.尾接続(new 鳳凰D());
		obj.尾接続(new 鳳凰D());
		obj.尾接続(new 鳳凰D());
		obj.尾接続(new 鳳凰D());
		obj.尾接続(new 尾_鳥D());
		obj.EnumEleD().SetValuesD("獣性", true);
		obj.EnumEleD().SetValuesD<頬肌D>("髭", false);
		obj.EnumEleD().SetValuesD("隈取", true);
		頭D2.隈取_タトゥ_表示 = false;
		obj.EnumEleD().SetValuesD("淫", true);
		obj.EnumEleD().SetValuesD("ハート", false);
		obj.SetValuesD("悪", true);
		obj.EnumEleD().SetValuesD("植", true);
		obj.EnumEleD().SetValuesD<足_鳥D>("竜性", true);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: false));
	}

	public static ChaD Getラミア()
	{
		腰D 腰D2 = Uni.腰();
		胸D obj = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = obj.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌長();
		if (RNG.XS.NextBool())
		{
			頭D2.Set耳人();
		}
		else
		{
			頭D2.Set耳尖();
		}
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj.肩左接続(肩D2);
		obj.肩右接続(肩D2.Get逆());
		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
		腰D2.半身接続(長物_蛇D2);
		長物_蛇D2.くぱぁ = 1.0;
		長物_蛇D2.ガード = false;
		胴_蛇D 胴_蛇D2 = new 胴_蛇D();
		長物_蛇D2.胴接続(胴_蛇D2);
		for (int i = 0; i < 40; i++)
		{
			胴_蛇D2.胴接続(胴_蛇D2 = new 胴_蛇D());
		}
		胴_蛇D2.胴接続(new 尾_ヘD());
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD<舌_長D>("股舌表示", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getシーラミア()
	{
		腰D 腰D2 = Uni.腰();
		胸D obj = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = obj.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌長();
		頭D2.Set耳鰭();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj.肩左接続(肩D2);
		obj.肩右接続(肩D2.Get逆());
		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
		腰D2.半身接続(長物_蛇D2);
		if (RNG.XS.NextBool())
		{
			長物_蛇D2.くぱぁ = 1.0;
			長物_蛇D2.ガード = false;
		}
		胴_蛇D 胴_蛇D2 = new 胴_蛇D();
		長物_蛇D2.胴接続(胴_蛇D2);
		for (int i = 0; i < 40; i++)
		{
			胴_蛇D2.胴接続(胴_蛇D2 = new 胴_蛇D());
		}
		胴_蛇D2.胴接続(new 尾_ウD());
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD<舌_長D>("股舌表示", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getオノケンタウレ()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳獣();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		obj.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		手_馬D e2 = new 手_馬D();
		下腕_蹄D 下腕_蹄D2 = new 下腕_蹄D();
		下腕_蹄D2.手接続(e2);
		上腕_蹄D 上腕_蹄D2 = new 上腕_蹄D();
		上腕_蹄D2.下腕接続(下腕_蹄D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_蹄D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_馬D e3 = new 足_馬D();
		脚_蹄D 脚_蹄D2 = new 脚_蹄D();
		脚_蹄D2.足接続(e3);
		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
		腿_蹄D2.脚接続(脚_蹄D2);
		四足腰D2.腿左接続(腿_蹄D2);
		四足腰D2.腿右接続(腿_蹄D2.Get逆());
		四足腰D2.尾接続(new 尾_牛D());
		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		obj.EnumEleD().SetValuesD<腰肌D>("獣性", true);
		四足腰D2.EnumEleD().SetValuesD<腰肌D>("獣性", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 0.0);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getヒッポケンタウレ()
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		if (RNG.XS.Next(2) == 0)
		{
			頭D2.Set耳人();
		}
		else
		{
			頭D2.Set耳尖();
		}
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		腰D2.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		手_馬D e2 = new 手_馬D();
		下腕_蹄D 下腕_蹄D2 = new 下腕_蹄D();
		下腕_蹄D2.手接続(e2);
		上腕_蹄D 上腕_蹄D2 = new 上腕_蹄D();
		上腕_蹄D2.下腕接続(下腕_蹄D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_蹄D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_馬D e3 = new 足_馬D();
		脚_蹄D 脚_蹄D2 = new 脚_蹄D();
		脚_蹄D2.足接続(e3);
		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
		腿_蹄D2.脚接続(脚_蹄D2);
		四足腰D2.腿左接続(腿_蹄D2);
		四足腰D2.腿右接続(腿_蹄D2.Get逆());
		四足腰D2.尾接続(new 尾_馬D());
		if (RNG.XS.NextBool())
		{
			腰D2.EnumEleD().SetValuesD<頭D>("馬", RNG.XS.NextBool());
		}
		腰D2.EnumEleD().SetValuesD<性器_人D>("表示", false);
		腰D2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		腰D2.EnumEleD().SetValuesD<腰肌D>("獣性", true);
		四足腰D2.EnumEleD().SetValuesD<腰肌D>("獣性", false);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getブケンタウレ()
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳獣();
		EleD eleD2 = RNG.XS.Next(4) switch
		{
			0 => new 角2_牛1D(), 
			1 => new 角2_牛2D(), 
			2 => new 角2_牛3D(), 
			_ => new 角2_牛4D(), 
		};
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		腰D2.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		手_牛D e2 = new 手_牛D();
		下腕_蹄D 下腕_蹄D2 = new 下腕_蹄D();
		下腕_蹄D2.手接続(e2);
		上腕_蹄D 上腕_蹄D2 = new 上腕_蹄D();
		上腕_蹄D2.下腕接続(下腕_蹄D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_蹄D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_牛D e3 = new 足_牛D();
		脚_蹄D 脚_蹄D2 = new 脚_蹄D();
		脚_蹄D2.足接続(e3);
		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
		腿_蹄D2.脚接続(脚_蹄D2);
		四足腰D2.腿左接続(腿_蹄D2);
		四足腰D2.腿右接続(腿_蹄D2.Get逆());
		四足腰D2.尾接続(new 尾_牛D());
		if (RNG.XS.NextBool())
		{
			腰D2.EnumEleD().SetValuesD<頬肌D>("牛", true);
			腰D2.EnumEleD().SetValuesD<四足脇D>("配色指定", 配色指定.H0);
		}
		腰D2.EnumEleD().SetValuesD<性器_人D>("表示", false);
		腰D2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		腰D2.EnumEleD().SetValuesD<腰肌D>("獣性", true);
		四足腰D2.EnumEleD().SetValuesD<腰肌D>("獣性", false);
		腰D2.EnumEleD().SetValuesD("バスト", 1.0);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getカプラケンタウレ()
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳獣();
		EleD eleD2 = RNG.XS.Next(4) switch
		{
			0 => new 角2_山1D(), 
			1 => new 角2_山2D(), 
			2 => new 角2_山3D(), 
			_ => new 角2_巻D(), 
		};
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		腰D2.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		四足胸D2.背中接続(new 背中_羽D
		{
			毛 = true
		});
		手_牛D e2 = new 手_牛D();
		下腕_蹄D 下腕_蹄D2 = new 下腕_蹄D();
		下腕_蹄D2.手接続(e2);
		上腕_蹄D 上腕_蹄D2 = new 上腕_蹄D();
		上腕_蹄D2.下腕接続(下腕_蹄D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_蹄D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_牛D e3 = new 足_牛D();
		脚_蹄D 脚_蹄D2 = new 脚_蹄D();
		脚_蹄D2.足接続(e3);
		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
		腿_蹄D2.脚接続(脚_蹄D2);
		四足腰D2.腿左接続(腿_蹄D2);
		四足腰D2.腿右接続(腿_蹄D2.Get逆());
		四足腰D2.尾接続(new 尾_犬D());
		四足胴D2.SetValuesD("獣毛", true);
		腰D2.EnumEleD().SetValuesD("胸毛", true);
		腰D2.EnumEleD().SetValuesD<腰肌D>("獣毛", true);
		腰D2.EnumEleD().SetValuesD<性器_人D>("表示", false);
		腰D2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		腰D2.EnumEleD().SetValuesD<双目D>("蛸目", RNG.XS.NextBool());
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getマーメイド()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳人();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		長物_魚D 長物_魚D2 = new 長物_魚D();
		obj.半身接続(長物_魚D2);
		尾_魚D 尾_魚D2 = new 尾_魚D();
		長物_魚D2.尾接続(尾_魚D2);
		尾_魚D2.尾先接続(new 尾鰭_魚D());
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getドルフィンマーメイド()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳尖();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		長物_鯨D 長物_鯨D2 = new 長物_鯨D();
		obj.半身接続(長物_鯨D2);
		尾_鯨D 尾_鯨D2 = new 尾_鯨D();
		長物_鯨D2.尾接続(尾_鯨D2);
		尾_鯨D2.尾先接続(new 尾鰭_鯨D());
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getオールドマーメイド()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳人();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		尾_魚D 尾_魚D2 = new 尾_魚D();
		尾_魚D2.尺度B = 1.2;
		尾_魚D2.尺度YB = 1.5;
		尾_魚D2.尾0_表示 = false;
		尾_魚D2.尾0_鱗右_鱗1_表示 = false;
		尾_魚D2.尾0_鱗右_鱗2_表示 = false;
		尾_魚D2.尾先接続(new 尾鰭_魚D());
		obj.腿左接続(尾_魚D2);
		obj.腿右接続(尾_魚D2.Get逆());
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getイクテュオケンタウレ(bool b)
	{
		腰D 腰D2 = Uni.腰();
		胸D obj = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = obj.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳鰭();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj.肩左接続(肩D2);
		obj.肩右接続(肩D2.Get逆());
		if (b)
		{
			長物_魚D 長物_魚D2 = new 長物_魚D();
			腰D2.半身接続(長物_魚D2);
			EleD eleD = new 鰭_魚D();
			長物_魚D2.左0接続(eleD);
			長物_魚D2.右0接続(eleD.Get逆());
			尾_魚D 尾_魚D2 = new 尾_魚D();
			長物_魚D2.尾接続(尾_魚D2);
			尾_魚D2.尾先接続(new 尾鰭_魚D());
		}
		else
		{
			長物_蛇D 長物_蛇D2 = new 長物_蛇D();
			腰D2.半身接続(長物_蛇D2);
			if (RNG.XS.NextBool())
			{
				長物_蛇D2.くぱぁ = 1.0;
				長物_蛇D2.ガード = false;
			}
			EleD eleD = new 鰭_魚D();
			長物_蛇D2.左接続(eleD);
			長物_蛇D2.右接続(eleD.Get逆());
			胴_蛇D 胴_蛇D2 = new 胴_蛇D();
			長物_蛇D2.胴接続(胴_蛇D2);
			尾_ヘD 尾_ヘD2 = new 尾_ヘD();
			胴_蛇D2.胴接続(尾_ヘD2);
			尾_ヘD2.尾先接続(new 尾鰭_魚D());
		}
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getデルピヌスケンタウレ()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳尖();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		長物_鯨D 長物_鯨D2 = new 長物_鯨D();
		obj.半身接続(長物_鯨D2);
		EleD eleD = new 鰭_豚D();
		長物_鯨D2.左0接続(eleD);
		長物_鯨D2.右0接続(eleD.Get逆());
		尾_鯨D 尾_鯨D2 = new 尾_鯨D();
		長物_鯨D2.尾接続(尾_鯨D2);
		尾_鯨D2.尾先接続(new 尾鰭_鯨D());
		obj.EnumEleD().SetValuesD<頬肌D>("豹", true);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getスキュラ()
	{
		腰D 腰D2 = Uni.腰();
		胸D obj = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = obj.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		if (RNG.XS.NextBool())
		{
			頭D2.Set耳尖();
		}
		else
		{
			頭D2.Set耳人();
		}
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj.肩左接続(肩D2);
		obj.肩右接続(肩D2.Get逆());
		多足_蛸D 多足_蛸D2 = new 多足_蛸D();
		腰D2.半身接続(多足_蛸D2);
		触手_軟D 触手_軟D2 = new 触手_軟D
		{
			後足 = true
		};
		触手_軟D 触手_軟D3 = new 触手_軟D
		{
			前足 = true
		};
		if (RNG.XS.NextBool())
		{
			触手_軟D2.SetValuesD("鎧", true);
			触手_軟D3.SetValuesD("鎧", true);
		}
		多足_蛸D2.軟体内左接続(触手_軟D2.Copy());
		多足_蛸D2.軟体内右接続(触手_軟D2.Get逆());
		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
		if (RNG.XS.NextBool())
		{
			腰D2.EnumEleD().SetValuesD("紋柄", true);
		}
		if (RNG.XS.NextBool())
		{
			腰D2.EnumEleD().SetValuesD<鼻肌D>("紋柄", false);
		}
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getオールドスキュラ(bool b)
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		if (RNG.XS.NextBool())
		{
			頭D2.Set耳尖();
		}
		else
		{
			頭D2.Set耳人();
		}
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		触手_犬D 触手_犬D2 = new 触手_犬D();
		触手_犬D2.SetValuesD("脚", b);
		if (b)
		{
			触手_犬D2.SetValuesD("鰭", RNG.XS.NextBool());
		}
		obj.腿左接続(触手_犬D2.Copy());
		obj.腿右接続(触手_犬D2.Get逆());
		obj.腿左接続(触手_犬D2.Copy());
		obj.腿右接続(触手_犬D2.Get逆());
		obj.腿左接続(触手_犬D2.Copy());
		obj.腿右接続(触手_犬D2.Get逆());
		長物_魚D 長物_魚D2 = new 長物_魚D();
		obj.半身接続(長物_魚D2);
		尾_魚D 尾_魚D2 = new 尾_魚D();
		長物_魚D2.尾接続(尾_魚D2);
		尾_魚D2.尾先接続(new 尾鰭_魚D());
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getカリュブディス()
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口裂();
		頭D2.Set舌長();
		頭D2.Set耳鰭();
		EleD eleD2 = RNG.XS.Next(4) switch
		{
			0 => new 角2_牛1D(), 
			1 => new 角2_牛2D(), 
			2 => new 角2_牛3D(), 
			_ => new 角2_牛4D(), 
		};
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		長物_鯨D 長物_鯨D2 = new 長物_鯨D();
		腰D2.半身接続(長物_鯨D2);
		eleD2 = new 鰭_鯨D();
		長物_鯨D2.左0接続(eleD2);
		長物_鯨D2.右0接続(eleD2.Get逆());
		尾_鯨D 尾_鯨D2 = new 尾_鯨D();
		長物_鯨D2.尾接続(尾_鯨D2);
		尾_鯨D2.尾先接続(new 尾鰭_鯨D());
		腰D2.EnumEleD().SetValuesD("水掻", true);
		腰D2.EnumEleD().SetValuesD("竜性", true);
		腰D2.EnumEleD().SetValuesD("獣毛", true);
		腰D2.EnumEleD().SetValuesD<胸毛D>("表示", true);
		腰D2.EnumEleD().SetValuesD("悪", true);
		腰D2.EnumEleD().SetValuesD<下腕_人D>("悪", false);
		腰D2.EnumEleD().SetValuesD<手_人D>("悪", false);
		腰D2.EnumEleD().SetValuesD("逆十字", false);
		腰D2.EnumEleD().SetValuesD<上腕_人D>("淫", true);
		腰D2.EnumEleD().SetValuesD<腰D>("鱗", false);
		腰D2.EnumEleD().SetValuesD<腰D>("毛", false);
		腰D2.EnumEleD().SetValuesD<腰肌D>("鱗", false);
		腰D2.EnumEleD().SetValuesD<腰肌D>("毛", false);
		腰D2.EnumEleD().SetValuesD<手_人D>("配色", 配色指定.S0);
		腰D2.EnumEleD().SetValuesD("肥大", 1.0);
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getアラクネ(bool b)
	{
		腰D 腰D2 = Uni.腰();
		胸D obj = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = obj.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		if (RNG.XS.NextBool())
		{
			頭D2.Set耳尖();
		}
		else
		{
			頭D2.Set耳人();
		}
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj.肩左接続(肩D2);
		obj.肩右接続(肩D2.Get逆());
		if (RNG.XS.NextBool())
		{
			EleD eleD = new 虫顎D();
			頭D2.頬左接続(eleD);
			頭D2.頬右接続(eleD.Get逆());
		}
		多足_蜘D 多足_蜘D2 = new 多足_蜘D();
		腰D2.半身接続(多足_蜘D2);
		尾_蜘D 尾_蜘D2 = new 尾_蜘D();
		尾_蜘D2.出糸 = RNG.XS.NextBool();
		多足_蜘D2.尾接続(尾_蜘D2);
		触肢_肢蜘D 触肢_肢蜘D2 = new 触肢_肢蜘D();
		節足_足蜘D 節足_足蜘D2 = new 節足_足蜘D();
		節足_足蜘D2.爪 = b;
		EleD eleD2 = 節足_足蜘D2.Copy();
		EleD eleD3 = 節足_足蜘D2.Copy();
		eleD3.反転Y = !尾_蜘D2.出糸;
		EleD eleD4 = 節足_足蜘D2.Copy();
		eleD4.反転Y = eleD3.反転Y;
		多足_蜘D2.触肢左接続(触肢_肢蜘D2);
		多足_蜘D2.節足左1接続(節足_足蜘D2);
		多足_蜘D2.節足左2接続(eleD2);
		多足_蜘D2.節足左3接続(eleD3);
		多足_蜘D2.節足左4接続(eleD4);
		多足_蜘D2.触肢右接続(触肢_肢蜘D2.Get逆());
		多足_蜘D2.節足右1接続(節足_足蜘D2.Get逆());
		多足_蜘D2.節足右2接続(eleD2.Get逆());
		多足_蜘D2.節足右3接続(eleD3.Get逆());
		多足_蜘D2.節足右4接続(eleD4.Get逆());
		if (RNG.XS.NextBool())
		{
			腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		}
		if (RNG.XS.NextBool())
		{
			多足_蜘D2.EnumEleD().SetValuesD("柄", true);
		}
		腰D2.EnumEleD().SetValuesD<頭D>("蜘", 頭D2.頬左_接続.IsEleD<虫顎D>() || RNG.XS.NextBool());
		腰D2.EnumEleD().SetValuesD<頬肌D>("蜘", RNG.XS.NextBool());
		腰D2.EnumEleD().SetValuesD<胸肌D>("蜘", RNG.XS.NextBool());
		if (頭D2.頬左_接続.IsEleD<虫顎D>())
		{
			腰D2.EnumEleD().SetValuesD<頬肌D>("蜘", false);
		}
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getギルタブリル()
	{
		腰D 腰D2 = Uni.腰();
		胸D obj = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = obj.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		if (RNG.XS.NextBool())
		{
			頭D2.Set耳尖();
		}
		else
		{
			頭D2.Set耳人();
		}
		if (RNG.XS.NextBool())
		{
			EleD eleD = new 虫顎D();
			頭D2.頬左接続(eleD);
			頭D2.頬右接続(eleD.Get逆());
		}
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj.肩左接続(肩D2);
		obj.肩右接続(肩D2.Get逆());
		多足_蠍D 多足_蠍D2 = new 多足_蠍D();
		腰D2.半身接続(多足_蠍D2);
		多足_蠍D2.前腹_腹節3_節線_表示 = RNG.XS.NextBool();
		多足_蠍D2.前腹_腹節4_節線_表示 = 多足_蠍D2.前腹_腹節3_節線_表示;
		多足_蠍D2.前腹_腹節5_節線_表示 = 多足_蠍D2.前腹_腹節3_節線_表示;
		多足_蠍D2.前腹_腹節6_節線_表示 = 多足_蠍D2.前腹_腹節3_節線_表示;
		触肢_肢蠍D 触肢_肢蠍D2 = new 触肢_肢蠍D();
		節足_足蠍D 節足_足蠍D2 = new 節足_足蠍D();
		節足_足蠍D2.爪 = RNG.XS.NextBool();
		EleD eleD2 = 節足_足蠍D2.Copy();
		EleD eleD3 = 節足_足蠍D2.Copy();
		EleD eleD4 = 節足_足蠍D2.Copy();
		多足_蠍D2.触肢左接続(触肢_肢蠍D2);
		多足_蠍D2.節足左1接続(節足_足蠍D2);
		多足_蠍D2.節足左2接続(eleD2);
		多足_蠍D2.節足左3接続(eleD3);
		多足_蠍D2.節足左4接続(eleD4);
		多足_蠍D2.触肢右接続(触肢_肢蠍D2.Get逆());
		多足_蠍D2.節足右1接続(節足_足蠍D2.Get逆());
		多足_蠍D2.節足右2接続(eleD2.Get逆());
		多足_蠍D2.節足右3接続(eleD3.Get逆());
		多足_蠍D2.節足右4接続(eleD4.Get逆());
		if (RNG.XS.NextBool())
		{
			EleD eleD = new 触覚_蠍D();
			多足_蠍D2.櫛状板左接続(eleD);
			多足_蠍D2.櫛状板右接続(eleD.Get逆());
		}
		多足_蠍D2.尾接続(new 尾_蠍D());
		腰D2.EnumEleD().SetValuesD("タトゥ", true);
		腰D2.EnumEleD().SetValuesD("ハート", false);
		腰D2.EnumEleD().SetValuesD("逆十字", false);
		腰D2.EnumEleD().SetValuesD<上腕_人D>("淫", false);
		腰D2.EnumEleD().SetValuesD<上腕_人D>("植", false);
		腰D2.EnumEleD().SetValuesD<頬肌D>("タトゥ", false);
		腰D2.EnumEleD().SetValuesD<胸D>("植", false);
		腰D2.EnumEleD().SetValuesD<手_人D>("悪", false);
		if (RNG.XS.NextBool())
		{
			腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		}
		if (RNG.XS.NextBool())
		{
			多足_蠍D2.EnumEleD().SetValuesD("柄", true);
		}
		腰D2.EnumEleD().SetValuesD<頭D>("蜘", 頭D2.頬左_接続.IsEleD<虫顎D>() || RNG.XS.NextBool());
		腰D2.EnumEleD().SetValuesD<頬肌D>("蜘", RNG.XS.NextBool());
		if (頭D2.頬左_接続.IsEleD<虫顎D>())
		{
			腰D2.EnumEleD().SetValuesD<頬肌D>("蜘", false);
		}
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getギルタブルル()
	{
		腰D obj = Uni.腰();
		胴D 胴D2 = obj.Set胴();
		胸D 胸D2 = 胴D2.Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳尖();
		頭D2.額接続(new 角1_虫D());
		EleD eleD2 = new 角2_虫D();
		eleD2.SetValuesD("棘", true);
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		顔面_甲D e = new 顔面_甲D();
		頭D2.顔面接続(e);
		手_人D e2 = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e2);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		if (RNG.XS.NextBool())
		{
			手_鳥D e3 = new 手_鳥D();
			下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D();
			下腕_鳥D2.手接続(e3);
			上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D();
			上腕_鳥D2.下腕接続(下腕_鳥D2);
			胸D2.翼上左接続(上腕_鳥D2);
			胸D2.翼上右接続(上腕_鳥D2.Get逆());
		}
		足_鳥D e4 = new 足_鳥D();
		脚_鳥D 脚_鳥D2 = new 脚_鳥D();
		脚_鳥D2.足接続(e4);
		腿_鳥D 腿_鳥D2 = new 腿_鳥D();
		腿_鳥D2.脚接続(脚_鳥D2);
		obj.腿左接続(腿_鳥D2);
		obj.腿右接続(腿_鳥D2.Get逆());
		obj.尾接続(new 尾_鳥D());
		obj.尾接続(new 尾_蛇D());
		eleD2 = new 尾_蠍D();
		胴D2.翼左接続(eleD2);
		胴D2.翼右接続(eleD2.Get逆());
		obj.EnumEleD().SetValuesD("タトゥ", true);
		obj.EnumEleD().SetValuesD("ハート", false);
		obj.EnumEleD().SetValuesD<手_人D>("タトゥ", false);
		obj.EnumEleD().SetValuesD<胸D>("植", false);
		obj.EnumEleD().SetValuesD<胸肌D>("植", false);
		obj.EnumEleD().SetValuesD<頭D>("逆十字", false);
		obj.EnumEleD().SetValuesD<頭D>("顎下", true);
		obj.EnumEleD().SetValuesD<腰D>("獣", true);
		obj.EnumEleD().SetValuesD<腰肌D>("獣", true);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: false));
	}

	public static ChaD Getアルラウネ()
	{
		腰D obj = Uni.腰();
		胴D obj2 = obj.Set胴();
		胸D obj3 = obj2.Set胸R();
		頭D 頭D2 = obj3.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳尖();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj3.肩左接続(肩D2);
		obj3.肩右接続(肩D2.Get逆());
		植D 植D2 = new 植D();
		EleD eleD2 = SlaveMatrix.GameClasses._Con.Get花R(右: false);
		植D2.花接続(eleD2);
		bool flag = RNG.XS.NextBool();
		if (eleD2 is 花_百D)
		{
			((花_百D)eleD2).萼_萼_表示 = !flag;
		}
		植D2.披針葉1_葉_表示 = flag;
		植D2.披針葉1_葉脈_表示 = flag;
		植D2.披針葉2_葉_表示 = flag;
		植D2.披針葉2_葉脈_表示 = flag;
		植D2.披針葉3_葉_表示 = flag;
		植D2.披針葉3_葉脈_表示 = flag;
		植D2.披針葉4_葉_表示 = flag;
		植D2.披針葉4_葉脈_表示 = flag;
		植D2.心臓葉1_葉_表示 = !flag;
		植D2.心臓葉1_葉脈_表示 = !flag;
		植D2.心臓葉2_葉_表示 = !flag;
		植D2.心臓葉2_葉脈_表示 = !flag;
		植D2.心臓葉3_葉_表示 = !flag;
		植D2.心臓葉3_葉脈_表示 = !flag;
		植D2.心臓葉4_葉_表示 = !flag;
		植D2.心臓葉4_葉脈_表示 = !flag;
		eleD.頭頂左接続(植D2);
		eleD.頭頂右接続(植D2.Get逆());
		触手_蔦D 触手_蔦D2 = new 触手_蔦D
		{
			先端表示 = RNG.XS.NextBool()
		};
		触手_蔦D2.SetValuesD("棘", RNG.XS.NextBool());
		EleD eleD3 = (flag ? ((葉D)new 葉_披D()) : ((葉D)new 葉_心D()));
		eleD3.尺度B *= 1.2;
		触手_蔦D2.節3接続(eleD3);
		eleD3.尺度B *= 葉倍率;
		触手_蔦D2.節5接続(eleD3 = eleD3.Copy());
		eleD3.尺度B *= 葉倍率;
		触手_蔦D2.節7接続(eleD3 = eleD3.Copy());
		eleD3.尺度B *= 葉倍率;
		触手_蔦D2.節9接続(eleD3 = eleD3.Copy());
		eleD3.尺度B *= 葉倍率;
		触手_蔦D2.節11接続(eleD3 = eleD3.Copy());
		eleD3.尺度B *= 葉倍率;
		触手_蔦D2.節13接続(eleD3 = eleD3.Copy());
		eleD3.尺度B *= 葉倍率;
		触手_蔦D2.節15接続(eleD3 = eleD3.Copy());
		eleD3.尺度B *= 葉倍率;
		触手_蔦D2.節17接続(eleD3 = eleD3.Copy());
		eleD3.尺度B *= 葉倍率;
		触手_蔦D2.節19接続(eleD3 = eleD3.Copy());
		eleD3.尺度B *= 葉倍率;
		EleD eleD4 = 触手_蔦D2.Copy();
		obj2.翼左接続(触手_蔦D2);
		obj2.翼右接続(触手_蔦D2.Get逆());
		obj.翼左接続(eleD4);
		obj.翼右接続(eleD4.Get逆());
		腿_人D 腿_人D2 = new 腿_人D();
		obj.腿左接続(腿_人D2);
		obj.腿右接続(腿_人D2.Get逆());
		単足_植D 単足_植D2 = new 単足_植D();
		obj.半身接続(単足_植D2);
		EleD eleD5 = new 尾_根D();
		単足_植D2.根外左接続(eleD5);
		単足_植D2.根外右接続(eleD5.Copy());
		単足_植D2.根内左接続(eleD5.Copy());
		単足_植D2.根内右接続(eleD5.Copy());
		単足_植D2.根中央接続(eleD5.Copy());
		単足_植D2.根外左接続(eleD5.Copy());
		単足_植D2.根外右接続(eleD5.Copy());
		単足_植D2.根内左接続(eleD5.Copy());
		単足_植D2.根内右接続(eleD5.Copy());
		単足_植D2.根中央接続(eleD5.Copy());
		obj.EnumEleD().SetValuesD("植", true);
		obj.EnumEleD().SetValuesD("淫", true);
		obj.EnumEleD().SetValuesD<下腕_人D>("淫", false);
		obj.EnumEleD().SetValuesD("ハート", false);
		obj.EnumEleD().SetValuesD("隈取", true);
		obj.EnumEleD().SetValuesD<頬肌D>("隈取", false);
		obj.EnumEleD().SetValuesD<腿_人D>("悪", true);
		obj.EnumEleD().SetValuesD<腿_人D>("葉1", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: false));
	}

	public static ChaD Getサキュバス()
	{
		腰D 腰D2 = Uni.腰();
		胴D 胴D2 = 腰D2.Set胴();
		胸D 胸D2 = 胴D2.Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳長();
		EleD eleD2 = RNG.XS.Next(5) switch
		{
			0 => new 角2_山2D
			{
				尺度B = 0.9
			}, 
			1 => new 角2_巻D
			{
				尺度B = 0.9
			}, 
			2 => new 角2_牛1D
			{
				尺度B = 0.9
			}, 
			3 => new 角2_牛2D
			{
				尺度B = 0.9
			}, 
			_ => new 角2_牛4D
			{
				尺度B = 0.9
			}, 
		};
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		手_蝙D e2 = new 手_蝙D
		{
			シャープ = 1.0
		};
		下腕_蝙D 下腕_蝙D2 = new 下腕_蝙D();
		下腕_蝙D2.手接続(e2);
		上腕_蝙D 上腕_蝙D2 = new 上腕_蝙D();
		上腕_蝙D2.下腕接続(下腕_蝙D2);
		胴D2.翼左接続(上腕_蝙D2);
		胴D2.翼右接続(上腕_蝙D2.Get逆());
		足_人D e3 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e3);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		腰D2.腿左接続(腿_人D2);
		腰D2.腿右接続(腿_人D2.Get逆());
		腰D2.尾接続(new 尾_淫D());
		腰D2.EnumEleD().SetValuesD("淫", true);
		腰D2.EnumEleD().SetValuesD<胸D>("植", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()))
		{
			現陰毛 = 0.0
		};
	}

	public static ChaD Getデビル()
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口R();
		頭D2.Set舌短();
		if (RNG.XS.NextBool())
		{
			頭D2.Set耳尖();
		}
		else
		{
			頭D2.Set耳長();
		}
		EleD eleD2 = RNG.XS.Next(8) switch
		{
			0 => new 角2_山1D(), 
			1 => new 角2_山2D(), 
			2 => new 角2_山3D(), 
			3 => new 角2_牛1D(), 
			4 => new 角2_牛2D(), 
			5 => new 角2_牛3D(), 
			6 => new 角2_牛4D(), 
			_ => new 角2_鬼D(), 
		};
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		if (RNG.XS.NextBool())
		{
			手_蝙D e2 = new 手_蝙D
			{
				シャープ = RNG.XS.NextDouble()
			};
			下腕_蝙D 下腕_蝙D2 = new 下腕_蝙D();
			下腕_蝙D2.手接続(e2);
			上腕_蝙D 上腕_蝙D2 = new 上腕_蝙D();
			上腕_蝙D2.下腕接続(下腕_蝙D2);
			胸D2.翼上左接続(上腕_蝙D2);
			胸D2.翼上右接続(上腕_蝙D2.Get逆());
		}
		else
		{
			手_鳥D e3 = new 手_鳥D();
			下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D();
			下腕_鳥D2.手接続(e3);
			上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D();
			上腕_鳥D2.下腕接続(下腕_鳥D2);
			胸D2.翼上左接続(上腕_鳥D2);
			胸D2.翼上右接続(上腕_鳥D2.Get逆());
		}
		if (RNG.XS.NextBool())
		{
			足_人D e4 = new 足_人D();
			脚_人D 脚_人D2 = new 脚_人D();
			脚_人D2.足接続(e4);
			腿_人D 腿_人D2 = new 腿_人D();
			腿_人D2.脚接続(脚_人D2);
			腰D2.腿左接続(腿_人D2);
			腰D2.腿右接続(腿_人D2.Get逆());
		}
		else
		{
			足_牛D e5 = new 足_牛D();
			脚_蹄D 脚_蹄D2 = new 脚_蹄D();
			脚_蹄D2.足接続(e5);
			腿_蹄D 腿_蹄D2 = new 腿_蹄D();
			腿_蹄D2.脚接続(脚_蹄D2);
			腰D2.腿左接続(腿_蹄D2);
			腰D2.腿右接続(腿_蹄D2.Get逆());
			腰D2.EnumEleD().SetValuesD<腰肌D>("獣性", true);
			腰D2.EnumEleD().SetValuesD<頬肌D>("髭", false);
		}
		腰D2.尾接続(RNG.XS.NextM(4) switch
		{
			0 => new 尾_犬D(), 
			1 => new 尾_馬D(), 
			2 => new 尾_牛D(), 
			_ => new 尾_悪D(), 
		});
		腰D2.EnumEleD().SetValuesD("悪", true);
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getエンジェル(bool b)
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳人();
		if (b)
		{
			頭D2.頭頂接続(new 頭頂_天D());
		}
		else
		{
			胸D2.背中接続(new 背中_光D());
		}
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		手_鳥D 手_鳥D2 = new 手_鳥D
		{
			シャープ = RNG.XS.NextDouble()
		};
		下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D
		{
			シャープ = 手_鳥D2.シャープ
		};
		下腕_鳥D2.手接続(手_鳥D2);
		上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D
		{
			シャープ = 下腕_鳥D2.シャープ
		};
		上腕_鳥D2.下腕接続(下腕_鳥D2);
		for (int i = 0; i < RNG.XS.Next(2) + 1; i++)
		{
			胸D2.翼上左接続(上腕_鳥D2.Copy());
			胸D2.翼上右接続(上腕_鳥D2.Get逆());
		}
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		腰D2.腿左接続(腿_人D2);
		腰D2.腿右接続(腿_人D2.Get逆());
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getウェアキャット()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻R();
		頭D2.Set口人();
		頭D2.Set舌短();
		EleD eleD2 = new 獣耳D();
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		obj.腿左接続(腿_人D2);
		obj.腿右接続(腿_人D2.Get逆());
		obj.尾接続(new 尾_猫D());
		obj.EnumEleD().SetValuesD("獣性", true);
		obj.EnumEleD().SetValuesD<下腕_人D>("獣腕", false);
		obj.EnumEleD().SetValuesD<手_人D>("獣性", false);
		obj.EnumEleD().SetValuesD<手_人D>("獣毛", true);
		obj.EnumEleD().SetValuesD<手_人D>("肉球", true);
		obj.EnumEleD().SetValuesD("胸毛", false);
		obj.EnumEleD().SetValuesD<頬肌D>("髭", 頭D2.鼻_接続.IsEleD<鼻_獣D>());
		obj.EnumEleD().SetValuesD<双目D>("猫目", true);
		obj.EnumEleD().SetValuesD<口_通常D>("牙", true);
		obj.EnumEleD().SetValuesD<下腕_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD<脚_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD<足_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getウェアフォックス()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻R();
		頭D2.Set口人();
		頭D2.Set舌短();
		EleD eleD2 = new 獣耳D
		{
			尺度YB = 1.2
		};
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		obj.腿左接続(腿_人D2);
		obj.腿右接続(腿_人D2.Get逆());
		obj.尾接続(new 尾_狐D());
		obj.EnumEleD().SetValuesD("獣性", true);
		obj.EnumEleD().SetValuesD<下腕_人D>("獣腕", false);
		obj.EnumEleD().SetValuesD<手_人D>("獣性", false);
		obj.EnumEleD().SetValuesD<手_人D>("獣毛", true);
		obj.EnumEleD().SetValuesD<手_人D>("肉球", true);
		obj.EnumEleD().SetValuesD<頬肌D>("髭", 頭D2.鼻_接続.IsEleD<鼻_獣D>());
		obj.EnumEleD().SetValuesD<双目D>("猫目", true);
		obj.EnumEleD().SetValuesD<口_通常D>("牙", true);
		obj.EnumEleD().SetValuesD<下腕_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD<脚_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD<足_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getウェアウルフ()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻R();
		頭D2.Set口人();
		頭D2.Set舌短();
		EleD eleD2 = new 獣耳D();
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		obj.腿左接続(腿_人D2);
		obj.腿右接続(腿_人D2.Get逆());
		obj.尾接続(new 尾_犬D());
		obj.EnumEleD().SetValuesD("獣性", true);
		obj.EnumEleD().SetValuesD<頬肌D>("髭", false);
		obj.EnumEleD().SetValuesD<口_通常D>("牙", true);
		obj.EnumEleD().SetValuesD<下腕_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD<脚_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD<足_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getリザードマン()
	{
		腰D 腰D2 = Uni.腰();
		胸D obj = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = obj.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口R();
		頭D2.Set舌短();
		頭D2.Set耳尖();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj.肩左接続(肩D2);
		obj.肩右接続(肩D2.Get逆());
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		腰D2.腿左接続(腿_人D2);
		腰D2.腿右接続(腿_人D2.Get逆());
		EleD eleD;
		if (RNG.XS.Next(2) == 0)
		{
			eleD = new 尾_ヘD();
			eleD.尺度B = 0.6;
		}
		else
		{
			eleD = new 尾_龍D();
		}
		腰D2.尾接続(eleD);
		腰D2.EnumEleD().SetValuesD("竜性", true);
		腰D2.EnumEleD().SetValuesD<下腕_人D>("棘", false);
		腰D2.EnumEleD().SetValuesD<下腕_人D>("肘2", false);
		腰D2.EnumEleD().SetValuesD<手_人D>("鱗", true);
		腰D2.EnumEleD().SetEleDs(delegate(手_人D f)
		{
			f.竜性 = false;
		});
		腰D2.EnumEleD().SetValuesD<脚_人D>("棘", false);
		腰D2.EnumEleD().SetValuesD<双目D>("猫目", true);
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getドラゴニュート()
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		EleD e;
		if (RNG.XS.NextBool())
		{
			e = ((RNG.XS.Next(2) != 0) ? ((角1D)new 角1_鬼D()) : ((角1D)new 角1_一D()));
			頭D2.額接続(e);
		}
		e = RNG.XS.Next(8) switch
		{
			0 => new 角2_山1D(), 
			1 => new 角2_山2D(), 
			2 => new 角2_山3D(), 
			3 => new 角2_巻D(), 
			4 => new 角2_牛1D(), 
			5 => new 角2_牛2D(), 
			6 => new 角2_牛3D(), 
			_ => new 角2_牛4D(), 
		};
		eleD.頭頂左接続(e);
		eleD.頭頂右接続(e.Get逆());
		手_人D e2 = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e2);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		if (RNG.XS.NextBool())
		{
			if (RNG.XS.NextBool())
			{
				手_蝙D e3 = new 手_蝙D
				{
					シャープ = RNG.XS.NextDouble()
				};
				下腕_蝙D 下腕_蝙D2 = new 下腕_蝙D();
				下腕_蝙D2.手接続(e3);
				上腕_蝙D 上腕_蝙D2 = new 上腕_蝙D();
				上腕_蝙D2.下腕接続(下腕_蝙D2);
				胸D2.翼上左接続(上腕_蝙D2);
				胸D2.翼上右接続(上腕_蝙D2.Get逆());
				頭D2.Set耳長();
			}
			else
			{
				手_鳥D 手_鳥D2 = new 手_鳥D
				{
					シャープ = RNG.XS.NextDouble()
				};
				下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D
				{
					シャープ = 手_鳥D2.シャープ
				};
				下腕_鳥D2.手接続(手_鳥D2);
				上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D
				{
					シャープ = 下腕_鳥D2.シャープ
				};
				上腕_鳥D2.下腕接続(下腕_鳥D2);
				胸D2.翼上左接続(上腕_鳥D2);
				胸D2.翼上右接続(上腕_鳥D2.Get逆());
				頭D2.Set耳獣();
			}
		}
		else
		{
			頭D2.Set耳尖();
		}
		足_人D e4 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e4);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		腰D2.腿左接続(腿_人D2);
		腰D2.腿右接続(腿_人D2.Get逆());
		switch (RNG.XS.Next(3))
		{
		case 0:
			e = new 尾_ヘD();
			e.尺度B = 0.6;
			break;
		case 1:
			e = new 尾_竜D();
			break;
		default:
			e = new 尾_龍D();
			break;
		}
		腰D2.尾接続(e);
		腰D2.EnumEleD().SetValuesD("竜性", true);
		腰D2.EnumEleD().SetValuesD<手_人D>("竜性", false);
		腰D2.EnumEleD().SetValuesD<手_人D>("鱗", true);
		腰D2.EnumEleD().SetValuesD<双目D>("猫目", RNG.XS.NextBool());
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getドラゴン()
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口R();
		頭D2.Set舌短();
		EleD e;
		if (RNG.XS.NextBool())
		{
			e = ((RNG.XS.Next(2) != 0) ? ((角1D)new 角1_鬼D()) : ((角1D)new 角1_一D()));
			頭D2.額接続(e);
		}
		e = RNG.XS.Next(8) switch
		{
			0 => new 角2_山1D(), 
			1 => new 角2_山2D(), 
			2 => new 角2_山3D(), 
			3 => new 角2_巻D(), 
			4 => new 角2_牛1D(), 
			5 => new 角2_牛2D(), 
			6 => new 角2_牛3D(), 
			_ => new 角2_牛4D(), 
		};
		eleD.頭頂左接続(e);
		eleD.頭頂右接続(e.Get逆());
		手_人D e2 = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e2);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		腰D2.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		if (RNG.XS.NextBool())
		{
			手_蝙D e3 = new 手_蝙D();
			下腕_蝙D 下腕_蝙D2 = new 下腕_蝙D();
			下腕_蝙D2.手接続(e3);
			上腕_蝙D 上腕_蝙D2 = new 上腕_蝙D();
			上腕_蝙D2.下腕接続(下腕_蝙D2);
			四足胸D2.翼上左接続(上腕_蝙D2);
			四足胸D2.翼上右接続(上腕_蝙D2.Get逆());
			頭D2.Set耳鰭();
		}
		else
		{
			手_鳥D e4 = new 手_鳥D();
			下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D();
			下腕_鳥D2.手接続(e4);
			上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D();
			上腕_鳥D2.下腕接続(下腕_鳥D2);
			四足胸D2.翼上左接続(上腕_鳥D2);
			四足胸D2.翼上右接続(上腕_鳥D2.Get逆());
			腰D2.EnumEleD().SetValuesD<四足胴D>("獣毛", true);
			頭D2.Set耳羽();
		}
		手_獣D e5 = new 手_獣D();
		下腕_獣D 下腕_獣D2 = new 下腕_獣D();
		下腕_獣D2.手接続(e5);
		上腕_獣D 上腕_獣D2 = new 上腕_獣D();
		上腕_獣D2.下腕接続(下腕_獣D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_獣D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_竜D e6 = new 足_竜D();
		脚_竜D 脚_竜D2 = new 脚_竜D();
		脚_竜D2.足接続(e6);
		腿_竜D 腿_竜D2 = new 腿_竜D();
		腿_竜D2.脚接続(脚_竜D2);
		四足腰D2.腿左接続(腿_竜D2);
		四足腰D2.腿右接続(腿_竜D2.Get逆());
		switch (RNG.XS.Next(5))
		{
		case 0:
			e = new 尾_ヘD();
			e.尺度B = 0.6;
			break;
		case 1:
			e = new 尾_竜D();
			break;
		case 2:
			e = new 尾_龍D();
			break;
		default:
			e = new 尾_悪D();
			break;
		}
		四足腰D2.尾接続(e);
		腰D2.EnumEleD().SetValuesD("竜性", true);
		四足胸D2.EnumEleD().SetValuesD<胸肌D>("鱗", false);
		腰D2.EnumEleD().SetValuesD<手_人D>("配色", 配色指定.S0);
		腰D2.EnumEleD().SetValuesD<双目D>("猫目", true);
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD<性器_人D>("表示", false);
		腰D2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getドラコケンタウレ()
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口R();
		頭D2.Set舌短();
		EleD e;
		if (RNG.XS.NextBool())
		{
			e = ((RNG.XS.Next(2) != 0) ? ((角1D)new 角1_鬼D()) : ((角1D)new 角1_一D()));
			頭D2.額接続(e);
		}
		e = RNG.XS.Next(8) switch
		{
			0 => new 角2_山1D(), 
			1 => new 角2_山2D(), 
			2 => new 角2_山3D(), 
			3 => new 角2_巻D(), 
			4 => new 角2_牛1D(), 
			5 => new 角2_牛2D(), 
			6 => new 角2_牛3D(), 
			_ => new 角2_牛4D(), 
		};
		eleD.頭頂左接続(e);
		eleD.頭頂右接続(e.Get逆());
		手_人D e2 = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e2);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		腰D2.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		頭D2.Set耳長();
		手_獣D e3 = new 手_獣D();
		下腕_獣D 下腕_獣D2 = new 下腕_獣D();
		下腕_獣D2.手接続(e3);
		上腕_獣D 上腕_獣D2 = new 上腕_獣D();
		上腕_獣D2.下腕接続(下腕_獣D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_獣D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_竜D e4 = new 足_竜D();
		脚_竜D 脚_竜D2 = new 脚_竜D();
		脚_竜D2.足接続(e4);
		腿_竜D 腿_竜D2 = new 腿_竜D();
		腿_竜D2.脚接続(脚_竜D2);
		四足腰D2.腿左接続(腿_竜D2);
		四足腰D2.腿右接続(腿_竜D2.Get逆());
		switch (RNG.XS.Next(5))
		{
		case 0:
			e = new 尾_ヘD();
			e.尺度B = 0.6;
			break;
		case 1:
			e = new 尾_竜D();
			break;
		case 2:
			e = new 尾_龍D();
			break;
		default:
			e = new 尾_悪D();
			break;
		}
		四足腰D2.尾接続(e);
		腰D2.EnumEleD().SetValuesD("竜性", true);
		四足胸D2.EnumEleD().SetValuesD<胸肌D>("鱗", false);
		腰D2.EnumEleD().SetValuesD<手_人D>("配色", 配色指定.S0);
		腰D2.EnumEleD().SetValuesD<双目D>("猫目", true);
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD<性器_人D>("表示", false);
		腰D2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getワイバーン()
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口R();
		頭D2.Set舌短();
		EleD e;
		if (RNG.XS.NextBool())
		{
			e = ((RNG.XS.Next(2) != 0) ? ((角1D)new 角1_鬼D()) : ((角1D)new 角1_一D()));
			頭D2.額接続(e);
		}
		e = RNG.XS.Next(6) switch
		{
			0 => new 角2_山1D(), 
			1 => new 角2_山2D(), 
			2 => new 角2_山3D(), 
			3 => new 角2_牛2D(), 
			4 => new 角2_牛3D(), 
			_ => new 角2_牛4D(), 
		};
		eleD.頭頂左接続(e);
		eleD.頭頂右接続(e.Get逆());
		if (RNG.XS.NextBool())
		{
			手_蝙D e2 = new 手_蝙D
			{
				尺度B = 1.1
			};
			下腕_蝙D 下腕_蝙D2 = new 下腕_蝙D
			{
				尺度B = 1.1
			};
			下腕_蝙D2.手接続(e2);
			上腕_蝙D 上腕_蝙D2 = new 上腕_蝙D
			{
				尺度B = 1.1
			};
			上腕_蝙D2.下腕接続(下腕_蝙D2);
			肩D 肩D2 = new 肩D();
			肩D2.上腕接続(上腕_蝙D2);
			胸D2.肩左接続(肩D2);
			胸D2.肩右接続(肩D2.Get逆());
			頭D2.Set耳長();
		}
		else
		{
			手_鳥D e3 = new 手_鳥D
			{
				尺度B = 1.1,
				指_表示 = true
			};
			下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D
			{
				尺度B = 1.1
			};
			下腕_鳥D2.手接続(e3);
			上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D
			{
				尺度B = 1.1
			};
			上腕_鳥D2.下腕接続(下腕_鳥D2);
			肩D 肩D3 = new 肩D();
			肩D3.上腕接続(上腕_鳥D2);
			胸D2.肩左接続(肩D3);
			胸D2.肩右接続(肩D3.Get逆());
			胸D2.背中接続(new 背中_羽D());
			頭D2.Set耳獣();
		}
		足_鳥D e4 = new 足_鳥D();
		脚_竜D 脚_竜D2 = new 脚_竜D();
		脚_竜D2.足接続(e4);
		腿_竜D 腿_竜D2 = new 腿_竜D();
		腿_竜D2.脚接続(脚_竜D2);
		腰D2.腿左接続(腿_竜D2);
		腰D2.腿右接続(腿_竜D2.Get逆());
		腰D2.尾接続(RNG.XS.Next(5) switch
		{
			0 => new 尾_ヘD
			{
				尺度B = 0.6
			}, 
			1 => new 尾_竜D(), 
			2 => new 尾_龍D(), 
			3 => new 尾_蠍D
			{
				尺度B = 1.3
			}, 
			_ => new 尾_悪D
			{
				尺度B = 1.5
			}, 
		});
		腰D2.EnumEleD().SetValuesD("竜性", true);
		腰D2.EnumEleD().SetValuesD<双目D>("猫目", true);
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getワーム()
	{
		腰D 腰D2 = Uni.腰();
		頭D 頭D2 = 腰D2.Set胴().Set胸R().Set首()
			.Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口裂();
		頭D2.Set舌長();
		頭D2.Set耳鰭();
		頭D2.Set耳尖();
		EleD e;
		if (RNG.XS.NextBool())
		{
			e = ((RNG.XS.Next(2) != 0) ? ((角1D)new 角1_鬼D()) : ((角1D)new 角1_一D()));
			頭D2.額接続(e);
		}
		e = RNG.XS.Next(5) switch
		{
			0 => new 角2_山1D(), 
			1 => new 角2_山2D(), 
			2 => new 角2_牛2D(), 
			3 => new 角2_牛4D(), 
			_ => new 角2_鬼D(), 
		};
		eleD.頭頂左接続(e);
		eleD.頭頂右接続(e.Get逆());
		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
		腰D2.半身接続(長物_蛇D2);
		胴_蛇D 胴_蛇D2 = new 胴_蛇D();
		長物_蛇D2.胴接続(胴_蛇D2);
		for (int i = 0; i < 40; i++)
		{
			胴_蛇D2.胴接続(胴_蛇D2 = new 胴_蛇D());
		}
		胴_蛇D2.胴接続(new 尾_ヘD());
		腰D2.EnumEleD().SetValuesD("竜性", true);
		腰D2.EnumEleD().SetValuesD<腰肌D>("竜性", false);
		腰D2.EnumEleD().SetValuesD<双目D>("猫目", RNG.XS.NextBool());
		腰D2.EnumEleD().SetValuesD<舌_長D>("股舌表示", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getサンドワーム()
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口裂();
		頭D2.Set舌短();
		頭D2.Set耳人();
		EleD eleD2 = RNG.XS.Next(5) switch
		{
			0 => new 角2_山1D(), 
			1 => new 角2_山2D(), 
			2 => new 角2_牛2D(), 
			3 => new 角2_牛4D(), 
			_ => new 角2_鬼D(), 
		};
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		頭D2.頭頂接続(new 頭頂_皿D
		{
			甲殻 = true
		});
		大顎基D 大顎基D2 = new 大顎基D();
		eleD2 = new 大顎D();
		大顎基D2.顎左接続(eleD2);
		大顎基D2.顎右接続(eleD2.Get逆());
		頭D2.大顎基接続(大顎基D2);
		顔面_蟲D e = new 顔面_蟲D();
		頭D2.顔面接続(e);
		if (RNG.XS.NextBool())
		{
			eleD2 = new 虫顎D
			{
				尺度B = 1.1
			};
			頭D2.頬左接続(eleD2);
			頭D2.頬右接続(eleD2.Get逆());
		}
		下腕_人D 下腕_人D2 = new 下腕_人D();
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		下腕_人D2.虫鎌接続(new 虫鎌D());
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		胸D2.肩左接続(肩D2.Copy());
		胸D2.肩右接続(肩D2.Get逆());
		胸D2.肩左接続(肩D2.Copy());
		胸D2.肩右接続(肩D2.Get逆());
		長物_蟲D 長物_蟲D2 = new 長物_蟲D();
		腰D2.半身接続(長物_蟲D2);
		胴_蟲D 胴_蟲D2 = new 胴_蟲D();
		長物_蟲D2.胴接続(胴_蟲D2);
		for (int i = 0; i < 21; i++)
		{
			胴_蟲D2.胴接続(胴_蟲D2 = new 胴_蟲D());
		}
		尾_蟲D 尾_蟲D2 = new 尾_蟲D();
		節D 節D2 = (RNG.XS.NextBool() ? ((節尾D)new 節尾_曳航D()) : ((節尾D)new 節尾_鋏D()));
		尾_蟲D2.尾左接続(節D2);
		尾_蟲D2.尾右接続(節D2.Get逆());
		胴_蟲D2.胴接続(尾_蟲D2);
		腰D2.EnumEleD().SetValuesD("虫性", true);
		腰D2.EnumEleD().SetValuesD("配色", 配色指定.C0);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getリュウ()
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口裂();
		頭D2.Set舌長();
		頭D2.Set耳鰭();
		頭D2.Set耳尖();
		EleD eleD2 = new 角2_山2D();
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
		腰D2.半身接続(長物_蛇D2);
		足_鳥D e = new 足_鳥D
		{
			尺度B = 1.1
		};
		脚_竜D 脚_竜D2 = new 脚_竜D
		{
			尺度B = 1.1
		};
		脚_竜D2.足接続(e);
		四足脇D 四足脇D2 = new 四足脇D
		{
			尺度B = 1.1
		};
		四足脇D2.上腕接続(脚_竜D2);
		腰D2.翼左接続(四足脇D2);
		腰D2.翼右接続(四足脇D2.Get逆());
		胴_蛇D 胴_蛇D2 = new 胴_蛇D();
		長物_蛇D2.胴接続(胴_蛇D2);
		for (int i = 0; i < 50; i++)
		{
			胴_蛇D2.胴接続(胴_蛇D2 = new 胴_蛇D());
		}
		e = new 足_鳥D();
		脚_竜D2 = new 脚_竜D();
		脚_竜D2.足接続(e);
		腿_竜D 腿_竜D2 = new 腿_竜D();
		腿_竜D2.脚接続(脚_竜D2);
		胴_蛇D2.左接続(腿_竜D2);
		胴_蛇D2.右接続(腿_竜D2.Get逆());
		尾_ヘD 尾_ヘD2 = new 尾_ヘD();
		尾_ヘD2.尾先接続(new 尾鰭_魚D());
		胴_蛇D2.胴接続(尾_ヘD2);
		腰D2.EnumEleD().SetValuesD<頭D>("馬", true);
		胸D2.肌_接続.SetValuesD<胸毛D>("表示", true);
		腰D2.EnumEleD().SetValuesD("竜性", true);
		腰D2.EnumEleD().SetValuesD<腰肌D>("竜性", false);
		腰D2.EnumEleD().SetValuesD<双目D>("猫目", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getスライム()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳人();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		腿_人D 腿_人D2 = new 腿_人D
		{
			スライム = true
		};
		obj.腿左接続(腿_人D2);
		obj.腿右接続(腿_人D2.Get逆());
		obj.半身接続(new 単足_粘D());
		obj.EnumEleD().SetValuesD("スライム", true);
		obj.EnumEleD().SetValuesD("ハイライト", true);
		obj.EnumEleD().SetValuesD<ボテ腹_人D>("表示", false);
		obj.EnumEleD().SetValuesD("眼", false);
		obj.EnumEleD().SetValuesD("コア", false);
		obj.EnumEleD().SetValuesD("秘石", false);
		obj.EnumEleD().SetValuesD<双目D>("ハイライト下", false);
		obj.EnumEleD().SetValuesD("コア1", RNG.XS.NextBool());
		obj.EnumEleD().SetValuesD("コア2", RNG.XS.NextBool());
		obj.EnumEleD().SetValuesD<双目D>("瞳孔", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: false));
	}

	public static ChaD Getフェアリー(bool b1, bool b2)
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		switch (RNG.XS.Next(3))
		{
		case 0:
			頭D2.Set耳人();
			break;
		case 1:
			頭D2.Set耳尖();
			break;
		default:
			頭D2.Set耳長();
			break;
		}
		植D 植D2 = new 植D();
		EleD eleD2 = SlaveMatrix.GameClasses._Con.Get花R(右: false);
		植D2.花接続(eleD2);
		bool flag = RNG.XS.NextBool();
		if (eleD2 is 花_百D)
		{
			((花_百D)eleD2).萼_萼_表示 = !flag;
		}
		植D2.披針葉1_葉_表示 = flag;
		植D2.披針葉1_葉脈_表示 = flag;
		植D2.披針葉2_葉_表示 = flag;
		植D2.披針葉2_葉脈_表示 = flag;
		植D2.披針葉3_葉_表示 = flag;
		植D2.披針葉3_葉脈_表示 = flag;
		植D2.披針葉4_葉_表示 = flag;
		植D2.披針葉4_葉脈_表示 = flag;
		植D2.心臓葉1_葉_表示 = !flag;
		植D2.心臓葉1_葉脈_表示 = !flag;
		植D2.心臓葉2_葉_表示 = !flag;
		植D2.心臓葉2_葉脈_表示 = !flag;
		植D2.心臓葉3_葉_表示 = !flag;
		植D2.心臓葉3_葉脈_表示 = !flag;
		植D2.心臓葉4_葉_表示 = !flag;
		植D2.心臓葉4_葉脈_表示 = !flag;
		eleD.頭頂左接続(植D2);
		eleD.頭頂右接続(植D2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		if (b1)
		{
			EleD eleD3 = new 前翅_羽D
			{
				尺度B = 0.9
			};
			胸D2.翼上左接続(eleD3);
			胸D2.翼上右接続(eleD3.Get逆());
			eleD3 = new 後翅_羽D
			{
				尺度B = 0.9
			};
			胸D2.翼下左接続(eleD3);
			胸D2.翼下右接続(eleD3.Get逆());
		}
		else
		{
			EleD eleD3 = new 前翅_蝶D
			{
				尺度B = 0.9,
				水青 = b2
			};
			胸D2.翼上左接続(eleD3);
			胸D2.翼上右接続(eleD3.Get逆());
			eleD3 = new 後翅_蝶D
			{
				尺度B = 0.9,
				水青 = b2
			};
			胸D2.翼下左接続(eleD3);
			胸D2.翼下右接続(eleD3.Get逆());
		}
		if (RNG.XS.NextBool())
		{
			if (b1)
			{
				EleD eleD3 = new 触覚_線D();
				eleD3.尺度YB = 0.4;
				頭D2.触覚左接続(eleD3);
				頭D2.触覚右接続(eleD3.Get逆());
			}
			else if (b2)
			{
				EleD eleD3 = new 触覚_蛾D();
				頭D2.触覚左接続(eleD3);
				頭D2.触覚右接続(eleD3.Get逆());
			}
			else
			{
				EleD eleD3 = new 触覚_蝶D();
				頭D2.触覚左接続(eleD3);
				頭D2.触覚右接続(eleD3.Get逆());
			}
		}
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		腰D2.腿左接続(腿_人D2);
		腰D2.腿右接続(腿_人D2.Get逆());
		腰D2.EnumEleD().SetValuesD("肥大", 0.0);
		腰D2.EnumEleD().SetValuesD("身長", 0.0);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getオーグリス(bool b)
	{
		腰D 腰D2 = Uni.腰();
		胸D obj = 腰D2.Set胴().Set胸R();
		首D 首D2 = obj.Set首();
		頭D 頭D2;
		if (b)
		{
			頭D2 = 首D2.Set頭R1();
			頭D2.EnumEleD().GetEleD<基髪D>();
			頭D2.額接続(new 角1_鬼D());
		}
		else
		{
			頭D2 = 首D2.Set頭R();
			基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
			EleD eleD2 = new 角2_鬼D();
			eleD.頭頂左接続(eleD2);
			eleD.頭頂右接続(eleD2.Get逆());
		}
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		if (RNG.XS.NextBool())
		{
			頭D2.Set耳人();
		}
		else
		{
			頭D2.Set耳尖();
		}
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj.肩左接続(肩D2);
		obj.肩右接続(肩D2.Get逆());
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		腰D2.腿左接続(腿_人D2);
		腰D2.腿右接続(腿_人D2.Get逆());
		if (RNG.XS.NextBool())
		{
			腰D2.EnumEleD().SetValuesD("隈取", true);
			頭D2.隈取_タトゥ_表示 = false;
			腰D2.EnumEleD().SetValuesD<頬肌D>("豹", true);
			腰D2.EnumEleD().SetValuesD("淫", true);
			腰D2.EnumEleD().SetValuesD("ハート", false);
			腰D2.SetValuesD("悪", true);
			腰D2.EnumEleD().SetValuesD<胸D>("植", true);
			腰D2.EnumEleD().SetValuesD<胴D>("植", true);
			腰D2.EnumEleD().SetValuesD<胸D>("タトゥ2", false);
			腰D2.EnumEleD().SetValuesD<下腕_人D>("手首", false);
			腰D2.EnumEleD().SetValuesD<脚_人D>("足首", false);
		}
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getサイクロプス()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R1();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set単目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		if (RNG.XS.NextBool())
		{
			頭D2.Set耳人();
		}
		else
		{
			頭D2.Set耳尖();
		}
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		obj.腿左接続(腿_人D2);
		obj.腿右接続(腿_人D2.Get逆());
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 1.0);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getエイリアン()
	{
		腰D 腰D2 = Uni.腰();
		胸D obj = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = obj.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set目宇R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳尖();
		頭頂_宇D 頭頂_宇D2 = new 頭頂_宇D();
		頭頂_宇D2.頭部後接続(new 頭頂後_宇D());
		頭D2.頭頂接続(頭頂_宇D2);
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		下腕_人D2.虫鎌接続(new 虫鎌D());
		obj.肩左接続(肩D2);
		obj.肩右接続(肩D2.Get逆());
		多足_蛸D 多足_蛸D2 = new 多足_蛸D();
		腰D2.半身接続(多足_蛸D2);
		触手_軟D 触手_軟D2 = new 触手_軟D
		{
			後足 = true
		};
		触手_軟D 触手_軟D3 = new 触手_軟D
		{
			前足 = true
		};
		多足_蛸D2.軟体内左接続(触手_軟D2.Copy());
		多足_蛸D2.軟体内右接続(触手_軟D2.Get逆());
		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
		腰D2.EnumEleD().SetValuesD("コア1", true);
		腰D2.EnumEleD().SetValuesD("虫性", true);
		腰D2.EnumEleD().SetValuesD<頭D>("虫性", false);
		腰D2.EnumEleD().SetValuesD<胸D>("器官", false);
		腰D2.EnumEleD().SetValuesD<手_人D>("宇手", true);
		if (RNG.XS.NextBool())
		{
			腰D2.EnumEleD().SetValuesD("紋柄", true);
		}
		腰D2.EnumEleD().SetValuesD("吸盤", false);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getクラーケン()
	{
		腰D 腰D2 = Uni.腰();
		胸D obj = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = obj.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口裂();
		頭D2.Set舌短();
		頭D2.Set耳長();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj.肩左接続(肩D2);
		obj.肩右接続(肩D2.Get逆());
		多足_蛸D 多足_蛸D2 = new 多足_蛸D();
		腰D2.半身接続(多足_蛸D2);
		触手_軟D 触手_軟D2 = new 触手_軟D
		{
			後足 = true
		};
		触手_軟D 触手_軟D3 = new 触手_軟D
		{
			前足 = true
		};
		触手_触D 触手_触D2 = new 触手_触D();
		触手_触D2.SetValuesD("爪", RNG.XS.NextBool());
		多足_蛸D2.軟体内左接続(触手_軟D2.Copy());
		多足_蛸D2.軟体内右接続(触手_軟D2.Get逆());
		多足_蛸D2.軟体内左接続(触手_触D2.Copy());
		多足_蛸D2.軟体内右接続(触手_触D2.Get逆());
		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
		多足_蛸D2.軟体外左接続(触手_軟D3.Copy());
		多足_蛸D2.軟体外右接続(触手_軟D3.Get逆());
		if (RNG.XS.NextBool())
		{
			腰D2.EnumEleD().SetValuesD("紋柄", true);
			多足_蛸D2.EnumEleD().SetValuesD<触手_触D>("柄", RNG.XS.NextBool());
		}
		腰D2.EnumEleD().SetValuesD<双目D>("蛸目", RNG.XS.NextBool());
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getセイレーン(int i)
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口R();
		頭D2.Set舌短();
		頭D2.Set耳尖();
		switch (i)
		{
		case 0:
		{
			if (RNG.XS.NextBool())
			{
				手_人D e4 = new 手_人D();
				下腕_人D 下腕_人D4 = new 下腕_人D();
				下腕_人D4.手接続(e4);
				上腕_人D 上腕_人D4 = new 上腕_人D();
				上腕_人D4.下腕接続(下腕_人D4);
				肩D 肩D4 = new 肩D();
				肩D4.上腕接続(上腕_人D4);
				胸D2.肩左接続(肩D4);
				胸D2.肩右接続(肩D4.Get逆());
			}
			手_鳥D e5 = new 手_鳥D
			{
				シャープ = 1.0
			};
			下腕_鳥D 下腕_鳥D3 = new 下腕_鳥D
			{
				シャープ = 1.0
			};
			下腕_鳥D3.手接続(e5);
			上腕_鳥D 上腕_鳥D3 = new 上腕_鳥D
			{
				シャープ = 1.0
			};
			上腕_鳥D3.下腕接続(下腕_鳥D3);
			胸D2.翼上左接続(上腕_鳥D3);
			胸D2.翼上右接続(上腕_鳥D3.Get逆());
			足_鳥D e6 = new 足_鳥D();
			脚_鳥D 脚_鳥D3 = new 脚_鳥D();
			脚_鳥D3.足接続(e6);
			腿_鳥D 腿_鳥D3 = new 腿_鳥D();
			腿_鳥D3.脚接続(脚_鳥D3);
			腰D2.腿左接続(腿_鳥D3);
			腰D2.腿右接続(腿_鳥D3.Get逆());
			腰D2.EnumEleD().SetValuesD<腰肌D>("獣毛", true);
			腰D2.尾接続(new 尾_鳥D());
			break;
		}
		case 1:
		{
			手_人D e3 = new 手_人D();
			下腕_人D 下腕_人D3 = new 下腕_人D();
			下腕_人D3.手接続(e3);
			上腕_人D 上腕_人D3 = new 上腕_人D();
			上腕_人D3.下腕接続(下腕_人D3);
			肩D 肩D3 = new 肩D();
			肩D3.上腕接続(上腕_人D3);
			胸D2.肩左接続(肩D3);
			胸D2.肩右接続(肩D3.Get逆());
			尾_魚D 尾_魚D2 = new 尾_魚D
			{
				尺度B = 1.2,
				尺度YB = 1.5
			};
			尾_魚D2.尾0_表示 = false;
			尾_魚D2.尾0_鱗右_鱗1_表示 = false;
			尾_魚D2.尾0_鱗右_鱗2_表示 = false;
			尾_魚D2.尾先接続(new 尾鰭_魚D());
			腰D2.腿左接続(尾_魚D2);
			腰D2.腿右接続(尾_魚D2.Get逆());
			腰D2.EnumEleD().SetValuesD<腰D>("鱗", true);
			腰D2.EnumEleD().SetValuesD<腰肌D>("鱗", true);
			break;
		}
		default:
		{
			腰D2.EnumEleD().SetValuesD<腰肌D>("獣毛", true);
			手_人D e = new 手_人D();
			下腕_人D 下腕_人D2 = new 下腕_人D();
			下腕_人D2.手接続(e);
			上腕_人D 上腕_人D2 = new 上腕_人D();
			上腕_人D2.下腕接続(下腕_人D2);
			肩D 肩D2 = new 肩D();
			肩D2.上腕接続(上腕_人D2);
			胸D2.肩左接続(肩D2);
			胸D2.肩右接続(肩D2.Get逆());
			四足胸D 四足胸D2 = Uni.四足胸();
			腰D2.半身接続(四足胸D2);
			四足胴D 四足胴D2 = Uni.四足胴();
			四足胸D2.胴接続(四足胴D2);
			四足腰D 四足腰D2 = Uni.四足腰();
			四足胴D2.腰接続(四足腰D2);
			四足腰D2.SetValuesD("尺度YB", 0.9);
			四足胴D2.SetValuesD("尺度YB", 0.8);
			四足胸D2.SetValuesD("尺度YB", 0.8);
			手_鳥D 手_鳥D2 = new 手_鳥D();
			手_鳥D2.シャープ = 1.0;
			下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D();
			下腕_鳥D2.手接続(手_鳥D2);
			下腕_鳥D2.シャープ = 1.0;
			上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D();
			上腕_鳥D2.下腕接続(下腕_鳥D2);
			上腕_鳥D2.シャープ = 1.0;
			四足胸D2.翼上左接続(上腕_鳥D2);
			四足胸D2.翼上右接続(上腕_鳥D2.Get逆());
			足_鳥D e2 = new 足_鳥D();
			脚_鳥D 脚_鳥D2 = new 脚_鳥D();
			脚_鳥D2.足接続(e2);
			腿_鳥D 腿_鳥D2 = new 腿_鳥D();
			腿_鳥D2.脚接続(脚_鳥D2);
			四足腰D2.腿左接続(腿_鳥D2);
			四足腰D2.腿右接続(腿_鳥D2.Get逆());
			四足腰D2.尾接続(new 尾_鳥D());
			四足胴D2.SetValuesD("獣毛", true);
			腰D2.EnumEleD().SetValuesD<性器_人D>("表示", false);
			腰D2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
			break;
		}
		}
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getユニコーン()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R1();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳獣();
		頭D2.額接続(new 角1_一D());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		obj.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		手_馬D e2 = new 手_馬D();
		下腕_蹄D 下腕_蹄D2 = new 下腕_蹄D();
		下腕_蹄D2.手接続(e2);
		上腕_蹄D 上腕_蹄D2 = new 上腕_蹄D();
		上腕_蹄D2.下腕接続(下腕_蹄D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_蹄D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_馬D e3 = new 足_馬D();
		脚_蹄D 脚_蹄D2 = new 脚_蹄D();
		脚_蹄D2.足接続(e3);
		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
		腿_蹄D2.脚接続(脚_蹄D2);
		四足腰D2.腿左接続(腿_蹄D2);
		四足腰D2.腿右接続(腿_蹄D2.Get逆());
		四足腰D2.尾接続(new 尾_馬D());
		obj.EnumEleD().SetValuesD<頭D>("馬", RNG.XS.NextBool());
		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		obj.EnumEleD().SetValuesD<腰肌D>("獣性", true);
		四足腰D2.EnumEleD().SetValuesD<腰肌D>("獣性", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getモノケロス()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R1();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳獣();
		頭D2.額接続(new 角1_一D
		{
			尺度YB = 2.0
		});
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		obj.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		四足胸D2.背中接続(new 背中_羽D
		{
			毛 = true
		});
		手_牛D e2 = new 手_牛D();
		下腕_蹄D 下腕_蹄D2 = new 下腕_蹄D();
		下腕_蹄D2.手接続(e2);
		上腕_蹄D 上腕_蹄D2 = new 上腕_蹄D();
		上腕_蹄D2.下腕接続(下腕_蹄D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_蹄D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_牛D e3 = new 足_牛D();
		脚_蹄D 脚_蹄D2 = new 脚_蹄D();
		脚_蹄D2.足接続(e3);
		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
		腿_蹄D2.脚接続(脚_蹄D2);
		四足腰D2.腿左接続(腿_蹄D2);
		四足腰D2.腿右接続(腿_蹄D2.Get逆());
		四足腰D2.尾接続(new 尾_牛D());
		obj.EnumEleD().SetValuesD<頭D>("馬", true);
		obj.EnumEleD().SetValuesD("胸毛", true);
		obj.EnumEleD().SetValuesD<頬肌D>("獣毛", true);
		obj.EnumEleD().SetValuesD<胸D>("獣毛", true);
		obj.EnumEleD().SetValuesD<腰D>("獣毛", true);
		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		obj.EnumEleD().SetValuesD<腰肌D>("獣性", true);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: false));
	}

	public static ChaD Getアリコーン()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R1();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳獣();
		頭D2.額接続(new 角1_一D());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		obj.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		手_鳥D 手_鳥D2 = new 手_鳥D
		{
			シャープ = RNG.XS.NextDouble()
		};
		下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D
		{
			シャープ = 手_鳥D2.シャープ
		};
		下腕_鳥D2.手接続(手_鳥D2);
		上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D
		{
			シャープ = 下腕_鳥D2.シャープ
		};
		上腕_鳥D2.下腕接続(下腕_鳥D2);
		四足胸D2.翼上左接続(上腕_鳥D2);
		四足胸D2.翼上右接続(上腕_鳥D2.Get逆());
		手_馬D e2 = new 手_馬D();
		下腕_蹄D 下腕_蹄D2 = new 下腕_蹄D();
		下腕_蹄D2.手接続(e2);
		上腕_蹄D 上腕_蹄D2 = new 上腕_蹄D();
		上腕_蹄D2.下腕接続(下腕_蹄D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_蹄D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_馬D e3 = new 足_馬D();
		脚_蹄D 脚_蹄D2 = new 脚_蹄D();
		脚_蹄D2.足接続(e3);
		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
		腿_蹄D2.脚接続(脚_蹄D2);
		四足腰D2.腿左接続(腿_蹄D2);
		四足腰D2.腿右接続(腿_蹄D2.Get逆());
		四足腰D2.尾接続(new 尾_馬D());
		obj.EnumEleD().SetValuesD<頭D>("馬", RNG.XS.NextBool());
		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		obj.EnumEleD().SetValuesD<腰肌D>("獣性", true);
		四足腰D2.EnumEleD().SetValuesD<腰肌D>("獣性", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: false));
	}

	public static ChaD Getバイコーン()
	{
		腰D obj = Uni.腰();
		胸D 胸D2 = obj.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳獣();
		EleD eleD2 = new 角2_山2D
		{
			尺度YB = 1.5
		};
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		obj.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		手_馬D e2 = new 手_馬D();
		下腕_蹄D 下腕_蹄D2 = new 下腕_蹄D();
		下腕_蹄D2.手接続(e2);
		上腕_蹄D 上腕_蹄D2 = new 上腕_蹄D();
		上腕_蹄D2.下腕接続(下腕_蹄D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_蹄D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_馬D e3 = new 足_馬D();
		脚_蹄D 脚_蹄D2 = new 脚_蹄D();
		脚_蹄D2.足接続(e3);
		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
		腿_蹄D2.脚接続(脚_蹄D2);
		四足腰D2.腿左接続(腿_蹄D2);
		四足腰D2.腿右接続(腿_蹄D2.Get逆());
		四足腰D2.尾接続(new 尾_馬D());
		obj.EnumEleD().SetValuesD<頭D>("馬", RNG.XS.NextBool());
		胸D2.肌_接続.SetValuesD("胸毛", true);
		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		obj.EnumEleD().SetValuesD<腰肌D>("獣性", true);
		四足腰D2.EnumEleD().SetValuesD<腰肌D>("獣性", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: false));
	}

	public static ChaD Getペガサス()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳獣();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		obj.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		手_鳥D 手_鳥D2 = new 手_鳥D
		{
			シャープ = RNG.XS.NextDouble()
		};
		下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D
		{
			シャープ = 手_鳥D2.シャープ
		};
		下腕_鳥D2.手接続(手_鳥D2);
		上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D
		{
			シャープ = 下腕_鳥D2.シャープ
		};
		上腕_鳥D2.下腕接続(下腕_鳥D2);
		四足胸D2.翼上左接続(上腕_鳥D2);
		四足胸D2.翼上右接続(上腕_鳥D2.Get逆());
		手_馬D e2 = new 手_馬D();
		下腕_蹄D 下腕_蹄D2 = new 下腕_蹄D();
		下腕_蹄D2.手接続(e2);
		上腕_蹄D 上腕_蹄D2 = new 上腕_蹄D();
		上腕_蹄D2.下腕接続(下腕_蹄D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_蹄D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_馬D e3 = new 足_馬D();
		脚_蹄D 脚_蹄D2 = new 脚_蹄D();
		脚_蹄D2.足接続(e3);
		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
		腿_蹄D2.脚接続(脚_蹄D2);
		四足腰D2.腿左接続(腿_蹄D2);
		四足腰D2.腿右接続(腿_蹄D2.Get逆());
		四足腰D2.尾接続(new 尾_馬D());
		obj.EnumEleD().SetValuesD<頭D>("馬", RNG.XS.NextBool());
		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		obj.EnumEleD().SetValuesD<腰肌D>("獣性", true);
		四足腰D2.EnumEleD().SetValuesD<腰肌D>("獣性", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getグリフォン()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳羽();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		obj.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		四足胸D2.背中接続(new 背中_羽D
		{
			毛 = true
		});
		手_鳥D 手_鳥D2 = new 手_鳥D();
		下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D();
		下腕_鳥D2.手接続(手_鳥D2);
		上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D();
		上腕_鳥D2.下腕接続(下腕_鳥D2);
		if (RNG.XS.NextBool())
		{
			手_鳥D2.シャープ = 1.0;
			下腕_鳥D2.シャープ = 1.0;
			上腕_鳥D2.シャープ = 1.0;
		}
		四足胸D2.翼上左接続(上腕_鳥D2);
		四足胸D2.翼上右接続(上腕_鳥D2.Get逆());
		四足胸D2.背中接続(new 背中_羽D());
		足_鳥D e2 = new 足_鳥D();
		脚_鳥D 脚_鳥D2 = new 脚_鳥D();
		脚_鳥D2.足接続(e2);
		脚_鳥D2.尺度B = 1.3;
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(脚_鳥D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_獣D e3 = new 足_獣D();
		脚_獣D 脚_獣D2 = new 脚_獣D();
		脚_獣D2.足接続(e3);
		腿_獣D 腿_獣D2 = new 腿_獣D();
		腿_獣D2.脚接続(脚_獣D2);
		四足腰D2.腿左接続(腿_獣D2);
		四足腰D2.腿右接続(腿_獣D2.Get逆());
		四足腰D2.尾接続(new 尾_牛D());
		四足胴D2.SetValuesD("獣毛", true);
		obj.EnumEleD().SetValuesD<腰肌D>("獣毛", true);
		obj.EnumEleD().SetValuesD<胸毛D>("表示", true);
		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: false));
	}

	public static ChaD Getヒッポグリフ()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳羽();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		obj.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		四足胸D2.背中接続(new 背中_羽D
		{
			毛 = true
		});
		手_鳥D 手_鳥D2 = new 手_鳥D();
		下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D();
		下腕_鳥D2.手接続(手_鳥D2);
		上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D();
		上腕_鳥D2.下腕接続(下腕_鳥D2);
		if (RNG.XS.NextBool())
		{
			手_鳥D2.シャープ = 1.0;
			下腕_鳥D2.シャープ = 1.0;
			上腕_鳥D2.シャープ = 1.0;
		}
		四足胸D2.翼上左接続(上腕_鳥D2);
		四足胸D2.翼上右接続(上腕_鳥D2.Get逆());
		四足胸D2.背中接続(new 背中_羽D());
		足_鳥D e2 = new 足_鳥D();
		脚_鳥D 脚_鳥D2 = new 脚_鳥D
		{
			尺度B = 1.3
		};
		脚_鳥D2.足接続(e2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(脚_鳥D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_馬D e3 = new 足_馬D();
		脚_蹄D 脚_蹄D2 = new 脚_蹄D();
		脚_蹄D2.足接続(e3);
		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
		腿_蹄D2.脚接続(脚_蹄D2);
		四足腰D2.腿左接続(腿_蹄D2);
		四足腰D2.腿右接続(腿_蹄D2.Get逆());
		四足腰D2.尾接続(new 尾_馬D());
		obj.EnumEleD().SetValuesD<頭D>("馬", RNG.XS.NextBool());
		四足胴D2.SetValuesD("獣毛", true);
		obj.EnumEleD().SetValuesD<腰肌D>("獣毛", true);
		obj.EnumEleD().SetValuesD<胸毛D>("表示", true);
		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		四足胴D2.SetValuesD("獣性", false);
		四足腰D2.EnumEleD().SetValuesD<腰肌D>("獣性", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: false));
	}

	public static ChaD Getキマイラ()
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻R();
		頭D2.Set口人();
		頭D2.Set舌短();
		EleD eleD2 = new 獣耳D();
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		eleD2 = RNG.XS.Next(3) switch
		{
			0 => new 角2_山1D(), 
			1 => new 角2_山2D(), 
			_ => new 角2_山3D(), 
		};
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		腰D2.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		四足胸D2.背中接続(new 背中_羽D
		{
			毛 = true
		});
		手_獣D e2 = new 手_獣D();
		下腕_獣D 下腕_獣D2 = new 下腕_獣D();
		下腕_獣D2.手接続(e2);
		上腕_獣D 上腕_獣D2 = new 上腕_獣D();
		上腕_獣D2.下腕接続(下腕_獣D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_獣D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_牛D e3 = new 足_牛D();
		脚_蹄D 脚_蹄D2 = new 脚_蹄D();
		脚_蹄D2.足接続(e3);
		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
		腿_蹄D2.脚接続(脚_蹄D2);
		四足腰D2.腿左接続(腿_蹄D2);
		四足腰D2.腿右接続(腿_蹄D2.Get逆());
		四足腰D2.尾接続(new 尾_蛇D());
		腰D2.EnumEleD().SetValuesD("獣性", true);
		腰D2.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
		腰D2.EnumEleD().SetValuesD<頬肌D>("髭", 頭D2.鼻_接続.IsEleD<鼻_獣D>());
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD<性器_人D>("表示", false);
		腰D2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getスフィンクス(bool b)
	{
		腰D 腰D2 = Uni.腰();
		胴D e = 腰D2.Set胴();
		胸D 胸D2 = e.Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳人();
		if (b)
		{
			EleD e2 = (RNG.XS.NextBool() ? ((尾D)new 尾_牛D()) : ((尾D)new 尾_蛇D()));
			腰D2.尾接続(e2);
			胸D2.背中接続(new 背中_羽D
			{
				毛 = true
			});
			手_鳥D e3 = new 手_鳥D();
			下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D();
			下腕_鳥D2.手接続(e3);
			上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D();
			上腕_鳥D2.下腕接続(下腕_鳥D2);
			肩D 肩D2 = new 肩D();
			肩D2.上腕接続(上腕_鳥D2);
			胸D2.肩左接続(肩D2);
			胸D2.肩右接続(肩D2.Get逆());
			手_獣D e4 = new 手_獣D
			{
				尺度B = 0.9
			};
			下腕_獣D 下腕_獣D2 = new 下腕_獣D
			{
				尺度B = 0.9
			};
			下腕_獣D2.手接続(e4);
			上腕_人D 上腕_人D2 = new 上腕_人D();
			上腕_人D2.下腕接続(下腕_獣D2);
			肩D 肩D3 = new 肩D();
			肩D3.上腕接続(上腕_人D2);
			上腕_人D2.EnumEleD().SetValuesD("獣性", true);
			胸D2.肩左接続(肩D3);
			胸D2.肩右接続(肩D3.Get逆());
			足_獣D e5 = new 足_獣D();
			脚_獣D 脚_獣D2 = new 脚_獣D();
			脚_獣D2.足接続(e5);
			腿_獣D 腿_獣D2 = new 腿_獣D();
			腿_獣D2.脚接続(脚_獣D2);
			腰D2.腿左接続(腿_獣D2);
			腰D2.腿右接続(腿_獣D2.Get逆());
			胸D2.肌_接続.SetValuesD<胸毛D>("表示", true);
			胸D2.SetValuesD("獣性", true);
			e.SetValuesD("獣性", true);
			腰D2.SetValuesD("獣性", true);
		}
		else
		{
			手_鳥D e6 = new 手_鳥D();
			下腕_鳥D 下腕_鳥D3 = new 下腕_鳥D();
			下腕_鳥D3.手接続(e6);
			上腕_鳥D 上腕_鳥D3 = new 上腕_鳥D();
			上腕_鳥D3.下腕接続(下腕_鳥D3);
			肩D 肩D4 = new 肩D();
			肩D4.上腕接続(上腕_鳥D3);
			胸D2.肩左接続(肩D4);
			胸D2.肩右接続(肩D4.Get逆());
			四足胸D 四足胸D2 = Uni.四足胸();
			腰D2.半身接続(四足胸D2);
			四足胴D 四足胴D2 = Uni.四足胴();
			四足胸D2.胴接続(四足胴D2);
			四足腰D 四足腰D2 = Uni.四足腰();
			四足胴D2.腰接続(四足腰D2);
			四足胸D2.背中接続(new 背中_羽D
			{
				毛 = true
			});
			手_獣D e7 = new 手_獣D();
			下腕_獣D 下腕_獣D3 = new 下腕_獣D();
			下腕_獣D3.手接続(e7);
			上腕_獣D 上腕_獣D2 = new 上腕_獣D();
			上腕_獣D2.下腕接続(下腕_獣D3);
			四足脇D 四足脇D2 = new 四足脇D();
			四足脇D2.上腕接続(上腕_獣D2);
			四足胸D2.脇左接続(四足脇D2);
			四足胸D2.脇右接続(四足脇D2.Get逆());
			足_獣D e8 = new 足_獣D();
			脚_獣D 脚_獣D3 = new 脚_獣D();
			脚_獣D3.足接続(e8);
			腿_獣D 腿_獣D3 = new 腿_獣D();
			腿_獣D3.脚接続(脚_獣D3);
			四足腰D2.腿左接続(腿_獣D3);
			四足腰D2.腿右接続(腿_獣D3.Get逆());
			EleD e2 = (RNG.XS.NextBool() ? ((尾D)new 尾_牛D()) : ((尾D)new 尾_蛇D()));
			四足腰D2.尾接続(e2);
			四足胴D2.SetValuesD("獣毛", true);
			四足胸D2.肌_接続.SetValuesD<胸毛D>("表示", true);
			腰D2.EnumEleD().SetValuesD<性器_人D>("表示", false);
			腰D2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		}
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD<腰肌D>("獣性", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getレオントケンタウレ()
	{
		腰D obj = Uni.腰();
		胸D 胸D2 = obj.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻R();
		頭D2.Set口人();
		頭D2.Set舌短();
		EleD eleD2 = new 獣耳D();
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		obj.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		四足胸D2.背中接続(new 背中_羽D
		{
			毛 = true
		});
		手_獣D e2 = new 手_獣D();
		下腕_獣D 下腕_獣D2 = new 下腕_獣D();
		下腕_獣D2.手接続(e2);
		上腕_獣D 上腕_獣D2 = new 上腕_獣D();
		上腕_獣D2.下腕接続(下腕_獣D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_獣D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_獣D e3 = new 足_獣D();
		脚_獣D 脚_獣D2 = new 脚_獣D();
		脚_獣D2.足接続(e3);
		腿_獣D 腿_獣D2 = new 腿_獣D();
		腿_獣D2.脚接続(脚_獣D2);
		四足腰D2.腿左接続(腿_獣D2);
		四足腰D2.腿右接続(腿_獣D2.Get逆());
		四足腰D2.尾接続(new 尾_牛D());
		obj.EnumEleD().SetValuesD("獣性", true);
		obj.EnumEleD().SetValuesD<下腕_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
		胸D2.肌_接続.SetValuesD("胸毛", false);
		obj.EnumEleD().SetValuesD<頬肌D>("髭", 頭D2.鼻_接続.IsEleD<鼻_獣D>());
		obj.EnumEleD().SetValuesD<口_通常D>("牙", true);
		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getティグリスケンタウレ()
	{
		腰D 腰D2 = Uni.腰();
		胸D obj = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = obj.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻R();
		頭D2.Set口人();
		頭D2.Set舌短();
		EleD eleD2 = new 獣耳D();
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj.肩左接続(肩D2);
		obj.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		腰D2.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		手_獣D e2 = new 手_獣D();
		下腕_獣D 下腕_獣D2 = new 下腕_獣D();
		下腕_獣D2.手接続(e2);
		上腕_獣D 上腕_獣D2 = new 上腕_獣D();
		上腕_獣D2.下腕接続(下腕_獣D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_獣D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_獣D e3 = new 足_獣D();
		脚_獣D 脚_獣D2 = new 脚_獣D();
		脚_獣D2.足接続(e3);
		腿_獣D 腿_獣D2 = new 腿_獣D();
		腿_獣D2.脚接続(脚_獣D2);
		四足腰D2.腿左接続(腿_獣D2);
		四足腰D2.腿右接続(腿_獣D2.Get逆());
		四足腰D2.尾接続(new 尾_猫D());
		腰D2.EnumEleD().SetValuesD("獣性", true);
		腰D2.EnumEleD().SetValuesD<下腕_人D>("配色指定", 配色指定.B0);
		腰D2.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
		if (RNG.XS.NextBool())
		{
			腰D2.EnumEleD().SetValuesD<獣耳D>("配色指定", 配色指定.T0);
			腰D2.EnumEleD().SetValuesD<尾_猫D>("配色指定", 配色指定.T0);
		}
		else
		{
			腰D2.EnumEleD().SetValuesD<獣耳D>("配色指定", 配色指定.T1);
			腰D2.EnumEleD().SetValuesD<尾_猫D>("配色指定", 配色指定.T1);
		}
		四足胸D2.肌_接続.SetValuesD("胸毛", false);
		腰D2.EnumEleD().SetValuesD("虎", true);
		腰D2.EnumEleD().SetValuesD<頬肌D>("隈取", true);
		腰D2.EnumEleD().SetValuesD<頬肌D>("獣性", false);
		腰D2.EnumEleD().SetValuesD<上腕_人D>("淫", true);
		腰D2.EnumEleD().SetValuesD<上腕_人D>("ハート", false);
		腰D2.EnumEleD().SetValuesD<頬肌D>("髭", 頭D2.鼻_接続.IsEleD<鼻_獣D>());
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD<性器_人D>("表示", false);
		腰D2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getパンテーラケンタウレ()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻R();
		頭D2.Set口人();
		頭D2.Set舌短();
		EleD eleD2 = new 獣耳D();
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		obj.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		手_獣D e2 = new 手_獣D();
		下腕_獣D 下腕_獣D2 = new 下腕_獣D();
		下腕_獣D2.手接続(e2);
		上腕_獣D 上腕_獣D2 = new 上腕_獣D();
		上腕_獣D2.下腕接続(下腕_獣D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_獣D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_獣D e3 = new 足_獣D();
		脚_獣D 脚_獣D2 = new 脚_獣D();
		脚_獣D2.足接続(e3);
		腿_獣D 腿_獣D2 = new 腿_獣D();
		腿_獣D2.脚接続(脚_獣D2);
		四足腰D2.腿左接続(腿_獣D2);
		四足腰D2.腿右接続(腿_獣D2.Get逆());
		四足腰D2.尾接続(new 尾_猫D());
		obj.EnumEleD().SetValuesD("獣性", true);
		obj.EnumEleD().SetValuesD<下腕_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD("胸毛", false);
		obj.EnumEleD().SetValuesD("紋柄", true);
		obj.EnumEleD().SetValuesD<鼻肌D>("紋柄", false);
		obj.EnumEleD().SetValuesD<頬肌D>("獣性", false);
		obj.EnumEleD().SetValuesD<頬肌D>("髭", 頭D2.鼻_接続.IsEleD<鼻_獣D>());
		obj.EnumEleD().SetValuesD<口_通常D>("牙", true);
		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getチータケンタウレ()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻R();
		頭D2.Set口人();
		頭D2.Set舌短();
		EleD eleD2 = new 獣耳D();
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		double num = 0.95;
		四足胸D 四足胸D2 = Uni.四足胸();
		obj.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		四足胸D2.EnumEleD().SetValuesD("尺度XB", num);
		手_獣D e2 = new 手_獣D();
		下腕_獣D 下腕_獣D2 = new 下腕_獣D();
		下腕_獣D2.手接続(e2);
		上腕_獣D 上腕_獣D2 = new 上腕_獣D();
		上腕_獣D2.下腕接続(下腕_獣D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_獣D2);
		num = 1.035;
		下腕_獣D2.EnumEleD().SetValuesD("尺度YB", num);
		上腕_獣D2.尺度XB = num;
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_獣D e3 = new 足_獣D();
		脚_獣D 脚_獣D2 = new 脚_獣D();
		脚_獣D2.足接続(e3);
		腿_獣D 腿_獣D2 = new 腿_獣D();
		腿_獣D2.脚接続(脚_獣D2);
		脚_獣D2.EnumEleD().SetValuesD("尺度YB", num);
		腿_獣D2.尺度XB = num;
		四足腰D2.腿左接続(腿_獣D2);
		四足腰D2.腿右接続(腿_獣D2.Get逆());
		四足腰D2.尾接続(new 尾_猫D());
		四足腰D2.EnumEleD().SetValuesD("肥大", 0.5);
		obj.EnumEleD().SetValuesD("獣性", true);
		obj.EnumEleD().SetValuesD<下腕_人D>("獣腕", false);
		obj.EnumEleD().SetValuesD<手_人D>("獣性", false);
		obj.EnumEleD().SetValuesD<手_人D>("獣毛", true);
		obj.EnumEleD().SetValuesD<手_人D>("肉球", true);
		obj.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD<下腕_人D>("配色指定", 配色指定.B0);
		obj.EnumEleD().SetValuesD("胸毛", false);
		obj.EnumEleD().SetValuesD("紋柄", true);
		obj.EnumEleD().SetValuesD<鼻肌D>("紋柄", false);
		obj.EnumEleD().SetValuesD<頬肌D>("獣性", false);
		obj.EnumEleD().SetValuesD<頬肌D>("豹", true);
		obj.EnumEleD().SetValuesD<頬肌D>("髭", 頭D2.鼻_接続.IsEleD<鼻_獣D>());
		obj.EnumEleD().SetValuesD<口_通常D>("牙", true);
		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getウェアドラゴンフライ()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口R();
		頭D2.Set舌短();
		頭D2.Set耳尖();
		EleD eleD = new 虫顎D();
		頭D2.頬左接続(eleD);
		頭D2.頬右接続(eleD.Get逆());
		顔面_虫D 顔面_虫D2 = new 顔面_虫D();
		eleD = new 触覚_線D
		{
			尺度YB = 0.4
		};
		顔面_虫D2.触覚左接続(eleD);
		顔面_虫D2.触覚右接続(eleD.Get逆());
		頭D2.顔面接続(顔面_虫D2);
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		obj2.肩左接続(肩D2.Copy());
		obj2.肩右接続(肩D2.Get逆());
		eleD = new 前翅_羽D();
		obj2.翼上左接続(eleD);
		obj2.翼上右接続(eleD.Get逆());
		eleD = new 後翅_羽D();
		obj2.翼下左接続(eleD);
		obj2.翼下右接続(eleD.Get逆());
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		obj.腿左接続(腿_人D2);
		obj.腿右接続(腿_人D2.Get逆());
		eleD = new 尾_竜D();
		obj.尾接続(eleD);
		obj.EnumEleD().SetValuesD("虫性", true);
		obj.EnumEleD().SetValuesD("虫手", true);
		obj.EnumEleD().SetValuesD("虫足", true);
		obj.EnumEleD().SetValuesD("虫鎌節", false);
		obj.EnumEleD().SetValuesD<手_人D>("鱗", true);
		obj.EnumEleD().SetValuesD<足_人D>("鱗", true);
		obj.EnumEleD().SetValuesD("配色", 配色指定.C0);
		obj.EnumEleD().SetValuesD<双目D>("瞳孔", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: false));
	}

	public static ChaD Getウェアビートル()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳尖();
		頭D2.額接続(new 角1_虫D());
		EleD eleD = new 虫顎D();
		頭D2.頬左接続(eleD);
		頭D2.頬右接続(eleD.Get逆());
		顔面_甲D 顔面_甲D2 = new 顔面_甲D();
		eleD = new 触覚_甲D();
		顔面_甲D2.触覚左接続(eleD);
		顔面_甲D2.触覚右接続(eleD.Get逆());
		頭D2.顔面接続(顔面_甲D2);
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		obj2.肩左接続(肩D2.Copy());
		obj2.肩右接続(肩D2.Get逆());
		eleD = new 後翅_甲D();
		obj2.翼上左接続(eleD);
		obj2.翼上右接続(eleD.Get逆());
		eleD = new 前翅_甲D();
		eleD.SetValuesD("紋", RNG.XS.NextBool());
		obj2.翼上左接続(eleD);
		obj2.翼上右接続(eleD.Get逆());
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		obj.腿左接続(腿_人D2);
		obj.腿右接続(腿_人D2.Get逆());
		obj.EnumEleD().SetValuesD("虫性", true);
		obj.EnumEleD().SetValuesD("虫手", true);
		obj.EnumEleD().SetValuesD("虫足", true);
		obj.EnumEleD().SetValuesD("虫鎌節", false);
		obj.EnumEleD().SetValuesD<手_人D>("鱗", true);
		obj.EnumEleD().SetValuesD<足_人D>("鱗", true);
		obj.EnumEleD().SetValuesD("配色", 配色指定.C0);
		obj.EnumEleD().SetValuesD("棘3", false);
		obj.EnumEleD().SetValuesD("棘4", false);
		obj.EnumEleD().SetValuesD<双目D>("瞳孔", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: false));
	}

	public static ChaD Getウェアスタッグビートル()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳尖();
		EleD eleD = new 耳_尖D();
		頭D2.耳左接続(eleD);
		頭D2.耳右接続(eleD.Get逆());
		大顎基D 大顎基D2 = new 大顎基D();
		eleD = new 大顎D();
		大顎基D2.顎左接続(eleD);
		大顎基D2.顎右接続(eleD.Get逆());
		頭D2.大顎基接続(大顎基D2);
		顔面_甲D 顔面_甲D2 = new 顔面_甲D();
		eleD = new 触覚_甲D();
		顔面_甲D2.触覚左接続(eleD);
		顔面_甲D2.触覚右接続(eleD.Get逆());
		頭D2.顔面接続(顔面_甲D2);
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		obj2.肩左接続(肩D2.Copy());
		obj2.肩右接続(肩D2.Get逆());
		eleD = new 後翅_甲D();
		obj2.翼上左接続(eleD);
		obj2.翼上右接続(eleD.Get逆());
		eleD = new 前翅_甲D();
		eleD.SetValuesD("紋", RNG.XS.NextBool());
		obj2.翼上左接続(eleD);
		obj2.翼上右接続(eleD.Get逆());
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		obj.腿左接続(腿_人D2);
		obj.腿右接続(腿_人D2.Get逆());
		obj.EnumEleD().SetValuesD("虫性", true);
		obj.EnumEleD().SetValuesD("虫手", true);
		obj.EnumEleD().SetValuesD("虫足", true);
		obj.EnumEleD().SetValuesD("虫鎌節", false);
		obj.EnumEleD().SetValuesD<手_人D>("鱗", true);
		obj.EnumEleD().SetValuesD<足_人D>("鱗", true);
		obj.EnumEleD().SetValuesD("配色", 配色指定.C0);
		obj.EnumEleD().SetValuesD<脚_人D>("棘", false);
		obj.EnumEleD().SetValuesD<双目D>("瞳孔", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: false));
	}

	public static ChaD Getウェアマンティス()
	{
		腰D obj = Uni.腰();
		胴D obj2 = obj.Set胴();
		胸D obj3 = obj2.Set胸R();
		頭D 頭D2 = obj3.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口R();
		頭D2.Set舌短();
		頭D2.Set耳尖();
		EleD eleD = new 虫顎D();
		頭D2.頬左接続(eleD);
		頭D2.頬右接続(eleD.Get逆());
		顔面_虫D 顔面_虫D2 = new 顔面_虫D();
		eleD = new 触覚_線D();
		顔面_虫D2.触覚左接続(eleD);
		顔面_虫D2.触覚右接続(eleD.Get逆());
		頭D2.顔面接続(顔面_虫D2);
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		下腕_人D2.虫鎌接続(new 虫鎌D());
		obj3.肩左接続(肩D2);
		obj3.肩右接続(肩D2.Get逆());
		eleD = new 前翅_草D();
		eleD.SetValuesD("紋", RNG.XS.NextBool());
		obj2.翼左接続(eleD);
		obj2.翼右接続(eleD.Get逆());
		eleD = new 後翅_草D();
		obj2.翼左接続(eleD);
		obj2.翼右接続(eleD.Get逆());
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		obj.腿左接続(腿_人D2);
		obj.腿右接続(腿_人D2.Get逆());
		eleD = new 尾_虫D();
		obj.尾接続(eleD);
		obj.EnumEleD().SetValuesD("虫性", true);
		obj.EnumEleD().SetValuesD("虫手", true);
		obj.EnumEleD().SetValuesD("虫足", true);
		obj.EnumEleD().SetValuesD<手_人D>("鱗", true);
		obj.EnumEleD().SetValuesD<足_人D>("鱗", true);
		obj.EnumEleD().SetValuesD("配色", 配色指定.C0);
		obj.EnumEleD().SetValuesD<脚_人D>("棘2", false);
		obj.EnumEleD().SetValuesD<脚_人D>("棘3", false);
		obj.EnumEleD().SetValuesD<双目D>("瞳孔", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: false));
	}

	public static ChaD Getエキドナ()
	{
		腰D 腰D2 = Uni.腰();
		胸D obj = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = obj.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌長();
		if (RNG.XS.NextBool())
		{
			頭D2.Set耳人();
		}
		else
		{
			頭D2.Set耳尖();
		}
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj.肩左接続(肩D2);
		obj.肩右接続(肩D2.Get逆());
		手_鳥D 手_鳥D2 = new 手_鳥D
		{
			シャープ = RNG.XS.NextDouble()
		};
		下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D
		{
			シャープ = 手_鳥D2.シャープ
		};
		下腕_鳥D2.手接続(手_鳥D2);
		上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D
		{
			シャープ = 下腕_鳥D2.シャープ
		};
		上腕_鳥D2.下腕接続(下腕_鳥D2);
		obj.翼上左接続(上腕_鳥D2);
		obj.翼上右接続(上腕_鳥D2.Get逆());
		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
		腰D2.半身接続(長物_蛇D2);
		胴_蛇D 胴_蛇D2 = new 胴_蛇D();
		長物_蛇D2.胴接続(胴_蛇D2);
		for (int i = 0; i < 45; i++)
		{
			胴_蛇D2.胴接続(胴_蛇D2 = new 胴_蛇D());
		}
		胴_蛇D2.胴接続(RNG.XS.NextBool() ? ((尾D)new 尾_ヘD()) : ((尾D)new 尾_ガD()));
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD<舌_長D>("股舌表示", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getゴルゴン()
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		後髪0_肢系D 後髪0_肢系D2 = new 後髪0_肢系D();
		EleD eleD2 = new 尾_蛇D();
		後髪0_肢系D2.左5接続(eleD2);
		後髪0_肢系D2.左4接続(eleD2.Copy());
		後髪0_肢系D2.左3接続(eleD2.Copy());
		後髪0_肢系D2.左2接続(eleD2.Copy());
		後髪0_肢系D2.左1接続(eleD2.Copy());
		後髪0_肢系D2.右1接続(eleD2.Copy());
		後髪0_肢系D2.右2接続(eleD2.Copy());
		後髪0_肢系D2.右3接続(eleD2.Copy());
		後髪0_肢系D2.右4接続(eleD2.Copy());
		後髪0_肢系D2.右5接続(eleD2.Copy());
		eleD.後髪_接続.RemoveAt(0);
		eleD.後髪_接続.Insert(0, 後髪0_肢系D2);
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口裂();
		頭D2.Set舌長();
		頭D2.Set耳尖();
		頭D2.額接続(SlaveMatrix.GameClasses._Con.Get縦眼R());
		eleD2 = SlaveMatrix.GameClasses._Con.Get頬眼R(右: false);
		頭D2.頬肌左接続(eleD2);
		頭D2.頬肌右接続(eleD2.Get逆());
		eleD2 = RNG.XS.Next(3) switch
		{
			0 => new 角2_牛1D(), 
			1 => new 角2_牛4D(), 
			_ => new 角2_鬼D(), 
		};
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		腰D2.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		手_鳥D 手_鳥D2 = new 手_鳥D
		{
			シャープ = RNG.XS.NextDouble()
		};
		下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D
		{
			シャープ = 手_鳥D2.シャープ
		};
		下腕_鳥D2.手接続(手_鳥D2);
		上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D
		{
			シャープ = 下腕_鳥D2.シャープ
		};
		上腕_鳥D2.下腕接続(下腕_鳥D2);
		四足胸D2.翼上左接続(上腕_鳥D2);
		四足胸D2.翼上右接続(上腕_鳥D2.Get逆());
		足_馬D e2 = new 足_馬D();
		脚_蹄D 脚_蹄D2 = new 脚_蹄D();
		脚_蹄D2.足接続(e2);
		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
		腿_蹄D2.脚接続(脚_蹄D2);
		四足腰D2.腿左接続(腿_蹄D2);
		四足腰D2.腿右接続(腿_蹄D2.Get逆());
		四足腰D2.尾接続(new 尾_馬D());
		腰D2.EnumEleD().SetValuesD<上腕_人D>("竜性", true);
		腰D2.EnumEleD().SetValuesD<下腕_人D>("竜性", true);
		腰D2.EnumEleD().SetValuesD<手_人D>("鱗", true);
		腰D2.EnumEleD().SetValuesD<手_人D>("配色", 配色指定.S0);
		腰D2.EnumEleD().SetValuesD<性器_人D>("表示", false);
		腰D2.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getヒュドラ()
	{
		腰D 腰D2 = Uni.腰();
		頭D 頭D2 = 腰D2.Set胴().Set胸R().Set首()
			.Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		後髪0_肢系D 後髪0_肢系D2 = new 後髪0_肢系D();
		EleD eleD2 = new 尾_蛇D();
		後髪0_肢系D2.左5接続(eleD2);
		後髪0_肢系D2.左4接続(eleD2.Copy());
		後髪0_肢系D2.左3接続(eleD2.Copy());
		後髪0_肢系D2.左2接続(eleD2.Copy());
		後髪0_肢系D2.左1接続(eleD2.Copy());
		後髪0_肢系D2.右1接続(eleD2.Copy());
		後髪0_肢系D2.右2接続(eleD2.Copy());
		後髪0_肢系D2.右3接続(eleD2.Copy());
		後髪0_肢系D2.右4接続(eleD2.Copy());
		後髪0_肢系D2.右5接続(eleD2.Copy());
		eleD.後髪_接続.RemoveAt(0);
		eleD.後髪_接続.Insert(0, 後髪0_肢系D2);
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口裂();
		頭D2.Set舌長();
		頭D2.Set耳人();
		頭頂_宇D 頭頂_宇D2 = new 頭頂_宇D
		{
			鱗 = true
		};
		頭頂_宇D2.頭部後接続(new 頭頂後_宇D());
		頭D2.頭頂接続(頭頂_宇D2);
		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
		腰D2.半身接続(長物_蛇D2);
		胴_蛇D 胴_蛇D2 = new 胴_蛇D();
		長物_蛇D2.胴接続(胴_蛇D2);
		for (int i = 0; i < 45; i++)
		{
			胴_蛇D2.胴接続(胴_蛇D2 = new 胴_蛇D());
		}
		胴_蛇D2.胴接続(new 尾_ヘD());
		腰D2.EnumEleD().SetValuesD("竜性", true);
		腰D2.EnumEleD().SetValuesD<腰肌D>("竜性", false);
		腰D2.EnumEleD().SetValuesD<舌_長D>("股舌表示", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getウロボロス()
	{
		腰D 腰D2 = Uni.腰();
		頭D 頭D2 = 腰D2.Set胴().Set胸R().Set首()
			.Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口裂();
		頭D2.Set舌長();
		頭D2.Set耳人();
		頭D2.額接続(new 角1_虫D());
		EleD eleD2 = new 角2_虫D();
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		顔面_甲D e = new 顔面_甲D();
		頭D2.顔面接続(e);
		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
		腰D2.半身接続(長物_蛇D2);
		胴_蛇D 胴_蛇D2 = new 胴_蛇D();
		長物_蛇D2.胴接続(胴_蛇D2);
		for (int i = 0; i < 40; i++)
		{
			胴_蛇D2.胴接続(胴_蛇D2 = new 胴_蛇D());
		}
		胴_蛇D2.胴接続(new 尾_ヘD());
		腰D2.EnumEleD().SetValuesD("竜性", true);
		腰D2.EnumEleD().SetValuesD<腰肌D>("竜性", false);
		腰D2.EnumEleD().SetValuesD("コア1", true);
		腰D2.EnumEleD().SetValuesD<舌_長D>("股舌表示", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getカッパ()
	{
		腰D 腰D2 = Uni.腰();
		胸D obj = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = obj.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳尖();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj.肩左接続(肩D2);
		obj.肩右接続(肩D2.Get逆());
		頭D2.頭頂接続(new 頭頂_皿D());
		obj.背中接続(new 背中_甲D
		{
			縁側角 = RNG.XS.NextDouble()
		});
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		腰D2.腿左接続(腿_人D2);
		腰D2.腿右接続(腿_人D2.Get逆());
		if (RNG.XS.NextBool())
		{
			EleD e3 = new 尾_短D();
			腰D2.尾接続(e3);
		}
		腰D2.EnumEleD().SetValuesD("腹板", true);
		腰D2.EnumEleD().SetValuesD<胸腹板D>("表示", true);
		腰D2.EnumEleD().SetValuesD<胴腹板D>("表示", true);
		腰D2.EnumEleD().SetValuesD<ボテ腹板D>("表示", false);
		腰D2.EnumEleD().SetValuesD("水掻", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getムカデジョウロウ()
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口R();
		頭D2.Set舌短();
		頭D2.Set耳人();
		EleD eleD;
		if (RNG.XS.NextBool())
		{
			eleD = new 虫顎D
			{
				尺度B = 1.1
			};
			頭D2.頬左接続(eleD);
			頭D2.頬右接続(eleD.Get逆());
		}
		if (RNG.XS.NextBool())
		{
			eleD = new 触覚_節D
			{
				尺度B = 1.4
			};
			頭D2.触覚左接続(eleD);
			頭D2.触覚右接続(eleD.Get逆());
		}
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		if (RNG.XS.NextBool())
		{
			胸D2.肩左接続(肩D2.Copy());
			胸D2.肩右接続(肩D2.Get逆());
			胸D2.肩左接続(肩D2.Copy());
			胸D2.肩右接続(肩D2.Get逆());
		}
		長物_蟲D 長物_蟲D2 = new 長物_蟲D();
		腰D2.半身接続(長物_蟲D2);
		eleD = new 節足_足百D();
		長物_蟲D2.左0接続(eleD);
		長物_蟲D2.右0接続(eleD.Get逆());
		長物_蟲D2.左1接続(eleD.Copy());
		長物_蟲D2.右1接続(eleD.Get逆());
		胴_蟲D 胴_蟲D2 = new 胴_蟲D();
		長物_蟲D2.胴接続(胴_蟲D2);
		胴_蟲D2.左接続(eleD.Copy());
		胴_蟲D2.右接続(eleD.Get逆());
		for (int i = 0; i < 21; i++)
		{
			胴_蟲D2.胴接続(胴_蟲D2 = new 胴_蟲D());
			胴_蟲D2.左接続(eleD.Copy());
			胴_蟲D2.右接続(eleD.Get逆());
		}
		尾_蟲D 尾_蟲D2 = new 尾_蟲D();
		節尾_曳航D 節尾_曳航D2 = new 節尾_曳航D();
		尾_蟲D2.左1接続(eleD.Copy());
		尾_蟲D2.右1接続(eleD.Get逆());
		尾_蟲D2.左2接続(eleD.Copy());
		尾_蟲D2.右2接続(eleD.Get逆());
		尾_蟲D2.左3接続(eleD.Copy());
		尾_蟲D2.右3接続(eleD.Get逆());
		尾_蟲D2.左4接続(eleD.Copy());
		尾_蟲D2.右4接続(eleD.Get逆());
		尾_蟲D2.左5接続(eleD.Copy());
		尾_蟲D2.右5接続(eleD.Get逆());
		尾_蟲D2.尾左接続(節尾_曳航D2);
		尾_蟲D2.尾右接続(節尾_曳航D2.Get逆());
		胴_蟲D2.胴接続(尾_蟲D2);
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getカーバンクル()
	{
		腰D 腰D2 = Uni.腰();
		胸D obj = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = obj.Set首().Set頭R1();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		EleD eleD2 = new 獣耳D
		{
			尺度B = 1.1,
			尺度YB = 1.2
		};
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		腰D2.尾接続(new 尾_馬D());
		obj.背中接続(new 背中_羽D
		{
			毛 = true
		});
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj.肩左接続(肩D2);
		obj.肩右接続(肩D2.Get逆());
		足_獣D e2 = new 足_獣D();
		脚_獣D 脚_獣D2 = new 脚_獣D();
		脚_獣D2.足接続(e2);
		腿_獣D 腿_獣D2 = new 腿_獣D();
		腿_獣D2.脚接続(脚_獣D2);
		腰D2.腿左接続(腿_獣D2);
		腰D2.腿右接続(腿_獣D2.Get逆());
		腰D2.EnumEleD().SetValuesD("獣性", true);
		腰D2.EnumEleD().SetValuesD("秘石", true);
		腰D2.EnumEleD().SetValuesD<下腕_人D>("配色指定", 配色指定.B0);
		腰D2.EnumEleD().SetValuesD<手_人D>("配色指定", 配色指定.B0);
		腰D2.EnumEleD().SetValuesD<頬肌D>("髭", 頭D2.鼻_接続.IsEleD<鼻_獣D>());
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getバジリスク()
	{
		腰D 腰D2 = Uni.腰();
		胴D obj = 腰D2.Set胴();
		頭D 頭D2 = obj.Set胸R().Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌長();
		頭D2.Set耳人();
		頭頂_宇D 頭頂_宇D2 = new 頭頂_宇D
		{
			鱗 = true
		};
		頭頂_宇D2.頭部後接続(new 頭頂後_宇D());
		頭D2.頭頂接続(頭頂_宇D2);
		頭D2.額接続(new 角1_虫D());
		手_鳥D 手_鳥D2 = new 手_鳥D
		{
			シャープ = RNG.XS.NextDouble()
		};
		下腕_鳥D 下腕_鳥D2 = new 下腕_鳥D
		{
			シャープ = 手_鳥D2.シャープ
		};
		下腕_鳥D2.手接続(手_鳥D2);
		上腕_鳥D 上腕_鳥D2 = new 上腕_鳥D
		{
			シャープ = 下腕_鳥D2.シャープ
		};
		上腕_鳥D2.下腕接続(下腕_鳥D2);
		obj.翼左接続(上腕_鳥D2);
		obj.翼右接続(上腕_鳥D2.Get逆());
		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
		腰D2.半身接続(長物_蛇D2);
		足_鳥D e = new 足_鳥D
		{
			尺度B = 1.1
		};
		脚_竜D 脚_竜D2 = new 脚_竜D
		{
			尺度B = 1.1
		};
		脚_竜D2.足接続(e);
		四足脇D 四足脇D2 = new 四足脇D
		{
			尺度B = 1.1
		};
		四足脇D2.上腕接続(脚_竜D2);
		腰D2.翼左接続(四足脇D2);
		腰D2.翼右接続(四足脇D2.Get逆());
		胴_蛇D 胴_蛇D2 = new 胴_蛇D();
		長物_蛇D2.胴接続(胴_蛇D2);
		for (int i = 0; i < 30; i++)
		{
			胴_蛇D2.胴接続(胴_蛇D2 = new 胴_蛇D());
		}
		胴_蛇D2.胴接続(new 尾_ヘD());
		腰D2.EnumEleD().SetValuesD("竜性", true);
		腰D2.EnumEleD().SetValuesD<腰肌D>("竜性", false);
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getコカトリス()
	{
		腰D 腰D2 = Uni.腰();
		胴D obj = 腰D2.Set胴();
		胸D 胸D2 = obj.Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌長();
		頭D2.Set耳羽();
		手_蝙D e = new 手_蝙D();
		下腕_蝙D 下腕_蝙D2 = new 下腕_蝙D();
		下腕_蝙D2.手接続(e);
		上腕_蝙D 上腕_蝙D2 = new 上腕_蝙D();
		上腕_蝙D2.下腕接続(下腕_蝙D2);
		obj.翼左接続(上腕_蝙D2);
		obj.翼右接続(上腕_蝙D2.Get逆());
		胸D2.背中接続(new 背中_羽D
		{
			毛 = true
		});
		長物_蛇D 長物_蛇D2 = new 長物_蛇D();
		腰D2.半身接続(長物_蛇D2);
		足_鳥D e2 = new 足_鳥D
		{
			尺度B = 1.1
		};
		脚_竜D 脚_竜D2 = new 脚_竜D
		{
			尺度B = 1.1
		};
		脚_竜D2.足接続(e2);
		四足脇D 四足脇D2 = new 四足脇D
		{
			尺度B = 1.1
		};
		四足脇D2.上腕接続(脚_竜D2);
		腰D2.翼左接続(四足脇D2);
		腰D2.翼右接続(四足脇D2.Get逆());
		胴_蛇D 胴_蛇D2 = new 胴_蛇D();
		長物_蛇D2.胴接続(胴_蛇D2);
		for (int i = 0; i < 30; i++)
		{
			胴_蛇D2.胴接続(胴_蛇D2 = new 胴_蛇D());
		}
		胴_蛇D2.胴接続(new 尾_ヘD());
		腰D2.EnumEleD().SetValuesD("獣性", true);
		腰D2.EnumEleD().SetValuesD("竜性", true);
		腰D2.EnumEleD().SetValuesD<腰肌D>("竜性", false);
		腰D2.EnumEleD().SetValuesD<頬肌D>("髭", false);
		腰D2.EnumEleD().SetValuesD<口_通常D>("牙", true);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(b0: false));
	}

	public static ChaD Getカトブレパス()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		eleD.前髪_接続.RemoveAt(0);
		eleD.前髪接続(new 前髪_目隠れ1D());
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳獣();
		頭D2.額接続(SlaveMatrix.GameClasses._Con.Get縦眼R());
		EleD eleD2 = new 角2_牛2D();
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		四足胸D 四足胸D2 = Uni.四足胸();
		obj.半身接続(四足胸D2);
		四足胴D 四足胴D2 = Uni.四足胴();
		四足胸D2.胴接続(四足胴D2);
		四足腰D 四足腰D2 = Uni.四足腰();
		四足胴D2.腰接続(四足腰D2);
		手_牛D e2 = new 手_牛D();
		下腕_蹄D 下腕_蹄D2 = new 下腕_蹄D();
		下腕_蹄D2.手接続(e2);
		上腕_蹄D 上腕_蹄D2 = new 上腕_蹄D();
		上腕_蹄D2.下腕接続(下腕_蹄D2);
		四足脇D 四足脇D2 = new 四足脇D();
		四足脇D2.上腕接続(上腕_蹄D2);
		四足胸D2.脇左接続(四足脇D2);
		四足胸D2.脇右接続(四足脇D2.Get逆());
		足_牛D e3 = new 足_牛D();
		脚_蹄D 脚_蹄D2 = new 脚_蹄D();
		脚_蹄D2.足接続(e3);
		腿_蹄D 腿_蹄D2 = new 腿_蹄D();
		腿_蹄D2.脚接続(脚_蹄D2);
		四足腰D2.腿左接続(腿_蹄D2);
		四足腰D2.腿右接続(腿_蹄D2.Get逆());
		四足腰D2.尾接続(new 尾_牛D());
		obj.EnumEleD().SetValuesD("獣性", true);
		obj.EnumEleD().SetValuesD<頬肌D>("髭", false);
		obj.EnumEleD().SetValuesD("猫目", true);
		obj.EnumEleD().SetValuesD<性器_人D>("表示", false);
		obj.EnumEleD().SetValuesD<肛門_人D>("表示", false);
		obj.EnumEleD().SetValuesD<手_人D>("肉球", false);
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: false));
	}

	public static ChaD Getミノタウロス()
	{
		腰D 腰D2 = Uni.腰();
		胸D 胸D2 = 腰D2.Set胴().Set胸R();
		頭D 頭D2 = 胸D2.Set首().Set頭R();
		基髪D eleD = 頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳獣();
		EleD eleD2 = RNG.XS.Next(4) switch
		{
			0 => new 角2_牛1D(), 
			1 => new 角2_牛2D(), 
			2 => new 角2_牛3D(), 
			_ => new 角2_牛4D(), 
		};
		eleD.頭頂左接続(eleD2);
		eleD.頭頂右接続(eleD2.Get逆());
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		胸D2.肩左接続(肩D2);
		胸D2.肩右接続(肩D2.Get逆());
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		腰D2.腿左接続(腿_人D2);
		腰D2.腿右接続(腿_人D2.Get逆());
		腰D2.尾接続(new 尾_牛D());
		腰D2.EnumEleD().SetValuesD("獣性", true);
		腰D2.EnumEleD().SetValuesD<頬肌D>("髭", false);
		腰D2.EnumEleD().SetValuesD<手_人D>("肉球", false);
		腰D2.EnumEleD().SetValuesD("獣毛2", false);
		腰D2.EnumEleD().SetValuesD<下腕_人D>("配色指定", 配色指定.B0);
		腰D2.EnumEleD().SetValuesD<脚_人D>("配色指定", 配色指定.B0);
		腰D2.EnumEleD().SetValuesD<足_人D>("配色指定", 配色指定.B0);
		腰D2.EnumEleD().SetValuesD("バスト", 1.0);
		腰D2.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		腰D2.EnumEleD().SetValuesD("身長", 頭D2.目高);
		腰D2.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		腰D2.SetLowerHair();
		腰D2.AdjustScale(頭D2);
		return new ChaD(腰D2, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getリリン()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳人();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		obj.腿左接続(腿_人D2);
		obj.腿右接続(腿_人D2.Get逆());
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 頭D2.目高);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(RNG.XS.NextBool()));
	}

	public static ChaD Getエルフ()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳長();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		obj.腿左接続(腿_人D2);
		obj.腿右接続(腿_人D2.Get逆());
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", 1.0);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: true));
	}

	public static ChaD Getドワーフ()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳尖();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		obj.腿左接続(腿_人D2);
		obj.腿右接続(腿_人D2.Get逆());
		obj.EnumEleD().SetValuesD("肥大", 1.0);
		obj.EnumEleD().SetValuesD("身長", 0.0);
		obj.EnumEleD().SetValuesD("鋭爪", 0.2 + RNG.XS.NextDouble(0.8));
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: true));
	}

	public static ChaD GetViola()
	{
		腰D waist_description = Uni.腰();
		胴D body_description = waist_description.Set胴();
		胸D chest_description = body_description.Set胸R();
		首D neck_description = chest_description.Set首();
		頭D head_description = Uni.頭();
		neck_description.頭接続(head_description);
		head_description.目高 = 0.85;
		基髪D hair_description = (基髪D)head_description.基髪_接続[0];
		後髪0_カルD backhair_description = new 後髪0_カルD
		{
			髪長0 = 1.0,
			髪長1 = 1.0,
			毛量 = 1.0,
			広がり = 1.0
		};
		hair_description.後髪接続(backhair_description);
		横髪_カルD sidehair_description = new 横髪_カルD
		{
			髪長1 = 1.0,
			髪長2 = 1.0,
			毛量 = 1.0,
			広がり = 1.0
		};
		hair_description.横髪左接続(sidehair_description);
		hair_description.横髪右接続(sidehair_description.Get逆());
		hair_description.前髪接続(new 前髪_目隠れ2D
		{
			髪長 = 1.0,
			髪ハネ左_表示 = false,
			髪ハネ右_表示 = false,
			編み左表示 = false,
			編み右表示 = false
		});
		双目D eyes_description = Uni.魔中目(右: false);
		瞼_中D eyelids_discription = (瞼_中D)eyes_description.瞼_接続[0];
		eyelids_discription.サイズ = 0.5;
		eyelids_discription.サイズX = 0.8;
		eyelids_discription.サイズY = 0.5;
		eyelids_discription.外線 = 0.5;
		eyelids_discription.睫毛_睫毛3_長さ = 0.5;
		eyelids_discription.睫毛_睫毛4_長さ = 0.5;
		eyelids_discription.睫毛_睫毛1_長さ = 0.5;
		eyelids_discription.睫毛_睫毛2_長さ = 0.5;
		eyelids_discription.傾き = 0.8;
		head_description.目左接続(eyes_description);
		head_description.目右接続(eyes_description.Get逆());
		眉D eyebrow_description = new 眉D
		{
			サイズY = 0.4
		};
		head_description.眉左接続(eyebrow_description);
		head_description.眉右接続(eyebrow_description.Get逆());
		head_description.Set鼻人();
		head_description.Set口人();
		head_description.Set舌短();
		head_description.Set耳尖();


		手_人D hand_description = new 手_人D();
		下腕_人D lowerarm_description = new 下腕_人D();
		lowerarm_description.手接続(hand_description);
		上腕_人D upperarm_description = new 上腕_人D();
		upperarm_description.下腕接続(lowerarm_description);

		肩D shoulder_description = new 肩D();
		shoulder_description.上腕接続(upperarm_description);
		chest_description.肩左接続(shoulder_description);
		chest_description.肩右接続(shoulder_description.Get逆());

		EleD eleD = new 角2_牛4D();
		hair_description.頭頂左接続(eleD);
		hair_description.頭頂右接続(eleD.Get逆());

		植D 植D2 = new 植D();
		花_薔D 花_薔D2 = new 花_薔D();
		植D2.花接続(花_薔D2);
		花_薔D2.SetValuesD("表示", false);
		花_薔D2.萼_萼_表示 = true;
		花_薔D2.表示 = true;
		
		bool flag = (植D2.披針葉4_葉脈_表示 = (植D2.披針葉4_葉_表示 = (植D2.披針葉3_葉脈_表示 = (植D2.披針葉3_葉_表示 = (植D2.披針葉2_葉脈_表示 = (植D2.披針葉2_葉_表示 = (植D2.披針葉1_葉脈_表示 = (植D2.披針葉1_葉_表示 = true))))))));
		植D2.心臓葉1_葉_表示 = !flag;
		植D2.心臓葉1_葉脈_表示 = !flag;
		植D2.心臓葉2_葉_表示 = !flag;
		植D2.心臓葉2_葉脈_表示 = !flag;
		植D2.心臓葉3_葉_表示 = !flag;
		植D2.心臓葉3_葉脈_表示 = !flag;
		植D2.心臓葉4_葉_表示 = !flag;
		植D2.心臓葉4_葉脈_表示 = !flag;

		hair_description.頭頂左接続(植D2);
		hair_description.頭頂右接続(植D2.Get逆());
		手_蝙D e3 = new 手_蝙D
		{
			シャープ = 1.0
		};


		下腕_蝙D 下腕_蝙D2 = new 下腕_蝙D();
		下腕_蝙D2.手接続(e3);
		上腕_蝙D 上腕_蝙D2 = new 上腕_蝙D();
		上腕_蝙D2.下腕接続(下腕_蝙D2);

		chest_description.翼上左接続(上腕_蝙D2);
		chest_description.翼上右接続(上腕_蝙D2.Get逆());
		触手_蔦D 触手_蔦D2 = new 触手_蔦D
		{
			先端表示 = true
		};

		触手_蔦D2.SetValuesD("棘", true);
		EleD eleD2 = new 葉_披D();
		eleD2.尺度B *= 1.25;
		触手_蔦D2.節3接続(eleD2 = eleD2.Copy());
		eleD2.尺度B *= 葉倍率;
		触手_蔦D2.節5接続(eleD2 = eleD2.Copy());
		eleD2.尺度B *= 葉倍率;
		触手_蔦D2.節7接続(eleD2 = eleD2.Copy());
		eleD2.尺度B *= 葉倍率;
		触手_蔦D2.節9接続(eleD2 = eleD2.Copy());
		eleD2.尺度B *= 葉倍率;
		触手_蔦D2.節11接続(eleD2 = eleD2.Copy());
		eleD2.尺度B *= 葉倍率;
		触手_蔦D2.節13接続(eleD2 = eleD2.Copy());
		eleD2.尺度B *= 葉倍率;
		触手_蔦D2.節15接続(eleD2 = eleD2.Copy());
		eleD2.尺度B *= 葉倍率;
		触手_蔦D2.節17接続(eleD2 = eleD2.Copy());
		eleD2.尺度B *= 葉倍率;
		触手_蔦D2.節19接続(eleD2 = eleD2.Copy());
		eleD2.尺度B *= 葉倍率;
		EleD eleD3 = 触手_蔦D2.Copy();

		body_description.翼左接続(触手_蔦D2);
		body_description.翼右接続(触手_蔦D2.Get逆());
		waist_description.翼左接続(eleD3);
		waist_description.翼右接続(eleD3.Get逆());
		足_人D foot_description = new 足_人D();
		脚_人D legs_description = new 脚_人D();
		legs_description.足接続(foot_description);
		腿_人D thigh_description = new 腿_人D();
		thigh_description.脚接続(legs_description);

		waist_description.腿左接続(thigh_description);
		waist_description.腿右接続(thigh_description.Get逆());
		waist_description.EnumEleD().SetValuesD("陰毛", true);
		waist_description.EnumEleD().SetValuesD("植", true);
		waist_description.EnumEleD().SetValuesD("淫", true);
		waist_description.EnumEleD().SetValuesD<胸肌D>("植タトゥ", false);
		waist_description.EnumEleD().SetValuesD<上腕_人D>("植タトゥ", false);
		waist_description.EnumEleD().SetValuesD<下腕_人D>("淫", false);
		waist_description.EnumEleD().SetValuesD<腰肌D>("ハート", false);
		waist_description.EnumEleD().SetValuesD<頬肌D>("ハート", false);
		waist_description.EnumEleD().SetValuesD<頭D>("隈取", true);
		waist_description.EnumEleD().SetValuesD<腿_人D>("悪", true);
		waist_description.EnumEleD().SetValuesD<腰D>("悪", true);
		waist_description.EnumEleD().SetValuesD<腿_人D>("葉1", false);
		waist_description.EnumEleD().SetValuesD("猫目", true);
		waist_description.EnumEleD().SetValuesD("バスト", 0.85);
		waist_description.EnumEleD().SetValuesD("肥大", 0.3);
		waist_description.EnumEleD().SetValuesD("身長", 0.9);
		waist_description.EnumEleD().SetValuesD("鋭爪", 0.6);

		ChaD chaD = new ChaD(waist_description, new 体色(b0: false)
		{
			髪 = Color.FromArgb(255, 239, 241, 194).Add(0, 128, 0),
			眉 = Color.FromArgb(255, 239, 241, 194).Add(0, 128, 0),
			毛0 = Color.DarkGreen,
			体1 = Color.Violet,
			植0 = Color.DarkGreen.Add(0, 0, -50),
			植1 = Color.DarkGreen,
			人肌 = Color.FromArgb(255, 121, 200, 162),
			目左 = Color.LightPink,
			目右 = Color.LightPink,
			白部 = Color.FromArgb(255, 238, 248, 238),
			膜 = Color.Purple,
			刺青 = Color.FromArgb(255, 134, 0, 62),
			口紅 = Color.FromArgb(255, 134, 0, 62)
		});

		chaD.SetViola();
		waist_description.AdjustScale(head_description);
		return chaD;

	}

	public static ChaD Getヒューマン()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set双目R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳人();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		obj.腿左接続(腿_人D2);
		obj.腿右接続(腿_人D2.Get逆());
		obj.EnumEleD().SetValuesD("肥大", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("身長", RNG.XS.NextDouble());
		obj.EnumEleD().SetValuesD("鋭爪", 0.0);
		obj.SetLowerHair();
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: true));
	}

	public static ChaD Getプレーヤー()
	{
		腰D obj = Uni.腰();
		胸D obj2 = obj.Set胴().Set胸R();
		頭D 頭D2 = obj2.Set首().Set頭R();
		頭D2.EnumEleD().GetEleD<基髪D>();
		頭D2.Set目弱R();
		頭D2.Set鼻人();
		頭D2.Set口人();
		頭D2.Set舌短();
		頭D2.Set耳人();
		手_人D e = new 手_人D();
		下腕_人D 下腕_人D2 = new 下腕_人D();
		下腕_人D2.手接続(e);
		上腕_人D 上腕_人D2 = new 上腕_人D();
		上腕_人D2.下腕接続(下腕_人D2);
		肩D 肩D2 = new 肩D();
		肩D2.上腕接続(上腕_人D2);
		obj2.肩左接続(肩D2);
		obj2.肩右接続(肩D2.Get逆());
		足_人D e2 = new 足_人D();
		脚_人D 脚_人D2 = new 脚_人D();
		脚_人D2.足接続(e2);
		腿_人D 腿_人D2 = new 腿_人D();
		腿_人D2.脚接続(脚_人D2);
		obj.腿左接続(腿_人D2);
		obj.腿右接続(腿_人D2.Get逆());
		obj.EnumEleD().SetValuesD("肥大", Sta.GameData.体重);
		obj.EnumEleD().SetValuesD("身長", Sta.GameData.身長);
		obj.EnumEleD().SetValuesD("鋭爪", 0.0);
		obj.肌_接続.GetEleD<腰肌D>().陰毛_表示 = true;
		obj.AdjustScale(頭D2);
		return new ChaD(obj, new 体色(b0: true)
		{
			目左 = Sta.GameData.色.瞳色,
			目右 = Sta.GameData.色.瞳色,
			縦目 = Sta.GameData.色.瞳色,
			頬目左 = Sta.GameData.色.瞳色,
			頬目右 = Sta.GameData.色.瞳色,
			髪 = Sta.GameData.色.髪色,
			眉 = Sta.GameData.色.髪色,
			毛0 = Sta.GameData.色.髪色,
			睫 = Sta.GameData.色.髪色,
			人肌 = Sta.GameData.色.肌色,
			爪 = Color.PapayaWhip
		});
	}
}
