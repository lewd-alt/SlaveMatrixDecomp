using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix;

[Serializable]
public class 頭D : EleD
{
	public bool 頭_表示 = true;

	public bool 悪タトゥ_逆十字_逆十字1_表示;

	public bool 悪タトゥ_逆十字_逆十字2_表示;

	public bool 隈取_タトゥ_表示;

	public bool 隈取_タトゥ左_表示;

	public bool 隈取_タトゥ右_表示;

	public bool 秘石_基_表示;

	public bool 秘石_秘石_表示;

	public bool 秘石_ハイライト_表示;

	public bool 蜘蛛_眼左1_基_表示;

	public bool 蜘蛛_眼左1_眼_表示;

	public bool 蜘蛛_眼左1_ハイライト_表示;

	public bool 蜘蛛_眼左2_基_表示;

	public bool 蜘蛛_眼左2_眼_表示;

	public bool 蜘蛛_眼左2_ハイライト_表示;

	public bool 蜘蛛_眼右1_基_表示;

	public bool 蜘蛛_眼右1_眼_表示;

	public bool 蜘蛛_眼右1_ハイライト_表示;

	public bool 蜘蛛_眼右2_基_表示;

	public bool 蜘蛛_眼右2_眼_表示;

	public bool 蜘蛛_眼右2_ハイライト_表示;

	public bool 羽虫_眼中_基_表示;

	public bool 羽虫_眼中_眼_表示;

	public bool 羽虫_眼中_ハイライト_表示;

	public bool 羽虫_眼左_基_表示;

	public bool 羽虫_眼左_眼_表示;

	public bool 羽虫_眼左_ハイライト_表示;

	public bool 羽虫_眼右_基_表示;

	public bool 羽虫_眼右_眼_表示;

	public bool 羽虫_眼右_ハイライト_表示;

	public bool 紋柄_紋_表示;

	public bool 紋柄_紋左1_表示;

	public bool 紋柄_紋右1_表示;

	public bool 紋柄_紋左2_表示;

	public bool 紋柄_紋右2_表示;

	public bool 竜性_鱗1_表示;

	public bool 竜性_鱗2_表示;

	public bool 竜性_鱗3_表示;

	public bool 馬柄_馬柄_表示;

	public bool 虫性_顎下_表示;

	public double 目高;

	public double 目間;

	public double 眉間;

	public List<EleD> 基髪_接続 = new List<EleD>();

	public List<EleD> 目左_接続 = new List<EleD>();

	public List<EleD> 目右_接続 = new List<EleD>();

	public List<EleD> 鼻_接続 = new List<EleD>();

	public List<EleD> 口_接続 = new List<EleD>();

	public List<EleD> 頬左_接続 = new List<EleD>();

	public List<EleD> 頬右_接続 = new List<EleD>();

	public List<EleD> 額_接続 = new List<EleD>();

	public List<EleD> 眉左_接続 = new List<EleD>();

	public List<EleD> 眉右_接続 = new List<EleD>();

	public List<EleD> 耳左_接続 = new List<EleD>();

	public List<EleD> 耳右_接続 = new List<EleD>();

	public List<EleD> 鼻肌_接続 = new List<EleD>();

	public List<EleD> 単眼目_接続 = new List<EleD>();

	public List<EleD> 単眼眉_接続 = new List<EleD>();

	public List<EleD> 大顎基_接続 = new List<EleD>();

	public List<EleD> 顔面_接続 = new List<EleD>();

	public List<EleD> 頭頂_接続 = new List<EleD>();

	public List<EleD> 頬肌左_接続 = new List<EleD>();

	public List<EleD> 頬肌右_接続 = new List<EleD>();

	public List<EleD> 触覚左_接続 = new List<EleD>();

	public List<EleD> 触覚右_接続 = new List<EleD>();

	public 頭D()
	{
		ThisType = GetType();
	}

	public void 基髪接続(EleD e)
	{
		基髪_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_基髪_接続;
	}

	public void 目左接続(EleD e)
	{
		目左_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_目左_接続;
	}

	public void 目右接続(EleD e)
	{
		目右_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_目右_接続;
	}

	public void 鼻接続(EleD e)
	{
		鼻_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_鼻_接続;
	}

	public void 口接続(EleD e)
	{
		口_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_口_接続;
	}

	public void 頬左接続(EleD e)
	{
		頬左_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_頬左_接続;
	}

	public void 頬右接続(EleD e)
	{
		頬右_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_頬右_接続;
	}

	public void 額接続(EleD e)
	{
		額_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_額_接続;
	}

	public void 眉左接続(EleD e)
	{
		眉左_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_眉左_接続;
	}

	public void 眉右接続(EleD e)
	{
		眉右_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_眉右_接続;
	}

	public void 耳左接続(EleD e)
	{
		耳左_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_耳左_接続;
	}

	public void 耳右接続(EleD e)
	{
		耳右_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_耳右_接続;
	}

	public void 鼻肌接続(EleD e)
	{
		鼻肌_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_鼻肌_接続;
	}

	public void 単眼目接続(EleD e)
	{
		単眼目_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_単眼目_接続;
	}

	public void 単眼眉接続(EleD e)
	{
		単眼眉_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_単眼眉_接続;
	}

	public void 大顎基接続(EleD e)
	{
		大顎基_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_大顎基_接続;
	}

	public void 顔面接続(EleD e)
	{
		顔面_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_顔面_接続;
	}

	public void 頭頂接続(EleD e)
	{
		頭頂_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_頭頂_接続;
	}

	public void 頬肌左接続(EleD e)
	{
		頬肌左_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_頬肌左_接続;
	}

	public void 頬肌右接続(EleD e)
	{
		頬肌右_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_頬肌右_接続;
	}

	public void 触覚左接続(EleD e)
	{
		触覚左_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_触覚左_接続;
	}

	public void 触覚右接続(EleD e)
	{
		触覚右_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.頭_触覚右_接続;
	}

	public 頭D SetRandom()
	{
		目高 = RNG.XS.NextDouble();
		return this;
	}

	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
	{
		return new 頭(DisUnit, 配色指定, 体配色, Med, this);
	}
}
