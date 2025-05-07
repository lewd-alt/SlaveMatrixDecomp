using System;

namespace SlaveMatrix
{
    [Serializable]
    public struct 上着B_前掛け情報
    {
    	public bool ベース表示;

    	public bool 縁表示;

    	public bool 巻縁表示;

    	public 前掛けB色 色;

    	public bool IsShow
    	{
    		get
    		{
    			if (!ベース表示 && !縁表示)
    			{
    				return 巻縁表示;
    			}
    			return true;
    		}
    	}

    	public void SetDefault()
    	{
    		ベース表示 = true;
    		縁表示 = true;
    		巻縁表示 = true;
    		色.SetDefault();
    	}

    	public static 上着B_前掛け情報 GetDefault()
    	{
    		上着B_前掛け情報 result = default(上着B_前掛け情報);
    		result.SetDefault();
    		return result;
    	}
    }
}
