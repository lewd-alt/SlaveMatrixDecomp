using System;

namespace SlaveMatrix;

[Serializable]
public struct 下着B_ノーマル情報
{
	public bool ベース表示;

	public bool 紐輪表示;

	public bool 紐表示;

	public bool 縁1表示;

	public bool 縁2表示;

	public bool 縁3表示;

	public bool 縁4表示;

	public bool リボン表示;

	public bool リボン結び目表示;

	public bool ライン中表示;

	public bool ライン左右表示;

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

	public bool 染み表示;

	public ノーマルB色 色;

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
			if (!ベース表示 && !紐輪表示 && !紐表示 && !縁1表示 && !縁2表示 && !縁3表示 && !縁4表示 && !リボン表示 && !リボン結び目表示 && !ライン中表示 && !ライン左右表示 && !柄1表示 && !柄2表示 && !柄3表示 && !柄4表示 && !柄5表示 && !柄6表示 && !柄7表示 && !柄8表示 && !柄9表示 && !柄10表示)
			{
				return 染み表示;
			}
			return true;
		}
	}

	public void Setランジェリー()
	{
		ベース表示 = true;
		紐輪表示 = false;
		紐表示 = false;
		縁1表示 = true;
		縁2表示 = true;
		縁3表示 = true;
		縁4表示 = true;
		リボン表示 = true;
		リボン結び目表示 = true;
		ライン中表示 = true;
		ライン左右表示 = true;
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
		染み表示 = true;
		色.SetDefault();
	}

	public void Setランジェリー紐付き()
	{
		ベース表示 = true;
		紐輪表示 = true;
		紐表示 = true;
		縁1表示 = true;
		縁2表示 = true;
		縁3表示 = true;
		縁4表示 = true;
		リボン表示 = true;
		リボン結び目表示 = true;
		ライン中表示 = true;
		ライン左右表示 = true;
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
		染み表示 = true;
		色.SetDefault();
	}

	public void Setビキニ()
	{
		ベース表示 = true;
		紐輪表示 = false;
		紐表示 = false;
		縁1表示 = true;
		縁2表示 = true;
		縁3表示 = true;
		縁4表示 = true;
		リボン表示 = false;
		リボン結び目表示 = false;
		ライン中表示 = false;
		ライン左右表示 = false;
		柄1表示 = false;
		柄2表示 = false;
		柄3表示 = false;
		柄4表示 = false;
		柄5表示 = false;
		柄6表示 = false;
		柄7表示 = false;
		柄8表示 = false;
		柄9表示 = false;
		柄10表示 = false;
		染み表示 = true;
		色.Setビキニ();
	}

	public void Setビキニ紐付き()
	{
		ベース表示 = true;
		紐輪表示 = true;
		紐表示 = true;
		縁1表示 = true;
		縁2表示 = true;
		縁3表示 = true;
		縁4表示 = true;
		リボン表示 = false;
		リボン結び目表示 = false;
		ライン中表示 = false;
		ライン左右表示 = false;
		柄1表示 = false;
		柄2表示 = false;
		柄3表示 = false;
		柄4表示 = false;
		柄5表示 = false;
		柄6表示 = false;
		柄7表示 = false;
		柄8表示 = false;
		柄9表示 = false;
		柄10表示 = false;
		染み表示 = true;
		色.Setビキニ();
	}

	public static 下着B_ノーマル情報 Getランジェリー()
	{
		下着B_ノーマル情報 result = default(下着B_ノーマル情報);
		result.Setランジェリー();
		return result;
	}

	public static 下着B_ノーマル情報 Getランジェリー紐付き()
	{
		下着B_ノーマル情報 result = default(下着B_ノーマル情報);
		result.Setランジェリー紐付き();
		return result;
	}

	public static 下着B_ノーマル情報 Getビキニ()
	{
		下着B_ノーマル情報 result = default(下着B_ノーマル情報);
		result.Setビキニ();
		return result;
	}

	public static 下着B_ノーマル情報 Getビキニ紐付き()
	{
		下着B_ノーマル情報 result = default(下着B_ノーマル情報);
		result.Setビキニ紐付き();
		return result;
	}
}
