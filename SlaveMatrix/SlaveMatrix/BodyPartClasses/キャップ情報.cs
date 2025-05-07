using System;

namespace SlaveMatrix
{
    [Serializable]
    public struct キャップ情報
    {
    	public bool 根本_表示;

    	public bool 先端_表示;

    	public キャップ色 色;

    	public void SetDefault()
    	{
    		根本_表示 = true;
    		先端_表示 = true;
    		色.SetDefault();
    	}

    	public static キャップ情報 GetDefault()
    	{
    		キャップ情報 result = default(キャップ情報);
    		result.SetDefault();
    		return result;
    	}
    }
}
