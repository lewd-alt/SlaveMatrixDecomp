using System;
using _2DGAMELIB;

namespace SlaveMatrix;

[Serializable]
public class 脚_獣D : 獣脚D
{
	public bool 脚_表示 = true;

	public bool 筋_表示;

	public bool 脚輪_革_表示;

	public bool 脚輪_金具1_表示;

	public bool 脚輪_金具2_表示;

	public bool 脚輪_金具3_表示;

	public bool 脚輪_金具左_表示;

	public bool 脚輪_金具右_表示;

	public bool 脚輪表示;

	public bool 鎖表示;

	public 脚_獣D()
	{
		ThisType = GetType();
	}

	public override void 足接続(EleD e)
	{
		足_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.脚_獣_足_接続;
	}

	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
	{
		return new 脚_獣(DisUnit, 配色指定, 体配色, Med, this);
	}
}
