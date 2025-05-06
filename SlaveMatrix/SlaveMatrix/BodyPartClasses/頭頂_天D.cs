using System;
using _2DGAMELIB;

namespace SlaveMatrix;

[Serializable]
public class 頭頂_天D : 頭頂D
{
	public bool 天輪上_表示 = true;

	public bool 天輪下_表示 = true;

	public 頭頂_天D()
	{
		ThisType = GetType();
	}

	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
	{
		return new 頭頂_天(DisUnit, 配色指定, 体配色, Med, this);
	}
}
