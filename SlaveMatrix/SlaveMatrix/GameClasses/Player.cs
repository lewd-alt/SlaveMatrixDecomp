using System;
using System.Collections.Generic;
using System.Drawing;
using _2DGAMELIB;

namespace SlaveMatrix;
public enum CurrentState
{
    none,
    Start,
    Continue,
    End
}
public enum ToolType
{
    none,
    Hand,
    マウス,
    Penis,
    Dildo,
    Vibrator,
    Drill,
    デンマ,
    AnalVibrator,
    ロータ,
    パール,
    調教鞭,
    羽根箒,
    Ｔ剃刀,
    キャプ
}

public enum ActionType
{
    none,
    Grope,
    Milk,
    乳捏,
    核捏,
    Insertion,
    Contact,
    Whipping,
    Shaving,
    Tickle,
    くぱ,
    パイ,
    手コ,
    足コ,
    吸引,
    Licking
}

public enum ContactType
{
    none,
    Head,
    Face,
    Ear,
    Mouth,
    Hair,
    Neck,
    Shoulder,
    Chest,
    Milk,
    Side,
    Stomache,
    Crotch,
    Sex,
    Vagina,
    Nucleus,
    Anal,
    Thread,
    Thigh,
    Feet,
    Hand,
    Awareness,
    Touch,
    Tail,
    Wing,
    Fin,
    Other
}


//probably represents the player
public static class Player
{
	public static Cha Cha;

	public static TrainingUI UI;

	public static ContactType CurrentContactType;

	public static ActionType CurrentActionType;

	public static CurrentState タイミング情報n;

	public static ToolType CurrentToolType;

	public static int 挿入Lvn;

	public static int 強さn;

	public static bool 機械n;

	public static bool 射精n;

	public static ContactType 接触o;

	public static ActionType アクション情報o;

	public static CurrentState タイミング情報o;

	public static ToolType アイテム情報o;

	public static int 挿入Lvo;

	public static int 強さo;

	public static bool 機械o;

	public static bool 射精o;

	private static double 奴隷a;

	private static double 奴隷ao;

	private static double 主人a;

	private static double 主人ao;

	private static double 奴隷接触慣れ;

	private static double 奴隷アクション慣れ;

	public static bool 絶頂中;

	public static bool 射精中;

	private static int 絶頂回数;

	private static double 放尿率;

	public static double PreTrainingPride;

	public static double PreTrainingLust;

	public static double PreTrainingAffection;

	public static double PreTrainingTraining;

	public static double PreTrainingSkillL;

	public static double 調教前調教力;

	public static Mot ゲージ降下処理;

	public static bool 強制終了;

	public static bool Hairless;

	public static bool Virgin;

	public static bool 発情;

	public static bool Pregnant;

	public static bool Muscular;

	public static bool Scars;

	public static bool Trained;

	private static bool 初回;

	private static double 反応度;

	public static double PlayerStamina
	{
		get
		{
			return Sta.GameData.精力;
		}
		set
		{
			Sta.GameData.精力 = value;
		}
	}

	public static double PlayerSensitivity
	{
		get
		{
			return Sta.GameData.射精;
		}
		set
		{
			Sta.GameData.射精 = value;
			Sta.GameData.射精 = Sta.GameData.射精.Clamp(0.0, 1.0);
		}
	}

	public static double PlayerExcitement
	{
		get
		{
			return Sta.GameData.興奮;
		}
		set
		{
			Sta.GameData.興奮 = value;
			Sta.GameData.興奮 = Sta.GameData.興奮.Clamp(0.0, 1.0);
		}
	}

	public static double 調教力
	{
		get
		{
			return Sta.GameData.調教力;
		}
		set
		{
			Sta.GameData.調教力 = value;
		}
	}

	public static double Stamina
	{
		get
		{
			return Sta.GameData.TrainingTarget.ChaD.Stamina;
		}
		set
		{
			Sta.GameData.TrainingTarget.ChaD.Stamina = value;
		}
	}

	public static double Sensitivity
	{
		get
		{
			return Sta.GameData.TrainingTarget.ChaD.Sensitivity;
		}
		set
		{
			Sta.GameData.TrainingTarget.ChaD.Sensitivity = value;
			Sta.GameData.TrainingTarget.ChaD.Sensitivity = Sta.GameData.TrainingTarget.ChaD.Sensitivity.Clamp(0.0, 1.0);
		}
	}

	public static double Excitement
	{
		get
		{
			return Sta.GameData.TrainingTarget.ChaD.Excitement;
		}
		set
		{
			Sta.GameData.TrainingTarget.ChaD.Excitement = value;
			Sta.GameData.TrainingTarget.ChaD.Excitement = Sta.GameData.TrainingTarget.ChaD.Excitement.Clamp(0.0, 1.0);
		}
	}

	public static double Wetness
	{
		get
		{
			return Sta.GameData.TrainingTarget.ChaD.Wetness;
		}
		set
		{
			Sta.GameData.TrainingTarget.ChaD.Wetness = value;
		}
	}

	public static double Tension
	{
		get
		{
			return Sta.GameData.TrainingTarget.ChaD.Tension;
		}
		set
		{
			Sta.GameData.TrainingTarget.ChaD.Tension = value;
		}
	}

	public static double Shame
	{
		get
		{
			return Sta.GameData.TrainingTarget.ChaD.Shyness;
		}
		set
		{
			Sta.GameData.TrainingTarget.ChaD.Shyness = value;
		}
	}

	public static double Pride
	{
		get
		{
			return Sta.GameData.TrainingTarget.ChaD.Pride;
		}
		set
		{
			Sta.GameData.TrainingTarget.ChaD.Pride = value;
		}
	}

	public static double Lust
	{
		get
		{
			return Sta.GameData.TrainingTarget.ChaD.Lust;
		}
		set
		{
			Sta.GameData.TrainingTarget.ChaD.Lust = value;
		}
	}

	public static double Affection
	{
		get
		{
			return Sta.GameData.TrainingTarget.ChaD.Affection;
		}
		set
		{
			Sta.GameData.TrainingTarget.ChaD.Affection = value;
		}
	}

	public static double Training
	{
		get
		{
			return Sta.GameData.TrainingTarget.ChaD.Taming;
		}
		set
		{
			Sta.GameData.TrainingTarget.ChaD.Taming = value;
		}
	}

	public static double SkillL
	{
		get
		{
			return Sta.GameData.TrainingTarget.ChaD.SkillL;
		}
		set
		{
			Sta.GameData.TrainingTarget.ChaD.SkillL = value;
		}
	}

	public static Dictionary<ContactType, double> 部位感度
	{
		get
		{
			return Sta.GameData.TrainingTarget.ChaD.Sesnsitivities;
		}
		set
		{
			Sta.GameData.TrainingTarget.ChaD.Sesnsitivities = value;
		}
	}

	public static double 現陰毛
	{
		get
		{
			return Sta.GameData.TrainingTarget.ChaD.現陰毛;
		}
		set
		{
			Sta.GameData.TrainingTarget.ChaD.現陰毛 = value;
		}
	}

	public static double 放尿経験値
	{
		get
		{
			return Sta.GameData.TrainingTarget.ChaD.放尿経験値;
		}
		set
		{
			Sta.GameData.TrainingTarget.ChaD.放尿経験値 = value;
		}
	}

	public static bool パイズリRun => UI.ペニス処理.パイズリ.Run;

	public static bool フェラRun => UI.ペニス処理.フェラ.Run;

	public static bool 加算前提
	{
		get
		{
			if (!強制終了 && Sta.GameData.TrainingTarget != null && Cha != null)
			{
				return Cha.Med.Mode == "Training";
			}
			return false;
		}
	}

	public static double 調教力影響値 => 0.1 + 0.9 * 調教力;

	public static double 技巧度影響値 => 0.3 + 0.7 * (SkillL / Sta.GameData.TrainingTarget.MaxSkillL);

	public static double 主消費影響値 => (主人a + 調教力影響値.Inverse()) * 0.5 * ((Sta.GameData.祝福 != null) ? Sta.GameData.祝福.消耗乗算値 : 1.0);

	public static double 奴消費影響値 => 調教力.Inverse() * 強靭0_7w * 傷物1_2w * 調教済0_9w * Sta.GameData.TrainingTarget.消耗乗算値;

	public static double 主射精値 => (PlayerSensitivity + PlayerExcitement) / 2.0;

	public static double 主興奮値 => (PlayerSensitivity + PlayerExcitement + Excitement) / 3.0;

	public static double 主アクション値 => CurrentActionType switch
	{
		ActionType.Contact => 0.25, 
		ActionType.none => 0.8, 
		ActionType.足コ => 0.3, 
		ActionType.手コ => 0.35, 
		ActionType.パイ => 0.6, 
		ActionType.Insertion => 0.8 + ((CurrentContactType == ContactType.Vagina) ? Wetness : Excitement) * 0.2, 
		_ => 0.0, 
	};

	private static double 主感度興奮差 => (PlayerSensitivity - PlayerExcitement).Abs().Inverse();

	public static double 主刺激値 => 主アクション値 * 主感度興奮差;

	public static double 主感度確率
	{
		get
		{
			switch (CurrentActionType)
			{
			case ActionType.Insertion:
				return 0.2;
			case ActionType.Contact:
				return 0.2;
			case ActionType.パイ:
				if (パイズリRun)
				{
					return 0.6;
				}
				return 0.2;
			case ActionType.手コ:
				return 0.6;
			case ActionType.足コ:
				return 0.6;
			case ActionType.none:
				return 1.0;
			default:
				return 0.0;
			}
		}
	}

	public static double 感度値 => (Sensitivity + Excitement + Tension.Inverse() + Shame) / 4.0 * Lust * Affection * 発情1_5w * 調教済1_1w * 目隠帯補正増;

	public static double 興奮値 => (Sensitivity + Excitement + PlayerExcitement + Shame) / 4.0 * Lust * 発情1_5w * 調教済1_1w * 拘束具補正増 * 玉口枷補正増;

	public static double 潤滑値 => (Sensitivity + Excitement) / 2.0 * Lust * Affection * 処女0_8w * 発情1_5w * 調教済1_1w;

