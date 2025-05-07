using System;
using System.Drawing;

namespace SlaveMatrix
{
    [Serializable]
    public struct ノーマルB色
    {
    	public Color 生地;

    	public Color リボン;

    	public Color 柄;

    	public Color 縁;

    	public Color 紐;

    	public Color2 生地色;

    	public Color2 リボン色;

    	public Color2 柄色;

    	public Color2 縁色;

    	public Color2 紐色;

    	public void SetDefault()
    	{
    		生地 = Color.DarkRed;
    		リボン = Col.Black;
    		柄 = Col.Black;
    		縁 = Color.DarkRed;
    		紐 = Col.Black;
    		SetColor2();
    	}

    	public void SetRandom()
    	{
    		Col.GetRandomClothesColor(out 生地);
    		Col.GetRandomClothesColor(out リボン);
    		柄 = リボン;
    		縁 = 生地;
    		紐 = リボン;
    		SetColor2();
    	}

    	public void SetColor2()
    	{
    		Col.GetGrad(ref 生地, out 生地色);
    		Col.GetGrad(ref リボン, out リボン色);
    		Col.GetGrad(ref 柄, out 柄色);
    		Col.GetGrad(ref 縁, out 縁色);
    		Col.GetGrad(ref 紐, out 紐色);
    	}

    	public void Setビキニ()
    	{
    		生地 = Color.DarkRed;
    		リボン = Col.White;
    		柄 = Col.White;
    		縁 = Col.White;
    		紐 = Col.White;
    		Col.GetGrad(ref 生地, out 生地色);
    		Col.GetGrad(ref リボン, out リボン色);
    		Col.GetGrad(ref 柄, out 柄色);
    		Col.GetGrad(ref 縁, out 縁色);
    		Col.GetGrad(ref 紐, out 紐色);
    	}
    }
}
