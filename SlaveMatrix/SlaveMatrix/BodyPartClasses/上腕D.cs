using System;
using System.Collections.Generic;

namespace SlaveMatrix;

[Serializable]
public class 上腕D : EleD
{
	public List<EleD> 下腕_接続 = new List<EleD>();

	public virtual void 下腕接続(EleD e)
	{
	}
}