	public static double 緊張値 => (Sensitivity + Tension.Inverse() + Shame.Inverse()) / 3.0 * Lust * Affection * 処女0_8w * 傷物0_8w * 調教済1_1w * 拘束具補正減 * 目隠帯補正減;

	public static double 羞恥値 => (Sensitivity + Excitement + PlayerExcitement + Shame + Cha.Bod.くぱぁ0) / 5.0 * Affection * 無毛1_5w * 処女1_5w * 発情0_5w * 調教済1_1w * 目隠帯補正減 * 玉口枷補正増;

	public static double 奉仕補正
	{
		get
		{
			if (パイズリRun || フェラRun)
			{
				return 1.0 - 0.5 * (SkillL / Sta.GameData.TrainingTarget.MaxSkillL);
			}
			return 1.0;
		}
	}

	public static double 性感補正値
	{
		get
		{
			double num = 0.4;
			return CurrentContactType switch
			{
				ContactType.Stomache => num * 0.2, 
				ContactType.Thigh => num * 0.4, 
				ContactType.Side => num * 0.4, 
				ContactType.Mouth => num * 0.5, 
				ContactType.Ear => num * 0.6, 
				ContactType.Neck => num * 0.65, 
				ContactType.Chest => num * 0.6, 
				ContactType.Milk => num * 0.7, 
				ContactType.Crotch => num * 0.65, 
				ContactType.Anal => num * 0.8, 
				ContactType.Vagina => num * 0.85, 
				ContactType.Sex => num * 0.9, 
				ContactType.Nucleus => num * 1.1, 
				ContactType.Awareness => num * 1.1, 
				_ => 0.0, 
			};
		}
	}

	public static double 部位値
	{
		get
		{
			double num = 0.0;
			if (CurrentContactType != 0)
			{
				num = 部位感度[CurrentContactType];
			}
			return (num + 性感補正値).Clamp(0.0, 1.0);
		}
	}

	public static double アクション値 => CurrentActionType switch
	{
		ActionType.くぱ => 0.1, 
		ActionType.Shaving => 0.15, 
		ActionType.Contact => 0.25, 
		ActionType.Tickle => 0.3, 
		ActionType.Licking => 0.45, 
		ActionType.吸引 => 0.5, 
		ActionType.乳捏 => 0.6, 
		ActionType.パイ => 0.6, 
		ActionType.Grope => 0.65, 
		ActionType.Milk => 0.7, 
		ActionType.核捏 => 0.75, 
		ActionType.Insertion => 0.8 + ((CurrentContactType == ContactType.Vagina) ? Wetness : Excitement) * 0.2, 
		ActionType.Whipping => 1.0, 
		_ => 0.0, 
	};

	public static double アイテム値
	{
		get
		{
			switch (CurrentToolType)
			{
			case ToolType.Ｔ剃刀:
				return 0.1;
			case ToolType.Hand:
				return 0.2;
			case ToolType.羽根箒:
				return 0.25;
			case ToolType.マウス:
				return 0.3;
			case ToolType.ロータ:
				return 0.3;
			case ToolType.キャプ:
				return 0.3;
			case ToolType.Dildo:
				return 0.35;
			case ToolType.Penis:
				return 0.4;
			case ToolType.Vibrator:
				return 0.45;
			case ToolType.Drill:
				return 0.5;
			case ToolType.デンマ:
				return 0.9;
			case ToolType.調教鞭:
				return 1.0;
			case ToolType.パール:
				if (CurrentContactType != ContactType.Anal)
				{
					return 0.2;
				}
				return 0.4;
			case ToolType.AnalVibrator:
				if (CurrentContactType != ContactType.Anal)
				{
					return 0.35;
				}
				return 0.7;
			default:
				return 0.0;
			}
		}
	}

	public static double 慣れ値
	{
		get
		{
			double num = 0.5.Sqrt();
			double num2 = 1.0 - num;
			return (num + num2 * 奴隷接触慣れ.Inverse()) * (num + num2 * 奴隷アクション慣れ.Inverse());
		}
	}

	private static double 感度興奮差 => (Sensitivity - Excitement).Abs().Inverse();

	public static double 刺激値 => 部位値 * 慣れ値 * アイテム値 * アクション値 * (double)強さn * 感度興奮差 * 発情1_5w;

	public static double 拘束具補正増
	{
		get
		{
			if (!Cha.Bod.拘束具_表示)
			{
				return 1.0;
			}
			return 1.3;
		}
	}

	public static double 拘束具補正減
	{
		get
		{
			if (!Cha.Bod.拘束具_表示)
			{
				return 1.0;
			}
			return 1.3.Reciprocal();
		}
	}

	public static double 目隠帯補正増
	{
		get
		{
			if (!Cha.Bod.目隠帯_表示)
			{
				return 1.0;
			}
			return 1.3;
		}
	}

	public static double 目隠帯補正減
	{
		get
		{
			if (!Cha.Bod.目隠帯_表示)
			{
				return 1.0;
			}
			return 1.3.Reciprocal();
		}
	}

	public static double 玉口枷補正増
	{
		get
		{
			if (!Cha.Bod.玉口枷_表示)
			{
				return 1.0;
			}
			return 1.3;
		}
	}

	public static double 玉口枷補正減
	{
		get
		{
			if (!Cha.Bod.玉口枷_表示)
			{
				return 1.0;
			}
			return 1.3.Reciprocal();
		}
	}

	public static double 奴感度確率
	{
		get
		{
			switch (CurrentActionType)
			{
			case ActionType.Grope:
				return 0.3;
			case ActionType.乳捏:
				return 0.3;
			case ActionType.核捏:
				return 0.4;
			case ActionType.Insertion:
				return 0.3;
			case ActionType.Contact:
				return 0.2 * Sensitivity.Inverse().Pow(2.0);
			case ActionType.Shaving:
				return 0.2 * Sensitivity.Inverse().Pow(2.0);
			case ActionType.パイ:
				if (パイズリRun)
				{
					return 0.6;
				}
				return 0.2;
			case ActionType.Tickle:
				return 0.6 * Sensitivity.Inverse().Pow(2.0);
			case ActionType.くぱ:
				return 0.2;
			case ActionType.吸引:
				return 0.6;
			case ActionType.Milk:
				return 0.35;
			case ActionType.Licking:
				return 0.6;
			case ActionType.Whipping:
				return 1.0;
			default:
				return 0.0;
			}
		}
	}

	public static bool 奉仕0
	{
		get
		{
			if (!絶頂中 && !Cha.Bod.Is拘束 && Pride == 0.0)
			{
				if (!(Lust > 0.5) && !(Affection > 0.5))
				{
					return Training > 0.5;
				}
				return true;
			}
			return false;
		}
	}

	public static bool 奉仕1
	{
		get
		{
			if (Pride == 0.0)
			{
				if (!(Lust > 0.5) && !(Affection > 0.5))
				{
					return Training > 0.5;
				}
				return true;
			}
			return false;
		}
	}

	public static bool 手コキ
	{
		get
		{
			if (Cha.Bod.Is最前手人 && 奉仕0)
			{
				return SkillL > 0.1 * Sta.GameData.TrainingTarget.MaxSkillL;
			}
			return false;
		}
	}

	public static bool 足コキ
	{
		get
		{
			if (奉仕0)
			{
				return SkillL > 0.2 * Sta.GameData.TrainingTarget.MaxSkillL;
			}
			return false;
		}
	}

	public static bool パイズリ1
	{
		get
		{
			if (Cha.Bod.Is最前手人 && 奉仕0)
			{
				return SkillL > 0.2 * Sta.GameData.TrainingTarget.MaxSkillL;
			}
			return false;
		}
	}

	public static bool パイズリ2
	{
		get
		{
			if (Cha.Bod.Is最前手人 && 奉仕0)
			{
				return SkillL > 0.4 * Sta.GameData.TrainingTarget.MaxSkillL;
			}
			return false;
		}
	}

	public static bool パイズリ3
	{
		get
		{
			if (Cha.Bod.Is最前手人 && 奉仕0)
			{
				return SkillL > 0.6 * Sta.GameData.TrainingTarget.MaxSkillL;
			}
			return false;
		}
	}

	public static bool フェラ1
	{
		get
		{
			if (奉仕1 && !Cha.Bod.玉口枷_表示)
			{
				return SkillL > 0.15 * Sta.GameData.TrainingTarget.MaxSkillL;
			}
			return false;
		}
	}

	public static bool フェラ2
	{
		get
		{
			if (!絶頂中 && 奉仕1 && !Cha.Bod.玉口枷_表示 && SkillL > 0.5 * Sta.GameData.TrainingTarget.MaxSkillL)
			{
				return CurrentToolType == ToolType.Penis;
			}
			return false;
		}
	}

	public static double 口挿入度 => (0.05 + 部位感度[ContactType.Mouth] * Tension.Inverse() * (SkillL / Sta.GameData.TrainingTarget.MaxSkillL)).Sqrt();

	public static double 膣挿入度 => (0.05 + 部位感度[ContactType.Vagina] * Tension.Inverse() * Wetness).Sqrt();

	public static double 肛挿入度 => (0.05 + 部位感度[ContactType.Anal] * Tension.Inverse()).Sqrt();

	public static double 糸挿入度 => (0.05 + 部位感度[ContactType.Thread] * Tension.Inverse()).Sqrt();

	public static bool 手口 => 口挿入度 >= 0.6;

	public static bool 手膣
	{
		get
		{
			if (!Virgin)
			{
				return 膣挿入度 >= 0.6;
			}
			return false;
		}
	}

	public static bool 手肛 => 肛挿入度 >= 0.6;

	public static bool 手糸 => 糸挿入度 >= 0.6;

	public static double 変化V_射精 => PlayerStamina * PlayerExcitement;

	public static double 変化V_潮吹 => System.Math.Max(Lust, Sensitivity * Excitement);

	public static double 変化V_放尿 => System.Math.Max(System.Math.Max(Lust, Training), Excitement * Shame.Inverse());

	public static double 変化V_口 => 口挿入度;

	public static double 変化V_膣 => 膣挿入度;

	public static double 変化V_肛 => 肛挿入度;

	public static double 変化V_糸 => 糸挿入度;

	public static double 変化V_固有値乱数 => Cha.ChaD.固有値 * RNG.XS.NextDouble();

