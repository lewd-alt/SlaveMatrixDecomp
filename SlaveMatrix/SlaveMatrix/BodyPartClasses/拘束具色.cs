using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public struct 拘束具色
    {
    	public Color 革部;

    	public Color 金具;

    	public Color2 革部色;

    	public Color2 金具色;

    	public void SetDefault()
    	{
    		革部 = Col.Black;
    		金具 = Color.Gray;
    		SetColor2();
    	}

    	public void SetRandom()
    	{
    		Col.GetRandomClothesColor(out 革部);
    		Col.GetRandomClothesColor(out 金具);
    		SetColor2();
    	}

    	public void SetColor2()
    	{
    		Col.GetGrad(ref 革部, out 革部色);
    		Col.GetMetal(ref 金具, out 金具色);
    	}
    }
}
