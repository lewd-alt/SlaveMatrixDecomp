using System;

namespace SlaveMatrix
{
    [Serializable]
    public struct 髪留1情報
    {
    	public bool 髪縛1_表示;

    	public bool 髪縛2_表示;

    	public 髪留色 色;

    	public void SetDefault()
    	{
    		髪縛1_表示 = true;
    		髪縛2_表示 = true;
    		色.SetDefault();
    	}
    }
}