	public static double 無毛1_5w
	{
		get
		{
			if (!Hairless)
			{
				return 1.5 * 現陰毛.Inverse().Clamp(0.1, 1.0);
			}
			return 1.5;
		}
	}

	public static double 処女0_8w
	{
		get
		{
			if (!Virgin)
			{
				return 1.0;
			}
			return 0.8;
		}
	}

	public static double 処女1_5w
	{
		get
		{
			if (!Virgin)
			{
				return 1.0;
			}
			return 1.5;
		}
	}

	public static double 発情0_5w
	{
		get
		{
			if (!発情)
			{
				return 1.0;
			}
			return 0.5;
		}
	}

	public static double 発情1_5w
	{
		get
		{
			if (!発情)
			{
				return 1.0;
			}
			return 1.5;
		}
	}

	public static double 強靭0_7w
	{
		get
		{
			if (!Muscular)
			{
				return 1.0;
			}
			return 0.7;
		}
	}

	public static double 傷物0_8w
	{
		get
		{
			if (!Scars)
			{
				return 1.0;
			}
			return 0.8;
		}
	}

	public static double 傷物1_2w
	{
		get
		{
			if (!Scars)
			{
				return 1.0;
			}
			return 1.2;
		}
	}

	public static double 調教済0_9w
	{
		get
		{
			if (!Trained)
			{
				return 1.0;
			}
			return 0.9;
		}
	}

	public static double 調教済1_1w
	{
		get
		{
			if (!Trained)
			{
				return 1.0;
			}
			return 1.1;
		}
	}

	public static bool Is性器接触
	{
		get
		{
			if (CurrentContactType != ContactType.Crotch && CurrentContactType != ContactType.Sex && CurrentContactType != ContactType.Nucleus)
			{
				return CurrentContactType == ContactType.Vagina;
			}
			return true;
		}
	}

	public static void RecoverPlayerStamina()
	{
		PlayerStamina = (PlayerStamina + (0.05 + PlayerStamina * RNG.XS.NextDouble())).Clamp(0.0, 1.0);
	}

	public static void RecoverStamina(this Unit u)
	{
		u.ChaD.Stamina = (u.ChaD.Stamina + (0.05 + u.ChaD.Stamina * RNG.XS.NextDouble())).Clamp(0.0, 1.0);
	}

	public static void 体力消費(this Unit u)
	{
		u.ChaD.Stamina = (u.ChaD.Stamina - 0.5 * RNG.XS.NextDouble() * u.消耗乗算値).Clamp(0.0, 1.0);
	}

	public static void SetState()
	{
		Sensitivity = (1.0 * Pride.Inverse() * Lust * Affection * RNG.XS.NextDouble()).Clamp(0.0, 1.0);
		Excitement = (1.0 * Pride.Inverse() * Lust * Affection * RNG.XS.NextDouble()).Clamp(0.0, 1.0);
		Wetness = (2.0 * Pride.Inverse() * Lust * Affection).Clamp(0.0, 1.0);
		Tension = (2.0 * Pride * Lust.Inverse() * Affection.Inverse()).Clamp(0.0, 1.0);
		Shame = (1.0 * Pride.Inverse() * Affection).Clamp(0.0, 1.0);
	}

	public static void SetStateTraining()
	{
		if (Sta.GameData.TrainingTarget != null && Cha != null)
		{
			RecoverPlayerStamina();
			Sta.GameData.TrainingTarget.RecoverStamina();
			PlayerSensitivity = 0.0;
			PlayerExcitement = 0.0;
			SetState();
			PreTrainingPride = Pride;
			PreTrainingLust = Lust;
			PreTrainingAffection = Affection;
			PreTrainingTraining = Training;
			PreTrainingSkillL = SkillL;
			調教前調教力 = 調教力;
			Hairless = Sta.GameData.TrainingTarget.Hairless;
			Virgin = Sta.GameData.TrainingTarget.Virgin;
			発情 = Sta.GameData.TrainingTarget.発情フラグ;
			Pregnant = Sta.GameData.TrainingTarget.Pregnant;
			Muscular = Sta.GameData.TrainingTarget.Muscular;
			Scars = Sta.GameData.TrainingTarget.Scars;
			Trained = Sta.GameData.TrainingTarget.Trained;
			絶頂回数 = 0;
			初回 = true;
			反応度 = 1.0;
			Cha.SetInitialAngle();
			Cha.SetInitialExpression();
			Cha.SetInitialPosture();
			Cha.Emotion();
			Cha.UpdateExpression();
			Cha.UpdatePosture();
			Cha.Bod.処女喪失 = false;
			Cha.Bod.膣内精液.血液1_表示 = false;
			Cha.Bod.膣内精液.血液2_表示 = false;
			Cha.Bod.性器精液.血液1_表示 = false;
			Cha.Bod.性器精液.血液2_表示 = false;
			Cha.Bod.飛沫濃度 = 0.0;
			Cha.Bod.潮染み濃度 = 0.0;
			Cha.Bod.尿染み濃度 = 0.0;
			Cha.Bod.湯気左濃度 = 0.0;
			Cha.Bod.湯気右濃度 = 0.0;
			放尿率 = 1.0;
			Cha.Bod.噴乳左.母乳垂れ1_表示 = false;
			Cha.Bod.噴乳左.母乳垂れ2_表示 = false;
			Cha.Bod.噴乳右.母乳垂れ1_表示 = false;
			Cha.Bod.噴乳右.母乳垂れ2_表示 = false;
			表示ステート更新();
			強制終了 = false;
			ModBox();
			SensBox();
		}
	}

	public static void Result1()
	{
		UI.ip.TextIm = GameText.抵抗値 + " -" + (PreTrainingPride - Pride).Numf2() + "\r\n" + GameText.欲望度 + " +" + (Lust - PreTrainingLust).Numf2() + " " + GameText.情愛度 + " + " + (Affection - PreTrainingAffection).Numf2() + "\r\n" + GameText.卑屈度 + " +" + (Training - PreTrainingTraining).Numf2() + " " + GameText.技巧度 + " + " + (SkillL - PreTrainingSkillL).Numf2() + "\r\n\r\n" + GameText.調教力 + " +" + (調教力 - 調教前調教力).Numf2();
	}

	public static void Result2()
	{
		UI.ip.TextIm = GameText.抵抗値 + Pride.Numf2() + "\r\n" + GameText.欲望度 + Lust.Numf2() + " " + GameText.情愛度 + Affection.Numf2() + "\r\n" + GameText.卑屈度 + Training.Numf2() + " " + GameText.技巧度 + SkillL.Numf2() + "\r\n\r\n" + GameText.調教力 + 調教力.Numf2();
		Cha.Bod.変動ステート更新();
	}

	public static void アクション入力(ContactType contactType, ActionType actionType, CurrentState タイミング情報, ToolType toolType, int 挿入Lv, int 強さ, bool 機械, bool 射精)
	{
		接触o = CurrentContactType;
		アクション情報o = CurrentActionType;
		タイミング情報o = タイミング情報n;
		アイテム情報o = CurrentToolType;
		挿入Lvo = 挿入Lvn;
		強さo = 強さn;
		機械o = 機械n;
		射精o = 射精n;
		CurrentContactType = contactType;
		CurrentActionType = actionType;
		タイミング情報n = タイミング情報;
		CurrentToolType = toolType;
		挿入Lvn = 挿入Lv;
		強さn = 強さ;
		機械n = 機械;
		射精n = 射精;
		if (加算前提)
		{
			奴隷ゲージ上昇();
			if (toolType == ToolType.Penis)
			{
				主人ゲージ上昇();
			}
			Reaction0();
		}
	}

	public static void 自コキ処理()
	{
		if (加算前提)
		{
			CurrentActionType = ActionType.none;
			射精n = false;
			主人ゲージ上昇();
		}
	}

	public static void 主人ゲージ上昇()
	{
		主感度加算();
		射精直前処理();
		射精開始処理();
		if (!射精n)
		{
			射精処理();
		}
	}

	public static void 奴隷ゲージ上昇()
	{
		慣れ計算();
		部位計算();
		緊張計算();
		羞恥計算();
		潤滑計算();
		感度加算();
		欲望度計算();
		情愛度計算();
		卑屈度計算();
		技巧度計算();
		抵抗値計算();
		調教力計算();
		絶頂直前処理();
		絶頂開始処理();
	}

	public static void 調教強制終了()
	{
		if (Stamina == 0.0 || PlayerStamina == 0.0)
		{
			UI.ip.MaiShow = true;
			強制終了 = true;
			UI.ip.TextIm = GameText.体力が限界です調教を終了します;
		}
	}

	public static void 調教終了時()
	{
	}

	public static void 絶頂直前処理()
	{
		if (絶頂中 || !(Sensitivity > 0.85))
		{
			return;
		}
		if (0.1.Lot())
		{
			Cha.UpdateExpression();
		}
		if (0.1.Lot())
		{
			Cha.UpdatePosture();
		}
		if (0.05.Lot())
		{
			if (Cha.Bod.Is双眉)
			{
				Cha.両眉_0(RNG.XS.NextBool(), RNG.XS.NextM(3, 4), RNG.XS.NextM(3, 4));
			}
			if (Cha.Bod.Is単眉)
			{
				Cha.単眉_顰();
			}
		}
		if (0.015.Lot())
		{
			発声();
		}
	}

	public static void 絶頂開始処理()
	{
		if (絶頂中 || !(Sensitivity >= 1.0))
		{
			return;
		}
		絶頂中 = true;
		double value = 4.0 * Excitement * Tension.Inverse() * Shame * Pride.Inverse() * Lust * Affection;
		Cha.絶頂激しさ = value.Clamp(0.0, 1.0);
		Cha.絶頂時間 = value.Clamp(0.0, 0.85);
		UI.絶頂ゲージ点滅.Start();
		Cha.絶頂.Start();
		if (UI.ペニス処理.手コキ.Run)
		{
			UI.ペニス処理.手コキ.End();
		}
		if (UI.ペニス処理.足コキ.Run)
		{
			UI.ペニス処理.足コキ.End();
		}
		if (UI.ペニス処理.パイズリ.Run)
		{
			UI.ペニス処理.パイズリ.End();
		}
		if (UI.ペニス処理.フェラ.Run)
		{
			UI.ペニス処理.フェラ.End();
		}
		絶頂回数++;
		初回 = true;
		Reaction0();
		if (0.05.Lot())
		{
			if (Cha.Bod.Is双眉)
			{
				Cha.両眉_0(RNG.XS.NextBool(), RNG.XS.NextM(3, 4), RNG.XS.NextM(3, 4));
			}
			if (Cha.Bod.Is単眉)
			{
				Cha.単眉_顰();
			}
		}
	}

