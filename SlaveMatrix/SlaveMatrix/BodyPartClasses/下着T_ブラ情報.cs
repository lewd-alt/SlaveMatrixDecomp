using System;

namespace SlaveMatrix
{
    [Serializable]
    public struct 下着T_ブラ情報
    {
    	public bool ベース表示;

    	public bool 縁1表示;

    	public bool 縁2表示;

    	public bool 縁3表示;

    	public bool 縁4表示;

    	public bool 縁5表示;

    	public bool 縁6表示;

    	public bool 縁7表示;

    	public bool ジャスター表示;

    	public bool レース表示;

    	public bool 柄1表示;

    	public bool 柄2表示;

    	public bool 柄3表示;

    	public bool 柄4表示;

    	public bool 柄5表示;

    	public bool 柄6表示;

    	public bool 柄7表示;

    	public bool 柄8表示;

    	public bool 柄9表示;

    	public bool 柄10表示;

    	public bool 柄11表示;

    	public bool 柄12表示;

    	public bool 柄13表示;

    	public bool 柄14表示;

    	public bool リボン表示;

    	public bool リボン結び目表示;

    	public ブラT色 色;

    	public bool IsShow
    	{
    		get
    		{
    			if (!ベース表示 && !縁1表示 && !縁2表示 && !縁3表示 && !縁4表示 && !縁5表示 && !縁6表示 && !縁7表示 && !ジャスター表示 && !レース表示 && !柄1表示 && !柄2表示 && !柄3表示 && !柄4表示 && !柄5表示 && !柄6表示 && !柄7表示 && !柄8表示 && !柄9表示 && !柄10表示 && !柄11表示 && !柄12表示 && !柄13表示 && !柄14表示 && !リボン表示)
    			{
    				return リボン結び目表示;
    			}
    			return true;
    		}
    	}

    	public void SetDefault()
    	{
    		ベース表示 = true;
    		縁1表示 = true;
    		縁2表示 = true;
    		縁3表示 = true;
    		縁4表示 = true;
    		縁5表示 = true;
    		縁6表示 = true;
    		縁7表示 = true;
    		ジャスター表示 = true;
    		レース表示 = true;
    		柄1表示 = true;
    		柄2表示 = true;
    		柄3表示 = true;
    		柄4表示 = true;
    		柄5表示 = true;
    		柄6表示 = true;
    		柄7表示 = true;
    		柄8表示 = true;
    		柄9表示 = true;
    		柄10表示 = true;
    		柄11表示 = true;
    		柄12表示 = true;
    		柄13表示 = true;
    		柄14表示 = true;
    		リボン表示 = true;
    		リボン結び目表示 = true;
    		色.SetDefault();
    	}

    	public static 下着T_ブラ情報 GetDefault()
    	{
    		下着T_ブラ情報 result = default(下着T_ブラ情報);
    		result.SetDefault();
    		return result;
    	}
    }
}
