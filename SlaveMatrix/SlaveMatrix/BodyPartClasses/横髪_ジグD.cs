using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 横髪_ジグD : 横髪D
    {
    	public bool 髪1_表示 = true;

    	public bool 髪2_表示 = true;

    	public double 髪長1;

    	public double 髪長2;

    	public double 毛量;

    	public double 広がり;

    	public 横髪_ジグD()
    	{
    		ThisType = GetType();
    	}

    	public 横髪_ジグD SetRandom()
    	{
    		髪長1 = RNG.XS.NextDouble();
    		髪長2 = RNG.XS.NextDouble();
    		毛量 = RNG.XS.NextDouble();
    		広がり = RNG.XS.NextDouble();
    		髪長1 = 1.0;
    		髪長2 = 1.0;
    		return this;
    	}

    	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
    	{
    		return new 横髪_ジグ(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
