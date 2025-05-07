using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class マウスD : EleD
    {
    	public bool 上唇_表示 = true;

    	public bool 下唇_表示 = true;

    	public bool 舌_表示 = true;

    	public マウスD()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, Med Med, 主人公配色 体配色)
    	{
    		return new マウス(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
