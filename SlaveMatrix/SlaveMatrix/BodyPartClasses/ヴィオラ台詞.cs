using _2DGAMELIB;

namespace SlaveMatrix
{
    public class ヴィオラ台詞
    {
    	private Med Med;

    	private 吹き出し hd;

    	public ヴィオラ台詞(Med Med, 吹き出し hd)
    	{
    		this.Med = Med;
    		this.hd = hd;
    	}

    	public void Set()
    	{
    		string text = "";
    		string mode = Med.Mode;
    		if (mode == "Office")
    		{
    			text = ((!Sta.GameData.初事務所フラグ) ? GameText.今日はどうしたの : GameText.いらっしゃい待っていたわ);
    		}
    		else if (mode == "Debt")
    		{
    			text = GameText.今日借りれる金額はあと + Sta.GameData.日借金可能額.ToString("#,0") + GameText.よ;
    		}
    		hd.Text = text;
    	}
    }
}
