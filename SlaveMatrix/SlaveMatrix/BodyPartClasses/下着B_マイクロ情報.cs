using System;

namespace SlaveMatrix;

[Serializable]
public struct 下着B_マイクロ情報
{
	public bool ベース表示;

	public bool 紐輪表示;

	public bool 紐表示;

	public bool 縁1表示;

	public bool 縁2表示;

	public bool 縁3表示;

	public bool 縁4表示;

	public bool ヴィオラ表示;

	public bool 染み表示;

	public マイクロB色 色;

	public bool 縁
	{
		get
		{
			if (縁1表示 && 縁2表示 && 縁3表示)
			{
				return 縁4表示;
			}
			return false;
		}
		set
		{
			縁1表示 = value;
			縁2表示 = value;
			縁3表示 = value;
			縁4表示 = value;
		}
	}

	public bool 紐
	{
		get
		{
			if (紐輪表示)
			{
				return 紐表示;
			}
			return false;
		}
		set
		{
			紐輪表示 = value;
			紐表示 = value;
		}
	}

	public bool IsShow
	{
		get
		{
			if (!ベース表示 && !紐輪表示 && !紐表示 && !縁1表示 && !縁2表示 && !縁3表示 && !縁4表示 && !ヴィオラ表示)
			{
				return 染み表示;
			}
			return true;
		}
	}

	public void SetDefault()
	{
		ベース表示 = true;
		紐輪表示 = false;
		紐表示 = false;
		縁1表示 = true;
		縁2表示 = true;
		縁3表示 = true;
		縁4表示 = true;
		ヴィオラ表示 = false;
		染み表示 = true;
		色.SetDefault();
	}

	public void Set紐付き()
	{
		ベース表示 = true;
		紐輪表示 = true;
		紐表示 = true;
		縁1表示 = true;
		縁2表示 = true;
		縁3表示 = true;
		縁4表示 = true;
		ヴィオラ表示 = false;
		染み表示 = true;
		色.SetDefault();
	}

	public void Setヴィオラ()
	{
		ベース表示 = true;
		紐輪表示 = false;
		紐表示 = false;
		縁1表示 = true;
		縁2表示 = true;
		縁3表示 = true;
		縁4表示 = true;
		ヴィオラ表示 = true;
		染み表示 = false;
		色.Setヴィオラ();
	}

	public static 下着B_マイクロ情報 Getマイクロ()
	{
		下着B_マイクロ情報 result = default(下着B_マイクロ情報);
		result.SetDefault();
		return result;
	}

	public static 下着B_マイクロ情報 Getマイクロ紐付き()
	{
		下着B_マイクロ情報 result = default(下着B_マイクロ情報);
		result.Set紐付き();
		return result;
	}

	public static 下着B_マイクロ情報 Getヴィオラ()
	{
		下着B_マイクロ情報 result = default(下着B_マイクロ情報);
		result.Setヴィオラ();
		return result;
	}
}
