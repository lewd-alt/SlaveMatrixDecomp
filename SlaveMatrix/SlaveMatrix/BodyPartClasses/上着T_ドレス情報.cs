using System;

namespace SlaveMatrix;

[Serializable]
public struct 上着T_ドレス情報
{
	public bool ベース表示;

	public bool 紐1表示;

	public bool 紐2表示;

	public bool 紐3表示;

	public bool 紐4表示;

	public bool 紐5表示;

	public bool 紐6表示;

	public bool 縁表示;

	public bool 柄1表示;

	public bool 柄2表示;

	public bool IsShow
	{
		get
		{
			if (!ベース表示 && !紐1表示 && !紐2表示 && !紐3表示 && !紐4表示 && !紐5表示 && !紐6表示 && !縁表示 && !柄1表示)
			{
				return 柄2表示;
			}
			return true;
		}
	}

	public void SetDefault()
	{
		ベース表示 = true;
		紐1表示 = true;
		紐2表示 = true;
		紐3表示 = true;
		紐4表示 = true;
		紐5表示 = true;
		紐6表示 = true;
		縁表示 = true;
		柄1表示 = true;
		柄2表示 = true;
	}
}
