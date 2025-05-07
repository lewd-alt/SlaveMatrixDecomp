using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public struct ドレス色
    {
    	public Color 生地;

    	public Color 柄;

    	public Color 縁;

    	public Color 紐;

    	public Color2 生地色;

    	public Color2 柄色;

    	public Color2 縁色;

    	public Color2 紐色;

    	public void SetDefault()
    	{
    		Col.Add(ref Col.DarkGreen, 0, 0, -50, out 生地);
    		柄 = Color.Gold;
    		縁 = Color.Gold;
    		紐 = Col.Black;
    		SetColor2();
    	}

    	public void SetRandom()
    	{
    		Col.GetRandomClothesColor(out 生地);
    		Col.GetRandomClothesColor(out 柄);
    		縁 = 柄;
    		Col.GetRandomClothesColor(out 紐);
    		SetColor2();
    	}

    	public void SetColor2()
    	{
    		Col.GetGrad(ref 生地, out 生地色);
    		Col.GetGrad(ref 柄, out 柄色);
    		Col.GetGrad(ref 縁, out 縁色);
    		Col.GetGrad(ref 紐, out 紐色);
    	}
    }
}
