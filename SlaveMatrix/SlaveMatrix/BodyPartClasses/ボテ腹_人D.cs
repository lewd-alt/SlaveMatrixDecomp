using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class ボテ腹_人D : ボテ腹D
    {
    	public bool 腹_表示;

    	public bool ハイライト_表示;

    	public bool 臍_表示;

    	public bool ハイライト左1_表示;

    	public bool ハイライト左2_表示;

    	public bool ハイライト右1_表示;

    	public bool ハイライト右2_表示;

    	public bool ハイライト表示;

    	public double ハイライト濃度 = 1.0;

    	public List<EleD> 腹板_接続 = new List<EleD>();

    	public ボテ腹_人D()
    	{
    		ThisType = GetType();
    	}

    	public void 腹板接続(EleD e)
    	{
    		腹板_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.ボテ腹_人_腹板_接続;
    	}

    	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
    	{
    		return new ボテ腹_人(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