	public static void 絶頂中処理()
	{
		if (!加算前提)
		{
			return;
		}
		絶頂部位計算();
		絶頂欲望度計算();
		絶頂情愛度計算();
		絶頂卑屈度計算();
		絶頂抵抗値計算();
		調教力計算();
		if (0.1.Lot())
		{
			Cha.UpdateExpression();
		}
		if (絶頂回数 > 1 && Lust > 0.6 && 0.1.Lot())
		{
			if (Cha.Bod.Is双眼)
			{
				Cha.目_上転左();
				Cha.目_上転右();
			}
			if (Cha.Bod.Is単眼)
			{
				Cha.単目_上転();
			}
			if (Cha.Bod.Is頬眼)
			{
				Cha.頬目_上転左();
				Cha.頬目_上転右();
			}
			if (Cha.Bod.Is額眼)
			{
				Cha.額目_上転();
			}
		}
		if (RNG.XS.NextBool())
		{
			if (0.1.Lot())
			{
				if (Cha.Bod.Is双眼)
				{
					Cha.瞼_瞑左();
					Cha.瞼_瞑右();
				}
				if (Cha.Bod.Is単眼)
				{
					Cha.単瞼_瞑();
				}
				if (Cha.Bod.Is頬眼)
				{
					Cha.頬瞼_瞑左();
					Cha.頬瞼_瞑右();
				}
				if (Cha.Bod.Is額眼)
				{
					Cha.額瞼_瞑();
				}
			}
		}
		else if (0.1.Lot())
		{
			if (Cha.Bod.Is双眼)
			{
				Cha.瞼_半1左();
				Cha.瞼_半1右();
			}
			if (Cha.Bod.Is単眼)
			{
				Cha.単瞼_半1();
			}
			if (Cha.Bod.Is頬眼)
			{
				Cha.頬瞼_半1左();
				Cha.頬瞼_半1右();
			}
			if (Cha.Bod.Is額眼)
			{
				Cha.額瞼_半1();
			}
		}
		if (手膣 && Stamina > 0.1 && Wetness > 0.6 && Tension == 0.0 && Lust > 0.7 && Affection > 0.7 && (Excitement * 0.05).Lot())
		{
			Cha.潮吹大.Start();
		}
		else if (Wetness > 0.5 && Tension == 0.0 && Lust > 0.5 && Affection > 0.5 && (Excitement * 0.05).Lot())
		{
			Cha.潮吹小.Start();
		}
		if (Cha.Crying && Cha.Bod.舌_表示 && (Cha.絶頂激しさ * 0.0008).Lot())
		{
			Cha.鼻水.Start();
		}
		if ((Cha.Bod.舌_表示 || Cha.Bod.玉口枷_表示) && (Cha.絶頂激しさ * 0.001).Lot())
		{
			Cha.涎.Start();
		}
		if (0.05.Lot())
		{
			if (Cha.Bod.Is双眉)
			{
				Cha.両眉_0(RNG.XS.NextBool(), RNG.XS.NextM(3, 4), RNG.XS.NextM(3, 4));
			}
			if (Cha.Bod.Is単眉)
			{
				Cha.単眉_顰();
			}
		}
		if (0.01.Lot())
		{
			発声();
		}
	}

	public static void 絶頂終了処理()
	{
		if (加算前提)
		{
			絶頂終了処理_();
			if (Cha.Bod.くぱぁ0 > 0.5 && (0.1 + 放尿率 * 放尿経験値 * Tension.Inverse() * 0.5).Lot())
			{
				Cha.放尿.Start();
				放尿率 = (放尿率 - 0.1).Clamp(0.0, 1.0);
				放尿経験値 = (放尿経験値 + 0.03 * RNG.XS.NextDouble()).Clamp(0.0, 1.0);
			}
			発声();
		}
	}

	public static void 絶頂終了処理_()
	{
		UI.絶頂ゲージ点滅.End();
		絶頂中 = false;
		Sensitivity -= Cha.絶頂激しさ.Inverse() * 0.5;
		Excitement -= Cha.絶頂激しさ.Inverse() * 0.5;
	}

	public static void 射精処理()
	{
		if (射精中 && (PlayerStamina * 0.05).Lot())
		{
			UI.ペニス処理.精液発射();
		}
	}

	public static void 射精直前処理()
	{
		if (射精中 || !(PlayerSensitivity > 0.85) || (CurrentActionType != ActionType.手コ && CurrentActionType != ActionType.パイ) || !(Lust > 0.6) || !(SkillL > 0.5 * Sta.GameData.TrainingTarget.MaxSkillL))
		{
			return;
		}
		if (((SkillL + Lust) * 0.05).Lot())
		{
			if (Cha.Bod.Is双眼)
			{
				Cha.目_見つめ左();
				Cha.目_見つめ右();
			}
			if (Cha.Bod.Is頬眼)
			{
				Cha.頬目_見つめ左();
				Cha.頬目_見つめ右();
			}
			if (Cha.Bod.Is単眼)
			{
				Cha.単目_見つめ();
			}
			if (Cha.Bod.Is額眼)
			{
				Cha.額目_見つめ();
			}
		}
		if (!Cha.Bod.玉口枷_表示 && !Cha.Bod.舌_表示 && ((SkillL + Lust) * 0.05).Lot())
		{
			Cha.口_開き();
			Cha.舌_出し();
		}
	}

	public static void 射精開始処理()
	{
		if (加算前提 && !射精中 && PlayerSensitivity >= 1.0)
		{
			射精中 = true;
			double 射精時間 = (1.1 * PlayerExcitement * 技巧度影響値).Clamp(0.0, 0.85);
			UI.ペニス処理.射精時間 = 射精時間;
			UI.射精ゲージ点滅.Start();
			UI.ペニス処理.射精終了.Start();
		}
	}

	public static void 射精中処理()
	{
		if (!加算前提)
		{
			return;
		}
		if (CurrentActionType != 0)
		{
			絶頂技巧度計算();
		}
		if ((CurrentActionType != ActionType.手コ && CurrentActionType != ActionType.パイ) || !(Lust > 0.6) || !(SkillL > 0.5 * Sta.GameData.TrainingTarget.MaxSkillL))
		{
			return;
		}
		if (((SkillL + Lust) * 0.05).Lot())
		{
			if (Cha.Bod.Is双眼)
			{
				Cha.目_見つめ左();
				Cha.目_見つめ右();
			}
			if (Cha.Bod.Is頬眼)
			{
				Cha.頬目_見つめ左();
				Cha.頬目_見つめ右();
			}
			if (Cha.Bod.Is単眼)
			{
				Cha.単目_見つめ();
			}
			if (Cha.Bod.Is額眼)
			{
				Cha.額目_見つめ();
			}
		}
		if (!Cha.Bod.玉口枷_表示 && !Cha.Bod.舌_表示 && ((SkillL + Lust) * 0.05).Lot())
		{
			Cha.口_開き();
			Cha.舌_出し();
		}
	}

	public static void 射精終了処理()
	{
		if (加算前提)
		{
			射精終了処理_();
		}
	}

	public static void 射精終了処理_()
	{
		UI.射精ゲージ点滅.End();
		射精中 = false;
		PlayerSensitivity -= UI.ペニス処理.射精時間.Inverse() * 0.6;
		PlayerExcitement -= UI.ペニス処理.射精時間.Inverse() * 0.6;
	}

	public static void 中出し処理()
	{
		if (加算前提)
		{
			if (CurrentContactType != ContactType.Mouth)
			{
				潤滑計算();
			}
			欲望度計算();
			情愛度計算();
			if (CurrentContactType == ContactType.Vagina && !Sta.GameData.TrainingTarget.Pregnant)
			{
				Sta.GameData.TrainingTarget.Pregnant = (0.04 * 調教力 + 0.01 * 発情1_5w * ((Sta.GameData.TrainingTarget.Race == GameText.エキドナ) ? 2.0 : 1.0)).Lot();
			}
		}
	}

	public static void ぶっかけ処理()
	{
		if (!加算前提)
		{
			return;
		}
		羞恥計算();
		卑屈度計算();
		if (CurrentContactType != ContactType.Head && CurrentContactType != ContactType.Face && CurrentContactType != ContactType.Hair && CurrentContactType != ContactType.Mouth)
		{
			return;
		}
		if (0.7.Lot())
		{
			if (Cha.Bod.Is双眼)
			{
				Cha.瞼_瞑左();
				Cha.瞼_瞑右();
			}
			if (Cha.Bod.Is単眼)
			{
				Cha.単瞼_瞑();
			}
			if (Cha.Bod.Is頬眼)
			{
				Cha.頬瞼_瞑左();
				Cha.頬瞼_瞑右();
			}
			if (Cha.Bod.Is額眼)
			{
				Cha.額瞼_瞑();
			}
		}
		else
		{
			if (Cha.Bod.Is双眼)
			{
				Cha.瞼_半2左();
				Cha.瞼_半2右();
			}
			if (Cha.Bod.Is単眼)
			{
				Cha.単瞼_半2();
			}
			if (Cha.Bod.Is頬眼)
			{
				Cha.頬瞼_半2左();
				Cha.頬瞼_半2右();
			}
			if (Cha.Bod.Is額眼)
			{
				Cha.額瞼_半2();
			}
		}
	}

	public static void 主精力消費大()
	{
		if (加算前提)
		{
			double num = 0.02;
			PlayerStamina = (PlayerStamina - (num * 0.11 + num * 1.5 * 主消費影響値)).Clamp(0.0, 1.0);
		}
		調教強制終了();
	}

	public static void 主精力消費小()
	{
		if (加算前提)
		{
			double num = 0.0004;
			PlayerStamina = (PlayerStamina - (num * 0.11 + num * 1.5 * 主消費影響値)).Clamp(0.0, 1.0);
		}
		調教強制終了();
	}

