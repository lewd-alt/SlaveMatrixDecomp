using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix;

[Serializable]
public class 首D : EleD
{
	public bool 植性_蔦_表示;

	public bool 植性_棘左上_表示;

	public bool 植性_棘左下_表示;

	public bool 植性_棘右上_表示;

	public bool 植性_棘右下_表示;

	public bool 首_表示 = true;

	public bool 淫タトゥ_ハート_タトゥ左_表示;

	public bool 淫タトゥ_ハート_タトゥ右_表示;

	public bool 淫タトゥ_タトゥ左_表示;

	public bool 淫タトゥ_タトゥ右_表示;

	public bool 悪タトゥ_文字_文字a_枠_表示;

	public bool 悪タトゥ_文字_文字a_文字タトゥ1_表示;

	public bool 悪タトゥ_文字_文字a_文字タトゥ2_表示;

	public bool 悪タトゥ_文字_文字b_枠_表示;

	public bool 悪タトゥ_文字_文字b_文字タトゥ1_表示;

	public bool 悪タトゥ_文字_文字b_文字タトゥ2_表示;

	public bool 悪タトゥ_文字_文字c_枠_表示;

	public bool 悪タトゥ_文字_文字c_文字タトゥ1_表示;

	public bool 悪タトゥ_文字_文字c_文字タトゥ2_表示;

	public bool 悪タトゥ_文字_文字d_枠_表示;

	public bool 悪タトゥ_文字_文字d_文字タトゥ1_表示;

	public bool 悪タトゥ_文字_文字d_文字タトゥ2_表示;

	public bool 悪タトゥ_文字_文字e_枠_表示;

	public bool 悪タトゥ_文字_文字e_文字タトゥ1_表示;

	public bool 悪タトゥ_文字_文字e_文字タトゥ2_表示;

	public bool 悪タトゥ_文字_文字e_文字タトゥ3_表示;

	public bool 悪タトゥ_タトゥ_表示;

	public bool 竜性_鱗1_表示;

	public bool 竜性_鱗2_表示;

	public bool 竜性_鱗3_表示;

	public bool 竜性_鱗4_表示;

	public bool 竜性_鱗5_表示;

	public bool 竜性_鱗6_表示;

	public bool 虫性_蛇腹4_表示;

	public bool 虫性_蛇腹3_表示;

	public bool 虫性_蛇腹2_表示;

	public bool 虫性_蛇腹1_表示;

	public bool ヴィオラ_左_襟_表示;

	public bool ヴィオラ_左_縁1_表示;

	public bool ヴィオラ_左_縁2_表示;

	public bool ヴィオラ_右_襟_表示;

	public bool ヴィオラ_右_縁1_表示;

	public bool ヴィオラ_右_縁2_表示;

	public bool 首輪_革_表示;

	public bool 首輪_金具1_表示;

	public bool 首輪_金具2_表示;

	public bool 首輪_金具3_表示;

	public bool 首輪_金具左_表示;

	public bool 首輪_金具右_表示;

	public bool 首輪表示;

	public bool ヴィオラ襟ベース表示;

	public bool ヴィオラ縁表示;

	public bool 鎖表示;

	public List<EleD> 頭_接続 = new List<EleD>();

	public 首D()
	{
		ThisType = GetType();
	}

	public void 頭接続(EleD e)
	{
		頭_接続.Add(e);
		e.Par = this;
		e.接続情報 = ConnectionInfo.首_頭_接続;
	}

	public override Ele GetEle(double DisUnit, Med Med, 体配色 体配色)
	{
		return new 首(DisUnit, 配色指定, 体配色, Med, this);
	}
}
