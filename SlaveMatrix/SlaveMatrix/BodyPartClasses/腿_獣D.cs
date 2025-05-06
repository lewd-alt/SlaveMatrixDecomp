using System;
using _2DGAMELIB;

namespace SlaveMatrix;

[Serializable]
public class 腿_獣D : 獣腿D
{
	public bool 腿_表示 = true;

	public bool 筋_表示;

	public bool 虎柄_虎1_表示;

	public bool 虎柄_虎2_表示;

	public 腿_獣D()
	{
		ThisType = GetType();
	}

	public override void 脚接続(EleD e)
	{
		脚_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.腿_獣_脚_接続;
	}

	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
	{
		return new 腿_獣(DisUnit, 配色指定, 体配色, Med, this);
	}
}
