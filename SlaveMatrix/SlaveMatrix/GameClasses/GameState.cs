using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2DGAMELIB;

namespace SlaveMatrix;

[Serializable]
public class GameState
{
	public Unit ヴィオラ;

	public double 利子 = 0.002;

	public ulong 日借金額;

	public double 身長 = 0.5;

	public double 体重 = 0.5;

	public 主人公色 色 = new 主人公色();

	public 主人公配色 配色;

	public double 精力 = 1.0;

	public double 射精;

	public double 興奮;

	public double 調教力;

	public Unit プレーヤー;

	public ulong 時間;

	public ulong 所持金;

	public ulong 借金;

	public Dictionary<string, double> 需給;

	public int RepaymentStage;

	public Unit TrainingTarget;

	public Unit[] Slaves = new Unit[Mods.MaxRoomNumber];

	public Unit 祝福;

	public bool[] 系統開放 = new bool[9] { true, true, false, false, false, false, false, false, false };

	public bool[] PurchasedTools = new bool[14];

	public bool 初事務所フラグ = true;

	private const int Capacity = 3;

	public Generator[] Gen = new Generator[9];

	public bool Refresh;

	public int フロア数 = 1;

	public bool 拘束具;

	public bool 目隠帯;

	public bool 玉口枷;

	public bool 断面;

	public bool ガイド = true;

	public bool 心眼;

	public bool 媚薬;

	public bool 施術;

	public bool 淫紋;

	public bool 衣装;

	public bool ヴィオラ服;

	public bool 新日;

	public ulong 日借金可能額 => 50000000 - 日借金額;

	public ulong 利子額 => (ulong)((double)借金 * 利子).RoundDown(0);

	public string 時間帯
	{
		get
		{
			ulong num = 時間 % 3;
			if (num <= 2)
			{
				switch (num)
				{
				case 0uL:
					return GameText.朝;
				case 1uL:
					return GameText.昼;
				case 2uL:
					return GameText.夜;
				}
			}
			return "";
		}
	}

	public ulong 日数 => 時間 / 3;

	public Generator 鳥系 => Gen[0];

	public Generator 蛇系 => Gen[1];

	public Generator 獣系 => Gen[2];

	public Generator 水系 => Gen[3];

	public Generator 虫系 => Gen[4];

	public Generator 人型 => Gen[5];

	public Generator 幻獣 => Gen[6];

	public Generator 魔獣 => Gen[7];

	public Generator 竜系 => Gen[8];

	public void 時間進行()
	{
		時間++;
	}

	public string GetSaveDateString()
	{
		return 日数 + GameText.日目 + "/" + 時間帯;
	}

	public bool Is地下室一杯()
	{
		return !Slaves.Take(Mods.MaxRoomNumber / 9 * フロア数).Any((Unit e) => e == null);
	}

	public void Add地下室(Unit Unit)
	{
		for (int i = 0; i < Slaves.Length; i++)
		{
			if (Slaves[i] == null)
			{
				Slaves[i] = Unit;
				break;
			}
		}
		if (Sta.AutoSort)
		{
			Array.Sort(Slaves, (Unit e1, Unit e2) => (e1 != null) ? ((e2 != null) ? e1.Race.CompareTo(e2.Race) : int.MinValue) : int.MaxValue);
		}
		for (int j = 0; j < Slaves.Length; j++)
		{
			if (Slaves[j] != null)
			{
				Unit unit = Slaves[j];
				unit.階層位置 = j / 15;
				unit.RoomNumber = j % 15;
				unit.Number = (j + 1).ToString().PadLeft(3, '0');
				Slaves[j] = unit;
			}
		}
	}

	public void GenRefresh()
	{
		Refresh = true;
		/*
		Parallel.ForEach(Gen, Sta.po3, delegate(Generator g)
		{
			g.Refresh(3);
		});*/

		foreach (Generator g in Gen)
			g.Refresh(3);
		Refresh = false;
	}

	public void GenInstance()
	{
		Refresh = true;
		for (int i = 0; i < Gen.Length; i++)
		{
			Gen[i] = new Generator(3, (GeneratorType)i);
		}
		Refresh = false;
	}

	public string GetPriceInfo(out ulong s)
	{
		s = 0uL;
		Unit[] array = Slaves;
		foreach (Unit unit in array)
		{
			if (unit != null && !unit.保守)
			{
				s += unit.GetPrice();
			}
		}
		return "\r\n" + GameText.合計売却額 + " +" + s.ToString("#,0");
	}

