namespace SlaveMatrix;

public class 蝙通常
{
	public 上腕_蝙 上腕;

	public 下腕_蝙 下腕;

	public 手_蝙 手;

	public 蝙通常(上腕_蝙 上腕, 下腕_蝙 下腕, 手_蝙 手)
	{
		this.上腕 = 上腕;
		this.下腕 = 下腕;
		this.手 = 手;
	}

	public void 接続()
	{
		上腕.飛膜.接続(上腕, 下腕, 手, 上腕.接着());
		手.飛膜.接続(上腕, 下腕, 手, 手.カーブ);
	}
}
