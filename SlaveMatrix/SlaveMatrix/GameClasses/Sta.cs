using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using _2DGAMELIB;
using SlaveMatrix.Properties;

namespace SlaveMatrix;

public static class Sta
{
	public static Obj 胴体;

	public static Obj 肩左;

	public static Obj 腕左;

	public static Obj 脚左;

	public static Obj 尻尾;

	public static Obj 半身;

	public static Obj 肢左;

	public static Obj 肢中;

	public static Obj 性器;

	public static Obj 性器付;

	public static Obj スタンプ;

	public static Obj カーソル;

	public static Obj その他;

	public static Obj タイル;

	public static double MaxAre;

	public static Type Elet;

	public static Type EleDt;

	public static Type 胸t;

	public static Type 肩t;

	public static Type 胴t;

	public static Type 腰t;

	public static Type 尾_鯨t;

	public static Type 上腕_人t;

	public static Type 上腕_鳥t;

	public static Type 長物_鯨t;

	public static Type 後髪0_ジグDt;

	public static Type 後髪0_ハネDt;

	public static Type 後髪0_パツDt;

	public static Type 後髪0_カルDt;

	public static Type 後髪0_肢系Dt;

	public static Type 耳_人Dt;

	public static Type 耳_尖Dt;

	public static Type 耳_長Dt;

	public static Type 耳_鰭Dt;

	public static Type 耳_羽Dt;

	public static Type 耳_獣Dt;

	public static Type 肩Dt;

	public static Type 角1_一Dt;

	public static Type 角1_鬼Dt;

	public static Type 角1_虫Dt;

	public static Type 角2_山1Dt;

	public static Type 角2_山2Dt;

	public static Type 角2_山3Dt;

	public static Type 角2_巻Dt;

	public static Type 角2_牛1Dt;

	public static Type 角2_牛2Dt;

	public static Type 角2_牛3Dt;

	public static Type 角2_牛4Dt;

	public static Type 角2_鬼Dt;

	public static Type 角2_虫Dt;

	public static Type 花_薔Dt;

	public static Type 花_百Dt;

	public static Type 顔面_甲Dt;

	public static Type 顔面_虫Dt;

	public static Type 顔面_蟲Dt;

	public static Type 頭頂_宇Dt;

	public static Type 頭頂_皿Dt;

	public static Type 頭頂_天Dt;

	public static Type 頭頂後_宇Dt;

	public static Type 背中_羽Dt;

	public static Type 背中_甲Dt;

	public static Type 背中_光Dt;

	public static Type 触覚_線Dt;

	public static Type 触覚_節Dt;

	public static Type 触覚_甲Dt;

	public static Type 触覚_蝶Dt;

	public static Type 触覚_蛾Dt;

	public static Type 触覚_蠍Dt;

	public static Type 尾_猫Dt;

	public static Type 尾_犬Dt;

	public static Type 尾_狐Dt;

	public static Type 尾_馬Dt;

	public static Type 尾_牛Dt;

	public static Type 尾_龍Dt;

	public static Type 尾_竜Dt;

	public static Type 尾_悪Dt;

	public static Type 尾_淫Dt;

	public static Type 尾_鳥Dt;

	public static Type 尾_虫Dt;

	public static Type 尾_蜘Dt;

	public static Type 尾_蠍Dt;

	public static Type 尾_蛇Dt;

	public static Type 尾_腓Dt;

	public static Type 尾_短Dt;

	public static Type 尾_ヘDt;

	public static Type 尾_ガDt;

	public static Type 尾_ウDt;

	public static Type 尾_魚Dt;

	public static Type 尾_鯨Dt;

	public static Type 尾_蟲Dt;

	public static Type 尾_根Dt;

	public static Type 尾鰭_魚Dt;

	public static Type 尾鰭_鯨Dt;

	public static Type 鰭_魚Dt;

	public static Type 鰭_豚Dt;

	public static Type 鰭_鯨Dt;

	public static Type 葉_披Dt;

	public static Type 葉_心Dt;

	public static Type 前翅_甲Dt;

	public static Type 前翅_羽Dt;

	public static Type 前翅_蝶Dt;

	public static Type 前翅_草Dt;

	public static Type 後翅_甲Dt;

	public static Type 後翅_羽Dt;

	public static Type 後翅_蝶Dt;

	public static Type 後翅_草Dt;

	public static Type 触肢_肢蜘Dt;

	public static Type 触肢_肢蠍Dt;

	public static Type 節足_足蜘Dt;

	public static Type 節足_足蠍Dt;

	public static Type 節足_足百Dt;

	public static Type 節尾_曳航Dt;

	public static Type 節尾_鋏Dt;

	public static Type 触手_軟Dt;

	public static Type 触手_触Dt;

	public static Type 触手_犬Dt;

	public static Type 触手_蔦Dt;

	public static Type 上腕_人Dt;

	public static Type 上腕_鳥Dt;

	public static Type 上腕_蝙Dt;

	public static Type 上腕_獣Dt;

	public static Type 上腕_蹄Dt;

	public static Type 下腕_人Dt;

	public static Type 下腕_鳥Dt;

	public static Type 下腕_蝙Dt;

	public static Type 獣下腕Dt;

	public static Type 下腕_獣Dt;

	public static Type 下腕_蹄Dt;

	public static Type 手_人Dt;

	public static Type 手_鳥Dt;

	public static Type 手_蝙Dt;

	public static Type 手_獣Dt;

	public static Type 手_馬Dt;

	public static Type 手_牛Dt;

	public static Type 腿_人Dt;

	public static Type 腿_獣Dt;

	public static Type 腿_蹄Dt;

	public static Type 腿_鳥Dt;

	public static Type 腿_竜Dt;

	public static Type 脚_人Dt;

	public static Type 脚_獣Dt;

	public static Type 脚_蹄Dt;

	public static Type 脚_鳥Dt;

	public static Type 脚_竜Dt;

	public static Type 足_人Dt;

	public static Type 足_獣Dt;

	public static Type 足_馬Dt;

	public static Type 足_牛Dt;

	public static Type 足_鳥Dt;

	public static Type 足_竜Dt;

	public static Type 四足脇Dt;

	public static Type 胴_蛇Dt;

	public static Type 胴_蟲Dt;

	public static Type 大顎基Dt;

	public static Type 鳳凰Dt;

	public static Type 大顎Dt;

	public static Type 虫顎Dt;

	public static Type 虫鎌Dt;

	public static Type 獣耳Dt;

	public static Type 植Dt;

	public static string 拘束鎖t;

	public static string lt;

	public static string at;

	public static string cdt;

	public static string cpt;

	public static Type Bodt;

	public static string dt;

	public static string bt;

	public static string ct;

	private static HashSet<ConnectionInfo> 左右無し;

	private static Type 接続情報t;

	private static BindingFlags bf;

	private static BindingFlags bfi;

