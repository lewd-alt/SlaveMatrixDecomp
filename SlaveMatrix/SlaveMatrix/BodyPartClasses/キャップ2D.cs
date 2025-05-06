using System;
using _2DGAMELIB;

namespace SlaveMatrix;

[Serializable]
public class キャップ2D : EleD
{
	public bool 根本_表示;

	public bool 先端_表示;

	public キャップ2D()
	{
		ThisType = GetType();
	}

	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
	{
		return new キャップ2(DisUnit, 配色指定, 体配色, Med, this);
	}
}
