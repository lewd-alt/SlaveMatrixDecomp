using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 角2_山3D : 角2D
    {
    	public bool 根_根_表示 = true;

    	public bool 根_凸1_表示 = true;

    	public bool 根_凸2_表示 = true;

    	public bool 根_凸3_表示 = true;

    	public bool 根_凸4_表示 = true;

    	public bool 根_凸5_表示 = true;

    	public bool 根_凸6_表示 = true;

    	public bool 根_凸7_表示 = true;

    	public bool 根_凸8_表示 = true;

    	public bool 根_凸9_表示 = true;

    	public bool 根_凸10_表示 = true;

    	public bool 先_先_表示 = true;

    	public bool 先_凸1_表示 = true;

    	public bool 先_凸2_表示 = true;

    	public bool 先_凸3_表示 = true;

    	public bool 先_凸4_表示 = true;

    	public bool 先_凸5_表示 = true;

    	public bool 先_凸6_表示 = true;

    	public bool 根_折線1_表示 = true;

    	public bool 根_折線2_表示 = true;

    	public 角2_山3D()
    	{
    		ThisType = GetType();
    	}

    	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
    	{
    		return new 角2_山3(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
