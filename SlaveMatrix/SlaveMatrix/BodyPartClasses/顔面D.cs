using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class 顔面D : EleD
    {
    	public double 展開0;

    	public List<EleD> 触覚左_接続 = new List<EleD>();

    	public List<EleD> 触覚右_接続 = new List<EleD>();

    	public virtual void 触覚左接続(EleD e)
    	{
    	}

    	public virtual void 触覚右接続(EleD e)
    	{
    	}
    }
}
