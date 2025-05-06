using System;

namespace SlaveMatrix;

[Serializable]
public struct 髪留2情報
{
	public 髪留1情報 髪留左;

	public 髪留1情報 髪留右;

	public void SetDefault()
	{
		髪留左.SetDefault();
		髪留右.SetDefault();
	}

	public static 髪留2情報 GetDefault()
	{
		髪留2情報 result = default(髪留2情報);
		result.SetDefault();
		return result;
	}
}
