using System;

namespace SlaveMatrix
{
    [Serializable]
    public struct ドレス首情報
    {
    	public bool ヴィオラ襟ベース表示;

    	public bool ヴィオラ縁表示;

    	public ドレス首色 色;

    	public void SetDefault()
    	{
    		ヴィオラ襟ベース表示 = true;
    		ヴィオラ縁表示 = true;
    		色.SetDefault();
    	}

    	public static ドレス首情報 GetDefault()
    	{
    		ドレス首情報 result = default(ドレス首情報);
    		result.SetDefault();
    		return result;
    	}
    }
}
