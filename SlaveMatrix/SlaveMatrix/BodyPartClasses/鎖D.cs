using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 鎖D : EleD
    {
    	public bool 鎖2_表示 = true;

    	public bool 鎖1_表示 = true;

    	public 鎖D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
    	{
    		return new 鎖(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
