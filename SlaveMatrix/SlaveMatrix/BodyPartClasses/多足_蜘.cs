using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 多足_蜘 : 半身
    {
    	public Par X0Y0_胴;

    	public Par X0Y0_胸版;

    	public Par X0Y0_柄;

    	public ColorD 胴CD;

    	public ColorD 胸版CD;

    	public ColorD 柄CD;

    	public ColorP X0Y0_胴CP;

    	public ColorP X0Y0_胸版CP;

    	public ColorP X0Y0_柄CP;

    	public Ele[] 触肢左_接続;

    	public Ele[] 触肢右_接続;

    	public Ele[] 節足左1_接続;

    	public Ele[] 節足左2_接続;

    	public Ele[] 節足左3_接続;

    	public Ele[] 節足左4_接続;

    	public Ele[] 節足右1_接続;

    	public Ele[] 節足右2_接続;

    	public Ele[] 節足右3_接続;

    	public Ele[] 節足右4_接続;

    	public Ele[] 尾_接続;

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

    	public bool 胴_表示
    	{
    		get
    		{
    			return X0Y0_胴.Dra;
    		}
    		set
    		{
    			X0Y0_胴.Dra = value;
    			X0Y0_胴.Hit = value;
    		}
    	}

    	public bool 胸版_表示
    	{
    		get
    		{
    			return X0Y0_胸版.Dra;
    		}
    		set
    		{
    			X0Y0_胸版.Dra = value;
    			X0Y0_胸版.Hit = value;
    		}
    	}

    	public bool 柄_表示
    	{
    		get
    		{
    			return X0Y0_柄.Dra;
    		}
    		set
    		{
    			X0Y0_柄.Dra = value;
    			X0Y0_柄.Hit = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 胴_表示;
    		}
    		set
    		{
    			胴_表示 = value;
    			胸版_表示 = value;
    			柄_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 胴CD.不透明度;
    		}
    		set
    		{
    			胴CD.不透明度 = value;
    			胸版CD.不透明度 = value;
    			柄CD.不透明度 = value;
    		}
    	}

    	public JointS 触肢左_接続点 => new JointS(本体, X0Y0_胴, 10);

    	public JointS 触肢右_接続点 => new JointS(本体, X0Y0_胴, 11);

    	public JointS 節足左1_接続点 => new JointS(本体, X0Y0_胴, 2);

    	public JointS 節足左2_接続点 => new JointS(本体, X0Y0_胴, 4);

    	public JointS 節足左3_接続点 => new JointS(本体, X0Y0_胴, 6);

    	public JointS 節足左4_接続点 => new JointS(本体, X0Y0_胴, 8);

    	public JointS 節足右1_接続点 => new JointS(本体, X0Y0_胴, 3);

    	public JointS 節足右2_接続点 => new JointS(本体, X0Y0_胴, 5);

    	public JointS 節足右3_接続点 => new JointS(本体, X0Y0_胴, 7);

    	public JointS 節足右4_接続点 => new JointS(本体, X0Y0_胴, 9);

    	public JointS 尾_接続点 => new JointS(本体, X0Y0_胴, 0);

    	public 多足_蜘(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 多足_蜘D e)
    	{
    		多足_蜘 多足_蜘2 = this;
    		ThisType = GetType();
    		Dif dif = new Dif();
    		dif.Tag = "蜘";
    		dif.Add(new Pars(Sta.半身["多足"][0][1]));
    		本体 = new Difs();
    		本体.Tag = dif.Tag;
    		本体.Add(dif);
    		Pars pars = 本体[0][0];
    		X0Y0_胴 = pars["胴"].ToPar();
    		X0Y0_胸版 = pars["胸版"].ToPar();
    		X0Y0_柄 = pars["柄"].ToPar();
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
    		胴_表示 = e.胴_表示;
    		胸版_表示 = e.胸版_表示;
    		柄_表示 = e.柄_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Ele f;
    		if (e.触肢左_接続.Count > 0)
    		{
    			触肢左_接続 = e.触肢左_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蜘2;
    				f.ConnectionType = ConnectionInfo.多足_蜘_触肢左_接続;
    				f.接続(多足_蜘2.触肢左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.触肢右_接続.Count > 0)
    		{
    			触肢右_接続 = e.触肢右_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蜘2;
    				f.ConnectionType = ConnectionInfo.多足_蜘_触肢右_接続;
    				f.接続(多足_蜘2.触肢右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.節足左1_接続.Count > 0)
    		{
    			節足左1_接続 = e.節足左1_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蜘2;
    				f.ConnectionType = ConnectionInfo.多足_蜘_節足左1_接続;
    				f.接続(多足_蜘2.節足左1_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.節足左2_接続.Count > 0)
    		{
    			節足左2_接続 = e.節足左2_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蜘2;
    				f.ConnectionType = ConnectionInfo.多足_蜘_節足左2_接続;
    				f.接続(多足_蜘2.節足左2_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.節足左3_接続.Count > 0)
    		{
    			節足左3_接続 = e.節足左3_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蜘2;
    				f.ConnectionType = ConnectionInfo.多足_蜘_節足左3_接続;
    				f.接続(多足_蜘2.節足左3_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.節足左4_接続.Count > 0)
    		{
    			節足左4_接続 = e.節足左4_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蜘2;
    				f.ConnectionType = ConnectionInfo.多足_蜘_節足左4_接続;
    				f.接続(多足_蜘2.節足左4_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.節足右1_接続.Count > 0)
    		{
    			節足右1_接続 = e.節足右1_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蜘2;
    				f.ConnectionType = ConnectionInfo.多足_蜘_節足右1_接続;
    				f.接続(多足_蜘2.節足右1_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.節足右2_接続.Count > 0)
    		{
    			節足右2_接続 = e.節足右2_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蜘2;
    				f.ConnectionType = ConnectionInfo.多足_蜘_節足右2_接続;
    				f.接続(多足_蜘2.節足右2_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.節足右3_接続.Count > 0)
    		{
    			節足右3_接続 = e.節足右3_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蜘2;
    				f.ConnectionType = ConnectionInfo.多足_蜘_節足右3_接続;
    				f.接続(多足_蜘2.節足右3_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.節足右4_接続.Count > 0)
    		{
    			節足右4_接続 = e.節足右4_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蜘2;
    				f.ConnectionType = ConnectionInfo.多足_蜘_節足右4_接続;
    				f.接続(多足_蜘2.節足右4_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.尾_接続.Count > 0)
    		{
    			尾_接続 = e.尾_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 多足_蜘2;
    				f.ConnectionType = ConnectionInfo.多足_蜘_尾_接続;
    				f.接続(多足_蜘2.尾_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_胴CP = new ColorP(X0Y0_胴, 胴CD, DisUnit, abj: true);
    		X0Y0_胸版CP = new ColorP(X0Y0_胸版, 胸版CD, DisUnit, abj: true);
    		X0Y0_柄CP = new ColorP(X0Y0_柄, 柄CD, DisUnit, abj: true);
    		濃度 = e.濃度;
    	}

    	public override void 色更新()
    	{
    		X0Y0_胴CP.Update();
    		X0Y0_胸版CP.Update();
    		X0Y0_柄CP.Update();
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
    		胴CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		胸版CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    	}

    	private void 配色T0(体配色 体配色)
    	{
    		胴CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		胸版CD = new ColorD(ref Col.Black, ref 体配色.甲1O);
    		柄CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    	}

    	private void 配色T1(体配色 体配色)
    	{
    		胴CD = new ColorD(ref Col.Black, ref 体配色.甲0O);
    		胸版CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		柄CD = new ColorD(ref Col.Black, ref 体配色.体0O);
    	}

    	public override IEnumerable<Ele> EnumEle()
    	{
    		yield return this;
    		if (尾_接続 != null)
    		{
    			foreach (Ele item in 尾_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item;
    			}
    		}
    		if (節足左4_接続 != null)
    		{
    			foreach (Ele item2 in 節足左4_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item2;
    			}
    		}
    		if (節足右4_接続 != null)
    		{
    			foreach (Ele item3 in 節足右4_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item3;
    			}
    		}
    		if (節足左3_接続 != null)
    		{
    			foreach (Ele item4 in 節足左3_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item4;
    			}
    		}
    		if (節足右3_接続 != null)
    		{
    			foreach (Ele item5 in 節足右3_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item5;
    			}
    		}
    		if (節足左2_接続 != null)
    		{
    			foreach (Ele item6 in 節足左2_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item6;
    			}
    		}
    		if (節足右2_接続 != null)
    		{
    			foreach (Ele item7 in 節足右2_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item7;
    			}
    		}
    		if (節足左1_接続 != null)
    		{
    			foreach (Ele item8 in 節足左1_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item8;
    			}
    		}
    		if (節足右1_接続 != null)
    		{
    			foreach (Ele item9 in 節足右1_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item9;
    			}
    		}
    		if (触肢左_接続 != null)
    		{
    			foreach (Ele item10 in 触肢左_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    			{
    				yield return item10;
    			}
    		}
    		if (触肢右_接続 == null)
    		{
    			yield break;
    		}
    		foreach (Ele item11 in 触肢右_接続.Select((Ele e) => e.EnumEle()).JoinEnum())
    		{
    			yield return item11;
    		}
    	}
    }
}
