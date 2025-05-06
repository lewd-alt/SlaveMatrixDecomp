using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2DGAMELIB;
using SlaveMatrix.Properties;

namespace SlaveMatrix;

public static class Mods
{
	private static SubInfo si;

	public static ヴィオラ台詞 ヴィオラ台詞;

	public static キャラ台詞 キャラ台詞;

	private static ListView SaveData;

	private static InfoPanel ip;

	private static Buts dbs;

	private static Cha TrainingTarget;

	public static 吹き出し キャラ吹出し;

	private static Cha Viola;

	public static 吹き出し ヴィオラ吹出し;

	private static Lab npl;

	public static Are DrawBuffer;

	public static Are BlackBackground;

	public static Are BasementBackground;

	public static Are OfficeBackground;

	public static Are drawArea;

	private static MotV mv;

	private static bool sta;

	private static double v;

	private static Action<Are, FPS> メインフォーム描画;

	private static Action<Are, FPS> 調教描画;

	public static Action<Are, FPS> 撮影描画;

	private static Action<Are, FPS> 対象描画;

	private static Action<Are, FPS> DrawBlessing;

	private static Action<Are, FPS> DrawOffice;

	private static Action<Are, FPS> DrawDebt;

	private static Action<Are, FPS> DrawSlaveShop;

	private static Action<Are, FPS> DrawToolShop;

	private static Action<Are, FPS> 中継描画;

	private static Action<Are, FPS> DrawOP0;

	private static Action<Are, FPS> DrawOP1;

	private static Action<Are, FPS> 説明描画;

	private static Action<Are, FPS> 初事務所描画;

	private static Action<Are, FPS> 返済イベント描画;

	private static Action<Are, FPS> 日数進行描画;

	private static Action<Are, FPS> PlayerInformationSliders;

	public const double 初期利子 = 0.002;

	public const ulong 開始借金額 = 5000000000uL;

	public const ulong 日借金上限 = 50000000uL;

	public static ulong 単位返済段階額;

	public const ulong MaxMoney = 9999999999999uL;

	public const ulong MinMoney = 0uL;

	public static double DemandMax;

	public static bool SDShow;

	public static bool save;

	public static bool title;

	public static bool processing;

	private static Action 対象UI初期化;

	private static Action 奴隷UI初期化;

	private static string[] 日終了ログa;

	public static ulong 労働利益;

	public static ulong 日利益額;

	public static ulong 日利子額;

	private const int ml = 19;

	private static bool dayp;

	private static CancellationTokenSource cts;

	public static Task t1;

	private static bool start;

	private const ulong 遺伝情報変更価格 = 10000000uL;

	public const int 最大フロア数 = 9;

	private static bool 調教前調教済みフラグ;

	public const bool v3 = false;

	public const bool 体験版 = false;

	public static int MaxRoomNumber => 135;

	public static Dictionary<string, Module> GetMods(Med Med)
	{
		Sta.LoadConfig();
		Sta.タイル準備();
		Sta.Set擬音();
		Sta.Set喘ぎ();

		drawArea = new Are(Med, Hit: false);
		drawArea.Setting();

		DrawBuffer = new Are(Med, Hit: true);
		DrawBuffer.Setting();
		BlackBackground = new Are(Med, Hit: true);
		BlackBackground.Setting();
		BlackBackground.Clear(Col.Black);
		BasementBackground = new Are(Med, Hit: true);
		BasementBackground.Setting();
		using (Bitmap image = new Bitmap(new MemoryStream(Resources.dangeon01_ex2)))
		{
			BasementBackground.GD.DrawImage(image, BasementBackground.Dis.GetRect());
		}
		OfficeBackground = new Are(Med, Hit: true);
		OfficeBackground.Setting();
		using (Bitmap image2 = new Bitmap(new MemoryStream(Resources.li_room10a_c_ex2)))
		{
			OfficeBackground.GD.DrawImage(image2, OfficeBackground.Dis.GetRect());
		}
		SaveData = new ListView(DrawBuffer, Dat.Vec2DZero.AddY(0.0025), 0.25, new Font("MS Gothic", 1f), 0.11, Col.White, Col.Empty, Col.Black, Col.Empty, Enumerable.Repeat(new TA(new string('A', 15), delegate
		{
		}), 10).ToArray());
		SaveData.SetHitColor(Med);
		dbs = new Buts();
		ParT parT = new ParT();
		double y = 0.9075;
		if (Program.biggerWindow)
		{
			y = 0.932;
		}
		parT.Font = new Font("MS Gothic", 0.1f);
		parT.PositionBase = DrawBuffer.GetPosition(-0.001, y);
		parT.Text = "Player";
		parT.FontSize = 0.14;
		parT.SizeBase = 0.05;
		parT.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
		parT.Closed = true;
		parT.TextColor = Col.White;
		parT.BrushColor = Color.FromArgb(160, Col.Black);
		parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT.StringFormat.Alignment = StringAlignment.Center;
		parT.StringFormat.LineAlignment = StringAlignment.Center;
		dbs.Add("プレイヤー", new But1(parT, delegate
		{
			if (Sta.GameData.所持金 < 10000000)
			{
				ip.SubInfoIm = GameText.所持金が足りません;
			}
			else
			{
				Sounds.精算.Play();
				Sta.GameData.所持金 -= 10000000uL;
				ip.UpdateSub2();

				//note: removed 50ms timeout -- could add back with mot...
				Med.InvokeL(delegate
				{
					Med.SwitchMode("PlayerInformation", DrawBuffer, PlayerInformationSliders);
				});
			}
		}));
		ParT parT2 = new ParT();
		parT2.Font = new Font("MS Gothic", 0.1f);
		double x = 0.699;
		if (Program.biggerWindow)
		{
			x = 0.77;
		}
		parT2.PositionBase = DrawBuffer.GetPosition(x, y);
		parT2.Text = "Title";
		parT2.FontSize = 0.14;
		parT2.SizeBase = 0.05;
		parT2.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT2.OP.ScalingXY(parT2.OP.GetCenter(), 0.87, 0.23);
		parT2.Closed = true;
		parT2.TextColor = Col.White;
		parT2.BrushColor = Color.FromArgb(160, Col.Black);
		parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT2.StringFormat.Alignment = StringAlignment.Center;
		parT2.StringFormat.LineAlignment = StringAlignment.Center;
		dbs.Add("タイトル", new But1(parT2, delegate
		{
			Sounds.操作.Play();
			string tb = ((ip.TextIm == "") ? " " : ip.TextIm);
			bool sb = ip.MaiShow;
			ip.MaiShow = true;
			ip.TextIm = GameText.タイトル画面に戻りますか;
			ip.選択yAct = delegate
			{
				Sounds.操作.Play();
				Med.Mode = "Title";
				Color HitColor4 = Col.Empty;
				dbs.Move(ref HitColor4);
				ip.選択肢表示 = false;
			};
			ip.選択nAct = delegate
			{
				Sounds.操作.Play();
				ip.TextIm = tb;
				ip.MaiShow = sb;
				Color HitColor3 = Col.Empty;
				dbs.Move(ref HitColor3);
				ip.選択肢表示 = false;
			};
			ip.選択肢表示 = true;
		}));
		ParT parT3 = new ParT();
		parT3.Font = new Font("MS Gothic", 0.1f);
		x = 0.895;
		if (Program.biggerWindow)
		{
			x = 0.92;
		}
		parT3.PositionBase = DrawBuffer.GetPosition(x, y);
		parT3.Text = "Save";
		parT3.FontSize = 0.14;
		parT3.SizeBase = 0.05;
		parT3.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT3.OP.ScalingXY(parT3.OP.GetCenter(), 0.87, 0.23);
		parT3.Closed = true;
		parT3.TextColor = Col.White;
		parT3.BrushColor = Color.FromArgb(160, Col.Black);
		parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT3.StringFormat.Alignment = StringAlignment.Center;
		parT3.StringFormat.LineAlignment = StringAlignment.Center;
		dbs.Add("セーブ", new But1(parT3, delegate
		{
			Sounds.操作.Play();
			SaveData.bs["0"].Dra = false;
			save = true;
			SetSLlv(Med);
			Color HitColor2 = Col.Empty;
			SaveData.Move(ref HitColor2);
			SDShow = true;
			ip.SubInfoIm = "RCl:" + GameText.戻る;
		}));
		ParT parT4 = new ParT();
		parT4.Font = new Font("MS Gothic", 0.1f);
		x = 0.797;
		if (Program.biggerWindow)
		{
			x = 0.845;
		}
		parT4.PositionBase = DrawBuffer.GetPosition(x, y);
		parT4.Text = "Load";
		parT4.FontSize = 0.14;
		parT4.SizeBase = 0.05;
		parT4.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT4.OP.ScalingXY(parT4.OP.GetCenter(), 0.87, 0.23);
		parT4.Closed = true;
		parT4.TextColor = Col.White;
		parT4.BrushColor = Color.FromArgb(160, Col.Black);
		parT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT4.HitColor = Med.GetUniqueColor();
		parT4.StringFormat.Alignment = StringAlignment.Center;
		parT4.StringFormat.LineAlignment = StringAlignment.Center;
		dbs.Add("ロード", new But1(parT4, delegate
		{
			Sounds.操作.Play();
			SaveData.bs["0"].Dra = true;
			save = false;
			title = false;
			SetSLlv(Med);
			Color HitColor = Col.Empty;
			SaveData.Move(ref HitColor);
			SDShow = true;
			ip.SubInfoIm = "RCl:" + GameText.戻る;
		}));
		NewButtons(Med);
		dbs.SetHitColor(Med);
		ip = new InfoPanel(Med, DrawBuffer);
		ip.SetHitColor(Med);
		ヴィオラ吹出し = new 吹き出し(DrawBuffer, 右: false, new Font("MS Gothic", 1f), 0.08, " ", Col.White, Col.Black, Color.FromArgb(160, Col.Black), 19.0, Dis: false, Col.White, delegate
		{
		});
		ヴィオラ吹出し.SetHitColor(Med);
		キャラ吹出し = new 吹き出し(DrawBuffer, 右: false, new Font("MS Gothic", 1f), 0.08, " ", Col.White, Col.Black, Color.FromArgb(160, Col.Black), 19.0, Dis: true);
		キャラ吹出し.SetHitColor(Med);
		si = new SubInfo(Med, ip);
		ヴィオラ台詞 = new ヴィオラ台詞(Med, ヴィオラ吹出し);
		キャラ台詞 = new キャラ台詞(Med, キャラ吹出し);
		npl = new Lab(Med, DrawBuffer, "ラベル1", new Vector2D(ip.MaiB.Position.X, 0.026), 0.1, 1.5, new Font("MS Gothic", 1f), 0.085, "No Slave", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		return new Dictionary<string, Module>
		{
			{
				"Start",
				Start(Med)
			},
			{
				"Credit",
				Credit(Med)
			},
			{
				"Title",
				Title(Med)
			},
			{
				"メインフォーム",
				メインフォーム(Med)
			},
			{
				"対象",
				対象(Med)
			},
			{
				"Training",
				Training(Med)
			},
			{
				"Blessing",
				Blessing(Med)
			},
			{
				"Office",
				Office(Med)
			},
			{
				"Debt",
				Debt(Med)
			},
			{
				"SlaveShop",
				SlaveShop(Med)
			},
			{
				"ToolShop",
				ToolShop(Med)
			},
			{
				"調教中継行",
				調教中継行(Med)
			},
			{
				"調教中継帰",
				調教中継帰(Med)
			},
			{
				"StartOfDay",
				StartOfDay(Med)
			},
			{
				"PlayerInformation",
				PlayerInformation(Med)
			},
			{
				"OP0",
				OP0(Med)
			},
			{
				"OP1",
				OP1(Med)
			},
			{
				"説明",
				説明(Med)
			},
			{
				"初事務所",
				初事務所(Med)
			},
			{
				"RepaymentEvent1",
				RepaymentEvent1(Med)
			},
			{
				"RepaymentEvent2",
				RepaymentEvent2(Med)
			},
			{
				"RepaymentEvent3",
				RepaymentEvent3(Med)
			},
			{
				"ViolaBlessing",
				ViolaBlessing(Med)
			}
		};
	}

	public static void Dispose()
	{
		drawArea.Dispose();
		DrawBuffer.Dispose();
		BlackBackground.Dispose();
		BasementBackground.Dispose();
		OfficeBackground.Dispose();
		if (TrainingTarget != null)
		{
			TrainingTarget.Dispose();
		}
		キャラ吹出し.Dispose();
		if (Viola != null)
		{
			Viola.Dispose();
		}
		ヴィオラ吹出し.Dispose();
		SaveData.Dispose();
		ip.Dispose();
		dbs.Dispose();
		npl.Dispose();
	}

	private static void SwitchMode(Med Med, Are Are, FPS FPS, Action<Are, FPS> 描画)
	{
		if (sta)
		{
			if (v < mv.Max)
			{
				mv.GetValue(FPS);
				v = mv.Value;
				if (sta)
				{
					Med.FadeIn(v);
				}
			}
			else
			{
				sta = false;
				v = 0.0;
				mv.ResetValue();
			}
		}
		else
		{
			描画(Are, FPS);
		}
	}

	public static void SwitchMode(this Med Med, string Mode, Are Are)
	{
		Med.Mode = Mode;
		Med.DrawStart(Are);
		Med.DrawEnd(BlackBackground);
		sta = true;
	}

	public static void SwitchMode(this Med Med, string Mode, Are Are, Action<Are, FPS> 描画)
	{
		Med.Mode = Mode;
		描画(drawArea, Med.FPSF);
		Med.DrawStart(Are);
		Med.DrawEnd(drawArea);
		sta = true;
	}

	public static void SetDemandMaximum()
	{
		if (Sta.GameData.RepaymentStage == 0)
		{
			DemandMax = 8.0;
		}
		else if (Sta.GameData.RepaymentStage == 1)
		{
			DemandMax = 9.0;
		}
		else if (Sta.GameData.RepaymentStage == 2)
		{
			DemandMax = 10.0;
		}
		else
		{
			DemandMax = 11.0;
		}
	}

	public static ulong 加算(this ulong u0, ulong u1)
	{
		checked
		{
			try
			{
				if (u0 + u1 > 9999999999999L)
				{
					return 9999999999999uL;
				}
				return u0 + u1;
			}
			catch
			{
				return 9999999999999uL;
			}
		}
	}

	public static ulong 減算(this ulong u0, ulong u1)
	{
		if (u0 < u1)
		{
			return 0uL;
		}
		return u0 - u1;
	}

	public static void SetSLlv(Med Med)
	{
		SaveData.Acts = sllv(Med);
	}

	private static IEnumerable<TA> sllv(Med Med)
	{
		int j = 0;
		string[] array = Sta.SDPaths();
		foreach (string text in array)
		{
			string path = text;
			int i = j;
			bool f = path == null;
			yield return new TA(f ? (i + ": No data") : Path.GetFileNameWithoutExtension(path).Replace("：", ":").Replace("_", "/"), delegate
			{
				if (!processing)
				{
					Sounds.操作.Play();
					if (save)
					{
						processing = true;
						Save(path, i, Med);
					}
					else if (!f)
					{
						processing = true;
						Load(path, i, Med);
					}
				}
			});
			j++;
		}
	}

	private static void AutoSave()
	{
		string s = Sta.SavePath + "\\0： ";
		foreach (string item in from e in Directory.EnumerateFiles(Sta.SavePath)
			where e.StartsWith(s)
			select e)
        {
            System.IO.File.Delete(item);
        }
		Sta.GDSave(0);
	}

	private static void Save(string Path, int i, Med Med)
	{
		ip.SubInfoIm = GameText.セーブ中です + "\r\n" + GameText.しばらくお待ちください;

		if (Path != null)
		{
            System.IO.File.Delete(Path);
		}
		Sta.GDSave(i);
		SetSLlv(Med);
		SDShow = false;
		ip.SubInfoIm = i + ": " + Sta.GameData.GetSaveDateString() + "\r\n" + GameText.セーブしました;
		processing = false;
		Med.InvokeL(Sounds.完了.Play);
	}

	private static void Load(string Path, int i, Med Med)
	{
		cts.Cancel();
		ip.SubInfoIm = GameText.ロード中です + "\r\n" + GameText.しばらくお待ちください;
		
		Sta.GameData = Path.LoadExMod<GameState>();
		Cha d = Viola;
		Viola = new Cha(Med, DrawBuffer, Sta.GameData.ヴィオラ.ChaD);
		Viola.Set衣装(Sta.GameData.ヴィオラ.着衣);
		ヴィオラ吹出し.接続(Viola.Bod.頭.口_接続点);
		Med.InvokeL(delegate
		{
			Initialize();
			if (d != null)
			{
				d.Dispose();
			}
			if (TrainingTarget != null)
			{
				TrainingTarget.Dispose();
				TrainingTarget = null;
			}
			SDShow = false;
			if (title)
			{
				Med.SwitchMode("メインフォーム", DrawBuffer, メインフォーム描画);
			}
			else
			{
				Med.Mode = "メインフォーム";
				ip.SubInfoIm = i + ": " + Sta.GameData.GetSaveDateString() + "\r\n" + GameText.ロードしました;
			}
			processing = false;
			SetDemandMaximum();
			if (Sta.GameData.Slaves.Length < MaxRoomNumber)
			{
				Unit[] array = new Unit[MaxRoomNumber];
				Array.Copy(Sta.GameData.Slaves, array, Sta.GameData.Slaves.Length);
				Sta.GameData.Slaves = array;
			}
			Med.InvokeL(Sounds.完了.Play);
		});
	}

	private static void Initialize()
	{
		ロード時初期化();
		対象UI初期化();
		奴隷UI初期化();
	}

	private static void al(string s, int i)
	{
		ref string reference = ref 日終了ログa[i];
		reference = reference + s + "\r\n";
	}

	public static void 日終了()
	{
		Player.RecoverPlayerStamina();
		Player.RecoverPlayerStamina();
		Sta.GameData.日借金額 = 0uL;
		労働利益 = 0uL;
		日利益額 = 0uL;
		日利子額 = Sta.GameData.利子額;
		日終了ログa = new string[MaxRoomNumber];
		int num = 0;
		Unit[] Slaves = Sta.GameData.Slaves;
		foreach (Unit unit in Slaves)
		{
			if (unit != null)
			{
				unit.RecoverStamina();
				unit.RecoverStamina();
				unit.ChaD.現陰毛 = (unit.ChaD.現陰毛 + 0.05).Clamp(0.0, 1.0);
				int num2 = ((unit.妊娠進行期間 <= 0) ? 1 : unit.妊娠進行期間);
				bool flag = Sta.GameData.日数 % (ulong)(num2 * 2) == 0;
				if (unit.発情フラグ && flag && !unit.ChaD.タトゥ)
				{
					unit.発情フラグ = false;
				}
				else if (flag)
				{
					unit.発情フラグ = true;
				}
				checked
				{
					if (unit.Pregnant)
					{
						if (unit.非妊娠)
						{
							al(GameText.収容番号 + unit.Number + "/" + unit.Name + GameText.が妊娠しました + ((unit.Laboror || unit.Prostitute) ? ("\r\n" + GameText.労働が解除されます) : ""), num);
							unit.非妊娠 = false;
						}
						if (unchecked(Sta.GameData.日数 % (ulong)num2) == 0L)
						{
							if (unit.妊娠状態変数 == 4)
							{
								unit.体力消費();
								unit.体力消費();
								unit.体力消費();
								al(GameText.収容番号 + unit.Number + "/" + unit.Name + GameText.が出産しました, num);
								if (Sta.GameData.Is地下室一杯())
								{
									ulong price = unit.Child.GetPrice();
									al(GameText.収容できないので子は売却されます + "+" + price.ToString("#,0"), num);
									try
									{
										日利益額 += price;
									}
									catch
									{
										日利益額 = 9999999999999uL;
									}
								}
								else
								{
									al(GameText.子を奴隷として収容します, num);
									Sta.GameData.Add地下室(unit.Child);
								}
								unit.Child = null;
								unit.妊娠状態変数 = -1;
								unit.ChaD.現乳房 = 0.0;
								unit.Pregnant = false;
								unit.非妊娠 = true;
							}
							else
							{
								unchecked
								{
									unit.妊娠状態変数++;
									unit.ChaD.現乳房 += 0.2;
								}
							}
						}
					}
					else if (unit.Trained && unit.Is増殖可 && unit.ChaD.Stamina == 1.0 && 0.3.Lot())
					{
						unit.体力消費();
						unit.体力消費();
						unit.体力消費();
						al(GameText.収容番号 + unit.Number + "/" + unit.Name + GameText.が増殖しました, num);
						if (Sta.GameData.Is地下室一杯())
						{
							ulong price2 = unit.GetPrice();
							al(GameText.収容できないので子は売却されます + "+" + price2.ToString("#,0"), num);
							try
							{
								日利益額 += price2;
							}
							catch
							{
								日利益額 = 9999999999999uL;
							}
						}
						else
						{
							al(GameText.子を奴隷として収容します, num);
							Sta.GameData.Add地下室(unit.DeepCopy().増殖時Reset());
						}
					}
					if (unit.非妊娠)
					{
						try
						{
							if (unit.Laboror)
							{
								労働利益 += (ulong)(500000.0 * ((double)unit.種族情報.一般 / 9.0) * (double)unit.LaborCount * unit.一般労働倍率()).RoundDown(0);
							}
							else if (unit.Prostitute)
							{
								労働利益 += (ulong)((double)unit.GetPrice() * 0.012 * ((double)unit.種族情報.娼婦 / 9.0 + unit.ChaD.Lust + unit.ChaD.Affection + unit.ChaD.Taming + unit.ChaD.SkillL) * (double)unit.ProstituteCount * unit.娼婦労働倍率() * (unit.Virgin ? 0.4 : 1.0)).RoundDown(0);
							}
						}
						catch
						{
							労働利益 = 9999999999999uL;
						}
					}
					unit.LaborCount = 0;
					unit.ProstituteCount = 0;
				}
			}
			num++;
		}
		checked
		{
			try
			{
				日利益額 += 労働利益;
			}
			catch
			{
				日利益額 = 9999999999999uL;
			}
			dayp = false;
			Sta.GameData.新日 = true;
		}
	}

	public static void 時進行()
	{
		Player.RecoverPlayerStamina();
		Parallel.ForEach(Sta.GameData.Slaves, Sta.po3, delegate(Unit u)
		{
			if (u != null)
			{
				if (u.非妊娠 && u.Laboror && u.ChaD.Stamina > 0.333)
				{
					u.LaborCount++;
					u.体力消費();
					u.種族情報.一般成長(u.一般最大加算値);
				}
				else if (u.非妊娠 && u.Prostitute && u.ChaD.Stamina > 0.333)
				{
					u.ProstituteCount++;
					u.体力消費();
					u.種族情報.娼婦成長(u.娼婦最大加算値);
					u.ChaD.娼婦調教(u.MaxSkillL);
					if (!u.Pregnant && (0.002 * (u.発情フラグ ? 1.5 : 1.0) * ((u.Race == GameText.エキドナ) ? 2.0 : 1.0)).Lot())
					{
						u.Virgin = false;
						u.娼婦妊娠();
					}
				}
				else
				{
					u.RecoverStamina();
				}
			}
		});
	}

	private static void 並列処理()
	{
		日終了();
		AutoSave();
	}

	public static bool 時間進行(Med Med)
	{
		bool flag = Sta.GameData.時間帯 == GameText.夜;
		時進行();
		if (flag)
		{
			while (dayp)
			{
			}
			dayp = true;
			cts.Cancel();
			Sta.GameData.Refresh = false;
			cts = new CancellationTokenSource();

			t1 = Task.Factory.StartNew(並列処理, cts.Token);

			Med.SwitchMode("StartOfDay", DrawBuffer, 日数進行描画);
		}
		else
		{
			Sta.GameData.時間進行();
		}
		return flag;
	}

	public static void 日付進行(Med Med)
	{
		while (!時間進行(Med))
		{
		}
	}

	public static void ロード時初期化()
	{
		while (dayp)
		{
		}
		cts.Cancel();
		Sta.GameData.Refresh = false;
	}

	public static void 妊娠状態反映()
	{
		if (Sta.GameData.TrainingTarget.妊娠状態変数 > -1)
		{
			TrainingTarget.Bod.ボテ腹i = Sta.GameData.TrainingTarget.妊娠状態変数;
			TrainingTarget.Bod.ボテ腹_表示 = true;
			if (!TrainingTarget.Bod.Is獣)
			{
				TrainingTarget.Bod.ボテ腹_人.ハイライト表示 = Sta.GameData.TrainingTarget.妊娠状態変数 > 2;
			}
		}
		else
		{
			TrainingTarget.Bod.ボテ腹i = 0;
			TrainingTarget.Bod.ボテ腹_表示 = false;
		}
		TrainingTarget.Bod.断面_表示 = TrainingTarget.Bod.断面_表示;
		TrainingTarget.Bod.変動ステート更新();
	}

	public static void Setnpl(Unit u)
	{
		npl.Text = GameText.収容番号 + u.Number + "\r\n" + (Sta.AlwaysUseName ? u.Name : (u.Trained ? u.Name : u.Race));
	}

	public static void ResetTrainingTarget()
	{
		Player.Cha = TrainingTarget;
		Player.SetState();
		Player.表示ステート更新();
		Player.ModBox();
		Player.SensBox();
		妊娠状態反映();
		TrainingTarget.SetInitialExpression();
		TrainingTarget.Emotion();
		TrainingTarget.UpdateExpression();
		TrainingTarget.口修正();
		if (Sta.GameData.TrainingTarget.Trained)
		{
			TrainingTarget.Bod.拘束具_表示 = false;
			TrainingTarget.Bod.首輪_表示 = true;
			TrainingTarget.Set基本姿勢();
		}
		else
		{
			TrainingTarget.Bod.拘束具_表示 = true;
			TrainingTarget.Set拘束姿勢();
		}
		if (Sta.GameData.TrainingTarget.ChaD.胸施術)
		{
			TrainingTarget.Bod.胸施術();
		}
		if (Sta.GameData.TrainingTarget.ChaD.股施術)
		{
			TrainingTarget.Bod.股施術();
		}
		if (Sta.GameData.TrainingTarget.ChaD.タトゥ)
		{
			TrainingTarget.Bod.タトゥ();
		}
		if (Sta.GameData.TrainingTarget.着衣 != null)
		{
			TrainingTarget.Set衣装(Sta.GameData.TrainingTarget.着衣);
		}
		TrainingTarget.Bod.Join();
		TrainingTarget.Bod.Update();
	}

	public static void Set調教対象(Med Med, Unit u)
	{
		Sta.GameData.TrainingTarget = u;
		if (TrainingTarget != null)
		{
			TrainingTarget.Dispose();
		}
		TrainingTarget = new Cha(Med, DrawBuffer, Sta.GameData.TrainingTarget.ChaD);
		キャラ吹出し.接続(TrainingTarget.Bod.頭.口_接続点);
		Setnpl(u);
		double d = ((u.Trained && Sta.MoveInsectMask) ? 1.0 : 0.0);
		if (TrainingTarget.Bod.Is顔面)
		{
			TrainingTarget.Bod.頭.顔面_接続.SetEle(delegate(顔面 顔面)
			{
				顔面.展開0 = d;
				顔面.展開1 = d;
			});
			TrainingTarget.Bod.頭.大顎基_接続.SetEle(delegate(大顎基 大顎)
			{
				大顎.展開 = d;
			});
			TrainingTarget.Bod.頭.額_接続.SetEle(delegate(角1_虫 虫角)
			{
				虫角.展開 = d;
			});
		}
		ResetTrainingTarget();
	}

	public static void 対象状態初期化()
	{
		Player.SetState();
		TrainingTarget.Crying = false;
		if (TrainingTarget.Bod.鼻水左 != null)
		{
			TrainingTarget.Bod.鼻水左.表示 = false;
			TrainingTarget.Bod.鼻水右.表示 = false;
		}
		if (TrainingTarget.Bod.涎左 != null)
		{
			TrainingTarget.Bod.涎左.表示 = false;
			TrainingTarget.Bod.涎右.表示 = false;
		}
		TrainingTarget.Bod.噴乳左.表示 = false;
		TrainingTarget.Bod.噴乳右.表示 = false;
		TrainingTarget.噴乳染み = 0.0;
		TrainingTarget.Bod.下着T染み = 0.0;
		TrainingTarget.SetInitialExpression();
		TrainingTarget.Emotion();
		TrainingTarget.UpdateExpression();
		if (Sta.GameData.TrainingTarget.Trained)
		{
			TrainingTarget.Set基本姿勢();
		}
		else
		{
			TrainingTarget.Set拘束姿勢();
		}
		Player.表示ステート更新();
		Player.ModBox();
		Player.SensBox();
	}

	public static void Player説明(ref Color hc, Action Reset)
	{
		if (dbs["プレイヤー"].Pars.Values.First().ToPar().HitColor == hc)
		{
			ip.SubInfoIm = GameText.プレイヤーの遺伝情報を設定します + "(-" + 10000000uL.ToString("#,0") + ")";
		}
		else if (ip.SubInfoIm == GameText.プレイヤーの遺伝情報を設定します + "(-" + 10000000uL.ToString("#,0") + ")")
		{
			Reset();
		}
	}

	public static void フラッシュ(this Med Med)
	{
		調教描画(drawArea, Med.FPSF);
		Med.ClearSta(Color.FromArgb(128, Color.White));
		Med.DrawEnd(drawArea);
		sta = true;
	}

	public static Module Start(Med Med)
	{
		return new Module
		{
			Setting = delegate
			{
                Med.Mode = "Credit";
            }
		};
	}

	public static Module Credit(Med Med) {

		MotV mv = new MotV(0.0, 1.0){BaseSpeed = 0.5};

		double v = 0.0;
		bool fadeIn = true;
		bool fadeOut = false;
		double num = 0.15;

		Lab label = new Lab(Med, DrawBuffer, "クレジット", DrawBuffer.GetPosition(ref Shas.中央中央), num, 1.0, new Font("", 1f), 0.06, "Auto Eden Presents.", Col.White, Col.Empty, Col.Empty, Col.Empty, Input: false);
		label.ParT.PositionBase -= new Vector2D(label.ParT.RectSize.X - 0.07, label.ParT.RectSize.Y * 3.0) * 0.5 * num;

		return new Module()
		{
			Setting = delegate
			{
				DrawBuffer.Clear(Col.Black);
				DrawBuffer.Draw(label.ParT);
				Med.DrawStart(BlackBackground);
				Med.DrawEnd(DrawBuffer);
				v = 0.0;
				fadeIn = true;
				fadeOut = false;
				mv.ResetValue();
			},

			Down = delegate
			{
				Med.Mode = "Title";
			},

			Draw = delegate (FPS FPS)
			{
				if (fadeIn || fadeOut)
				{
					if (v < mv.Max)
					{
						mv.GetValue(FPS);
						v = mv.Value;
						if (fadeIn)
						{
							Med.FadeIn(v);
						}
						if (fadeOut)
						{
							Med.FadeOut(v);
						}
					}
					else
					{
						if (fadeOut)
						{
							v = 0.0;
							fadeOut = false;
							mv.ResetValue();
							Med.Draw(BlackBackground);
						}
						if (fadeIn)
						{
							v = 0.0;
							fadeIn = false;
							mv.ResetValue();
							Med.Draw(DrawBuffer);
							fadeOut = true;
							Med.DrawStart(DrawBuffer);
							Med.DrawEnd(BlackBackground);
						}
					}
				}
				else
				{
					Med.Draw(BlackBackground);
					Med.Mode = "Title";
				}
			},

			Dispose = delegate
			{
				label.Dispose();
			}
		};
	}

	public static Module Title(Med Med)
	{
		MotV mv = new MotV(0.0, 1.0)
		{
			BaseSpeed = 0.5
		};

        bool ll = false;
        double v = 0.0;
		bool b1 = true;
		double num = 0.2;

		Lab label = new Lab(Med, DrawBuffer, "タイトル", DrawBuffer.GetPosition(ref Shas.中央中央), num, 1.0, new Font("", 1f), 0.07, "Slave Matrix", Col.White, Col.Empty, Col.Empty, Col.Empty, Input: false);
		label.ParT.PositionBase -= new Vector2D(label.ParT.RectSize.X - 0.07, label.ParT.RectSize.Y * 3.0) * 0.5 * num;

		ListView listView = new ListView(DrawBuffer, label.ParT.PositionBase.MulXY(1.015, 1.2), 0.25, new Font("MS Gothic", 1f), 0.09, Col.White, Col.Empty, Col.Empty, Col.Empty,
			new TA("Start", delegate
			{
				Sounds.操作.Play();
				Sta.GameData.SetDefault();

				Viola?.Dispose();
				TrainingTarget?.Dispose();
				TrainingTarget = null;

				Initialize();
				start = true;
				SetDemandMaximum();
				Med.SwitchMode("PlayerInformation", DrawBuffer, PlayerInformationSliders);
			}),
			new TA("Load", delegate
			{
				Sounds.操作.Play();
				SaveData.bs["0"].Dra = true;
				save = false;
				title = true;
				SetSLlv(Med);
				ll = true;
				ip.SubInfoIm = "RCl:" + GameText.戻る;
			})
		);

		listView.SetHitColor(Med);

		return new Module
		{
            Setting = delegate
            {
                ip.MaiShow = false;
                ip.Mai2Show = false;
                ip.SubShow = true;
                ip.Sub2Show = false;
                ll = false;
                DrawBuffer.Clear(Col.Black);
                DrawBuffer.Draw(label.ParT);
                Med.DrawStart(BlackBackground);
                Med.DrawEnd(DrawBuffer);
                v = 0.0;
                b1 = true;
                mv.ResetValue();
                Sounds.日常BGM.Stop();
                Sounds.OPBGM.Play();
            },
            Down = delegate (MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!processing)
				{
					if (mb == MouseButtons.Left)
					{
						if (ll)
						{
							SaveData.Down(ref hc);
						}
						else
						{
							listView.Down(ref hc);
						}
					}
					else if (ll && mb == MouseButtons.Right)
					{
						ll = false;
					}
				}
			},
			Up = delegate (MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!processing && mb == MouseButtons.Left)
				{
					if (ll)
					{
						SaveData.Up(ref hc);
					}
					else
					{
						listView.Up(ref hc);
					}
				}
			},
			Move = delegate (MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!processing)
				{
					SaveData.Move(ref hc);
					listView.Move(ref hc);
				}
			},
			Leave = delegate
			{
				if (!processing)
				{
					if (ll)
					{
						SaveData.Leave();
					}
					else
					{
						listView.Leave();
					}
				}
			},
			Draw = delegate (FPS FPS)
			{
				if (b1)
				{
					if (v < mv.Max)
					{
						mv.GetValue(FPS);
						v = mv.Value;
						if (b1)
						{
							Med.FadeIn(v);
						}
					}
					else
					{
						v = 0.0;
						b1 = false;
						mv.ResetValue();
						Med.Draw(DrawBuffer);
					}
				}
				else
				{
					DrawBuffer.Draw(BlackBackground);
					if (ll)
					{
						ip.Draw(DrawBuffer, FPS);
						SaveData.Draw(DrawBuffer);
					}
					else
					{
						DrawBuffer.Draw(label.ParT);
						listView.Draw(DrawBuffer);
					}
					Med.Draw(DrawBuffer);
				}
			},

