using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class 下腕D : EleD
    {
    	public List<EleD> 手_接続 = new List<EleD>();

    	public virtual void 手接続(EleD e)
    	{
    	}
    }
}
