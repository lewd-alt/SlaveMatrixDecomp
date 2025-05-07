using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 後髪0_下1カルD : お下げ1D
    {
    	public bool 髪基_表示 = true;

    	public bool お下げ_髪節_表示 = true;

    	public bool お下げ_髪縛1_表示 = true;

    	public bool お下げ_髪縛2_表示 = true;

    	public bool お下げ_髪右2_表示 = true;

    	public bool お下げ_髪右1_表示 = true;

    	public bool お下げ_髪左2_表示 = true;

    	public bool お下げ_髪左1_表示 = true;

    	public bool お下げ_髪根_表示 = true;

    	public double 髪長0;

    	public double 髪長1;

    	public double 毛量;

    	public double 広がり;

    	public bool スライム;

    	public 後髪0_下1カルD()
    	{
    		ThisType = GetType();
    	}

    	public 後髪0_下1カルD SetRandom()
    	{
    		髪長0 = RNG.XS.NextDouble();
    		髪長1 = RNG.XS.NextDouble();
    		毛量 = RNG.XS.NextDouble();
    		広がり = RNG.XS.NextDouble();
    		右 = RNG.XS.NextBool();
    		return this;
    	}

    	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
    	{
    		return new 後髪0_下1カル(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