	public static 髪留2情報 髪留2初期化;

	public static 玉口枷情報 玉口枷初期化;

	public static 目隠帯情報 目隠帯初期化;

	public static 拘束具情報 拘束具初期化;

	public static ピアス情報 ピアス初期化;

	public static キャップ情報 キャップ初期化;

	public static ドレス首情報 ドレス首初期化;

	public static 下着T_チューブ情報 下着T_チューブ初期化;

	public static 下着T_クロス情報 下着T_クロス初期化;

	public static 下着T_ビキニ情報 下着T_ビキニ初期化;

	public static 下着T_マイクロ情報 下着T_マイクロ初期化;

	public static 下着T_ブラ情報 下着T_ブラ初期化;

	public static 下着B_ノーマル情報 下着B_ノーマル初期化;

	public static 下着B_マイクロ情報 下着B_マイクロ初期化;

	public static ドレス情報 ドレス初期化;

	public static 上着B_クロス情報 上着B_クロス初期化;

	public static 上着B_前掛け情報 上着B_前掛け初期化;

	public static ブーツ情報 ブーツ初期化;

	public static string CurrentDirectory;

	public static GameState GameData;

	public static string SavePath;

	public static string ImiPath;

	public static List<string[]> 口挿;

	public static List<string[]> 口中;

	public static List<string[]> 口抜;

	public static List<string[]> 膣挿;

	public static List<string[]> 膣中;

	public static List<string[]> 膣抜;

	public static List<string[]> 肛挿;

	public static List<string[]> 肛中;

	public static List<string[]> 肛抜;

	public static List<string[]> 糸挿;

	public static List<string[]> 糸中;

	public static List<string[]> 糸抜;

	public static List<string[]> 潮吹;

	public static List<string[]> 放尿;

	public static List<string[]> くぱ;

	public static List<string[]> 吸引;

	public static List<string[]> 吸着;

	public static List<string[]> 吸脱;

	public static List<string[]> 振動;

	public static List<string[]> 鞭振;

	public static List<string[]> 鞭打;

	public static List<string[]> 剃り;

	public static List<string[]> 射精;

	public static string 処女喪失;

	public static string PanPath;

	public static string[][] a;

	public static string[][] i;

	public static string[][] u;

	public static string[][] e;

	public static string[][] o;

	public static string[][] n;

	public static string[] end;

	//public static ParallelOptions po3;

	public static string ConfigPath;

	public static bool SimpleMating;

	public static bool AutoSort;

	public static bool PlayBGM;

	public static bool BigWindow;

	public static bool HighQuality;

	public static bool SensesButton;

	public static bool FixInfo;

	public static bool JsonButton;

	public static bool RefreshStoreEveryTime;

	//public static bool EncryptSave;
	//public static bool DecryptLoad;

	public static string JsonSavePath;

	public static bool DontScar;

	public static bool FastText;

	public static bool AntiAliasing;

	public static bool TranslateJson;

	public static string TranslateJsonFile;

	public static Dictionary<string, string> TranslateDict;

	public static bool ShowFPS;

	public static bool MoveButton;

	public static bool StaminaButton;

	public static bool AlwaysUseName;

	public static bool MoveInsectMask;

    public static bool ShowSenses;

    public static void タイル準備()
	{
		タイル.SetJoints();
		foreach (Par item in タイル.EnumAllPar())
		{
			item.BrushColor = Col.DarkGray;
			item.GetAlpha(out var ret);
			item.PenColor = Color.FromArgb(ret / 2, Col.Black);
			item.Hit = false;
		}
	}

	public static void Disposes()
	{
		胴体.Dispose();
		肩左.Dispose();
		腕左.Dispose();
		脚左.Dispose();
		尻尾.Dispose();
		半身.Dispose();
		肢左.Dispose();
		肢中.Dispose();
		性器.Dispose();
		性器付.Dispose();
		スタンプ.Dispose();
		カーソル.Dispose();
		その他.Dispose();
		タイル.Dispose();
		Sounds.Close();
		Mods.Dispose();
	}

	public static double GetRanAngle(this double MaxAngle)
	{
		return MaxAngle * RNG.XS.NextDouble() * (double)(RNG.XS.NextBool() ? 1 : (-1));
	}

	public static T GetEleD<T>(this IEnumerable<EleD> src) where T : EleD
	{
		if (src == null)
		{
			return null;
		}
		return (T)src.FirstOrDefault((EleD e) => e is T);
	}

	public static T GetEleD<T>(this IEnumerable<EleD> src, bool 右) where T : EleD
	{
		if (src == null)
		{
			return null;
		}
		return (T)src.FirstOrDefault((EleD e) => e is T && e.右 == 右);
	}

	public static T GetEleD<T>(this IEnumerable<EleD> src, Func<T, bool> con) where T : EleD
	{
		if (src == null)
		{
			return null;
		}
		return (T)src.FirstOrDefault((EleD e) => e is T && con((T)e));
	}

	public static IEnumerable<T> GetEleDs<T>(this IEnumerable<EleD> src) where T : EleD
	{
		return src?.Where((EleD e) => e is T).Cast<T>();
	}

	public static void SetEleD<T>(this IEnumerable<EleD> src, Action<T> a) where T : EleD
	{
		T eleD = src.GetEleD<T>();
		if (eleD != null)
		{
			a(eleD);
		}
	}

	public static void SetEleDs<T>(this IEnumerable<EleD> src, Action<T> a) where T : EleD
	{
		if (src == null)
		{
			return;
		}
		foreach (T eleD in src.GetEleDs<T>())
		{
			a(eleD);
		}
	}

	public static bool IsEleD<T>(this IEnumerable<EleD> src) where T : EleD
	{
		return src.GetEleD<T>() != null;
	}

