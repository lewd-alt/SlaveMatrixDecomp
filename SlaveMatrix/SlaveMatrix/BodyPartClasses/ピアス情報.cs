using System;

namespace SlaveMatrix
{
    [Serializable]
    public struct ピアス情報
    {
    	public bool ピアス_表示;

    	public ピアス色 色;

    	public void SetDefault()
    	{
    		ピアス_表示 = true;
    		色.SetDefault();
    	}

    	public static ピアス情報 GetDefault()
    	{
    		ピアス情報 result = default(ピアス情報);
    		result.SetDefault();
    		return result;
    	}
    }
}
