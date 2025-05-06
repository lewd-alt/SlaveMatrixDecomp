using System;
using _2DGAMELIB;

namespace SlaveMatrix;

[Serializable]
public class 目傷D : EleD
{
	public bool 傷上_表示;

	public bool 傷下_表示;

	public 目傷D()
	{
		ThisType = GetType();
	}

	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
	{
		return new 目傷(DisUnit, 配色指定, 体配色, Med, this);
	}
}
