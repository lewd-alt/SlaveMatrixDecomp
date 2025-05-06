using System;
using _2DGAMELIB;

namespace SlaveMatrix;

[Serializable]
public class 顔ハイライトD : EleD
{
	public bool ハイライト1_表示;

	public bool ハイライト2_表示;

	public 顔ハイライトD()
	{
		ThisType = GetType();
	}

	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
	{
		return new 顔ハイライト(DisUnit, 配色指定, 体配色, Med, this);
	}
}
