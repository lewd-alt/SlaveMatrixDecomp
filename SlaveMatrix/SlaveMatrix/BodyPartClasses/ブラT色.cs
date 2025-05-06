using System;
using System.Drawing;

namespace SlaveMatrix;

[Serializable]
public struct ブラT色
{
	public Color 生地1;

	public Color 生地2;

	public Color リボン;

	public Color レース;

	public Color 柄;

	public Color 縁;

	public Color 紐;

	public Color ジャスター;

	public Color2 生地1色;

	public Color2 生地2色;

	public Color2 リボン色;

	public Color2 レース色;

	public Color2 柄色;

	public Color2 縁色;

	public Color2 紐色;

	public Color2 ジャスター色;

	public void SetDefault()
	{
		生地1 = Color.DarkRed;
		生地2 = Color.DarkRed;
		リボン = Col.Black;
		レース = Col.Black;
		柄 = Col.Black;
		縁 = Color.DarkRed;
		紐 = Col.Black;
		ジャスター = Color.Gold;
		SetColor2();
	}

	public void SetRandom()
	{
		Col.GetRandomClothesColor(out 生地1);
		生地2 = 生地1;
		Col.GetRandomClothesColor(out リボン);
		レース = リボン;
		柄 = リボン;
		縁 = 生地1;
		紐 = リボン;
		Col.GetRandomClothesColor(out ジャスター);
		SetColor2();
	}

	public void SetColor2()
	{
		Col.GetGrad(ref 生地1, out 生地1色);
		Col.GetGrad(ref 生地2, out 生地2色);
		Col.GetGrad(ref リボン, out リボン色);
		Col.GetGrad(ref レース, out レース色);
		Col.GetGrad(ref 柄, out 柄色);
		Col.GetGrad(ref 縁, out 縁色);
		Col.GetGrad(ref 紐, out 紐色);
		Col.GetGrad(ref ジャスター, out ジャスター色);
	}
}
