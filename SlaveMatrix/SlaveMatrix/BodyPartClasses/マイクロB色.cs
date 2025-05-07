using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public struct マイクロB色
    {
    	public Color 生地;

    	public Color 留;

    	public Color 縁;

    	public Color 紐;

    	public Color2 生地色;

    	public Color2 留色;

    	public Color2 縁色;

    	public Color2 紐色;

    	public void SetDefault()
    	{
    		生地 = Color.DarkRed;
    		留 = Color.Gold;
    		縁 = Col.White;
    		紐 = Col.White;
    		SetColor2();
    	}

    	public void SetRandom()
    	{
    		Col.GetRandomClothesColor(out 生地);
    		Col.GetRandomClothesColor(out 留);
    		Col.GetRandomClothesColor(out 縁);
    		紐 = 縁;
    		SetColor2();
    	}

    	public void SetColor2()
    	{
    		Col.GetGrad(ref 生地, out 生地色);
    		Col.GetGrad(ref 留, out 留色);
    		Col.GetGrad(ref 縁, out 縁色);
    		Col.GetGrad(ref 紐, out 紐色);
    	}

    	public void Setヴィオラ()
    	{
    		Col.Add(ref Col.DarkGreen, 0, 0, -50, out 生地);
    		留 = Color.Gold;
    		縁 = Color.Gold;
    		紐 = Col.Black;
    		Col.GetGrad(ref 生地, out 生地色);
    		Col.GetGrad(ref 留, out 留色);
    		Col.GetGrad(ref 縁, out 縁色);
    		Col.GetGrad(ref 紐, out 紐色);
    	}
    }
}
