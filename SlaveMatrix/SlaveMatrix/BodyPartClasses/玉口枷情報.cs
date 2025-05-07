using System;

namespace SlaveMatrix
{
    [Serializable]
    public struct 玉口枷情報
    {
    	public bool 金具左上_表示;

    	public bool 金具左下_表示;

    	public bool 革左_表示;

    	public bool 金具右上_表示;

    	public bool 金具右下_表示;

    	public bool 革右_表示;

    	public bool 革_表示;

    	public bool 玉_表示;

    	public bool 穴中上_表示;

    	public bool 穴右_表示;

    	public bool 穴中下_表示;

    	public bool 穴左_表示;

    	public bool 穴上右上_表示;

    	public bool 穴上右下_表示;

    	public bool 穴下右上_表示;

    	public bool 穴下右下_表示;

    	public bool 穴下左下_表示;

    	public bool 穴下左上_表示;

    	public bool 穴上左下_表示;

    	public bool 穴上左上_表示;

    	public bool 丸金具左内_表示;

    	public bool 丸金具右内2_表示;

    	public bool 丸金具左外_表示;

    	public bool 丸金具右外_表示;

    	public 玉口枷色 色;

    	public void SetDefault()
    	{
    		金具左上_表示 = true;
    		金具左下_表示 = true;
    		革左_表示 = true;
    		金具右上_表示 = true;
    		金具右下_表示 = true;
    		革右_表示 = true;
    		革_表示 = true;
    		玉_表示 = true;
    		穴中上_表示 = true;
    		穴右_表示 = true;
    		穴中下_表示 = true;
    		穴左_表示 = true;
    		穴上右上_表示 = true;
    		穴上右下_表示 = true;
    		穴下右上_表示 = true;
    		穴下右下_表示 = true;
    		穴下左下_表示 = true;
    		穴下左上_表示 = true;
    		穴上左下_表示 = true;
    		穴上左上_表示 = true;
    		丸金具左内_表示 = true;
    		丸金具右内2_表示 = true;
    		丸金具左外_表示 = true;
    		丸金具右外_表示 = true;
    		色.SetDefault();
    	}

    	public static 玉口枷情報 GetDefault()
    	{
    		玉口枷情報 result = default(玉口枷情報);
    		result.SetDefault();
    		return result;
    	}
    }
}