	public static void 奴体力消費大()
	{
		if (加算前提)
		{
			double num = 0.02 * (1.0 - 0.6 * 調教力);
			Stamina = (Stamina - (num + num * ((奴隷a + Pride + Tension) / 3.0) * 奴消費影響値 + num * (機械n ? 刺激値 : 0.0) * 奴消費影響値)).Clamp(0.0, 1.0);
			調教強制終了();
		}
	}

	public static void 奴体力消費中()
	{
		if (加算前提)
		{
			double num = 0.01 * (1.0 - 0.6 * 調教力);
			Stamina = (Stamina - (num + num * ((奴隷a + Pride + Tension) / 3.0) * 奴消費影響値 + num * (機械n ? 刺激値 : 0.0) * 奴消費影響値)).Clamp(0.0, 1.0);
			調教強制終了();
		}
	}

	public static void 奴体力消費小()
	{
		if (加算前提)
		{
			double num = 0.0004 * (1.0 - 0.6 * 調教力);
			Stamina = (Stamina - (num + num * ((奴隷a + Pride + Tension) / 3.0) * 奴消費影響値 + num * (機械n ? 刺激値 : 0.0) * 奴消費影響値)).Clamp(0.0, 1.0);
			調教強制終了();
		}
	}

	public static void 主回復()
	{
		PlayerStamina = (PlayerStamina + ((Sta.GameData.祝福 != null) ? Sta.GameData.祝福.回復値 : 0.0)).Clamp(0.0, 1.0);
	}

	public static void 主感度加算()
	{
		double num = 0.0025;
		double num2 = 0.0095 - num;
		主人ao = 主人a;
		主人a = num + num2 * 主刺激値 * 主射精値 * 技巧度影響値;
		if (主感度確率.Lot())
		{
			PlayerSensitivity = (PlayerSensitivity + 主人a).Clamp(0.0, 1.0);
		}
	}

	public static void 主感度減算()
	{
		double num = 0.0003;
		PlayerSensitivity = (PlayerSensitivity - (num + 主人a * PlayerSensitivity * PlayerExcitement.Inverse() * 技巧度影響値.Inverse())).Clamp(0.0, 1.0);
	}

	public static void 主興奮計算()
	{
		double num = 0.0025;
		double num2 = 0.05 - num;
		PlayerExcitement = (PlayerExcitement + (PlayerSensitivity - PlayerExcitement) * (num + num2 * 主興奮値 * 技巧度影響値)).Clamp(0.0, 1.0);
	}

	public static void 主興奮計算2()
	{
		if (Excitement > PlayerExcitement)
		{
			double num = 0.0025;
			double num2 = 0.05 - num;
			PlayerExcitement = (PlayerExcitement + (Excitement - PlayerExcitement) * (num + num2 * 主興奮値 * 技巧度影響値)).Clamp(0.0, 1.0);
		}
	}

	public static void 回復()
	{
		Stamina = (Stamina + Sta.GameData.TrainingTarget.回復値).Clamp(0.0, 1.0);
	}

	public static void 慣れ計算()
	{
		double num = 0.0001;
		double num2 = 0.0005 - num;
		if (接触o == CurrentContactType && 強さo == 強さn)
		{
			奴隷接触慣れ = (奴隷接触慣れ + (num + num2 * Cha.ChaD.固有値 * 調教力.Inverse())).Clamp(0.0, 1.0);
		}
		else
		{
			奴隷接触慣れ = 0.0;
		}
		if (アクション情報o == CurrentActionType && 強さo == 強さn)
		{
			奴隷アクション慣れ = (奴隷アクション慣れ + (num + num2 * Cha.ChaD.固有値 * 調教力.Inverse())).Clamp(0.0, 1.0);
		}
		else
		{
			奴隷アクション慣れ = 0.0;
		}
	}

	public static void 感度加算()
	{
		double num = 0.0025;
		double num2 = 0.005 - num;
		奴隷ao = 奴隷a;
		奴隷a = num + num2 * 刺激値 * 感度値 * 調教力影響値;
		if (機械n)
		{
			奴隷a *= (Pride * 調教力影響値.Inverse()).Inverse();
		}
		奴隷a -= 奴隷a * Sensitivity * (Pride + Tension) * 調教力.Inverse();
		if (奴感度確率.Lot())
		{
			Sensitivity = (Sensitivity + 奴隷a * 奉仕補正).Clamp(0.0, 1.0);
		}
	}

	public static void 感度減算()
	{
		double num = 0.0003;
		Sensitivity = (Sensitivity - (num + 奴隷a * Sensitivity * Excitement.Inverse() * 調教力影響値.Inverse())).Clamp(0.0, 1.0);
	}

	public static void 興奮計算()
	{
		double num = 0.0025;
		double num2 = 0.05 - num;
		Excitement = (Excitement + (Sensitivity - Excitement) * (num + num2 * 興奮値 * 調教力影響値)).Clamp(0.0, 1.0);
	}

	public static void 興奮計算2()
	{
		if (PlayerExcitement > Excitement)
		{
			double num = 0.0025;
			double num2 = 0.05 - num;
			Excitement = (Excitement + (PlayerExcitement - Excitement) * (num + num2 * 興奮値 * 調教力影響値)).Clamp(0.0, 1.0);
		}
	}

	public static void 潤滑計算()
	{
		double num = 2E-05;
		double num2 = 0.3 - num;
		if (CurrentContactType == ContactType.Vagina && CurrentActionType == ActionType.Insertion)
		{
			Wetness = (Wetness + (0.0005 + num2 * 奴隷a * 潤滑値)).Clamp(0.0, 1.0);
		}
		Wetness = (Wetness + (num + num2 * 奴隷a * 潤滑値)).Clamp(0.0, 1.0);
	}

