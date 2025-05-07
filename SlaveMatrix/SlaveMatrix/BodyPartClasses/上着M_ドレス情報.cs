using System;

namespace SlaveMatrix
{
    [Serializable]
    public struct 上着M_ドレス情報
    {
    	public bool ベース表示;

    	public bool 縁表示;

    	public bool 柄1表示;

    	public bool 柄2表示;

    	public bool 柄3表示;

    	public bool IsShow
    	{
    		get
    		{
    			if (!ベース表示 && !縁表示 && !柄1表示 && !柄2表示)
    			{
    				return 柄3表示;
    			}
    			return true;
    		}
    	}

    	public void SetDefault()
    	{
    		ベース表示 = true;
    		縁表示 = true;
    		柄1表示 = true;
    		柄2表示 = true;
    		柄3表示 = true;
    	}
    }
}
