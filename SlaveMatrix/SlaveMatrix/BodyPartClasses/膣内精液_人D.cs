using System;
using _2DGAMELIB;

namespace SlaveMatrix;

[Serializable]
public class 膣内精液_人D : 膣内精液D
{
	public bool 精液_表示 = true;

	public bool 血液1_表示;

	public bool 血液2_表示;

	public 膣内精液_人D()
	{
		ThisType = GetType();
	}

	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
	{
		return new 膣内精液_人(DisUnit, 配色指定, 体配色, Med, this);
	}
}
