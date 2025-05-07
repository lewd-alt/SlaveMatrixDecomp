using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 尾_虫D : 尾D
    {
    	public bool 尾10_表示 = true;

    	public bool 針_表示 = true;

    	public bool 輪2_革_表示 = true;

    	public bool 輪2_金具1_表示 = true;

    	public bool 輪2_金具2_表示 = true;

    	public bool 輪2_金具3_表示 = true;

    	public bool 輪2_金具左_表示 = true;

    	public bool 輪2_金具右_表示 = true;

    	public bool 尾9_表示 = true;

    	public bool 尾8_表示 = true;

    	public bool 尾7_表示 = true;

    	public bool 尾6_表示 = true;

    	public bool 尾5_表示 = true;

    	public bool 輪1_革_表示 = true;

    	public bool 輪1_金具1_表示 = true;

    	public bool 輪1_金具2_表示 = true;

    	public bool 輪1_金具3_表示 = true;

    	public bool 輪1_金具左_表示 = true;

    	public bool 輪1_金具右_表示 = true;

    	public bool 尾4_表示 = true;

    	public bool 尾3_表示 = true;

    	public bool 尾2_表示 = true;

    	public bool 尾1_表示 = true;

    	public bool 尾0_表示 = true;

    	public bool 輪1表示 = true;

    	public bool 輪2表示 = true;

    	public bool 鎖表示;

    	public 尾_虫D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
    	{
    		return new 尾_虫(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