	public static bool 苦痛条件(this Cha c)
	{
		if ((!機械n || !(c.ChaD.Lust < 0.5) || !(c.ChaD.Affection < 0.5)) && (CurrentActionType != ActionType.Whipping || !(c.ChaD.Lust < 0.65)))
		{
			if (CurrentActionType == ActionType.Insertion)
			{
				if (!(c.ChaD.Wetness < 0.5) && !Virgin)
				{
					if (CurrentContactType != 0)
					{
						return c.ChaD.Sesnsitivities[CurrentContactType] < 0.5;
					}
					return false;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	public static void 緊張計算()
	{
		double num = 1E-05;
		double num2 = 0.3 - num;
		if (0.5.Lot())
		{
			Tension = (Tension + 2E-05 * Pride).Clamp(0.0, 1.0);
		}
		if (Cha.苦痛条件())
		{
			Tension = (Tension + (num + num2 * 奴隷a * 緊張値.Inverse() * 調教力影響値.Inverse())).Clamp(0.0, 1.0);
		}
		else if (CurrentActionType == ActionType.Tickle)
		{
			Tension = (Tension - (num + num2 * 奴隷a * 緊張値 * 調教力影響値 * 4.5) * ((CurrentToolType == ToolType.羽根箒) ? 2.0 : 1.0)).Clamp(0.0, 1.0);
		}
		if (CurrentToolType == ToolType.Hand || CurrentToolType == ToolType.マウス || CurrentToolType == ToolType.Penis)
		{
			Tension = (Tension - (num + num2 * 奴隷a * 緊張値 * 調教力影響値 * 0.5)).Clamp(0.0, 1.0);
		}
	}

	public static void 羞恥計算()
	{
		double num = 7.5E-05;
		double num2 = 0.4 - num;
		if (CurrentActionType == ActionType.くぱ)
		{
			Shame = (Shame + (num + num2 * 奴隷a * 羞恥値 * 調教力影響値 * RNG.XS.NextDouble())).Clamp(0.0, 1.0);
		}
		else if (CurrentActionType == ActionType.Shaving)
		{
			Shame = (Shame + (num + num2 * 奴隷a * 羞恥値 * 調教力影響値 * 現陰毛 * 4.0)).Clamp(0.0, 1.0);
		}
		Shame = (Shame + (num + num2 * 奴隷a * 羞恥値 * 調教力影響値 * RNG.XS.NextDouble())).Clamp(0.0, 1.0);
	}

	public static void 調教力計算()
	{
		if (!機械n)
		{
			double num = 1E-05;
			double num2 = 2E-05 - num;
			調教力 = (調教力 + (num + num2 * 奴隷a * 感度興奮差 * 調教力影響値)).Clamp(0.0, 1.0);
		}
	}

	public static void 部位計算()
	{
		if (CurrentContactType != 0)
		{
			部位感度[CurrentContactType] = (部位感度[CurrentContactType] + 0.015 * 奴隷a * 調教力影響値 * 発情1_5w * 調教済1_1w).Clamp(0.0, 1.0);
		}
		if (Cha.Bod.玉口枷_表示 && 部位感度.ContainsKey(ContactType.Mouth))
		{
			部位感度[ContactType.Mouth] = (部位感度[ContactType.Mouth] + 0.005 * 奴隷a * 調教力影響値 * 発情1_5w * 調教済1_1w).Clamp(0.0, 1.0);
		}
	}

	public static void 抵抗値計算()
	{
		Pride = (Pride - 0.02 * 奴隷a * Training * 調教力影響値 * 処女0_8w * 発情1_5w * 傷物0_8w).Clamp(0.0, 1.0);
	}

	public static void 欲望度計算()
	{
		Lust = (Lust + 0.0075 * 奴隷a * 調教力影響値 * 処女0_8w * 発情1_5w * 調教済1_1w * 目隠帯補正増).Clamp(0.0, 1.0);
	}

	public static void 情愛度計算()
	{
		if (CurrentToolType == ToolType.Hand || CurrentToolType == ToolType.マウス || CurrentToolType == ToolType.Penis || Affection > 0.5)
		{
			Affection = (Affection + 0.015 * 奴隷a * 調教力影響値 * 処女1_5w * 傷物1_2w * 調教済1_1w * 拘束具補正減 * 目隠帯補正減 * 玉口枷補正減).Clamp(0.0, 1.0);
		}
	}

	public static void 卑屈度計算()
	{
		if (CurrentActionType == ActionType.Whipping)
		{
			Training = (Training + 0.5 * 奴隷a * 調教力影響値 * 傷物1_2w * 拘束具補正増 * 玉口枷補正増).Clamp(0.0, 1.0);
		}
		if ((0.1 * RNG.XS.NextDouble() * Cha.ChaD.固有値).Lot())
		{
			Training = (Training + 0.2 * 奴隷a * 調教力影響値 * 傷物1_2w * 拘束具補正増 * 玉口枷補正増).Clamp(0.0, 1.0);
		}
		Training = (Training + 0.0005 * 奴隷a * 調教力影響値 * 傷物1_2w * 拘束具補正増 * 玉口枷補正増).Clamp(0.0, 1.0);
		if (CurrentContactType == ContactType.Anal)
		{
			Training = (Training + 0.0005 * 奴隷a * 調教力影響値 * 傷物1_2w * 拘束具補正増 * 玉口枷補正増).Clamp(0.0, 1.0);
		}
	}

	public static void 技巧度計算()
	{
		if ((CurrentActionType == ActionType.Insertion && CurrentToolType == ToolType.Penis) || CurrentActionType == ActionType.パイ || CurrentActionType == ActionType.手コ || CurrentActionType == ActionType.足コ)
		{
			SkillL = (SkillL + 0.0035 * 主人a * 調教力影響値).Clamp(0.0, Sta.GameData.TrainingTarget.MaxSkillL);
		}
	}

	public static void 絶頂部位計算()
	{
		if (CurrentContactType != 0)
		{
			部位感度[CurrentContactType] = (部位感度[CurrentContactType] + 0.03 * 奴隷a * 感度興奮差 * 調教力影響値 * 発情1_5w * 調教済1_1w * RNG.XS.NextDouble()).Clamp(0.0, 1.0);
		}
		if (Cha.Bod.玉口枷_表示 && 部位感度.ContainsKey(ContactType.Mouth))
		{
			部位感度[ContactType.Mouth] = (部位感度[ContactType.Mouth] + 0.01 * 奴隷a * 調教力影響値 * 発情1_5w * 調教済1_1w).Clamp(0.0, 1.0);
		}
	}

	public static void 絶頂抵抗値計算()
	{
		Pride = (Pride - 0.04 * 奴隷a * 感度興奮差 * 調教力影響値 * 処女0_8w * 発情1_5w * RNG.XS.NextDouble()).Clamp(0.0, 1.0);
	}

	public static void 絶頂欲望度計算()
	{
		Lust = (Lust + 0.015 * 奴隷a * 感度興奮差 * 調教力影響値 * 処女0_8w * 発情1_5w * 調教済1_1w * 目隠帯補正増 * RNG.XS.NextDouble()).Clamp(0.0, 1.0);
	}

	public static void 絶頂情愛度計算()
	{
		Affection = (Affection + 0.03 * 奴隷a * 感度興奮差 * 調教力影響値 * 処女1_5w * 発情1_5w * 傷物1_2w * 調教済1_1w * 拘束具補正減 * 目隠帯補正減 * 玉口枷補正減 * RNG.XS.NextDouble()).Clamp(0.0, 1.0);
	}

	public static void 絶頂卑屈度計算()
	{
		Training = (Training + 0.001 * 奴隷a * 感度興奮差 * 調教力影響値 * 傷物1_2w * 拘束具補正増 * 玉口枷補正増 * RNG.XS.NextDouble()).Clamp(0.0, 1.0);
	}

	public static void 絶頂技巧度計算()
	{
		if ((CurrentActionType == ActionType.Insertion && CurrentToolType == ToolType.Penis) || CurrentActionType == ActionType.パイ || CurrentActionType == ActionType.手コ || CurrentActionType == ActionType.足コ)
		{
			SkillL = (SkillL + 0.007 * 主人a * 主感度興奮差 * 調教力影響値 * RNG.XS.NextDouble()).Clamp(0.0, Sta.GameData.TrainingTarget.MaxSkillL);
		}
	}

	public static void 表示ステート更新()
	{
		if (Sta.GameData.TrainingTarget == null)
		{
			return;
		}
		UI.体力sゲージ.Value = Stamina;
		UI.絶頂sゲージ.Value = Sensitivity;
		UI.興奮sゲージ.Value = Excitement;
		UI.精力mゲージ.Value = PlayerStamina;
		UI.射精mゲージ.Value = PlayerSensitivity;
		UI.興奮mゲージ.Value = PlayerExcitement;
		Cha.Bod.下着B染み = Wetness;
		Cha.Bod.陰核勃起 = Excitement;
		Cha.Bod.乳首勃起 = Excitement;
		Cha.Bod.顔紅潮 = Excitement.Max(Shame);
		Cha.Bod.体紅潮 = Excitement;
		Cha.呼吸速度 = 0.2 + 0.8 * Excitement;
		if (Lust > 0.5 && Affection > 0.5)
		{
			Cha.Bod.子宮下がり = Excitement;
		}
		if (Lust > 0.5 && 部位感度[ContactType.Anal] > 0.75)
		{
			Cha.Bod.肛門開き = Excitement;
		}
		if (Lust > 0.3)
		{
			if (!UI.ハンド処理.Isくぱぁ && (!UI.Is挿入 || UI.ハンド左.Xi == 7))
			{
				Cha.Bod.くぱぁ0 = Excitement;
			}
			if (!Cha.ChaD.股施術 && (Cha.Bod.Is蠍 || (Cha.Bod.Is蛇 && Cha.Bod.蛇.ガード)))
			{
				Cha.Bod.くぱぁ1 = Excitement;
				if (Cha.Bod.くぱぁ1 < 0.3)
				{
					UI.くぱぁ閉じ時();
				}
			}
		}
		if (!Cha.汗かき.Run && Lust > 0.5 && Excitement > 0.75)
		{
			Cha.汗かき.Start();
		}
		else if (Cha.汗かき.Run && Excitement < 0.4)
		{
			Cha.汗かき.End();
		}
		if (UI.ハンド処理.Isくぱぁ)
		{
			UI.Set_くぱぁ(UI.ハンド右, 右: true);
			UI.Set_くぱぁ(UI.ハンド左, 右: false);
		}
		if (UI.ステート描画)
		{
			UI.ステート.TextIm = GameText.体力 + "/" + Stamina.Numf1() + "\r\n" + GameText.感度 + "/" + Sensitivity.Numf1() + "\r\n" + GameText.興奮 + "/" + Excitement.Numf1() + "\r\n" + GameText.潤滑 + "/" + Wetness.Numf1() + "\r\n" + GameText.緊張 + "/" + Tension.Numf1() + "\r\n" + GameText.羞恥 + "/" + Shame.Numf1() + "\r\n\r\n" + GameText.抵抗値 + "/" + Pride.Numf1() + "\r\n" + GameText.欲望度 + "/" + Lust.Numf1() + "\r\n" + GameText.情愛度 + "/" + Affection.Numf1() + "\r\n" + GameText.卑屈度 + "/" + Training.Numf1() + "\r\n" + GameText.技巧度 + "/" + SkillL.Numf1();
		}
	}

	public static double 否定_(this Cha c)
	{
		return c.ChaD.Pride;
	}

	public static double 屈辱_(this Cha c)
	{
		return c.ChaD.Sensitivity * c.ChaD.Pride * c.ChaD.Taming;
	}

	public static double 羞恥_(this Cha c)
	{
		return c.ChaD.Shyness;
	}

	public static double 受容_(this Cha c)
	{
		return c.ChaD.Tension.Inverse() * c.ChaD.Pride.Inverse() * c.ChaD.Affection;
	}

	public static double 欲望_(this Cha c)
	{
		return c.ChaD.Tension.Inverse() * c.ChaD.Pride.Inverse() * c.ChaD.Lust;
	}

	public static double 興奮_(this Cha c)
	{
		return c.ChaD.Tension.Inverse() * c.ChaD.Pride.Inverse() * c.ChaD.Excitement * c.ChaD.Lust;
	}

	public static double 余裕_(this Cha c)
	{
		return c.ChaD.Tension.Inverse() * c.ChaD.Stamina * c.ChaD.Sensitivity.Inverse() * c.ChaD.Taming.Inverse() * c.ChaD.SkillL;
	}

	public static double 幸福_(this Cha c)
	{
		return c.ChaD.Tension.Inverse() * c.ChaD.Pride.Inverse() * c.ChaD.Tension.Inverse() * c.ChaD.Affection;
	}

	public static double 喜悦_(this Cha c)
	{
		return c.ChaD.Tension.Inverse() * c.ChaD.Pride.Inverse() * c.ChaD.Sensitivity * c.ChaD.Affection * c.ChaD.Lust;
	}

	public static double 淫乱_(this Cha c)
	{
		return c.ChaD.Tension.Inverse() * c.ChaD.Pride.Inverse() * c.ChaD.Sensitivity * c.ChaD.Excitement * c.ChaD.Lust * c.ChaD.Taming;
	}

	public static double 其他_(this Cha c)
	{
		return 0.2;
	}

	public static void Emotion(this Cha c)
	{
		switch (c.ChaD.Emotion)
		{
		case EmotionType.none:
			switch (Oth.GetRandomIndex(c.否定_(), c.屈辱_(), c.羞恥_(), c.受容_(), c.欲望_(), c.興奮_(), c.余裕_(), c.幸福_(), c.喜悦_(), c.淫乱_(), c.其他_()))
			{
			case 0:
				c.ChaD.Emotion = EmotionType.Denial;
				break;
			case 1:
				c.ChaD.Emotion = EmotionType.Humiliation;
				break;
			case 2:
				c.ChaD.Emotion = EmotionType.Shame;
				break;
			case 3:
				c.ChaD.Emotion = EmotionType.Acceptance;
				break;
			case 4:
				c.ChaD.Emotion = EmotionType.Desire;
				break;
			case 5:
				c.ChaD.Emotion = EmotionType.Excitement;
				break;
			case 6:
				c.ChaD.Emotion = EmotionType.余裕;
				break;
			case 7:
				c.ChaD.Emotion = EmotionType.Happiness;
				break;
			case 8:
				c.ChaD.Emotion = EmotionType.Joy;
				break;
			case 9:
				c.ChaD.Emotion = EmotionType.Lewd;
				break;
			case 10:
				c.ChaD.Emotion = EmotionType.Other;
				break;
			}
			break;
		case EmotionType.Denial:
			switch (Oth.GetRandomIndex(c.否定_(), c.屈辱_(), c.羞恥_(), c.喜悦_()))
			{
			case 0:
				c.ChaD.Emotion = EmotionType.Denial;
				break;
			case 1:
				c.ChaD.Emotion = EmotionType.Humiliation;
				break;
			case 2:
				c.ChaD.Emotion = EmotionType.Shame;
				break;
			case 3:
				c.ChaD.Emotion = EmotionType.Joy;
				break;
			}
			break;
		case EmotionType.Humiliation:
			switch (Oth.GetRandomIndex(c.否定_(), c.屈辱_(), c.羞恥_(), c.興奮_()))
			{
			case 0:
				c.ChaD.Emotion = EmotionType.Denial;
				break;
			case 1:
				c.ChaD.Emotion = EmotionType.Humiliation;
				break;
			case 2:
				c.ChaD.Emotion = EmotionType.Shame;
				break;
			case 3:
				c.ChaD.Emotion = EmotionType.Excitement;
				break;
			}
			break;
		case EmotionType.Shame:
			switch (Oth.GetRandomIndex(c.屈辱_(), c.羞恥_(), c.興奮_()))
			{
			case 0:
				c.ChaD.Emotion = EmotionType.Humiliation;
				break;
			case 1:
				c.ChaD.Emotion = EmotionType.Shame;
				break;
			case 2:
				c.ChaD.Emotion = EmotionType.Excitement;
				break;
			}
			break;
		case EmotionType.Acceptance:
			switch (Oth.GetRandomIndex(c.羞恥_(), c.受容_(), c.欲望_(), c.興奮_(), c.余裕_()))
			{
			case 0:
				c.ChaD.Emotion = EmotionType.Shame;
				break;
			case 1:
				c.ChaD.Emotion = EmotionType.Acceptance;
				break;
			case 2:
				c.ChaD.Emotion = EmotionType.Desire;
				break;
			case 3:
				c.ChaD.Emotion = EmotionType.Excitement;
				break;
			case 4:
				c.ChaD.Emotion = EmotionType.余裕;
				break;
			}
			break;
		case EmotionType.Desire:
			switch (Oth.GetRandomIndex(c.受容_(), c.欲望_(), c.興奮_(), c.喜悦_(), c.淫乱_()))
			{
			case 0:
				c.ChaD.Emotion = EmotionType.Acceptance;
				break;
			case 1:
				c.ChaD.Emotion = EmotionType.Desire;
				break;
			case 2:
				c.ChaD.Emotion = EmotionType.Excitement;
				break;
			case 3:
				c.ChaD.Emotion = EmotionType.Joy;
				break;
			case 4:
				c.ChaD.Emotion = EmotionType.Lewd;
				break;
			}
			break;
		case EmotionType.Excitement:
			switch (Oth.GetRandomIndex(c.羞恥_(), c.欲望_(), c.興奮_(), c.喜悦_(), c.淫乱_()))
			{
			case 0:
				c.ChaD.Emotion = EmotionType.Shame;
				break;
			case 1:
				c.ChaD.Emotion = EmotionType.Desire;
				break;
			case 2:
				c.ChaD.Emotion = EmotionType.Excitement;
				break;
			case 3:
				c.ChaD.Emotion = EmotionType.Joy;
				break;
			case 4:
				c.ChaD.Emotion = EmotionType.Lewd;
				break;
			}
			break;
		case EmotionType.余裕:
			switch (Oth.GetRandomIndex(c.受容_(), c.欲望_(), c.興奮_(), c.余裕_(), c.幸福_()))
			{
			case 0:
				c.ChaD.Emotion = EmotionType.Acceptance;
				break;
			case 1:
				c.ChaD.Emotion = EmotionType.Desire;
				break;
			case 2:
				c.ChaD.Emotion = EmotionType.Excitement;
				break;
			case 3:
				c.ChaD.Emotion = EmotionType.余裕;
				break;
			case 4:
				c.ChaD.Emotion = EmotionType.Happiness;
				break;
			}
			break;
		case EmotionType.Happiness:
			switch (Oth.GetRandomIndex(c.受容_(), c.欲望_(), c.余裕_(), c.幸福_(), c.喜悦_()))
			{
			case 0:
				c.ChaD.Emotion = EmotionType.Acceptance;
				break;
			case 1:
				c.ChaD.Emotion = EmotionType.Desire;
				break;
			case 2:
				c.ChaD.Emotion = EmotionType.余裕;
				break;
			case 3:
				c.ChaD.Emotion = EmotionType.Happiness;
				break;
			case 4:
				c.ChaD.Emotion = EmotionType.Joy;
				break;
			}
			break;
		case EmotionType.Joy:
			switch (Oth.GetRandomIndex(c.羞恥_(), c.受容_(), c.欲望_(), c.興奮_(), c.幸福_(), c.喜悦_(), c.淫乱_()))
			{
			case 0:
				c.ChaD.Emotion = EmotionType.Shame;
				break;
			case 1:
				c.ChaD.Emotion = EmotionType.Acceptance;
				break;
			case 2:
				c.ChaD.Emotion = EmotionType.Desire;
				break;
			case 3:
				c.ChaD.Emotion = EmotionType.Excitement;
				break;
			case 4:
				c.ChaD.Emotion = EmotionType.Happiness;
				break;
			case 5:
				c.ChaD.Emotion = EmotionType.Joy;
				break;
			case 6:
				c.ChaD.Emotion = EmotionType.Lewd;
				break;
			}
			break;
		case EmotionType.Lewd:
			switch (Oth.GetRandomIndex(c.屈辱_(), c.羞恥_(), c.欲望_(), c.興奮_(), c.幸福_(), c.喜悦_(), c.淫乱_()))
			{
			case 0:
				c.ChaD.Emotion = EmotionType.Humiliation;
				break;
			case 1:
				c.ChaD.Emotion = EmotionType.Shame;
				break;
			case 2:
				c.ChaD.Emotion = EmotionType.Desire;
				break;
			case 3:
				c.ChaD.Emotion = EmotionType.Excitement;
				break;
			case 4:
				c.ChaD.Emotion = EmotionType.Happiness;
				break;
			case 5:
				c.ChaD.Emotion = EmotionType.Joy;
				break;
			case 6:
				c.ChaD.Emotion = EmotionType.Lewd;
				break;
			}
			break;
		case EmotionType.Other:
			switch (Oth.GetRandomIndex(c.羞恥_(), c.受容_(), c.余裕_(), c.幸福_(), c.其他_()))
			{
			case 0:
				c.ChaD.Emotion = EmotionType.Shame;
				break;
			case 1:
				c.ChaD.Emotion = EmotionType.Acceptance;
				break;
			case 2:
				c.ChaD.Emotion = EmotionType.余裕;
				break;
			case 3:
				c.ChaD.Emotion = EmotionType.Happiness;
				break;
			case 4:
				c.ChaD.Emotion = EmotionType.Other;
				break;
			}
			break;
		}
		if (c.苦痛条件())
		{
			c.ChaD.Emotion = EmotionType.Humiliation;
		}
		if (c.放尿.Run)
		{
			c.ChaD.Emotion = EmotionType.Shame;
		}
	}

	public static void WaitingState0()
	{
		if (0.02.Lot())
		{
			WaitingState1();
		}
	}

	public static void WaitingState1()
	{
		if ((Excitement.Inverse() * 0.05).Lot())
		{
			Cha.Crying = false;
		}
		if (Cha.Bod.Is初期腰)
		{
			Cha.Bod.Set腰();
		}
		Cha.Emotion();
		Cha.UpdateExpression();
		Cha.UpdatePosture();
	}

	public static void Reaction0()
	{
		if (Cha != null && Cha.EyeTracking.Run)
		{
			Cha.EyeTracking.End();
		}
		if (Virgin && CurrentActionType == ActionType.Insertion && (CurrentToolType == ToolType.Penis || CurrentToolType == ToolType.Dildo || CurrentToolType == ToolType.Vibrator || CurrentToolType == ToolType.Drill || CurrentToolType == ToolType.デンマ || CurrentToolType == ToolType.AnalVibrator) && CurrentContactType == ContactType.Vagina && 挿入Lvn > 2)
		{
			Reaction2();
			Cha.Bod.腰.位置B += Oth.GetRandomVector() * 0.0004;
			Cha.Bod.腰振りv = RNG.XS.NextDouble();
			switch (RNG.XS.Next(2))
			{
			case 0:
				Cha.ChaD.Emotion = EmotionType.Humiliation;
				break;
			case 1:
				Cha.ChaD.Emotion = EmotionType.Shame;
				break;
			}
			Cha.SetInitialExpression();
			Cha.UpdatePosture();
			Virgin = false;
			Sta.GameData.TrainingTarget.Virgin = false;
			UI.発音(Cha.Bod.膣口位置.GetAreaPoint(0.04), Sta.処女喪失, Color.Red, 0.3, b: true);
			Cha.Bod.処女喪失 = true;
			if (Cha.Bod.断面_表示)
			{
				Cha.Bod.膣内精液.血液1_表示 = true;
				Cha.Bod.膣内精液.血液2_表示 = true;
			}
			Cha.Bod.性器精液.血液1_表示 = true;
			Cha.Bod.性器精液.血液2_表示 = true;
			Cha.Bod.性器精液.血液濃度 = 0.0;
			発声();
		}
		else if (!射精n && (初回 || タイミング情報n == CurrentState.Start || CurrentActionType == ActionType.Whipping || (CurrentContactType == ContactType.Vagina && CurrentActionType == ActionType.Insertion && 挿入Lvn == (int)(5.0 * Cha.ChaD.固有値) && 0.2.Lot())))
		{
			Reaction1();
			初回 = false;
		}
		else if (反応度 > 0.0)
		{
			if ((反応度 * 0.25).Lot())
			{
				Reaction1();
			}
			反応度 = (反応度 - 0.05).Clamp(0.0, 1.0);
		}
		else if ((0.02 + 0.03 * Sensitivity).Lot())
		{
			Reaction1();
		}
		else if (タイミング情報n == CurrentState.End)
		{
			WaitingState1();
			初回 = true;
			反応度 = 1.0;
			if (CurrentActionType == ActionType.Insertion && CurrentContactType == ContactType.Mouth && SkillL < 0.5 * Sta.GameData.TrainingTarget.MaxSkillL && Reactions.Tongue.Contains(Cha.Bod.口i) && ((CurrentToolType == ToolType.Hand && 手口) || CurrentToolType == ToolType.Penis || CurrentToolType == ToolType.Dildo || CurrentToolType == ToolType.Vibrator || CurrentToolType == ToolType.Drill || CurrentToolType == ToolType.デンマ || CurrentToolType == ToolType.AnalVibrator) && (SkillL.Inverse() * 0.8).Lot())
			{
				Cha.Coughing.Start();
				return;
			}
			Cha.SetInitialExpression();
			Cha.口();
		}
	}

	public static void Reaction1()
	{
		Reaction2();
		Cha.Bod.腰.位置B += Oth.GetRandomVector() * 0.0004;
		Cha.Bod.腰振りv = RNG.XS.NextDouble();
		Cha.Emotion();
		Cha.UpdateExpression();
		Cha.UpdatePosture();
		if (Cha.苦痛条件())
		{
			if (0.7.Lot())
			{
				if (Cha.Bod.Is双眼)
				{
					Cha.瞼_瞑左();
					Cha.瞼_瞑右();
				}
				if (Cha.Bod.Is単眼)
				{
					Cha.単瞼_瞑();
				}
				if (Cha.Bod.Is頬眼)
				{
					Cha.頬瞼_瞑左();
					Cha.頬瞼_瞑右();
				}
				if (Cha.Bod.Is額眼)
				{
					Cha.額瞼_瞑();
				}
			}
			else
			{
				if (Cha.Bod.Is双眼)
				{
					Cha.瞼_半2左();
					Cha.瞼_半2右();
				}
				if (Cha.Bod.Is単眼)
				{
					Cha.単瞼_半2();
				}
				if (Cha.Bod.Is頬眼)
				{
					Cha.頬瞼_半2左();
					Cha.頬瞼_半2右();
				}
				if (Cha.Bod.Is額眼)
				{
					Cha.額瞼_半2();
				}
			}
		}
		if (0.15.Lot() || CurrentActionType == ActionType.Whipping || 初回)
		{
			発声();
		}
	}

	public static void Reaction2()
	{
		if ((Affection > 0.8 && Excitement > 0.8 && (Excitement * 0.04).Lot()) || (Cha.苦痛条件() && (Excitement * (double)強さn * (1.0 / 75.0)).Lot()))
		{
			Cha.Crying = true;
		}
		if (CurrentToolType == ToolType.Hand && CurrentActionType == ActionType.Contact && CurrentContactType == ContactType.Head && (Excitement.Inverse() * 0.04).Lot())
		{
			Cha.Crying = false;
		}
		if ((Cha.Bod.玉口枷_表示 && Sensitivity.Lot()) || (CurrentActionType == ActionType.Insertion && CurrentContactType == ContactType.Mouth && Sensitivity > 0.5 && Excitement > 0.5 && Lust > 0.8 && Sensitivity.Lot() && ((CurrentToolType == ToolType.Hand && 手膣) || CurrentToolType == ToolType.Penis || CurrentToolType == ToolType.Dildo || CurrentToolType == ToolType.Vibrator || CurrentToolType == ToolType.Drill || CurrentToolType == ToolType.デンマ || CurrentToolType == ToolType.AnalVibrator)))
		{
			Cha.涎.Start();
		}
		if (Stamina > 0.1 && Sensitivity > 0.5 && Wetness > 0.6 && Tension == 0.0 && Lust > 0.7 && Affection > 0.7 && (Excitement * 0.05).Lot())
		{
			Cha.潮吹小.Start();
		}
		if (CurrentActionType == ActionType.Insertion && CurrentContactType == ContactType.Vagina && Sensitivity > 0.4 && Wetness == 1.0 && Lust > 0.7 && Affection > 0.7 && Sensitivity.Lot() && ((CurrentToolType == ToolType.Hand && 手膣) || CurrentToolType == ToolType.Penis || CurrentToolType == ToolType.Dildo || CurrentToolType == ToolType.Vibrator || CurrentToolType == ToolType.Drill || CurrentToolType == ToolType.デンマ || CurrentToolType == ToolType.AnalVibrator))
		{
			Cha.飛沫.Start();
		}
		if (Sta.GameData.TrainingTarget.妊娠状態変数 > 2 && !Cha.Bod.乳房左.虫性_甲殻_表示 && (CurrentActionType == ActionType.乳捏 || CurrentActionType == ActionType.パイ || ((double)Sta.GameData.TrainingTarget.妊娠状態変数 * 0.1).Lot()))
		{
			Cha.噴乳.Start();
		}
		if (!Cha.膣ヒク.Run && (CurrentContactType == ContactType.Crotch || CurrentContactType == ContactType.Sex || CurrentContactType == ContactType.Nucleus || CurrentContactType == ContactType.Vagina || RNG.XS.NextBool()) && 部位感度[ContactType.Vagina] > 0.4)
		{
			Cha.膣ヒク.Start();
		}
		if (!Cha.肛ヒク.Run && (CurrentContactType == ContactType.Anal || CurrentContactType == ContactType.Vagina || RNG.XS.NextBool()) && 部位感度[ContactType.Anal] > 0.4)
		{
			Cha.肛ヒク.Start();
		}
		if (!Cha.糸ヒク.Run && (CurrentContactType == ContactType.Thread || RNG.XS.NextBool()))
		{
			Cha.糸ヒク.Start();
		}
	}

	public static void 発声()
	{
		int num = 0;
		if (CurrentContactType == ContactType.Mouth)
		{
			num = 4;
		}
		else if (Cha.苦痛条件())
		{
			num = 0;
		}
		else
		{
			double num2 = (Tension + Pride) * 0.5;
			num = 1 + Oth.GetRandomIndex((Shame + Tension + Training + Pride) / 4.0, (Sensitivity + Affection + Lust) / 3.0 - num2, (Sensitivity + Excitement + Affection + Lust + Training) / 5.0 - num2);
		}
		string text = "";
		if (Cha.Bod.口i == 4 || Cha.Bod.口i == 10 || Cha.Bod.口i == 11)
		{
			string[][] n = Sta.n;
			text = n[num][RNG.XS.Next(n[num].Length)];
		}
		else if (Cha.Bod.玉口枷_表示)
		{
			text = Sta.o[3][RNG.XS.Next(Sta.o[3].Length)];
		}
		else
		{
			string[][] n;
			do
			{
				n = GetRandomTable();
			}
			while (n[num].Length < 1 || string.IsNullOrWhiteSpace(text = n[num][RNG.XS.Next(n[num].Length)]));
		}
		UI.発音(Cha.Bod.口腔位置.GetAreaPoint(0.05), text.語尾() + " ", Color.Pink, 0.3 + 0.1 * Excitement, b: true);
	}

	public static string 語尾(this string s)
	{
		switch (Oth.GetRandomIndex((Shame + Tension) * 0.5, Cha.苦痛条件() ? 1.0 : ((Sensitivity + Excitement + Lust) / 3.0), (Affection + Lust) * 0.4 - Pride))
		{
		case 0:
			return s + Sta.end[(!RNG.XS.NextBool()) ? 1u : 0u];
		case 1:
			if (s.EndsWith(Sta.end[2]))
			{
				return s + Sta.end[3];
			}
			return s + Sta.end[RNG.XS.NextBool() ? 2 : 3];
		case 2:
			return s + Sta.end[4];
		default:
			return s + Sta.end[0];
		}
	}

	public static string[][] GetRandomTable()
	{
		return RNG.XS.Next(6) switch
		{
			0 => Sta.a, 
			1 => Sta.i, 
			2 => Sta.u, 
			3 => Sta.e, 
			4 => Sta.o, 
			5 => Sta.n, 
			_ => null, 
		};
	}

	static Player()
	{
		絶頂中 = false;
		射精中 = false;
		ゲージ降下処理 = new Mot(0.0, 1.0)
		{
			BaseSpeed = 1.0,
			Staing = delegate
			{
			},
			Runing = delegate
			{
				if (加算前提)
				{
					if (Sensitivity > 0.0 && !絶頂中)
					{
						感度減算();
					}
					興奮計算();
					興奮計算2();
					回復();
					if (PlayerSensitivity > 0.0 && !射精中)
					{
						主感度減算();
					}
					主興奮計算();
					主興奮計算2();
					主回復();
					WaitingState0();
				}
			},
			Reaing = delegate
			{
			},
			Rouing = delegate
			{
			},
			Ending = delegate
			{
			}
		};
		強制終了 = false;
		初回 = false;
		反応度 = 0.0;
	}

	public static void ModBox()
	{
		if (Sta.GameData.TrainingTarget == null)
		{
			return;
		}
		ChaD chaD = Sta.GameData.TrainingTarget.ChaD;
		List<string> list = new List<string>();
		foreach (KeyValuePair<ContactType, double> item in chaD.Sesnsitivities)
		{
			list.Add(GameText.TouchTranslation(item.Key) + ": " + item.Value.Numf1());
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (i % 2 == 1)
			{
				list.Insert(i, "\r\n");
			}
		}
		UI.InfoBox.TextIm = "Sizes:" + "\r\n Breasts : " + chaD.最乳房.Numf1() + "\r\n Nipples : " + chaD.最乳首.Numf1() + "\r\n Clit    : " + chaD.現陰核.Numf1() + "\r\n Vag     : " + chaD.現性器.Numf1() + "\r\n Anus    : " + chaD.現肛門.Numf1() + "\r\nMood : " + GameText.TranslateState(chaD.Emotion) + "\r\nTouching : " + GameText.TouchTranslation(CurrentContactType);
	}

	public static void SensBox()
	{
		if (Sta.GameData.TrainingTarget == null)
		{
			return;
		}
		ChaD chaD = Sta.GameData.TrainingTarget.ChaD;
		UI.SensitivityBox.TextIm = "Sensitivities:\r\n";
		foreach (KeyValuePair<ContactType, double> item in chaD.Sesnsitivities)
		{
			Tex sensitivityBox = UI.SensitivityBox;
			sensitivityBox.TextIm = sensitivityBox.TextIm + GameText.TouchTranslation(item.Key) + ": " + item.Value.Numf1() + "\r\n";
		}
	}
}
