using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix;

[Serializable]
public class 多足_蛸D : 半身D
{
	public bool 胴_表示 = true;

	public List<EleD> 軟体外左_接続 = new List<EleD>();

	public List<EleD> 軟体外右_接続 = new List<EleD>();

	public List<EleD> 軟体内左_接続 = new List<EleD>();

	public List<EleD> 軟体内右_接続 = new List<EleD>();

	public 多足_蛸D()
	{
		ThisType = GetType();
	}

	public void 軟体外左接続(EleD e)
	{
		軟体外左_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.多足_蛸_軟体外左_接続;
		foreach (EleD item in e.EnumEleD())
		{
			item.尺度B = 1.0;
		}
	}

	public void 軟体外右接続(EleD e)
	{
		軟体外右_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.多足_蛸_軟体外右_接続;
		foreach (EleD item in e.EnumEleD())
		{
			item.尺度B = 1.0;
		}
	}

	public void 軟体内左接続(EleD e)
	{
		軟体内左_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.多足_蛸_軟体内左_接続;
		foreach (EleD item in e.EnumEleD())
		{
			item.尺度B = 1.0;
		}
	}

	public void 軟体内右接続(EleD e)
	{
		軟体内右_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.多足_蛸_軟体内右_接続;
		foreach (EleD item in e.EnumEleD())
		{
			item.尺度B = 1.0;
		}
	}

	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
	{
		return new 多足_蛸(DisUnit, 配色指定, 体配色, Med, this);
	}
}
