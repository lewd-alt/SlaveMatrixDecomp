using System;

namespace SlaveMatrix;

[Serializable]
public struct 上着B_クロス情報
{
	public bool ベース表示;

	public bool ベース皺1表示;

	public bool ベース皺2表示;

	public bool ベース皺3表示;

	public bool ベース皺4表示;

	public bool ベース皺5表示;

	public bool 中表示;

	public bool 中皺1表示;

	public bool 中皺2表示;

	public クロスB色 色;

	public bool 中
	{
		get
		{
			if (中表示 && 中皺1表示)
			{
				return 中皺2表示;
			}
			return false;
		}
		set
		{
			中表示 = value;
			中皺1表示 = value;
			中皺2表示 = value;
		}
	}

	public bool IsShow
	{
		get
		{
			if (!ベース表示 && !ベース皺1表示 && !ベース皺2表示 && !ベース皺3表示 && !ベース皺4表示 && !ベース皺5表示 && !中表示 && !中皺1表示)
			{
				return 中皺2表示;
			}
			return true;
		}
	}

	public void SetDefault()
	{
		ベース表示 = true;
		ベース皺1表示 = true;
		ベース皺2表示 = true;
		ベース皺3表示 = true;
		ベース皺4表示 = true;
		ベース皺5表示 = true;
		中表示 = true;
		中皺1表示 = true;
		中皺2表示 = true;
		色.SetDefault();
	}

	public static 上着B_クロス情報 GetDefault()
	{
		上着B_クロス情報 result = default(上着B_クロス情報);
		result.SetDefault();
		return result;
	}
}
