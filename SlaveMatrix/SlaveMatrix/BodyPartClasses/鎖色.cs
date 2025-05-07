using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public struct 鎖色
    {
    	public Color 金属;

    	public Color2 金属色;

    	public void SetDefault()
    	{
    		金属 = Color.Gray;
    		SetColor2();
    	}

    	public void SetRandom()
    	{
    		Col.GetRandomClothesColor(out 金属);
    		SetColor2();
    	}

    	public void SetColor2()
    	{
    		Col.GetMetal(ref 金属, out 金属色);
    	}
    }
}
