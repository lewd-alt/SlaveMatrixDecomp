using System;
using _2DGAMELIB;

namespace SlaveMatrix;

[Serializable]
public class 触肢_肢蜘D : 触肢D
{
	public bool 基節_表示 = true;

	public bool 転節_表示 = true;

	public bool 腿節_表示 = true;

	public bool 膝節_表示 = true;

	public bool 脛節_表示 = true;

	public bool 輪_革_表示 = true;

	public bool 輪_金具1_表示 = true;

	public bool 輪_金具2_表示 = true;

	public bool 輪_金具3_表示 = true;

	public bool 輪_金具左_表示 = true;

	public bool 輪_金具右_表示 = true;

	public bool 蹠節_表示 = true;

	public bool 輪表示 = true;

	public bool 鎖表示;

	public 触肢_肢蜘D()
	{
		ThisType = GetType();
	}

	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
	{
		return new 触肢_肢蜘(DisUnit, 配色指定, 体配色, Med, this);
	}
}
