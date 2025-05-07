using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 後髪1_結1ハネD : アップD
    {
    	public bool 髪基_表示 = true;

    	public bool お下げ_髪根_表示 = true;

    	public bool お下げ_髪左1_表示 = true;

    	public bool お下げ_髪左2_表示 = true;

    	public bool お下げ_髪左3_表示 = true;

    	public bool お下げ_髪右1_表示 = true;

    	public bool お下げ_髪右2_表示 = true;

    	public bool お下げ_髪右3_表示 = true;

    	public double 髪長;

    	public double 毛量;

    	public double 広がり;

    	public double 高さ;

    	public 後髪1_結1ハネD()
    	{
    		ThisType = GetType();
    	}

    	public 後髪1_結1ハネD SetRandom()
    	{
    		髪長 = RNG.XS.NextDouble();
    		毛量 = RNG.XS.NextDouble();
    		広がり = RNG.XS.NextDouble();
    		高さ = RNG.XS.NextDouble();
    		return this;
    	}

    	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
    	{
    		return new 後髪1_結1ハネ(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
