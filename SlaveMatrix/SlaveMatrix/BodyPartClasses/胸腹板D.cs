using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 胸腹板D : EleD
    {
    	public bool 虫性_腹板_表示;

    	public bool 虫性_縦線_表示;

    	public 胸腹板D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
    	{
    		return new 胸腹板(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
