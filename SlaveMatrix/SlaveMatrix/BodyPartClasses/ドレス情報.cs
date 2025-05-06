using System;

namespace SlaveMatrix;

[Serializable]
public struct ドレス情報
{
	public 上着T_ドレス情報 T;

	public 上着M_ドレス情報 M;

	public ドレス色 色;

	public bool IsShow
	{
		get
		{
			if (!T.IsShow)
			{
				return M.IsShow;
			}
			return true;
		}
	}

	public void SetDefault()
	{
		T.SetDefault();
		M.SetDefault();
		色.SetDefault();
	}

	public static ドレス情報 GetDefault()
	{
		ドレス情報 result = default(ドレス情報);
		result.SetDefault();
		return result;
	}
}