	public static void SetValuesD(this EleD e, string s, object value)
	{
		if (e == null)
		{
			return;
		}
		string text = value.GetType().ToString();
		FieldInfo[] fields = e.GetType().GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			if (fieldInfo.FieldType.ToString() == text && fieldInfo.Name.Contains(s))
			{
				fieldInfo.SetValue(e, value);
			}
		}
	}

	public static void SetValuesD(this IEnumerable<EleD> src, string s, object value)
	{
		if (src == null)
		{
			return;
		}
		string text = value.GetType().ToString();
		foreach (EleD item in src)
		{
			FieldInfo[] fields = item.GetType().GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				if (fieldInfo.FieldType.ToString() == text && fieldInfo.Name.Contains(s))
				{
					fieldInfo.SetValue(item, value);
				}
			}
		}
	}

	public static void SetValuesD<T>(this IEnumerable<EleD> src, string s, object value) where T : EleD
	{
		if (src == null)
		{
			return;
		}
		string text = value.GetType().ToString();
		foreach (T eleD in src.GetEleDs<T>())
		{
			FieldInfo[] fields = eleD.GetType().GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				if (fieldInfo.FieldType.ToString() == text && fieldInfo.Name.Contains(s))
				{
					fieldInfo.SetValue(eleD, value);
				}
			}
		}
	}

	public static T GetEle<T>(this IEnumerable<Ele> src) where T : Ele
	{
		if (src == null)
		{
			return null;
		}
		return (T)src.FirstOrDefault((Ele e) => e is T);
	}

	public static T GetEle<T>(this IEnumerable<Ele> src, bool 右) where T : Ele
	{
		if (src == null)
		{
			return null;
		}
		return (T)src.FirstOrDefault((Ele e) => e is T && e.右 == 右);
	}

	public static T GetEle<T>(this IEnumerable<Ele> src, Func<T, bool> con) where T : Ele
	{
		if (src == null)
		{
			return null;
		}
		return (T)src.FirstOrDefault((Ele e) => e is T && con((T)e));
	}

	public static IEnumerable<T> GetEles<T>(this IEnumerable<Ele> src) where T : Ele
	{
		return src?.Where((Ele e) => e is T).Cast<T>();
	}

	public static IEnumerable<T> GetEles<T>(this IEnumerable<Ele> src, bool 右) where T : Ele
	{
		return src?.Where((Ele e) => e is T && e.右 == 右).Cast<T>();
	}

	public static IEnumerable<T> GetEles<T>(this IEnumerable<Ele> src, Func<T, bool> con) where T : Ele
	{
		return src?.Where((Ele e) => e is T && con((T)e)).Cast<T>();
	}

	public static void SetEle<T>(this IEnumerable<Ele> src, Action<T> a) where T : Ele
	{
		T ele = src.GetEle<T>();
		if (ele != null)
		{
			a(ele);
		}
	}

	public static void SetEles<T>(this IEnumerable<Ele> src, Action<T> a) where T : Ele
	{
		if (src == null)
		{
			return;
		}
		foreach (T ele in src.GetEles<T>())
		{
			a(ele);
		}
	}

	public static bool IsEle<T>(this IEnumerable<Ele> src) where T : Ele
	{
		return src.GetEle<T>() != null;
	}

	public static void SetValues(this Ele e, string s, object value)
	{
		if (e == null)
		{
			return;
		}
		string text = value.GetType().ToString();
		PropertyInfo[] properties = e.GetType().GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			if (propertyInfo.CanWrite && propertyInfo.PropertyType.ToString() == text && propertyInfo.Name.Contains(s))
			{
				propertyInfo.SetValue(e, value, null);
			}
		}
	}

	public static void SetValues(this IEnumerable<Ele> src, string s, object value)
	{
		if (src == null)
		{
			return;
		}
		string text = value.GetType().ToString();
		foreach (Ele item in src)
		{
			PropertyInfo[] properties = item.GetType().GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				if (propertyInfo.CanWrite && propertyInfo.PropertyType.ToString() == text && propertyInfo.Name.Contains(s))
				{
					propertyInfo.SetValue(item, value, null);
				}
			}
		}
	}

	public static T GetEleL<T>(this IEnumerable<Ele> src) where T : Ele
	{
		if (src == null)
		{
			return null;
		}
		return (T)src.LastOrDefault((Ele e) => e is T);
	}

	public static T GetEleL<T>(this IEnumerable<Ele> src, bool 右) where T : Ele
	{
		if (src == null)
		{
			return null;
		}
		return (T)src.LastOrDefault((Ele e) => e is T && e.右 == 右);
	}

	public static T GetEleL<T>(this IEnumerable<Ele> src, Func<T, bool> con) where T : Ele
	{
		if (src == null)
		{
			return null;
		}
		return (T)src.LastOrDefault((Ele e) => e is T && con((T)e));
	}

	public static IEnumerable<T> GetElesL<T>(this IEnumerable<Ele> src) where T : Ele
	{
		return src?.Where((Ele e) => e is T).Cast<T>();
	}

	public static IEnumerable<T> GetElesL<T>(this IEnumerable<Ele> src, bool 右) where T : Ele
	{
		return src?.Where((Ele e) => e is T && e.右 == 右).Cast<T>();
	}

	public static IEnumerable<T> GetElesL<T>(this IEnumerable<Ele> src, Func<T, bool> con) where T : Ele
	{
		return src?.Where((Ele e) => e is T && con((T)e)).Cast<T>();
	}

	public static void 描画0(this IEnumerable<Ele> es, Are Are)
	{
		foreach (Ele e in es)
		{
			e.描画0(Are);
		}
	}

	public static void 描画1(this IEnumerable<Ele> es, Are Are)
	{
		foreach (Ele e in es)
		{
			e.描画1(Are);
		}
	}

	public static IEnumerable<T> JoinEnum<T>(this IEnumerable<IEnumerable<T>> es)
	{
		foreach (IEnumerable<T> e in es)
		{
			foreach (T item in e)
			{
				yield return item;
			}
		}
	}

	public static void 配色T(this Ele ele, int i, string s, ref Color2 c1, ref Color2 c2)
	{
		Type type = ele.GetType();
		string ft = typeof(ColorD).ToString();
		int num = 0;
		foreach (FieldInfo item in from e in type.GetFields()
			where e.FieldType.ToString() == ft && e.Name.Contains(s)
			select e)
		{
			if (num % 2 == i)
			{
				item.SetValue(ele, new ColorD(ref Col.Black, ref c1));
			}
			else
			{
				item.SetValue(ele, new ColorD(ref Col.Black, ref c2));
			}
			num++;
		}
	}

	public static bool Is左右無し(this ConnectionInfo 接続情報)
	{
		return 左右無し.Contains(接続情報);
	}

	public static ConnectionInfo To接続情報(this string s)
	{
		return (ConnectionInfo)Enum.Parse(接続情報t, s);
	}

	public static object GetField(this Type Type, object Object, string Name)
	{
		return Type.GetField(Name, bf).GetValue(Object);
	}

	public static object GetProperty(this Type Type, object Object, string Name)
	{
		return Type.GetProperty(Name, bf).GetValue(Object, null);
	}

	public static Color BlendP1(this Color Cd, Color Cs)
	{
		double num = (double)(int)Cd.A / 255.0;
		double num2 = (double)(int)Cs.A / 255.0;
		double num3 = 1.0 - num2;
		double num4 = num2 + num3 * num;
		return Color.FromArgb((int)(255.0 * num4), (int)(((double)(int)Cs.R * num2 + (double)(int)Cd.R * num3 * num) / num4), (int)(((double)(int)Cs.G * num2 + (double)(int)Cd.G * num3 * num) / num4), (int)(((double)(int)Cs.B * num2 + (double)(int)Cd.B * num3 * num) / num4));
	}

	public static void SetHitFalse(this Ele e)
	{
		foreach (Par item in e.本体.EnumAllPar())
		{
			item.Hit = false;
		}
	}

	public static void SetHitTrue(this Ele e)
	{
		foreach (Par item in e.本体.EnumAllPar())
		{
			item.Hit = true;
		}
	}

	public static void Setting(this Are Are)
	{
		Are.GD.SmoothingMode = SmoothingMode.HighQuality;
		Are.GD.PixelOffsetMode = PixelOffsetMode.HighQuality;
	}

	public static string Numf1(this double n)
	{
		return n.ToString("P1").PadLeft(6);
	}

	public static string Numf2(this double n)
	{
		return n.ToString("P2").PadLeft(7);
	}

	public static string[] SDPaths()
	{
		IEnumerable<string> source = Directory.EnumerateFiles(SavePath);
		return new string[10]
		{
			source.FirstOrDefault((string e) => e.StartsWith(SavePath + "\\0： ")),
			source.FirstOrDefault((string e) => e.StartsWith(SavePath + "\\1： ")),
			source.FirstOrDefault((string e) => e.StartsWith(SavePath + "\\2： ")),
			source.FirstOrDefault((string e) => e.StartsWith(SavePath + "\\3： ")),
			source.FirstOrDefault((string e) => e.StartsWith(SavePath + "\\4： ")),
			source.FirstOrDefault((string e) => e.StartsWith(SavePath + "\\5： ")),
			source.FirstOrDefault((string e) => e.StartsWith(SavePath + "\\6： ")),
			source.FirstOrDefault((string e) => e.StartsWith(SavePath + "\\7： ")),
			source.FirstOrDefault((string e) => e.StartsWith(SavePath + "\\8： ")),
			source.FirstOrDefault((string e) => e.StartsWith(SavePath + "\\9： "))
		};
	}

	public static void GDSave(int i)
	{
		//if (!EncryptSave)
		{
			GameData.SaveExMod(SavePath + "\\" + i + "： " + GameData.GetSaveDateString().Replace("/", "_") + ".sav");
		}
		/*else
		{
			GameData.SaveEx(SavePath + "\\" + i + "： " + GameData.GetSaveDateString().Replace("/", "_") + ".sav");
		}*/
	}

	public static string GetVal(this List<string[]> t, double v1, double v2)
	{
		int count = t.Count;
		double[] array = new double[count];
		int num = ((int)((double)count * v1)).Limit(0, count);
		for (int i = 0; i < count; i++)
		{
			array[i] = count - (num - i).Abs();
		}
		num = Oth.GetRandomIndex(array);
		int num2 = ((int)((double)t[num].Length * v2)).Limit(0, t[num].Length);
		return t[num][num2];
	}

	public static List<string[]> パース(this string s)
	{
		List<string[]> list = new List<string[]>();
		string[] array = s.Split("\r\n\r\n");
		foreach (string text in array)
		{
			if (!string.IsNullOrWhiteSpace(text))
			{
				list.Add((from f in text.Split("\r\n")
					where !string.IsNullOrWhiteSpace(f) && !f.StartsWith("//")
					select f).ToArray());
			}
		}
		return list;
	}

	public static void Set擬音()
	{
		string[] array = ImiPath.FromText().Split(',');
		口挿 = array[0].パース();
		口中 = array[1].パース();
		口抜 = array[2].パース();
		膣挿 = array[3].パース();
		膣中 = array[4].パース();
		膣抜 = array[5].パース();
		肛挿 = array[6].パース();
		肛中 = array[7].パース();
		肛抜 = array[8].パース();
		糸挿 = array[9].パース();
		糸中 = array[10].パース();
		糸抜 = array[11].パース();
		潮吹 = array[12].パース();
		放尿 = array[13].パース();
		くぱ = array[14].パース();
		吸引 = array[15].パース();
		吸着 = array[16].パース();
		吸脱 = array[17].パース();
		振動 = array[18].パース();
		鞭振 = array[19].パース();
		鞭打 = array[20].パース();
		剃り = array[21].パース();
		射精 = array[22].パース();
		処女喪失 = (from f in array[23].Split("\r\n")
			where !string.IsNullOrWhiteSpace(f) && !f.StartsWith("//")
			select f).First();
	}

	public static Vector2D GetAreaPoint(this Vector2D Base, double r)
	{
		double num = r * 0.5;
		double num2 = Base.X - num;
		double num3 = Base.X + num;
		double num4 = Base.Y - num;
		double num5 = Base.Y + num;
		double num6 = num3 - num2;
		double num7 = num5 - num4;
		return RNG.XS.Next(7) switch
		{
			0 => new Vector2D(RNG.XS.NextDouble(num2 - num6, num2), RNG.XS.NextDouble(num4, num5)), 
			1 => new Vector2D(RNG.XS.NextDouble(num2 - num6, num2), RNG.XS.NextDouble(num4, num5)), 
			2 => new Vector2D(RNG.XS.NextDouble(num2 - num6, num2), RNG.XS.NextDouble(num5, num5 + num7)), 
			3 => new Vector2D(RNG.XS.NextDouble(num2, num3), RNG.XS.NextDouble(num5, num5 + num7)), 
			4 => new Vector2D(RNG.XS.NextDouble(num3, num3 + num6), RNG.XS.NextDouble(num5, num5 + num7)), 
			5 => new Vector2D(RNG.XS.NextDouble(num3, num3 + num6), RNG.XS.NextDouble(num4, num5)), 
			6 => new Vector2D(RNG.XS.NextDouble(num3, num3 + num6), RNG.XS.NextDouble(num4, num5)), 
			_ => Dat.Vec2DZero, 
		};
	}

	public static Vector2D GetAreaPoint(ref Vector2D Base, double r)
	{
		double num = r * 0.5;
		double num2 = Base.X - num;
		double num3 = Base.X + num;
		double num4 = Base.Y - num;
		double num5 = Base.Y + num;
		double num6 = num3 - num2;
		double num7 = num5 - num4;
		return RNG.XS.Next(7) switch
		{
			0 => new Vector2D(RNG.XS.NextDouble(num2 - num6, num2), RNG.XS.NextDouble(num4, num5)), 
			1 => new Vector2D(RNG.XS.NextDouble(num2 - num6, num2), RNG.XS.NextDouble(num4, num5)), 
			2 => new Vector2D(RNG.XS.NextDouble(num2 - num6, num2), RNG.XS.NextDouble(num5, num5 + num7)), 
			3 => new Vector2D(RNG.XS.NextDouble(num2, num3), RNG.XS.NextDouble(num5, num5 + num7)), 
			4 => new Vector2D(RNG.XS.NextDouble(num3, num3 + num6), RNG.XS.NextDouble(num5, num5 + num7)), 
			5 => new Vector2D(RNG.XS.NextDouble(num3, num3 + num6), RNG.XS.NextDouble(num4, num5)), 
			6 => new Vector2D(RNG.XS.NextDouble(num3, num3 + num6), RNG.XS.NextDouble(num4, num5)), 
			_ => Dat.Vec2DZero, 
		};
	}

	public static void Set喘ぎ()
	{
		a = (from f in (PanPath + "\\a.txt").FromText().Split(',')
			select (from g in f.Split("\r\n")
				where !string.IsNullOrWhiteSpace(g) && !g.StartsWith("//")
				select g).ToArray()).ToArray();
		i = (from f in (PanPath + "\\i.txt").FromText().Split(',')
			select (from g in f.Split("\r\n")
				where !string.IsNullOrWhiteSpace(g) && !g.StartsWith("//")
				select g).ToArray()).ToArray();
		u = (from f in (PanPath + "\\u.txt").FromText().Split(',')
			select (from g in f.Split("\r\n")
				where !string.IsNullOrWhiteSpace(g) && !g.StartsWith("//")
				select g).ToArray()).ToArray();
		e = (from f in (PanPath + "\\e.txt").FromText().Split(',')
			select (from g in f.Split("\r\n")
				where !string.IsNullOrWhiteSpace(g) && !g.StartsWith("//")
				select g).ToArray()).ToArray();
		o = (from f in (PanPath + "\\o.txt").FromText().Split(',')
			select (from g in f.Split("\r\n")
				where !string.IsNullOrWhiteSpace(g) && !g.StartsWith("//")
				select g).ToArray()).ToArray();
		n = (from f in (PanPath + "\\n.txt").FromText().Split(',')
			select (from g in f.Split("\r\n")
				where !string.IsNullOrWhiteSpace(g) && !g.StartsWith("//")
				select g).ToArray()).ToArray();
		end = (from g in (PanPath + "\\end.txt").FromText().Split("\r\n")
			where !g.StartsWith("//")
			select g).ToArray();
	}

	public static void LoadConfig()
	{
		try
		{
			if (!File.Exists(ConfigPath))
			{
				"SimpleMating:0\r\nAutoSort:0\r\nPlayBGM:1\r\nFastText:0\r\nShowFPS:0\r\nBigWindow:0\r\nHighQuality:0\r\nAntiAliasing:0\r\nSensesButton:0\r\nFixInfo:0\r\nJsonButton:0\r\nTranslateJson:0\r\nMoveButton:0\r\nStaminaButton:0\r\nRefreshStoreEveryTime:0\r\nAlwaysUseName:0\r\nMoveInsectMask:1\r\nEncryptSave:1\r\nDecryptLoad:1".ToText(ConfigPath, Encoding.Unicode);
			}
			string[] source = ConfigPath.ReadLines();
			SimpleMating = source.First((string e) => e.StartsWith("SimpleMating:")).Last() == '1';
			AutoSort = source.First((string e) => e.StartsWith("AutoSort:")).Last() == '1';
			PlayBGM = source.First((string e) => e.StartsWith("PlayBGM:")).Last() == '1';
			FastText = source.First((string e) => e.StartsWith("FastText:")).Last() == '1';
			ShowFPS = source.First((string e) => e.StartsWith("ShowFPS:")).Last() == '1';
			BigWindow = source.First((string e) => e.StartsWith("BigWindow:")).Last() == '1';
			HighQuality = source.First((string e) => e.StartsWith("HighQuality:")).Last() == '1';
			AntiAliasing = source.First((string e) => e.StartsWith("AntiAliasing:")).Last() == '1';
			SensesButton = source.First((string e) => e.StartsWith("SensesButton:")).Last() == '1';
			FixInfo = source.First((string e) => e.StartsWith("FixInfo:")).Last() == '1';
			JsonButton = source.First((string e) => e.StartsWith("JsonButton:")).Last() == '1';
			TranslateJson = source.First((string e) => e.StartsWith("TranslateJson:")).Last() == '1';
			MoveButton = source.First((string e) => e.StartsWith("MoveButton:")).Last() == '1';
			StaminaButton = source.First((string e) => e.StartsWith("StaminaButton:")).Last() == '1';
			RefreshStoreEveryTime = source.First((string e) => e.StartsWith("RefreshStoreEveryTime:")).Last() == '1';
			AlwaysUseName = source.First((string e) => e.StartsWith("AlwaysUseName:")).Last() == '1';
			MoveInsectMask = source.First((string e) => e.StartsWith("MoveInsectMask:")).Last() == '1';
			//EncryptSave = source.First((string e) => e.StartsWith("EncryptSave:")).Last() == '1';
			//DecryptLoad = source.First((string e) => e.StartsWith("DecryptLoad:")).Last() == '1';
		}
		catch
		{
			SimpleMating = false;
			AutoSort = false;
			PlayBGM = true;
			FastText = false;
			ShowFPS = false;
			BigWindow = false;
			HighQuality = false;
			AntiAliasing = false;
			SensesButton = false;
			FixInfo = false;
			JsonButton = false;
			TranslateJson = false;
			MoveButton = false;
			StaminaButton = false;
			RefreshStoreEveryTime = false;
			AlwaysUseName = false;
			MoveInsectMask = true;
			//EncryptSave = true;
			//DecryptLoad = true;
		}
		if (!PlayBGM)
		{
			//Sounds.OPBGM = new SoundPlayer(CurrentDirectory + "\\bgm\\doesntexist", Loop: true);
			//Sounds.日常BGM = new SoundPlayer(CurrentDirectory + "\\bgm\\doesntexist2", Loop: true);
		}
	}

	static Sta()
	{
		胴体 = Resources.胴体.ObjLoad();
		//胴体.SaveExMod("C:\\Users\\dave\\Documents\\胴体");
		//Ser.ToJson(胴体, "C:\\Users\\dave\\Documents\\胴体.json");
		//胴体 = Ser.UnJson<Obj>("C:\\Users\\dave\\Documents\\胴体.json");

		肩左 = Resources.肩左.ObjLoad();
        //肩左.SaveExMod("C:\\Users\\dave\\Documents\\肩左");
        //Ser.ToJson(肩左, "C:\\Users\\dave\\Documents\\肩左.json");
        //肩左 = Ser.UnJson<Obj>("C:\\Users\\dave\\Documents\\肩左.json");

        腕左 = Resources.腕左.ObjLoad();
        //腕左.SaveExMod("C:\\Users\\dave\\Documents\\腕左");
        //Ser.ToJson(腕左, "C:\\Users\\dave\\Documents\\腕左.json");
        //腕左 = Ser.UnJson<Obj>("C:\\Users\\dave\\Documents\\腕左.json");


        脚左 = Resources.脚左.ObjLoad();
        //脚左.SaveExMod("C:\\Users\\dave\\Documents\\脚左");
        //Ser.ToJson(脚左, "C:\\Users\\dave\\Documents\\脚左.json");
        //脚左 = Ser.UnJson<Obj>("C:\\Users\\dave\\Documents\\脚左.json");

        尻尾 = Resources.尻尾.ObjLoad();
        //尻尾.SaveExMod("C:\\Users\\dave\\Documents\\尻尾");
        //Ser.ToJson(尻尾, "C:\\Users\\dave\\Documents\\尻尾.json");
        //尻尾 = Ser.UnJson<Obj>("C:\\Users\\dave\\Documents\\尻尾.json");

        半身 = Resources.半身.ObjLoad();
        //半身.SaveExMod("C:\\Users\\dave\\Documents\\半身");
        //Ser.ToJson(半身, "C:\\Users\\dave\\Documents\\半身.json");
        //半身 = Ser.UnJson<Obj>("C:\\Users\\dave\\Documents\\半身.json");

        肢左 = Resources.肢左.ObjLoad();
        //肢左.SaveExMod("C:\\Users\\dave\\Documents\\肢左");
        //Ser.ToJson(肢左, "C:\\Users\\dave\\Documents\\肢左.json");
        //肢左 = Ser.UnJson<Obj>("C:\\Users\\dave\\Documents\\肢左.json");

        肢中 = Resources.肢中.ObjLoad();
        //肢中.SaveExMod("C:\\Users\\dave\\Documents\\肢中");
        //Ser.ToJson(肢中, "C:\\Users\\dave\\Documents\\肢中.json");
        //肢中 = Ser.UnJson<Obj>("C:\\Users\\dave\\Documents\\肢中.json");

        性器 = Resources.性器.ObjLoad();
        //性器.SaveExMod("C:\\Users\\dave\\Documents\\性器");
        //Ser.ToJson(性器, "C:\\Users\\dave\\Documents\\性器.json");
        //性器 = Ser.UnJson<Obj>("C:\\Users\\dave\\Documents\\性器.json");

        性器付 = Resources.性器付.ObjLoad();
        //性器付.SaveExMod("C:\\Users\\dave\\Documents\\性器付");
        //Ser.ToJson(性器付, "C:\\Users\\dave\\Documents\\性器付.json");
        //性器付 = Ser.UnJson<Obj>("C:\\Users\\dave\\Documents\\性器付.json");

        スタンプ = Resources.スタンプ.ObjLoad();
        //スタンプ.SaveExMod("C:\\Users\\dave\\Documents\\スタンプ");
        //Ser.ToJson(スタンプ, "C:\\Users\\dave\\Documents\\スタンプ.json");
        //スタンプ = Ser.UnJson<Obj>("C:\\Users\\dave\\Documents\\スタンプ.json");

        カーソル = Resources.カーソル.ObjLoad();
        //カーソル.SaveExMod("C:\\Users\\dave\\Documents\\カーソル");
        //Ser.ToJson(カーソル, "C:\\Users\\dave\\Documents\\カーソル.json");
        //カーソル = Ser.UnJson<Obj>("C:\\Users\\dave\\Documents\\カーソル.json");

        その他 = Resources.その他.ObjLoad();
        //その他.SaveExMod("C:\\Users\\dave\\Documents\\その他");
        //Ser.ToJson(その他, "C:\\Users\\dave\\Documents\\その他.json");
        //その他 = Ser.UnJson<Obj>("C:\\Users\\dave\\Documents\\その他.json");

        タイル = Resources.タイル.ObjLoad();
        //タイル.SaveExMod("C:\\Users\\dave\\Documents\\タイル");
        //Ser.ToJson(タイル, "C:\\Users\\dave\\Documents\\タイル.json");
        //タイル = Ser.UnJson<Obj>("C:\\Users\\dave\\Documents\\タイル.json");

        MaxAre = 0.0584246154149664;
		Elet = typeof(Ele);
		EleDt = typeof(EleD);
		胸t = typeof(胸);
		肩t = typeof(肩);
		胴t = typeof(胴);
		腰t = typeof(腰);
		尾_鯨t = typeof(尾_鯨);
		上腕_人t = typeof(上腕_人);
		上腕_鳥t = typeof(上腕_鳥);
		長物_鯨t = typeof(長物_鯨);
		後髪0_ジグDt = typeof(後髪0_ジグD);
		後髪0_ハネDt = typeof(後髪0_ハネD);
		後髪0_パツDt = typeof(後髪0_パツD);
		後髪0_カルDt = typeof(後髪0_カルD);
		後髪0_肢系Dt = typeof(後髪0_肢系D);
		耳_人Dt = typeof(耳_人D);
		耳_尖Dt = typeof(耳_尖D);
		耳_長Dt = typeof(耳_長D);
		耳_鰭Dt = typeof(耳_鰭D);
		耳_羽Dt = typeof(耳_羽D);
		耳_獣Dt = typeof(耳_獣D);
		肩Dt = typeof(肩D);
		角1_一Dt = typeof(角1_一D);
		角1_鬼Dt = typeof(角1_鬼D);
		角1_虫Dt = typeof(角1_虫D);
		角2_山1Dt = typeof(角2_山1D);
		角2_山2Dt = typeof(角2_山2D);
		角2_山3Dt = typeof(角2_山3D);
		角2_巻Dt = typeof(角2_巻D);
		角2_牛1Dt = typeof(角2_牛1D);
		角2_牛2Dt = typeof(角2_牛2D);
		角2_牛3Dt = typeof(角2_牛3D);
		角2_牛4Dt = typeof(角2_牛4D);
		角2_鬼Dt = typeof(角2_鬼D);
		角2_虫Dt = typeof(角2_虫D);
		花_薔Dt = typeof(花_薔D);
		花_百Dt = typeof(花_百D);
		顔面_甲Dt = typeof(顔面_甲D);
		顔面_虫Dt = typeof(顔面_虫D);
		顔面_蟲Dt = typeof(顔面_蟲D);
		頭頂_宇Dt = typeof(頭頂_宇D);
		頭頂_皿Dt = typeof(頭頂_皿D);
		頭頂_天Dt = typeof(頭頂_天D);
		頭頂後_宇Dt = typeof(頭頂後_宇D);
		背中_羽Dt = typeof(背中_羽D);
		背中_甲Dt = typeof(背中_甲D);
		背中_光Dt = typeof(背中_光D);
		触覚_線Dt = typeof(触覚_線D);
		触覚_節Dt = typeof(触覚_節D);
		触覚_甲Dt = typeof(触覚_甲D);
		触覚_蝶Dt = typeof(触覚_蝶D);
		触覚_蛾Dt = typeof(触覚_蛾D);
		触覚_蠍Dt = typeof(触覚_蠍D);
		尾_猫Dt = typeof(尾_猫D);
		尾_犬Dt = typeof(尾_犬D);
		尾_狐Dt = typeof(尾_狐D);
		尾_馬Dt = typeof(尾_馬D);
		尾_牛Dt = typeof(尾_牛D);
		尾_龍Dt = typeof(尾_龍D);
		尾_竜Dt = typeof(尾_竜D);
		尾_悪Dt = typeof(尾_悪D);
		尾_淫Dt = typeof(尾_淫D);
		尾_鳥Dt = typeof(尾_鳥D);
		尾_虫Dt = typeof(尾_虫D);
		尾_蜘Dt = typeof(尾_蜘D);
		尾_蠍Dt = typeof(尾_蠍D);
		尾_蛇Dt = typeof(尾_蛇D);
		尾_腓Dt = typeof(尾_腓D);
		尾_短Dt = typeof(尾_短D);
		尾_ヘDt = typeof(尾_ヘD);
		尾_ガDt = typeof(尾_ガD);
		尾_ウDt = typeof(尾_ウD);
		尾_魚Dt = typeof(尾_魚D);
		尾_鯨Dt = typeof(尾_鯨D);
		尾_蟲Dt = typeof(尾_蟲D);
		尾_根Dt = typeof(尾_根D);
		尾鰭_魚Dt = typeof(尾鰭_魚D);
		尾鰭_鯨Dt = typeof(尾鰭_鯨D);
		鰭_魚Dt = typeof(鰭_魚D);
		鰭_豚Dt = typeof(鰭_豚D);
		鰭_鯨Dt = typeof(鰭_鯨D);
		葉_披Dt = typeof(葉_披D);
		葉_心Dt = typeof(葉_心D);
		前翅_甲Dt = typeof(前翅_甲D);
		前翅_羽Dt = typeof(前翅_羽D);
		前翅_蝶Dt = typeof(前翅_蝶D);
		前翅_草Dt = typeof(前翅_草D);
		後翅_甲Dt = typeof(後翅_甲D);
		後翅_羽Dt = typeof(後翅_羽D);
		後翅_蝶Dt = typeof(後翅_蝶D);
		後翅_草Dt = typeof(後翅_草D);
		触肢_肢蜘Dt = typeof(触肢_肢蜘D);
		触肢_肢蠍Dt = typeof(触肢_肢蠍D);
		節足_足蜘Dt = typeof(節足_足蜘D);
		節足_足蠍Dt = typeof(節足_足蠍D);
		節足_足百Dt = typeof(節足_足百D);
		節尾_曳航Dt = typeof(節尾_曳航D);
		節尾_鋏Dt = typeof(節尾_鋏D);
		触手_軟Dt = typeof(触手_軟D);
		触手_触Dt = typeof(触手_触D);
		触手_犬Dt = typeof(触手_犬D);
		触手_蔦Dt = typeof(触手_蔦D);
		上腕_人Dt = typeof(上腕_人D);
		上腕_鳥Dt = typeof(上腕_鳥D);
		上腕_蝙Dt = typeof(上腕_蝙D);
		上腕_獣Dt = typeof(上腕_獣D);
		上腕_蹄Dt = typeof(上腕_蹄D);
		下腕_人Dt = typeof(下腕_人D);
		下腕_鳥Dt = typeof(下腕_鳥D);
		下腕_蝙Dt = typeof(下腕_蝙D);
		獣下腕Dt = typeof(獣下腕D);
		下腕_獣Dt = typeof(下腕_獣D);
		下腕_蹄Dt = typeof(下腕_蹄D);
		手_人Dt = typeof(手_人D);
		手_鳥Dt = typeof(手_鳥D);
		手_蝙Dt = typeof(手_蝙D);
		手_獣Dt = typeof(手_獣D);
		手_馬Dt = typeof(手_馬D);
		手_牛Dt = typeof(手_牛D);
		腿_人Dt = typeof(腿_人D);
		腿_獣Dt = typeof(腿_獣D);
		腿_蹄Dt = typeof(腿_蹄D);
		腿_鳥Dt = typeof(腿_鳥D);
		腿_竜Dt = typeof(腿_竜D);
		脚_人Dt = typeof(脚_人D);
		脚_獣Dt = typeof(脚_獣D);
		脚_蹄Dt = typeof(脚_蹄D);
		脚_鳥Dt = typeof(脚_鳥D);
		脚_竜Dt = typeof(脚_竜D);
		足_人Dt = typeof(足_人D);
		足_獣Dt = typeof(足_獣D);
		足_馬Dt = typeof(足_馬D);
		足_牛Dt = typeof(足_牛D);
		足_鳥Dt = typeof(足_鳥D);
		足_竜Dt = typeof(足_竜D);
		四足脇Dt = typeof(四足脇D);
		胴_蛇Dt = typeof(胴_蛇D);
		胴_蟲Dt = typeof(胴_蟲D);
		大顎基Dt = typeof(大顎基D);
		鳳凰Dt = typeof(鳳凰D);
		大顎Dt = typeof(大顎D);
		虫顎Dt = typeof(虫顎D);
		虫鎌Dt = typeof(虫鎌D);
		獣耳Dt = typeof(獣耳D);
		植Dt = typeof(植D);
		拘束鎖t = typeof(拘束鎖).ToString();
		lt = typeof(List<EleD>).ToString();
		at = typeof(Ele[]).ToString();
		cdt = typeof(ColorD).ToString();
		cpt = typeof(ColorP).ToString();
		Bodt = typeof(Bod);
		dt = typeof(double).ToString();
		bt = typeof(bool).ToString();
		ct = typeof(Color).ToString();
		左右無し = new HashSet<ConnectionInfo>(new ConnectionInfo[67]
		{
			ConnectionInfo.none,
			ConnectionInfo.頭_基髪_接続,
			ConnectionInfo.頭_鼻_接続,
			ConnectionInfo.頭_口_接続,
			ConnectionInfo.頭_額_接続,
			ConnectionInfo.頭_鼻肌_接続,
			ConnectionInfo.頭_単眼目_接続,
			ConnectionInfo.頭_単眼眉_接続,
			ConnectionInfo.頭_大顎基_接続,
			ConnectionInfo.頭_顔面_接続,
			ConnectionInfo.頭_頭頂_接続,
			ConnectionInfo.基髪_前髪_接続,
			ConnectionInfo.基髪_後髪_接続,
			ConnectionInfo.後髪0_肢系_中央_接続,
			ConnectionInfo.単目_瞼_接続,
			ConnectionInfo.縦目_瞼_接続,
			ConnectionInfo.吹出し_吹出し_接続,
			ConnectionInfo.首_頭_接続,
			ConnectionInfo.胸_首_接続,
			ConnectionInfo.胸_肌_接続,
			ConnectionInfo.胸_背中_接続,
			ConnectionInfo.胴_胸_接続,
			ConnectionInfo.胴_肌_接続,
			ConnectionInfo.腰_胴_接続,
			ConnectionInfo.腰_肌_接続,
			ConnectionInfo.腰_膣基_接続,
			ConnectionInfo.腰_肛門_接続,
			ConnectionInfo.腰_尾_接続,
			ConnectionInfo.腰_半身_接続,
			ConnectionInfo.腰_上着_接続,
			ConnectionInfo.ボテ腹_人_腹板_接続,
			ConnectionInfo.ボテ腹_獣_腹板_接続,
			ConnectionInfo.肛門_人_肛門精液_接続,
			ConnectionInfo.肛門_獣_肛門精液_接続,
			ConnectionInfo.性器_人_陰核_接続,
			ConnectionInfo.性器_人_尿道_接続,
			ConnectionInfo.性器_人_膣口_接続,
			ConnectionInfo.性器_獣_陰核_接続,
			ConnectionInfo.性器_獣_尿道_接続,
			ConnectionInfo.性器_獣_膣口_接続,
			ConnectionInfo.上着ボトム_クロス_上着ボトム後_接続,
			ConnectionInfo.頭頂_宇_頭部後_接続,
			ConnectionInfo.尾_ヘ_尾先_接続,
			ConnectionInfo.尾_ウ_尾先_接続,
			ConnectionInfo.尾_魚_尾先_接続,
			ConnectionInfo.尾_鯨_尾先_接続,
			ConnectionInfo.長物_魚_尾_接続,
			ConnectionInfo.長物_鯨_尾_接続,
			ConnectionInfo.長物_蛇_胴_接続,
			ConnectionInfo.長物_蟲_胴_接続,
			ConnectionInfo.四足胸_胴_接続,
			ConnectionInfo.四足胸_肌_接続,
			ConnectionInfo.四足胸_背中_接続,
			ConnectionInfo.四足胴_腰_接続,
			ConnectionInfo.四足胴_肌_接続,
			ConnectionInfo.四足腰_膣基_接続,
			ConnectionInfo.四足腰_肛門_接続,
			ConnectionInfo.四足腰_尾_接続,
			ConnectionInfo.四足腰_半身_接続,
			ConnectionInfo.四足腰_上着_接続,
			ConnectionInfo.四足腰_肌_接続,
			ConnectionInfo.多足_蜘_尾_接続,
			ConnectionInfo.多足_蠍_尾_接続,
			ConnectionInfo.単足_植_根中央_接続,
			ConnectionInfo.胴_蛇_胴_接続,
			ConnectionInfo.胴_蟲_胴_接続,
			ConnectionInfo.ペニス_尿道_接続
		});
		接続情報t = typeof(ConnectionInfo);
		bf = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
		bfi = bf | BindingFlags.InvokeMethod;
		髪留2初期化 = default(髪留2情報);
		玉口枷初期化 = default(玉口枷情報);
		目隠帯初期化 = default(目隠帯情報);
		拘束具初期化 = default(拘束具情報);
		ピアス初期化 = default(ピアス情報);
		キャップ初期化 = default(キャップ情報);
		ドレス首初期化 = default(ドレス首情報);
		下着T_チューブ初期化 = default(下着T_チューブ情報);
		下着T_クロス初期化 = default(下着T_クロス情報);
		下着T_ビキニ初期化 = default(下着T_ビキニ情報);
		下着T_マイクロ初期化 = default(下着T_マイクロ情報);
		下着T_ブラ初期化 = default(下着T_ブラ情報);
		下着B_ノーマル初期化 = default(下着B_ノーマル情報);
		下着B_マイクロ初期化 = default(下着B_マイクロ情報);
		ドレス初期化 = default(ドレス情報);
		上着B_クロス初期化 = default(上着B_クロス情報);
		上着B_前掛け初期化 = default(上着B_前掛け情報);
		ブーツ初期化 = default(ブーツ情報);
		CurrentDirectory = Directory.GetCurrentDirectory();
		GameData = new GameState();
		SavePath = CurrentDirectory + "\\save";
		ImiPath = CurrentDirectory + "\\text\\Basement\\Training\\Imitation.txt";
		PanPath = CurrentDirectory + "\\text\\Basement\\Training\\Pant";

		/*
		po3 = new ParallelOptions
		{
			MaxDegreeOfParallelism = 3
		};*/
		ConfigPath = CurrentDirectory + "\\Config.ini";
		SimpleMating = false;
		AutoSort = false;
	}

	public static void GDSaveJson(int i)
	{
		for (int j = 0; j < GameData.Gen.Length; j++)
		{
			GameData.Gen[j].Buf.Clear();
		}
		string path = JsonSavePath + "\\" + i + "： " + GameData.GetSaveDateString().Replace("/", "_") + ".json";
		GameData.ToJson(path);
		if (TranslateJson)
		{
			Translate(path, 0);
		}
	}

	public static string[] JSDPaths()
	{
		JsonSavePath = CurrentDirectory + "\\save\\json";
		IEnumerable<string> source = Directory.EnumerateFiles(JsonSavePath);
		return new string[10]
		{
			source.FirstOrDefault((string e) => e.StartsWith(JsonSavePath + "\\0： ")),
			source.FirstOrDefault((string e) => e.StartsWith(JsonSavePath + "\\1： ")),
			source.FirstOrDefault((string e) => e.StartsWith(JsonSavePath + "\\2： ")),
			source.FirstOrDefault((string e) => e.StartsWith(JsonSavePath + "\\3： ")),
			source.FirstOrDefault((string e) => e.StartsWith(JsonSavePath + "\\4： ")),
			source.FirstOrDefault((string e) => e.StartsWith(JsonSavePath + "\\5： ")),
			source.FirstOrDefault((string e) => e.StartsWith(JsonSavePath + "\\6： ")),
			source.FirstOrDefault((string e) => e.StartsWith(JsonSavePath + "\\7： ")),
			source.FirstOrDefault((string e) => e.StartsWith(JsonSavePath + "\\8： ")),
			source.FirstOrDefault((string e) => e.StartsWith(JsonSavePath + "\\9： "))
		};
	}

	public static string Translate(string Path, int Mode)
	{
		TranslateJsonFile = CurrentDirectory + "\\text\\Translate.json";
		TranslateDict = Ser.UnJson<Dictionary<string, string>>(TranslateJsonFile);
		string input = File.ReadAllText(Path);
		switch (Mode)
		{
		case 0:
			input = new Regex("\\\"(.+)\\\"\\:", RegexOptions.Compiled).Replace(input, (Match match) => (!TranslateDict.ContainsKey(match.Groups[1].Value)) ? match.Value : ("\"" + TranslateDict[match.Groups[1].Value] + "\":"));
			File.WriteAllText(Path, input);
			return input;
		case 1:
			TranslateDict = TranslateDict.ToDictionary((KeyValuePair<string, string> x) => x.Value, (KeyValuePair<string, string> x) => x.Key);
			return new Regex("\\\"(.+)\\\"\\:", RegexOptions.Compiled).Replace(input, (Match match) => (!TranslateDict.ContainsKey(match.Groups[1].Value)) ? match.Value : ("\"" + TranslateDict[match.Groups[1].Value] + "\":"));
		default:
			return "null";
		}
	}
}
