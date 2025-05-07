using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 肩D : EleD
    {
    	public bool 脇_脇_表示 = true;

    	public bool 脇_筋肉_表示;

    	public bool 肩_表示 = true;

    	public bool 肩_虫性_甲殻1_表示;

    	public bool 肩_虫性_甲殻2_表示;

    	public bool 肩_傷I1_表示;

    	public bool 肩_傷I2_表示;

    	public bool 肩_傷I3_表示;

    	public bool 肩_傷I4_表示;

    	public bool 肩_シャツ_表示;

    	public bool 肩_ナース_表示;

    	public List<EleD> 上腕_接続 = new List<EleD>();

    	public 肩D()
    	{
    		ThisType = GetType();
    	}

    	public void 上腕接続(EleD e)
    	{
    		上腕_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.肩_上腕_接続;
    	}

    	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
    	{
    		return new 肩(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