	public void 地下室詰め()
	{
		Unit[] array = Slaves.Where((Unit e) => e != null).ToArray();
		for (int i = 0; i < Mods.MaxRoomNumber; i++)
		{
			if (array.Length > i)
			{
				array[i].階層位置 = i / 15;
				array[i].RoomNumber = i % 15;
				array[i].Number = (i + 1).ToString().PadLeft(3, '0');
				Slaves[i] = array[i];
			}
			else
			{
				Slaves[i] = null;
			}
		}
	}

	public GameState()
	{
		配色 = new 主人公配色(色);
	}

	public void SetDefault()
	{
		ヴィオラ = null;
		利子 = 0.002;
		日借金額 = 0uL;
		身長 = 0.5;
		体重 = 0.5;
		色 = new 主人公色();
		配色 = new 主人公配色(色);
		精力 = 1.0;
		射精 = 0.0;
		興奮 = 0.0;
		調教力 = 0.0;
		時間 = 0uL;
		所持金 = 0uL;
		借金 = 0uL;
		需給初期化();
		RepaymentStage = 0;
		TrainingTarget = null;
		Slaves = new Unit[Mods.MaxRoomNumber];
		祝福 = null;
		系統開放 = new bool[9] { true, true, false, false, false, false, false, false, false };
		PurchasedTools = new bool[14];
		初事務所フラグ = true;

		GenInstance();

		フロア数 = 1;
		拘束具 = false;
		目隠帯 = false;
		玉口枷 = false;
		断面 = false;
		ガイド = true;
		心眼 = false;
		媚薬 = false;
		施術 = false;
		淫紋 = false;
		衣装 = false;
		ヴィオラ服 = false;
		新日 = false;
	}

	public void 需給初期化()
	{
		需給 = new Dictionary<string, double>
		{
			{
				GameText.サキュバス,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.バイコーン,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ドワーフ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.アルラウネ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.スキュラ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.アラクネ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ユニコーン,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.エキドナ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ムカデジョウロウ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.オールドスキュラ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ドラゴニュート,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.カッパ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.エルフ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.リザードマン,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.オーグリス,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.デビル,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.オールドマーメイド,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ラミア,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.シーラミア,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.サイクロプス,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ミノタウロス,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.エイリアン,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ゴルゴン,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ギルタブリル,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ウロボロス,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.フェニックス,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ドラゴン,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.リュウ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.リリン,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.セイレーン,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ハルピュイア,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.オノケンタウレ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.カプラケンタウレ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.チータケンタウレ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.エンジェル,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.マーメイド,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ドルフィンマーメイド,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ウェアキャット,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ウェアウルフ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ウェアフォックス,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ヒュドラ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.クラーケン,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ヒッポケンタウレ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ブケンタウレ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.レオントケンタウレ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ティグリスケンタウレ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.パンテーラケンタウレ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.イクテュオケンタウレ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.デルピヌスケンタウレ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ギルタブルル,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.スフィンクス,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ペガサス,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.アリコーン,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.キマイラ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.グリフォン,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ヒッポグリフ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.モノケロス,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.カリュブディス,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ドラコケンタウレ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.カーバンクル,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.スライム,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.フェアリー,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ハーピー,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.アフール,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ウェアマンティス,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ウェアドラゴンフライ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.カトブレパス,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.バジリスク,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.コカトリス,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ワーム,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ワイバーン,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ウェアビートル,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ウェアスタッグビートル,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.サンドワーム,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ヴィオランテ,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ヒューマン,
				NextNormal(RNG.XS, Mods.DemandMax)
			},
			{
				GameText.ミックス,
				NextNormal(RNG.XS, Mods.DemandMax)
			}
		};
	}

	public void 需給更新()
	{
		string[] array = Sta.GameData.需給.Keys.ToArray();
		foreach (string key in array)
		{
			Sta.GameData.需給[key] = NextNormal(RNG.XS, Mods.DemandMax);
		}
	}

	private double NextNormal(MyRandom r, double mr)
	{
		double num = mr * 0.5 * r.NextNorCos();
		if (!(num > 0.0))
		{
			if (!(num < 0.0))
			{
				return 1.0;
			}
			return 0.0 - 1.0 / num;
		}
		return num;
	}
}
