using System;
using System.Collections.Generic;

namespace SlaveMatrix
{
    [Serializable]
    public class 鼻D : EleD
    {
    	public List<EleD> 鼻水左_接続 = new List<EleD>();

    	public List<EleD> 鼻水右_接続 = new List<EleD>();

    	public virtual void 鼻水左接続(EleD e)
    	{
    	}

    	public virtual void 鼻水右接続(EleD e)
    	{
    	}
    }
}
