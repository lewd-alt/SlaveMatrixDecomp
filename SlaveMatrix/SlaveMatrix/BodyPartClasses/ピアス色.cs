using System;
using System.Drawing;

namespace SlaveMatrix;

[Serializable]
public struct ピアス色
{
	public Color ピアス;

	public Color2 金具色;

	public void SetDefault()
	{
		ピアス = Color.Gold;
		SetColor2();
	}

	public void SetRandom()
	{
		Col.GetRandomClothesColor(out ピアス);
		SetColor2();
	}

	public void SetColor2()
	{
		Col.GetGrad(ref ピアス, out 金具色);
	}
}
