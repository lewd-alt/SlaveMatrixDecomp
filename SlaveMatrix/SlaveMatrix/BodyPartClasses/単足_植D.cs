using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    [Serializable]
    public class 単足_植D : 半身D
    {
    	public bool 幹上_表示 = true;

    	public bool 幹下_表示 = true;

    	public bool 葉左_表示 = true;

    	public bool 葉右_表示 = true;

    	public bool 脈上1_表示 = true;

    	public bool 脈上2_表示 = true;

    	public bool 脈下1_表示 = true;

    	public bool 脈下2_表示 = true;

    	public bool 虫食_左_虫食1_表示;

    	public bool 虫食_左_虫食2_表示;

    	public bool 虫食_左_虫食3_表示;

    	public bool 虫食_左_虫食4_表示;

    	public bool 虫食_左_虫食5_表示;

    	public bool 虫食_左_虫食6_表示;

    	public bool 虫食_左_虫食7_表示;

    	public bool 虫食_左_虫食8_表示;

    	public bool 虫食_左_虫食9_表示;

    	public bool 虫食_左_虫食10_表示;

    	public bool 虫食_左_虫食11_表示;

    	public bool 虫食_左_虫食12_表示;

    	public bool 虫食_右_虫食1_表示;

    	public bool 虫食_右_虫食2_表示;

    	public bool 虫食_右_虫食3_表示;

    	public bool 虫食_右_虫食4_表示;

    	public bool 虫食_右_虫食5_表示;

    	public bool 虫食_右_虫食6_表示;

    	public bool 虫食_右_虫食7_表示;

    	public bool 虫食_右_虫食8_表示;

    	public bool 虫食_右_虫食9_表示;

    	public bool 虫食_右_虫食10_表示;

    	public bool 虫食_右_虫食11_表示;

    	public bool 虫食_右_虫食12_表示;

    	public bool 脚輪_革_表示 = true;

    	public bool 脚輪_金具1_表示 = true;

    	public bool 脚輪_金具2_表示 = true;

    	public bool 脚輪_金具3_表示 = true;

    	public bool 脚輪_金具左_表示 = true;

    	public bool 脚輪_金具右_表示 = true;

    	public bool 脚輪表示 = true;

    	public bool 鎖表示;

    	public List<EleD> 根外左_接続 = new List<EleD>();

    	public List<EleD> 根内左_接続 = new List<EleD>();

    	public List<EleD> 根中央_接続 = new List<EleD>();

    	public List<EleD> 根内右_接続 = new List<EleD>();

    	public List<EleD> 根外右_接続 = new List<EleD>();

    	public 単足_植D()
    	{
    		ThisType = GetType();
    	}

    	public void 根外左接続(EleD e)
    	{
    		根外左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.単足_植_根外左_接続;
    	}

    	public void 根内左接続(EleD e)
    	{
    		根内左_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.単足_植_根内左_接続;
    	}

    	public void 根中央接続(EleD e)
    	{
    		根中央_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.単足_植_根中央_接続;
    	}

    	public void 根内右接続(EleD e)
    	{
    		根内右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.単足_植_根内右_接続;
    	}

    	public void 根外右接続(EleD e)
    	{
    		根外右_接続.Add(e);
    		e.Par = this;
    		e.接続情報 = ConnectionInfo.単足_植_根外右_接続;
    	}

    	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
    	{
    		return new 単足_植(DisUnit, 配色指定, 体配色, Med, this);
    	}

    	public override IEnumerable<EleD> EnumEleD()
    	{
    		yield return this;
    		if (根外左_接続 != null)
    		{
    			foreach (EleD item in 根外左_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item;
    			}
    		}
    		if (根外右_接続 != null)
    		{
    			foreach (EleD item2 in 根外右_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item2;
    			}
    		}
    		if (根内左_接続 != null)
    		{
    			foreach (EleD item3 in 根内左_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item3;
    			}
    		}
    		if (根内右_接続 != null)
    		{
    			foreach (EleD item4 in 根内右_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    			{
    				yield return item4;
    			}
    		}
    		if (根中央_接続 == null)
    		{
    			yield break;
    		}
    		foreach (EleD item5 in 根中央_接続.Select((EleD e) => e.EnumEleD()).JoinEnum())
    		{
    			yield return item5;
    		}
    	}
    }
}