			Dispose = delegate
			{
				label.Dispose();
				listView.Dispose();
			}
		};
	}

	public static Module メインフォーム(Med Med)
	{
		Module mod = new Module();
		Buts bs = new Buts();
		ParT parT = new ParT();
		parT.Font = new Font("MS Gothic", 0.1f);
		parT.PositionBase = DrawBuffer.GetPosition(0.85, 0.02);
		parT.Text = GameText.事務所;
		parT.FontSize = 0.15;
		parT.SizeBase = 0.05;
		parT.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT.OP.ScalingY(parT.OP.GetCenter(), 0.47);
		parT.OP.Rotation(parT.OP.GetCenter(), -26.0);
		parT.Closed = true;
		parT.TextColor = Col.White;
		parT.BrushColor = Color.FromArgb(160, Col.Black);
		parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT.StringFormat.Alignment = StringAlignment.Center;
		parT.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン1", new But1(parT, delegate
		{
			Sounds.操作.Play();
			Med.SwitchMode("Office", DrawBuffer, DrawOffice);
		}));
		ParT parT2 = new ParT();
		parT2.Font = new Font("MS Gothic", 0.1f);
		parT2.PositionBase = DrawBuffer.GetPosition(0.85, 0.1);
		parT2.Text = GameText.調教;
		parT2.FontSize = 0.15;
		parT2.SizeBase = 0.05;
		parT2.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT2.OP.ScalingY(parT2.OP.GetCenter(), 0.47);
		parT2.OP.Rotation(parT2.OP.GetCenter(), -26.0);
		parT2.Closed = true;
		parT2.TextColor = Col.White;
		parT2.BrushColor = Color.FromArgb(160, Col.Black);
		parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT2.StringFormat.Alignment = StringAlignment.Center;
		parT2.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン2", new But1(parT2, delegate
		{
			Sounds.操作.Play();
			Med.SwitchMode("調教中継行", DrawBuffer, 中継描画);
		}));
		ParT parT3 = new ParT();
		parT3.Font = new Font("MS Gothic", 0.1f);
		parT3.PositionBase = DrawBuffer.GetPosition(0.85, 0.18);
		parT3.Text = GameText.対象;
		parT3.FontSize = 0.15;
		parT3.SizeBase = 0.05;
		parT3.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT3.OP.ScalingY(parT3.OP.GetCenter(), 0.47);
		parT3.OP.Rotation(parT3.OP.GetCenter(), -26.0);
		parT3.Closed = true;
		parT3.TextColor = Col.White;
		parT3.BrushColor = Color.FromArgb(160, Col.Black);
		parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT3.StringFormat.Alignment = StringAlignment.Center;
		parT3.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン3", new But1(parT3, delegate
		{
			Sounds.操作.Play();
			Med.Mode = "対象";
		}));
		ParT parT4 = new ParT();
		parT4.Font = new Font("MS Gothic", 0.1f);
		parT4.PositionBase = DrawBuffer.GetPosition(0.85, 0.26);
		parT4.Text = GameText.休む;
		parT4.FontSize = 0.15;
		parT4.SizeBase = 0.05;
		parT4.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT4.OP.ScalingY(parT4.OP.GetCenter(), 0.47);
		parT4.OP.Rotation(parT4.OP.GetCenter(), -26.0);
		parT4.Closed = true;
		parT4.TextColor = Col.White;
		parT4.BrushColor = Color.FromArgb(160, Col.Black);
		parT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT4.StringFormat.Alignment = StringAlignment.Center;
		parT4.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン4", new But1(parT4, delegate
		{
			Sounds.操作.Play();
			si.Set(bre: true);
			時間進行(Med);
			ip.UpdateSub2();
		}));
		ParT parT5 = new ParT();
		parT5.Font = new Font("MS Gothic", 0.1f);
		parT5.PositionBase = DrawBuffer.GetPosition(0.85, 0.34);
		parT5.Text = GameText.眠る;
		parT5.FontSize = 0.15;
		parT5.SizeBase = 0.05;
		parT5.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT5.OP.ScalingY(parT5.OP.GetCenter(), 0.47);
		parT5.OP.Rotation(parT5.OP.GetCenter(), -26.0);
		parT5.Closed = true;
		parT5.TextColor = Col.White;
		parT5.BrushColor = Color.FromArgb(160, Col.Black);
		parT5.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT5.StringFormat.Alignment = StringAlignment.Center;
		parT5.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン5", new But1(parT5, delegate
		{
			Sounds.操作.Play();
			日付進行(Med);
		}));
		ParT parT6 = new ParT();
		parT6.Font = new Font("MS Gothic", 0.1f);
		parT6.PositionBase = DrawBuffer.GetPosition(0.85, 0.42);
		parT6.Text = GameText.祝福;
		parT6.FontSize = 0.15;
		parT6.SizeBase = 0.05;
		parT6.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT6.OP.ScalingY(parT6.OP.GetCenter(), 0.47);
		parT6.OP.Rotation(parT6.OP.GetCenter(), -26.0);
		parT6.Closed = true;
		parT6.TextColor = Col.White;
		parT6.BrushColor = Color.FromArgb(160, Col.Black);
		parT6.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT6.StringFormat.Alignment = StringAlignment.Center;
		parT6.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン6", new But1(parT6, delegate
		{
			Sounds.操作.Play();
			Med.Mode = "Blessing";
		}));
		ParT parT7 = new ParT();
		parT7.Font = new Font("MS Gothic", 0.1f);
		parT7.PositionBase = DrawBuffer.GetPosition(0.85, 0.58);
		parT7.Text = GameText.チェンジ;
		parT7.FontSize = 0.15;
		parT7.SizeBase = 0.05;
		parT7.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT7.OP.ScalingY(parT7.OP.GetCenter(), 0.47);
		parT7.OP.Rotation(parT7.OP.GetCenter(), -26.0);
		parT7.Closed = true;
		parT7.TextColor = Col.White;
		parT7.BrushColor = Color.FromArgb(160, Col.Black);
		parT7.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT7.StringFormat.Alignment = StringAlignment.Center;
		parT7.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン7", new But1(parT7, delegate
		{
			Unit unit = null;
			unit = ((Sta.GameData.TrainingTarget == null) ? (from e in Sta.GameData.Slaves
				where e != null
				orderby RNG.XS.Next()
				select e).First() : (from e in Sta.GameData.Slaves
				where e != null && e != Sta.GameData.TrainingTarget
				orderby RNG.XS.Next()
				select e).FirstOrDefault());
			if (unit != null)
			{
				if (unit.Trained)
				{
					Sounds.変更3.Play();
				}
				else
				{
					Sounds.変更Play();
				}
				Set調教対象(Med, unit);
				bs["ボタン2"].Dra = true;
			}
			else
			{
				Sounds.操作.Play();
				ip.SubInfoIm = GameText.他の奴隷がいません;
			}
		}));
		bs.SetHitColor(Med);
		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Down(ref hc);
					if (mb == MouseButtons.Right)
					{
						Sounds.操作.Play();
						SDShow = false;
						ip.Up(ref hc);
						dbs.Move(ref hc);
					}
				}
				else
				{
					switch (mb)
					{
					case MouseButtons.Left:
						if (!ip.選択肢表示)
						{
							dbs.Down(ref hc);
							bs.Down(ref hc);
						}
						ip.Down(ref hc);
						break;
					case MouseButtons.Right:
						if (ip.TextIm == GameText.タイトル画面に戻りますか)
						{
							ip.nb.Action(ip.nb);
						}
						break;
					}
				}
			}
		};
		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Up(ref hc);
				}
				else if (mb == MouseButtons.Left)
				{
					if (!ip.選択肢表示)
					{
						dbs.Up(ref hc);
						bs.Up(ref hc);
					}
					ip.Up(ref hc);
				}
			}
		};
		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Move(ref hc);
				}
				else
				{
					if (!ip.選択肢表示)
					{
						if (TrainingTarget != null)
						{
							TrainingTarget.CP = cp;
						}
						dbs.Move(ref hc);
						bs.Move(ref hc);
						if (bs["ボタン7"].Pars.Values.First().ToPar().HitColor == hc)
						{
							ip.SubInfoIm = GameText.奴隷をランダムに選択します;
						}
						else if (ip.SubInfoIm == GameText.奴隷をランダムに選択します)
						{
							si.Set(bre: false);
						}
						Player説明(ref hc, delegate
						{
							si.Set(bre: false);
						});
					}
					ip.Move(ref hc);
				}
			}
		};
		mod.Leave = delegate
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Leave();
				}
				else if (!ip.選択肢表示)
				{
					dbs.Leave();
					bs.Leave();
				}
			}
		};
		mod.Wheel = delegate
		{
		};
		mod.Setting = delegate
		{
			if (Med.Modeb != "PlayerInformation")
			{
				ip.UpdateSub2();
				ip.MaiShow = false;
				ip.Mai.Feed.Dra = false;
				ip.Mai2Show = false;
				ip.SubShow = true;
				ip.Sub2Show = true;
				Player.UI.ステート描画 = Sta.GameData.心眼;
				if (TrainingTarget == null && Sta.GameData.TrainingTarget != null)
				{
					Set調教対象(Med, Sta.GameData.TrainingTarget);
				}
				bs["ボタン2"].Dra = Sta.GameData.TrainingTarget != null;
				bs["ボタン3"].Dra = !Sta.GameData.初事務所フラグ && Sta.GameData.Slaves.Count((Unit e) => e != null) > 0;
				bs["ボタン4"].Dra = !Sta.GameData.初事務所フラグ;
				bs["ボタン5"].Dra = !Sta.GameData.初事務所フラグ;
				bs["ボタン6"].Dra = !Sta.GameData.初事務所フラグ;
				bs["ボタン7"].Dra = !Sta.GameData.初事務所フラグ && Sta.GameData.Slaves.Count((Unit e) => e != null) > 0;
				si.Set(bre: false);
				Color HitColor = Col.Empty;
				ip.Up(ref HitColor);
				Sounds.OPBGM.Stop();
				Sounds.日常BGM.Play();
				npl.ParT.PositionBase = new Vector2D(Player.UI.ステート.Position.X, 0.026);
			}
		};
		メインフォーム描画 = delegate(Are a, FPS FPS)
		{
			Med.GH.Clear(Col.Transparent);
			if (a.GH != null)
			{
				a.GH.Clear(Col.Transparent);
			}
			a.Draw(BasementBackground);
			if (TrainingTarget != null)
			{
				TrainingTarget.Draw(a, FPS);
				Player.UI.DrawState(a);
				a.Draw(npl.ParT);
			}
			bs.Draw(a);
			dbs.Draw(a);
			ip.Draw(a, FPS);
			if (SDShow)
			{
				SaveData.Draw(a);
			}
			Med.Draw(a);
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, メインフォーム描画);
		};
		mod.Dispose = delegate
		{
			bs.Dispose();
		};
		return mod;
	}

	public static Module Training(Med Med)
	{
		Module mod = new Module();
		調教背景 BackgroundDrawing = new 調教背景();
		Are TrainingBackground = new Are(Med, Hit: false);
		TrainingBackground.Setting();
		TrainingBackground.GD.Clear(Color.Gray);
		Player.UI = new TrainingUI(Med, DrawBuffer, ip);
		Player.UI.調教終了.Action = delegate
		{
			Sounds.操作.Play();
			Med.SwitchMode("調教中継帰", DrawBuffer, 中継描画);
		};
		bool 調教完了 = false;
		bool 調教済みチェック = true;
		Action 調教完了表情 = delegate
		{
			if (TrainingTarget.EyeTracking.Run)
			{
				TrainingTarget.EyeTracking.End();
			}
			if (TrainingTarget.Bod.Is双眉)
			{
				TrainingTarget.Bod.眉左.眉間_表示 = false;
				TrainingTarget.Bod.眉右.眉間_表示 = false;
			}
			if (TrainingTarget.Bod.Is双眼)
			{
				TrainingTarget.瞼_半1左();
				TrainingTarget.瞼_半1右();
				TrainingTarget.目_見つめ左();
				TrainingTarget.目_見つめ右();
			}
			if (TrainingTarget.Bod.Is頬眼)
			{
				TrainingTarget.頬瞼_半1左();
				TrainingTarget.頬瞼_半1右();
				TrainingTarget.頬目_見つめ左();
				TrainingTarget.頬目_見つめ右();
			}
			if (TrainingTarget.Bod.Is単眼)
			{
				TrainingTarget.単瞼_半1();
				TrainingTarget.単目_見つめ();
			}
			if (TrainingTarget.Bod.Is額眼)
			{
				TrainingTarget.額瞼_半1();
				TrainingTarget.額目_見つめ();
			}
			if (!TrainingTarget.Bod.玉口枷_表示)
			{
				TrainingTarget.口_閉笑();
			}
		};
		mod.Setting = delegate
		{
			TrainingBackground.GD.Clear(Color.Gray);
			BackgroundDrawing.Reset();
			BackgroundDrawing.描画(TrainingBackground);
			ip.MaiShow = false;
			ip.Mai.Feed.Dra = true;
			ip.Mai2Show = false;
			ip.SubShow = true;
			ip.Sub2Show = false;
			Med.CursorHide();
			Player.UI.ディルCM.Show = Sta.GameData.PurchasedTools[0];
			Player.UI.コモンCM.Show = Sta.GameData.PurchasedTools[1];
			Player.UI.ドリルCM.Show = Sta.GameData.PurchasedTools[2];
			Player.UI.デンマCM.Show = Sta.GameData.PurchasedTools[3];
			Player.UI.アナルCM.Show = Sta.GameData.PurchasedTools[4];
			Player.UI.調教鞭CM.Show = Sta.GameData.PurchasedTools[5];
			Player.UI.羽根箒CM.Show = Sta.GameData.PurchasedTools[6];
			Player.UI.T剃刀CM.Show = Sta.GameData.PurchasedTools[7];
			Player.UI.キャップ1CM.Show = Sta.GameData.PurchasedTools[8];
			Player.UI.キャップ2CM.Show = Sta.GameData.PurchasedTools[8];
			Player.UI.キャップ3CM.Show = Sta.GameData.PurchasedTools[8];
			Player.UI.ロータCM.Show = Sta.GameData.PurchasedTools[9];
			Player.UI.パールCM.Show = Sta.GameData.PurchasedTools[10];
			Player.UI.目隠帯.Dra = Sta.GameData.PurchasedTools[11];
			Player.UI.玉口枷.Dra = Sta.GameData.PurchasedTools[12];
			Player.UI.撮影.Dra = Sta.GameData.PurchasedTools[13];
			Player.表示ステート更新();
			Player.ModBox();
			Player.SensBox();
			if (TrainingTarget.Bod.Is獣)
			{
				TrainingTarget.Bod.腰.位置B = Med.Base.GetPosition(ref Shas.中央中央).AddY(-0.03);
			}
			else if (TrainingTarget.Bod.Is半身)
			{
				TrainingTarget.Bod.腰.位置B = Med.Base.GetPosition(ref Shas.中央中央).AddY(-0.02);
			}
			TrainingTarget.Bod.Join();
			TrainingTarget.Bod.Update();
			キャラ吹出し.接続();
			TrainingTarget.Bod.汗染み濃度 = 1.0;
			調教済みチェック = true;
			調教前調教済みフラグ = Sta.GameData.TrainingTarget.Trained;
			if (調教完了 = Sta.GameData.TrainingTarget.IsTrained())
			{
				調教完了表情();
			}
		};
		ContactD cd = default(ContactD);
		Vector2D op = Dat.Vec2DZero;
		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			Player.UI.Down(ref mb, ref cp, ref op, ref hc, ref cd);
			ip.Down(ref hc);
		};
		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			Player.UI.Up(ref mb, ref cp, ref hc, ref cd);
			ip.Up(ref hc);
		};
		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			TrainingTarget.CP = cp;
			cd = TrainingTarget.GetContact(ref hc);
			Player.UI.Move(ref mb, ref cp, ref op, ref hc, ref cd);
			ip.Move(ref hc);
			op = cp;
		};
		mod.Leave = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			Player.UI.Leave(ref mb, ref cp, ref hc);
		};
		mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
		{
			Player.UI.Wheel(ref mb, ref cp, ref dt, ref hc, ref cd);
		};
		調教描画 = delegate(Are a, FPS FPS)
		{
			Player.UI.Mots.Drive(FPS);
			Med.GH.Clear(Col.Transparent);
			if (a.GH != null)
			{
				a.GH.Clear(Col.Transparent);
			}
			a.Draw(TrainingBackground);
			TrainingTarget.Draw(a, FPS);
			キャラ吹出し.Draw(a, FPS);
			Player.UI.StaDraw(a, FPS);
			ip.Draw(a, FPS);
			Med.Draw(a);
			if (調教済みチェック)
			{
				if (調教完了)
				{
					調教完了表情();
					キャラ台詞.Set状態();
					if (TrainingTarget.Bod.Is顔面)
					{
						Action<Tex> o_done = キャラ吹出し.Tex.Done;
                        キャラ吹出し.Tex.Done = delegate (Tex tex)
						{
							o_done(tex);
                            TrainingTarget.顔面展開.Start();
                        };
					}
				}
				調教済みチェック = false;
			}
		};
		撮影描画 = delegate(Are a, FPS FPS)
		{
			a.Draw(TrainingBackground);
			TrainingTarget.Draw(a, FPS);
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, 調教描画);
		};
		mod.Dispose = delegate
		{
			TrainingBackground.Dispose();
			Player.UI.Dispose();
		};
		return mod;
	}

	public static Module 調教中継行(Med Med)
	{
		Module obj = new Module
		{
			Down = delegate
			{
				Med.SwitchMode("Training", DrawBuffer, 調教描画);
			},
			Up = delegate
			{
			},
			Move = delegate
			{
			},
			Leave = delegate
			{
			},
			Wheel = delegate
			{
			},
			Setting = delegate
			{
				ip.MaiShow = true;
				ip.Mai.Feed.Dra = true;
				ip.Mai2Show = false;
				ip.SubShow = true;
				ip.Sub2Show = false;
				ip.Text = GameText.点6;
				if (!TrainingTarget.Bod.Setピアス.ピアス_表示)
				{
					TrainingTarget.Bod.脱衣();
				}
				Player.UI.SetTarget(Sta.GameData.TrainingTarget, TrainingTarget);
				Player.SetStateTraining();
				Player.表示ステート更新();
				Player.ModBox();
				Player.SensBox();
				TrainingTarget.Bod.首輪_表示 = true;
				si.Set(bre: false);
				Player.UI.Reset();
				Player.UI.擬音キュー.Clear();
				Player.UI.擬音.Clear();
			}
		};
		中継描画 = delegate(Are a, FPS FPS)
		{
			Med.GH.Clear(Col.Transparent);
			if (a.GH != null)
			{
				a.GH.Clear(Col.Transparent);
			}
			a.Draw(BlackBackground);
			ip.Draw(a, FPS);
			Med.Draw(a);
		};
		obj.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, 中継描画);
		};
		obj.Dispose = delegate
		{
		};
		return obj;
	}

	public static Module 調教中継帰(Med Med)
	{
		Module mod = new Module();
		bool Result2 = false;
		bool Result3 = false;
		bool b1 = false;
		bool b2 = false;
		bool b3 = false;
		mod.Down = delegate
		{
			if (!Result2)
			{
				Player.Result2();
				Result2 = true;
				b1 = Sta.GameData.TrainingTarget.Pregnant && Sta.GameData.TrainingTarget.非妊娠;
				b2 = !調教前調教済みフラグ && Sta.GameData.TrainingTarget.Trained;
				b3 = Sta.GameData.TrainingTarget.Trained && Sta.GameData.祝福 == null;
				Result3 = !(b1 || b2 || b3);
			}
			else if (!Result3)
			{
				ip.TextIm = "";
				if (b1)
				{
					InfoPanel 情報パネル2 = ip;
					情報パネル2.TextIm = 情報パネル2.TextIm + GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "/" + Sta.GameData.TrainingTarget.Name + GameText.が妊娠しました + ((Sta.GameData.TrainingTarget.Laboror || Sta.GameData.TrainingTarget.Prostitute) ? ("\r\n" + GameText.労働が解除されます) : "") + "\r\n";
					Sta.GameData.TrainingTarget.非妊娠 = false;
				}
				if (b2)
				{
					InfoPanel 情報パネル2 = ip;
					情報パネル2.TextIm = 情報パネル2.TextIm + GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "/" + Sta.GameData.TrainingTarget.Name + GameText.の調教が完了しました + "\r\n";
				}
				if (b3)
				{
					Sta.GameData.祝福 = Sta.GameData.TrainingTarget;
					InfoPanel 情報パネル2 = ip;
					情報パネル2.TextIm = 情報パネル2.TextIm + GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "/" + Sta.GameData.TrainingTarget.Name + GameText.から祝福を受けました;
					Sounds.祝福.Play();
				}
				Result3 = true;
			}
			else if (!時間進行(Med))
			{
				Player.UI.Reset();
				Med.SwitchMode("メインフォーム", DrawBuffer, メインフォーム描画);
			}
		};
		mod.Up = delegate
		{
		};
		mod.Move = delegate
		{
		};
		mod.Leave = delegate
		{
		};
		mod.Wheel = delegate
		{
		};
		mod.Setting = delegate
		{
			ip.MaiShow = true;
			ip.Mai.Feed.Dra = true;
			ip.Mai2Show = false;
			ip.SubShow = true;
			ip.Sub2Show = false;
			Med.CursorShow();
			Color HitColor = Col.Empty;
			Player.UI.調教終了.Up(ref HitColor);
			Player.Result1();
			if (Player.UI.強制拘束)
			{
				Sta.GameData.拘束具 = Player.UI.拘束bu;
			}
			Sta.GameData.TrainingTarget.発情フラグ = Player.UI.発情bu;
			Player.調教終了時();
			TrainingTarget.絶頂.End();
			TrainingTarget.体揺れ.End();


			TrainingTarget.放尿強制終了();



			Player.絶頂終了処理_();
			Player.射精終了処理_();
			TrainingTarget.Bod.膣内精液.精液濃度 = 0.0;
			TrainingTarget.Bod.断面.精液濃度 = 0.0;
			TrainingTarget.Bod.スタンプClear();
			TrainingTarget.Bod.腰.位置B = Med.Base.GetPosition(ref Shas.中央中央);
			TrainingTarget.Bod.汗染み濃度 = 0.0;
			TrainingTarget.Bod.飛沫濃度 = 0.0;
			TrainingTarget.Bod.潮染み濃度 = 0.0;
			TrainingTarget.Bod.尿染み濃度 = 0.0;
			if (!TrainingTarget.Bod.Is粘)
			{
				TrainingTarget.Bod.断面_表示 = false;
			}
			TrainingTarget.EyeTracking.End();
			TrainingTarget.口腔精液垂れ.End();
			TrainingTarget.性器精液垂れ.End();
			TrainingTarget.肛門精液垂れ.End();
			TrainingTarget.出糸精液垂れ.End();
			TrainingTarget.Bod.Set腰();
			if (Sta.GameData.TrainingTarget.Trained)
			{
				TrainingTarget.Bod.拘束具_表示 = false;
				TrainingTarget.Bod.首輪_表示 = true;
				TrainingTarget.Set基本姿勢();
			}
			else
			{
				TrainingTarget.Bod.拘束具_表示 = true;
				TrainingTarget.Set拘束姿勢();
			}
			TrainingTarget.Emotion();
			TrainingTarget.SetInitialExpression();
			TrainingTarget.口修正();
			TrainingTarget.舌_無し();
			TrainingTarget.Set衣装(Sta.GameData.TrainingTarget.着衣);
			Player.SetState();
			Player.表示ステート更新();
			Player.ModBox();
			Player.SensBox();
			TrainingTarget.Bod.カーソル = null;
			TrainingTarget.Bod.Join();
			TrainingTarget.Bod.Update();
			キャラ吹出し.接続();
			キャラ吹出し.消失.End();
			Result2 = false;
			Result3 = false;
			si.Set(bre: false);
			Sta.GameData.目隠帯 = false;
			Sta.GameData.玉口枷 = false;
			Sta.GameData.拘束具 = false;
			Sta.GameData.断面 = false;
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, 中継描画);
		};
		mod.Dispose = delegate
		{
		};
		return mod;
	}

	public static Module 対象(Med Med)
	{
		try
		{
			uint 胸施術価格 = 10000000u;
			uint 股施術価格 = 10000000u;
			uint 淫紋価格 = 10000000u;
			uint 衣装変更価格 = 10000000u;
			bool d = false;
			Module mod = new Module();
			Buts bs = new Buts();
			Swi 保守sw = new Swi(Color.DarkRed);
			Swi 一般sw = new Swi(Color.DarkRed);
			Swi 娼婦sw = new Swi(Color.DarkRed);
			int i = 0;
			int f = 0;
			ListView lv = new ListView(DrawBuffer, DrawBuffer.GetPosition(0.01, 0.08), 0.4, new Font("MS Gothic", 1f), 0.08, Col.White, Col.Empty, Color.FromArgb(160, Col.Black), Col.Black, Enumerable.Repeat(new TA("No Slave".PadLeft(15, ' '), delegate
			{
			}), 15).ToArray());
			Color lv初期縁色 = Col.Black;
			Action lv縁色初期化 = delegate
			{
				foreach (But item in lv.bs.EnumBut)
				{
					item.Pars.Values.First().ToParT().PenColor = lv初期縁色;
				}
			};
			Action<Unit> SetUI = delegate(Unit u)
			{
				if (u != null)
				{
					ip.TextIm = u.GetStatus();
					bs["MoveRoomDown"].Dra = Sta.MoveButton;
					bs["MoveRoomUp"].Dra = Sta.MoveButton;
					bs["MoveFloorDown"].Dra = Sta.MoveButton;
					bs["MoveFloorUp"].Dra = Sta.MoveButton;
					bs["子"].Dra = true;
					bs["親形質1"].Dra = true;
					bs["親形質2"].Dra = true;
					保守sw.SetFlag(bs["保守"], u.保守);
					一般sw.SetFlag(bs["一般労働"], u.Laboror);
					娼婦sw.SetFlag(bs["娼婦労働"], u.Prostitute);
					bs["保守"].Dra = true;
					bs["一般労働"].Dra = u.非妊娠 && u.Trained;
					bs["娼婦労働"].Dra = u.非妊娠 && u.Trained;
					bs["売却"].Dra = !u.保守;
					bs["胸施術"].Dra = Sta.GameData.施術 && !u.ChaD.胸施術 && u.ChaD.Is胸甲殻();
					bs["股施術"].Dra = Sta.GameData.施術 && !u.ChaD.股施術 && u.ChaD.Is股防御();
					bs["淫紋"].Dra = Sta.GameData.淫紋 && u.Trained && !u.ChaD.タトゥ && !u.ChaD.Isタトゥ();
					bs["衣装"].Dra = Sta.GameData.衣装 && u.Trained;
				}
				else
				{
					npl.Text = "No Slave";
					ip.TextIm = " ";
					bs["MoveRoomDown"].Dra = false;
					bs["MoveRoomUp"].Dra = false;
					bs["MoveFloorDown"].Dra = false;
					bs["MoveFloorUp"].Dra = false;
					bs["子"].Dra = false;
					bs["親形質1"].Dra = false;
					bs["親形質2"].Dra = false;
					bs["保守"].Dra = false;
					bs["一般労働"].Dra = false;
					bs["娼婦労働"].Dra = false;
					bs["売却"].Dra = false;
					bs["胸施術"].Dra = false;
					bs["股施術"].Dra = false;
					bs["淫紋"].Dra = false;
					bs["衣装"].Dra = false;
				}
			};
			Action<int> set = delegate(int n)
			{
				i = 0;
				lv.Acts = Enumerable.Repeat(new TA("", delegate
				{
				}), 15).Select(delegate(TA e)
				{
					Unit u = Sta.GameData.Slaves[n + i];
					if (u == null)
					{
						e.Text = "No Slave";
						e.act = delegate(But b)
						{
							lv縁色初期化();
							b.Pars.Values.First().ToParT().PenColor = Color.Red;
							Sta.GameData.TrainingTarget = null;
							if (TrainingTarget != null)
							{
								TrainingTarget.Dispose();
								TrainingTarget = null;
							}
							SetUI(null);
						};
					}
					else
					{
						e.Text = GameText.収容番号 + u.Number;
						e.act = delegate(But b)
						{
							lv縁色初期化();
							b.Pars.Values.First().ToParT().PenColor = Color.Red;
							Sta.GameData.TrainingTarget = u;
							bs["子"].Action(bs["子"]);
							if (ip.Mai2Show)
							{
								if (Sta.GameData.TrainingTarget == null)
								{
									ip.Mai2Im = " ";
									ip.選択肢表示 = false;
								}
								else
								{
									d = false;
									bs["売却"].Action(bs["売却"]);
									d = true;
								}
							}
						};
					}
					int num8 = i;
					i = num8 + 1;
					return e;
				});
			};
			lv.SetHitColor(Med);
			ParT parT = new ParT();
			parT.Font = new Font("MS Gothic", 0.1f);
			parT.PositionBase = DrawBuffer.GetPosition(0.85, 0.02);
			parT.Text = GameText.戻る;
			parT.FontSize = 0.15;
			parT.SizeBase = 0.05;
			parT.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT.OP.ScalingY(parT.OP.GetCenter(), 0.47);
			parT.OP.Rotation(parT.OP.GetCenter(), -26.0);
			parT.Closed = true;
			parT.TextColor = Col.White;
			parT.BrushColor = Color.FromArgb(160, Col.Black);
			parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT.StringFormat.Alignment = StringAlignment.Center;
			parT.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン0", new But1(parT, delegate
			{
				Sounds.操作.Play();
				if (Sta.GameData.TrainingTarget != null && bs["子"].Pars.Values.First().ToParT().PenColor != Color.Red)
				{
					Set調教対象(Med, Sta.GameData.TrainingTarget);
					SetUI(Sta.GameData.TrainingTarget);
				}
				Med.Mode = "メインフォーム";
			}));
			Color bs初期縁色 = Col.Black;
			Action bs縁色初期化 = delegate
			{
				foreach (But item2 in bs.EnumBut.Skip(1).Take(3))
				{
					item2.Pars.Values.First().ToParT().PenColor = bs初期縁色;
				}
			};
			ParT parT2 = new ParT();
			parT2.Font = new Font("MS Gothic", 0.1f);
			parT2.PositionBase = DrawBuffer.GetPosition(0.85, 0.1);
			parT2.Text = GameText.子;
			parT2.FontSize = 0.15;
			parT2.SizeBase = 0.05;
			parT2.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT2.OP.ScalingY(parT2.OP.GetCenter(), 0.47);
			parT2.OP.Rotation(parT2.OP.GetCenter(), -26.0);
			parT2.Closed = true;
			parT2.TextColor = Col.White;
			parT2.BrushColor = Color.FromArgb(160, Col.Black);
			parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT2.StringFormat.Alignment = StringAlignment.Center;
			parT2.StringFormat.LineAlignment = StringAlignment.Center;
			parT2.PenColor = Color.Red;
			bs.Add("子", new But1(parT2, delegate(But b)
			{
				if (d)
				{
					Sounds.操作.Play();
				}
				bs縁色初期化();
				b.Pars.Values.First().ToParT().PenColor = Color.Red;
				if (Sta.GameData.TrainingTarget != null)
				{
					if (TrainingTarget == null || TrainingTarget.ChaD != Sta.GameData.TrainingTarget.ChaD)
					{
						Set調教対象(Med, Sta.GameData.TrainingTarget);
					}
					SetUI(Sta.GameData.TrainingTarget);
					bs["胸施術"].Dra = Sta.GameData.施術 && !Sta.GameData.TrainingTarget.ChaD.胸施術 && Sta.GameData.TrainingTarget.ChaD.Is胸甲殻();
					bs["股施術"].Dra = Sta.GameData.施術 && !Sta.GameData.TrainingTarget.ChaD.股施術 && Sta.GameData.TrainingTarget.ChaD.Is股防御();
					bs["淫紋"].Dra = Sta.GameData.淫紋 && Sta.GameData.TrainingTarget.Trained && !Sta.GameData.TrainingTarget.ChaD.タトゥ && !Sta.GameData.TrainingTarget.ChaD.Isタトゥ();
					bs["衣装"].Dra = Sta.GameData.衣装 && Sta.GameData.TrainingTarget.Trained;
				}
			}));
			ParT parT3 = new ParT();
			parT3.Font = new Font("MS Gothic", 0.1f);
			parT3.PositionBase = DrawBuffer.GetPosition(0.85, 0.18);
			parT3.Text = GameText.親形質1;
			parT3.FontSize = 0.15;
			parT3.SizeBase = 0.05;
			parT3.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT3.OP.ScalingY(parT3.OP.GetCenter(), 0.47);
			parT3.OP.Rotation(parT3.OP.GetCenter(), -26.0);
			parT3.Closed = true;
			parT3.TextColor = Col.White;
			parT3.BrushColor = Color.FromArgb(160, Col.Black);
			parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT3.StringFormat.Alignment = StringAlignment.Center;
			parT3.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("親形質1", new But1(parT3, delegate(But b)
			{
				Sounds.操作.Play();
				bs縁色初期化();
				b.Pars.Values.First().ToParT().PenColor = Color.Red;
				if (Sta.GameData.TrainingTarget != null)
				{
					if (TrainingTarget != null)
					{
						TrainingTarget.Dispose();
					}
					TrainingTarget = new Cha(Med, DrawBuffer, Sta.GameData.TrainingTarget.Mother.ChaD);
					if (TrainingTarget.Bod.Is双眼)
					{
						TrainingTarget.両目_見つめ();
					}
					if (TrainingTarget.Bod.Is頬眼)
					{
						TrainingTarget.両頬目_見つめ();
					}
					if (TrainingTarget.Bod.Is単眼)
					{
						TrainingTarget.単目_見つめ();
					}
					if (TrainingTarget.Bod.Is額眼)
					{
						TrainingTarget.額目_見つめ();
					}
					if (Sta.GameData.TrainingTarget.Mother.Race == GameText.ヴィオランテ)
					{
						TrainingTarget.両瞼_卑();
						TrainingTarget.両瞼_半1();
					}
					TrainingTarget.口_閉笑();
					TrainingTarget.Set基本姿勢();
					npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "\r\n" + GameText.親形質1;
					ip.TextIm = Sta.GameData.TrainingTarget.Mother.GetStatus();
					bs["胸施術"].Dra = false;
					bs["股施術"].Dra = false;
					bs["淫紋"].Dra = false;
					bs["衣装"].Dra = false;
				}
			}));
			ParT parT4 = new ParT();
			parT4.Font = new Font("MS Gothic", 0.1f);
			parT4.PositionBase = DrawBuffer.GetPosition(0.85, 0.26);
			parT4.Text = GameText.親形質2;
			parT4.FontSize = 0.15;
			parT4.SizeBase = 0.05;
			parT4.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT4.OP.ScalingY(parT4.OP.GetCenter(), 0.47);
			parT4.OP.Rotation(parT4.OP.GetCenter(), -26.0);
			parT4.Closed = true;
			parT4.TextColor = Col.White;
			parT4.BrushColor = Color.FromArgb(160, Col.Black);
			parT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT4.StringFormat.Alignment = StringAlignment.Center;
			parT4.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("親形質2", new But1(parT4, delegate(But b)
			{
				Sounds.操作.Play();
				bs縁色初期化();
				b.Pars.Values.First().ToParT().PenColor = Color.Red;
				if (Sta.GameData.TrainingTarget != null)
				{
					if (TrainingTarget != null)
					{
						TrainingTarget.Dispose();
					}
					TrainingTarget = new Cha(Med, DrawBuffer, Sta.GameData.TrainingTarget.Father.ChaD);
					if (TrainingTarget.Bod.Is双眼)
					{
						TrainingTarget.両目_見つめ();
					}
					if (TrainingTarget.Bod.Is頬眼)
					{
						TrainingTarget.両頬目_見つめ();
					}
					if (TrainingTarget.Bod.Is単眼)
					{
						TrainingTarget.単目_見つめ();
					}
					if (TrainingTarget.Bod.Is額眼)
					{
						TrainingTarget.額目_見つめ();
					}
					if (Sta.GameData.TrainingTarget.Father.Race == GameText.ヴィオランテ)
					{
						TrainingTarget.両瞼_卑();
						TrainingTarget.両瞼_半1();
					}
					TrainingTarget.口_閉笑();
					TrainingTarget.Set基本姿勢();
					npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "\r\n" + GameText.親形質2;
					ip.TextIm = Sta.GameData.TrainingTarget.Father.GetStatus();
					bs["胸施術"].Dra = false;
					bs["股施術"].Dra = false;
					bs["淫紋"].Dra = false;
					bs["衣装"].Dra = false;
				}
			}));
			ParT parT5 = new ParT();
			parT5.Font = new Font("MS Gothic", 0.1f);
			parT5.PositionBase = DrawBuffer.GetPosition(0.85, 0.34);
			parT5.Text = GameText.保守;
			parT5.FontSize = 0.15;
			parT5.SizeBase = 0.05;
			parT5.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT5.OP.ScalingY(parT5.OP.GetCenter(), 0.47);
			parT5.OP.Rotation(parT5.OP.GetCenter(), -26.0);
			parT5.Closed = true;
			parT5.TextColor = Col.White;
			parT5.BrushColor = Color.FromArgb(160, Col.Black);
			parT5.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT5.StringFormat.Alignment = StringAlignment.Center;
			parT5.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("保守", new But1(parT5, delegate(But b)
			{
				Sounds.操作.Play();
				if (Sta.GameData.TrainingTarget != null)
				{
					保守sw.OnOff(b);
					Sta.GameData.TrainingTarget.保守 = 保守sw.Flag;
					bs["売却"].Dra = !Sta.GameData.TrainingTarget.保守;
					ip.SubInfoIm = (Sta.GameData.TrainingTarget.保守 ? GameText.奴隷を保守対象に設定しました : GameText.奴隷の保守設定を解除しました);
				}
			}));
			ParT parT6 = new ParT();
			parT6.Font = new Font("MS Gothic", 0.1f);
			parT6.PositionBase = DrawBuffer.GetPosition(0.85, 0.42);
			parT6.Text = GameText.一般労働;
			parT6.FontSize = 0.15;
			parT6.SizeBase = 0.05;
			parT6.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT6.OP.ScalingY(parT6.OP.GetCenter(), 0.47);
			parT6.OP.Rotation(parT6.OP.GetCenter(), -26.0);
			parT6.Closed = true;
			parT6.TextColor = Col.White;
			parT6.BrushColor = Color.FromArgb(160, Col.Black);
			parT6.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT6.StringFormat.Alignment = StringAlignment.Center;
			parT6.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("一般労働", new But1(parT6, delegate(But b)
			{
				Sounds.操作.Play();
				if (Sta.GameData.TrainingTarget != null)
				{
					一般sw.OnOff(b);
					Sta.GameData.TrainingTarget.Laboror = 一般sw.Flag;
					if (一般sw.Flag && 娼婦sw.Flag)
					{
						娼婦sw.SetFlag(bs["娼婦労働"], On: false);
					}
					Sta.GameData.TrainingTarget.Prostitute = 娼婦sw.Flag;
					ip.SubInfoIm = (Sta.GameData.TrainingTarget.Laboror ? GameText.奴隷を一般労働に設定しました : GameText.奴隷の一般労働を解除しました);
				}
			}));
			ParT parT7 = new ParT();
			parT7.Font = new Font("MS Gothic", 0.1f);
			parT7.PositionBase = DrawBuffer.GetPosition(0.85, 0.5);
			parT7.Text = GameText.娼婦労働;
			parT7.FontSize = 0.15;
			parT7.SizeBase = 0.05;
			parT7.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT7.OP.ScalingY(parT7.OP.GetCenter(), 0.47);
			parT7.OP.Rotation(parT7.OP.GetCenter(), -26.0);
			parT7.Closed = true;
			parT7.TextColor = Col.White;
			parT7.BrushColor = Color.FromArgb(160, Col.Black);
			parT7.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT7.StringFormat.Alignment = StringAlignment.Center;
			parT7.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("娼婦労働", new But1(parT7, delegate(But b)
			{
				Sounds.操作.Play();
				if (Sta.GameData.TrainingTarget != null)
				{
					娼婦sw.OnOff(b);
					Sta.GameData.TrainingTarget.Prostitute = 娼婦sw.Flag;
					if (娼婦sw.Flag && 一般sw.Flag)
					{
						一般sw.SetFlag(bs["一般労働"], On: false);
					}
					Sta.GameData.TrainingTarget.Laboror = 一般sw.Flag;
					ip.SubInfoIm = (Sta.GameData.TrainingTarget.Prostitute ? GameText.奴隷を娼婦労働に設定しました : GameText.奴隷の娼婦労働を解除しました);
				}
			}));
			ParT parT8 = new ParT();
			parT8.Font = new Font("MS Gothic", 0.1f);
			parT8.PositionBase = DrawBuffer.GetPosition(0.75, 0.405);
			parT8.Text = GameText.全一般;
			parT8.FontSize = 0.15;
			parT8.SizeBase = 0.05;
			parT8.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT8.OP.ScalingY(parT8.OP.GetCenter(), 0.47);
			parT8.OP.Rotation(parT8.OP.GetCenter(), -26.0);
			parT8.Closed = true;
			parT8.TextColor = Col.White;
			parT8.BrushColor = Color.FromArgb(160, Col.Black);
			parT8.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT8.StringFormat.Alignment = StringAlignment.Center;
			parT8.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("全一般", new But1(parT8, delegate
			{
				Sounds.操作.Play();
				if (Sta.GameData.TrainingTarget != null)
				{
					一般sw.SetFlag(bs["一般労働"], On: true);
					娼婦sw.SetFlag(bs["娼婦労働"], On: false);
				}
				Unit[] 地下室3 = Sta.GameData.Slaves;
				foreach (Unit unit3 in 地下室3)
				{
					if (unit3 != null && unit3.Trained && unit3.非妊娠)
					{
						unit3.Laboror = true;
						unit3.Prostitute = false;
					}
				}
				ip.SubInfoIm = GameText.労働可能な全ての奴隷に一般労働を設定しました;
			}));
			ParT parT9 = new ParT();
			parT9.Font = new Font("MS Gothic", 0.1f);
			parT9.PositionBase = DrawBuffer.GetPosition(0.75, 0.485);
			parT9.Text = GameText.全娼婦;
			parT9.FontSize = 0.15;
			parT9.SizeBase = 0.05;
			parT9.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT9.OP.ScalingY(parT9.OP.GetCenter(), 0.47);
			parT9.OP.Rotation(parT9.OP.GetCenter(), -26.0);
			parT9.Closed = true;
			parT9.TextColor = Col.White;
			parT9.BrushColor = Color.FromArgb(160, Col.Black);
			parT9.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT9.StringFormat.Alignment = StringAlignment.Center;
			parT9.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("全娼婦", new But1(parT9, delegate
			{
				Sounds.操作.Play();
				if (Sta.GameData.TrainingTarget != null)
				{
					一般sw.SetFlag(bs["一般労働"], On: false);
					娼婦sw.SetFlag(bs["娼婦労働"], On: true);
				}
				Unit[] 地下室2 = Sta.GameData.Slaves;
				foreach (Unit unit2 in 地下室2)
				{
					if (unit2 != null && unit2.Trained && unit2.非妊娠)
					{
						unit2.Laboror = false;
						unit2.Prostitute = true;
					}
				}
				ip.SubInfoIm = GameText.労働可能な全ての奴隷に娼婦労働を設定しました;
			}));
			ParT parT10 = new ParT();
			parT10.Font = new Font("MS Gothic", 0.1f);
			parT10.PositionBase = DrawBuffer.GetPosition(0.75, 0.565);
			parT10.Text = GameText.全解除;
			parT10.FontSize = 0.15;
			parT10.SizeBase = 0.05;
			parT10.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT10.OP.ScalingY(parT10.OP.GetCenter(), 0.47);
			parT10.OP.Rotation(parT10.OP.GetCenter(), -26.0);
			parT10.Closed = true;
			parT10.TextColor = Col.White;
			parT10.BrushColor = Color.FromArgb(160, Col.Black);
			parT10.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT10.StringFormat.Alignment = StringAlignment.Center;
			parT10.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("全解除", new But1(parT10, delegate
			{
				Sounds.操作.Play();
				if (Sta.GameData.TrainingTarget != null)
				{
					一般sw.SetFlag(bs["一般労働"], On: false);
					娼婦sw.SetFlag(bs["娼婦労働"], On: false);
				}
				Unit[] 地下室 = Sta.GameData.Slaves;
				foreach (Unit unit in 地下室)
				{
					if (unit != null && unit.Trained)
					{
						unit.Laboror = false;
						unit.Prostitute = false;
					}
				}
				ip.SubInfoIm = GameText.労働中の全ての奴隷の労働を解除しました;
			}));
			ParT parT11 = new ParT();
			parT11.Font = new Font("MS Gothic", 0.1f);
			parT11.PositionBase = DrawBuffer.GetPosition(0.85, 0.58);
			parT11.Text = GameText.売却;
			parT11.FontSize = 0.15;
			parT11.SizeBase = 0.05;
			parT11.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT11.OP.ScalingY(parT11.OP.GetCenter(), 0.47);
			parT11.OP.Rotation(parT11.OP.GetCenter(), -26.0);
			parT11.Closed = true;
			parT11.TextColor = Col.White;
			parT11.BrushColor = Color.FromArgb(160, Col.Black);
			parT11.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT11.StringFormat.Alignment = StringAlignment.Center;
			parT11.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("売却", new But1(parT11, delegate
			{
				if (d)
				{
					Sounds.操作.Play();
				}
				ip.Mai2Im = Sta.GameData.TrainingTarget.GetPriceInfo();
				ip.Mai2Show = true;
				if (!Sta.GameData.TrainingTarget.保守)
				{
					ip.TextIm = GameText.売却しますか;
				}
				ip.選択yAct = delegate
				{
					Color HitColor4 = Col.Empty;
					bs.Move(ref HitColor4);
					ulong price = Sta.GameData.TrainingTarget.GetPrice();
					Sta.GameData.所持金 = Sta.GameData.所持金.加算(price);
					Sounds.精算.Play();
					ip.UpdateSub2();
					for (int m = 0; m < Sta.GameData.Slaves.Length; m++)
					{
						if (Sta.GameData.Slaves[m] == Sta.GameData.TrainingTarget)
						{
							Sta.GameData.Slaves[m] = null;
							break;
						}
					}
					Sta.GameData.地下室詰め();
					set(f);
					ip.SubInfoIm = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + GameText.を売却しました + " \r\n+" + price.ToString("#,0");
					d = false;
					But but8 = bs["ボタン" + (Sta.GameData.TrainingTarget.階層位置 + 1)];
					but8.Action(but8);
					But but9 = lv.bs.EnumBut.ToArray()[Sta.GameData.TrainingTarget.RoomNumber];
					but9.Action(but9);
					if (Sta.GameData.TrainingTarget == null)
					{
						ip.Mai2Im = " ";
						ip.選択肢表示 = false;
					}
					else
					{
						d = false;
						bs["売却"].Action(bs["売却"]);
					}
					d = true;
				};
				ip.選択nAct = delegate
				{
					Sounds.操作.Play();
					Color HitColor3 = Col.Empty;
					bs.Move(ref HitColor3);
					ip.Mai2Show = false;
					if (Sta.GameData.TrainingTarget == null)
					{
						ip.TextIm = " ";
					}
					else
					{
						ip.TextIm = Sta.GameData.TrainingTarget.GetStatus();
					}
					ip.SubInfoIm = GameText.売却をキャンセルしました;
					ip.選択肢表示 = false;
				};
				ip.選択肢表示 = !Sta.GameData.TrainingTarget.保守;
			}));
			ParT parT12 = new ParT();
			parT12.Font = new Font("MS Gothic", 0.1f);
			parT12.PositionBase = DrawBuffer.GetPosition(0.75, 0.645);
			parT12.Text = GameText.全売却;
			parT12.FontSize = 0.15;
			parT12.SizeBase = 0.05;
			parT12.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT12.OP.ScalingY(parT12.OP.GetCenter(), 0.47);
			parT12.OP.Rotation(parT12.OP.GetCenter(), -26.0);
			parT12.Closed = true;
			parT12.TextColor = Col.White;
			parT12.BrushColor = Color.FromArgb(160, Col.Black);
			parT12.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT12.StringFormat.Alignment = StringAlignment.Center;
			parT12.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("全売却", new But1(parT12, delegate
			{
				Sounds.操作.Play();
				string tb = ip.TextIm;
				ip.Mai2Im = Sta.GameData.GetPriceInfo(out var p);
				ip.Mai2Show = true;
				ip.TextIm = GameText.保守以外の全ての奴隷を売却しますか;
				ip.選択yAct = delegate
				{
					Color HitColor2 = Col.Empty;
					bs.Move(ref HitColor2);
					ip.Mai2Show = false;
					Sta.GameData.所持金 = Sta.GameData.所持金.加算(p);
					Sounds.精算.Play();
					ip.UpdateSub2();
					for (int l = 0; l < Sta.GameData.Slaves.Length; l++)
					{
						if (Sta.GameData.Slaves[l] != null && !Sta.GameData.Slaves[l].保守)
						{
							Sta.GameData.Slaves[l] = null;
						}
					}
					Sta.GameData.地下室詰め();
					set(f);
					d = false;
					if (Sta.GameData.TrainingTarget != null)
					{
						if (!Sta.GameData.TrainingTarget.保守)
						{
							But but6 = bs["ボタン" + (Sta.GameData.TrainingTarget.階層位置 + 1)];
							but6.Action(but6);
							But but7 = lv.bs.EnumBut.ToArray()[Sta.GameData.TrainingTarget.RoomNumber];
							but7.Action(but7);
						}
						else if (Sta.AlwaysUseName)
						{
							setName();
						}
						else
						{
							npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + (Sta.GameData.TrainingTarget.Trained ? ("\r\n" + Sta.GameData.TrainingTarget.Name) : Sta.GameData.TrainingTarget.Race);
						}
					}
					ip.SubInfoIm = GameText.保守以外の全ての奴隷を売却しました + " \r\n+" + p.ToString("#,0");
					ip.TextIm = " ";
					d = true;
					ip.選択肢表示 = false;
				};
				ip.選択nAct = delegate
				{
					Sounds.操作.Play();
					Color HitColor = Col.Empty;
					bs.Move(ref HitColor);
					ip.Mai2Show = false;
					ip.TextIm = tb;
					ip.SubInfoIm = GameText.全売却をキャンセルしました;
					ip.選択肢表示 = false;
				};
				ip.選択肢表示 = true;
			}));
			Color f初期縁色 = Col.Black;
			Action f縁色初期化 = delegate
			{
				foreach (But item3 in bs.EnumBut.Skip(10))
				{
					item3.Pars.Values.First().ToParT().PenColor = f初期縁色;
				}
			};
			Action<But, int> 階層選択 = delegate(But b, int o)
			{
				f縁色初期化();
				b.Pars.Values.First().ToParT().PenColor = Color.Red;
				set(o);
			};
			Action 部屋選択 = delegate
			{
				lv縁色初期化();
				if (Sta.GameData.TrainingTarget != null && f == Sta.GameData.TrainingTarget.階層位置 * 15)
				{
					lv.bs[Sta.GameData.TrainingTarget.RoomNumber.ToString()].Pars.Values.First().ToParT().PenColor = Color.Red;
				}
			};
			ParT parT13 = new ParT();
			parT13.Font = new Font("MS Gothic", 0.1f);
			parT13.PositionBase = DrawBuffer.GetPosition(0.03, 0.03);
			parT13.Text = "1F";
			parT13.FontSize = 0.15;
			parT13.SizeBase = 0.05;
			parT13.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT13.BasePointBase = parT13.OP.GetCenter();
			parT13.OP.ScalingXY(parT13.BasePointBase, 0.3);
			parT13.Closed = true;
			parT13.TextColor = Col.White;
			parT13.BrushColor = Color.FromArgb(160, Col.Black);
			parT13.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT13.StringFormat.Alignment = StringAlignment.Center;
			parT13.StringFormat.LineAlignment = StringAlignment.Center;
			parT13.PenColor = Color.Red;
			bs.Add("ボタン1", new But1(parT13, delegate(But b)
			{
				if (d)
				{
					Sounds.操作.Play();
				}
				階層選択(b, f = 0);
				部屋選択();
			}));
			ParT parT14 = new ParT();
			parT14.Font = new Font("MS Gothic", 0.1f);
			parT14.PositionBase = DrawBuffer.GetPosition(0.07, 0.03);
			parT14.Text = "2F";
			parT14.FontSize = 0.15;
			parT14.SizeBase = 0.05;
			parT14.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT14.BasePointBase = parT14.OP.GetCenter();
			parT14.OP.ScalingXY(parT14.BasePointBase, 0.3);
			parT14.Closed = true;
			parT14.TextColor = Col.White;
			parT14.BrushColor = Color.FromArgb(160, Col.Black);
			parT14.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT14.StringFormat.Alignment = StringAlignment.Center;
			parT14.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン2", new But1(parT14, delegate(But b)
			{
				if (d)
				{
					Sounds.操作.Play();
				}
				階層選択(b, f = 15);
				部屋選択();
			}));
			ParT parT15 = new ParT();
			parT15.Font = new Font("MS Gothic", 0.1f);
			parT15.PositionBase = DrawBuffer.GetPosition(0.11, 0.03);
			parT15.Text = "3F";
			parT15.FontSize = 0.15;
			parT15.SizeBase = 0.05;
			parT15.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT15.BasePointBase = parT15.OP.GetCenter();
			parT15.OP.ScalingXY(parT15.BasePointBase, 0.3);
			parT15.Closed = true;
			parT15.TextColor = Col.White;
			parT15.BrushColor = Color.FromArgb(160, Col.Black);
			parT15.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT15.StringFormat.Alignment = StringAlignment.Center;
			parT15.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン3", new But1(parT15, delegate(But b)
			{
				if (d)
				{
					Sounds.操作.Play();
				}
				階層選択(b, f = 30);
				部屋選択();
			}));
			ParT parT16 = new ParT();
			parT16.Font = new Font("MS Gothic", 0.1f);
			parT16.PositionBase = DrawBuffer.GetPosition(0.15, 0.03);
			parT16.Text = "4F";
			parT16.FontSize = 0.15;
			parT16.SizeBase = 0.05;
			parT16.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT16.BasePointBase = parT16.OP.GetCenter();
			parT16.OP.ScalingXY(parT16.BasePointBase, 0.3);
			parT16.Closed = true;
			parT16.TextColor = Col.White;
			parT16.BrushColor = Color.FromArgb(160, Col.Black);
			parT16.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT16.StringFormat.Alignment = StringAlignment.Center;
			parT16.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン4", new But1(parT16, delegate(But b)
			{
				if (d)
				{
					Sounds.操作.Play();
				}
				階層選択(b, f = 45);
				部屋選択();
			}));
			ParT parT17 = new ParT();
			parT17.Font = new Font("MS Gothic", 0.1f);
			parT17.PositionBase = DrawBuffer.GetPosition(0.19, 0.03);
			parT17.Text = "5F";
			parT17.FontSize = 0.15;
			parT17.SizeBase = 0.05;
			parT17.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT17.BasePointBase = parT17.OP.GetCenter();
			parT17.OP.ScalingXY(parT17.BasePointBase, 0.3);
			parT17.Closed = true;
			parT17.TextColor = Col.White;
			parT17.BrushColor = Color.FromArgb(160, Col.Black);
			parT17.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT17.StringFormat.Alignment = StringAlignment.Center;
			parT17.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン5", new But1(parT17, delegate(But b)
			{
				if (d)
				{
					Sounds.操作.Play();
				}
				階層選択(b, f = 60);
				部屋選択();
			}));
			ParT parT18 = new ParT();
			parT18.Font = new Font("MS Gothic", 0.1f);
			parT18.PositionBase = DrawBuffer.GetPosition(0.23, 0.03);
			parT18.Text = "6F";
			parT18.FontSize = 0.15;
			parT18.SizeBase = 0.05;
			parT18.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT18.BasePointBase = parT18.OP.GetCenter();
			parT18.OP.ScalingXY(parT18.BasePointBase, 0.3);
			parT18.Closed = true;
			parT18.TextColor = Col.White;
			parT18.BrushColor = Color.FromArgb(160, Col.Black);
			parT18.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT18.StringFormat.Alignment = StringAlignment.Center;
			parT18.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン6", new But1(parT18, delegate(But b)
			{
				if (d)
				{
					Sounds.操作.Play();
				}
				階層選択(b, f = 75);
				部屋選択();
			}));
			ParT parT19 = new ParT();
			parT19.Font = new Font("MS Gothic", 0.1f);
			parT19.PositionBase = DrawBuffer.GetPosition(0.27, 0.03);
			parT19.Text = "7F";
			parT19.FontSize = 0.15;
			parT19.SizeBase = 0.05;
			parT19.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT19.BasePointBase = parT19.OP.GetCenter();
			parT19.OP.ScalingXY(parT19.BasePointBase, 0.3);
			parT19.Closed = true;
			parT19.TextColor = Col.White;
			parT19.BrushColor = Color.FromArgb(160, Col.Black);
			parT19.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT19.StringFormat.Alignment = StringAlignment.Center;
			parT19.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン7", new But1(parT19, delegate(But b)
			{
				if (d)
				{
					Sounds.操作.Play();
				}
				階層選択(b, f = 90);
				部屋選択();
			}));
			ParT parT20 = new ParT();
			parT20.Font = new Font("MS Gothic", 0.1f);
			parT20.PositionBase = DrawBuffer.GetPosition(0.31, 0.03);
			parT20.Text = "8F";
			parT20.FontSize = 0.15;
			parT20.SizeBase = 0.05;
			parT20.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT20.BasePointBase = parT20.OP.GetCenter();
			parT20.OP.ScalingXY(parT20.BasePointBase, 0.3);
			parT20.Closed = true;
			parT20.TextColor = Col.White;
			parT20.BrushColor = Color.FromArgb(160, Col.Black);
			parT20.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT20.StringFormat.Alignment = StringAlignment.Center;
			parT20.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン8", new But1(parT20, delegate(But b)
			{
				if (d)
				{
					Sounds.操作.Play();
				}
				階層選択(b, f = 105);
				部屋選択();
			}));
			ParT parT21 = new ParT();
			parT21.Font = new Font("MS Gothic", 0.1f);
			parT21.PositionBase = DrawBuffer.GetPosition(0.35, 0.03);
			parT21.Text = "9F";
			parT21.FontSize = 0.15;
			parT21.SizeBase = 0.05;
			parT21.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT21.BasePointBase = parT21.OP.GetCenter();
			parT21.OP.ScalingXY(parT21.BasePointBase, 0.3);
			parT21.Closed = true;
			parT21.TextColor = Col.White;
			parT21.BrushColor = Color.FromArgb(160, Col.Black);
			parT21.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT21.StringFormat.Alignment = StringAlignment.Center;
			parT21.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("ボタン9", new But1(parT21, delegate(But b)
			{
				if (d)
				{
					Sounds.操作.Play();
				}
				階層選択(b, f = 120);
				部屋選択();
			}));
			ParT parT22 = new ParT();
			parT22.Font = new Font("MS Gothic", 0.1f);
			parT22.PositionBase = DrawBuffer.GetPosition(0.75, 0.085);
			parT22.Text = GameText.胸施術;
			parT22.FontSize = 0.15;
			parT22.SizeBase = 0.05;
			parT22.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT22.OP.ScalingY(parT8.OP.GetCenter(), 0.47);
			parT22.OP.Rotation(parT8.OP.GetCenter(), -26.0);
			parT22.Closed = true;
			parT22.TextColor = Col.White;
			parT22.BrushColor = Color.FromArgb(160, Col.Black);
			parT22.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT22.StringFormat.Alignment = StringAlignment.Center;
			parT22.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("胸施術", new But1(parT22, delegate
			{
				if (Sta.GameData.所持金 < 胸施術価格)
				{
					Sounds.操作.Play();
					ip.SubInfoIm = GameText.所持金が足りません;
				}
				else
				{
					Sta.GameData.所持金 -= 胸施術価格;
					Sounds.精算.Play();
					ip.UpdateSub2();
					Sta.GameData.TrainingTarget.ChaD.胸施術 = true;
					TrainingTarget.Bod.胸施術();
					if (Sta.GameData.TrainingTarget.着衣 != null)
					{
						TrainingTarget.Set衣装(Sta.GameData.TrainingTarget.着衣);
					}
					Sta.GameData.TrainingTarget.体力消費();
					bs["胸施術"].Dra = false;
					ip.SubInfoIm = GameText.胸の甲殻を切除しました;
					TrainingTarget.SetInitialExpression();
					TrainingTarget.Emotion();
					TrainingTarget.UpdateExpression();
					if (Sta.GameData.TrainingTarget.Trained)
					{
						TrainingTarget.Bod.拘束具_表示 = false;
						TrainingTarget.Bod.首輪_表示 = true;
						TrainingTarget.Set基本姿勢();
					}
					else
					{
						TrainingTarget.Bod.拘束具_表示 = true;
						TrainingTarget.Set拘束姿勢();
					}
				}
			}));
			ParT parT23 = new ParT();
			parT23.Font = new Font("MS Gothic", 0.1f);
			parT23.PositionBase = DrawBuffer.GetPosition(0.75, 0.165);
			parT23.Text = GameText.股施術;
			parT23.FontSize = 0.15;
			parT23.SizeBase = 0.05;
			parT23.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT23.OP.ScalingY(parT8.OP.GetCenter(), 0.47);
			parT23.OP.Rotation(parT8.OP.GetCenter(), -26.0);
			parT23.Closed = true;
			parT23.TextColor = Col.White;
			parT23.BrushColor = Color.FromArgb(160, Col.Black);
			parT23.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT23.StringFormat.Alignment = StringAlignment.Center;
			parT23.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("股施術", new But1(parT23, delegate
			{
				if (Sta.GameData.所持金 < 股施術価格)
				{
					Sounds.操作.Play();
					ip.SubInfoIm = GameText.所持金が足りません;
				}
				else
				{
					Sta.GameData.所持金 -= 股施術価格;
					Sounds.精算.Play();
					ip.UpdateSub2();
					Sta.GameData.TrainingTarget.ChaD.股施術 = true;
					TrainingTarget.Bod.股施術();
					if (Sta.GameData.TrainingTarget.着衣 != null)
					{
						TrainingTarget.Set衣装(Sta.GameData.TrainingTarget.着衣);
					}
					Sta.GameData.TrainingTarget.体力消費();
					bs["股施術"].Dra = false;
					ip.SubInfoIm = GameText.股の + (TrainingTarget.Bod.Is蠍 ? GameText.甲殻 : GameText.鱗) + GameText.を切除しました;
					TrainingTarget.SetInitialExpression();
					TrainingTarget.Emotion();
					TrainingTarget.UpdateExpression();
					if (Sta.GameData.TrainingTarget.Trained)
					{
						TrainingTarget.Bod.拘束具_表示 = false;
						TrainingTarget.Bod.首輪_表示 = true;
						TrainingTarget.Set基本姿勢();
					}
					else
					{
						TrainingTarget.Bod.拘束具_表示 = true;
						TrainingTarget.Set拘束姿勢();
					}
				}
			}));
			ParT parT24 = new ParT();
			parT24.Font = new Font("MS Gothic", 0.1f);
			parT24.PositionBase = DrawBuffer.GetPosition(0.75, 0.245);
			parT24.Text = GameText.淫紋;
			parT24.FontSize = 0.15;
			parT24.SizeBase = 0.05;
			parT24.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT24.OP.ScalingY(parT8.OP.GetCenter(), 0.47);
			parT24.OP.Rotation(parT8.OP.GetCenter(), -26.0);
			parT24.Closed = true;
			parT24.TextColor = Col.White;
			parT24.BrushColor = Color.FromArgb(160, Col.Black);
			parT24.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT24.StringFormat.Alignment = StringAlignment.Center;
			parT24.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("淫紋", new But1(parT24, delegate
			{
				if (Sta.GameData.所持金 < 淫紋価格)
				{
					Sounds.操作.Play();
					ip.SubInfoIm = GameText.所持金が足りません;
				}
				else
				{
					Sta.GameData.所持金 -= 淫紋価格;
					Sounds.精算.Play();
					ip.UpdateSub2();
					Sta.GameData.TrainingTarget.ChaD.タトゥ = true;
					TrainingTarget.Bod.タトゥ();
					Sta.GameData.TrainingTarget.発情フラグ = true;
					Sta.GameData.TrainingTarget.体力消費();
					bs["淫紋"].Dra = false;
					ip.SubInfoIm = GameText.淫紋を刻みました;
					TrainingTarget.SetInitialExpression();
					TrainingTarget.Emotion();
					TrainingTarget.UpdateExpression();
					if (Sta.GameData.TrainingTarget.Trained)
					{
						TrainingTarget.Bod.拘束具_表示 = false;
						TrainingTarget.Bod.首輪_表示 = true;
						TrainingTarget.Set基本姿勢();
					}
					else
					{
						TrainingTarget.Bod.拘束具_表示 = true;
						TrainingTarget.Set拘束姿勢();
					}
					if (TrainingTarget.Bod.Is獣)
					{
						TrainingTarget.Bod.EI半中1.Updatef = true;
					}
				}
			}));
			ParT parT25 = new ParT();
			parT25.Font = new Font("MS Gothic", 0.1f);
			parT25.PositionBase = DrawBuffer.GetPosition(0.75, 0.325);
			parT25.Text = GameText.衣装;
			parT25.FontSize = 0.15;
			parT25.SizeBase = 0.05;
			parT25.OP.AddRange(new Out[1] { Shas.Get正方形() });
			parT25.OP.ScalingY(parT9.OP.GetCenter(), 0.47);
			parT25.OP.Rotation(parT9.OP.GetCenter(), -26.0);
			parT25.Closed = true;
			parT25.TextColor = Col.White;
			parT25.BrushColor = Color.FromArgb(160, Col.Black);
			parT25.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
			parT25.StringFormat.Alignment = StringAlignment.Center;
			parT25.StringFormat.LineAlignment = StringAlignment.Center;
			bs.Add("衣装", new But1(parT25, delegate
			{
				if (Sta.GameData.所持金 < 衣装変更価格)
				{
					Sounds.操作.Play();
					ip.SubInfoIm = GameText.所持金が足りません;
				}
				else
				{
					Sta.GameData.所持金 -= 衣装変更価格;
					Sounds.精算.Play();
					ip.UpdateSub2();
					Sta.GameData.TrainingTarget.Change衣装();
					TrainingTarget.Set衣装(Sta.GameData.TrainingTarget.着衣);
					ip.SubInfoIm = GameText.衣装を変更しました;
					TrainingTarget.SetInitialExpression();
					TrainingTarget.Emotion();
					TrainingTarget.UpdateExpression();
					if (Sta.GameData.TrainingTarget.Trained)
					{
						TrainingTarget.Bod.拘束具_表示 = false;
						TrainingTarget.Bod.首輪_表示 = true;
						TrainingTarget.Set基本姿勢();
					}
					else
					{
						TrainingTarget.Bod.拘束具_表示 = true;
						TrainingTarget.Set拘束姿勢();
					}
				}
			}));
			bs.Add("MoveRoomDown", MoveRoomDownButton(mod));
			bs.Add("MoveRoomUp", MoveRoomUpButton(mod));
			bs.Add("MoveFloorDown", MoveFloorDownButton(mod));
			bs.Add("MoveFloorUp", MoveFloorUpButton(mod));
			bs.SetHitColor(Med);
			mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!processing)
				{
					if (SDShow)
					{
						SaveData.Down(ref hc);
						if (mb == MouseButtons.Right && !processing)
						{
							Sounds.操作.Play();
							SDShow = false;
							ip.Up(ref hc);
							dbs.Move(ref hc);
						}
					}
					else
					{
						switch (mb)
						{
						case MouseButtons.Left:
							if (!ip.Mai2Show)
							{
								dbs.Down(ref hc);
								bs.Down(ref hc);
							}
							lv.Down(ref hc);
							ip.Down(ref hc);
							break;
						case MouseButtons.Right:
							if (!ip.Mai2Show)
							{
								bs["ボタン0"].Action(bs["ボタン0"]);
							}
							else
							{
								ip.nb.Action(ip.nb);
							}
							break;
						}
					}
				}
			};
			mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!processing)
				{
					if (SDShow)
					{
						SaveData.Up(ref hc);
					}
					else if (mb == MouseButtons.Left)
					{
						if (!ip.Mai2Show)
						{
							dbs.Up(ref hc);
							bs.Up(ref hc);
						}
						lv.Up(ref hc);
						ip.Up(ref hc);
					}
				}
			};
			mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
			{
				if (!processing)
				{
					if (SDShow)
					{
						SaveData.Move(ref hc);
					}
					else
					{
						if (!ip.Mai2Show)
						{
							dbs.Move(ref hc);
							bs.Move(ref hc);
							if (bs["胸施術"].Pars.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.胸の甲殻を切除しました) && !(ip.SubInfoIm == GameText.所持金が足りません))
							{
								ip.SubInfoIm = GameText.胸の甲殻を切除します + "(-" + 胸施術価格.ToString("#,0") + ")";
							}
							else if (ip.SubInfoIm == GameText.胸の甲殻を切除します + "(-" + 胸施術価格.ToString("#,0") + ")")
							{
								si.Set(bre: false);
							}
							if (TrainingTarget != null)
							{
								if (bs["股施術"].Pars.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.股の + (TrainingTarget.Bod.Is蛇 ? GameText.鱗 : GameText.甲殻) + GameText.を切除しました) && !(ip.SubInfoIm == GameText.所持金が足りません))
								{
									ip.SubInfoIm = GameText.股の + (TrainingTarget.Bod.Is蛇 ? GameText.鱗 : GameText.甲殻) + GameText.を切除します + "(-" + 股施術価格.ToString("#,0") + ")";
								}
								else if (ip.SubInfoIm == GameText.股の + (TrainingTarget.Bod.Is蛇 ? GameText.鱗 : GameText.甲殻) + GameText.を切除します + "(-" + 股施術価格.ToString("#,0") + ")")
								{
									si.Set(bre: false);
								}
							}
							if (bs["淫紋"].Pars.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.淫紋を刻みました) && !(ip.SubInfoIm == GameText.所持金が足りません))
							{
								ip.SubInfoIm = GameText.淫紋を刻みます + "(-" + 淫紋価格.ToString("#,0") + ")";
							}
							else if (ip.SubInfoIm == GameText.淫紋を刻みます + "(-" + 淫紋価格.ToString("#,0") + ")")
							{
								si.Set(bre: false);
							}
							if (bs["衣装"].Pars.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.衣装を変更しました) && !(ip.SubInfoIm == GameText.所持金が足りません))
							{
								ip.SubInfoIm = GameText.衣装を変更します + "(-" + 衣装変更価格.ToString("#,0") + ")";
							}
							else if (ip.SubInfoIm == GameText.衣装を変更します + "(-" + 衣装変更価格.ToString("#,0") + ")")
							{
								si.Set(bre: false);
							}
							if (bs["保守"].Pars.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.奴隷を保守対象に設定しました) && !(ip.SubInfoIm == GameText.奴隷の保守設定を解除しました))
							{
								ip.SubInfoIm = GameText.奴隷の保守設定を切り替えます;
							}
							else if (ip.SubInfoIm == GameText.奴隷の保守設定を切り替えます)
							{
								si.Set(bre: false);
							}
							if (bs["一般労働"].Pars.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.奴隷を一般労働に設定しました) && !(ip.SubInfoIm == GameText.奴隷の一般労働を解除しました))
							{
								ip.SubInfoIm = GameText.奴隷の一般労働設定を切り替えます;
							}
							else if (ip.SubInfoIm == GameText.奴隷の一般労働設定を切り替えます)
							{
								si.Set(bre: false);
							}
							if (bs["娼婦労働"].Pars.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.奴隷を娼婦労働に設定しました) && !(ip.SubInfoIm == GameText.奴隷の娼婦労働を解除しました))
							{
								ip.SubInfoIm = GameText.奴隷の娼婦労働設定を切り替えます;
							}
							else if (ip.SubInfoIm == GameText.奴隷の娼婦労働設定を切り替えます)
							{
								si.Set(bre: false);
							}
							if (bs["売却"].Pars.Values.First().ToPar().HitColor == hc)
							{
								ip.SubInfoIm = GameText.奴隷を売却します;
							}
							else if (ip.SubInfoIm == GameText.奴隷を売却します)
							{
								si.Set(bre: false);
							}
							if (bs["全一般"].Pars.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.労働可能な全ての奴隷に一般労働を設定しました))
							{
								ip.SubInfoIm = GameText.労働可能な全ての奴隷を働かせます;
							}
							else if (ip.SubInfoIm == GameText.労働可能な全ての奴隷を働かせます)
							{
								si.Set(bre: false);
							}
							if (bs["全娼婦"].Pars.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.労働可能な全ての奴隷に娼婦労働を設定しました))
							{
								ip.SubInfoIm = GameText.労働可能な全ての奴隷を娼婦として働かせます;
							}
							else if (ip.SubInfoIm == GameText.労働可能な全ての奴隷を娼婦として働かせます)
							{
								si.Set(bre: false);
							}
							if (bs["全解除"].Pars.Values.First().ToPar().HitColor == hc && !(ip.SubInfoIm == GameText.労働中の全ての奴隷の労働を解除しました))
							{
								ip.SubInfoIm = GameText.全ての奴隷の労働を解除します;
							}
							else if (ip.SubInfoIm == GameText.全ての奴隷の労働を解除します)
							{
								si.Set(bre: false);
							}
							if (bs["全売却"].Pars.Values.First().ToPar().HitColor == hc && !ip.SubInfoIm.StartsWith(GameText.保守以外の全ての奴隷を売却しました) && !(ip.SubInfoIm == GameText.全売却をキャンセルしました))
							{
								ip.SubInfoIm = GameText.保守以外の全ての奴隷を売却します;
							}
							else if (ip.SubInfoIm == GameText.保守以外の全ての奴隷を売却します)
							{
								si.Set(bre: false);
							}
							Player説明(ref hc, delegate
							{
								si.Set(bre: false);
							});
						}
						lv.Move(ref hc);
						ip.Move(ref hc);
					}
				}
			};
			mod.Leave = delegate
			{
				if (!processing)
				{
					if (SDShow)
					{
						SaveData.Leave();
					}
					else
					{
						if (!ip.Mai2Show)
						{
							dbs.Leave();
							bs.Leave();
						}
						lv.Leave();
					}
				}
			};
			mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
			{
				int num2 = 0;
				using (IEnumerator<But> enumerator2 = bs.EnumBut.Skip(12).GetEnumerator())
				{
					while (enumerator2.MoveNext() && !(enumerator2.Current.Pars.Values.First().ToParT().PenColor == Color.Red))
					{
						num2++;
					}
				}
				int num3 = 0;
				using (IEnumerator<But> enumerator2 = lv.bs.EnumBut.GetEnumerator())
				{
					while (enumerator2.MoveNext() && !(enumerator2.Current.Pars.Values.First().ToParT().PenColor == Color.Red))
					{
						num3++;
					}
				}
				int num4 = num3 - dt.Sign();
				d = false;
				if (num4 < 0 && num2 > 0)
				{
					But but3 = bs["ボタン" + num2];
					but3.Action(but3);
					num4 = 14;
				}
				else if (num4 > 14 && num2 < Sta.GameData.フロア数 - 1)
				{
					But but4 = bs["ボタン" + (num2 + 2)];
					but4.Action(but4);
					num4 = 0;
				}
				d = true;
				But but5 = lv.bs[num4.Limit(0, 15).ToString()];
				but5.Action(but5);
				if (ip.Mai2Show)
				{
					if (Sta.GameData.TrainingTarget == null)
					{
						ip.Mai2Im = " ";
						ip.選択肢表示 = false;
					}
					else
					{
						d = false;
						bs["売却"].Action(bs["売却"]);
						d = true;
					}
				}
			};
			mod.Setting = delegate
			{
				if (Med.Modeb != "PlayerInformation")
				{
					for (int j = 1; j <= 9; j++)
					{
						bs["ボタン" + j].Dra = false;
					}
					for (int k = 1; k <= Sta.GameData.フロア数; k++)
					{
						bs["ボタン" + k].Dra = true;
					}
					ip.UpdateSub2();
					ip.MaiShow = true;
					ip.Mai.Feed.Dra = false;
					ip.Mai2Show = false;
					ip.SubShow = true;
					ip.Sub2Show = true;
					d = false;
					Player.UI.ステート描画 = false;
					if (Sta.GameData.TrainingTarget != null)
					{
						But but = bs["ボタン" + (Sta.GameData.TrainingTarget.階層位置 + 1)];
						but.Action(but);
						lv縁色初期化();
						lv.bs[Sta.GameData.TrainingTarget.RoomNumber.ToString()].Pars.Values.First().ToParT().PenColor = Color.Red;
						bs["子"].Action(bs["子"]);
					}
					else
					{
						ip.TextIm = GameText.対象が設定されていません;
						階層選択(bs["ボタン" + (f / 15 + 1)], f);
						SetUI(null);
						int num = 0;
						using (IEnumerator<But> enumerator = lv.bs.EnumBut.GetEnumerator())
						{
							while (enumerator.MoveNext() && !(enumerator.Current.Pars.Values.First().ToParT().PenColor == Color.Red))
							{
								num++;
							}
						}
						But but2 = lv.bs[num.Limit(0, 15).ToString()];
						but2.Action(but2);
					}
					d = true;
					si.Set(bre: false);
					if (Sta.BigWindow)
					{
						npl.ParT.PositionBase = new Vector2D(0.095, 0.035);
					}
					else
					{
						npl.ParT.PositionBase = new Vector2D(ip.MaiB.Position.X, 0.026);
					}
				}
			};
			対象描画 = delegate(Are a, FPS FPS)
			{
				Med.GH.Clear(Col.Transparent);
				if (a.GH != null)
				{
					a.GH.Clear(Col.Transparent);
				}
				a.Draw(BasementBackground);
				if (TrainingTarget != null)
				{
					TrainingTarget.Draw(a, FPS);
					Player.UI.DrawState(a);
				}
				a.Draw(npl.ParT);
				lv.Draw(a);
				bs.Draw(a);
				dbs.Draw(a);
				ip.Draw(a, FPS);
				if (SDShow)
				{
					SaveData.Draw(a);
				}
				Med.Draw(a);
			};
			mod.Draw = delegate(FPS FPS)
			{
				SwitchMode(Med, DrawBuffer, FPS, 対象描画);
			};
			mod.Dispose = delegate
			{
				lv.Dispose();
				bs.Dispose();
			};
			対象UI初期化 = delegate
			{
				f = 0;
				npl.Text = "No Slave";
				lv縁色初期化();
			};
			return mod;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static Module Blessing(Med Med)
	{
		Module mod = new Module();
		Cha 祝福 = null;
		bool d = false;
		Lab l = new Lab(Med, DrawBuffer, "ラベル1", new Vector2D(ip.MaiB.Position.X, 0.026), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "No blessing", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		Buts bs = new Buts();
		Action 祝福なし = delegate
		{
			bs["子"].Dra = false;
			bs["親形質1"].Dra = false;
			bs["親形質2"].Dra = false;
			bs["祝福解除"].Dra = false;
			l.Text = "No blessing";
			ip.MaiShow = false;
			if (祝福 != null)
			{
				祝福.Dispose();
				祝福 = null;
			}
		};
		ParT parT = new ParT();
		parT.Font = new Font("MS Gothic", 0.1f);
		parT.PositionBase = DrawBuffer.GetPosition(0.85, 0.02);
		parT.Text = GameText.戻る;
		parT.FontSize = 0.15;
		parT.SizeBase = 0.05;
		parT.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT.OP.ScalingY(parT.OP.GetCenter(), 0.47);
		parT.OP.Rotation(parT.OP.GetCenter(), -26.0);
		parT.Closed = true;
		parT.TextColor = Col.White;
		parT.BrushColor = Color.FromArgb(160, Col.Black);
		parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT.StringFormat.Alignment = StringAlignment.Center;
		parT.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン0", new But1(parT, delegate
		{
			Sounds.操作.Play();
			Med.Mode = "メインフォーム";
		}));
		Action<Buts> rs1 = delegate(Buts bs_)
		{
			Color penColor = bs_["ボタン0"].Pars.Values.First().ToParT().PenColor;
			foreach (But item in bs_.EnumBut.Skip(1))
			{
				item.Pars.Values.First().ToParT().PenColor = penColor;
			}
		};
		ParT parT2 = new ParT();
		parT2.Font = new Font("MS Gothic", 0.1f);
		parT2.PositionBase = DrawBuffer.GetPosition(0.85, 0.1);
		parT2.Text = GameText.子;
		parT2.FontSize = 0.15;
		parT2.SizeBase = 0.05;
		parT2.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT2.OP.ScalingY(parT2.OP.GetCenter(), 0.47);
		parT2.OP.Rotation(parT2.OP.GetCenter(), -26.0);
		parT2.Closed = true;
		parT2.TextColor = Col.White;
		parT2.BrushColor = Color.FromArgb(160, Col.Black);
		parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT2.StringFormat.Alignment = StringAlignment.Center;
		parT2.StringFormat.LineAlignment = StringAlignment.Center;
		parT2.PenColor = Color.Red;
		bs.Add("子", new But1(parT2, delegate(But bu)
		{
			if (d)
			{
				Sounds.操作.Play();
			}
			rs1(bs);
			bu.Pars.Values.First().ToParT().PenColor = Color.Red;
			if (Sta.GameData.祝福 != null)
			{
				l.Text = Sta.GameData.祝福.Name;
				ip.TextIm = Sta.GameData.祝福.GetStatus();
				if (祝福 != null)
				{
					祝福.Dispose();
				}
				祝福 = new Cha(Med, DrawBuffer, Sta.GameData.祝福.ChaD);
				if (祝福.Bod.Is双眼)
				{
					祝福.両目_見つめ();
				}
				if (祝福.Bod.Is頬眼)
				{
					祝福.両頬目_見つめ();
				}
				if (祝福.Bod.Is単眼)
				{
					祝福.単目_見つめ();
				}
				if (祝福.Bod.Is額眼)
				{
					祝福.額目_見つめ();
				}
				if (Sta.GameData.祝福.Race == GameText.ヴィオランテ)
				{
					祝福.両瞼_卑();
					祝福.両瞼_半1();
				}
				祝福.口_閉笑();
				祝福.Set基本姿勢();
			}
		}));
		ParT parT3 = new ParT();
		parT3.Font = new Font("MS Gothic", 0.1f);
		parT3.PositionBase = DrawBuffer.GetPosition(0.85, 0.18);
		parT3.Text = GameText.親形質1;
		parT3.FontSize = 0.15;
		parT3.SizeBase = 0.05;
		parT3.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT3.OP.ScalingY(parT3.OP.GetCenter(), 0.47);
		parT3.OP.Rotation(parT3.OP.GetCenter(), -26.0);
		parT3.Closed = true;
		parT3.TextColor = Col.White;
		parT3.BrushColor = Color.FromArgb(160, Col.Black);
		parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT3.StringFormat.Alignment = StringAlignment.Center;
		parT3.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("親形質1", new But1(parT3, delegate(But bu)
		{
			Sounds.操作.Play();
			rs1(bs);
			bu.Pars.Values.First().ToParT().PenColor = Color.Red;
			if (Sta.GameData.祝福 != null)
			{
				l.Text = GameText.親形質1;
				ip.TextIm = Sta.GameData.祝福.Mother.GetStatus();
				if (祝福 != null)
				{
					祝福.Dispose();
				}
				祝福 = new Cha(Med, DrawBuffer, Sta.GameData.祝福.Mother.ChaD);
				if (祝福.Bod.Is双眼)
				{
					祝福.両目_見つめ();
				}
				if (祝福.Bod.Is頬眼)
				{
					祝福.両頬目_見つめ();
				}
				if (祝福.Bod.Is単眼)
				{
					祝福.単目_見つめ();
				}
				if (祝福.Bod.Is額眼)
				{
					祝福.額目_見つめ();
				}
				if (Sta.GameData.祝福.Mother.Race == GameText.ヴィオランテ)
				{
					祝福.両瞼_卑();
					祝福.両瞼_半1();
				}
				祝福.口_閉笑();
				祝福.Set基本姿勢();
			}
		}));
		ParT parT4 = new ParT();
		parT4.Font = new Font("MS Gothic", 0.1f);
		parT4.PositionBase = DrawBuffer.GetPosition(0.85, 0.26);
		parT4.Text = GameText.親形質2;
		parT4.FontSize = 0.15;
		parT4.SizeBase = 0.05;
		parT4.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT4.OP.ScalingY(parT4.OP.GetCenter(), 0.47);
		parT4.OP.Rotation(parT4.OP.GetCenter(), -26.0);
		parT4.Closed = true;
		parT4.TextColor = Col.White;
		parT4.BrushColor = Color.FromArgb(160, Col.Black);
		parT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT4.StringFormat.Alignment = StringAlignment.Center;
		parT4.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("親形質2", new But1(parT4, delegate(But bu)
		{
			Sounds.操作.Play();
			rs1(bs);
			bu.Pars.Values.First().ToParT().PenColor = Color.Red;
			if (Sta.GameData.祝福 != null)
			{
				l.Text = GameText.親形質2;
				ip.TextIm = Sta.GameData.祝福.Father.GetStatus();
				if (祝福 != null)
				{
					祝福.Dispose();
				}
				祝福 = new Cha(Med, DrawBuffer, Sta.GameData.祝福.Father.ChaD);
				if (祝福.Bod.Is双眼)
				{
					祝福.両目_見つめ();
				}
				if (祝福.Bod.Is頬眼)
				{
					祝福.両頬目_見つめ();
				}
				if (祝福.Bod.Is単眼)
				{
					祝福.単目_見つめ();
				}
				if (祝福.Bod.Is額眼)
				{
					祝福.額目_見つめ();
				}
				if (Sta.GameData.祝福.Father.Race == GameText.ヴィオランテ)
				{
					祝福.両瞼_卑();
					祝福.両瞼_半1();
				}
				祝福.口_閉笑();
				祝福.Set基本姿勢();
			}
		}));
		ParT parT5 = new ParT();
		parT5.Font = new Font("MS Gothic", 0.1f);
		parT5.PositionBase = DrawBuffer.GetPosition(0.85, 0.34);
		parT5.Text = GameText.祝福解除;
		parT5.FontSize = 0.15;
		parT5.SizeBase = 0.05;
		parT5.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT5.OP.ScalingY(parT5.OP.GetCenter(), 0.47);
		parT5.OP.Rotation(parT5.OP.GetCenter(), -26.0);
		parT5.Closed = true;
		parT5.TextColor = Col.White;
		parT5.BrushColor = Color.FromArgb(160, Col.Black);
		parT5.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT5.StringFormat.Alignment = StringAlignment.Center;
		parT5.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("祝福解除", new But1(parT5, delegate
		{
			Sounds.解除.Play();
			Sta.GameData.祝福 = null;
			祝福なし();
			ip.SubInfoIm = GameText.祝福を解除しました;
		}));
		bs.SetHitColor(Med);
		Action subinfo = delegate
		{
			if (Sta.GameData.祝福 != null)
			{
				ip.SubInfoIm = Sta.GameData.祝福.Name + GameText.から祝福を受けています;
			}
			else
			{
				ip.SubInfoIm = GameText.祝福されていません;
			}
		};
		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Down(ref hc);
					if (mb == MouseButtons.Right && !processing)
					{
						Sounds.操作.Play();
						SDShow = false;
						ip.Up(ref hc);
						dbs.Move(ref hc);
					}
				}
				else
				{
					switch (mb)
					{
					case MouseButtons.Left:
						if (!ip.選択肢表示)
						{
							dbs.Down(ref hc);
							bs.Down(ref hc);
						}
						ip.Down(ref hc);
						break;
					case MouseButtons.Right:
						if (!ip.選択肢表示)
						{
							bs["ボタン0"].Action(bs["ボタン0"]);
						}
						else
						{
							ip.nb.Action(ip.nb);
						}
						break;
					}
				}
			}
		};
		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Up(ref hc);
				}
				else if (mb == MouseButtons.Left)
				{
					if (!ip.選択肢表示)
					{
						dbs.Up(ref hc);
						bs.Up(ref hc);
					}
					ip.Up(ref hc);
				}
			}
		};
		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Move(ref hc);
				}
				else
				{
					if (!ip.選択肢表示)
					{
						dbs.Move(ref hc);
						bs.Move(ref hc);
						Player説明(ref hc, subinfo);
					}
					ip.Move(ref hc);
				}
			}
		};
		mod.Leave = delegate
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Leave();
				}
				else if (!ip.選択肢表示)
				{
					dbs.Leave();
					bs.Leave();
				}
			}
		};
		mod.Wheel = delegate
		{
		};
		mod.Setting = delegate
		{
			if (Med.Modeb != "PlayerInformation")
			{
				ip.UpdateSub2();
				ip.MaiShow = true;
				ip.Mai.Feed.Dra = false;
				ip.Mai2Show = false;
				ip.SubShow = true;
				ip.Sub2Show = true;
				if (Sta.GameData.祝福 != null)
				{
					bs["子"].Dra = true;
					bs["親形質1"].Dra = true;
					bs["親形質2"].Dra = true;
					bs["祝福解除"].Dra = true;
					ip.MaiShow = true;
				}
				else
				{
					祝福なし();
				}
				subinfo();
				d = false;
				bs["子"].Action(bs["子"]);
				d = true;
			}
		};
		DrawBlessing = delegate(Are a, FPS FPS)
		{
			Med.GH.Clear(Col.Transparent);
			if (a.GH != null)
			{
				a.GH.Clear(Col.Transparent);
			}
			a.Draw(BasementBackground);
			if (祝福 != null)
			{
				祝福.Draw(a, FPS);
			}
			a.Draw(l.ParT);
			bs.Draw(a);
			dbs.Draw(a);
			ip.Draw(a, FPS);
			if (SDShow)
			{
				SaveData.Draw(a);
			}
			Med.Draw(a);
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, DrawBlessing);
		};
		mod.Dispose = delegate
		{
			if (祝福 != null)
			{
				祝福.Dispose();
			}
			l.Dispose();
			bs.Dispose();
		};
		return mod;
	}

	public static Module Office(Med Med)
	{
		Module mod = new Module();
		Buts bs = new Buts();
		ParT parT = new ParT();
		parT.Font = new Font("MS Gothic", 0.1f);
		parT.PositionBase = DrawBuffer.GetPosition(0.85, 0.02);
		parT.Text = GameText.戻る;
		parT.FontSize = 0.15;
		parT.SizeBase = 0.05;
		parT.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT.OP.ScalingY(parT.OP.GetCenter(), 0.47);
		parT.OP.Rotation(parT.OP.GetCenter(), -26.0);
		parT.Closed = true;
		parT.TextColor = Col.White;
		parT.BrushColor = Color.FromArgb(160, Col.Black);
		parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT.StringFormat.Alignment = StringAlignment.Center;
		parT.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン0", new But1(parT, delegate
		{
			Sounds.操作.Play();
			if (!時間進行(Med))
			{
				Med.SwitchMode("メインフォーム", DrawBuffer, メインフォーム描画);
			}
		}));
		ParT parT2 = new ParT();
		parT2.Font = new Font("MS Gothic", 0.1f);
		parT2.PositionBase = DrawBuffer.GetPosition(0.85, 0.1);
		parT2.Text = GameText.借金;
		parT2.FontSize = 0.15;
		parT2.SizeBase = 0.05;
		parT2.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT2.OP.ScalingY(parT2.OP.GetCenter(), 0.47);
		parT2.OP.Rotation(parT2.OP.GetCenter(), -26.0);
		parT2.Closed = true;
		parT2.TextColor = Col.White;
		parT2.BrushColor = Color.FromArgb(160, Col.Black);
		parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT2.StringFormat.Alignment = StringAlignment.Center;
		parT2.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン1", new But1(parT2, delegate
		{
			Sounds.操作.Play();
			Med.Mode = "Debt";
		}));
		ParT parT3 = new ParT();
		parT3.Font = new Font("MS Gothic", 0.1f);
		parT3.PositionBase = DrawBuffer.GetPosition(0.85, 0.18);
		parT3.Text = GameText.購入;
		parT3.FontSize = 0.15;
		parT3.SizeBase = 0.05;
		parT3.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT3.OP.ScalingY(parT3.OP.GetCenter(), 0.47);
		parT3.OP.Rotation(parT3.OP.GetCenter(), -26.0);
		parT3.Closed = true;
		parT3.TextColor = Col.White;
		parT3.BrushColor = Color.FromArgb(160, Col.Black);
		parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT3.StringFormat.Alignment = StringAlignment.Center;
		parT3.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン2", new But1(parT3, delegate
		{
			Sounds.操作.Play();
			Med.Mode = "SlaveShop";
		}));
		ParT parT4 = new ParT();
		parT4.Font = new Font("MS Gothic", 0.1f);
		parT4.PositionBase = DrawBuffer.GetPosition(0.85, 0.58);
		parT4.Text = GameText.祝福;
		parT4.FontSize = 0.15;
		parT4.SizeBase = 0.05;
		parT4.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT4.OP.ScalingY(parT4.OP.GetCenter(), 0.47);
		parT4.OP.Rotation(parT4.OP.GetCenter(), -26.0);
		parT4.Closed = true;
		parT4.TextColor = Col.White;
		parT4.BrushColor = Color.FromArgb(160, Col.Black);
		parT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT4.StringFormat.Alignment = StringAlignment.Center;
		parT4.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン3", new But1(parT4, delegate
		{
			Sounds.操作.Play();
			Med.SwitchMode("ViolaBlessing", DrawBuffer, 返済イベント描画);
		}));
		bs.SetHitColor(Med);
		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Down(ref hc);
					if (mb == MouseButtons.Right && !processing)
					{
						Sounds.操作.Play();
						SDShow = false;
						ip.Up(ref hc);
						dbs.Move(ref hc);
					}
				}
				else
				{
					switch (mb)
					{
					case MouseButtons.Left:
						if (!ip.選択肢表示)
						{
							dbs.Down(ref hc);
							bs.Down(ref hc);
						}
						ip.Down(ref hc);
						break;
					case MouseButtons.Right:
						if (!ip.選択肢表示)
						{
							bs["ボタン0"].Action(bs["ボタン0"]);
						}
						else
						{
							ip.nb.Action(ip.nb);
						}
						break;
					}
				}
			}
		};
		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Up(ref hc);
				}
				else if (mb == MouseButtons.Left)
				{
					if (!ip.選択肢表示)
					{
						dbs.Up(ref hc);
						bs.Up(ref hc);
					}
					ip.Up(ref hc);
				}
			}
		};
		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Move(ref hc);
				}
				else
				{
					if (!ip.選択肢表示)
					{
						dbs.Move(ref hc);
						bs.Move(ref hc);
						Player説明(ref hc, delegate
						{
							si.Set(bre: false);
						});
					}
					ip.Move(ref hc);
				}
			}
		};
		mod.Leave = delegate
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Leave();
				}
				else if (!ip.選択肢表示)
				{
					dbs.Leave();
					bs.Leave();
				}
			}
		};
		mod.Wheel = delegate
		{
		};
		mod.Setting = delegate
		{
			if (Med.Modeb != "PlayerInformation")
			{
				ip.UpdateSub2();
				ip.MaiShow = false;
				ip.Mai.Feed.Dra = false;
				ip.Mai2Show = false;
				ip.SubShow = true;
				ip.Sub2Show = true;
				ヴィオラ吹出し.Tex.Feed.Dra = false;
				bs["ボタン1"].Dra = !Sta.GameData.初事務所フラグ;
				bs["ボタン3"].Dra = Sta.GameData.RepaymentStage == 3;
				Viola.両目_見つめ();
				Viola.表情_基本0();
				Viola.Set基本姿勢();
				if (Sta.GameData.初事務所フラグ)
				{
					Viola.表情_不敵1();
					ヴィオラ台詞.Set();
				}
				else
				{
					ヴィオラ台詞.Set();
				}
				si.Set(bre: false);
				if (Sta.GameData.RepaymentStage < 3)
				{
					if (Sta.GameData.RepaymentStage == 0 && Sta.GameData.借金 < 単位返済段階額 * 2)
					{
						Sta.GameData.RepaymentStage = 1;
						Sta.GameData.系統開放[2] = true;
						Sta.GameData.系統開放[3] = true;
						Sta.GameData.心眼 = true;
						Med.SwitchMode("RepaymentEvent1", DrawBuffer, 返済イベント描画);
						SetDemandMaximum();
					}
					else if (Sta.GameData.RepaymentStage == 1 && Sta.GameData.借金 < 単位返済段階額)
					{
						Sta.GameData.RepaymentStage = 2;
						Sta.GameData.系統開放[4] = true;
						Sta.GameData.系統開放[5] = true;
						Sta.GameData.媚薬 = true;
						Sta.GameData.施術 = true;
						Sta.GameData.淫紋 = true;
						Sta.GameData.衣装 = true;
						Med.SwitchMode("RepaymentEvent2", DrawBuffer, 返済イベント描画);
						SetDemandMaximum();
					}
					else if (Sta.GameData.RepaymentStage == 2 && Sta.GameData.借金 == 0L)
					{
						Sta.GameData.RepaymentStage = 3;
						Sta.GameData.系統開放[6] = true;
						Sta.GameData.系統開放[7] = true;
						Sta.GameData.系統開放[8] = true;
						Sta.GameData.ヴィオラ服 = true;
						Med.SwitchMode("RepaymentEvent3", DrawBuffer, 返済イベント描画);
						SetDemandMaximum();
					}
				}
			}
		};
		DrawOffice = delegate(Are a, FPS FPS)
		{
			if (a.GH != null)
			{
				a.GH.Clear(Col.Transparent);
			}
			a.Draw(OfficeBackground);
			Viola.Draw(a, FPS);
			ヴィオラ吹出し.Draw(a, FPS);
			bs.Draw(a);
			dbs.Draw(a);
			ip.Draw(a, FPS);
			if (SDShow)
			{
				SaveData.Draw(a);
			}
			Med.Draw(a);
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, DrawOffice);
		};
		mod.Dispose = delegate
		{
			bs.Dispose();
		};
		return mod;
	}

	public static Module Debt(Med Med)
	{
		Module mod = new Module();
		Vector2D position = DrawBuffer.GetPosition(0.15, 0.37);
		Buts bs = new Buts();
		ParT parT = new ParT();
		parT.Font = new Font("MS Gothic", 0.1f);
		parT.PositionBase = DrawBuffer.GetPosition(0.85, 0.02);
		parT.Text = GameText.戻る;
		parT.FontSize = 0.15;
		parT.SizeBase = 0.05;
		parT.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT.OP.ScalingY(parT.OP.GetCenter(), 0.47);
		parT.OP.Rotation(parT.OP.GetCenter(), -26.0);
		parT.Closed = true;
		parT.TextColor = Col.White;
		parT.BrushColor = Color.FromArgb(160, Col.Black);
		parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT.StringFormat.Alignment = StringAlignment.Center;
		parT.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン0", new But1(parT, delegate
		{
			Sounds.操作.Play();
			Med.Mode = "Office";
		}));
		ParT parT2 = new ParT();
		parT2.Font = new Font("MS Gothic", 0.1f);
		parT2.PositionBase = position + DrawBuffer.GetPosition(0.0, 0.0);
		parT2.Text = "c";
		parT2.FontSize = 0.15;
		parT2.SizeBase = 0.07;
		parT2.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT2.OP.ScalingXY(parT2.OP.GetCenter(), 0.3, 0.3);
		parT2.Closed = true;
		parT2.TextColor = Col.White;
		parT2.BrushColor = Color.FromArgb(160, Col.Black);
		parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT2.StringFormat.Alignment = StringAlignment.Center;
		parT2.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("nc", new But1(parT2, delegate
		{
			Sounds.操作.Play();
			ip.TextIm = "0";
		}));
		ParT parT3 = new ParT();
		parT3.Font = new Font("MS Gothic", 0.1f);
		parT3.PositionBase = position + DrawBuffer.GetPosition(0.06, 0.0);
		parT3.Text = "m";
		parT3.FontSize = 0.15;
		parT3.SizeBase = 0.07;
		parT3.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT3.OP.ScalingXY(parT3.OP.GetCenter(), 0.3, 0.3);
		parT3.Closed = true;
		parT3.TextColor = Col.White;
		parT3.BrushColor = Color.FromArgb(160, Col.Black);
		parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT3.StringFormat.Alignment = StringAlignment.Center;
		parT3.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("nm", new But1(parT3, delegate
		{
			Sounds.操作.Play();
			ip.TextIm = 9999999999999uL.ToString("#,0");
		}));
		Action<string> SetNum = delegate(string num)
		{
			if (ulong.Parse(ip.TextIm, NumberStyles.AllowThousands).ToString().Length < 9999999999999uL.ToString().Length)
			{
				ip.TextIm += num;
				ip.TextIm = ulong.Parse(ip.TextIm, NumberStyles.AllowThousands).ToString("#,0");
			}
		};
		ParT parT4 = new ParT();
		parT4.Font = new Font("MS Gothic", 0.1f);
		parT4.PositionBase = position + DrawBuffer.GetPosition(0.0, 0.07);
		parT4.Text = "7";
		parT4.FontSize = 0.15;
		parT4.SizeBase = 0.07;
		parT4.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT4.OP.ScalingXY(parT4.OP.GetCenter(), 0.3, 0.3);
		parT4.Closed = true;
		parT4.TextColor = Col.White;
		parT4.BrushColor = Color.FromArgb(160, Col.Black);
		parT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT4.StringFormat.Alignment = StringAlignment.Center;
		parT4.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("n7", new But1(parT4, delegate
		{
			Sounds.操作.Play();
			SetNum("7");
		}));
		ParT parT5 = new ParT();
		parT5.Font = new Font("MS Gothic", 0.1f);
		parT5.PositionBase = position + DrawBuffer.GetPosition(0.06, 0.07);
		parT5.Text = "8";
		parT5.FontSize = 0.15;
		parT5.SizeBase = 0.07;
		parT5.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT5.OP.ScalingXY(parT5.OP.GetCenter(), 0.3, 0.3);
		parT5.Closed = true;
		parT5.TextColor = Col.White;
		parT5.BrushColor = Color.FromArgb(160, Col.Black);
		parT5.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT5.StringFormat.Alignment = StringAlignment.Center;
		parT5.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("n8", new But1(parT5, delegate
		{
			Sounds.操作.Play();
			SetNum("8");
		}));
		ParT parT6 = new ParT();
		parT6.Font = new Font("MS Gothic", 0.1f);
		parT6.PositionBase = position + DrawBuffer.GetPosition(0.12, 0.07);
		parT6.Text = "9";
		parT6.FontSize = 0.15;
		parT6.SizeBase = 0.07;
		parT6.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT6.OP.ScalingXY(parT6.OP.GetCenter(), 0.3, 0.3);
		parT6.Closed = true;
		parT6.TextColor = Col.White;
		parT6.BrushColor = Color.FromArgb(160, Col.Black);
		parT6.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT6.StringFormat.Alignment = StringAlignment.Center;
		parT6.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("n9", new But1(parT6, delegate
		{
			Sounds.操作.Play();
			SetNum("9");
		}));
		ParT parT7 = new ParT();
		parT7.Font = new Font("MS Gothic", 0.1f);
		parT7.PositionBase = position + DrawBuffer.GetPosition(0.0, 0.14);
		parT7.Text = "4";
		parT7.FontSize = 0.15;
		parT7.SizeBase = 0.07;
		parT7.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT7.OP.ScalingXY(parT7.OP.GetCenter(), 0.3, 0.3);
		parT7.Closed = true;
		parT7.TextColor = Col.White;
		parT7.BrushColor = Color.FromArgb(160, Col.Black);
		parT7.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT7.StringFormat.Alignment = StringAlignment.Center;
		parT7.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("n4", new But1(parT7, delegate
		{
			Sounds.操作.Play();
			SetNum("4");
		}));
		ParT parT8 = new ParT();
		parT8.Font = new Font("MS Gothic", 0.1f);
		parT8.PositionBase = position + DrawBuffer.GetPosition(0.06, 0.14);
		parT8.Text = "5";
		parT8.FontSize = 0.15;
		parT8.SizeBase = 0.07;
		parT8.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT8.OP.ScalingXY(parT8.OP.GetCenter(), 0.3, 0.3);
		parT8.Closed = true;
		parT8.TextColor = Col.White;
		parT8.BrushColor = Color.FromArgb(160, Col.Black);
		parT8.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT8.StringFormat.Alignment = StringAlignment.Center;
		parT8.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("n5", new But1(parT8, delegate
		{
			Sounds.操作.Play();
			SetNum("5");
		}));
		ParT parT9 = new ParT();
		parT9.Font = new Font("MS Gothic", 0.1f);
		parT9.PositionBase = position + DrawBuffer.GetPosition(0.12, 0.14);
		parT9.Text = "6";
		parT9.FontSize = 0.15;
		parT9.SizeBase = 0.07;
		parT9.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT9.OP.ScalingXY(parT9.OP.GetCenter(), 0.3, 0.3);
		parT9.Closed = true;
		parT9.TextColor = Col.White;
		parT9.BrushColor = Color.FromArgb(160, Col.Black);
		parT9.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT9.StringFormat.Alignment = StringAlignment.Center;
		parT9.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("n6", new But1(parT9, delegate
		{
			Sounds.操作.Play();
			SetNum("6");
		}));
		ParT parT10 = new ParT();
		parT10.Font = new Font("MS Gothic", 0.1f);
		parT10.PositionBase = position + DrawBuffer.GetPosition(0.0, 0.21);
		parT10.Text = "1";
		parT10.FontSize = 0.15;
		parT10.SizeBase = 0.07;
		parT10.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT10.OP.ScalingXY(parT10.OP.GetCenter(), 0.3, 0.3);
		parT10.Closed = true;
		parT10.TextColor = Col.White;
		parT10.BrushColor = Color.FromArgb(160, Col.Black);
		parT10.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT10.StringFormat.Alignment = StringAlignment.Center;
		parT10.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("n1", new But1(parT10, delegate
		{
			Sounds.操作.Play();
			SetNum("1");
		}));
		ParT parT11 = new ParT();
		parT11.Font = new Font("MS Gothic", 0.1f);
		parT11.PositionBase = position + DrawBuffer.GetPosition(0.06, 0.21);
		parT11.Text = "2";
		parT11.FontSize = 0.15;
		parT11.SizeBase = 0.07;
		parT11.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT11.OP.ScalingXY(parT11.OP.GetCenter(), 0.3, 0.3);
		parT11.Closed = true;
		parT11.TextColor = Col.White;
		parT11.BrushColor = Color.FromArgb(160, Col.Black);
		parT11.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT11.StringFormat.Alignment = StringAlignment.Center;
		parT11.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("n2", new But1(parT11, delegate
		{
			Sounds.操作.Play();
			SetNum("2");
		}));
		ParT parT12 = new ParT();
		parT12.Font = new Font("MS Gothic", 0.1f);
		parT12.PositionBase = position + DrawBuffer.GetPosition(0.12, 0.21);
		parT12.Text = "3";
		parT12.FontSize = 0.15;
		parT12.SizeBase = 0.07;
		parT12.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT12.OP.ScalingXY(parT12.OP.GetCenter(), 0.3, 0.3);
		parT12.Closed = true;
		parT12.TextColor = Col.White;
		parT12.BrushColor = Color.FromArgb(160, Col.Black);
		parT12.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT12.StringFormat.Alignment = StringAlignment.Center;
		parT12.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("n3", new But1(parT12, delegate
		{
			Sounds.操作.Play();
			SetNum("3");
		}));
		ParT parT13 = new ParT();
		parT13.Font = new Font("MS Gothic", 0.1f);
		parT13.PositionBase = position + DrawBuffer.GetPosition(0.0, 0.28);
		parT13.Text = "0";
		parT13.FontSize = 0.15;
		parT13.SizeBase = 0.07;
		parT13.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT13.OP.ScalingXY(parT13.OP.GetCenter(), 0.3, 0.3);
		parT13.Closed = true;
		parT13.TextColor = Col.White;
		parT13.BrushColor = Color.FromArgb(160, Col.Black);
		parT13.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT13.StringFormat.Alignment = StringAlignment.Center;
		parT13.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("n0", new But1(parT13, delegate
		{
			Sounds.操作.Play();
			SetNum("0");
		}));
		ParT parT14 = new ParT();
		parT14.Font = new Font("MS Gothic", 0.1f);
		parT14.PositionBase = position + DrawBuffer.GetPosition(0.12, 0.28);
		parT14.Text = GameText.借;
		parT14.FontSize = 0.15;
		parT14.SizeBase = 0.07;
		parT14.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT14.OP.ScalingXY(parT14.OP.GetCenter(), 0.3, 0.3);
		parT14.Closed = true;
		parT14.TextColor = Col.White;
		parT14.BrushColor = Color.FromArgb(160, Col.Black);
		parT14.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT14.StringFormat.Alignment = StringAlignment.Center;
		parT14.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("nb", new But1(parT14, delegate
		{
			if (Sta.GameData.日借金可能額 != 0)
			{
				ulong num3 = ulong.Parse(ip.Text, NumberStyles.AllowThousands);
				if (num3 != 0)
				{
					if (num3 > Sta.GameData.日借金可能額)
					{
						num3 = Sta.GameData.日借金可能額;
						ip.SubInfo = GameText.借金可能額以上は無視されます;
					}
					Sta.GameData.日借金額 += num3;
					Sta.GameData.所持金 = Sta.GameData.所持金.加算(num3);
					Sta.GameData.借金 = Sta.GameData.借金.加算(num3);
					bs["nr"].Dra = Sta.GameData.借金 != 0;
					ip.TextIm = "0";
					Sounds.精算.Play();
					ip.UpdateSub2();
					ヴィオラ台詞.Set();
				}
				else
				{
					Sounds.操作.Play();
				}
			}
			else
			{
				Sounds.操作.Play();
				ip.SubInfo = GameText.今日はこれ以上借りることが出来ません;
			}
		}));
		ParT parT15 = new ParT();
		parT15.Font = new Font("MS Gothic", 0.1f);
		parT15.PositionBase = position + DrawBuffer.GetPosition(0.06, 0.28);
		parT15.Text = GameText.返;
		parT15.FontSize = 0.15;
		parT15.SizeBase = 0.07;
		parT15.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT15.OP.ScalingXY(parT15.OP.GetCenter(), 0.3, 0.3);
		parT15.Closed = true;
		parT15.TextColor = Col.White;
		parT15.BrushColor = Color.FromArgb(160, Col.Black);
		parT15.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT15.StringFormat.Alignment = StringAlignment.Center;
		parT15.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("nr", new But1(parT15, delegate
		{
			if (Sta.GameData.所持金 != 0)
			{
				ulong num2 = ulong.Parse(ip.Text, NumberStyles.AllowThousands);
				if (num2 != 0)
				{
					if (num2 > Sta.GameData.所持金)
					{
						num2 = Sta.GameData.所持金;
						ip.SubInfo = GameText.返済可能額以上は無視されます;
					}
					if (num2 > Sta.GameData.借金)
					{
						Sta.GameData.所持金 = Sta.GameData.所持金.減算(Sta.GameData.借金);
						Sta.GameData.借金 = 0uL;
						ip.SubInfo = GameText.返済可能額以上は無視されます;
					}
					else
					{
						Sta.GameData.所持金 = Sta.GameData.所持金.減算(num2);
						Sta.GameData.借金 = Sta.GameData.借金.減算(num2);
					}
					bs["nr"].Dra = Sta.GameData.借金 != 0;
					ip.TextIm = "0";
					Sounds.精算.Play();
					ip.UpdateSub2();
				}
				else
				{
					Sounds.操作.Play();
				}
			}
			else
			{
				Sounds.操作.Play();
				ip.SubInfo = GameText.所持金がありません;
			}
		}));
		bs.SetHitColor(Med);
		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Down(ref hc);
					if (mb == MouseButtons.Right && !processing)
					{
						Sounds.操作.Play();
						SDShow = false;
						ip.Up(ref hc);
						dbs.Move(ref hc);
					}
				}
				else
				{
					switch (mb)
					{
					case MouseButtons.Left:
						if (!ip.選択肢表示)
						{
							ヴィオラ吹出し.Down(ヴィオラ吹出し.GetHitColor);
							dbs.Down(ref hc);
							bs.Down(ref hc);
						}
						ip.Down(ref hc);
						break;
					case MouseButtons.Right:
						if (!ip.選択肢表示)
						{
							bs["ボタン0"].Action(bs["ボタン0"]);
						}
						else
						{
							ip.nb.Action(ip.nb);
						}
						break;
					}
				}
			}
		};
		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Up(ref hc);
				}
				else if (mb == MouseButtons.Left)
				{
					if (!ip.選択肢表示)
					{
						ヴィオラ吹出し.Up(ヴィオラ吹出し.GetHitColor);
						dbs.Up(ref hc);
						bs.Up(ref hc);
					}
					ip.Up(ref hc);
				}
			}
		};
		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Move(ref hc);
				}
				else
				{
					if (!ip.選択肢表示)
					{
						dbs.Move(ref hc);
						bs.Move(ref hc);
						Player説明(ref hc, delegate
						{
							si.Set(bre: false);
						});
					}
					ip.Move(ref hc);
				}
			}
		};
		mod.Leave = delegate
		{
			if (SDShow)
			{
				SaveData.Leave();
			}
			else if (!ip.選択肢表示)
			{
				dbs.Leave();
				bs.Leave();
			}
		};
		mod.Wheel = delegate
		{
		};
		mod.Setting = delegate
		{
			if (Med.Modeb != "PlayerInformation")
			{
				ip.TextIm = "0";
				ip.UpdateSub2();
				ip.MaiShow = true;
				ip.Mai.Feed.Dra = false;
				ip.Mai2Show = false;
				ip.SubShow = true;
				ip.Sub2Show = true;
				Viola.両目_見つめ();
				Viola.両瞼_半1();
				Viola.両瞼_卑();
				Viola.口_薄笑();
				Viola.両腕_人_腕下げ(0, 左右: false, 前後: false);
				Viola.両触手_S字(0);
				Viola.両触手_S字(1);
				Viola.SetSymmetry();
				ヴィオラ台詞.Set();
				si.Set(bre: false);
				bs["nr"].Dra = Sta.GameData.借金 != 0;
				bs["nr"].Dra = Sta.GameData.借金 != 0;
			}
		};
		DrawDebt = delegate(Are a, FPS FPS)
		{
			Med.GH.Clear(Col.Transparent);
			if (a.GH != null)
			{
				a.GH.Clear(Col.Transparent);
			}
			a.Draw(OfficeBackground);
			Viola.Draw(a, FPS);
			ヴィオラ吹出し.Draw(a, FPS);
			bs.Draw(a);
			dbs.Draw(a);
			ip.Draw(a, FPS);
			if (SDShow)
			{
				SaveData.Draw(a);
			}
			Med.Draw(a);
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, DrawDebt);
		};
		mod.Dispose = delegate
		{
			bs.Dispose();
		};
		return mod;
	}

	public static Module SlaveShop(Med Med)
	{
		Module mod = new Module();
		Cha PurchasTarget = null;
		bool d = false;
		Action Reload = null;
		Unit u = null;
		Generator g = null;
		Buts bs = new Buts();
		ParT parT = new ParT();
		parT.Font = new Font("MS Gothic", 0.1f);
		parT.PositionBase = DrawBuffer.GetPosition(0.85, 0.02);
		parT.Text = GameText.戻る;
		parT.FontSize = 0.15;
		parT.SizeBase = 0.05;
		parT.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT.OP.ScalingY(parT.OP.GetCenter(), 0.47);
		parT.OP.Rotation(parT.OP.GetCenter(), -26.0);
		parT.Closed = true;
		parT.TextColor = Col.White;
		parT.BrushColor = Color.FromArgb(160, Col.Black);
		parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT.StringFormat.Alignment = StringAlignment.Center;
		parT.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン0", new But1(parT, delegate
		{
			Sounds.操作.Play();
			if (Sta.GameData.初事務所フラグ)
			{
				Med.SwitchMode("初事務所", DrawBuffer, 初事務所描画);
			}
			else
			{
				Med.Mode = "Office";
			}
		}));
		ParT parT2 = new ParT();
		parT2.Font = new Font("MS Gothic", 0.1f);
		parT2.PositionBase = DrawBuffer.GetPosition(0.85, 0.1);
		parT2.Text = GameText.奴隷;
		parT2.FontSize = 0.15;
		parT2.SizeBase = 0.05;
		parT2.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT2.OP.ScalingY(parT2.OP.GetCenter(), 0.47);
		parT2.OP.Rotation(parT2.OP.GetCenter(), -26.0);
		parT2.Closed = true;
		parT2.TextColor = Col.White;
		parT2.BrushColor = Color.FromArgb(160, Col.Black);
		parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT2.StringFormat.Alignment = StringAlignment.Center;
		parT2.StringFormat.LineAlignment = StringAlignment.Center;
		parT2.PenColor = Color.Red;
		bs.Add("ボタン1", new But1(parT2, delegate
		{
			Sounds.操作.Play();
			Med.Mode = "SlaveShop";
		}));
		ParT parT3 = new ParT();
		parT3.Font = new Font("MS Gothic", 0.1f);
		parT3.PositionBase = DrawBuffer.GetPosition(0.85, 0.18);
		parT3.Text = GameText.道具;
		parT3.FontSize = 0.15;
		parT3.SizeBase = 0.05;
		parT3.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT3.OP.ScalingY(parT3.OP.GetCenter(), 0.47);
		parT3.OP.Rotation(parT3.OP.GetCenter(), -26.0);
		parT3.Closed = true;
		parT3.TextColor = Col.White;
		parT3.BrushColor = Color.FromArgb(160, Col.Black);
		parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT3.StringFormat.Alignment = StringAlignment.Center;
		parT3.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン2", new But1(parT3, delegate
		{
			Sounds.操作.Play();
			Med.Mode = "ToolShop";
		}));
		Color bs初期縁色 = Col.Black;
		Action bs縁色初期化 = delegate
		{
			foreach (But item in bs.EnumBut.Skip(3).Take(10))
			{
				item.Pars.Values.First().ToParT().PenColor = bs初期縁色;
			}
		};
		double num = 0.7;
		double num2 = -0.03;
		ParT parT4 = new ParT();
		parT4.Font = new Font("MS Gothic", 0.1f);
		parT4.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.02 * num);
		parT4.Text = GameText.ランダム;
		parT4.FontSize = 0.15;
		parT4.SizeBase = 0.05;
		parT4.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT4.OP.ScalingY(parT4.OP.GetCenter(), 0.5 * num);
		parT4.Closed = true;
		parT4.TextColor = Col.White;
		parT4.BrushColor = Color.FromArgb(160, Col.Black);
		parT4.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT4.StringFormat.Alignment = StringAlignment.Center;
		parT4.StringFormat.LineAlignment = StringAlignment.Center;
		parT4.PenColor = Color.Red;
		bs.Add("対象0", new But1(parT4, delegate(But bu)
		{
			if (d)
			{
				Sounds.操作.Play();
			}
			d = true;
			bs縁色初期化();
			bu.Pars.Values.First().ToParT().PenColor = Color.Red;
			Reload();
		}));
		ParT parT5 = new ParT();
		parT5.Font = new Font("MS Gothic", 0.1f);
		parT5.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.1 * num);
		parT5.Text = GameText.鳥系;
		parT5.FontSize = 0.15;
		parT5.SizeBase = 0.05;
		parT5.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT5.OP.ScalingY(parT5.OP.GetCenter(), 0.5 * num);
		parT5.Closed = true;
		parT5.TextColor = Col.White;
		parT5.BrushColor = Color.FromArgb(160, Col.Black);
		parT5.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT5.StringFormat.Alignment = StringAlignment.Center;
		parT5.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("対象1", new But1(parT5, delegate(But bu)
		{
			Sounds.操作.Play();
			bs縁色初期化();
			bu.Pars.Values.First().ToParT().PenColor = Color.Red;
			Reload();
		}));
		ParT parT6 = new ParT();
		parT6.Font = new Font("MS Gothic", 0.1f);
		parT6.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.18 * num);
		parT6.Text = GameText.蛇系;
		parT6.FontSize = 0.15;
		parT6.SizeBase = 0.05;
		parT6.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT6.OP.ScalingY(parT6.OP.GetCenter(), 0.5 * num);
		parT6.Closed = true;
		parT6.TextColor = Col.White;
		parT6.BrushColor = Color.FromArgb(160, Col.Black);
		parT6.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT6.StringFormat.Alignment = StringAlignment.Center;
		parT6.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("対象2", new But1(parT6, delegate(But bu)
		{
			Sounds.操作.Play();
			bs縁色初期化();
			bu.Pars.Values.First().ToParT().PenColor = Color.Red;
			Reload();
		}));
		ParT parT7 = new ParT();
		parT7.Font = new Font("MS Gothic", 0.1f);
		parT7.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.26 * num);
		parT7.Text = GameText.獣系;
		parT7.FontSize = 0.15;
		parT7.SizeBase = 0.05;
		parT7.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT7.OP.ScalingY(parT7.OP.GetCenter(), 0.5 * num);
		parT7.Closed = true;
		parT7.TextColor = Col.White;
		parT7.BrushColor = Color.FromArgb(160, Col.Black);
		parT7.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT7.StringFormat.Alignment = StringAlignment.Center;
		parT7.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("対象3", new But1(parT7, delegate(But bu)
		{
			Sounds.操作.Play();
			bs縁色初期化();
			bu.Pars.Values.First().ToParT().PenColor = Color.Red;
			Reload();
		}));
		ParT parT8 = new ParT();
		parT8.Font = new Font("MS Gothic", 0.1f);
		parT8.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.34 * num);
		parT8.Text = GameText.水系;
		parT8.FontSize = 0.15;
		parT8.SizeBase = 0.05;
		parT8.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT8.OP.ScalingY(parT8.OP.GetCenter(), 0.5 * num);
		parT8.Closed = true;
		parT8.TextColor = Col.White;
		parT8.BrushColor = Color.FromArgb(160, Col.Black);
		parT8.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT8.StringFormat.Alignment = StringAlignment.Center;
		parT8.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("対象4", new But1(parT8, delegate(But bu)
		{
			Sounds.操作.Play();
			bs縁色初期化();
			bu.Pars.Values.First().ToParT().PenColor = Color.Red;
			Reload();
		}));
		ParT parT9 = new ParT();
		parT9.Font = new Font("MS Gothic", 0.1f);
		parT9.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.42 * num);
		parT9.Text = GameText.虫系;
		parT9.FontSize = 0.15;
		parT9.SizeBase = 0.05;
		parT9.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT9.OP.ScalingY(parT9.OP.GetCenter(), 0.5 * num);
		parT9.Closed = true;
		parT9.TextColor = Col.White;
		parT9.BrushColor = Color.FromArgb(160, Col.Black);
		parT9.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT9.StringFormat.Alignment = StringAlignment.Center;
		parT9.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("対象5", new But1(parT9, delegate(But bu)
		{
			Sounds.操作.Play();
			bs縁色初期化();
			bu.Pars.Values.First().ToParT().PenColor = Color.Red;
			Reload();
		}));
		ParT parT10 = new ParT();
		parT10.Font = new Font("MS Gothic", 0.1f);
		parT10.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.5 * num);
		parT10.Text = GameText.人型;
		parT10.FontSize = 0.15;
		parT10.SizeBase = 0.05;
		parT10.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT10.OP.ScalingY(parT10.OP.GetCenter(), 0.5 * num);
		parT10.Closed = true;
		parT10.TextColor = Col.White;
		parT10.BrushColor = Color.FromArgb(160, Col.Black);
		parT10.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT10.StringFormat.Alignment = StringAlignment.Center;
		parT10.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("対象6", new But1(parT10, delegate(But bu)
		{
			Sounds.操作.Play();
			bs縁色初期化();
			bu.Pars.Values.First().ToParT().PenColor = Color.Red;
			Reload();
		}));
		ParT parT11 = new ParT();
		parT11.Font = new Font("MS Gothic", 0.1f);
		parT11.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.58 * num);
		parT11.Text = GameText.幻獣;
		parT11.FontSize = 0.15;
		parT11.SizeBase = 0.05;
		parT11.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT11.OP.ScalingY(parT11.OP.GetCenter(), 0.5 * num);
		parT11.Closed = true;
		parT11.TextColor = Col.White;
		parT11.BrushColor = Color.FromArgb(160, Col.Black);
		parT11.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT11.StringFormat.Alignment = StringAlignment.Center;
		parT11.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("対象7", new But1(parT11, delegate(But bu)
		{
			Sounds.操作.Play();
			bs縁色初期化();
			bu.Pars.Values.First().ToParT().PenColor = Color.Red;
			Reload();
		}));
		ParT parT12 = new ParT();
		parT12.Font = new Font("MS Gothic", 0.1f);
		parT12.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.66 * num);
		parT12.Text = GameText.魔獣;
		parT12.FontSize = 0.15;
		parT12.SizeBase = 0.05;
		parT12.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT12.OP.ScalingY(parT12.OP.GetCenter(), 0.5 * num);
		parT12.Closed = true;
		parT12.TextColor = Col.White;
		parT12.BrushColor = Color.FromArgb(160, Col.Black);
		parT12.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT12.StringFormat.Alignment = StringAlignment.Center;
		parT12.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("対象8", new But1(parT12, delegate(But bu)
		{
			Sounds.操作.Play();
			bs縁色初期化();
			bu.Pars.Values.First().ToParT().PenColor = Color.Red;
			Reload();
		}));
		ParT parT13 = new ParT();
		parT13.Font = new Font("MS Gothic", 0.1f);
		parT13.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.74 * num);
		parT13.Text = GameText.竜系;
		parT13.FontSize = 0.15;
		parT13.SizeBase = 0.05;
		parT13.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT13.OP.ScalingY(parT13.OP.GetCenter(), 0.5 * num);
		parT13.Closed = true;
		parT13.TextColor = Col.White;
		parT13.BrushColor = Color.FromArgb(160, Col.Black);
		parT13.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT13.StringFormat.Alignment = StringAlignment.Center;
		parT13.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("対象9", new But1(parT13, delegate(But bu)
		{
			Sounds.操作.Play();
			bs縁色初期化();
			bu.Pars.Values.First().ToParT().PenColor = Color.Red;
			Reload();
		}));
		Action SetGen = delegate
		{
			if (bs["対象0"].Pars.Values.First().ToParT().PenColor == Color.Red)
			{
				if ((Sta.GameData.鳥系.Count != 0 && Sta.GameData.系統開放[0]) || (Sta.GameData.蛇系.Count != 0 && Sta.GameData.系統開放[1]) || (Sta.GameData.獣系.Count != 0 && Sta.GameData.系統開放[2]) || (Sta.GameData.水系.Count != 0 && Sta.GameData.系統開放[3]) || (Sta.GameData.虫系.Count != 0 && Sta.GameData.系統開放[4]) || (Sta.GameData.人型.Count != 0 && Sta.GameData.系統開放[5]) || (Sta.GameData.幻獣.Count != 0 && Sta.GameData.系統開放[6]) || (Sta.GameData.魔獣.Count != 0 && Sta.GameData.系統開放[7]) || (Sta.GameData.竜系.Count != 0 && Sta.GameData.系統開放[8]))
				{
					do
					{
						switch (RNG.XS.Next(Sta.GameData.系統開放.Count((bool e) => e)))
						{
						case 0:
							g = Sta.GameData.鳥系;
							break;
						case 1:
							g = Sta.GameData.蛇系;
							break;
						case 2:
							g = Sta.GameData.獣系;
							break;
						case 3:
							g = Sta.GameData.水系;
							break;
						case 4:
							g = Sta.GameData.虫系;
							break;
						case 5:
							g = Sta.GameData.人型;
							break;
						case 6:
							g = Sta.GameData.幻獣;
							break;
						case 7:
							g = Sta.GameData.魔獣;
							break;
						case 8:
							g = Sta.GameData.竜系;
							break;
						}
					}
					while (g.Count == 0);
				}
				else
				{
					switch (RNG.XS.Next(Sta.GameData.系統開放.Count((bool e) => e)))
					{
					case 0:
						g = Sta.GameData.鳥系;
						break;
					case 1:
						g = Sta.GameData.蛇系;
						break;
					case 2:
						g = Sta.GameData.獣系;
						break;
					case 3:
						g = Sta.GameData.水系;
						break;
					case 4:
						g = Sta.GameData.虫系;
						break;
					case 5:
						g = Sta.GameData.人型;
						break;
					case 6:
						g = Sta.GameData.幻獣;
						break;
					case 7:
						g = Sta.GameData.魔獣;
						break;
					case 8:
						g = Sta.GameData.竜系;
						break;
					}
				}
			}
			else if (bs["対象1"].Pars.Values.First().ToParT().PenColor == Color.Red)
			{
				g = Sta.GameData.鳥系;
			}
			else if (bs["対象2"].Pars.Values.First().ToParT().PenColor == Color.Red)
			{
				g = Sta.GameData.蛇系;
			}
			else if (bs["対象3"].Pars.Values.First().ToParT().PenColor == Color.Red)
			{
				g = Sta.GameData.獣系;
			}
			else if (bs["対象4"].Pars.Values.First().ToParT().PenColor == Color.Red)
			{
				g = Sta.GameData.水系;
			}
			else if (bs["対象5"].Pars.Values.First().ToParT().PenColor == Color.Red)
			{
				g = Sta.GameData.虫系;
			}
			else if (bs["対象6"].Pars.Values.First().ToParT().PenColor == Color.Red)
			{
				g = Sta.GameData.人型;
			}
			else if (bs["対象7"].Pars.Values.First().ToParT().PenColor == Color.Red)
			{
				g = Sta.GameData.幻獣;
			}
			else if (bs["対象8"].Pars.Values.First().ToParT().PenColor == Color.Red)
			{
				g = Sta.GameData.魔獣;
			}
			else if (bs["対象9"].Pars.Values.First().ToParT().PenColor == Color.Red)
			{
				g = Sta.GameData.竜系;
			}
		};
		Reload = delegate
		{
			SetGen();
			g.Rotation();
			u = g.RefCharacter();
			if (u != null)
			{
				PurchasTarget?.Dispose();
				PurchasTarget = new Cha(Med, DrawBuffer, u.ChaD);

				PurchasTarget.SetInitialExpression();
				PurchasTarget.Emotion();
				PurchasTarget.UpdateExpression();
				PurchasTarget.Bod.拘束具_表示 = true;
				PurchasTarget.Set拘束姿勢();
				PurchasTarget.Set衣装(u.着衣);
				ip.TextIm = u.GetStatus();
			}
			else
			{
				ip.Mai.TextIm = GameText.売り切れです;
			}
		};
		ParT parT14 = new ParT();
		parT14.Font = new Font("MS Gothic", 0.1f);
		parT14.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.9 * num);
		parT14.Text = GameText.チェンジ;
		parT14.FontSize = 0.15;
		parT14.SizeBase = 0.05;
		parT14.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT14.OP.ScalingY(parT14.OP.GetCenter(), 0.5 * num);
		parT14.Closed = true;
		parT14.TextColor = Col.White;
		parT14.BrushColor = Color.FromArgb(160, Col.Black);
		parT14.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT14.StringFormat.Alignment = StringAlignment.Center;
		parT14.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("変更", new But1(parT14, delegate
		{
			if (!ip.Mai.TextIm.StartsWith(GameText.売り切れです))
			{
				Sounds.変更Play();
			}
			else
			{
				Sounds.操作.Play();
			}
			Reload();
		}));
		ParT parT15 = new ParT();
		parT15.Font = new Font("MS Gothic", 0.1f);
		parT15.PositionBase = DrawBuffer.GetPosition(0.01, num2 + 0.98 * num);
		parT15.Text = GameText.購入;
		parT15.FontSize = 0.15;
		parT15.SizeBase = 0.05;
		parT15.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT15.OP.ScalingY(parT15.OP.GetCenter(), 0.5 * num);
		parT15.Closed = true;
		parT15.TextColor = Col.White;
		parT15.BrushColor = Color.FromArgb(160, Col.Black);
		parT15.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT15.StringFormat.Alignment = StringAlignment.Center;
		parT15.StringFormat.LineAlignment = StringAlignment.Center;
		ulong 買値;
		bs.Add("購入", new But1(parT15, delegate
		{
			if (Sta.GameData.Is地下室一杯())
			{
				Sounds.操作.Play();
				ip.SubInfoIm = GameText.これ以上奴隷を収容できません;
			}
			else if (u == null)
			{
				Sounds.操作.Play();
				ip.Mai.TextIm = GameText.売り切れです;
			}
			else if (Sta.GameData.所持金 < (買値 = (ulong)((double)u.GetPrice() * ((Sta.GameData.祝福 == Sta.GameData.ヴィオラ) ? 0.6 : 1.0))))
			{
				Sounds.操作.Play();
				ip.SubInfoIm = GameText.所持金が足りません;
			}
			else
			{
				u.Price = 買値;
				Sta.GameData.所持金 -= 買値;
				Sounds.精算.Play();
				ip.UpdateSub2();
				Sta.GameData.Add地下室(g.GetCharacter());
				Reload();
			}
		}));
		bs.SetHitColor(Med);
		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Down(ref hc);
					if (mb == MouseButtons.Right && !processing)
					{
						Sounds.操作.Play();
						SDShow = false;
						ip.Up(ref hc);
						dbs.Move(ref hc);
					}
				}
				else
				{
					switch (mb)
					{
					case MouseButtons.Left:
						if (!ip.選択肢表示)
						{
							dbs.Down(ref hc);
							bs.Down(ref hc);
						}
						ip.Down(ref hc);
						break;
					case MouseButtons.Right:
						if (!ip.選択肢表示)
						{
							bs["ボタン0"].Action(bs["ボタン0"]);
						}
						else
						{
							ip.nb.Action(ip.nb);
						}
						break;
					}
				}
			}
		};
		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Up(ref hc);
				}
				else if (mb == MouseButtons.Left)
				{
					if (!ip.選択肢表示)
					{
						dbs.Up(ref hc);
						bs.Up(ref hc);
					}
					ip.Up(ref hc);
				}
			}
		};
		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Move(ref hc);
				}
				else
				{
					if (!ip.選択肢表示)
					{
						dbs.Move(ref hc);
						bs.Move(ref hc);
						Player説明(ref hc, delegate
						{
							si.Set(bre: false);
						});
					}
					ip.Move(ref hc);
				}
			}
		};
		mod.Leave = delegate
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Leave();
				}
				else if (!ip.選択肢表示)
				{
					dbs.Leave();
					bs.Leave();
				}
			}
		};
		mod.Wheel = delegate(MouseButtons mb, Vector2D cp, int dt, Color hc)
		{
			int num3 = 0;
			using (IEnumerator<But> enumerator = bs.EnumBut.Skip(3).Take(10).GetEnumerator())
			{
				while (enumerator.MoveNext() && !(enumerator.Current.Pars.Values.First().ToParT().PenColor == Color.Red))
				{
					num3++;
				}
			}
			int num4 = Sta.GameData.系統開放.Count((bool e) => e) + 1;
			int num5 = num3 - dt.Sign();
			if (num5 < 0)
			{
				num5 = num4 - 1;
			}
			num5 %= num4;
			But but = bs["対象" + num5];
			but.Action(but);
		};
		mod.Setting = delegate
		{
			if (Med.Modeb != "PlayerInformation")
			{
				ip.UpdateSub2();
				ip.MaiShow = true;
				ip.Mai.Feed.Dra = false;
				ip.Mai2Show = false;
				ip.SubShow = true;
				ip.Sub2Show = true;
				bs["対象1"].Dra = Sta.GameData.系統開放[0];
				bs["対象2"].Dra = Sta.GameData.系統開放[1];
				bs["対象3"].Dra = Sta.GameData.系統開放[2];
				bs["対象4"].Dra = Sta.GameData.系統開放[3];
				bs["対象5"].Dra = Sta.GameData.系統開放[4];
				bs["対象6"].Dra = Sta.GameData.系統開放[5];
				bs["対象7"].Dra = Sta.GameData.系統開放[6];
				bs["対象8"].Dra = Sta.GameData.系統開放[7];
				bs["対象9"].Dra = Sta.GameData.系統開放[8];
				if (Sta.RefreshStoreEveryTime)
				{
					Sta.GameData.新日 = true;
				}
				if (Sta.GameData.新日)
				{
					Sta.GameData.GenRefresh();
					Sta.GameData.新日 = false;
				}
				Reload();
				si.Set(bre: false);
			}
		};
		DrawSlaveShop = delegate(Are a, FPS FPS)
		{
			Med.GH.Clear(Col.Transparent);
			if (a.GH != null)
			{
				a.GH.Clear(Col.Transparent);
			}
			a.Draw(OfficeBackground);
			if (u != null)
			{
				PurchasTarget.Draw(a, FPS);
			}
			bs.Draw(a);
			dbs.Draw(a);
			ip.Draw(a, FPS);
			if (SDShow)
			{
				SaveData.Draw(a);
			}
			Med.Draw(a);
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, DrawSlaveShop);
		};
		mod.Dispose = delegate
		{
			if (PurchasTarget != null)
			{
				PurchasTarget.Dispose();
			}
			bs.Dispose();
		};
		奴隷UI初期化 = delegate
		{
			d = false;
			bs縁色初期化();
			bs["対象0"].Pars.Values.First().ToParT().PenColor = Color.Red;
		};
		return mod;
	}

	public static Module ToolShop(Med Med)
	{
		Module mod = new Module();
		Buts bs = new Buts();
		ParT parT = new ParT();
		parT.Font = new Font("MS Gothic", 0.1f);
		parT.PositionBase = DrawBuffer.GetPosition(0.85, 0.02);
		parT.Text = GameText.戻る;
		parT.FontSize = 0.15;
		parT.SizeBase = 0.05;
		parT.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT.OP.ScalingY(parT.OP.GetCenter(), 0.47);
		parT.OP.Rotation(parT.OP.GetCenter(), -26.0);
		parT.Closed = true;
		parT.TextColor = Col.White;
		parT.BrushColor = Color.FromArgb(160, Col.Black);
		parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT.StringFormat.Alignment = StringAlignment.Center;
		parT.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン0", new But1(parT, delegate
		{
			Sounds.操作.Play();
			if (Sta.GameData.初事務所フラグ)
			{
				Med.SwitchMode("初事務所", DrawBuffer, 初事務所描画);
			}
			else
			{
				Med.Mode = "Office";
			}
		}));
		ParT parT2 = new ParT();
		parT2.Font = new Font("MS Gothic", 0.1f);
		parT2.PositionBase = DrawBuffer.GetPosition(0.85, 0.1);
		parT2.Text = GameText.奴隷;
		parT2.FontSize = 0.15;
		parT2.SizeBase = 0.05;
		parT2.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT2.OP.ScalingY(parT2.OP.GetCenter(), 0.47);
		parT2.OP.Rotation(parT2.OP.GetCenter(), -26.0);
		parT2.Closed = true;
		parT2.TextColor = Col.White;
		parT2.BrushColor = Color.FromArgb(160, Col.Black);
		parT2.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT2.StringFormat.Alignment = StringAlignment.Center;
		parT2.StringFormat.LineAlignment = StringAlignment.Center;
		bs.Add("ボタン1", new But1(parT2, delegate
		{
			Sounds.操作.Play();
			Med.Mode = "SlaveShop";
		}));
		ParT parT3 = new ParT();
		parT3.Font = new Font("MS Gothic", 0.1f);
		parT3.PositionBase = DrawBuffer.GetPosition(0.85, 0.18);
		parT3.Text = GameText.道具;
		parT3.FontSize = 0.15;
		parT3.SizeBase = 0.05;
		parT3.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT3.OP.ScalingY(parT3.OP.GetCenter(), 0.47);
		parT3.OP.Rotation(parT3.OP.GetCenter(), -26.0);
		parT3.Closed = true;
		parT3.TextColor = Col.White;
		parT3.BrushColor = Color.FromArgb(160, Col.Black);
		parT3.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT3.StringFormat.Alignment = StringAlignment.Center;
		parT3.StringFormat.LineAlignment = StringAlignment.Center;
		parT3.PenColor = Color.Red;
		bs.Add("ボタン2", new But1(parT3, delegate
		{
			Sounds.操作.Play();
			Med.Mode = "ToolShop";
		}));
		bs.SetHitColor(Med);
		ListView lv = null;
		Action<But, int, ulong> buy = delegate(But but, int ind, ulong pri)
		{
			if (Sta.GameData.所持金 >= pri)
			{
				but.Dra = false;
				Sta.GameData.PurchasedTools[ind] = true;
				Sta.GameData.所持金 -= pri;
				Sounds.精算.Play();
				ip.UpdateSub2();
				ip.TextIm = " ";
				if (!lv.bs.EnumBut.Any((But e) => e.Dra))
				{
					ip.SubInfo = GameText.買える物は何も無い;
					ip.TextIm = GameText.売り切れです;
				}
			}
			else
			{
				Sounds.操作.Play();
				ip.SubInfoIm = GameText.所持金が足りません;
			}
		};
		lv = new ListView(DrawBuffer, DrawBuffer.GetPosition(0.01, 0.03), 0.5, new Font("MS Gothic", 1f), 0.07, Col.White, Col.Empty, Color.FromArgb(160, Col.Black), Col.Black, new TA(GameText.ﾃﾞｨﾙﾄﾞﾊﾞｲﾌﾞ + " 35,000,000", delegate(But b)
		{
			buy(b, 0, 35000000uL);
		}), new TA(GameText.ﾉｰﾏﾙﾊﾞｲﾌﾞ + "   40,000,000", delegate(But b)
		{
			buy(b, 1, 40000000uL);
		}), new TA(GameText.ﾄﾞﾘﾙﾊﾞｲﾌﾞ + "   60,000,000", delegate(But b)
		{
			buy(b, 2, 60000000uL);
		}), new TA(GameText.ﾃﾞﾝﾏﾊﾞｲﾌﾞ + "   50,000,000", delegate(But b)
		{
			buy(b, 3, 50000000uL);
		}), new TA(GameText.ｱﾅﾙﾊﾞｲﾌﾞ + "    45,000,000", delegate(But b)
		{
			buy(b, 4, 45000000uL);
		}), new TA(GameText.調教鞭 + "      30,000,000", delegate(But b)
		{
			buy(b, 5, 30000000uL);
		}), new TA(GameText.羽根箒 + "      20,000,000", delegate(But b)
		{
			buy(b, 6, 20000000uL);
		}), new TA(GameText.T字剃刀 + "     20,000,000", delegate(But b)
		{
			buy(b, 7, 20000000uL);
		}), new TA(GameText.振動ｷｬｯﾌﾟ + "   30,000,000", delegate(But b)
		{
			buy(b, 8, 30000000uL);
		}), new TA(GameText.ﾋﾟﾝｸﾛｰﾀ + "     20,000,000", delegate(But b)
		{
			buy(b, 9, 20000000uL);
		}), new TA(GameText.ｱﾅﾙﾊﾟｰﾙ + "     20,000,000", delegate(But b)
		{
			buy(b, 10, 20000000uL);
		}), new TA(GameText.目隠帯 + "      25,000,000", delegate(But b)
		{
			buy(b, 11, 25000000uL);
		}), new TA(GameText.玉口枷 + "      20,000,000", delegate(But b)
		{
			buy(b, 12, 20000000uL);
		}), new TA(GameText.カメラ + "     100,000,000", delegate(But b)
		{
			buy(b, 13, 100000000uL);
		}), new TA(GameText.ﾌﾛｱ増設 + "    300,000,000", delegate(But b)
		{
			ulong num = 300000000uL;
			if (Sta.GameData.所持金 >= num)
			{
				Sta.GameData.フロア数++;
				if (Sta.GameData.フロア数 == 9)
				{
					b.Dra = false;
				}
				Sta.GameData.所持金 -= num;
				Sounds.精算.Play();
				ip.UpdateSub2();
				ip.TextIm = " ";
				if (!lv.bs.EnumBut.Any((But e) => e.Dra))
				{
					ip.SubInfo = GameText.買える物は何も無い;
					ip.TextIm = GameText.売り切れです;
				}
			}
			else
			{
				Sounds.操作.Play();
				ip.SubInfoIm = GameText.所持金が足りません;
			}
		}));
		lv.SetHitColor(Med);
		Action subinfo = delegate
		{
			if (lv.bs.EnumBut.Any((But e) => e.Dra))
			{
				ip.SubInfo = GameText.ふざけた値段だ;
			}
			else
			{
				ip.SubInfo = GameText.買える物は何も無い;
			}
		};
		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Down(ref hc);
					if (mb == MouseButtons.Right && !processing)
					{
						Sounds.操作.Play();
						SDShow = false;
						ip.Up(ref hc);
						dbs.Move(ref hc);
					}
				}
				else
				{
					switch (mb)
					{
					case MouseButtons.Left:
						if (!ip.選択肢表示)
						{
							dbs.Down(ref hc);
							bs.Down(ref hc);
							lv.Down(ref hc);
						}
						break;
					case MouseButtons.Right:
						if (!ip.選択肢表示)
						{
							bs["ボタン0"].Action(bs["ボタン0"]);
						}
						else
						{
							ip.nb.Action(ip.nb);
						}
						break;
					}
				}
			}
		};
		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Up(ref hc);
				}
				else if (mb == MouseButtons.Left)
				{
					if (!ip.選択肢表示)
					{
						dbs.Up(ref hc);
						bs.Up(ref hc);
						lv.Up(ref hc);
					}
					ip.Up(ref hc);
				}
			}
		};
		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Move(ref hc);
				}
				else
				{
					if (!ip.選択肢表示)
					{
						dbs.Move(ref hc);
						bs.Move(ref hc);
						lv.Move(ref hc);
						if (lv.bs["0"].Pars.Values.First().ToPar().HitColor == hc)
						{
							ip.TextIm = GameText.ペニスを模したバイブ + "\r\n" + GameText.刺激は控えめ;
						}
						if (lv.bs["1"].Pars.Values.First().ToPar().HitColor == hc)
						{
							ip.TextIm = GameText.一般的なバイブ + "\r\n" + GameText.ディルドバイブより刺激が強い;
						}
						if (lv.bs["2"].Pars.Values.First().ToPar().HitColor == hc)
						{
							ip.TextIm = GameText.振動と回転の2つの刺激をもたらすバイブ;
						}
						if (lv.bs["3"].Pars.Values.First().ToPar().HitColor == hc)
						{
							ip.TextIm = GameText.強力な振動のバイブ + "\r\n" + GameText.刺激が強い;
						}
						if (lv.bs["4"].Pars.Values.First().ToPar().HitColor == hc)
						{
							ip.TextIm = GameText.アナルの調教に適したバイブ;
						}
						if (lv.bs["5"].Pars.Values.First().ToPar().HitColor == hc)
						{
							ip.TextIm = GameText.痛みを与えるための道具;
						}
						if (lv.bs["6"].Pars.Values.First().ToPar().HitColor == hc)
						{
							ip.TextIm = GameText.緊張を解きほぐすために利用する;
						}
						if (lv.bs["7"].Pars.Values.First().ToPar().HitColor == hc)
						{
							ip.TextIm = GameText.陰毛を剃ることが出来る;
						}
						if (lv.bs["8"].Pars.Values.First().ToPar().HitColor == hc)
						{
							ip.TextIm = GameText.吸着振動するキャップ;
						}
						if (lv.bs["9"].Pars.Values.First().ToPar().HitColor == hc)
						{
							ip.TextIm = GameText.刺激の弱いバイブの一種;
						}
						if (lv.bs["10"].Pars.Values.First().ToPar().HitColor == hc)
						{
							ip.TextIm = GameText.アナルの調教に適した道具;
						}
						if (lv.bs["11"].Pars.Values.First().ToPar().HitColor == hc)
						{
							ip.TextIm = GameText.奴隷の視界を遮るための道具;
						}
						if (lv.bs["12"].Pars.Values.First().ToPar().HitColor == hc)
						{
							ip.TextIm = GameText.奴隷の口をふさぐための道具;
						}
						if (lv.bs["13"].Pars.Values.First().ToPar().HitColor == hc)
						{
							ip.TextIm = GameText.写真を撮影することが出来る;
						}
						if (lv.bs["14"].Pars.Values.First().ToPar().HitColor == hc)
						{
							ip.TextIm = GameText.フロアを増設し収容できる奴隷の数を増やす;
						}
						Player説明(ref hc, subinfo);
					}
					ip.Move(ref hc);
				}
			}
		};
		mod.Leave = delegate
		{
			if (!processing)
			{
				if (SDShow)
				{
					SaveData.Leave();
				}
				else if (!ip.選択肢表示)
				{
					dbs.Leave();
					bs.Leave();
					lv.Leave();
				}
			}
		};
		mod.Wheel = delegate
		{
		};
		mod.Setting = delegate
		{
			if (Med.Modeb != "PlayerInformation")
			{
				ip.UpdateSub2();
				ip.MaiShow = true;
				ip.Mai.Feed.Dra = false;
				ip.Mai2Show = false;
				ip.SubShow = true;
				ip.Sub2Show = true;
				lv.bs["0"].Dra = !Sta.GameData.PurchasedTools[0];
				lv.bs["1"].Dra = !Sta.GameData.PurchasedTools[1];
				lv.bs["2"].Dra = !Sta.GameData.PurchasedTools[2];
				lv.bs["3"].Dra = !Sta.GameData.PurchasedTools[3];
				lv.bs["4"].Dra = !Sta.GameData.PurchasedTools[4];
				lv.bs["5"].Dra = !Sta.GameData.PurchasedTools[5];
				lv.bs["6"].Dra = !Sta.GameData.PurchasedTools[6];
				lv.bs["7"].Dra = !Sta.GameData.PurchasedTools[7];
				lv.bs["8"].Dra = !Sta.GameData.PurchasedTools[8];
				lv.bs["9"].Dra = !Sta.GameData.PurchasedTools[9];
				lv.bs["10"].Dra = !Sta.GameData.PurchasedTools[10];
				lv.bs["11"].Dra = !Sta.GameData.PurchasedTools[11];
				lv.bs["12"].Dra = !Sta.GameData.PurchasedTools[12];
				lv.bs["13"].Dra = !Sta.GameData.PurchasedTools[13];
				lv.bs["14"].Dra = Sta.GameData.フロア数 < 9;
				if (Sta.GameData.PurchasedTools.All((bool e) => e) && Sta.GameData.フロア数 == 9)
				{
					ip.TextIm = GameText.売り切れです;
				}
				else
				{
					ip.TextIm = " ";
				}
				subinfo();
			}
		};
		DrawToolShop = delegate(Are a, FPS FPS)
		{
			Med.GH.Clear(Col.Transparent);
			if (a.GH != null)
			{
				a.GH.Clear(Col.Transparent);
			}
			a.Draw(OfficeBackground);
			lv.Draw(a);
			bs.Draw(a);
			dbs.Draw(a);
			ip.Draw(a, FPS);
			if (SDShow)
			{
				SaveData.Draw(a);
			}
			Med.Draw(DrawBuffer);
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, DrawToolShop);
		};
		mod.Dispose = delegate
		{
			lv.Dispose();
			bs.Dispose();
		};
		return mod;
	}

	public static Module StartOfDay(Med Med)
	{
		Module obj = new Module
		{
			Down = delegate
			{
				Sta.GameData.時間進行();
				if (日利益額 != 0 || 日利子額 != 0)
				{
					if (日利益額 != 0)
					{
						Sta.GameData.所持金 = Sta.GameData.所持金.加算(日利益額);
					}
					if (日利子額 != 0)
					{
						Sta.GameData.借金 = Sta.GameData.借金.加算(日利子額);
					}
					Sounds.精算.Play();
					ip.UpdateSub2();
				}
				if (Sta.GameData.日数 >= 10)
				{
					Sta.GameData.利子 = 0.002;
				}
				Sta.GameData.需給更新();
				Med.SwitchMode("メインフォーム", DrawBuffer, メインフォーム描画);
			},
			Up = delegate
			{
			},
			Move = delegate
			{
			},
			Leave = delegate
			{
			},
			Wheel = delegate
			{
			},
			Setting = delegate
			{
				ip.UpdateSub2();
				ip.MaiShow = true;
				ip.Mai.Feed.Dra = true;
				ip.Mai2Show = true;
				ip.SubShow = true;
				ip.Sub2Show = true;
				while (dayp)
				{
					Application.DoEvents();
				}
				ip.Mai2Im = (from e in 日終了ログa
					where !string.IsNullOrWhiteSpace(e)
					select e.Substring(0, e.Length - 2)).Join("\r\n") + ((労働利益 != 0) ? ("\r\n" + GameText.労働利益 + " + " + 労働利益.ToString("#,0")) : "");
				ip.TextIm = ((日利益額 != 0) ? (GameText.利益 + " + " + 日利益額.ToString("#,0") + "\r\n") : "") + ((日利子額 != 0) ? (GameText.利子 + " + " + 日利子額.ToString("#,0") + "\r\n") : "") + ">> Next days.";
				if (TrainingTarget != null && Sta.GameData.TrainingTarget != null)
				{
					対象状態初期化();
					妊娠状態反映();
				}
				si.Set(bre: false);
			}
		};
		日数進行描画 = delegate(Are a, FPS FPS)
		{
			if (TrainingTarget != null)
			{
				TrainingTarget.Mots.Drive(FPS);
			}
			Med.GH.Clear(Col.Transparent);
			if (a.GH != null)
			{
				a.GH.Clear(Col.Transparent);
			}
			a.Draw(BlackBackground);
			ip.Draw(a, FPS);
			Med.Draw(a);
		};
		obj.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, 日数進行描画);
		};
		obj.Dispose = delegate
		{
		};
		return obj;
	}

	public static Module PlayerInformation(Med Med)
	{
		Module mod = new Module();
		double num = 0.2;
		double num2 = 0.039;
		double num3 = 0.15;
		ParT parT = new ParT();
		parT.Font = new Font("MS Gothic", 0.1f);
		parT.PositionBase = DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + 0.72));
		parT.Text = GameText.完了;
		parT.FontSize = 0.15;
		parT.SizeBase = 0.05;
		parT.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT.OP.ScalingY(parT.OP.GetCenter(), 0.47);
		parT.Closed = true;
		parT.TextColor = Col.White;
		parT.BrushColor = Color.FromArgb(160, Col.Black);
		parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT.HitColor = Med.GetUniqueColor();
		parT.StringFormat.Alignment = StringAlignment.Center;
		parT.StringFormat.LineAlignment = StringAlignment.Center;
		But1 完了 = new But1(parT, delegate
		{
			Sta.GameData.配色 = new 主人公配色(Sta.GameData.色);
			Player.UI.ハンド右.再配色(Sta.GameData.配色);
			Player.UI.ハンド左.再配色(Sta.GameData.配色);
			Player.UI.ペニス.再配色(Sta.GameData.配色);
			Player.UI.マウス.再配色(Sta.GameData.配色);
			Sta.GameData.プレーヤー = Generator.プレーヤー();
			Sounds.完了.Play();
			if (start)
			{
				start = false;
				Med.SwitchMode("OP0", DrawBuffer, DrawOP0);
			}
			else
			{
				switch (Med.Modeb)
				{
				case "メインフォーム":
					Med.SwitchMode("メインフォーム", DrawBuffer, メインフォーム描画);
					break;
				case "対象":
					Med.SwitchMode("対象", DrawBuffer, 対象描画);
					break;
				case "Blessing":
					Med.SwitchMode("Blessing", DrawBuffer, DrawBlessing);
					break;
				case "Office":
					Med.SwitchMode("Office", DrawBuffer, DrawOffice);
					break;
				case "Debt":
					Med.SwitchMode("Debt", DrawBuffer, DrawDebt);
					break;
				case "SlaveShop":
					Med.SwitchMode("SlaveShop", DrawBuffer, DrawSlaveShop);
					break;
				case "ToolShop":
					Med.SwitchMode("ToolShop", DrawBuffer, DrawToolShop);
					break;
				}
			}
		});
		Labs ls = new Labs(Med, DrawBuffer);
		ls.Add("ラベル0", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 - 0.1)), 0.1, 2.5, new Font("MS Gothic", 1f), 0.085, " ", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		ls.Add("ラベル1", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 0.0 + 0.005)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, GameText.肌の色, Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		ls.Add("ラベル2", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 0.0 + 0.045)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "H:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		ls.Add("ラベル3", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 0.0 + 0.086)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "S:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		ls.Add("ラベル4", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 0.0 + 0.127)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "V:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		ls.Add("ラベル5", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 1.0 + 0.005)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, GameText.髪の色, Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		ls.Add("ラベル6", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 1.0 + 0.045)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "H:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		ls.Add("ラベル7", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 1.0 + 0.086)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "S:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		ls.Add("ラベル8", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 1.0 + 0.127)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "V:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		ls.Add("ラベル9", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 2.0 + 0.005)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, GameText.瞳の色, Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		ls.Add("ラベル10", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 2.0 + 0.045)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "H:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		ls.Add("ラベル11", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 2.0 + 0.086)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "S:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		ls.Add("ラベル12", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 2.0 + 0.127)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "V:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		ls.Add("ラベル13", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 3.0 + 0.005)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, GameText.体格, Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		ls.Add("ラベル14", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 3.0 + 0.045)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "H:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		ls.Add("ラベル15", DrawBuffer.GetPosition(new Vector2D(num2 + 0.19, num3 + num * 3.0 + 0.086)), 0.1, 1.0, new Font("MS Gothic", 1f), 0.085, "W:", Col.White, Col.Black, ip.MaiB.BrushColor, Col.Black, Input: false);
		Gau H肌 = new Gau("H肌", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 0.0 + 0.06)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, DrawBuffer.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
		H肌.Gauge.PenColor = Col.White;
		H肌.Frame1.PenColor = Col.White;
		H肌.Knob.PenColor = Col.White;
		H肌.Knob.HitColor = Med.GetUniqueColor();
		Gau S肌 = new Gau("S肌", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 0.0 + 0.1)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, DrawBuffer.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
		S肌.Gauge.PenColor = Col.White;
		S肌.Frame1.PenColor = Col.White;
		S肌.Knob.PenColor = Col.White;
		S肌.Knob.HitColor = Med.GetUniqueColor();
		Gau V肌 = new Gau("V肌", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 0.0 + 0.14)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, DrawBuffer.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
		V肌.Gauge.PenColor = Col.White;
		V肌.Frame1.PenColor = Col.White;
		V肌.Knob.PenColor = Col.White;
		V肌.Knob.HitColor = Med.GetUniqueColor();
		Gau H髪 = new Gau("H髪", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 1.0 + 0.06)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, DrawBuffer.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
		H髪.Gauge.PenColor = Col.White;
		H髪.Frame1.PenColor = Col.White;
		H髪.Knob.PenColor = Col.White;
		H髪.Knob.HitColor = Med.GetUniqueColor();
		Gau S髪 = new Gau("S髪", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 1.0 + 0.1)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, DrawBuffer.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
		S髪.Gauge.PenColor = Col.White;
		S髪.Frame1.PenColor = Col.White;
		S髪.Knob.PenColor = Col.White;
		S髪.Knob.HitColor = Med.GetUniqueColor();
		Gau V髪 = new Gau("V髪", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 1.0 + 0.14)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, DrawBuffer.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
		V髪.Gauge.PenColor = Col.White;
		V髪.Frame1.PenColor = Col.White;
		V髪.Knob.PenColor = Col.White;
		V髪.Knob.HitColor = Med.GetUniqueColor();
		Gau H瞳 = new Gau("H瞳", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 2.0 + 0.06)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, DrawBuffer.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
		H瞳.Gauge.PenColor = Col.White;
		H瞳.Frame1.PenColor = Col.White;
		H瞳.Knob.PenColor = Col.White;
		H瞳.Knob.HitColor = Med.GetUniqueColor();
		Gau S瞳 = new Gau("S瞳", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 2.0 + 0.1)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, DrawBuffer.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
		S瞳.Gauge.PenColor = Col.White;
		S瞳.Frame1.PenColor = Col.White;
		S瞳.Knob.PenColor = Col.White;
		S瞳.Knob.HitColor = Med.GetUniqueColor();
		Gau V瞳 = new Gau("V瞳", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 2.0 + 0.14)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, DrawBuffer.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
		V瞳.Gauge.PenColor = Col.White;
		V瞳.Frame1.PenColor = Col.White;
		V瞳.Knob.PenColor = Col.White;
		V瞳.Knob.HitColor = Med.GetUniqueColor();
		Gau 身長 = new Gau("身長", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 3.0 + 0.06)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, DrawBuffer.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
		身長.Gauge.PenColor = Col.White;
		身長.Frame1.PenColor = Col.White;
		身長.Knob.PenColor = Col.White;
		身長.Knob.HitColor = Med.GetUniqueColor();
		Gau 体重 = new Gau("体重", DrawBuffer.GetPosition(new Vector2D(num2 + 0.532, num3 + num * 3.0 + 0.1)), DrawBuffer.Size, 0.6, 0.03, 0.02, Open.Rig, Range.ZeroOne, DrawBuffer.DisUnit, Color.Transparent, Color.Transparent, Color.Transparent, Color.Transparent, Col.Black, Knob: true);
		体重.Gauge.PenColor = Col.White;
		体重.Frame1.PenColor = Col.White;
		体重.Knob.PenColor = Col.White;
		体重.Knob.HitColor = Med.GetUniqueColor();
		Hsv hsv = HSV.ToHSV(ref Sta.GameData.色.肌色);
		H肌.Value = (double)hsv.H / 360.0;
		S肌.Value = (double)hsv.S / 255.0;
		V肌.Value = (double)hsv.V / 255.0;
		H肌.Base.BrushColor = Sta.GameData.色.肌色;
		S肌.Base.BrushColor = Sta.GameData.色.肌色;
		V肌.Base.BrushColor = Sta.GameData.色.肌色;
		ls["ラベル2"].Text = "H:" + hsv.H;
		ls["ラベル3"].Text = "S:" + hsv.S;
		ls["ラベル4"].Text = "V:" + hsv.V;
		hsv = HSV.ToHSV(ref Sta.GameData.色.髪色);
		H髪.Value = (double)hsv.H / 360.0;
		S髪.Value = (double)hsv.S / 255.0;
		V髪.Value = (double)hsv.V / 255.0;
		H髪.Base.BrushColor = Sta.GameData.色.髪色;
		S髪.Base.BrushColor = Sta.GameData.色.髪色;
		V髪.Base.BrushColor = Sta.GameData.色.髪色;
		ls["ラベル6"].Text = "H:" + hsv.H;
		ls["ラベル7"].Text = "S:" + hsv.S;
		ls["ラベル8"].Text = "V:" + hsv.V;
		hsv = HSV.ToHSV(ref Sta.GameData.色.瞳色);
		H瞳.Value = (double)hsv.H / 360.0;
		S瞳.Value = (double)hsv.S / 255.0;
		V瞳.Value = (double)hsv.V / 255.0;
		H瞳.Base.BrushColor = Sta.GameData.色.瞳色;
		S瞳.Base.BrushColor = Sta.GameData.色.瞳色;
		V瞳.Base.BrushColor = Sta.GameData.色.瞳色;
		ls["ラベル10"].Text = "H:" + hsv.H;
		ls["ラベル11"].Text = "S:" + hsv.S;
		ls["ラベル12"].Text = "V:" + hsv.V;
		身長.Value = Sta.GameData.身長;
		体重.Value = Sta.GameData.体重;
		ls["ラベル14"].Text = "H:" + $"{身長.Value:0.00}";
		ls["ラベル15"].Text = "W:" + $"{体重.Value:0.00}";
		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (mb == MouseButtons.Left)
			{
				H肌.Down(ref hc, ref cp);
				S肌.Down(ref hc, ref cp);
				V肌.Down(ref hc, ref cp);
				H髪.Down(ref hc, ref cp);
				S髪.Down(ref hc, ref cp);
				V髪.Down(ref hc, ref cp);
				H瞳.Down(ref hc, ref cp);
				S瞳.Down(ref hc, ref cp);
				V瞳.Down(ref hc, ref cp);
				身長.Down(ref hc, ref cp);
				体重.Down(ref hc, ref cp);
				完了.Down(ref hc);
			}
		};
		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (mb == MouseButtons.Left)
			{
				H肌.Up();
				S肌.Up();
				V肌.Up();
				H髪.Up();
				S髪.Up();
				V髪.Up();
				H瞳.Up();
				S瞳.Up();
				V瞳.Up();
				身長.Up();
				体重.Up();
				完了.Up(ref hc);
			}
		};
		int h;
		int s;
		int v;
		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			if (mb == MouseButtons.Left)
			{
				H肌.Move(ref cp);
				S肌.Move(ref cp);
				V肌.Move(ref cp);
				h = (int)(360.0 * H肌.Value);
				s = (int)(255.0 * S肌.Value);
				v = (int)(255.0 * V肌.Value);
				HSV.ToRGB(h, s, v, out Sta.GameData.色.肌色);
				H肌.Base.BrushColor = Sta.GameData.色.肌色;
				S肌.Base.BrushColor = Sta.GameData.色.肌色;
				V肌.Base.BrushColor = Sta.GameData.色.肌色;
				ls["ラベル2"].Text = "H:" + h;
				ls["ラベル3"].Text = "S:" + s;
				ls["ラベル4"].Text = "V:" + v;
				H髪.Move(ref cp);
				S髪.Move(ref cp);
				V髪.Move(ref cp);
				h = (int)(360.0 * H髪.Value);
				s = (int)(255.0 * S髪.Value);
				v = (int)(255.0 * V髪.Value);
				HSV.ToRGB(h, s, v, out Sta.GameData.色.髪色);
				H髪.Base.BrushColor = Sta.GameData.色.髪色;
				S髪.Base.BrushColor = Sta.GameData.色.髪色;
				V髪.Base.BrushColor = Sta.GameData.色.髪色;
				ls["ラベル6"].Text = "H:" + h;
				ls["ラベル7"].Text = "S:" + s;
				ls["ラベル8"].Text = "V:" + v;
				H瞳.Move(ref cp);
				S瞳.Move(ref cp);
				V瞳.Move(ref cp);
				h = (int)(360.0 * H瞳.Value);
				s = (int)(255.0 * S瞳.Value);
				v = (int)(255.0 * V瞳.Value);
				HSV.ToRGB(h, s, v, out Sta.GameData.色.瞳色);
				H瞳.Base.BrushColor = Sta.GameData.色.瞳色;
				S瞳.Base.BrushColor = Sta.GameData.色.瞳色;
				V瞳.Base.BrushColor = Sta.GameData.色.瞳色;
				ls["ラベル10"].Text = "H:" + h;
				ls["ラベル11"].Text = "S:" + s;
				ls["ラベル12"].Text = "V:" + v;
				身長.Move(ref cp);
				体重.Move(ref cp);
				ls["ラベル14"].Text = "H:" + $"{身長.Value:0.00}";
				ls["ラベル15"].Text = "W:" + $"{体重.Value:0.00}";
			}
			完了.Move(ref hc);
		};
		mod.Leave = delegate
		{
			H肌.Leave();
			S肌.Leave();
			V肌.Leave();
			H髪.Leave();
			S髪.Leave();
			V髪.Leave();
			H瞳.Leave();
			S瞳.Leave();
			V瞳.Leave();
			身長.Leave();
			体重.Leave();
			完了.Leave();
		};
		mod.Wheel = delegate
		{
		};
		mod.Setting = delegate
		{
			ls["ラベル0"].Text = GameText.プレイヤーの遺伝情報を設定してください + (start ? ("(" + GameText.後から変更できます + ")") : "");
			hsv = HSV.ToHSV(ref Sta.GameData.色.肌色);
			H肌.Value = (double)hsv.H / 360.0;
			S肌.Value = (double)hsv.S / 255.0;
			V肌.Value = (double)hsv.V / 255.0;
			H肌.Base.BrushColor = Sta.GameData.色.肌色;
			S肌.Base.BrushColor = Sta.GameData.色.肌色;
			V肌.Base.BrushColor = Sta.GameData.色.肌色;
			ls["ラベル2"].Text = "H:" + hsv.H;
			ls["ラベル3"].Text = "S:" + hsv.S;
			ls["ラベル4"].Text = "V:" + hsv.V;
			hsv = HSV.ToHSV(ref Sta.GameData.色.髪色);
			H髪.Value = (double)hsv.H / 360.0;
			S髪.Value = (double)hsv.S / 255.0;
			V髪.Value = (double)hsv.V / 255.0;
			H髪.Base.BrushColor = Sta.GameData.色.髪色;
			S髪.Base.BrushColor = Sta.GameData.色.髪色;
			V髪.Base.BrushColor = Sta.GameData.色.髪色;
			ls["ラベル6"].Text = "H:" + hsv.H;
			ls["ラベル7"].Text = "S:" + hsv.S;
			ls["ラベル8"].Text = "V:" + hsv.V;
			hsv = HSV.ToHSV(ref Sta.GameData.色.瞳色);
			H瞳.Value = (double)hsv.H / 360.0;
			S瞳.Value = (double)hsv.S / 255.0;
			V瞳.Value = (double)hsv.V / 255.0;
			H瞳.Base.BrushColor = Sta.GameData.色.瞳色;
			S瞳.Base.BrushColor = Sta.GameData.色.瞳色;
			V瞳.Base.BrushColor = Sta.GameData.色.瞳色;
			ls["ラベル10"].Text = "H:" + hsv.H;
			ls["ラベル11"].Text = "S:" + hsv.S;
			ls["ラベル12"].Text = "V:" + hsv.V;
			身長.Value = Sta.GameData.身長;
			体重.Value = Sta.GameData.体重;
			ls["ラベル14"].Text = "H:" + $"{身長.Value:0.00}";
			ls["ラベル15"].Text = "W:" + $"{体重.Value:0.00}";
		};
		PlayerInformationSliders = delegate(Are a, FPS FPS)
		{
			Med.GH.Clear(Col.Transparent);
			if (a.GH != null)
			{
				a.GH.Clear(Col.Transparent);
			}
			a.Draw(BlackBackground);
			ls.Draw(a);
			a.Draw(H肌.Pars);
			a.Draw(S肌.Pars);
			a.Draw(V肌.Pars);
			a.Draw(H髪.Pars);
			a.Draw(S髪.Pars);
			a.Draw(V髪.Pars);
			a.Draw(H瞳.Pars);
			a.Draw(S瞳.Pars);
			a.Draw(V瞳.Pars);
			a.Draw(身長.Pars);
			a.Draw(体重.Pars);
			完了.Draw(a);
			Med.Draw(a);
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, PlayerInformationSliders);
		};
		mod.Dispose = delegate
		{
			ls.Dispose();
			H肌.Dispose();
			S肌.Dispose();
			V肌.Dispose();
			H髪.Dispose();
			S髪.Dispose();
			V髪.Dispose();
			H瞳.Dispose();
			S瞳.Dispose();
			V瞳.Dispose();
			身長.Dispose();
			体重.Dispose();
			完了.Dispose();
		};
		return mod;
	}

	public static Module OP0(Med Med)
	{
		Module mod = new Module();
		int i = 0;
		int wi = 0;
		string[] tsp = new string[4]
		{
			GameText.点12,
			GameText.点9,
			GameText.点6,
			GameText.点3
		};
		string[] sub = new string[4]
		{
			"",
			GameText.闇が揺れる,
			GameText.身体が現る,
			GameText.意識が宿る
		};
		mod.Down = delegate
		{
			//TODO uncomment
			//if (!ip.Mai.IsPlaying && !ip.Sub.IsPlaying && wi == i)
			{
				i++;
				wi = i;
				if (i < tsp.Length)
				{
					ip.Text = tsp[i];
					ip.SubInfo = sub[i];
				}
				else
				{
					Med.SwitchMode("OP1", DrawBuffer, DrawOP1);
				}
			}
		};
		mod.Up = delegate
		{
		};
		mod.Move = delegate
		{
		};
		mod.Leave = delegate
		{
		};
		mod.Wheel = delegate
		{
		};
		mod.Setting = delegate
		{
			ip.UpdateSub2();
			ip.MaiShow = true;
			ip.Mai.Feed.Dra = true;
			ip.Mai2Show = false;
			ip.SubShow = true;
			ip.Sub2Show = true;
			Sounds.OPBGM.Stop();
			i = 0;
			wi = 0;
			ip.Text = tsp[i];
			ip.SubInfo = sub[i];
		};
		DrawOP0 = delegate(Are a, FPS FPS)
		{
			if (a.GH != null)
			{
				a.GH.Clear(Col.Transparent);
			}
			a.Draw(BlackBackground);
			dbs.Draw(a);
			ip.Draw(a, FPS);
			Med.Draw(a);
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, DrawOP0);
		};
		mod.Dispose = delegate
		{
		};
		return mod;
	}

	public static Module OP1(Med Med)
	{
		Module mod = new Module();
		int i = 0;
		int wi = 0;
		Action[] sfc = new Action[15]
		{
			delegate
			{
				Viola.表情_基本0();
			},
			delegate
			{
				Viola.表情_基本1();
			},
			delegate
			{
				Viola.表情_困り顔0();
			},
			delegate
			{
				Viola.表情_困り顔1();
			},
			delegate
			{
				Viola.表情_不敵0();
			},
			delegate
			{
				Viola.表情_基本1();
			},
			delegate
			{
				Viola.表情_不敵1眉上();
			},
			delegate
			{
				Viola.表情_基本1();
			},
			delegate
			{
				Viola.表情_不敵0();
			},
			delegate
			{
				Viola.表情_不敵0眉上();
			},
			delegate
			{
				Viola.表情_基本1眉上();
			},
			delegate
			{
			},
			delegate
			{
				Viola.表情_卑屈();
			},
			delegate
			{
				Viola.表情_基本1();
			},
			delegate
			{
				Viola.表情_不敵0();
			}
		};
		string[] tsc = new string[15]
		{
			GameText.点6,
			GameText.お目覚めかしら,
			GameText.話の途中で眠ってしまうんですもの,
			GameText.よっぽど疲れていたのね,
			GameText.点3,
			GameText.誰って顔をしているわね,
			GameText.うふふ良いわ + "\r\n" + GameText.もう一度自己紹介をしてあげる,
			GameText.私の名前はヴィオランテ + "  \r\n" + GameText.ここではヴィオラと呼ばれているわ,
			GameText.点3,
			GameText.それでは話の続きをしましょうか,
			GameText.今あなたには全部で + 5000000000uL.ToString("#,0") + GameText.の借金が課せられているわ,
			"",
			GameText.でも心配しないで,
			GameText.そんなあなたにぴったりなお仕事を紹介してあげる,
			GameText.とっても儲かる素敵なお仕事をね
		};
		string[] tsp = new string[15]
		{
			GameText.点6ハテナ,
			GameText.点6,
			GameText.点9,
			GameText.点6,
			GameText.点9,
			GameText.点6,
			GameText.点6,
			GameText.点6,
			GameText.点6,
			GameText.点6,
			GameText.点6,
			"",
			GameText.点9,
			GameText.点6,
			GameText.点9
		};
		string[] sub = new string[15]
		{
			GameText.光が射す,
			GameText.目が眩む,
			GameText.見慣れぬ女が立っている,
			GameText.良い香りがする,
			GameText.空気はぬるい,
			GameText.女は語る,
			GameText.女は続ける,
			GameText.女は名乗る,
			GameText.違和感を覚える,
			GameText.知らない世界だ,
			"",
			"",
			GameText.なんて日だ,
			GameText.話が進む,
			GameText.事は運ぶ
		};
		Action<Tex> d = delegate
		{
			ip.SubInfo = GameText.安い額ではない;
			ip.選択yAct = delegate
			{
				Sounds.操作.Play();
				ヴィオラ吹出し.Tex.Done = delegate
				{
					Sounds.精算.Play();
					Sta.GameData.借金 = 5000000000uL;
					ip.UpdateSub2();
				};
				Viola.表情_不敵0眉上();
				ヴィオラ吹出し.Text = GameText.うふふそうよね;
				ip.Text = GameText.点6;
				ip.SubInfo = GameText.身に覚えはない;
				if (i == 10)
				{
					i++;
					wi = i;
				}
				if (wi == 10)
				{
					wi++;
				}
				ip.選択肢表示 = false;
			};
			ip.選択nAct = delegate
			{
				Sounds.操作.Play();
				ヴィオラ吹出し.Tex.Done = delegate
				{
					Sounds.精算.Play();
					Sta.GameData.借金 = 5000000000uL;
					ip.UpdateSub2();
				};
				Viola.表情_素1();
				ヴィオラ吹出し.Text = GameText.関係ないわここに書いてあるもの + "\r\n" + GameText.ほらねそうでしょう;
				ip.Text = GameText.点6;
				ip.SubInfo = GameText.身に覚えはない;
				if (i == 10)
				{
					i++;
					wi = i;
				}
				if (wi == 10)
				{
					wi++;
				}
				ip.選択肢表示 = false;
			};
			ip.選択肢表示 = true;
		};
		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.DownB(ref hc);
			if (!ヴィオラ吹出し.Tex.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying)
			{
				if (wi == i && i != 10 && ヴィオラ吹出し.Tex.Done == null)
				{
					i++;
					wi = i;
					if (i < tsp.Length)
					{
						if (i == 10)
						{
							ヴィオラ吹出し.Tex.Done = d;
						}
						else
						{
							ヴィオラ吹出し.Tex.Done = null;
						}
						if (i != 11)
						{
							sfc[i]();
							ヴィオラ吹出し.Text = tsc[i];
							ip.Text = tsp[i];
							ip.SubInfo = sub[i];
						}
					}
					else
					{
						Med.SwitchMode("説明", DrawBuffer, 説明描画);
					}
				}
				else if (wi == 12 && i == 11)
				{
					i += 2;
					wi = i;
					sfc[i]();
					ヴィオラ吹出し.Text = tsc[i];
					ip.Text = tsp[i];
					ip.SubInfo = sub[i];
				}
			}
		};
		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.Up(ref hc);
		};
		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.Move(ref hc);
		};
		mod.Leave = delegate
		{
		};
		mod.Wheel = delegate
		{
		};
		mod.Setting = delegate
		{
			ip.Mai.Feed.Dra = false;
			Sounds.日常BGM.Play();
			Sta.GameData.ヴィオラ = new Unit();
			Sta.GameData.ヴィオラ.SetViola(Med, DrawBuffer);
			Viola = new Cha(Med, DrawBuffer, Sta.GameData.ヴィオラ.ChaD);
			Viola.Set衣装(Sta.GameData.ヴィオラ.着衣);
			ヴィオラ吹出し.接続(Viola.Bod.頭.口_接続点);
			i = 0;
			wi = 0;
			sfc[i]();
			ヴィオラ吹出し.Text = tsc[i];
			ip.Text = tsp[i];
			ip.SubInfo = sub[i];

			Viola.両目_見つめ();
			Viola.Set基本姿勢();

			//I added this 
			Viola.Bod.拘束具_表示 = false;
			Viola.Set拘束姿勢();
        };
		DrawOP1 = delegate(Are a, FPS FPS)
		{
			System.Diagnostics.Debug.Print("Draw OP1\n");
			a.Draw(OfficeBackground);
			//Viola.SetInitialAngle();
			Viola.Draw(a, FPS);
			ヴィオラ吹出し.Draw(a, FPS);
			dbs.Draw(a);
			ip.Draw(a, FPS);
			Med.Draw(a);
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, DrawOP1);
		};
		mod.Dispose = delegate
		{
		};
		return mod;
	}

	public static Module 説明(Med Med)
	{
		Module mod = new Module();
		int i = 0;
		int wi = 0;
		Action[] sfc = new Action[11]
		{
			delegate
			{
				Viola.表情_基本0();
			},
			delegate
			{
				Viola.表情_基本1();
			},
			delegate
			{
				Viola.表情_不敵1();
			},
			delegate
			{
				Viola.表情_基本0();
			},
			delegate
			{
				Viola.表情_基本1();
			},
			delegate
			{
				Viola.表情_不敵0眉上();
			},
			delegate
			{
				Viola.表情_基本1眉上();
			},
			delegate
			{
				Viola.表情_不敵0眉上();
			},
			delegate
			{
				Viola.表情_基本1();
			},
			delegate
			{
				Viola.表情_不敵1眉上();
			},
			delegate
			{
				Viola.表情_不敵0眉上();
			}
		};
		string[] tsc = new string[11]
		{
			GameText.点3,
			GameText.ここは地下牢よ,
			GameText.あなたにはこの場所で調教師として働いてもらうわ,
			GameText.仕事の流れを説明するわね,
			GameText.まず事務所で奴隷を仕入れて頂戴,
			GameText.仕入れたら性奴として使えるようにあなたが躾けるの,
			GameText.躾けた分だけ上乗せされた値段で売れるようになるわ,
			GameText.それと従順になった奴隷に働いてもらうのもいいわね + "   \r\n" + GameText.あと奴隷の転売という手もあるわ,
			GameText.まぁこんなところね簡単でしょう,
			GameText.それでは頑張って頂戴,
			GameText.期待しているわ
		};
		string[] tsp = new string[11]
		{
			GameText.点6,
			GameText.点3,
			GameText.点6,
			GameText.点6,
			GameText.点6,
			GameText.点6,
			GameText.点6,
			GameText.点6,
			GameText.点6,
			GameText.点6,
			GameText.点6
		};
		string[] sub = new string[11]
		{
			GameText.冷めた空気が舞い上がる,
			GameText.ヴィオラは語る,
			GameText.仕事が決まる,
			GameText.説明が始まる,
			GameText.ヴィオラは語る,
			GameText.ヴィオラは続ける,
			GameText.説明が続く,
			GameText.説明は続く,
			GameText.説明が終わる,
			GameText.奴隷母体の名の下に,
			GameText.物語は動き出す
		};
		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.DownB(ref hc);
			if (!ヴィオラ吹出し.Tex.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying && wi == i)
			{
				i++;
				wi = i;
				if (i < tsp.Length)
				{
					sfc[i]();
					ヴィオラ吹出し.Text = tsc[i];
					ip.Text = tsp[i];
					ip.SubInfo = sub[i];
				}
				else
				{
					Med.SwitchMode("メインフォーム", DrawBuffer, メインフォーム描画);
				}
			}
		};
		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.Up(ref hc);
		};
		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.Move(ref hc);
		};
		mod.Leave = delegate
		{
		};
		mod.Wheel = delegate
		{
		};
		mod.Setting = delegate
		{
			Viola.両目_見つめ();
			Viola.表情_基本1();
			Viola.Set基本姿勢();
			i = 0;
			wi = 0;
			sfc[i]();
			ヴィオラ吹出し.Text = tsc[i];
			ip.Text = tsp[i];
			ip.SubInfo = sub[i];
		};
		説明描画 = delegate(Are a, FPS FPS)
		{
			if (a.GH != null)
			{
				a.GH.Clear(Col.Transparent);
			}
			a.Draw(BasementBackground);
			Viola.Draw(a, FPS);
			ヴィオラ吹出し.Draw(a, FPS);
			dbs.Draw(a);
			ip.Draw(a, FPS);
			Med.Draw(a);
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, 説明描画);
		};
		mod.Dispose = delegate
		{
		};
		return mod;
	}

	public static Module 初事務所(Med Med)
	{
		Module mod = new Module();
		int i = 0;
		int wi = 0;
		Action[] sfc = new Action[11]
		{
			delegate
			{
				Viola.表情_基本0();
			},
			delegate
			{
				Viola.表情_不敵1();
			},
			delegate
			{
			},
			delegate
			{
				Viola.表情_不敵1眉上();
			},
			delegate
			{
				Viola.表情_基本1();
			},
			delegate
			{
				Viola.表情_不敵1眉上();
			},
			delegate
			{
				Viola.表情_基本0();
			},
			delegate
			{
			},
			delegate
			{
				Viola.表情_不敵0眉上();
			},
			delegate
			{
				Viola.表情_基本0();
			},
			delegate
			{
				Viola.表情_不敵0();
			}
		};
		string[] tsc = new string[11]
		{
			GameText.点6,
			GameText.どうかしたの,
			"",
			GameText.お金がなければ借りればいいじゃない,
			GameText.借金と返済は事務所つまりここで出来るわ,
			GameText.借金には1日 + Sta.GameData.利子 * 100.0 + GameText.の利子がつくわよ + "  \r\n" + GameText.良心的よねうふふ,
			GameText.そうそう言い忘れていたけどあなたは調教師として必要な拘束術が使えるようになっているはずよ,
			"",
			GameText.点6,
			GameText.私からは以上よ,
			GameText.仕事に戻ると良いわ
		};
		string[] tsp = new string[11]
		{
			GameText.点6,
			GameText.点3,
			"",
			GameText.点6,
			GameText.点6,
			GameText.点6,
			GameText.点6,
			"",
			GameText.点6,
			GameText.点6,
			GameText.点6
		};
		string[] sub = new string[11]
		{
			GameText.ヴィオラは佇む,
			GameText.ヴィオラは尋ねる,
			"",
			GameText.ヴィオラは返す,
			GameText.説明が始まる,
			GameText.ヴィオラは語る,
			GameText.話は続く,
			"",
			GameText.危険な女だ,
			GameText.話が終わる,
			GameText.話は終わる
		};
		Action<Tex> d1 = delegate
		{
			ip.Mai.Done = delegate
			{
				ip.選択yAct = delegate
				{
					Sounds.操作.Play();
					Viola.表情_不敵0眉上();
					ヴィオラ吹出し.Text = GameText.うふふそうよね;
					ip.Text = GameText.点6;
					ip.SubInfo = GameText.あなたは答える;
					if (i == 1)
					{
						i++;
						wi = i;
					}
					if (wi == 1)
					{
						wi++;
					}
					ip.選択肢表示 = false;
				};
				ip.選択nAct = delegate
				{
					Sounds.操作.Play();
					Viola.表情_困り顔1();
					ヴィオラ吹出し.Text = GameText.嘘おっしゃい無いのは分かっているわ;
					ip.Text = GameText.点6;
					ip.SubInfo = GameText.あなたは答える;
					if (i == 1)
					{
						i++;
						wi = i;
					}
					if (wi == 1)
					{
						wi++;
					}
					ip.選択肢表示 = false;
				};
				ip.選択肢表示 = true;
			};
			ip.Text = GameText.金が無い;
		};
		Action<Tex> d2 = delegate
		{
			ip.Mai.Done = delegate
			{
				ip.選択yAct = delegate
				{
					Sounds.操作.Play();
					ip.Sub.Done = delegate
					{
						Viola.Bod.拘束具_表示 = false;
						Viola.両翼獣_全開(0);
						Viola.両触手_S字(0);
						Viola.両触手_S字(1);
						Viola.SetSymmetry();
						Viola.Bod.Update();
						Viola.表情_不敵1();
						Sounds.弾け.Play();
						ip.Text = GameText.エクス2;
						ip.SubInfo = GameText.あなたの鎖は弾け飛ぶ;
						ヴィオラ吹出し.Text = GameText.あらあら今ので利子が上がってしまったわうふふ;
						ヴィオラ吹出し.Tex.Feed.Dra = true;
						Sta.GameData.利子 *= 2.0;
					};
					ヴィオラ吹出し.Tex.Feed.Dra = false;
					Viola.Bod.拘束具_表示 = true;
					Viola.両翼獣_閉じ(0);
					Viola.両触手_S字(0);
					Viola.両触手_S字(1);
					Viola.SetSymmetry();
					Viola.Bod.Update();
					Viola.表情_素0眉上();
					Sounds.変更1.Play();
					ヴィオラ吹出し.Text = GameText.っ点3;
					ip.Text = GameText.エクス1;
					ip.SubInfo = GameText.鋼の鎖がヴィオラを縛る + "        ";
					if (i == 6)
					{
						i++;
						wi = i;
					}
					if (wi == 6)
					{
						wi++;
					}
					ip.選択肢表示 = false;
				};
				ip.選択nAct = delegate
				{
					Sounds.操作.Play();
					Viola.表情_不敵0();
					ヴィオラ吹出し.Text = GameText.点3うふふ + "\r\n" + GameText.慎重なのは良いことよ;
					ip.Text = GameText.点6;
					ip.SubInfo = GameText.ヴィオラは微笑む;
					if (i == 6)
					{
						i++;
						wi = i;
					}
					if (wi == 6)
					{
						wi++;
					}
					ip.選択肢表示 = false;
				};
				ip.選択肢表示 = true;
			};
			ip.Text = GameText.ヴィオラで試す;
		};
		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.DownB(ref hc);
			if (!ヴィオラ吹出し.Tex.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying)
			{
				if (wi == i && i != 1 && i != 6 && ヴィオラ吹出し.Tex.Done == null)
				{
					i++;
					wi = i;
					if (i < tsp.Length)
					{
						if (i == 8)
						{
							Viola.両翼獣_半開き(0);
							Viola.Bod.Update();
						}
						if (i == 1)
						{
							ヴィオラ吹出し.Tex.Done = d1;
						}
						else if (i == 6)
						{
							ヴィオラ吹出し.Tex.Done = d2;
						}
						else
						{
							ヴィオラ吹出し.Tex.Done = null;
						}
						if (i != 2 && i != 7)
						{
							sfc[i]();
							ヴィオラ吹出し.Text = tsc[i];
							ip.Text = tsp[i];
							ip.SubInfo = sub[i];
						}
					}
					else
					{
						Sta.GameData.初事務所フラグ = false;
						Med.SwitchMode("Office", DrawBuffer, DrawOffice);
					}
				}
				else if ((wi == 3 && i == 2) || (wi == 8 && i == 7))
				{
					i += 2;
					wi = i;
					sfc[i]();
					ヴィオラ吹出し.Text = tsc[i];
					ip.Text = tsp[i];
					ip.SubInfo = sub[i];
				}
			}
		};
		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.Up(ref hc);
		};
		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.Move(ref hc);
		};
		mod.Leave = delegate
		{
		};
		mod.Wheel = delegate
		{
		};
		mod.Setting = delegate
		{
			ip.UpdateSub2();
			ip.MaiShow = true;
			ip.Mai.Feed.Dra = false;
			ip.Mai2Show = false;
			ip.SubShow = true;
			ip.Sub2Show = true;
			ヴィオラ吹出し.Tex.Feed.Dra = true;
			Viola.両目_見つめ();
			Viola.表情_基本0();
			Viola.Set基本姿勢();
			i = 0;
			wi = 0;
			sfc[i]();
			ヴィオラ吹出し.Text = tsc[i];
			ip.Text = tsp[i];
			ip.SubInfo = sub[i];
		};
		初事務所描画 = delegate(Are a, FPS FPS)
		{
			if (a.GH != null)
			{
				a.GH.Clear(Col.Transparent);
			}
			a.Draw(OfficeBackground);
			Viola.Draw(a, FPS);
			ヴィオラ吹出し.Draw(a, FPS);
			dbs.Draw(a);
			ip.Draw(a, FPS);
			Med.Draw(a);
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, 初事務所描画);
		};
		mod.Dispose = delegate
		{
		};
		return mod;
	}

	public static Module RepaymentEvent1(Med Med)
	{
		Module mod = new Module();
		int i = 0;
		int wi = 0;
		Action[] sfc = new Action[3]
		{
			delegate
			{
				Viola.表情_不敵0();
			},
			delegate
			{
				Viola.表情_基本1();
			},
			delegate
			{
				Viola.表情_不敵1();
			}
		};
		string[] tsc = new string[3]
		{
			GameText.仕事には慣れたかしら,
			GameText.あなたが頑張っているおかげで奴隷の仕入元のハンターと話がまとまったの,
			GameText.今後もこの調子で頑張って頂戴
		};
		string[] tsp = new string[3]
		{
			GameText.点3,
			GameText.点6,
			GameText.点6
		};
		string[] sub = new string[3]
		{
			GameText.ヴィオラが尋ねる,
			GameText.ヴィオラは語る,
			GameText.話が終わる
		};
		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.DownB(ref hc);
			if (!ヴィオラ吹出し.Tex.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying && wi == i)
			{
				i++;
				wi = i;
				if (i < tsp.Length)
				{
					sfc[i]();
					ヴィオラ吹出し.Text = tsc[i];
					ip.Text = tsp[i];
					ip.SubInfo = sub[i];
				}
				else
				{
					Med.SwitchMode("Office", DrawBuffer, DrawOffice);
				}
			}
		};
		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.Up(ref hc);
		};
		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.Move(ref hc);
		};
		mod.Leave = delegate
		{
		};
		mod.Wheel = delegate
		{
		};
		mod.Setting = delegate
		{
			ip.UpdateSub2();
			ip.MaiShow = true;
			ip.Mai.Feed.Dra = false;
			ip.Mai2Show = false;
			ip.SubShow = true;
			ip.Sub2Show = true;
			ヴィオラ吹出し.Tex.Feed.Dra = true;
			Viola.両目_見つめ();
			Viola.表情_基本0();
			Viola.Set基本姿勢();
			i = 0;
			wi = 0;
			sfc[i]();
			ヴィオラ吹出し.Text = tsc[i];
			ip.Text = tsp[i];
			ip.SubInfo = sub[i];
		};
		返済イベント描画 = delegate(Are a, FPS FPS)
		{
			if (a.GH != null)
			{
				a.GH.Clear(Col.Transparent);
			}
			a.Draw(OfficeBackground);
			Viola.Draw(a, FPS);
			ヴィオラ吹出し.Draw(a, FPS);
			dbs.Draw(a);
			ip.Draw(a, FPS);
			Med.Draw(a);
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, 返済イベント描画);
		};
		mod.Dispose = delegate
		{
		};
		return mod;
	}

	public static Module RepaymentEvent2(Med Med)
	{
		Module mod = new Module();
		int i = 0;
		int wi = 0;
		Action[] sfc = new Action[3]
		{
			delegate
			{
				Viola.表情_不敵1();
			},
			delegate
			{
				Viola.表情_不敵0眉上();
			},
			delegate
			{
				Viola.表情_基本0();
			}
		};
		string[] tsc = new string[3]
		{
			GameText.うふふ + "\r\n" + GameText.なかなか順調のようね,
			GameText.そろそろ奴隷の身嗜みを考えてみてもいいんじゃないかしら,
			GameText.身嗜みに手を加えられるように手配しておくわね
		};
		string[] tsp = new string[3]
		{
			GameText.点3,
			GameText.点6,
			GameText.点3
		};
		string[] sub = new string[3]
		{
			GameText.ヴィオラが語る,
			GameText.ヴィオラは語る,
			GameText.事は運ぶ
		};
		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.DownB(ref hc);
			if (!ヴィオラ吹出し.Tex.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying && wi == i)
			{
				i++;
				wi = i;
				if (i < tsp.Length)
				{
					sfc[i]();
					ヴィオラ吹出し.Text = tsc[i];
					ip.Text = tsp[i];
					ip.SubInfo = sub[i];
				}
				else
				{
					Med.SwitchMode("Office", DrawBuffer, DrawOffice);
				}
			}
		};
		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.Up(ref hc);
		};
		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.Move(ref hc);
		};
		mod.Leave = delegate
		{
		};
		mod.Wheel = delegate
		{
		};
		mod.Setting = delegate
		{
			ip.UpdateSub2();
			ip.MaiShow = true;
			ip.Mai.Feed.Dra = false;
			ip.Mai2Show = false;
			ip.SubShow = true;
			ip.Sub2Show = true;
			ヴィオラ吹出し.Tex.Feed.Dra = true;
			Viola.両目_見つめ();
			Viola.表情_基本0();
			Viola.Set基本姿勢();
			i = 0;
			wi = 0;
			sfc[i]();
			ヴィオラ吹出し.Text = tsc[i];
			ip.Text = tsp[i];
			ip.SubInfo = sub[i];
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, 返済イベント描画);
		};
		mod.Dispose = delegate
		{
		};
		return mod;
	}

	public static Module RepaymentEvent3(Med Med)
	{
		Module mod = new Module();
		bool yes = false;
		int i = 0;
		int wi = 0;
		Action[] sfc = new Action[4]
		{
			delegate
			{
				Viola.表情_不敵1眉上();
			},
			delegate
			{
				Viola.表情_不敵0();
			},
			delegate
			{
				Viola.表情_基本0();
			},
			delegate
			{
			}
		};
		Action[] sfcy = new Action[5]
		{
			delegate
			{
				Viola.表情_素0();
			},
			delegate
			{
				Viola.表情_不敵1眉上();
			},
			delegate
			{
				Viola.表情_困り顔0();
			},
			delegate
			{
				Viola.表情_困り顔1();
			},
			delegate
			{
				Viola.表情_不敵0眉上();
			}
		};
		Action[] sfcn = new Action[5]
		{
			delegate
			{
				Viola.表情_不敵1();
			},
			delegate
			{
				Viola.表情_不敵0眉上();
			},
			delegate
			{
				Viola.表情_基本0();
			},
			delegate
			{
				Viola.表情_不敵1();
			},
			delegate
			{
				Viola.表情_不敵0();
			}
		};
		string[] tsc = new string[4]
		{
			GameText.うふふ + "\r\n" + GameText.まさか本当に完済してくれるとは思わなかったわ,
			GameText.もうあなたがここに縛られている理由は何もないわね,
			GameText.だから好きになさい,
			""
		};
		string[] tscy = new string[5]
		{
			GameText.点6,
			GameText.そんなこと言わずにもっとゆっくりしていくといいわ,
			GameText.別にあなたを帰すときのことを考えてなかったとかそういうことではないのよ,
			GameText.点6,
			GameText.とにかくご苦労様 + "\r\n" + GameText.そしてありがとう調教師
		};
		string[] tscn = new string[5]
		{
			GameText.あなたを手放すなんてありえないわ,
			GameText.なんてったって + 5000000000uL.ToString("#,0") + GameText.もの稼ぎ手ですもの,
			GameText.点3,
			GameText.点6,
			GameText.お勤めご苦労様 + "\r\n" + GameText.そしてありがとう調教師
		};
		string[] tsp = new string[9]
		{
			GameText.点3,
			GameText.点6,
			GameText.点6,
			"",
			GameText.点6,
			GameText.点6,
			GameText.点6,
			GameText.点6,
			GameText.点6
		};
		string[] sub = new string[4]
		{
			GameText.ヴィオラは語る,
			GameText.ヴィオラは続ける,
			GameText.あなたは自由だ,
			""
		};
		string[] suby = new string[5]
		{
			GameText.ヴィオラは黙る,
			GameText.ヴィオラは慌てる,
			GameText.弁解は続く,
			GameText.危険な女だ,
			GameText.物語は終わった
		};
		string[] subn = new string[5]
		{
			GameText.ヴィオラは語る,
			GameText.ヴィオラは続ける,
			GameText.余韻が響く,
			GameText.余韻に浸る,
			GameText.物語は終わった
		};
		Action<Tex> d1 = delegate
		{
			ip.Mai.Done = delegate
			{
				ip.選択yAct = delegate
				{
					yes = true;
					Sounds.操作.Play();
					Viola.表情_基本1眉上();
					ヴィオラ吹出し.Text = GameText.え;
					ip.Text = GameText.点6;
					ip.SubInfo = GameText.あなたは答える;
					if (i == 2)
					{
						i++;
						wi = i;
					}
					if (wi == 2)
					{
						wi++;
					}
					ip.選択肢表示 = false;
				};
				ip.選択nAct = delegate
				{
					yes = false;
					Sounds.操作.Play();
					Viola.表情_不敵0();
					ヴィオラ吹出し.Text = GameText.うふふそうよね;
					ip.Text = GameText.点6;
					ip.SubInfo = GameText.あなたは答える;
					if (i == 2)
					{
						i++;
						wi = i;
					}
					if (wi == 2)
					{
						wi++;
					}
					ip.選択肢表示 = false;
				};
				ip.選択肢表示 = true;
			};
			ip.Text = GameText.家に帰る;
		};
		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.DownB(ref hc);
			if (!ヴィオラ吹出し.Tex.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying)
			{
				if (wi == i && i != 2 && ヴィオラ吹出し.Tex.Done == null)
				{
					i++;
					wi = i;
					if (i < tsp.Length)
					{
						if (i == 2)
						{
							ヴィオラ吹出し.Tex.Done = d1;
						}
						else
						{
							ヴィオラ吹出し.Tex.Done = null;
						}
						if (i != 3)
						{
							if (i < 4)
							{
								sfc[i]();
								ヴィオラ吹出し.Text = tsc[i];
								ip.SubInfo = sub[i];
							}
							else if (yes)
							{
								sfcy[i - 4]();
								ヴィオラ吹出し.Text = tscy[i - 4];
								ip.SubInfo = suby[i - 4];
							}
							else
							{
								sfcn[i - 4]();
								ヴィオラ吹出し.Text = tscn[i - 4];
								ip.SubInfo = subn[i - 4];
							}
							ip.Text = tsp[i];
						}
					}
					else
					{
						Sta.GameData.初事務所フラグ = false;
						Med.SwitchMode("Office", DrawBuffer, DrawOffice);
					}
				}
				else if (wi == 4 && i == 3)
				{
					i += 2;
					wi = i;
					if (i < 4)
					{
						sfc[i]();
						ヴィオラ吹出し.Text = tsc[i];
						ip.SubInfo = sub[i];
					}
					else if (yes)
					{
						sfcy[i - 4]();
						ヴィオラ吹出し.Text = tscy[i - 4];
						ip.SubInfo = suby[i - 4];
					}
					else
					{
						sfcn[i - 4]();
						ヴィオラ吹出し.Text = tscn[i - 4];
						ip.SubInfo = subn[i - 4];
					}
					ip.Text = tsp[i];
				}
			}
		};
		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.Up(ref hc);
		};
		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.Move(ref hc);
		};
		mod.Leave = delegate
		{
		};
		mod.Wheel = delegate
		{
		};
		mod.Setting = delegate
		{
			ip.UpdateSub2();
			ip.MaiShow = true;
			ip.Mai.Feed.Dra = false;
			ip.Mai2Show = false;
			ip.SubShow = true;
			ip.Sub2Show = true;
			ヴィオラ吹出し.Tex.Feed.Dra = true;
			Viola.両目_見つめ();
			Viola.表情_基本0();
			Viola.Set基本姿勢();
			i = 0;
			wi = 0;
			sfc[i]();
			ヴィオラ吹出し.Text = tsc[i];
			ip.Text = tsp[i];
			ip.SubInfo = sub[i];
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, 返済イベント描画);
		};
		mod.Dispose = delegate
		{
		};
		return mod;
	}

	public static Module ViolaBlessing(Med Med)
	{
		Module mod = new Module();
		int i = 0;
		int wi = 0;
		Action[] sfc = new Action[4]
		{
			delegate
			{
				Viola.表情_基本0();
			},
			delegate
			{
				Viola.表情_不敵1眉上();
			},
			delegate
			{
				Viola.表情_不敵0();
			},
			delegate
			{
				Sounds.祝福.Play();
				Viola.表情_不敵0眉上();
			}
		};
		string[] tsc = new string[4]
		{
			GameText.祝福してほしいの,
			GameText.そうよね + "\r\n" + GameText.あなたはがんばったもの,
			GameText.ちゅっ,
			GameText.うふふ
		};
		string[] tsp = new string[4]
		{
			GameText.点3,
			GameText.点6,
			GameText.エクス1,
			GameText.点3
		};
		string[] sub = new string[4]
		{
			GameText.ヴィオラに頼む,
			GameText.ヴィオラは微笑む,
			GameText.キスされる,
			GameText.ヴィオラに祝福された
		};
		mod.Down = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.DownB(ref hc);
			if (!ヴィオラ吹出し.Tex.IsPlaying && !ip.Mai.IsPlaying && !ip.Sub.IsPlaying && wi == i)
			{
				i++;
				wi = i;
				if (i < tsp.Length)
				{
					sfc[i]();
					ヴィオラ吹出し.Text = tsc[i];
					ip.Text = tsp[i];
					ip.SubInfo = sub[i];
				}
				else
				{
					Med.SwitchMode("Office", DrawBuffer, DrawOffice);
				}
			}
		};
		mod.Up = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.Up(ref hc);
		};
		mod.Move = delegate(MouseButtons mb, Vector2D cp, Color hc)
		{
			ip.Move(ref hc);
		};
		mod.Leave = delegate
		{
		};
		mod.Wheel = delegate
		{
		};
		mod.Setting = delegate
		{
			ip.UpdateSub2();
			ip.MaiShow = true;
			ip.Mai.Feed.Dra = false;
			ip.Mai2Show = false;
			ip.SubShow = true;
			ip.Sub2Show = true;
			ヴィオラ吹出し.Tex.Feed.Dra = true;
			Viola.両目_見つめ();
			Viola.表情_基本0();
			Viola.Set基本姿勢();
			i = 0;
			wi = 0;
			sfc[i]();
			ヴィオラ吹出し.Text = tsc[i];
			ip.Text = tsp[i];
			ip.SubInfo = sub[i];
			Sta.GameData.祝福 = Sta.GameData.ヴィオラ;
		};
		mod.Draw = delegate(FPS FPS)
		{
			SwitchMode(Med, DrawBuffer, FPS, 返済イベント描画);
		};
		mod.Dispose = delegate
		{
		};
		return mod;
	}

	static Mods()
	{
		TrainingTarget = null;
		mv = new MotV(0.0, 1.0)
		{
			BaseSpeed = 2.0
		};
		sta = false;
		v = 0.0;
		単位返済段階額 = 1666666666uL;
		DemandMax = 8.0;
		SDShow = false;
		save = false;
		title = false;
		processing = false;
		日終了ログa = new string[MaxRoomNumber];
		労働利益 = 0uL;
		日利益額 = 0uL;
		日利子額 = 0uL;
		dayp = false;
		cts = new CancellationTokenSource();
		start = false;
	}

	public static void SensesButton()
	{
		double x = 0.6;
		double y = 0.9075;
		if (Program.biggerWindow)
		{
			x = 0.695;
			y = 0.932;
		}
		ParT parT = new ParT();
		parT.Font = new Font("MS Gothic", 0.1f);
		parT.PositionBase = DrawBuffer.GetPosition(x, y);
		parT.Text = "Senses";
		parT.FontSize = 0.14;
		parT.SizeBase = 0.05;
		parT.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
		parT.Closed = true;
		parT.TextColor = Col.White;
		parT.BrushColor = Color.FromArgb(160, Col.Black);
		parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT.StringFormat.Alignment = StringAlignment.Center;
		parT.StringFormat.LineAlignment = StringAlignment.Center;
		dbs.Add("Senses", new But1(parT, delegate
		{
			Sounds.操作.Play();
			Sta.ShowSenses = !Sta.ShowSenses;
		}));
	}

	public static void ToJsonButton(Med med)
	{
		double x = 0.6;
		double y = 0.9075;
		if (Program.biggerWindow)
		{
			x = 0.695;
			y = 0.932;
			if (Sta.SensesButton)
			{
				x = 0.62;
			}
		}
		if (!Program.biggerWindow && Sta.SensesButton)
		{
			x = 0.5;
		}
		ParT parT = new ParT();
		parT.Font = new Font("MS Gothic", 0.1f);
		parT.PositionBase = DrawBuffer.GetPosition(x, y);
		parT.Text = "SaveJSON";
		parT.FontSize = 0.14;
		parT.SizeBase = 0.05;
		parT.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
		parT.Closed = true;
		parT.TextColor = Col.White;
		parT.BrushColor = Color.FromArgb(160, Col.Black);
		parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT.StringFormat.Alignment = StringAlignment.Center;
		parT.StringFormat.LineAlignment = StringAlignment.Center;
		dbs.Add("SaveJSON", new But1(parT, delegate
		{
			Sounds.操作.Play();
			SaveData.bs["0"].Dra = false;
			save = true;
			SetJSLlv(med);
			Color HitColor = Col.Empty;
			SaveData.Move(ref HitColor);
			SDShow = true;
			ip.SubInfoIm = "RCl:" + GameText.戻る;
		}));
	}

	public static void UnJsonButton(Med med)
	{
		double y = 0.9075;
		double x = 0.5;
		if (Program.biggerWindow)
		{
			x = 0.62;
			y = 0.932;
			if (Sta.SensesButton)
			{
				x = 0.545;
			}
		}
		if (!Program.biggerWindow && Sta.SensesButton)
		{
			x = 0.4;
		}
		ParT parT = new ParT();
		parT.Font = new Font("MS Gothic", 0.1f);
		parT.PositionBase = DrawBuffer.GetPosition(x, y);
		parT.Text = "LoadJSON";
		parT.FontSize = 0.14;
		parT.SizeBase = 0.05;
		parT.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
		parT.Closed = true;
		parT.TextColor = Col.White;
		parT.BrushColor = Color.FromArgb(160, Col.Black);
		parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT.StringFormat.Alignment = StringAlignment.Center;
		parT.StringFormat.LineAlignment = StringAlignment.Center;
		dbs.Add("LoadJSON", new But1(parT, delegate
		{
			Sounds.操作.Play();
			SaveData.bs["0"].Dra = true;
			save = false;
			title = false;
			SetJSLlv(med);
			Color HitColor = Col.Empty;
			SaveData.Move(ref HitColor);
			SDShow = true;
			ip.SubInfoIm = "RCl:" + GameText.戻る;
		}));
	}

	public static void NewButtons(Med med)
	{
		if (Sta.SensesButton)
		{
			SensesButton();
		}
		if (Sta.JsonButton)
		{
			ToJsonButton(med);
			UnJsonButton(med);
		}
	}

	public static void SetJSLlv(Med med)
	{
		SaveData.Acts = jsllv(med);
	}

	private static IEnumerable<TA> jsllv(Med med)
	{
		int k = 0;
		string[] array = Sta.JSDPaths();
		foreach (string text in array)
		{
			string path = text;
			int i = k;
			bool f = path == null;
			yield return new TA(f ? (i + ": No data") : Path.GetFileNameWithoutExtension(path).Replace("：", ":").Replace("_", "/"), delegate
			{
				if (!processing)
				{
					Sounds.操作.Play();
					if (save)
					{
						processing = true;
						JsonSave(path, i, med);
					}
					else if (!f)
					{
						processing = true;
						JsonLoad(path, i, med);
					}
				}
			});
			k++;
		}
	}

	private static void JsonSave(string Path, int i, Med med)
	{
		ip.SubInfoIm = GameText.セーブ中です + "\r\n" + GameText.しばらくお待ちください;

		if (Path != null)
		{
            System.IO.File.Delete(Path);
		}
		Sta.GDSaveJson(i);
		SetJSLlv(med);
		SDShow = false;
		ip.SubInfoIm = i + ": " + Sta.GameData.GetSaveDateString() + "\r\n" + GameText.セーブしました;
		processing = false;
		Sounds.完了.Play();
	}

	private static void JsonLoad(string Path, int i, Med med)
	{
		cts.Cancel();
		ip.SubInfoIm = GameText.ロード中です + "\r\n" + GameText.しばらくお待ちください;
		
		Sta.DontScar = true;
		if (Sta.TranslateJson)
		{
			string text = Sta.CurrentDirectory + "temp.json";
			string contents = Sta.Translate(Path, 1);
			File.WriteAllText(text, contents);
			Sta.GameData = Ser.UnJson<GameState>(text);
            System.IO.File.Delete(text);
		}
		else
		{
			Sta.GameData = Ser.UnJson<GameState>(Path);
		}
		Sta.DontScar = false;
		Cha d = Viola;
		Viola = new Cha(med, DrawBuffer, Sta.GameData.ヴィオラ.ChaD);
		Viola.Set衣装(Sta.GameData.ヴィオラ.着衣);
		ヴィオラ吹出し.接続(Viola.Bod.頭.口_接続点);
		med.InvokeL(delegate
		{
			Initialize();
			if (d != null)
			{
				d.Dispose();
			}
			if (TrainingTarget != null)
			{
				TrainingTarget.Dispose();
				TrainingTarget = null;
			}
			SDShow = false;
			if (title)
			{
				med.SwitchMode("メインフォーム", DrawBuffer, メインフォーム描画);
			}
			else
			{
				med.Mode = "メインフォーム";
				ip.SubInfoIm = i + ": " + Sta.GameData.GetSaveDateString() + "\r\n" + GameText.ロードしました;
			}
			processing = false;
			SetDemandMaximum();
			if (Sta.GameData.Slaves.Length < MaxRoomNumber)
			{
				Unit[] array = new Unit[MaxRoomNumber];
				Array.Copy(Sta.GameData.Slaves, array, Sta.GameData.Slaves.Length);
				Sta.GameData.Slaves = array;
			}
			Sta.GameData.Gen = new Generator[9];
			Sta.GameData.GenInstance();
			Sounds.完了.Play();
		});
	}

	public static void MoveRoomDown()
	{
		if (Sta.GameData.TrainingTarget != null)
		{
			int num = int.Parse(Sta.GameData.TrainingTarget.Number) - 1;
			if (Sta.GameData.Slaves[num + 1] != null)
			{
				Unit unit = Sta.GameData.Slaves[num];
				Unit unit2 = Sta.GameData.Slaves[num + 1];
				int[] array = new int[3]
				{
					int.Parse(unit.Number),
					unit.階層位置,
					unit.RoomNumber
				};
				unit.Number = unit2.Number;
				unit.階層位置 = unit2.階層位置;
				unit.RoomNumber = unit2.RoomNumber;
				unit2.Number = array[0].ToString().PadLeft(3, '0');
				unit2.階層位置 = array[1];
				unit2.RoomNumber = array[2];
				Sta.GameData.Slaves[num] = unit2;
				Sta.GameData.Slaves[num + 1] = unit;
				Sta.GameData.TrainingTarget = Sta.GameData.Slaves[num + 1];
			}
		}
	}

	public static void MoveRoomUp()
	{
		if (Sta.GameData.TrainingTarget != null)
		{
			int num = int.Parse(Sta.GameData.TrainingTarget.Number) - 1;
			if (num != 0 && Sta.GameData.Slaves[num - 1] != null)
			{
				Unit unit = Sta.GameData.Slaves[num];
				Unit unit2 = Sta.GameData.Slaves[num - 1];
				int[] array = new int[3]
				{
					int.Parse(unit.Number),
					unit.階層位置,
					unit.RoomNumber
				};
				unit.Number = unit2.Number;
				unit.階層位置 = unit2.階層位置;
				unit.RoomNumber = unit2.RoomNumber;
				unit2.Number = array[0].ToString().PadLeft(3, '0');
				unit2.階層位置 = array[1];
				unit2.RoomNumber = array[2];
				Sta.GameData.Slaves[num] = unit2;
				Sta.GameData.Slaves[num - 1] = unit;
				Sta.GameData.TrainingTarget = Sta.GameData.Slaves[num - 1];
			}
		}
	}

	public static void MoveFloorDown()
	{
		if (Sta.GameData.TrainingTarget == null)
		{
			return;
		}
		for (int i = 0; i < 15; i++)
		{
			int num = int.Parse(Sta.GameData.TrainingTarget.Number) - 1;
			if (Sta.GameData.Slaves[num + 1] == null)
			{
				break;
			}
			Unit unit = Sta.GameData.Slaves[num];
			Unit unit2 = Sta.GameData.Slaves[num + 1];
			int[] array = new int[3]
			{
				int.Parse(unit.Number),
				unit.階層位置,
				unit.RoomNumber
			};
			unit.Number = unit2.Number;
			unit.階層位置 = unit2.階層位置;
			unit.RoomNumber = unit2.RoomNumber;
			unit2.Number = array[0].ToString().PadLeft(3, '0');
			unit2.階層位置 = array[1];
			unit2.RoomNumber = array[2];
			Sta.GameData.Slaves[num] = unit2;
			Sta.GameData.Slaves[num + 1] = unit;
			Sta.GameData.TrainingTarget = Sta.GameData.Slaves[num + 1];
		}
	}

	public static void MoveFloorUp()
	{
		if (Sta.GameData.TrainingTarget == null)
		{
			return;
		}
		for (int i = 0; i < 15; i++)
		{
			int num = int.Parse(Sta.GameData.TrainingTarget.Number) - 1;
			if (num == 0 || Sta.GameData.Slaves[num - 1] == null)
			{
				break;
			}
			Unit unit = Sta.GameData.Slaves[num];
			Unit unit2 = Sta.GameData.Slaves[num - 1];
			int[] array = new int[3]
			{
				int.Parse(unit.Number),
				unit.階層位置,
				unit.RoomNumber
			};
			unit.Number = unit2.Number;
			unit.階層位置 = unit2.階層位置;
			unit.RoomNumber = unit2.RoomNumber;
			unit2.Number = array[0].ToString().PadLeft(3, '0');
			unit2.階層位置 = array[1];
			unit2.RoomNumber = array[2];
			Sta.GameData.Slaves[num] = unit2;
			Sta.GameData.Slaves[num - 1] = unit;
			Sta.GameData.TrainingTarget = Sta.GameData.Slaves[num - 1];
		}
	}

	public static But MoveRoomDownButton(Module mod)
	{
		double x = 0.195;
		double y = 0.1625;
		if (Program.biggerWindow)
		{
			x = 0.146;
			y = 0.14;
		}
		ParT parT = new ParT();
		parT.Font = new Font("MS Gothic", 0.1f);
		parT.PositionBase = DrawBuffer.GetPosition(x, y);
		parT.Text = "Room ▼";
		parT.FontSize = 0.14;
		parT.SizeBase = 0.05;
		parT.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
		parT.Closed = true;
		parT.TextColor = Col.White;
		parT.BrushColor = Color.FromArgb(160, Col.Black);
		parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT.StringFormat.Alignment = StringAlignment.Center;
		parT.StringFormat.LineAlignment = StringAlignment.Center;
		return new But1(parT, delegate
		{
			Sounds.操作.Play();
			MoveRoomDown();
			mod.Setting();
			if (Sta.AlwaysUseName)
			{
				npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "\r\n" + Sta.GameData.TrainingTarget.Name;
			}
			else
			{
				npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + (Sta.GameData.TrainingTarget.Trained ? ("\r\n" + Sta.GameData.TrainingTarget.Name) : ("\r\n" + Sta.GameData.TrainingTarget.Race));
			}
		});
	}

	public static But MoveRoomUpButton(Module mod)
	{
		double x = 0.195;
		double y = 0.12;
		if (Program.biggerWindow)
		{
			x = 0.146;
			y = 0.11;
		}
		ParT parT = new ParT();
		parT.Font = new Font("MS Gothic", 0.1f);
		parT.PositionBase = DrawBuffer.GetPosition(x, y);
		parT.Text = "Room ▲";
		parT.FontSize = 0.14;
		parT.SizeBase = 0.05;
		parT.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
		parT.Closed = true;
		parT.TextColor = Col.White;
		parT.BrushColor = Color.FromArgb(160, Col.Black);
		parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT.StringFormat.Alignment = StringAlignment.Center;
		parT.StringFormat.LineAlignment = StringAlignment.Center;
		return new But1(parT, delegate
		{
			Sounds.操作.Play();
			MoveRoomUp();
			mod.Setting();
			if (Sta.AlwaysUseName)
			{
				npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "\r\n" + Sta.GameData.TrainingTarget.Name;
			}
			else
			{
				npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + (Sta.GameData.TrainingTarget.Trained ? ("\r\n" + Sta.GameData.TrainingTarget.Name) : ("\r\n" + Sta.GameData.TrainingTarget.Race));
			}
		});
	}

	public static But MoveFloorDownButton(Module mod)
	{
		double x = 0.195;
		double y = 0.2475;
		if (Program.biggerWindow)
		{
			x = 0.146;
			y = 0.2;
		}
		ParT parT = new ParT();
		parT.Font = new Font("MS Gothic", 0.1f);
		parT.PositionBase = DrawBuffer.GetPosition(x, y);
		parT.Text = "Floor ▼";
		parT.FontSize = 0.14;
		parT.SizeBase = 0.05;
		parT.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
		parT.Closed = true;
		parT.TextColor = Col.White;
		parT.BrushColor = Color.FromArgb(160, Col.Black);
		parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT.StringFormat.Alignment = StringAlignment.Center;
		parT.StringFormat.LineAlignment = StringAlignment.Center;
		return new But1(parT, delegate
		{
			Sounds.操作.Play();
			MoveFloorDown();
			mod.Setting();
			if (Sta.AlwaysUseName)
			{
				npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "\r\n" + Sta.GameData.TrainingTarget.Name;
			}
			else
			{
				npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + (Sta.GameData.TrainingTarget.Trained ? ("\r\n" + Sta.GameData.TrainingTarget.Name) : ("\r\n" + Sta.GameData.TrainingTarget.Race));
			}
		});
	}

	public static But MoveFloorUpButton(Module mod)
	{
		double x = 0.195;
		double y = 0.205;
		if (Program.biggerWindow)
		{
			x = 0.146;
			y = 0.17;
		}
		ParT parT = new ParT();
		parT.Font = new Font("MS Gothic", 0.1f);
		parT.PositionBase = DrawBuffer.GetPosition(x, y);
		parT.Text = "Floor ▲";
		parT.FontSize = 0.14;
		parT.SizeBase = 0.05;
		parT.OP.AddRange(new Out[1] { Shas.Get正方形() });
		parT.OP.ScalingXY(parT.OP.GetCenter(), 0.87, 0.23);
		parT.Closed = true;
		parT.TextColor = Col.White;
		parT.BrushColor = Color.FromArgb(160, Col.Black);
		parT.ShadBrush = new SolidBrush(Color.FromArgb(64, Col.Black));
		parT.StringFormat.Alignment = StringAlignment.Center;
		parT.StringFormat.LineAlignment = StringAlignment.Center;
		return new But1(parT, delegate
		{
			Sounds.操作.Play();
			MoveFloorUp();
			mod.Setting();
			if (Sta.AlwaysUseName)
			{
				npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "\r\n" + Sta.GameData.TrainingTarget.Name;
			}
			else
			{
				npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + (Sta.GameData.TrainingTarget.Trained ? ("\r\n" + Sta.GameData.TrainingTarget.Name) : ("\r\n" + Sta.GameData.TrainingTarget.Race));
			}
		});
	}

	public static void setName()
	{
		npl.Text = GameText.収容番号 + Sta.GameData.TrainingTarget.Number + "\r\n" + Sta.GameData.TrainingTarget.Name;
	}
}
