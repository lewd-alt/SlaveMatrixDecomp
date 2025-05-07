using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 頭頂後_宇D : EleD
    {
    	public bool 頭部_表示 = true;

    	public bool 線_線左1_表示 = true;

    	public bool 線_線左2_表示 = true;

    	public bool 線_線左3_表示 = true;

    	public bool 線_線右1_表示 = true;

    	public bool 線_線右2_表示 = true;

    	public bool 線_線右3_表示 = true;

    	public 頭頂後_宇D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
    	{
    		return new 頭頂後_宇(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
