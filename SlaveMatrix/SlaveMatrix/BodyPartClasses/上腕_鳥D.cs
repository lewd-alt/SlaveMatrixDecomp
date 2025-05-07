using System;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 上腕_鳥D : 翼上腕D
    {
    	public bool 風切羽_羽3_表示 = true;

    	public bool 風切羽_羽2_表示 = true;

    	public bool 風切羽_羽1_表示 = true;

    	public bool 羽毛_表示 = true;

    	public bool 鳥翼上腕_表示 = true;

    	public bool 小雨覆_表示 = true;

    	public bool 竜性_鱗1_表示;

    	public bool 竜性_鱗2_表示;

    	public bool 竜性_鱗3_表示;

    	public bool 竜性_鱗4_表示;

    	public double 展開;

    	public double シャープ;

    	public bool 上腕_外線;

    	public bool 小雨覆_外線;

    	public bool 羽毛_外線;

    	public bool 風切羽_羽1_外線;

    	public bool 風切羽_羽2_外線;

    	public bool 風切羽_羽3_外線;

    	public 上腕_鳥D()
    	{
    		ThisType = GetType();
    	}

    	public override void 下腕接続(EleD e)
    	{
    		下腕_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.上腕_鳥_下腕_接続;
    	}

    	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
    	{
    		return new 上腕_鳥(DisUnit, 配色指定, 体配色, Med, this);
    	}
    }
}
