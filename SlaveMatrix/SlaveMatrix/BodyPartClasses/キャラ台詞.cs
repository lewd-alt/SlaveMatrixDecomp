using _2DGAMELIB;

namespace SlaveMatrix;

public class キャラ台詞
{
	private Med Med;

	private 吹き出し hd;

	public キャラ台詞(Med Med, 吹き出し hd)
	{
		this.Med = Med;
		this.hd = hd;
	}

	public void Set()
	{
		string text = "";
		text = hd.Text;
		hd.Text = text;
	}

	public void Set状態()
	{
		string 点6ハート = GameText.点6ハート;
		hd.Text = 点6ハート;
	}
}
