using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class ぶっかけ_小D : EleD
    {
    	public bool 精液_表示 = true;

    	public ぶっかけ_小D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, Med Med, 主人公配色 体配色)
    	{
    		return new ぶっかけ_小(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
