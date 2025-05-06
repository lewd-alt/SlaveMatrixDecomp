using System;

namespace SlaveMatrix;

[Serializable]
public struct 下着T_クロス情報
{
	public bool ベース表示;

	public bool 皺1表示;

	public bool 皺2表示;

	public bool 皺3表示;

	public bool 縁1表示;

	public bool 縁2表示;

	public bool 縁3表示;

	public bool 縁4表示;

	public クロスT色 色;

	public bool IsShow
	{
		get
		{
			if (!ベース表示 && !皺1表示 && !皺2表示 && !皺3表示 && !縁1表示 && !縁2表示 && !縁3表示)
			{
				return 縁4表示;
			}
			return true;
		}
	}

	public void SetDefault()
	{
		ベース表示 = true;
		皺1表示 = true;
		皺2表示 = true;
		皺3表示 = true;
		縁1表示 = true;
		縁2表示 = true;
		縁3表示 = true;
		縁4表示 = true;
		色.SetDefault();
	}

	public static 下着T_クロス情報 GetDefault()
	{
		下着T_クロス情報 result = default(下着T_クロス情報);
		result.SetDefault();
		return result;
	}
}
