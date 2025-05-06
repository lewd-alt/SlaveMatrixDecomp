using System;
using System.Collections.Generic;

namespace SlaveMatrix;

[Serializable]
public class 吹出しD : EleD
{
	public bool 吹出し_表示;

	public List<EleD> 吹出し_接続 = new List<EleD>();

	public 吹出しD()
	{
		ThisType = GetType();
	}

	public void 吹出し接続(EleD e)
	{
		吹出し_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.吹出し_吹出し_接続;
	}
}
