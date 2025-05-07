using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 横髪_肢系D : 横髪D
    {
    	public bool 髪_表示 = true;

    	public List<EleD> 肢_接続 = new List<EleD>();

    	public 横髪_肢系D()
    	{
    		ThisType = GetType();
    	}

    	public void 肢接続(EleD e)
    	{
    		肢_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.横髪_肢系_肢_接続;
    	}

    	public EleD SetRandom()
    	{
    		return this;
    	}

    	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
    	{
    		return new 横髪_肢系(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
