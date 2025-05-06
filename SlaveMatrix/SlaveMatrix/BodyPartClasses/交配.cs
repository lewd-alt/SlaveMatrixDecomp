using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using _2DGAMELIB;
using SlaveMatrix.GameClasses;

namespace SlaveMatrix;

public static class 交配
{
	private static HashSet<string> 頭頂 = new HashSet<string>
	{
		Sta.頭頂_宇Dt.ToString(),
		Sta.頭頂_皿Dt.ToString(),
		Sta.頭頂_天Dt.ToString()
	};

	private static HashSet<string> 額 = new HashSet<string>
	{
		Sta.角1_一Dt.ToString(),
		Sta.角1_鬼Dt.ToString(),
		Sta.角1_虫Dt.ToString()
	};

	private static HashSet<string> 側頭 = new HashSet<string>
	{
		Sta.角1_鬼Dt.ToString(),
		Sta.角2_山1Dt.ToString(),
		Sta.角2_山2Dt.ToString(),
		Sta.角2_山3Dt.ToString(),
		Sta.角2_巻Dt.ToString(),
		Sta.角2_牛1Dt.ToString(),
		Sta.角2_牛2Dt.ToString(),
		Sta.角2_牛3Dt.ToString(),
		Sta.角2_牛4Dt.ToString(),
		Sta.角2_鬼Dt.ToString(),
		Sta.角2_虫Dt.ToString(),
		Sta.触覚_線Dt.ToString(),
		Sta.触覚_節Dt.ToString(),
		Sta.触覚_甲Dt.ToString(),
		Sta.触覚_蝶Dt.ToString(),
		Sta.触覚_蛾Dt.ToString(),
		Sta.上腕_鳥Dt.ToString(),
		Sta.上腕_蝙Dt.ToString(),
		Sta.獣耳Dt.ToString(),
		Sta.植Dt.ToString()
	};

	private static HashSet<string> 触覚 = new HashSet<string>
	{
		Sta.触覚_線Dt.ToString(),
		Sta.触覚_節Dt.ToString(),
		Sta.触覚_甲Dt.ToString(),
		Sta.触覚_蝶Dt.ToString(),
		Sta.触覚_蛾Dt.ToString()
	};

	private static HashSet<string> 耳 = new HashSet<string>
	{
		Sta.耳_人Dt.ToString(),
		Sta.耳_尖Dt.ToString(),
		Sta.耳_長Dt.ToString(),
		Sta.耳_鰭Dt.ToString(),
		Sta.耳_羽Dt.ToString(),
		Sta.耳_獣Dt.ToString()
	};

	private static HashSet<string> 頬 = new HashSet<string> { Sta.虫顎Dt.ToString() };

	private static HashSet<string> 後髪 = new HashSet<string>
	{
		Sta.尾_龍Dt.ToString(),
		Sta.尾_竜Dt.ToString(),
		Sta.尾_悪Dt.ToString(),
		Sta.尾_淫Dt.ToString(),
		Sta.尾_虫Dt.ToString(),
		Sta.尾_蠍Dt.ToString(),
		Sta.尾_蛇Dt.ToString(),
		Sta.尾_腓Dt.ToString(),
		Sta.尾_根Dt.ToString(),
		Sta.節尾_曳航Dt.ToString(),
		Sta.触手_軟Dt.ToString(),
		Sta.触手_触Dt.ToString(),
		Sta.触手_蔦Dt.ToString(),
		Sta.鳳凰Dt.ToString()
	};

	private static HashSet<string> 肩人 = new HashSet<string> { Sta.肩Dt.ToString() };

	private static HashSet<string> 胸翼上人 = new HashSet<string>
	{
		Sta.前翅_甲Dt.ToString(),
		Sta.前翅_羽Dt.ToString(),
		Sta.前翅_蝶Dt.ToString(),
		Sta.前翅_草Dt.ToString(),
		Sta.後翅_甲Dt.ToString(),
		Sta.後翅_草Dt.ToString(),
		Sta.上腕_鳥Dt.ToString(),
		Sta.上腕_蝙Dt.ToString()
	};

	private static HashSet<string> 胸翼下人 = new HashSet<string>
	{
		Sta.後翅_羽Dt.ToString(),
		Sta.後翅_蝶Dt.ToString()
	};

	private static HashSet<string> 胴翼人 = new HashSet<string>
	{
		Sta.尾_蠍Dt.ToString(),
		Sta.前翅_甲Dt.ToString(),
		Sta.前翅_羽Dt.ToString(),
		Sta.前翅_蝶Dt.ToString(),
		Sta.前翅_草Dt.ToString(),
		Sta.後翅_甲Dt.ToString(),
		Sta.後翅_草Dt.ToString(),
		Sta.触肢_肢蜘Dt.ToString(),
		Sta.触肢_肢蠍Dt.ToString(),
		Sta.節足_足蜘Dt.ToString(),
		Sta.節足_足蠍Dt.ToString(),
		Sta.節足_足百Dt.ToString(),
		Sta.節尾_曳航Dt.ToString(),
		Sta.触手_軟Dt.ToString(),
		Sta.触手_触Dt.ToString(),
		Sta.触手_蔦Dt.ToString(),
		Sta.上腕_鳥Dt.ToString(),
		Sta.上腕_蝙Dt.ToString()
	};

	private static HashSet<string> 腰翼人 = new HashSet<string>
	{
		Sta.後翅_羽Dt.ToString(),
		Sta.後翅_蝶Dt.ToString(),
		Sta.触肢_肢蜘Dt.ToString(),
		Sta.触肢_肢蠍Dt.ToString(),
		Sta.節足_足蜘Dt.ToString(),
		Sta.節足_足蠍Dt.ToString(),
		Sta.節足_足百Dt.ToString(),
		Sta.節尾_曳航Dt.ToString(),
		Sta.触手_軟Dt.ToString(),
		Sta.触手_触Dt.ToString(),
		Sta.触手_蔦Dt.ToString(),
		Sta.四足脇Dt.ToString()
	};

	private static HashSet<string> 腿人 = new HashSet<string>
	{
		Sta.尾_魚Dt.ToString(),
		Sta.触手_犬Dt.ToString(),
		Sta.腿_人Dt.ToString(),
		Sta.腿_獣Dt.ToString(),
		Sta.腿_蹄Dt.ToString(),
		Sta.腿_鳥Dt.ToString(),
		Sta.腿_竜Dt.ToString()
	};

	private static HashSet<string> 肩獣 = new HashSet<string> { Sta.四足脇Dt.ToString() };

	private static HashSet<string> 胸翼上獣 = new HashSet<string>
	{
		Sta.前翅_甲Dt.ToString(),
		Sta.前翅_羽Dt.ToString(),
		Sta.前翅_蝶Dt.ToString(),
		Sta.前翅_草Dt.ToString(),
		Sta.後翅_甲Dt.ToString(),
		Sta.後翅_草Dt.ToString(),
		Sta.上腕_鳥Dt.ToString(),
		Sta.上腕_蝙Dt.ToString()
	};

	private static HashSet<string> 胸翼下獣 = new HashSet<string>
	{
		Sta.後翅_羽Dt.ToString(),
		Sta.後翅_蝶Dt.ToString()
	};

	private static HashSet<string> 胴翼獣 = new HashSet<string>();

	private static HashSet<string> 腰翼獣 = new HashSet<string>();

	private static HashSet<string> 腿獣 = new HashSet<string>
	{
		Sta.腿_獣Dt.ToString(),
		Sta.腿_蹄Dt.ToString(),
		Sta.腿_鳥Dt.ToString(),
		Sta.腿_竜Dt.ToString()
	};

	private static HashSet<string> 蛸外 = new HashSet<string>
	{
		Sta.尾_魚Dt.ToString(),
		Sta.触手_軟Dt.ToString(),
		Sta.触手_触Dt.ToString(),
		Sta.触手_犬Dt.ToString()
	};

	private static HashSet<string> 蛸内 = new HashSet<string>
	{
		Sta.尾_魚Dt.ToString(),
		Sta.節尾_曳航Dt.ToString(),
		Sta.節尾_鋏Dt.ToString(),
		Sta.触手_軟Dt.ToString(),
		Sta.触手_触Dt.ToString(),
		Sta.触手_犬Dt.ToString()
	};

	private static HashSet<string> 蜘触肢 = new HashSet<string>
	{
		Sta.触肢_肢蜘Dt.ToString(),
		Sta.触肢_肢蠍Dt.ToString(),
		Sta.節足_足蠍Dt.ToString(),
		Sta.節足_足百Dt.ToString(),
		Sta.節尾_曳航Dt.ToString(),
		Sta.節尾_鋏Dt.ToString()
	};

	private static HashSet<string> 蜘節足1 = new HashSet<string>
	{
		Sta.節足_足蜘Dt.ToString(),
		Sta.節足_足蠍Dt.ToString(),
		Sta.節足_足百Dt.ToString()
	};

	private static HashSet<string> 蜘節足2 = new HashSet<string>
	{
		Sta.節足_足蜘Dt.ToString(),
		Sta.節足_足蠍Dt.ToString(),
		Sta.節足_足百Dt.ToString()
	};

	private static HashSet<string> 蜘節足3 = new HashSet<string>
	{
		Sta.節足_足蜘Dt.ToString(),
		Sta.節足_足蠍Dt.ToString(),
		Sta.節足_足百Dt.ToString()
	};

	private static HashSet<string> 蜘節足4 = new HashSet<string>
	{
		Sta.節足_足蜘Dt.ToString(),
		Sta.節足_足蠍Dt.ToString(),
		Sta.節足_足百Dt.ToString()
	};

	private static HashSet<string> 蠍触肢 = new HashSet<string>
	{
		Sta.触肢_肢蜘Dt.ToString(),
		Sta.触肢_肢蠍Dt.ToString(),
		Sta.節足_足蜘Dt.ToString(),
		Sta.節足_足百Dt.ToString(),
		Sta.節尾_曳航Dt.ToString(),
		Sta.節尾_鋏Dt.ToString()
	};

	private static HashSet<string> 蠍節足1 = new HashSet<string>
	{
		Sta.節足_足蜘Dt.ToString(),
		Sta.節足_足蠍Dt.ToString(),
		Sta.節足_足百Dt.ToString()
	};

	private static HashSet<string> 蠍節足2 = new HashSet<string>
	{
		Sta.節足_足蜘Dt.ToString(),
		Sta.節足_足蠍Dt.ToString(),
		Sta.節足_足百Dt.ToString()
	};

	private static HashSet<string> 蠍節足3 = new HashSet<string>
	{
		Sta.節足_足蜘Dt.ToString(),
		Sta.節足_足蠍Dt.ToString(),
		Sta.節足_足百Dt.ToString()
	};

	private static HashSet<string> 蠍節足4 = new HashSet<string>
	{
		Sta.節足_足蜘Dt.ToString(),
		Sta.節足_足蠍Dt.ToString(),
		Sta.節足_足百Dt.ToString()
	};

	private static HashSet<string> 蠍櫛状板 = new HashSet<string>
	{
		Sta.触覚_蠍Dt.ToString(),
		Sta.鰭_魚Dt.ToString(),
		Sta.鰭_豚Dt.ToString(),
		Sta.鰭_鯨Dt.ToString(),
		Sta.節尾_曳航Dt.ToString()
	};

	private static HashSet<string> 植外 = new HashSet<string>
	{
		Sta.尾_猫Dt.ToString(),
		Sta.尾_悪Dt.ToString(),
		Sta.尾_淫Dt.ToString(),
		Sta.尾_根Dt.ToString(),
		Sta.節尾_曳航Dt.ToString()
	};

	private static HashSet<string> 植内 = new HashSet<string>
	{
		Sta.尾_猫Dt.ToString(),
		Sta.尾_悪Dt.ToString(),
		Sta.尾_淫Dt.ToString(),
		Sta.尾_根Dt.ToString(),
		Sta.節尾_曳航Dt.ToString()
	};

	private static HashSet<string> 魚 = new HashSet<string>
	{
		Sta.鰭_魚Dt.ToString(),
		Sta.鰭_豚Dt.ToString(),
		Sta.鰭_鯨Dt.ToString()
	};

	private static HashSet<string> 鯨 = new HashSet<string>
	{
		Sta.鰭_魚Dt.ToString(),
		Sta.鰭_豚Dt.ToString(),
		Sta.鰭_鯨Dt.ToString()
	};

	private static HashSet<string> 蛇 = new HashSet<string>
	{
		Sta.鰭_魚Dt.ToString(),
		Sta.鰭_豚Dt.ToString(),
		Sta.鰭_鯨Dt.ToString(),
		Sta.節足_足蜘Dt.ToString(),
		Sta.節足_足蠍Dt.ToString(),
		Sta.節足_足百Dt.ToString(),
		Sta.腿_竜Dt.ToString()
	};

	private static HashSet<string> 蟲 = new HashSet<string>
	{
		Sta.鰭_魚Dt.ToString(),
		Sta.鰭_豚Dt.ToString(),
		Sta.鰭_鯨Dt.ToString(),
		Sta.節足_足蜘Dt.ToString(),
		Sta.節足_足蠍Dt.ToString(),
		Sta.節足_足百Dt.ToString()
	};

	private static HashSet<string> 蟲尾 = new HashSet<string> { Sta.節足_足百Dt.ToString() };

	private static HashSet<string> 蟲尾先 = new HashSet<string>
	{
		Sta.節尾_曳航Dt.ToString(),
		Sta.節尾_鋏Dt.ToString(),
		Sta.鳳凰Dt.ToString(),
		Sta.大顎Dt.ToString()
	};

	private static HashSet<string> 触覚甲 = new HashSet<string>
	{
		Sta.触覚_線Dt.ToString(),
		Sta.触覚_節Dt.ToString(),
		Sta.触覚_甲Dt.ToString(),
		Sta.触覚_蝶Dt.ToString(),
		Sta.触覚_蛾Dt.ToString()
	};

	private static HashSet<string> 触覚虫 = new HashSet<string>
	{
		Sta.触覚_線Dt.ToString(),
		Sta.触覚_節Dt.ToString(),
		Sta.触覚_甲Dt.ToString(),
		Sta.触覚_蝶Dt.ToString(),
		Sta.触覚_蛾Dt.ToString()
	};

	private static HashSet<string> 触覚蟲 = new HashSet<string>
	{
		Sta.触覚_線Dt.ToString(),
		Sta.触覚_節Dt.ToString(),
		Sta.触覚_甲Dt.ToString(),
		Sta.触覚_蝶Dt.ToString(),
		Sta.触覚_蛾Dt.ToString()
	};

	private static HashSet<string> 背中人 = new HashSet<string>
	{
		Sta.背中_羽Dt.ToString(),
		Sta.背中_甲Dt.ToString(),
		Sta.背中_光Dt.ToString()
	};

	private static HashSet<string> 背中獣 = new HashSet<string> { Sta.背中_羽Dt.ToString() };

	private static HashSet<string> 尾人 = new HashSet<string>
	{
		Sta.尾_猫Dt.ToString(),
		Sta.尾_犬Dt.ToString(),
		Sta.尾_狐Dt.ToString(),
		Sta.尾_馬Dt.ToString(),
		Sta.尾_牛Dt.ToString(),
		Sta.尾_龍Dt.ToString(),
		Sta.尾_竜Dt.ToString(),
		Sta.尾_悪Dt.ToString(),
		Sta.尾_淫Dt.ToString(),
		Sta.尾_鳥Dt.ToString(),
		Sta.尾_虫Dt.ToString(),
		Sta.尾_蜘Dt.ToString(),
		Sta.尾_蠍Dt.ToString(),
		Sta.尾_蛇Dt.ToString(),
		Sta.尾_腓Dt.ToString(),
		Sta.尾_短Dt.ToString(),
		Sta.尾_ヘDt.ToString(),
		Sta.尾_ガDt.ToString(),
		Sta.尾_ウDt.ToString(),
		Sta.尾_魚Dt.ToString(),
		Sta.尾_鯨Dt.ToString(),
		Sta.尾_蟲Dt.ToString(),
		Sta.尾_根Dt.ToString(),
		Sta.鳳凰Dt.ToString()
	};

	private static HashSet<string> 尾獣 = new HashSet<string>
	{
		Sta.尾_猫Dt.ToString(),
		Sta.尾_犬Dt.ToString(),
		Sta.尾_狐Dt.ToString(),
		Sta.尾_馬Dt.ToString(),
		Sta.尾_牛Dt.ToString(),
		Sta.尾_龍Dt.ToString(),
		Sta.尾_竜Dt.ToString(),
		Sta.尾_悪Dt.ToString(),
		Sta.尾_淫Dt.ToString(),
		Sta.尾_鳥Dt.ToString(),
		Sta.尾_虫Dt.ToString(),
		Sta.尾_蜘Dt.ToString(),
		Sta.尾_蠍Dt.ToString(),
		Sta.尾_蛇Dt.ToString(),
		Sta.尾_腓Dt.ToString(),
		Sta.尾_短Dt.ToString(),
		Sta.尾_ヘDt.ToString(),
		Sta.尾_ガDt.ToString(),
		Sta.尾_ウDt.ToString(),
		Sta.尾_魚Dt.ToString(),
		Sta.尾_鯨Dt.ToString(),
		Sta.尾_蟲Dt.ToString(),
		Sta.尾_根Dt.ToString(),
		Sta.鳳凰Dt.ToString()
	};

	private static HashSet<string> 尾蜘 = new HashSet<string>
	{
		Sta.尾_猫Dt.ToString(),
		Sta.尾_犬Dt.ToString(),
		Sta.尾_狐Dt.ToString(),
		Sta.尾_馬Dt.ToString(),
		Sta.尾_牛Dt.ToString(),
		Sta.尾_龍Dt.ToString(),
		Sta.尾_竜Dt.ToString(),
		Sta.尾_悪Dt.ToString(),
		Sta.尾_淫Dt.ToString(),
		Sta.尾_鳥Dt.ToString(),
		Sta.尾_虫Dt.ToString(),
		Sta.尾_蜘Dt.ToString(),
		Sta.尾_蠍Dt.ToString(),
		Sta.尾_蛇Dt.ToString(),
		Sta.尾_腓Dt.ToString(),
		Sta.尾_短Dt.ToString(),
		Sta.尾_ヘDt.ToString(),
		Sta.尾_ガDt.ToString(),
		Sta.尾_ウDt.ToString(),
		Sta.尾_魚Dt.ToString(),
		Sta.尾_鯨Dt.ToString(),
		Sta.尾_蟲Dt.ToString(),
		Sta.尾_根Dt.ToString()
	};

	private static HashSet<string> 尾蠍 = new HashSet<string>
	{
		Sta.尾_猫Dt.ToString(),
		Sta.尾_犬Dt.ToString(),
		Sta.尾_狐Dt.ToString(),
		Sta.尾_馬Dt.ToString(),
		Sta.尾_牛Dt.ToString(),
		Sta.尾_龍Dt.ToString(),
		Sta.尾_竜Dt.ToString(),
		Sta.尾_悪Dt.ToString(),
		Sta.尾_淫Dt.ToString(),
		Sta.尾_鳥Dt.ToString(),
		Sta.尾_虫Dt.ToString(),
		Sta.尾_蜘Dt.ToString(),
		Sta.尾_蠍Dt.ToString(),
		Sta.尾_蛇Dt.ToString(),
		Sta.尾_腓Dt.ToString(),
		Sta.尾_短Dt.ToString(),
		Sta.尾_ヘDt.ToString(),
		Sta.尾_ガDt.ToString(),
		Sta.尾_ウDt.ToString(),
		Sta.尾_魚Dt.ToString(),
		Sta.尾_鯨Dt.ToString(),
		Sta.尾_蟲Dt.ToString(),
		Sta.尾_根Dt.ToString()
	};

	private static HashSet<string> 尾魚 = new HashSet<string>
	{
		Sta.尾_龍Dt.ToString(),
		Sta.尾_竜Dt.ToString(),
		Sta.尾_鳥Dt.ToString(),
		Sta.尾_虫Dt.ToString(),
		Sta.尾_蜘Dt.ToString(),
		Sta.尾_魚Dt.ToString(),
		Sta.尾_鯨Dt.ToString()
	};

	private static HashSet<string> 尾鯨 = new HashSet<string> { Sta.尾_鯨Dt.ToString() };

	private static HashSet<string> 尾蛇 = new HashSet<string>
	{
		Sta.尾_ヘDt.ToString(),
		Sta.尾_ガDt.ToString(),
		Sta.尾_ウDt.ToString(),
		Sta.尾_蟲Dt.ToString()
	};

	private static HashSet<string> 尾蟲 = new HashSet<string>
	{
		Sta.尾_ヘDt.ToString(),
		Sta.尾_ガDt.ToString(),
		Sta.尾_ウDt.ToString(),
		Sta.尾_蟲Dt.ToString()
	};

	private static HashSet<string> 根中 = new HashSet<string>
	{
		Sta.尾_猫Dt.ToString(),
		Sta.尾_悪Dt.ToString(),
		Sta.尾_淫Dt.ToString(),
		Sta.尾_根Dt.ToString()
	};

	private static HashSet<string> 尾先ヘ = new HashSet<string>
	{
		Sta.尾鰭_魚Dt.ToString(),
		Sta.尾鰭_鯨Dt.ToString()
	};

	private static HashSet<string> 尾先ウ = new HashSet<string>
	{
		Sta.尾鰭_魚Dt.ToString(),
		Sta.尾鰭_鯨Dt.ToString()
	};

	private static HashSet<string> 尾先魚 = new HashSet<string>
	{
		Sta.尾鰭_魚Dt.ToString(),
		Sta.尾鰭_鯨Dt.ToString()
	};

	private static HashSet<string> 尾先鯨 = new HashSet<string>
	{
		Sta.尾鰭_魚Dt.ToString(),
		Sta.尾鰭_鯨Dt.ToString()
	};

	private static HashSet<string> 頭頂後 = new HashSet<string> { Sta.頭頂後_宇Dt.ToString() };

	private static HashSet<string> 上腕人 = new HashSet<string>
	{
		Sta.鰭_魚Dt.ToString(),
		Sta.鰭_豚Dt.ToString(),
		Sta.鰭_鯨Dt.ToString(),
		Sta.触肢_肢蠍Dt.ToString(),
		Sta.上腕_人Dt.ToString(),
		Sta.上腕_鳥Dt.ToString(),
		Sta.上腕_蝙Dt.ToString()
	};

	private static HashSet<string> 上腕獣 = new HashSet<string>
	{
		Sta.触肢_肢蠍Dt.ToString(),
		Sta.上腕_獣Dt.ToString(),
		Sta.上腕_蹄Dt.ToString(),
		Sta.脚_鳥Dt.ToString(),
		Sta.脚_竜Dt.ToString()
	};

	private static HashSet<string> 下腕人 = new HashSet<string>
	{
		Sta.下腕_人Dt.ToString(),
		Sta.下腕_獣Dt.ToString()
	};

	private static HashSet<string> 下腕鳥 = new HashSet<string> { Sta.下腕_鳥Dt.ToString() };

	private static HashSet<string> 下腕蝙 = new HashSet<string> { Sta.下腕_蝙Dt.ToString() };

	private static HashSet<string> 下腕獣 = new HashSet<string> { Sta.下腕_獣Dt.ToString() };

	private static HashSet<string> 下腕蹄 = new HashSet<string> { Sta.下腕_蹄Dt.ToString() };

	private static HashSet<string> 手人 = new HashSet<string> { Sta.手_人Dt.ToString() };

	private static HashSet<string> 手鳥 = new HashSet<string> { Sta.手_鳥Dt.ToString() };

	private static HashSet<string> 手蝙 = new HashSet<string> { Sta.手_蝙Dt.ToString() };

	private static HashSet<string> 手獣 = new HashSet<string> { Sta.手_獣Dt.ToString() };

	private static HashSet<string> 手蹄 = new HashSet<string>
	{
		Sta.手_馬Dt.ToString(),
		Sta.手_牛Dt.ToString()
	};

	private static HashSet<string> 虫鎌 = new HashSet<string> { Sta.虫鎌Dt.ToString() };

	private static HashSet<string> 脚人 = new HashSet<string> { Sta.脚_人Dt.ToString() };

	private static HashSet<string> 脚獣 = new HashSet<string>
	{
		Sta.脚_獣Dt.ToString(),
		Sta.脚_蹄Dt.ToString(),
		Sta.脚_鳥Dt.ToString(),
		Sta.脚_竜Dt.ToString()
	};

	private static HashSet<string> 脚蹄 = new HashSet<string>
	{
		Sta.脚_獣Dt.ToString(),
		Sta.脚_蹄Dt.ToString(),
		Sta.脚_鳥Dt.ToString(),
		Sta.脚_竜Dt.ToString()
	};

	private static HashSet<string> 脚鳥 = new HashSet<string>
	{
		Sta.脚_獣Dt.ToString(),
		Sta.脚_蹄Dt.ToString(),
		Sta.脚_鳥Dt.ToString(),
		Sta.脚_竜Dt.ToString()
	};

	private static HashSet<string> 脚竜 = new HashSet<string>
	{
		Sta.脚_獣Dt.ToString(),
		Sta.脚_蹄Dt.ToString(),
		Sta.脚_鳥Dt.ToString(),
		Sta.脚_竜Dt.ToString()
	};

	private static HashSet<string> 足人 = new HashSet<string> { Sta.足_人Dt.ToString() };

	private static HashSet<string> 足獣 = new HashSet<string>
	{
		Sta.足_獣Dt.ToString(),
		Sta.足_馬Dt.ToString(),
		Sta.足_牛Dt.ToString(),
		Sta.足_鳥Dt.ToString(),
		Sta.足_竜Dt.ToString()
	};

	private static HashSet<string> 足蹄 = new HashSet<string>
	{
		Sta.足_獣Dt.ToString(),
		Sta.足_馬Dt.ToString(),
		Sta.足_牛Dt.ToString(),
		Sta.足_鳥Dt.ToString(),
		Sta.足_竜Dt.ToString()
	};

	private static HashSet<string> 足鳥 = new HashSet<string>
	{
		Sta.足_獣Dt.ToString(),
		Sta.足_馬Dt.ToString(),
		Sta.足_牛Dt.ToString(),
		Sta.足_鳥Dt.ToString(),
		Sta.足_竜Dt.ToString()
	};

	private static HashSet<string> 足竜 = new HashSet<string>
	{
		Sta.足_獣Dt.ToString(),
		Sta.足_馬Dt.ToString(),
		Sta.足_牛Dt.ToString(),
		Sta.足_鳥Dt.ToString(),
		Sta.足_竜Dt.ToString()
	};

	private static HashSet<string> 前翅甲軸1 = new HashSet<string>();

	private static HashSet<string> 前翅甲軸2 = new HashSet<string>();

	private static HashSet<string> 前翅甲軸3 = new HashSet<string>();

	private static HashSet<string> 犬頭 = new HashSet<string>();

	private static HashSet<string> 犬上腕 = new HashSet<string>();

	private static HashSet<string> 犬下腕 = new HashSet<string>();

	private static HashSet<string> 犬手 = new HashSet<string>();

	private static HashSet<string> 蔦 = new HashSet<string>
	{
		Sta.葉_披Dt.ToString(),
		Sta.葉_心Dt.ToString()
	};

	private static HashSet<string> 蔦先 = new HashSet<string> { Sta.虫鎌Dt.ToString() };

	private static HashSet<string> 顔面 = new HashSet<string>
	{
		Sta.顔面_甲Dt.ToString(),
		Sta.顔面_虫Dt.ToString(),
		Sta.顔面_蟲Dt.ToString()
	};

	private static HashSet<string> 大顎基 = new HashSet<string> { Sta.大顎基Dt.ToString() };

	private static HashSet<string> 大顎 = new HashSet<string> { Sta.大顎Dt.ToString() };

	private static HashSet<string> 花 = new HashSet<string>
	{
		Sta.花_薔Dt.ToString(),
		Sta.花_百Dt.ToString()
	};

	public static Dictionary<ConnectionInfo, HashSet<string>> 接続範囲 = new Dictionary<ConnectionInfo, HashSet<string>>
	{
		{
			ConnectionInfo.基髪_頭頂左_接続,
			側頭
		},
		{
			ConnectionInfo.基髪_頭頂右_接続,
			側頭
		},
		{
			ConnectionInfo.頭_触覚左_接続,
			触覚
		},
		{
			ConnectionInfo.頭_触覚右_接続,
			触覚
		},
		{
			ConnectionInfo.頭_耳左_接続,
			耳
		},
		{
			ConnectionInfo.頭_耳右_接続,
			耳
		},
		{
			ConnectionInfo.頭_頬左_接続,
			頬
		},
		{
			ConnectionInfo.頭_頬右_接続,
			頬
		},
		{
			ConnectionInfo.後髪0_肢系_左5_接続,
			後髪
		},
		{
			ConnectionInfo.後髪0_肢系_右5_接続,
			後髪
		},
		{
			ConnectionInfo.後髪0_肢系_左4_接続,
			後髪
		},
		{
			ConnectionInfo.後髪0_肢系_右4_接続,
			後髪
		},
		{
			ConnectionInfo.後髪0_肢系_左3_接続,
			後髪
		},
		{
			ConnectionInfo.後髪0_肢系_右3_接続,
			後髪
		},
		{
			ConnectionInfo.後髪0_肢系_左2_接続,
			後髪
		},
		{
			ConnectionInfo.後髪0_肢系_右2_接続,
			後髪
		},
		{
			ConnectionInfo.後髪0_肢系_左1_接続,
			後髪
		},
		{
			ConnectionInfo.後髪0_肢系_右1_接続,
			後髪
		},
		{
			ConnectionInfo.胸_肩左_接続,
			肩人
		},
		{
			ConnectionInfo.胸_肩右_接続,
			肩人
		},
		{
			ConnectionInfo.胸_翼上左_接続,
			胸翼上人
		},
		{
			ConnectionInfo.胸_翼上右_接続,
			胸翼上人
		},
		{
			ConnectionInfo.胸_翼下左_接続,
			胸翼下人
		},
		{
			ConnectionInfo.胸_翼下右_接続,
			胸翼下人
		},
		{
			ConnectionInfo.胴_翼左_接続,
			胴翼人
		},
		{
			ConnectionInfo.胴_翼右_接続,
			胴翼人
		},
		{
			ConnectionInfo.腰_翼左_接続,
			腰翼人
		},
		{
			ConnectionInfo.腰_翼右_接続,
			腰翼人
		},
		{
			ConnectionInfo.腰_腿左_接続,
			腿人
		},
		{
			ConnectionInfo.腰_腿右_接続,
			腿人
		},
		{
			ConnectionInfo.四足胸_脇左_接続,
			肩獣
		},
		{
			ConnectionInfo.四足胸_脇右_接続,
			肩獣
		},
		{
			ConnectionInfo.四足胸_翼上左_接続,
			胸翼上獣
		},
		{
			ConnectionInfo.四足胸_翼上右_接続,
			胸翼上獣
		},
		{
			ConnectionInfo.四足胸_翼下左_接続,
			胸翼下獣
		},
		{
			ConnectionInfo.四足胸_翼下右_接続,
			胸翼下獣
		},
		{
			ConnectionInfo.四足胴_翼左_接続,
			胴翼獣
		},
		{
			ConnectionInfo.四足胴_翼右_接続,
			胴翼獣
		},
		{
			ConnectionInfo.四足腰_翼左_接続,
			腰翼獣
		},
		{
			ConnectionInfo.四足腰_翼右_接続,
			腰翼獣
		},
		{
			ConnectionInfo.四足腰_腿左_接続,
			腿獣
		},
		{
			ConnectionInfo.四足腰_腿右_接続,
			腿獣
		},
		{
			ConnectionInfo.多足_蛸_軟体外左_接続,
			蛸外
		},
		{
			ConnectionInfo.多足_蛸_軟体外右_接続,
			蛸外
		},
		{
			ConnectionInfo.多足_蛸_軟体内左_接続,
			蛸内
		},
		{
			ConnectionInfo.多足_蛸_軟体内右_接続,
			蛸内
		},
		{
			ConnectionInfo.多足_蜘_触肢左_接続,
			蜘触肢
		},
		{
			ConnectionInfo.多足_蜘_触肢右_接続,
			蜘触肢
		},
		{
			ConnectionInfo.多足_蜘_節足左1_接続,
			蜘節足1
		},
		{
			ConnectionInfo.多足_蜘_節足右1_接続,
			蜘節足1
		},
		{
			ConnectionInfo.多足_蜘_節足左2_接続,
			蜘節足2
		},
		{
			ConnectionInfo.多足_蜘_節足右2_接続,
			蜘節足2
		},
		{
			ConnectionInfo.多足_蜘_節足左3_接続,
			蜘節足3
		},
		{
			ConnectionInfo.多足_蜘_節足右3_接続,
			蜘節足3
		},
		{
			ConnectionInfo.多足_蜘_節足左4_接続,
			蜘節足4
		},
		{
			ConnectionInfo.多足_蜘_節足右4_接続,
			蜘節足4
		},
		{
			ConnectionInfo.多足_蠍_触肢左_接続,
			蠍触肢
		},
		{
			ConnectionInfo.多足_蠍_触肢右_接続,
			蠍触肢
		},
		{
			ConnectionInfo.多足_蠍_節足左1_接続,
			蠍節足1
		},
		{
			ConnectionInfo.多足_蠍_節足右1_接続,
			蠍節足1
		},
		{
			ConnectionInfo.多足_蠍_節足左2_接続,
			蠍節足2
		},
		{
			ConnectionInfo.多足_蠍_節足右2_接続,
			蠍節足2
		},
		{
			ConnectionInfo.多足_蠍_節足左3_接続,
			蠍節足3
		},
		{
			ConnectionInfo.多足_蠍_節足右3_接続,
			蠍節足3
		},
		{
			ConnectionInfo.多足_蠍_節足左4_接続,
			蠍節足4
		},
		{
			ConnectionInfo.多足_蠍_節足右4_接続,
			蠍節足4
		},
		{
			ConnectionInfo.多足_蠍_櫛状板左_接続,
			蠍櫛状板
		},
		{
			ConnectionInfo.多足_蠍_櫛状板右_接続,
			蠍櫛状板
		},
		{
			ConnectionInfo.単足_植_根外左_接続,
			植外
		},
		{
			ConnectionInfo.単足_植_根外右_接続,
			植外
		},
		{
			ConnectionInfo.単足_植_根内左_接続,
			植内
		},
		{
			ConnectionInfo.単足_植_根内右_接続,
			植内
		},
		{
			ConnectionInfo.長物_魚_左0_接続,
			魚
		},
		{
			ConnectionInfo.長物_魚_右0_接続,
			魚
		},
		{
			ConnectionInfo.長物_魚_左6_接続,
			魚
		},
		{
			ConnectionInfo.長物_魚_右6_接続,
			魚
		},
		{
			ConnectionInfo.長物_鯨_左0_接続,
			鯨
		},
		{
			ConnectionInfo.長物_鯨_右0_接続,
			鯨
		},
		{
			ConnectionInfo.長物_鯨_左6_接続,
			鯨
		},
		{
			ConnectionInfo.長物_鯨_右6_接続,
			鯨
		},
		{
			ConnectionInfo.長物_蛇_左_接続,
			蛇
		},
		{
			ConnectionInfo.長物_蛇_右_接続,
			蛇
		},
		{
			ConnectionInfo.胴_蛇_左_接続,
			蛇
		},
		{
			ConnectionInfo.胴_蛇_右_接続,
			蛇
		},
		{
			ConnectionInfo.長物_蟲_左0_接続,
			蟲
		},
		{
			ConnectionInfo.長物_蟲_右0_接続,
			蟲
		},
		{
			ConnectionInfo.長物_蟲_左1_接続,
			蟲
		},
		{
			ConnectionInfo.長物_蟲_右1_接続,
			蟲
		},
		{
			ConnectionInfo.尾_蟲_左1_接続,
			蟲尾
		},
		{
			ConnectionInfo.尾_蟲_右1_接続,
			蟲尾
		},
		{
			ConnectionInfo.尾_蟲_左2_接続,
			蟲尾
		},
		{
			ConnectionInfo.尾_蟲_右2_接続,
			蟲尾
		},
		{
			ConnectionInfo.尾_蟲_左3_接続,
			蟲尾
		},
		{
			ConnectionInfo.尾_蟲_右3_接続,
			蟲尾
		},
		{
			ConnectionInfo.尾_蟲_左4_接続,
			蟲尾
		},
		{
			ConnectionInfo.尾_蟲_右4_接続,
			蟲尾
		},
		{
			ConnectionInfo.尾_蟲_左5_接続,
			蟲尾
		},
		{
			ConnectionInfo.尾_蟲_右5_接続,
			蟲尾
		},
		{
			ConnectionInfo.尾_蟲_尾左_接続,
			蟲尾先
		},
		{
			ConnectionInfo.尾_蟲_尾右_接続,
			蟲尾先
		},
		{
			ConnectionInfo.胴_蟲_左_接続,
			蟲
		},
		{
			ConnectionInfo.胴_蟲_右_接続,
			蟲
		},
		{
			ConnectionInfo.顔面_甲_触覚左_接続,
			触覚甲
		},
		{
			ConnectionInfo.顔面_甲_触覚右_接続,
			触覚甲
		},
		{
			ConnectionInfo.顔面_虫_触覚左_接続,
			触覚虫
		},
		{
			ConnectionInfo.顔面_虫_触覚右_接続,
			触覚虫
		},
		{
			ConnectionInfo.顔面_蟲_触覚左_接続,
			触覚蟲
		},
		{
			ConnectionInfo.顔面_蟲_触覚右_接続,
			触覚蟲
		},
		{
			ConnectionInfo.頭_頭頂_接続,
			頭頂
		},
		{
			ConnectionInfo.頭_額_接続,
			額
		},
		{
			ConnectionInfo.胸_背中_接続,
			背中人
		},
		{
			ConnectionInfo.四足胸_背中_接続,
			背中獣
		},
		{
			ConnectionInfo.腰_尾_接続,
			尾人
		},
		{
			ConnectionInfo.四足腰_尾_接続,
			尾獣
		},
		{
			ConnectionInfo.多足_蜘_尾_接続,
			尾蜘
		},
		{
			ConnectionInfo.多足_蠍_尾_接続,
			尾蠍
		},
		{
			ConnectionInfo.長物_魚_尾_接続,
			尾魚
		},
		{
			ConnectionInfo.長物_鯨_尾_接続,
			尾鯨
		},
		{
			ConnectionInfo.長物_蛇_胴_接続,
			尾蛇
		},
		{
			ConnectionInfo.長物_蟲_胴_接続,
			尾蟲
		},
		{
			ConnectionInfo.胴_蛇_胴_接続,
			尾蛇
		},
		{
			ConnectionInfo.胴_蟲_胴_接続,
			尾蟲
		},
		{
			ConnectionInfo.単足_植_根中央_接続,
			根中
		},
		{
			ConnectionInfo.尾_ヘ_尾先_接続,
			尾先ヘ
		},
		{
			ConnectionInfo.尾_ウ_尾先_接続,
			尾先ウ
		},
		{
			ConnectionInfo.尾_魚_尾先_接続,
			尾先魚
		},
		{
			ConnectionInfo.尾_鯨_尾先_接続,
			尾先鯨
		},
		{
			ConnectionInfo.頭頂_宇_頭部後_接続,
			頭頂後
		},
		{
			ConnectionInfo.頭_大顎基_接続,
			大顎基
		},
		{
			ConnectionInfo.頭_顔面_接続,
			顔面
		},
		{
			ConnectionInfo.肩_上腕_接続,
			上腕人
		},
		{
			ConnectionInfo.四足脇_上腕_接続,
			上腕獣
		},
		{
			ConnectionInfo.上腕_人_下腕_接続,
			下腕人
		},
		{
			ConnectionInfo.上腕_鳥_下腕_接続,
			下腕鳥
		},
		{
			ConnectionInfo.上腕_蝙_下腕_接続,
			下腕蝙
		},
		{
			ConnectionInfo.上腕_獣_下腕_接続,
			下腕獣
		},
		{
			ConnectionInfo.上腕_蹄_下腕_接続,
			下腕蹄
		},
		{
			ConnectionInfo.下腕_人_手_接続,
			手人
		},
		{
			ConnectionInfo.下腕_鳥_手_接続,
			手鳥
		},
		{
			ConnectionInfo.下腕_蝙_手_接続,
			手蝙
		},
		{
			ConnectionInfo.下腕_獣_手_接続,
			手獣
		},
		{
			ConnectionInfo.下腕_蹄_手_接続,
			手蹄
		},
		{
			ConnectionInfo.下腕_人_虫鎌_接続,
			虫鎌
		},
		{
			ConnectionInfo.腿_人_脚_接続,
			脚人
		},
		{
			ConnectionInfo.腿_獣_脚_接続,
			脚獣
		},
		{
			ConnectionInfo.腿_蹄_脚_接続,
			脚蹄
		},
		{
			ConnectionInfo.腿_鳥_脚_接続,
			脚鳥
		},
		{
			ConnectionInfo.腿_竜_脚_接続,
			脚竜
		},
		{
			ConnectionInfo.脚_人_足_接続,
			足人
		},
		{
			ConnectionInfo.脚_獣_足_接続,
			足獣
		},
		{
			ConnectionInfo.脚_蹄_足_接続,
			足蹄
		},
		{
			ConnectionInfo.脚_鳥_足_接続,
			足鳥
		},
		{
			ConnectionInfo.脚_竜_足_接続,
			足竜
		},
		{
			ConnectionInfo.前翅_甲_軸1_接続,
			前翅甲軸1
		},
		{
			ConnectionInfo.前翅_甲_軸2_接続,
			前翅甲軸2
		},
		{
			ConnectionInfo.前翅_甲_軸3_接続,
			前翅甲軸3
		},
		{
			ConnectionInfo.触手_犬_頭_接続,
			犬頭
		},
		{
			ConnectionInfo.触手_犬_上腕左_接続,
			犬上腕
		},
		{
			ConnectionInfo.触手_犬_上腕右_接続,
			犬上腕
		},
		{
			ConnectionInfo.触手_犬_下腕左_接続,
			犬下腕
		},
		{
			ConnectionInfo.触手_犬_下腕右_接続,
			犬下腕
		},
		{
			ConnectionInfo.触手_犬_手左_接続,
			犬手
		},
		{
			ConnectionInfo.触手_犬_手右_接続,
			犬手
		},
		{
			ConnectionInfo.触手_蔦_節3_接続,
			蔦
		},
		{
			ConnectionInfo.触手_蔦_節5_接続,
			蔦
		},
		{
			ConnectionInfo.触手_蔦_節7_接続,
			蔦
		},
		{
			ConnectionInfo.触手_蔦_節9_接続,
			蔦
		},
		{
			ConnectionInfo.触手_蔦_節11_接続,
			蔦
		},
		{
			ConnectionInfo.触手_蔦_節13_接続,
			蔦
		},
		{
			ConnectionInfo.触手_蔦_節15_接続,
			蔦
		},
		{
			ConnectionInfo.触手_蔦_節17_接続,
			蔦
		},
		{
			ConnectionInfo.触手_蔦_節19_接続,
			蔦
		},
		{
			ConnectionInfo.触手_蔦_先端_接続,
			蔦先
		},
		{
			ConnectionInfo.大顎基_顎左_接続,
			大顎
		},
		{
			ConnectionInfo.大顎基_顎右_接続,
			大顎
		},
		{
			ConnectionInfo.植_花_接続,
			花
		}
	};

	private static Type 体色t = typeof(体色);

	private static HashSet<string> 実数対象 = new HashSet<string>
	{
		"肥大", "身長", "サイズ", "サイズX", "サイズY", "目高", "目間", "眉間", "髪長0", "髪長1",
		"毛量", "広がり", "髪長", "高さ", "髪長2", "傾き", "外線", "睫毛_睫毛3_長さ", "睫毛_睫毛1_長さ", "睫毛_睫毛2_長さ",
		"睫毛_睫毛4_長さ", "睫毛上上左_長さ", "睫毛上中左_長さ", "睫毛上下左_長さ", "睫毛上上右_長さ", "睫毛上中右_長さ", "睫毛上下右_長さ", "睫毛下上左_長さ", "睫毛下下左_長さ", "睫毛下上右_長さ",
		"睫毛下下右_長さ", "瞼左_睫毛1_長さ", "瞼左_睫毛2_長さ", "瞼右_睫毛1_長さ", "瞼右_睫毛2_長さ", "口紅濃度", "バスト", "縁側角", "シャープ", "鋭爪"
	};

	private static BindingFlags bi = BindingFlags.Instance | BindingFlags.Public;

	private static Type[] t0 = new Type[0];

	private static 体色 Mix(体色 母方, 体色 父方, double 変異率, 腰D d)
	{
		体色 体色2 = new 体色();
		switch (RNG.XS.Next(4))
		{
		case 0:
			foreach (FieldInfo item in from e in 体色t.GetFields()
				where e.FieldType.ToString() == Sta.ct
				select e)
			{
				item.SetValue(体色2, RNG.XS.NextBool() ? item.GetValue(母方) : item.GetValue(父方));
			}
			break;
		case 1:
			foreach (FieldInfo item2 in from e in 体色t.GetFields()
				where e.FieldType.ToString() == Sta.ct
				select e)
			{
				Color c3 = (Color)item2.GetValue(母方);
				Color c4 = (Color)item2.GetValue(父方);
				if (!c3.IsEmpty && !c4.IsEmpty)
				{
					item2.SetValue(体色2, Oth.GetInter(ref c3, ref c4));
				}
				else
				{
					item2.SetValue(体色2, c3);
				}
			}
			break;
		case 2:
			foreach (FieldInfo item3 in from e in 体色t.GetFields()
				where e.FieldType.ToString() == Sta.ct
				select e)
			{
				Color c5 = (Color)item3.GetValue(母方);
				Color c6 = (Color)item3.GetValue(父方);
				if (!c5.IsEmpty && !c6.IsEmpty)
				{
					item3.SetValue(体色2, Oth.GetInter(ref c5, ref c6));
				}
				else
				{
					item3.SetValue(体色2, c6);
				}
			}
			break;
		default:
			foreach (FieldInfo item4 in from e in 体色t.GetFields()
				where e.FieldType.ToString() == Sta.ct
				select e)
			{
				Color c = (Color)item4.GetValue(母方);
				Color c2 = (Color)item4.GetValue(父方);
				if (!c.IsEmpty && !c2.IsEmpty)
				{
					item4.SetValue(体色2, Oth.GetInter(ref c, ref c2));
				}
				else
				{
					item4.SetValue(体色2, RNG.XS.NextBool() ? c : c2);
				}
			}
			break;
		}
		if (母方.血統.Contains(GameText.アルビノ) && 父方.血統.Contains(GameText.アルビノ))
		{
			体色2.血統.Add(GameText.アルビノ);
		}
		else if (母方.血統.Contains(GameText.メラニス) && 父方.血統.Contains(GameText.メラニス))
		{
			体色2.血統.Add(GameText.メラニス);
		}
		else if (母方.血統.Any((string e) => e.StartsWith(GameText.ルチノー)) && 父方.血統.Any((string e) => e.StartsWith(GameText.ルチノー)))
		{
			string text = 母方.血統.First((string e) => e.StartsWith(GameText.ルチノー));
			string text2 = 父方.血統.First((string e) => e.StartsWith(GameText.ルチノー));
			if (text == text2)
			{
				体色2.血統.Add(text);
			}
			else
			{
				double rutinohWeight = text.GetRutinohWeight();
				double rutinohWeight2 = text2.GetRutinohWeight();
				if (rutinohWeight < rutinohWeight2)
				{
					体色2.血統.Add(text);
				}
				else if (rutinohWeight > rutinohWeight2)
				{
					体色2.血統.Add(text2);
				}
				else
				{
					体色2.血統.Add(RNG.XS.NextBool() ? text : text2);
				}
			}
		}
		if (変異率.Lot())
		{
			double[] obj = new double[4] { 1.0, 2.0, 8.0, 0.0 };
			obj[3] = 500.0 * ((Sta.GameData.祝福 != null && Sta.GameData.祝福.Race == GameText.カーバンクル) ? 0.5 : 1.0);
			switch (Oth.GetRandomIndex(obj))
			{
			case 0:
				if (体色2.血統.Contains(GameText.アルビノ))
				{
					break;
				}
				foreach (FieldInfo item5 in from e in 体色t.GetFields()
					where 体色.変異色.Contains(e.Name) && e.FieldType.ToString() == Sta.ct
					select e)
				{
					Color color = (Color)item5.GetValue(体色2);
					if (color != Col.Empty)
					{
						if (item5.Name == "人肌")
						{
							color = Color.FromArgb(color.A, 255, 255, 255);
							Col.GetLimitSkin(ref color, out color);
							item5.SetValue(体色2, color);
						}
						else if (item5.Name.Contains("目") || item5.Name.Contains("眼") || item5.Name.Contains("秘石") || item5.Name.Contains("コア"))
						{
							item5.SetValue(体色2, Color.FromArgb(color.A, 255, 0, 0));
						}
						else
						{
							item5.SetValue(体色2, Color.FromArgb(color.A, 255, 255, 255));
						}
					}
				}
				体色2.血統.Add(GameText.アルビノ);
				break;
			case 1:
				if (体色2.血統.Contains(GameText.メラニス))
				{
					break;
				}
				foreach (FieldInfo item6 in from e in 体色t.GetFields()
					where 体色.変異色.Contains(e.Name) && e.FieldType.ToString() == Sta.ct
					select e)
				{
					Color color = (Color)item6.GetValue(体色2);
					if (color != Col.Empty)
					{
						if (item6.Name == "人肌")
						{
							color = Color.FromArgb(color.A, 0, 0, 0);
							Col.GetLimitSkin(ref color, out color);
							item6.SetValue(体色2, color);
						}
						else if (item6.Name.Contains("目") || item6.Name.Contains("眼") || item6.Name.Contains("秘石") || item6.Name.Contains("コア"))
						{
							item6.SetValue(体色2, Color.FromArgb(color.A, 0, 127, 255));
						}
						else
						{
							item6.SetValue(体色2, Color.FromArgb(color.A, 0, 0, 0));
						}
					}
				}
				体色2.血統.Add(GameText.メラニス);
				break;
			case 2:
			{
				if (体色2.血統.Any((string e) => e.StartsWith(GameText.ルチノー)))
				{
					break;
				}
				int num = RNG.XS.Next(3);
				int num2 = RNG.XS.Next(3);
				int num3 = RNG.XS.Next(3);
				foreach (FieldInfo item7 in from e in 体色t.GetFields()
					where 体色.変異色.Contains(e.Name) && e.FieldType.ToString() == Sta.ct
					select e)
				{
					Color color = (Color)item7.GetValue(体色2);
					if (color != Col.Empty)
					{
						if (item7.Name == "人肌")
						{
							color = Color.FromArgb(color.A, GetVal(color.R, num), GetVal(color.G, num2), GetVal(color.B, num3));
							Col.GetLimitSkin(ref color, out color);
							item7.SetValue(体色2, color);
						}
						else
						{
							color = Color.FromArgb(color.A, GetVal(color.R, num), GetVal(color.G, num2), GetVal(color.B, num3));
							Col.GetLimit(ref color, out color);
							item7.SetValue(体色2, color);
						}
					}
				}
				if (num != 2 || num2 != 2 || num3 != 2)
				{
					体色2.血統.Add(GameText.ルチノー + num + num2 + num3);
				}
				break;
			}
			}
			if (0.05.Lot())
			{
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				foreach (EleD item8 in d.EnumEleD())
				{
					if (!flag && item8 is 双目D)
					{
						flag = true;
					}
					if (!flag2 && item8 is 頬目D)
					{
						flag2 = true;
					}
					if (!flag3 && item8 is 縦目D)
					{
						flag3 = true;
					}
				}
				if ((flag2 && 体色2.頬目左 != 体色2.頬目右) || (flag && 体色2.目左 != 体色2.目右) || (flag3 && (体色2.目左 != 体色2.縦目 || 体色2.目右 != 体色2.縦目)))
				{
					体色2.血統.Add(GameText.オッドアイ);
				}
			}
			else
			{
				switch (RNG.XS.Next(6))
				{
				case 0:
					体色2.縦目 = 体色2.目左;
					体色2.頬目左 = 体色2.目左;
					体色2.頬目右 = 体色2.目左;
					体色2.目右 = 体色2.目左;
					break;
				case 1:
					体色2.縦目 = 体色2.目右;
					体色2.頬目左 = 体色2.目右;
					体色2.頬目右 = 体色2.目右;
					体色2.目左 = 体色2.目右;
					break;
				case 2:
					Oth.GetInter(ref 体色2.目左, ref 体色2.目右, out 体色2.縦目);
					体色2.頬目左 = 体色2.目左;
					体色2.頬目右 = 体色2.目左;
					体色2.目右 = 体色2.目左;
					break;
				case 3:
					Oth.GetInter(ref 体色2.目左, ref 体色2.目右, out 体色2.縦目);
					体色2.頬目左 = 体色2.目右;
					体色2.頬目右 = 体色2.目右;
					体色2.目左 = 体色2.目右;
					break;
				case 4:
					体色2.頬目左 = 体色2.目左;
					体色2.頬目右 = 体色2.目左;
					体色2.目右 = 体色2.目左;
					break;
				default:
					体色2.頬目左 = 体色2.目右;
					体色2.頬目右 = 体色2.目右;
					体色2.目左 = 体色2.目右;
					break;
				}
			}
		}
		else if (母方.血統.Contains(GameText.オッドアイ) && 父方.血統.Contains(GameText.オッドアイ))
		{
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			foreach (EleD item9 in d.EnumEleD())
			{
				if (!flag4 && item9 is 双目D)
				{
					flag4 = true;
				}
				if (!flag5 && item9 is 頬目D)
				{
					flag5 = true;
				}
				if (!flag6 && item9 is 縦目D)
				{
					flag6 = true;
				}
			}
			if ((flag5 && 体色2.頬目左 != 体色2.頬目右) || (flag4 && 体色2.目左 != 体色2.目右) || (flag6 && (体色2.目左 != 体色2.縦目 || 体色2.目右 != 体色2.縦目)))
			{
				体色2.血統.Add(GameText.オッドアイ);
			}
		}
		else
		{
			switch (RNG.XS.Next(6))
			{
			case 0:
				体色2.縦目 = 体色2.目左;
				体色2.頬目左 = 体色2.目左;
				体色2.頬目右 = 体色2.目左;
				体色2.目右 = 体色2.目左;
				break;
			case 1:
				体色2.縦目 = 体色2.目右;
				体色2.頬目左 = 体色2.目右;
				体色2.頬目右 = 体色2.目右;
				体色2.目左 = 体色2.目右;
				break;
			case 2:
				Oth.GetInter(ref 体色2.目左, ref 体色2.目右, out 体色2.縦目);
				体色2.頬目左 = 体色2.目左;
				体色2.頬目右 = 体色2.目左;
				体色2.目右 = 体色2.目左;
				break;
			case 3:
				Oth.GetInter(ref 体色2.目左, ref 体色2.目右, out 体色2.縦目);
				体色2.頬目左 = 体色2.目右;
				体色2.頬目右 = 体色2.目右;
				体色2.目左 = 体色2.目右;
				break;
			case 4:
				体色2.頬目左 = 体色2.目左;
				体色2.頬目右 = 体色2.目左;
				体色2.目右 = 体色2.目左;
				break;
			default:
				体色2.頬目左 = 体色2.目右;
				体色2.頬目右 = 体色2.目右;
				体色2.目左 = 体色2.目右;
				break;
			}
		}
		return 体色2;
	}

	private static int GetVal(int i, int v)
	{
		return v switch
		{
			1 => 255, 
			0 => 0, 
			_ => i, 
		};
	}

	private static 腰D Mix(腰D 母方, 腰D 父方, double 変異率, bool 原種モード)
	{
		int i = (原種モード ? RNG.XS.Next(3) : RNG.XS.Next(7));
		Dictionary<ConnectionInfo, List<Type>> 接続構成 = Get接続構成(母方, 父方);
		Type[] 要素構成 = Get要素構成(母方, 父方);
		頭D 頭D2 = Mix<頭D>(母方, 父方, i, 原種モード);
		基髪D 基髪D2 = new 基髪D();
		頭D2.基髪接続(基髪D2);
		頭D2.目左接続(new 目傷D());
		頭D2.目右接続(new 目傷D
		{
			右 = true
		});
		頭D2.目左接続(new 目尻影D());
		頭D2.目右接続(new 目尻影D
		{
			右 = true
		});
		鼻肌D 鼻肌D2;
		頭D2.鼻肌接続(鼻肌D2 = Mix<鼻肌D>(母方, 父方, i, 原種モード));
		頭D2.鼻肌接続(new 紅潮D());
		頬肌D 頬肌D2 = Mix<頬肌D>(母方, 父方, 右: false, i, 原種モード);
		頭D2.頬肌左接続(頬肌D2);
		頭D2.頬肌右接続(頬肌D2.Get逆());
		顔ハイライトD 顔ハイライトD2 = Mix<顔ハイライトD>(母方, 父方, 右: false, i, 原種モード);
		頭D2.頬左接続(顔ハイライトD2);
		頭D2.頬右接続(顔ハイライトD2.Get逆());
		頭D2.単眼目接続(new 目隠帯D());
		頭D2.口接続(new 玉口枷D());
		頭D2.AlignC();
		首D 首D2 = Mix<首D>(母方, 父方, i, 原種モード);
		首D2.頭接続(頭D2);
		胸D 胸D2 = Mix<胸D>(母方, 父方, i, 原種モード);
		乳房D 乳房D2 = Mix<乳房D>(母方, 父方, 右: false, i, 原種モード);
		乳房D2.噴乳接続(new 噴乳D());
		乳房D2.噴乳接続(new ピアスD());
		乳房D2.噴乳接続(new キャップ2D());
		乳房D2.噴乳接続(new 下着乳首D());
		胸D2.胸左接続(乳房D2);
		胸D2.胸右接続(乳房D2.Get逆());
		胸D2.肌接続(Mix<胸毛D>(母方, 父方, i, 原種モード));
		胸D2.肌接続(Mix<胸肌D>(母方, 父方, i, 原種モード));
		胸腹板D 胸腹板D2;
		胸D2.肌接続(胸腹板D2 = Mix<胸腹板D>(母方, 父方, i, 原種モード));
		胸D2.肌接続(new 下着トップ_チューブD());
		胸D2.肌接続(new 下着トップ_クロスD());
		胸D2.肌接続(new 下着トップ_ビキニD());
		胸D2.肌接続(new 下着トップ_マイクロD());
		胸D2.肌接続(new 下着トップ_ブラD());
		胸D2.肌接続(new 上着トップ_ドレスD());
		胸D2.AlignC();
		胸D2.首接続(首D2);
		胴D 胴D2 = Mix<胴D>(母方, 父方, i, 原種モード);
		胴腹板D 胴腹板D2;
		胴D2.肌接続(胴腹板D2 = Mix<胴腹板D>(母方, 父方, i, 原種モード));
		胴D2.肌接続(Mix<胴肌D>(母方, 父方, i, 原種モード));
		胴D2.肌接続(new 上着ミドル_ドレスD());
		胴D2.AlignC();
		胴D2.胸接続(胸D2);
		腰D 腰 = Mix<腰D>(母方, 父方, i, 原種モード);
		腰.膣基接続(new 膣基_人D());
		腰.膣基接続(new 膣内精液_人D());
		腰.膣基接続(new 断面_人D());
		腰.膣基接続(Uni.性器());
		腰.肛門接続(Uni.肛門());
		腰.肌接続(Uni.ボテ腹());
		腰肌D 腰肌;
		腰.肌接続(腰肌 = Mix<腰肌D>(母方, 父方, i, 原種モード));
		腰.肌接続(new 下着ボトム_ノーマルD());
		腰.肌接続(new 下着ボトム_マイクロD());
		上着ボトム_クロスD 上着ボトム_クロスD2 = new 上着ボトム_クロスD();
		上着ボトム_クロスD2.上着ボトム後接続(new 上着ボトム_クロス後D());
		腰.上着接続(上着ボトム_クロスD2);
		腰.上着接続(new 上着ボトム_前掛けD());
		腰.AlignC();
		腰.胴接続(胴D2);
		胴D2.肥大 = 腰.肥大;
		if (RNG.XS.NextBool())
		{
			EleD eleD = SlaveMatrix.GameClasses._Con.Get後髪0R();
			基髪D2.後髪接続(eleD);
			eleD.AlignR();
			if (eleD is 後髪0_肢系D && 変異率.Lot())
			{
				eleD.接続(母方, 父方, i, ConnectionInfo.後髪0_肢系_左2_接続, 要素構成, 接続構成, 変異率, 原種モード);
				eleD.接続(母方, 父方, i, ConnectionInfo.後髪0_肢系_左3_接続, 要素構成, 接続構成, 変異率, 原種モード);
				eleD.接続(母方, 父方, i, ConnectionInfo.後髪0_肢系_左4_接続, 要素構成, 接続構成, 変異率, 原種モード);
				eleD.接続(母方, 父方, i, ConnectionInfo.後髪0_肢系_左5_接続, 要素構成, 接続構成, 変異率, 原種モード);
			}
			if ((eleD is 後髪0_ジグD || eleD is 後髪0_ハネD || eleD is 後髪0_パツD || eleD is 後髪0_カルD || eleD is 後髪0_肢系D) && RNG.XS.NextBool())
			{
				EleD e2 = SlaveMatrix.GameClasses._Con.Get後髪1R();
				基髪D2.後髪接続(e2);
				e2.AlignR();
			}
			EleD eleD2 = SlaveMatrix.GameClasses._Con.Get横髪R(右: false);
			基髪D2.横髪左接続(eleD2);
			eleD2.AlignR();
			基髪D2.横髪右接続(eleD2.Get逆());
			EleD e3 = SlaveMatrix.GameClasses._Con.Get前髪R();
			基髪D2.前髪接続(e3);
			e3.AlignR();
		}
		else
		{
			後髪0D 後髪0D2 = Mix<後髪0D>(母方, 父方, i, 原種モード);
			if (後髪0D2 != null)
			{
				基髪D2.後髪接続(後髪0D2);
				後髪0D2.AlignR();
				if (後髪0D2 is 後髪0_肢系D && 変異率.Lot())
				{
					後髪0D2.接続(母方, 父方, i, ConnectionInfo.後髪0_肢系_左2_接続, 要素構成, 接続構成, 変異率, 原種モード);
					後髪0D2.接続(母方, 父方, i, ConnectionInfo.後髪0_肢系_左3_接続, 要素構成, 接続構成, 変異率, 原種モード);
					後髪0D2.接続(母方, 父方, i, ConnectionInfo.後髪0_肢系_左4_接続, 要素構成, 接続構成, 変異率, 原種モード);
					後髪0D2.接続(母方, 父方, i, ConnectionInfo.後髪0_肢系_左5_接続, 要素構成, 接続構成, 変異率, 原種モード);
				}
				if ((後髪0D2 is 後髪0_ジグD || 後髪0D2 is 後髪0_ハネD || 後髪0D2 is 後髪0_パツD || 後髪0D2 is 後髪0_カルD || 後髪0D2 is 後髪0_肢系D) && RNG.XS.NextBool())
				{
					後髪1D 後髪1D2 = Mix<後髪1D>(母方, 父方, i, 原種モード);
					if (後髪1D2 != null)
					{
						基髪D2.後髪接続(後髪1D2);
						後髪1D2.AlignR();
					}
				}
			}
			else if (RNG.XS.NextBool())
			{
				後髪1D 後髪1D3 = Mix<後髪1D>(母方, 父方, i, 原種モード);
				if (後髪1D3 != null)
				{
					基髪D2.後髪接続(後髪1D3);
					後髪1D3.AlignR();
				}
			}
			横髪D 横髪D2 = Mix<横髪D>(母方, 父方, 右: false, i, 原種モード);
			基髪D2.横髪左接続(横髪D2);
			横髪D2.AlignR();
			基髪D2.横髪右接続(横髪D2.Get逆());
			前髪D e4 = Mix<前髪D>(母方, 父方, i, 原種モード);
			基髪D2.前髪接続(e4);
			e4.AlignR();
		}
		双目D 双目D2 = null;
		双目D 双目D3 = null;
		頬目D 頬目D2 = null;
		頬目D 頬目D3 = null;
		縦目D 縦目D2 = null;
		単目D 単目D2 = null;
		縦瞼D 縦瞼D2 = null;
		単瞼D 単瞼D2 = null;
		bool flag = 母方.EnumEleD().IsEleD<双目D>() || 父方.EnumEleD().IsEleD<双目D>();
		bool flag2 = 母方.EnumEleD().IsEleD<単目D>() || 父方.EnumEleD().IsEleD<単目D>();
		if (!原種モード && 変異率.Lot() && 0.05.Lot())
		{
			flag2 = true;
		}
		if (flag && flag2)
		{
			if (RNG.XS.NextBool())
			{
				双目D2 = Mix<双目D>(母方, 父方, 右: false, i, 原種モード);
				双瞼D 双瞼D2 = Mix<双瞼D>(母方, 父方, 右: false, i, 原種モード);
				眉D 眉D2 = Mix<眉D>(母方, 父方, 右: false, i, 原種モード);
				if (双目D2 != null && 双瞼D2 != null && 眉D2 != null)
				{
					if (原種モード || !変異率.Lot() || !0.05.Lot())
					{
						双目D2.瞼接続(双瞼D2);
						双目D2.瞼接続(new 涙D());
						頭D2.目左接続(双目D2);
						頭D2.目右接続(双目D3 = (双目D)双目D2.Get逆());
					}
					頭D2.眉左接続(眉D2);
					頭D2.眉右接続(眉D2.Get逆());
				}
				else
				{
					双目D2 = SlaveMatrix.GameClasses._Con.Get双眼R(右: false);
					頭D2.目左接続(双目D2);
					頭D2.目右接続(双目D3 = (双目D)双目D2.Get逆());
					眉D 眉D3 = SlaveMatrix.GameClasses._Con.Get眉R(右: false);
					頭D2.眉左接続(眉D3);
					頭D2.眉右接続(眉D3.Get逆());
				}
				縦目D2 = Mix<縦目D>(母方, 父方, i, 原種モード);
				縦瞼D2 = Mix<縦瞼D>(母方, 父方, i, 原種モード);
				if (縦目D2 != null && 縦瞼D2 != null)
				{
					縦目D2.瞼接続(縦瞼D2);
					頭D2.額接続(縦目D2);
				}
				else if (!原種モード && 変異率.Lot() && 0.05.Lot())
				{
					頭D2.額接続(縦目D2 = SlaveMatrix.GameClasses._Con.Get縦眼R());
					縦瞼D2 = 縦目D2.瞼_接続.GetEleD<縦瞼D>();
				}
				頬目D2 = Mix<頬目D>(母方, 父方, 右: false, i, 原種モード);
				頬瞼D 頬瞼D2 = Mix<頬瞼D>(母方, 父方, 右: false, i, 原種モード);
				if (頬目D2 != null && 頬瞼D2 != null)
				{
					頬目D2.瞼接続(頬瞼D2);
					頭D2.頬肌左接続(頬目D2);
					頭D2.頬肌右接続(頬目D3 = (頬目D)頬目D2.Get逆());
				}
				else if (!原種モード && 変異率.Lot() && 0.05.Lot())
				{
					頬目D2 = SlaveMatrix.GameClasses._Con.Get頬眼R(右: false);
					頭D2.頬肌左接続(頬目D2);
					頭D2.頬肌右接続(頬目D3 = (頬目D)頬目D2.Get逆());
				}
			}
			else
			{
				単目D2 = Mix<単目D>(母方, 父方, i, 原種モード);
				単瞼D2 = Mix<単瞼D>(母方, 父方, i, 原種モード);
				単眼眉D 単眼眉D2 = Mix<単眼眉D>(母方, 父方, i, 原種モード);
				if (単目D2 != null && 単瞼D2 != null && 単眼眉D2 != null)
				{
					単目D2.瞼接続(単瞼D2);
					単目D2.瞼接続(new 涙D
					{
						基準C = new Vector2D(0.01, 0.0)
					});
					単目D2.瞼接続(new 涙D
					{
						右 = true,
						基準C = new Vector2D(-0.01, 0.0)
					});
					頭D2.単眼目接続(単目D2);
					頭D2.単眼眉接続(単眼眉D2);
				}
				else
				{
					頭D2.単眼目接続(単目D2 = SlaveMatrix.GameClasses._Con.Get単眼R());
					単瞼D2 = 単目D2.瞼_接続.GetEleD<単瞼D>();
					頭D2.単眼眉接続(SlaveMatrix.GameClasses._Con.Get単眼眉R());
				}
			}
		}
		else if (flag)
		{
			双目D2 = Mix<双目D>(母方, 父方, 右: false, i, 原種モード);
			双瞼D 双瞼D3 = Mix<双瞼D>(母方, 父方, 右: false, i, 原種モード);
			眉D 眉D4 = Mix<眉D>(母方, 父方, 右: false, i, 原種モード);
			if (双目D2 != null && 双瞼D3 != null && 眉D4 != null)
			{
				if (原種モード || !変異率.Lot() || !0.05.Lot())
				{
					双目D2.瞼接続(双瞼D3);
					双目D2.瞼接続(new 涙D());
					頭D2.目左接続(双目D2);
					頭D2.目右接続(双目D3 = (双目D)双目D2.Get逆());
				}
				頭D2.眉左接続(眉D4);
				頭D2.眉右接続(眉D4.Get逆());
			}
			else
			{
				双目D2 = SlaveMatrix.GameClasses._Con.Get双眼R(右: false);
				頭D2.目左接続(双目D2);
				頭D2.目右接続(双目D3 = (双目D)双目D2.Get逆());
				眉D 眉D5 = SlaveMatrix.GameClasses._Con.Get眉R(右: false);
				頭D2.眉左接続(眉D5);
				頭D2.眉右接続(眉D5.Get逆());
			}
			縦目D2 = Mix<縦目D>(母方, 父方, i, 原種モード);
			縦瞼D2 = Mix<縦瞼D>(母方, 父方, i, 原種モード);
			if (縦目D2 != null && 縦瞼D2 != null)
			{
				縦目D2.瞼接続(縦瞼D2);
				頭D2.額接続(縦目D2);
			}
			else if (!原種モード && 変異率.Lot() && 0.05.Lot())
			{
				頭D2.額接続(縦目D2 = SlaveMatrix.GameClasses._Con.Get縦眼R());
				縦瞼D2 = 縦目D2.瞼_接続.GetEleD<縦瞼D>();
			}
			頬目D2 = Mix<頬目D>(母方, 父方, 右: false, i, 原種モード);
			頬瞼D 頬瞼D3 = Mix<頬瞼D>(母方, 父方, 右: false, i, 原種モード);
			if (頬目D2 != null && 頬瞼D3 != null)
			{
				頬目D2.瞼接続(頬瞼D3);
				頭D2.頬肌左接続(頬目D2);
				頭D2.頬肌右接続(頬目D3 = (頬目D)頬目D2.Get逆());
			}
			else if (!原種モード && 変異率.Lot() && 0.05.Lot())
			{
				頬目D2 = SlaveMatrix.GameClasses._Con.Get頬眼R(右: false);
				頭D2.頬肌左接続(頬目D2);
				頭D2.頬肌右接続(頬目D3 = (頬目D)頬目D2.Get逆());
			}
		}
		else if (flag2)
		{
			単目D2 = Mix<単目D>(母方, 父方, i, 原種モード);
			単瞼D2 = Mix<単瞼D>(母方, 父方, i, 原種モード);
			単眼眉D 単眼眉D3 = Mix<単眼眉D>(母方, 父方, i, 原種モード);
			if (単目D2 != null && 単瞼D2 != null && 単眼眉D3 != null)
			{
				単目D2.瞼接続(単瞼D2);
				単目D2.瞼接続(new 涙D
				{
					基準C = new Vector2D(0.01, 0.0)
				});
				単目D2.瞼接続(new 涙D
				{
					右 = true,
					基準C = new Vector2D(-0.01, 0.0)
				});
				頭D2.単眼目接続(単目D2);
				頭D2.単眼眉接続(単眼眉D3);
			}
			else
			{
				頭D2.単眼目接続(単目D2 = SlaveMatrix.GameClasses._Con.Get単眼R());
				単瞼D2 = 単目D2.瞼_接続.GetEleD<単瞼D>();
				頭D2.単眼眉接続(SlaveMatrix.GameClasses._Con.Get単眼眉R());
			}
		}
		鼻D 鼻D2 = Mix<鼻D>(母方, 父方, i, 原種モード);
		if (鼻D2 != null)
		{
			鼻D2.鼻水左接続(new 鼻水D());
			鼻D2.鼻水右接続(new 鼻水D
			{
				右 = true
			});
			頭D2.鼻接続(鼻D2);
		}
		口D 口D2 = Mix<口D>(母方, 父方, i, 原種モード);
		if (口D2 != null)
		{
			if (口D2 is 口_通常D)
			{
				頭D2.口接続(口D2);
				頭D2.口接続(new 涎_通常D());
				頭D2.口接続(new 涎_通常D
				{
					右 = true
				});
			}
			else if (口D2 is 口_裂けD)
			{
				頭D2.口接続(口D2);
				頭D2.口接続(new 涎_裂けD());
				頭D2.口接続(new 涎_裂けD
				{
					右 = true
				});
			}
			頭D2.口接続(new 性器精液_人D());
			頭D2.口接続(new 咳D());
			頭D2.口接続(new 呼気D());
			舌D 舌D2 = Mix<舌D>(母方, 父方, i, 原種モード);
			if (舌D2 != null)
			{
				頭D2.口接続(舌D2);
			}
		}
		頭D2.接続(母方, 父方, i, ConnectionInfo.頭_耳左_接続, 要素構成, 接続構成, 変異率, 原種モード);
		基髪D2.接続(母方, 父方, i, ConnectionInfo.基髪_頭頂左_接続, 要素構成, 接続構成, 変異率, 原種モード);
		頭D2.接続(母方, 父方, i, ConnectionInfo.頭_頬左_接続, 要素構成, 接続構成, 変異率, 原種モード);
		頭D2.接続(母方, 父方, i, ConnectionInfo.頭_大顎基_接続, 要素構成, 接続構成, 変異率, 原種モード);
		頭D2.接続(母方, 父方, i, ConnectionInfo.頭_顔面_接続, 要素構成, 接続構成, 変異率, 原種モード);
		頭D2.接続(母方, 父方, i, ConnectionInfo.頭_頭頂_接続, 要素構成, 接続構成, 変異率, 原種モード);
		頭D2.接続(母方, 父方, i, ConnectionInfo.頭_触覚左_接続, 要素構成, 接続構成, 変異率, 原種モード);
		胸D2.接続(母方, 父方, i, ConnectionInfo.胸_肩左_接続, 要素構成, 接続構成, 変異率, 原種モード);
		頭D2.接続(母方, 父方, i, ConnectionInfo.頭_額_接続, 要素構成, 接続構成, 変異率, 原種モード);
		胸D2.接続(母方, 父方, i, ConnectionInfo.胸_翼上左_接続, 要素構成, 接続構成, 変異率, 原種モード);
		胸D2.接続(母方, 父方, i, ConnectionInfo.胸_翼下左_接続, 要素構成, 接続構成, 変異率, 原種モード);
		胴D2.接続(母方, 父方, i, ConnectionInfo.胴_翼左_接続, 要素構成, 接続構成, 変異率, 原種モード);
		腰.接続(母方, 父方, i, ConnectionInfo.腰_翼左_接続, 要素構成, 接続構成, 変異率, 原種モード);
		if (原種モード)
		{
			胸D2.接続(母方, 父方, i, ConnectionInfo.胸_背中_接続, 要素構成, 接続構成, 変異率, 原種モード);
		}
		else
		{
			EleD eleD3 = Mix<背中D>(母方, 父方, i, 原種モード);
			string t;
			if (eleD3 != null)
			{
				t = eleD3.GetType().ToString();
				if (!胸D2.背中_接続.Any((EleD e) => e.GetType().ToString() == t) && RNG.XS.NextBool())
				{
					胸D2.背中接続(eleD3);
				}
			}
			eleD3 = Mix<背中D>(母方, 父方, i, 原種モード);
			if (eleD3 != null)
			{
				t = eleD3.GetType().ToString();
				if (!胸D2.背中_接続.Any((EleD e) => e.GetType().ToString() == t) && RNG.XS.NextBool())
				{
					胸D2.背中接続(eleD3);
				}
			}
			eleD3 = Mix<背中D>(母方, 父方, i, 原種モード);
			if (eleD3 != null)
			{
				t = eleD3.GetType().ToString();
				if (!胸D2.背中_接続.Any((EleD e) => e.GetType().ToString() == t) && RNG.XS.NextBool())
				{
					胸D2.背中接続(eleD3);
				}
			}
		}
		半身D 半身 = Mix<半身D>(母方, 父方, i, 原種モード);
		Action action = delegate
		{
			腰.半身接続(半身);
			半身.AlignR();
			if (半身 is 長物_魚D)
			{
				長物_魚D 長物_魚D2 = (長物_魚D)半身;
				長物_魚D2.接続(母方, 父方, i, ConnectionInfo.長物_魚_左0_接続, 要素構成, 接続構成, 変異率, 原種モード);
				長物_魚D2.接続(母方, 父方, i, ConnectionInfo.長物_魚_左6_接続, 要素構成, 接続構成, 変異率, 原種モード);
				長物_魚D2.接続(母方, 父方, i, ConnectionInfo.長物_魚_尾_接続, 要素構成, 接続構成, 変異率, 原種モード);
				if (長物_魚D2.尾_接続.Count > 0)
				{
					foreach (EleD item in 長物_魚D2.尾_接続)
					{
						item.AlignR();
					}
				}
				double 尺度B2 = 長物_魚D2.尺度B;
				foreach (EleD item2 in 長物_魚D2.左0_接続)
				{
					item2.尺度B = 尺度B2;
				}
				foreach (EleD item3 in 長物_魚D2.右0_接続)
				{
					item3.尺度B = 尺度B2;
				}
				尺度B2 *= 0.9;
				尺度B2 *= 0.9;
				尺度B2 *= 0.9;
				尺度B2 *= 0.9;
				尺度B2 *= 0.9;
				尺度B2 *= 0.9;
				foreach (EleD item4 in 長物_魚D2.左6_接続)
				{
					item4.尺度B = 尺度B2;
				}
				foreach (EleD item5 in 長物_魚D2.右6_接続)
				{
					item5.尺度B = 尺度B2;
				}
				腰.接続(母方, 父方, i, ConnectionInfo.腰_腿左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				for (int num3 = 腰.腿左_接続.Count - 1; num3 > -1; num3--)
				{
					if (!(腰.腿左_接続[num3] is 触手_犬D))
					{
						腰.腿左_接続.RemoveAt(num3);
					}
				}
				for (int num4 = 腰.腿右_接続.Count - 1; num4 > -1; num4--)
				{
					if (!(腰.腿右_接続[num4] is 触手_犬D))
					{
						腰.腿右_接続.RemoveAt(num4);
					}
				}
				if (腰.腿左_接続.IsEleD<触手_犬D>())
				{
					for (int num5 = 腰.翼左_接続.Count - 1; num5 > -1; num5--)
					{
						if (腰.翼左_接続[num5] is 四足脇D)
						{
							腰.翼左_接続.RemoveAt(num5);
						}
					}
					for (int num6 = 腰.翼右_接続.Count - 1; num6 > -1; num6--)
					{
						if (腰.翼右_接続[num6] is 四足脇D)
						{
							腰.翼右_接続.RemoveAt(num6);
						}
					}
				}
			}
			else if (半身 is 長物_鯨D)
			{
				長物_鯨D 鯨 = (長物_鯨D)半身;
				鯨.接続(母方, 父方, i, ConnectionInfo.長物_鯨_左0_接続, 要素構成, 接続構成, 変異率, 原種モード);
				鯨.接続(母方, 父方, i, ConnectionInfo.長物_鯨_左6_接続, 要素構成, 接続構成, 変異率, 原種モード);
				鯨.接続(母方, 父方, i, ConnectionInfo.長物_鯨_尾_接続, 要素構成, 接続構成, 変異率, 原種モード);
				if (鯨.尾_接続.Count > 0)
				{
					foreach (EleD item6 in 鯨.尾_接続)
					{
						item6.AlignR();
					}
				}
				鯨.尾_接続.SetEleD(delegate(尾_鯨D e)
				{
					e.柄 = 鯨.柄;
				});
				double 尺度B3 = 鯨.尺度B;
				foreach (EleD item7 in 鯨.左0_接続)
				{
					item7.尺度B = 尺度B3;
				}
				foreach (EleD item8 in 鯨.右0_接続)
				{
					item8.尺度B = 尺度B3;
				}
				尺度B3 *= 0.9;
				尺度B3 *= 0.9;
				尺度B3 *= 0.9;
				尺度B3 *= 0.9;
				尺度B3 *= 0.9;
				尺度B3 *= 0.9;
				foreach (EleD item9 in 鯨.左6_接続)
				{
					item9.尺度B = 尺度B3;
				}
				foreach (EleD item10 in 鯨.右6_接続)
				{
					item10.尺度B = 尺度B3;
				}
				腰.接続(母方, 父方, i, ConnectionInfo.腰_腿左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				for (int num7 = 腰.腿左_接続.Count - 1; num7 > -1; num7--)
				{
					if (!(腰.腿左_接続[num7] is 触手_犬D))
					{
						腰.腿左_接続.RemoveAt(num7);
					}
				}
				for (int num8 = 腰.腿右_接続.Count - 1; num8 > -1; num8--)
				{
					if (!(腰.腿右_接続[num8] is 触手_犬D))
					{
						腰.腿右_接続.RemoveAt(num8);
					}
				}
				if (腰.腿左_接続.IsEleD<触手_犬D>())
				{
					for (int num9 = 腰.翼左_接続.Count - 1; num9 > -1; num9--)
					{
						if (腰.翼左_接続[num9] is 四足脇D)
						{
							腰.翼左_接続.RemoveAt(num9);
						}
					}
					for (int num10 = 腰.翼右_接続.Count - 1; num10 > -1; num10--)
					{
						if (腰.翼右_接続[num10] is 四足脇D)
						{
							腰.翼右_接続.RemoveAt(num10);
						}
					}
				}
			}
			else if (半身 is 長物_蛇D)
			{
				長物_蛇D 長物_蛇D2 = (長物_蛇D)半身;
				長物_蛇D2.接続(母方, 父方, i, ConnectionInfo.長物_蛇_左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				胴_蛇D 胴_蛇D2 = Mix<胴_蛇D>(母方, 父方, i, 原種モード);
				if (胴_蛇D2 != null)
				{
					胴_蛇D2.接続(母方, 父方, i, ConnectionInfo.胴_蛇_左_接続, 要素構成, 接続構成, 変異率, 原種モード);
					長胴D 長胴D2 = (長胴D)胴_蛇D2.Copy();
					長物_蛇D2.胴接続(胴_蛇D2);
					int num11 = 2;
					int num12 = 母方.EnumEleD().Count((EleD e) => e is 長胴D);
					int num13 = 父方.EnumEleD().Count((EleD e) => e is 長胴D);
					num11 = (RNG.XS.NextBool() ? ((int)((double)(num12 + num13) * 0.5)) : ((!RNG.XS.NextBool()) ? num13 : num12));
					num11 = (num11 + RNG.XS.NextSign() * RNG.XS.Next(4)).Clamp(0, 50);
					for (int l = 0; l < num11; l++)
					{
						胴_蛇D2.胴接続(胴_蛇D2 = (胴_蛇D)長胴D2.Copy());
					}
					胴_蛇D2.接続(母方, 父方, i, ConnectionInfo.胴_蛇_胴_接続, 要素構成, 接続構成, 変異率, 原種モード);
					if (胴_蛇D2.EnumEleD().IsEleD<腿D>())
					{
						IEnumerable<胴_蛇D> eleDs = 長物_蛇D2.EnumEleD().Skip(1).GetEleDs<胴_蛇D>();
						foreach (胴_蛇D item11 in eleDs.Take(eleDs.Count() - 1))
						{
							item11.左_接続.Clear();
							item11.右_接続.Clear();
						}
						if (num11 < 2)
						{
							胴_蛇D obj = eleDs.Last();
							obj.左_接続.Clear();
							obj.右_接続.Clear();
						}
					}
					else
					{
						int num14 = 0;
						foreach (胴_蛇D eleD7 in 長物_蛇D2.EnumEleD().Skip(1).GetEleDs<胴_蛇D>())
						{
							if (num14 % 3 != 1)
							{
								eleD7.左_接続.Clear();
								eleD7.右_接続.Clear();
							}
							num14++;
						}
					}
				}
				else
				{
					長物_蛇D2.接続(母方, 父方, i, ConnectionInfo.長物_蛇_胴_接続, 要素構成, 接続構成, 変異率, 原種モード);
				}
				長物_蛇D2.AlignC();
				if (長物_蛇D2.ガード)
				{
					腰肌.竜性_鱗1_表示 = false;
					腰肌.竜性_鱗2_表示 = false;
					腰肌.竜性_鱗3_表示 = false;
					腰肌.竜性_鱗4_表示 = false;
					腰肌.獣性_獣毛_表示 = false;
					腰肌.陰毛_表示 = false;
				}
				腰.接続(母方, 父方, i, ConnectionInfo.腰_腿左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				for (int num15 = 腰.腿左_接続.Count - 1; num15 > -1; num15--)
				{
					if (!(腰.腿左_接続[num15] is 触手_犬D))
					{
						腰.腿左_接続.RemoveAt(num15);
					}
				}
				for (int num16 = 腰.腿右_接続.Count - 1; num16 > -1; num16--)
				{
					if (!(腰.腿右_接続[num16] is 触手_犬D))
					{
						腰.腿右_接続.RemoveAt(num16);
					}
				}
				if (腰.腿左_接続.IsEleD<触手_犬D>())
				{
					for (int num17 = 腰.翼左_接続.Count - 1; num17 > -1; num17--)
					{
						if (腰.翼左_接続[num17] is 四足脇D)
						{
							腰.翼左_接続.RemoveAt(num17);
						}
					}
					for (int num18 = 腰.翼右_接続.Count - 1; num18 > -1; num18--)
					{
						if (腰.翼右_接続[num18] is 四足脇D)
						{
							腰.翼右_接続.RemoveAt(num18);
						}
					}
				}
			}
			else if (半身 is 長物_蟲D)
			{
				長物_蟲D 長物_蟲D2 = (長物_蟲D)半身;
				長物_蟲D2.接続(母方, 父方, i, ConnectionInfo.長物_蟲_左0_接続, 要素構成, 接続構成, 変異率, 原種モード);
				長物_蟲D2.接続(母方, 父方, i, ConnectionInfo.長物_蟲_左1_接続, 要素構成, 接続構成, 変異率, 原種モード);
				胴_蟲D 胴_蟲D2 = Mix<胴_蟲D>(母方, 父方, i, 原種モード);
				if (胴_蟲D2 != null)
				{
					胴_蟲D2.接続(母方, 父方, i, ConnectionInfo.胴_蟲_左_接続, 要素構成, 接続構成, 変異率, 原種モード);
					長胴D 長胴D3 = (長胴D)胴_蟲D2.Copy();
					長物_蟲D2.胴接続(胴_蟲D2);
					int num19 = 2;
					int num20 = 母方.EnumEleD().Count((EleD e) => e is 長胴D);
					int num21 = 父方.EnumEleD().Count((EleD e) => e is 長胴D);
					num19 = (RNG.XS.NextBool() ? ((int)((double)(num20 + num21) * 0.5)) : ((!RNG.XS.NextBool()) ? num21 : num20));
					num19 = (num19 + RNG.XS.NextSign() * RNG.XS.Next(4)).Clamp(0, 50);
					for (int m = 0; m < num19; m++)
					{
						胴_蟲D2.胴接続(胴_蟲D2 = (胴_蟲D)長胴D3.Copy());
					}
					胴_蟲D2.接続(母方, 父方, i, ConnectionInfo.胴_蟲_胴_接続, 要素構成, 接続構成, 変異率, 原種モード);
				}
				else
				{
					長物_蟲D2.接続(母方, 父方, i, ConnectionInfo.長物_蟲_胴_接続, 要素構成, 接続構成, 変異率, 原種モード);
				}
				長物_蟲D2.AlignC();
				腰.翼左_接続.RemoveAll((EleD e) => e is 四足脇D);
				腰.翼右_接続.RemoveAll((EleD e) => e is 四足脇D);
			}
			else if (半身 is 四足胸D)
			{
				四足胸D 四足胸D2 = (四足胸D)半身;
				胸毛D 胸毛D2 = null;
				胸肌D 胸肌D2 = null;
				四足胸D2.肌接続(胸毛D2 = Mix<胸毛D>(母方, 父方, i, 原種モード));
				四足胸D2.肌接続(胸肌D2 = Mix<胸肌D>(母方, 父方, i, 原種モード));
				四足胸D2.AlignC();
				if (胸毛D2 != null)
				{
					胸毛D2.尺度B *= 1.4;
				}
				if (胸肌D2 != null)
				{
					胸肌D2.尺度B *= 1.3;
					胸肌D2.蜘蛛_眼左2_基_表示 = false;
					胸肌D2.蜘蛛_眼左2_眼_表示 = false;
					胸肌D2.蜘蛛_眼左2_ハイライト_表示 = false;
					胸肌D2.蜘蛛_眼右2_基_表示 = false;
					胸肌D2.蜘蛛_眼右2_眼_表示 = false;
					胸肌D2.蜘蛛_眼右2_ハイライト_表示 = false;
				}
				四足胸D2.肥大 = 腰.肥大;
				四足胴D 四足胴D2 = Mix<四足胴D>(母方, 父方, i, 原種モード);
				if (四足胴D2 != null)
				{
					胴肌D 胴肌D2 = null;
					四足胴D2.肌接続(胴肌D2 = Mix<胴肌D>(母方, 父方, i, 原種モード));
					四足胴D2.AlignC();
					if (胴肌D2 != null)
					{
						胴肌D2.尺度B *= 1.35;
					}
					四足胸D2.胴接続(四足胴D2);
					四足胴D2.肥大 = 腰.肥大;
				}
				四足腰D 四足腰D2 = Mix<四足腰D>(母方, 父方, i, 原種モード);
				if (四足腰D2 != null)
				{
					腰肌D 腰肌D2 = null;
					四足腰D2.膣基接続(new 膣基_獣D());
					四足腰D2.膣基接続(new 膣内精液_獣D());
					四足腰D2.膣基接続(new 断面_獣D());
					四足腰D2.膣基接続(Uni.四足性器());
					四足腰D2.肛門接続(Uni.四足肛門());
					四足腰D2.肌接続(new ボテ腹_獣D());
					四足腰D2.肌接続(腰肌D2 = Mix<腰肌D>(母方, 父方, i, 原種モード));
					腰.膣基_接続.SetEleD(delegate(性器_人D e)
					{
						e.表示 = false;
					});
					腰.肛門_接続.SetEleD(delegate(肛門_人D e)
					{
						e.表示 = false;
					});
					四足腰D2.肌_接続.SetEleD(delegate(腰肌D e)
					{
						e.陰毛_表示 = false;
					});
					四足腰D2.AlignC();
					if (腰肌D2 != null)
					{
						腰肌D2.尺度B *= 1.4;
						腰肌D2.虫性_腹板1_腹板_表示 = false;
						腰肌D2.虫性_腹板2_腹板_表示 = false;
						腰肌D2.虫性_腹板1_縦線_表示 = false;
						腰肌D2.虫性_腹板2_縦線_表示 = false;
						腰肌D2.陰毛_表示 = false;
					}
					四足胴D2.腰接続(四足腰D2);
					四足腰D2.肥大 = 腰.肥大;
					if ((腰肌D2.淫タトゥ_ハート_タトゥ右1_表示 || 腰肌D2.淫タトゥ_ハート_タトゥ右2_表示 || 腰肌D2.淫タトゥ_ハート_タトゥ左1_表示 || 腰肌D2.淫タトゥ_ハート_タトゥ左2_表示) && (腰肌D2.植タトゥ_タトゥ左_表示 || 腰肌D2.植タトゥ_タトゥ右_表示))
					{
						if (RNG.XS.NextBool())
						{
							腰肌D2.淫タトゥ_ハート_タトゥ右1_表示 = true;
							腰肌D2.淫タトゥ_ハート_タトゥ右2_表示 = true;
							腰肌D2.淫タトゥ_ハート_タトゥ左1_表示 = true;
							腰肌D2.淫タトゥ_ハート_タトゥ左2_表示 = true;
							腰肌D2.植タトゥ_タトゥ左_表示 = false;
							腰肌D2.植タトゥ_タトゥ右_表示 = false;
						}
						else
						{
							腰肌D2.淫タトゥ_ハート_タトゥ右1_表示 = false;
							腰肌D2.淫タトゥ_ハート_タトゥ右2_表示 = false;
							腰肌D2.淫タトゥ_ハート_タトゥ左1_表示 = false;
							腰肌D2.淫タトゥ_ハート_タトゥ左2_表示 = false;
							腰肌D2.植タトゥ_タトゥ左_表示 = true;
							腰肌D2.植タトゥ_タトゥ右_表示 = true;
						}
					}
				}
				四足胸D2.接続(母方, 父方, i, ConnectionInfo.四足胸_脇左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				四足胸D2.接続(母方, 父方, i, ConnectionInfo.四足胸_翼上左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				四足胸D2.接続(母方, 父方, i, ConnectionInfo.四足胸_翼下左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				四足胴D2.接続(母方, 父方, i, ConnectionInfo.四足胴_翼左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				四足腰D2.接続(母方, 父方, i, ConnectionInfo.四足腰_翼左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				四足胸D2.接続(母方, 父方, i, ConnectionInfo.四足胸_背中_接続, 要素構成, 接続構成, 変異率, 原種モード);
				四足腰D2.接続(母方, 父方, i, ConnectionInfo.四足腰_腿左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				四足腰D2.接続(母方, 父方, i, ConnectionInfo.四足腰_尾_接続, 要素構成, 接続構成, 変異率, 原種モード);
				腰.翼左_接続.RemoveAll((EleD e) => e is 四足脇D);
				腰.翼右_接続.RemoveAll((EleD e) => e is 四足脇D);
			}
			else if (半身 is 多足_蛸D)
			{
				多足_蛸D obj2 = (多足_蛸D)半身;
				obj2.接続(母方, 父方, i, ConnectionInfo.多足_蛸_軟体外左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				obj2.接続(母方, 父方, i, ConnectionInfo.多足_蛸_軟体内左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				obj2.軟体内左_接続.SetEleDs(delegate(触手_軟D e)
				{
					e.前足 = false;
					e.後足 = true;
				});
				obj2.軟体内右_接続.SetEleDs(delegate(触手_軟D e)
				{
					e.前足 = false;
					e.後足 = true;
				});
				obj2.軟体外左_接続.SetEleDs(delegate(触手_軟D e)
				{
					e.前足 = true;
					e.後足 = false;
				});
				obj2.軟体外右_接続.SetEleDs(delegate(触手_軟D e)
				{
					e.前足 = true;
					e.後足 = false;
				});
				腰.接続(母方, 父方, i, ConnectionInfo.腰_腿左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				腰.接続(母方, 父方, i, ConnectionInfo.腰_尾_接続, 要素構成, 接続構成, 変異率, 原種モード);
				for (int num22 = 腰.腿左_接続.Count - 1; num22 > -1; num22--)
				{
					if (!(腰.腿左_接続[num22] is 触手_犬D))
					{
						腰.腿左_接続.RemoveAt(num22);
					}
				}
				for (int num23 = 腰.腿右_接続.Count - 1; num23 > -1; num23--)
				{
					if (!(腰.腿右_接続[num23] is 触手_犬D))
					{
						腰.腿右_接続.RemoveAt(num23);
					}
				}
				if (腰.腿左_接続.IsEleD<触手_犬D>())
				{
					for (int num24 = 腰.翼左_接続.Count - 1; num24 > -1; num24--)
					{
						if (腰.翼左_接続[num24] is 四足脇D)
						{
							腰.翼左_接続.RemoveAt(num24);
						}
					}
					for (int num25 = 腰.翼右_接続.Count - 1; num25 > -1; num25--)
					{
						if (腰.翼右_接続[num25] is 四足脇D)
						{
							腰.翼右_接続.RemoveAt(num25);
						}
					}
				}
			}
			else if (半身 is 多足_蜘D)
			{
				多足_蜘D 多足_蜘D2 = (多足_蜘D)半身;
				多足_蜘D2.接続(母方, 父方, i, ConnectionInfo.多足_蜘_触肢左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				多足_蜘D2.接続(母方, 父方, i, ConnectionInfo.多足_蜘_節足左1_接続, 要素構成, 接続構成, 変異率, 原種モード);
				多足_蜘D2.接続(母方, 父方, i, ConnectionInfo.多足_蜘_節足左2_接続, 要素構成, 接続構成, 変異率, 原種モード);
				多足_蜘D2.接続(母方, 父方, i, ConnectionInfo.多足_蜘_節足左3_接続, 要素構成, 接続構成, 変異率, 原種モード);
				多足_蜘D2.接続(母方, 父方, i, ConnectionInfo.多足_蜘_節足左4_接続, 要素構成, 接続構成, 変異率, 原種モード);
				多足_蜘D2.接続(母方, 父方, i, ConnectionInfo.多足_蜘_尾_接続, 要素構成, 接続構成, 変異率, 原種モード);
				節足_足蜘D eleD5 = 多足_蜘D2.節足左1_接続.GetEleD<節足_足蜘D>();
				bool 柄1_表示 = eleD5?.柄1_表示 ?? false;
				bool 柄2_表示 = eleD5?.柄2_表示 ?? false;
				bool 爪 = eleD5?.爪 ?? false;
				foreach (EleD item12 in 多足_蜘D2.触肢左_接続)
				{
					if (item12 is 節尾_鋏D || item12 is 大顎D)
					{
						item12.反転Y = true;
					}
					else
					{
						item12.反転Y = false;
					}
				}
				foreach (EleD item13 in 多足_蜘D2.触肢右_接続)
				{
					if (item13 is 節尾_鋏D || item13 is 大顎D)
					{
						item13.反転Y = true;
					}
					else
					{
						item13.反転Y = false;
					}
				}
				foreach (EleD item14 in 多足_蜘D2.節足左1_接続)
				{
					if (item14 is 節足_足蜘D)
					{
						eleD5 = (節足_足蜘D)item14;
						eleD5.柄1_表示 = 柄1_表示;
						eleD5.柄2_表示 = 柄2_表示;
						eleD5.爪 = 爪;
						item14.反転Y = false;
					}
					else if (item14 is 節足_足百D)
					{
						item14.反転Y = true;
					}
					else
					{
						item14.反転Y = false;
					}
				}
				foreach (EleD item15 in 多足_蜘D2.節足右1_接続)
				{
					if (item15 is 節足_足蜘D)
					{
						eleD5 = (節足_足蜘D)item15;
						eleD5.柄1_表示 = 柄1_表示;
						eleD5.柄2_表示 = 柄2_表示;
						eleD5.爪 = 爪;
						item15.反転Y = false;
					}
					else if (item15 is 節足_足百D)
					{
						item15.反転Y = true;
					}
					else
					{
						item15.反転Y = false;
					}
				}
				foreach (EleD item16 in 多足_蜘D2.節足左2_接続)
				{
					if (item16 is 節足_足蜘D)
					{
						eleD5 = (節足_足蜘D)item16;
						eleD5.柄1_表示 = 柄1_表示;
						eleD5.柄2_表示 = 柄2_表示;
						eleD5.爪 = 爪;
						item16.反転Y = false;
					}
					else if (item16 is 節足_足百D)
					{
						item16.反転Y = true;
					}
					else
					{
						item16.反転Y = false;
					}
				}
				foreach (EleD item17 in 多足_蜘D2.節足右2_接続)
				{
					if (item17 is 節足_足蜘D)
					{
						eleD5 = (節足_足蜘D)item17;
						eleD5.柄1_表示 = 柄1_表示;
						eleD5.柄2_表示 = 柄2_表示;
						eleD5.爪 = 爪;
						item17.反転Y = false;
					}
					else if (item17 is 節足_足百D)
					{
						item17.反転Y = true;
					}
					else
					{
						item17.反転Y = false;
					}
				}
				bool 反転Y = 多足_蜘D2.節足左3_接続.Count > 0 && 多足_蜘D2.節足左3_接続.First().反転Y;
				foreach (EleD item18 in 多足_蜘D2.節足左3_接続)
				{
					if (item18 is 節足_足蜘D)
					{
						eleD5 = (節足_足蜘D)item18;
						eleD5.柄1_表示 = 柄1_表示;
						eleD5.柄2_表示 = 柄2_表示;
						eleD5.爪 = 爪;
						item18.反転Y = 反転Y;
					}
					else if (item18 is 節足_足百D)
					{
						item18.反転Y = true;
					}
					else
					{
						item18.反転Y = 反転Y;
					}
				}
				foreach (EleD item19 in 多足_蜘D2.節足右3_接続)
				{
					if (item19 is 節足_足蜘D)
					{
						eleD5 = (節足_足蜘D)item19;
						eleD5.柄1_表示 = 柄1_表示;
						eleD5.柄2_表示 = 柄2_表示;
						eleD5.爪 = 爪;
						item19.反転Y = 反転Y;
					}
					else if (item19 is 節足_足百D)
					{
						item19.反転Y = true;
					}
					else
					{
						item19.反転Y = 反転Y;
					}
				}
				foreach (EleD item20 in 多足_蜘D2.節足左4_接続)
				{
					if (item20 is 節足_足蜘D)
					{
						eleD5 = (節足_足蜘D)item20;
						eleD5.柄1_表示 = 柄1_表示;
						eleD5.柄2_表示 = 柄2_表示;
						eleD5.爪 = 爪;
						item20.反転Y = 反転Y;
					}
					else if (item20 is 節足_足百D)
					{
						item20.反転Y = true;
					}
					else
					{
						item20.反転Y = 反転Y;
					}
				}
				foreach (EleD item21 in 多足_蜘D2.節足右4_接続)
				{
					if (item21 is 節足_足蜘D)
					{
						eleD5 = (節足_足蜘D)item21;
						eleD5.柄1_表示 = 柄1_表示;
						eleD5.柄2_表示 = 柄2_表示;
						eleD5.爪 = 爪;
						item21.反転Y = 反転Y;
					}
					else if (item21 is 節足_足百D)
					{
						item21.反転Y = true;
					}
					else
					{
						item21.反転Y = 反転Y;
					}
				}
				腰.翼左_接続.RemoveAll((EleD e) => e is 四足脇D);
				腰.翼右_接続.RemoveAll((EleD e) => e is 四足脇D);
			}
			else if (半身 is 多足_蠍D)
			{
				多足_蠍D 多足_蠍D2 = (多足_蠍D)半身;
				多足_蠍D2.接続(母方, 父方, i, ConnectionInfo.多足_蠍_触肢左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				多足_蠍D2.接続(母方, 父方, i, ConnectionInfo.多足_蠍_節足左1_接続, 要素構成, 接続構成, 変異率, 原種モード);
				多足_蠍D2.接続(母方, 父方, i, ConnectionInfo.多足_蠍_節足左2_接続, 要素構成, 接続構成, 変異率, 原種モード);
				多足_蠍D2.接続(母方, 父方, i, ConnectionInfo.多足_蠍_節足左3_接続, 要素構成, 接続構成, 変異率, 原種モード);
				多足_蠍D2.接続(母方, 父方, i, ConnectionInfo.多足_蠍_節足左4_接続, 要素構成, 接続構成, 変異率, 原種モード);
				多足_蠍D2.接続(母方, 父方, i, ConnectionInfo.多足_蠍_櫛状板左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				多足_蠍D2.接続(母方, 父方, i, ConnectionInfo.多足_蠍_尾_接続, 要素構成, 接続構成, 変異率, 原種モード);
				節足_足蠍D eleD6 = 多足_蠍D2.節足左1_接続.GetEleD<節足_足蠍D>();
				bool 柄1_表示2 = eleD6?.柄1_表示 ?? false;
				bool 爪2 = eleD6?.爪 ?? false;
				foreach (EleD item22 in 多足_蠍D2.触肢左_接続)
				{
					if (item22 is 節尾_鋏D || item22 is 大顎D)
					{
						item22.反転Y = true;
					}
					else
					{
						item22.反転Y = false;
					}
				}
				foreach (EleD item23 in 多足_蠍D2.触肢右_接続)
				{
					if (item23 is 節尾_鋏D || item23 is 大顎D)
					{
						item23.反転Y = true;
					}
					else
					{
						item23.反転Y = false;
					}
				}
				foreach (EleD item24 in 多足_蠍D2.節足左1_接続)
				{
					if (item24 is 節足_足蠍D)
					{
						eleD6 = (節足_足蠍D)item24;
						eleD6.柄1_表示 = 柄1_表示2;
						eleD6.爪 = 爪2;
					}
					else if (item24 is 節足_足百D)
					{
						item24.反転Y = true;
					}
				}
				foreach (EleD item25 in 多足_蠍D2.節足右1_接続)
				{
					if (item25 is 節足_足蠍D)
					{
						eleD6 = (節足_足蠍D)item25;
						eleD6.柄1_表示 = 柄1_表示2;
						eleD6.爪 = 爪2;
					}
					else if (item25 is 節足_足百D)
					{
						item25.反転Y = true;
					}
				}
				foreach (EleD item26 in 多足_蠍D2.節足左2_接続)
				{
					if (item26 is 節足_足蠍D)
					{
						eleD6 = (節足_足蠍D)item26;
						eleD6.柄1_表示 = 柄1_表示2;
						eleD6.爪 = 爪2;
					}
					else if (item26 is 節足_足百D)
					{
						item26.反転Y = true;
					}
				}
				foreach (EleD item27 in 多足_蠍D2.節足右2_接続)
				{
					if (item27 is 節足_足蠍D)
					{
						eleD6 = (節足_足蠍D)item27;
						eleD6.柄1_表示 = 柄1_表示2;
						eleD6.爪 = 爪2;
					}
					else if (item27 is 節足_足百D)
					{
						item27.反転Y = true;
					}
				}
				foreach (EleD item28 in 多足_蠍D2.節足左3_接続)
				{
					if (item28 is 節足_足蠍D)
					{
						eleD6 = (節足_足蠍D)item28;
						eleD6.柄1_表示 = 柄1_表示2;
						eleD6.爪 = 爪2;
					}
					else if (item28 is 節足_足百D)
					{
						item28.反転Y = true;
					}
				}
				foreach (EleD item29 in 多足_蠍D2.節足右3_接続)
				{
					if (item29 is 節足_足蠍D)
					{
						eleD6 = (節足_足蠍D)item29;
						eleD6.柄1_表示 = 柄1_表示2;
						eleD6.爪 = 爪2;
					}
					else if (item29 is 節足_足百D)
					{
						item29.反転Y = true;
					}
				}
				foreach (EleD item30 in 多足_蠍D2.節足左4_接続)
				{
					if (item30 is 節足_足蠍D)
					{
						eleD6 = (節足_足蠍D)item30;
						eleD6.柄1_表示 = 柄1_表示2;
						eleD6.爪 = 爪2;
					}
					else if (item30 is 節足_足百D)
					{
						item30.反転Y = true;
					}
				}
				foreach (EleD item31 in 多足_蠍D2.節足右4_接続)
				{
					if (item31 is 節足_足蠍D)
					{
						eleD6 = (節足_足蠍D)item31;
						eleD6.柄1_表示 = 柄1_表示2;
						eleD6.爪 = 爪2;
					}
					else if (item31 is 節足_足百D)
					{
						item31.反転Y = true;
					}
				}
				腰.翼左_接続.RemoveAll((EleD e) => e is 四足脇D);
				腰.翼右_接続.RemoveAll((EleD e) => e is 四足脇D);
			}
			else if (半身 is 単足_植D)
			{
				単足_植D e5 = (単足_植D)半身;
				e5.接続(母方, 父方, i, ConnectionInfo.単足_植_根外左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				e5.接続(母方, 父方, i, ConnectionInfo.単足_植_根内左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				e5.接続(母方, 父方, i, ConnectionInfo.単足_植_根中央_接続, 要素構成, 接続構成, 変異率, 原種モード);
				腰.接続(母方, 父方, i, ConnectionInfo.腰_腿左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				for (int num26 = 腰.腿左_接続.Count - 1; num26 > -1; num26--)
				{
					if (!(腰.腿左_接続[num26] is 触手_犬D))
					{
						腰.腿左_接続.RemoveAt(num26);
					}
				}
				for (int num27 = 腰.腿右_接続.Count - 1; num27 > -1; num27--)
				{
					if (!(腰.腿右_接続[num27] is 触手_犬D))
					{
						腰.腿右_接続.RemoveAt(num27);
					}
				}
				if (腰.腿左_接続.IsEleD<触手_犬D>())
				{
					for (int num28 = 腰.翼左_接続.Count - 1; num28 > -1; num28--)
					{
						if (腰.翼左_接続[num28] is 四足脇D)
						{
							腰.翼左_接続.RemoveAt(num28);
						}
					}
					for (int num29 = 腰.翼右_接続.Count - 1; num29 > -1; num29--)
					{
						if (腰.翼右_接続[num29] is 四足脇D)
						{
							腰.翼右_接続.RemoveAt(num29);
						}
					}
				}
				腿_人D 腿_人D2 = Mix<腿_人D>(母方, 父方, 右: false, i, 原種モード);
				if (腿_人D2 != null)
				{
					腰.腿左接続(腿_人D2);
					腰.腿右接続(腿_人D2.Get逆());
				}
				腰.接続(母方, 父方, i, ConnectionInfo.腰_尾_接続, 要素構成, 接続構成, 変異率, 原種モード);
			}
			else if (半身 is 単足_粘D)
			{
				_ = (単足_粘D)半身;
				腰.接続(母方, 父方, i, ConnectionInfo.腰_腿左_接続, 要素構成, 接続構成, 変異率, 原種モード);
				for (int num30 = 腰.腿左_接続.Count - 1; num30 > -1; num30--)
				{
					if (!(腰.腿左_接続[num30] is 触手_犬D))
					{
						腰.腿左_接続.RemoveAt(num30);
					}
				}
				for (int num31 = 腰.腿右_接続.Count - 1; num31 > -1; num31--)
				{
					if (!(腰.腿右_接続[num31] is 触手_犬D))
					{
						腰.腿右_接続.RemoveAt(num31);
					}
				}
				if (腰.腿左_接続.IsEleD<触手_犬D>())
				{
					for (int num32 = 腰.翼左_接続.Count - 1; num32 > -1; num32--)
					{
						if (腰.翼左_接続[num32] is 四足脇D)
						{
							腰.翼左_接続.RemoveAt(num32);
						}
					}
					for (int num33 = 腰.翼右_接続.Count - 1; num33 > -1; num33--)
					{
						if (腰.翼右_接続[num33] is 四足脇D)
						{
							腰.翼右_接続.RemoveAt(num33);
						}
					}
				}
				腿_人D 腿_人D3 = Mix<腿_人D>(母方, 父方, 右: false, i, 原種モード);
				if (腿_人D3 != null)
				{
					腰.腿左接続(腿_人D3);
					腰.腿右接続(腿_人D3.Get逆());
				}
				腰.接続(母方, 父方, i, ConnectionInfo.腰_尾_接続, 要素構成, 接続構成, 変異率, 原種モード);
			}
		};
		Action action2 = delegate
		{
			腰.接続(母方, 父方, i, ConnectionInfo.腰_腿左_接続, 要素構成, 接続構成, 変異率, 原種モード);
			腰.接続(母方, 父方, i, ConnectionInfo.腰_尾_接続, 要素構成, 接続構成, 変異率, 原種モード);
		};
		if (半身 != null)
		{
			if (原種モード || RNG.XS.NextBool() || 半身 is 単足_植D || 半身 is 単足_粘D)
			{
				action();
			}
			else
			{
				action2();
				腿D eleD4 = 腰.腿左_接続.GetEleD<腿D>();
				if (eleD4 == null || eleD4.EnumEleD().Count() == 1 || 腰.翼左_接続.IsEleD<四足脇D>())
				{
					腰.腿左_接続.Clear();
					腰.腿右_接続.Clear();
					腰.尾_接続.Clear();
					action();
				}
			}
		}
		else
		{
			action2();
		}
		bool flag3 = false;
		顔面D 顔面D2 = null;
		foreach (EleD item32 in 腰.EnumEleD())
		{
			if (顔面D2 == null && item32 is 顔面D)
			{
				顔面D2 = (顔面D)item32;
			}
			else if (item32 is 尾_魚D)
			{
				尾_魚D 尾_魚D2 = (尾_魚D)item32;
				double num = 尾_魚D2.尺度B;
				for (int j = 0; j < 7; j++)
				{
					num *= 0.9;
				}
				foreach (EleD item33 in 尾_魚D2.左1_接続)
				{
					item33.尺度B = num;
				}
				foreach (EleD item34 in 尾_魚D2.右1_接続)
				{
					item34.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item35 in 尾_魚D2.左2_接続)
				{
					item35.尺度B = num;
				}
				foreach (EleD item36 in 尾_魚D2.右2_接続)
				{
					item36.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item37 in 尾_魚D2.左3_接続)
				{
					item37.尺度B = num;
				}
				foreach (EleD item38 in 尾_魚D2.右3_接続)
				{
					item38.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item39 in 尾_魚D2.左4_接続)
				{
					item39.尺度B = num;
				}
				foreach (EleD item40 in 尾_魚D2.右4_接続)
				{
					item40.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item41 in 尾_魚D2.左5_接続)
				{
					item41.尺度B = num;
				}
				foreach (EleD item42 in 尾_魚D2.右5_接続)
				{
					item42.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item43 in 尾_魚D2.左6_接続)
				{
					item43.尺度B = num;
				}
				foreach (EleD item44 in 尾_魚D2.右6_接続)
				{
					item44.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item45 in 尾_魚D2.左7_接続)
				{
					item45.尺度B = num;
				}
				foreach (EleD item46 in 尾_魚D2.右7_接続)
				{
					item46.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item47 in 尾_魚D2.左8_接続)
				{
					item47.尺度B = num;
				}
				foreach (EleD item48 in 尾_魚D2.右8_接続)
				{
					item48.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item49 in 尾_魚D2.左9_接続)
				{
					item49.尺度B = num;
				}
				foreach (EleD item50 in 尾_魚D2.右9_接続)
				{
					item50.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item51 in 尾_魚D2.左10_接続)
				{
					item51.尺度B = num;
				}
				foreach (EleD item52 in 尾_魚D2.右10_接続)
				{
					item52.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item53 in 尾_魚D2.左11_接続)
				{
					item53.尺度B = num;
				}
				foreach (EleD item54 in 尾_魚D2.右11_接続)
				{
					item54.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item55 in 尾_魚D2.左12_接続)
				{
					item55.尺度B = num;
				}
				foreach (EleD item56 in 尾_魚D2.右12_接続)
				{
					item56.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item57 in 尾_魚D2.左13_接続)
				{
					item57.尺度B = num;
				}
				foreach (EleD item58 in 尾_魚D2.右13_接続)
				{
					item58.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item59 in 尾_魚D2.左14_接続)
				{
					item59.尺度B = num;
				}
				foreach (EleD item60 in 尾_魚D2.右14_接続)
				{
					item60.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item61 in 尾_魚D2.左15_接続)
				{
					item61.尺度B = num;
				}
				foreach (EleD item62 in 尾_魚D2.右15_接続)
				{
					item62.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item63 in 尾_魚D2.左16_接続)
				{
					item63.尺度B = num;
				}
				foreach (EleD item64 in 尾_魚D2.右16_接続)
				{
					item64.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item65 in 尾_魚D2.左17_接続)
				{
					item65.尺度B = num;
				}
				foreach (EleD item66 in 尾_魚D2.右17_接続)
				{
					item66.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item67 in 尾_魚D2.左18_接続)
				{
					item67.尺度B = num;
				}
				foreach (EleD item68 in 尾_魚D2.右18_接続)
				{
					item68.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item69 in 尾_魚D2.左19_接続)
				{
					item69.尺度B = num;
				}
				foreach (EleD item70 in 尾_魚D2.右19_接続)
				{
					item70.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item71 in 尾_魚D2.左20_接続)
				{
					item71.尺度B = num;
				}
				foreach (EleD item72 in 尾_魚D2.右20_接続)
				{
					item72.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item73 in 尾_魚D2.左21_接続)
				{
					item73.尺度B = num;
				}
				foreach (EleD item74 in 尾_魚D2.右21_接続)
				{
					item74.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item75 in 尾_魚D2.左22_接続)
				{
					item75.尺度B = num;
				}
				foreach (EleD item76 in 尾_魚D2.右22_接続)
				{
					item76.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item77 in 尾_魚D2.左23_接続)
				{
					item77.尺度B = num;
				}
				foreach (EleD item78 in 尾_魚D2.右23_接続)
				{
					item78.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item79 in 尾_魚D2.左24_接続)
				{
					item79.尺度B = num;
				}
				foreach (EleD item80 in 尾_魚D2.右24_接続)
				{
					item80.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item81 in 尾_魚D2.左25_接続)
				{
					item81.尺度B = num;
				}
				foreach (EleD item82 in 尾_魚D2.右25_接続)
				{
					item82.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item83 in 尾_魚D2.左27_接続)
				{
					item83.尺度B = num;
				}
				foreach (EleD item84 in 尾_魚D2.右27_接続)
				{
					item84.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item85 in 尾_魚D2.左28_接続)
				{
					item85.尺度B = num;
				}
				foreach (EleD item86 in 尾_魚D2.右28_接続)
				{
					item86.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item87 in 尾_魚D2.左29_接続)
				{
					item87.尺度B = num;
				}
				foreach (EleD item88 in 尾_魚D2.右29_接続)
				{
					item88.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item89 in 尾_魚D2.左30_接続)
				{
					item89.尺度B = num;
				}
				foreach (EleD item90 in 尾_魚D2.右30_接続)
				{
					item90.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item91 in 尾_魚D2.左31_接続)
				{
					item91.尺度B = num;
				}
				foreach (EleD item92 in 尾_魚D2.右31_接続)
				{
					item92.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item93 in 尾_魚D2.左32_接続)
				{
					item93.尺度B = num;
				}
				foreach (EleD item94 in 尾_魚D2.右32_接続)
				{
					item94.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item95 in 尾_魚D2.左33_接続)
				{
					item95.尺度B = num;
				}
				foreach (EleD item96 in 尾_魚D2.右33_接続)
				{
					item96.尺度B = num;
				}
				num *= 0.9;
				foreach (EleD item97 in 尾_魚D2.左34_接続)
				{
					item97.尺度B = num;
				}
				foreach (EleD item98 in 尾_魚D2.右34_接続)
				{
					item98.尺度B = num;
				}
				if (item32.接続情報 != ConnectionInfo.腰_腿左_接続 && item32.接続情報 != ConnectionInfo.腰_腿右_接続)
				{
					尾_魚D2.尾0_表示 = true;
					尾_魚D2.尾0_鱗右_鱗1_表示 = true;
					尾_魚D2.尾0_鱗右_鱗2_表示 = true;
				}
				else
				{
					尾_魚D2.尾0_表示 = false;
					尾_魚D2.尾0_鱗右_鱗1_表示 = false;
					尾_魚D2.尾0_鱗右_鱗2_表示 = false;
				}
			}
			else if (item32 is 尾_鯨D)
			{
				尾_鯨D 尾_鯨D2 = (尾_鯨D)item32;
				double num2 = 尾_鯨D2.尺度B;
				for (int k = 0; k < 7; k++)
				{
					num2 *= 0.9;
				}
				foreach (EleD item99 in 尾_鯨D2.左1_接続)
				{
					item99.尺度B = num2;
				}
				foreach (EleD item100 in 尾_鯨D2.右1_接続)
				{
					item100.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item101 in 尾_鯨D2.左2_接続)
				{
					item101.尺度B = num2;
				}
				foreach (EleD item102 in 尾_鯨D2.右2_接続)
				{
					item102.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item103 in 尾_鯨D2.左3_接続)
				{
					item103.尺度B = num2;
				}
				foreach (EleD item104 in 尾_鯨D2.右3_接続)
				{
					item104.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item105 in 尾_鯨D2.左4_接続)
				{
					item105.尺度B = num2;
				}
				foreach (EleD item106 in 尾_鯨D2.右4_接続)
				{
					item106.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item107 in 尾_鯨D2.左5_接続)
				{
					item107.尺度B = num2;
				}
				foreach (EleD item108 in 尾_鯨D2.右5_接続)
				{
					item108.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item109 in 尾_鯨D2.左6_接続)
				{
					item109.尺度B = num2;
				}
				foreach (EleD item110 in 尾_鯨D2.右6_接続)
				{
					item110.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item111 in 尾_鯨D2.左7_接続)
				{
					item111.尺度B = num2;
				}
				foreach (EleD item112 in 尾_鯨D2.右7_接続)
				{
					item112.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item113 in 尾_鯨D2.左8_接続)
				{
					item113.尺度B = num2;
				}
				foreach (EleD item114 in 尾_鯨D2.右8_接続)
				{
					item114.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item115 in 尾_鯨D2.左9_接続)
				{
					item115.尺度B = num2;
				}
				foreach (EleD item116 in 尾_鯨D2.右9_接続)
				{
					item116.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item117 in 尾_鯨D2.左10_接続)
				{
					item117.尺度B = num2;
				}
				foreach (EleD item118 in 尾_鯨D2.右10_接続)
				{
					item118.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item119 in 尾_鯨D2.左11_接続)
				{
					item119.尺度B = num2;
				}
				foreach (EleD item120 in 尾_鯨D2.右11_接続)
				{
					item120.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item121 in 尾_鯨D2.左12_接続)
				{
					item121.尺度B = num2;
				}
				foreach (EleD item122 in 尾_鯨D2.右12_接続)
				{
					item122.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item123 in 尾_鯨D2.左13_接続)
				{
					item123.尺度B = num2;
				}
				foreach (EleD item124 in 尾_鯨D2.右13_接続)
				{
					item124.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item125 in 尾_鯨D2.左14_接続)
				{
					item125.尺度B = num2;
				}
				foreach (EleD item126 in 尾_鯨D2.右14_接続)
				{
					item126.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item127 in 尾_鯨D2.左15_接続)
				{
					item127.尺度B = num2;
				}
				foreach (EleD item128 in 尾_鯨D2.右15_接続)
				{
					item128.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item129 in 尾_鯨D2.左16_接続)
				{
					item129.尺度B = num2;
				}
				foreach (EleD item130 in 尾_鯨D2.右16_接続)
				{
					item130.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item131 in 尾_鯨D2.左17_接続)
				{
					item131.尺度B = num2;
				}
				foreach (EleD item132 in 尾_鯨D2.右17_接続)
				{
					item132.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item133 in 尾_鯨D2.左18_接続)
				{
					item133.尺度B = num2;
				}
				foreach (EleD item134 in 尾_鯨D2.右18_接続)
				{
					item134.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item135 in 尾_鯨D2.左19_接続)
				{
					item135.尺度B = num2;
				}
				foreach (EleD item136 in 尾_鯨D2.右19_接続)
				{
					item136.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item137 in 尾_鯨D2.左20_接続)
				{
					item137.尺度B = num2;
				}
				foreach (EleD item138 in 尾_鯨D2.右20_接続)
				{
					item138.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item139 in 尾_鯨D2.左21_接続)
				{
					item139.尺度B = num2;
				}
				foreach (EleD item140 in 尾_鯨D2.右21_接続)
				{
					item140.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item141 in 尾_鯨D2.左22_接続)
				{
					item141.尺度B = num2;
				}
				foreach (EleD item142 in 尾_鯨D2.右22_接続)
				{
					item142.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item143 in 尾_鯨D2.左23_接続)
				{
					item143.尺度B = num2;
				}
				foreach (EleD item144 in 尾_鯨D2.右23_接続)
				{
					item144.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item145 in 尾_鯨D2.左24_接続)
				{
					item145.尺度B = num2;
				}
				foreach (EleD item146 in 尾_鯨D2.右24_接続)
				{
					item146.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item147 in 尾_鯨D2.左25_接続)
				{
					item147.尺度B = num2;
				}
				foreach (EleD item148 in 尾_鯨D2.右25_接続)
				{
					item148.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item149 in 尾_鯨D2.左27_接続)
				{
					item149.尺度B = num2;
				}
				foreach (EleD item150 in 尾_鯨D2.右27_接続)
				{
					item150.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item151 in 尾_鯨D2.左28_接続)
				{
					item151.尺度B = num2;
				}
				foreach (EleD item152 in 尾_鯨D2.右28_接続)
				{
					item152.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item153 in 尾_鯨D2.左29_接続)
				{
					item153.尺度B = num2;
				}
				foreach (EleD item154 in 尾_鯨D2.右29_接続)
				{
					item154.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item155 in 尾_鯨D2.左30_接続)
				{
					item155.尺度B = num2;
				}
				foreach (EleD item156 in 尾_鯨D2.右30_接続)
				{
					item156.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item157 in 尾_鯨D2.左31_接続)
				{
					item157.尺度B = num2;
				}
				foreach (EleD item158 in 尾_鯨D2.右31_接続)
				{
					item158.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item159 in 尾_鯨D2.左32_接続)
				{
					item159.尺度B = num2;
				}
				foreach (EleD item160 in 尾_鯨D2.右32_接続)
				{
					item160.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item161 in 尾_鯨D2.左33_接続)
				{
					item161.尺度B = num2;
				}
				foreach (EleD item162 in 尾_鯨D2.右33_接続)
				{
					item162.尺度B = num2;
				}
				num2 *= 0.9;
				foreach (EleD item163 in 尾_鯨D2.左34_接続)
				{
					item163.尺度B = num2;
				}
				foreach (EleD item164 in 尾_鯨D2.右34_接続)
				{
					item164.尺度B = num2;
				}
			}
			else if (item32 is 触手_蔦D)
			{
				触手_蔦D 触手_蔦D2 = (触手_蔦D)item32;
				double 尺度B = 触手_蔦D2.尺度B;
				foreach (EleD item165 in 触手_蔦D2.節3_接続)
				{
					item165.尺度B = 尺度B;
				}
				尺度B *= SpeciesDefaults.葉倍率;
				foreach (EleD item166 in 触手_蔦D2.節5_接続)
				{
					item166.尺度B = 尺度B;
				}
				尺度B *= SpeciesDefaults.葉倍率;
				foreach (EleD item167 in 触手_蔦D2.節7_接続)
				{
					item167.尺度B = 尺度B;
				}
				尺度B *= SpeciesDefaults.葉倍率;
				foreach (EleD item168 in 触手_蔦D2.節9_接続)
				{
					item168.尺度B = 尺度B;
				}
				尺度B *= SpeciesDefaults.葉倍率;
				foreach (EleD item169 in 触手_蔦D2.節11_接続)
				{
					item169.尺度B = 尺度B;
				}
				尺度B *= SpeciesDefaults.葉倍率;
				foreach (EleD item170 in 触手_蔦D2.節13_接続)
				{
					item170.尺度B = 尺度B;
				}
				尺度B *= SpeciesDefaults.葉倍率;
				foreach (EleD item171 in 触手_蔦D2.節15_接続)
				{
					item171.尺度B = 尺度B;
				}
				尺度B *= SpeciesDefaults.葉倍率;
				foreach (EleD item172 in 触手_蔦D2.節17_接続)
				{
					item172.尺度B = 尺度B;
				}
				尺度B *= SpeciesDefaults.葉倍率;
				foreach (EleD item173 in 触手_蔦D2.節19_接続)
				{
					item173.尺度B = 尺度B;
				}
			}
			else if (item32 is 触手_軟D)
			{
				((触手_軟D)item32).節1_鎧_表示 = false;
			}
			else if (item32 is 触手_犬D)
			{
				触手_犬D 触手_犬D2 = (触手_犬D)item32;
				触手_犬D2.脚前_鰭_鰭膜3_表示 = (触手_犬D2.脚前_鰭_鰭条2_表示 = (触手_犬D2.脚前_鰭_鰭膜2_表示 = (触手_犬D2.脚前_鰭_鰭条1_表示 = (触手_犬D2.脚前_鰭_鰭膜1_表示 = (触手_犬D2.脚後_鰭_鰭膜3_表示 = (触手_犬D2.脚後_鰭_鰭条2_表示 = (触手_犬D2.脚後_鰭_鰭膜2_表示 = (触手_犬D2.脚後_鰭_鰭条1_表示 = (触手_犬D2.脚後_鰭_鰭膜1_表示 = 触手_犬D2.脚後_鰭_鰭膜1_表示 || 触手_犬D2.脚後_鰭_鰭条1_表示 || 触手_犬D2.脚後_鰭_鰭膜2_表示 || 触手_犬D2.脚後_鰭_鰭条2_表示 || 触手_犬D2.脚後_鰭_鰭膜3_表示)))))))));
			}
			else if (item32 is 背中_光D || item32 is 頭頂_天D)
			{
				item32.尺度YB = 1.0;
			}
			else if (item32 is 上腕_蝙D && (item32.接続情報 == ConnectionInfo.基髪_頭頂左_接続 || item32.接続情報 == ConnectionInfo.基髪_頭頂右_接続))
			{
				((上腕_蝙D)item32).竜性_鱗1_表示 = false;
			}
			else if (item32 is 上腕D && item32.Par is 肩D)
			{
				item32.AlignR();
			}
			if (!flag3)
			{
				flag3 |= item32.筋肉;
			}
		}
		if (頭D2.額_接続.Count > 1)
		{
			頭D2.額_接続.Remove(頭D2.額_接続[RNG.XS.Next(頭D2.額_接続.Count)]);
		}
		bool flag4 = false;
		flag4 |= 胸腹板D2.虫性_腹板_表示;
		flag4 |= 胴腹板D2.虫性_腹板_表示;
		flag4 |= 腰肌.虫性_腹板1_腹板_表示 || 腰肌.虫性_腹板2_腹板_表示;
		bool flag5 = false;
		flag5 |= 胸腹板D2.虫性_縦線_表示;
		flag5 |= 胴腹板D2.虫性_縦線_表示;
		flag5 |= 腰肌.虫性_腹板1_縦線_表示 || 腰肌.虫性_腹板2_縦線_表示;
		flag5 = flag5 && flag4;
		if (flag5)
		{
			flag5 = RNG.XS.NextBool();
		}
		胸腹板D2.虫性_腹板_表示 = flag4;
		胸腹板D2.虫性_縦線_表示 = flag5;
		胴腹板D2.虫性_腹板_表示 = flag4;
		胴腹板D2.虫性_縦線_表示 = flag5;
		腰肌.虫性_腹板1_腹板_表示 = flag4;
		腰肌.虫性_腹板2_腹板_表示 = flag4;
		腰肌.虫性_腹板1_縦線_表示 = flag5;
		腰肌.虫性_腹板2_縦線_表示 = flag5;
		if (RNG.XS.NextBool())
		{
			bool flag6 = false;
			bool flag7 = true;
			bool flag8 = false;
			if (双目D2 != null)
			{
				flag6 |= 双目D2.蛸目;
				flag7 &= 双目D2.黒目_瞳孔_表示;
				flag8 |= 双目D2.猫目;
			}
			if (双目D3 != null)
			{
				flag6 |= 双目D3.蛸目;
				flag7 &= 双目D3.黒目_瞳孔_表示;
				flag8 |= 双目D3.猫目;
			}
			if (頬目D2 != null)
			{
				flag6 |= 頬目D2.蛸目;
				flag7 &= 頬目D2.黒目_瞳孔_表示;
				flag8 |= 頬目D2.猫目;
			}
			if (頬目D3 != null)
			{
				flag6 |= 頬目D3.蛸目;
				flag7 &= 頬目D3.黒目_瞳孔_表示;
				flag8 |= 頬目D3.猫目;
			}
			if (縦目D2 != null)
			{
				flag6 |= 縦目D2.蛸目;
				flag7 &= 縦目D2.黒目_瞳孔_表示;
				flag8 |= 縦目D2.猫目;
			}
			if (単目D2 != null)
			{
				flag6 |= 単目D2.蛸目;
				flag7 &= 単目D2.黒目_瞳孔_表示;
				flag8 |= 単目D2.猫目;
			}
			bool flag9 = RNG.XS.NextBool();
			bool flag10 = RNG.XS.NextBool();
			bool flag11 = RNG.XS.NextBool();
			if (双目D2 != null)
			{
				双目D2.蛸目 = (flag9 ? flag6 : 双目D2.蛸目);
				双目D2.黒目_瞳孔_表示 = (flag10 ? flag7 : 双目D2.黒目_瞳孔_表示);
				双目D2.猫目 = (flag11 ? flag8 : 双目D2.猫目);
			}
			if (双目D3 != null)
			{
				双目D3.蛸目 = (flag9 ? flag6 : 双目D3.蛸目);
				双目D3.黒目_瞳孔_表示 = (flag10 ? flag7 : 双目D3.黒目_瞳孔_表示);
				双目D3.猫目 = (flag11 ? flag8 : 双目D3.猫目);
			}
			if (頬目D2 != null)
			{
				頬目D2.蛸目 = (flag9 ? flag6 : 頬目D2.蛸目);
				頬目D2.黒目_瞳孔_表示 = (flag10 ? flag7 : 頬目D2.黒目_瞳孔_表示);
				頬目D2.猫目 = (flag11 ? flag8 : 頬目D2.猫目);
			}
			if (頬目D3 != null)
			{
				頬目D3.蛸目 = (flag9 ? flag6 : 頬目D3.蛸目);
				頬目D3.黒目_瞳孔_表示 = (flag10 ? flag7 : 頬目D3.黒目_瞳孔_表示);
				頬目D3.猫目 = (flag11 ? flag8 : 頬目D3.猫目);
			}
			if (縦目D2 != null)
			{
				縦目D2.蛸目 = (flag9 ? flag6 : 縦目D2.蛸目);
				縦目D2.黒目_瞳孔_表示 = (flag10 ? flag7 : 縦目D2.黒目_瞳孔_表示);
				縦目D2.猫目 = (flag11 ? flag8 : 縦目D2.猫目);
			}
			if (単目D2 != null)
			{
				単目D2.蛸目 = (flag9 ? flag6 : 単目D2.蛸目);
				単目D2.黒目_瞳孔_表示 = (flag10 ? flag7 : 単目D2.黒目_瞳孔_表示);
				単目D2.猫目 = (flag11 ? flag8 : 単目D2.猫目);
			}
		}
		if (単目D2 != null)
		{
			鼻肌D2.紋柄_紋左_紋1_表示 = false;
			鼻肌D2.紋柄_紋左_紋2_表示 = false;
			鼻肌D2.紋柄_紋左_紋3_表示 = false;
			鼻肌D2.紋柄_紋左_紋4_表示 = false;
			鼻肌D2.紋柄_紋右_紋1_表示 = false;
			鼻肌D2.紋柄_紋右_紋2_表示 = false;
			鼻肌D2.紋柄_紋右_紋3_表示 = false;
			鼻肌D2.紋柄_紋右_紋4_表示 = false;
		}
		bool flag12 = 顔面D2?.触覚左_接続.IsEleD<触覚D>() ?? false;
		bool flag13 = 頭D2.触覚左_接続.IsEleD<触覚D>();
		bool flag14 = 基髪D2.頭頂左_接続.IsEleD<触覚D>();
		if (!flag12 && flag13 && flag14)
		{
			if (RNG.XS.NextBool())
			{
				頭D2.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
				頭D2.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
			}
			else
			{
				基髪D2.頭頂左_接続.RemoveAll((EleD e) => e is 触覚D);
				基髪D2.頭頂右_接続.RemoveAll((EleD e) => e is 触覚D);
			}
		}
		else if (flag12 && !flag13 && flag14)
		{
			if (RNG.XS.NextBool())
			{
				顔面D2.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
				顔面D2.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
			}
			else
			{
				基髪D2.頭頂左_接続.RemoveAll((EleD e) => e is 触覚D);
				基髪D2.頭頂右_接続.RemoveAll((EleD e) => e is 触覚D);
			}
		}
		else if (flag12 && flag13 && !flag14)
		{
			if (RNG.XS.NextBool())
			{
				顔面D2.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
				顔面D2.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
			}
			else
			{
				頭D2.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
				頭D2.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
			}
		}
		else if (flag12 && flag13 && flag14)
		{
			switch (RNG.XS.Next(2))
			{
			case 0:
				頭D2.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
				頭D2.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
				基髪D2.頭頂左_接続.RemoveAll((EleD e) => e is 触覚D);
				基髪D2.頭頂右_接続.RemoveAll((EleD e) => e is 触覚D);
				break;
			case 1:
				顔面D2.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
				顔面D2.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
				基髪D2.頭頂左_接続.RemoveAll((EleD e) => e is 触覚D);
				基髪D2.頭頂右_接続.RemoveAll((EleD e) => e is 触覚D);
				break;
			case 2:
				顔面D2.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
				顔面D2.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
				頭D2.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
				頭D2.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
				break;
			}
		}
		if (顔面D2 != null && flag13)
		{
			foreach (触覚D eleD8 in 頭D2.触覚左_接続.GetEleDs<触覚D>())
			{
				顔面D2.触覚左接続(eleD8);
			}
			foreach (触覚D eleD9 in 頭D2.触覚右_接続.GetEleDs<触覚D>())
			{
				顔面D2.触覚右接続(eleD9);
			}
			頭D2.触覚左_接続.RemoveAll((EleD e) => e is 触覚D);
			頭D2.触覚右_接続.RemoveAll((EleD e) => e is 触覚D);
		}
		if (腰肌.陰毛_表示 && 腰肌.獣性_獣毛_表示)
		{
			if (RNG.XS.NextBool())
			{
				腰肌.陰毛_表示 = false;
			}
			else
			{
				腰肌.獣性_獣毛_表示 = false;
			}
		}
		if (縦瞼D2 != null)
		{
			if (RNG.XS.NextBool())
			{
				縦瞼D2.瞼左_睫毛1_表示 = 縦瞼D2.瞼右_睫毛1_表示;
				縦瞼D2.瞼左_睫毛2_表示 = 縦瞼D2.瞼右_睫毛2_表示;
			}
			else
			{
				縦瞼D2.瞼右_睫毛1_表示 = 縦瞼D2.瞼左_睫毛1_表示;
				縦瞼D2.瞼右_睫毛2_表示 = 縦瞼D2.瞼左_睫毛2_表示;
			}
			if (RNG.XS.NextBool())
			{
				縦瞼D2.瞼左_睫毛1_長さ = 縦瞼D2.瞼右_睫毛1_長さ;
				縦瞼D2.瞼左_睫毛2_長さ = 縦瞼D2.瞼右_睫毛2_長さ;
			}
			else
			{
				縦瞼D2.瞼右_睫毛1_長さ = 縦瞼D2.瞼左_睫毛1_長さ;
				縦瞼D2.瞼右_睫毛2_長さ = 縦瞼D2.瞼左_睫毛2_長さ;
			}
		}
		if (単瞼D2 != null)
		{
			if (RNG.XS.NextBool())
			{
				単瞼D2.睫毛上上左_表示 = 単瞼D2.睫毛上上右_表示;
				単瞼D2.睫毛上中左_表示 = 単瞼D2.睫毛上中右_表示;
				単瞼D2.睫毛上下左_表示 = 単瞼D2.睫毛上下右_表示;
				単瞼D2.睫毛下上左_表示 = 単瞼D2.睫毛下上右_表示;
				単瞼D2.睫毛下下左_表示 = 単瞼D2.睫毛下下右_表示;
			}
			else
			{
				単瞼D2.睫毛上上右_表示 = 単瞼D2.睫毛上上左_表示;
				単瞼D2.睫毛上中右_表示 = 単瞼D2.睫毛上中左_表示;
				単瞼D2.睫毛上下右_表示 = 単瞼D2.睫毛上下左_表示;
				単瞼D2.睫毛下上右_表示 = 単瞼D2.睫毛下上左_表示;
				単瞼D2.睫毛下下右_表示 = 単瞼D2.睫毛下下左_表示;
			}
			if (RNG.XS.NextBool())
			{
				単瞼D2.睫毛上上左_長さ = 単瞼D2.睫毛上上右_長さ;
				単瞼D2.睫毛上中左_長さ = 単瞼D2.睫毛上中右_長さ;
				単瞼D2.睫毛上下左_長さ = 単瞼D2.睫毛上下右_長さ;
				単瞼D2.睫毛下上左_長さ = 単瞼D2.睫毛下上右_長さ;
				単瞼D2.睫毛下下左_長さ = 単瞼D2.睫毛下下右_長さ;
			}
			else
			{
				単瞼D2.睫毛上上右_長さ = 単瞼D2.睫毛上上左_長さ;
				単瞼D2.睫毛上中右_長さ = 単瞼D2.睫毛上中左_長さ;
				単瞼D2.睫毛上下右_長さ = 単瞼D2.睫毛上下左_長さ;
				単瞼D2.睫毛下上右_長さ = 単瞼D2.睫毛下上左_長さ;
				単瞼D2.睫毛下下右_長さ = 単瞼D2.睫毛下下左_長さ;
			}
		}
		if ((腰肌.淫タトゥ_ハート_タトゥ右1_表示 || 腰肌.淫タトゥ_ハート_タトゥ右2_表示 || 腰肌.淫タトゥ_ハート_タトゥ左1_表示 || 腰肌.淫タトゥ_ハート_タトゥ左2_表示) && (腰肌.植タトゥ_タトゥ左_表示 || 腰肌.植タトゥ_タトゥ右_表示))
		{
			if (RNG.XS.NextBool())
			{
				腰肌.淫タトゥ_ハート_タトゥ右1_表示 = true;
				腰肌.淫タトゥ_ハート_タトゥ右2_表示 = true;
				腰肌.淫タトゥ_ハート_タトゥ左1_表示 = true;
				腰肌.淫タトゥ_ハート_タトゥ左2_表示 = true;
				腰肌.植タトゥ_タトゥ左_表示 = false;
				腰肌.植タトゥ_タトゥ右_表示 = false;
			}
			else
			{
				腰肌.淫タトゥ_ハート_タトゥ右1_表示 = false;
				腰肌.淫タトゥ_ハート_タトゥ右2_表示 = false;
				腰肌.淫タトゥ_ハート_タトゥ左1_表示 = false;
				腰肌.淫タトゥ_ハート_タトゥ左2_表示 = false;
				腰肌.植タトゥ_タトゥ左_表示 = true;
				腰肌.植タトゥ_タトゥ右_表示 = true;
			}
		}
		if (flag3)
		{
			腰.EnumEleD().SetValuesD("筋肉", true);
		}
		return 腰;
	}

	public static EleD GetEleD(this IEnumerable<EleD> src, Type t)
	{
		return src?.FirstOrDefault((EleD e) => e.GetType().IsAssignableFrom(t));
	}

	public static EleD GetEleD(this IEnumerable<EleD> src, bool 右, Type t)
	{
		return src?.FirstOrDefault((EleD e) => e.GetType().IsAssignableFrom(t) && e.右 == 右);
	}

	public static EleD GetEleD(this IEnumerable<EleD> src, Func<EleD, bool> con, Type t)
	{
		return src?.FirstOrDefault((EleD e) => e.GetType().IsAssignableFrom(t) && con(e));
	}

	private static void Dou<T>(this T e)
	{
		FieldInfo[] fields = e.GetType().GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			if (fieldInfo.FieldType.ToString() == Sta.dt && 実数対象.Contains(fieldInfo.Name))
			{
				fieldInfo.SetValue(e, ((double)fieldInfo.GetValue(e) + (double)RNG.XS.NextSign() * RNG.XS.NextDouble(0.15)).Clamp(0.0, 1.0));
			}
		}
	}

	private static void Dou<T>(this T e0, T e1)
	{
		FieldInfo[] fields;
		switch (RNG.XS.Next(3))
		{
		case 0:
		{
			Type type = e1.GetType();
			fields = e0.GetType().GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				if (fieldInfo.FieldType.ToString() == Sta.dt && 実数対象.Contains(fieldInfo.Name))
				{
					FieldInfo field = type.GetField(fieldInfo.Name);
					if (field != null && field.FieldType.ToString() == Sta.dt)
					{
						fieldInfo.SetValue(e0, RNG.XS.NextBool() ? fieldInfo.GetValue(e0) : field.GetValue(e1));
					}
				}
			}
			return;
		}
		case 1:
		{
			Type type2 = e1.GetType();
			fields = e0.GetType().GetFields();
			foreach (FieldInfo fieldInfo2 in fields)
			{
				if (fieldInfo2.FieldType.ToString() == Sta.dt && 実数対象.Contains(fieldInfo2.Name))
				{
					FieldInfo field2 = type2.GetField(fieldInfo2.Name);
					if (field2 != null && field2.FieldType.ToString() == Sta.dt)
					{
						fieldInfo2.SetValue(e0, ((double)fieldInfo2.GetValue(e0) + (double)field2.GetValue(e1)) * 0.5);
					}
				}
			}
			return;
		}
		}
		fields = e0.GetType().GetFields();
		foreach (FieldInfo fieldInfo3 in fields)
		{
			if (fieldInfo3.FieldType.ToString() == Sta.dt && 実数対象.Contains(fieldInfo3.Name))
			{
				fieldInfo3.SetValue(e0, ((double)fieldInfo3.GetValue(e0) + (double)RNG.XS.NextSign() * RNG.XS.NextDouble(0.15)).Clamp(0.0, 1.0));
			}
		}
	}

	private static T Sub<T>(T e0, T e1) where T : EleD
	{
		object obj = e0.GetType().GetConstructor(bi, Type.DefaultBinder, t0, null).Invoke(null);
		EleD eleD = e0.Copy_以下無();
		Type type = e1.GetType();
		FieldInfo[] fields = e0.GetType().GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			if (fieldInfo.Name.EndsWith("_表示"))
			{
				FieldInfo field = type.GetField(fieldInfo.Name);
				if (field != null && field.FieldType.ToString() == Sta.bt)
				{
					bool num = (bool)fieldInfo.GetValue(e0);
					bool flag = num;
					fieldInfo.SetValue(eleD, (num && (bool)field.GetValue(e1)) ? fieldInfo.GetValue(obj) : ((object)flag));
				}
			}
		}
		return (T)eleD;
	}

	private static T Syn<T>(T e0, T e1) where T : EleD
	{
		e0.GetType().GetConstructor(bi, Type.DefaultBinder, t0, null).Invoke(null);
		EleD eleD = e0.Copy_以下無();
		Type type = e1.GetType();
		FieldInfo[] fields = e0.GetType().GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			if (fieldInfo.Name.EndsWith("_表示"))
			{
				FieldInfo field = type.GetField(fieldInfo.Name);
				if (field != null && field.FieldType.ToString() == Sta.bt)
				{
					fieldInfo.SetValue(eleD, (bool)fieldInfo.GetValue(e0) || (bool)field.GetValue(e1));
				}
			}
		}
		return (T)eleD;
	}

	private static T Mix<T>(T 母, T 父, int i, bool 原種モード) where T : EleD
	{
		T val = null;
		if (母 == null && 父 != null)
		{
			val = (T)父.Copy_以下無();
			val.Dou();
		}
		else if (母 != null && 父 == null)
		{
			val = (T)母.Copy_以下無();
			val.Dou();
		}
		else if (母 != null && 父 != null)
		{
			if (原種モード)
			{
				switch (i)
				{
				case 0:
					val = (T)母.Copy_以下無();
					val.Dou(父);
					break;
				case 1:
					val = (T)父.Copy_以下無();
					val.Dou(母);
					break;
				default:
				{
					bool flag = RNG.XS.NextBool();
					val = (T)(flag ? 母 : 父).Copy_以下無();
					val.Dou(flag ? 父 : 母);
					break;
				}
				}
			}
			else
			{
				switch (i)
				{
				case 0:
					val = (T)母.Copy_以下無();
					val.Dou(父);
					break;
				case 1:
					val = (T)父.Copy_以下無();
					val.Dou(母);
					break;
				case 2:
					val = Sub(母, 父);
					val.Dou(父);
					break;
				case 3:
					val = Sub(父, 母);
					val.Dou(母);
					break;
				case 4:
					val = Syn(母, 父);
					val.Dou(父);
					break;
				case 5:
					val = Syn(父, 母);
					val.Dou(母);
					break;
				default:
				{
					bool flag2 = RNG.XS.NextBool();
					val = (T)(flag2 ? 母 : 父).Copy_以下無();
					val.Dou(flag2 ? 父 : 母);
					break;
				}
				}
			}
		}
		return val;
	}

	private static T Mix<T>(腰D 母方, 腰D 父方, int i, bool 原種モード) where T : EleD
	{
		T eleD = (from e in 母方.EnumEleD()
			orderby RNG.XS.Next()
			select e).GetEleD<T>();
		T eleD2 = (from e in 父方.EnumEleD()
			orderby RNG.XS.Next()
			select e).GetEleD<T>();
		return Mix(eleD, eleD2, i, 原種モード);
	}

	private static T Mix<T>(腰D 母方, 腰D 父方, bool 右, int i, bool 原種モード) where T : EleD
	{
		T eleD = (from e in 母方.EnumEleD()
			orderby RNG.XS.Next()
			select e).GetEleD<T>(右);
		T eleD2 = (from e in 父方.EnumEleD()
			orderby RNG.XS.Next()
			select e).GetEleD<T>(右);
		return Mix(eleD, eleD2, i, 原種モード);
	}

	private static T Mix<T>(腰D 母方, 腰D 父方, Func<T, bool> con, int i, bool 原種モード) where T : EleD
	{
		T eleD = (from e in 母方.EnumEleD()
			orderby RNG.XS.Next()
			select e).GetEleD(con);
		T eleD2 = (from e in 父方.EnumEleD()
			orderby RNG.XS.Next()
			select e).GetEleD(con);
		return Mix(eleD, eleD2, i, 原種モード);
	}

	private static EleD Mix(腰D 母方, 腰D 父方, int i, Type t, bool 原種モード)
	{
		EleD eleD = (from e in 母方.EnumEleD()
			orderby RNG.XS.Next()
			select e).GetEleD(t);
		EleD eleD2 = (from e in 父方.EnumEleD()
			orderby RNG.XS.Next()
			select e).GetEleD(t);
		return Mix(eleD, eleD2, i, 原種モード);
	}

	private static EleD Mix(腰D 母方, 腰D 父方, bool 右, int i, Type t, bool 原種モード)
	{
		EleD eleD = (from e in 母方.EnumEleD()
			orderby RNG.XS.Next()
			select e).GetEleD(右, t);
		EleD eleD2 = (from e in 父方.EnumEleD()
			orderby RNG.XS.Next()
			select e).GetEleD(右, t);
		return Mix(eleD, eleD2, i, 原種モード);
	}

	private static EleD Mix(腰D 母方, 腰D 父方, Func<EleD, bool> con, int i, Type t, bool 原種モード)
	{
		EleD eleD = (from e in 母方.EnumEleD()
			orderby RNG.XS.Next()
			select e).GetEleD(con, t);
		EleD eleD2 = (from e in 父方.EnumEleD()
			orderby RNG.XS.Next()
			select e).GetEleD(con, t);
		return Mix(eleD, eleD2, i, 原種モード);
	}

	public static void AlignR(this EleD e)
	{
		if (e == null)
		{
			return;
		}
		FieldInfo[] fields = Sta.EleDt.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			if (fieldInfo.FieldType.ToString() == Sta.dt)
			{
				fieldInfo.SetValue(e, fieldInfo.GetValue(e.Par));
			}
		}
	}

	public static void AlignC(this EleD e)
	{
		if (e == null)
		{
			return;
		}
		foreach (EleD item in e.EnumEleD())
		{
			FieldInfo[] fields = Sta.EleDt.GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				if (fieldInfo.FieldType.ToString() == Sta.dt)
				{
					fieldInfo.SetValue(item, fieldInfo.GetValue(e));
				}
			}
		}
	}

	private static Dictionary<ConnectionInfo, List<Type>> Get接続構成(腰D 母方, 腰D 父方)
	{
		Dictionary<ConnectionInfo, List<Type>> dictionary = new Dictionary<ConnectionInfo, List<Type>>();
		foreach (EleD item in 母方.EnumEleD().Concat(父方.EnumEleD()))
		{
			Type type = item.GetType();
			if (!(item is 長胴D) && 接続範囲.ContainsKey(item.接続情報) && 接続範囲[item.接続情報].Contains(type.ToString()))
			{
				if (dictionary.ContainsKey(item.接続情報))
				{
					dictionary[item.接続情報].Add(type);
					continue;
				}
				dictionary[item.接続情報] = new List<Type> { type };
			}
		}
		return dictionary;
	}

	private static Type[] Get要素構成(腰D 母方, 腰D 父方)
	{
		return (from e in 母方.EnumEleD().Concat(父方.EnumEleD())
			where 接続範囲.ContainsKey(e.接続情報) && 接続範囲[e.接続情報].Contains(e.GetType().ToString())
			select e.GetType()).ToArray();
	}

	public static void 接続(this EleD e, 腰D 母方, 腰D 父方, int i, ConnectionInfo 接続, Type[] 要素構成, Dictionary<ConnectionInfo, List<Type>> 接続構成, double 変異率, bool 原種モード)
	{
		string text = 接続.ToString();
		if (text.Contains("左"))
		{
			ConnectionInfo 接続情報2 = 接続;
			ConnectionInfo 接続情報3 = text.Replace("左", "右").To接続情報();
			{
				foreach (EleD item in Enum接続肢(母方, 父方, 右: false, i, 接続, 要素構成, 接続構成, 変異率, 原種モード))
				{
					if (item != null)
					{
						e.接続(接続情報2, item);
						e.接続(接続情報3, item.Get逆());
					}
				}
				return;
			}
		}
		if (text.Contains("右"))
		{
			return;
		}
		foreach (EleD item2 in Enum接続肢(母方, 父方, 右: false, i, 接続, 要素構成, 接続構成, 変異率, 原種モード).Reverse())
		{
			if (item2 != null)
			{
				e.接続(接続, item2);
			}
		}
	}

	public static IEnumerable<EleD> Enum接続肢(腰D 母方, 腰D 父方, bool 右, int i, ConnectionInfo 接続, Type[] 要素構成, Dictionary<ConnectionInfo, List<Type>> 接続構成, double 変異率, bool 原種モード)
	{
		double l = (接続.接続数(母方, 父方) + 接続.接続数(母方, 父方) + 接続.接続数(母方, 父方)) / 3;
		double num = 1.0 / ((double)接続構成.Count * 0.5);
		if (!原種モード)
		{
			string text = 接続.ToString();
			if (text.Contains("肩") || text.Contains("脇") || text.Contains("翼"))
			{
				if (num.Lot())
				{
					l += (double)(int)(3.0 * 変異率 * RNG.XS.NextDouble());
				}
				if (l > 3.0)
				{
					l = 3.0;
				}
			}
			else if (接続 == ConnectionInfo.腰_尾_接続 || 接続 == ConnectionInfo.四足腰_尾_接続)
			{
				if (num.Lot())
				{
					l += (double)(int)(9.0 * 変異率 * RNG.XS.NextDouble());
				}
				if (l > 9.0)
				{
					l = 9.0;
				}
			}
			if ((num * 変異率 * 0.5).Lot())
			{
				l = 0.0;
			}
		}
		if (l == 0.0 && (接続 == ConnectionInfo.四足脇_上腕_接続 || 接続 == ConnectionInfo.腰_腿左_接続 || 接続 == ConnectionInfo.腰_腿左_接続 || 接続 == ConnectionInfo.四足腰_腿左_接続 || 接続 == ConnectionInfo.四足腰_腿左_接続 || 接続 == ConnectionInfo.長物_魚_尾_接続 || 接続 == ConnectionInfo.長物_鯨_尾_接続 || 接続 == ConnectionInfo.長物_蛇_胴_接続 || 接続 == ConnectionInfo.長物_蟲_胴_接続 || 接続 == ConnectionInfo.胴_蛇_胴_接続 || 接続 == ConnectionInfo.胴_蟲_胴_接続 || 接続 == ConnectionInfo.多足_蛸_軟体外左_接続 || 接続 == ConnectionInfo.多足_蛸_軟体外右_接続 || 接続 == ConnectionInfo.多足_蛸_軟体内左_接続 || 接続 == ConnectionInfo.多足_蛸_軟体内右_接続 || 接続 == ConnectionInfo.単足_植_根外左_接続 || 接続 == ConnectionInfo.単足_植_根内左_接続 || 接続 == ConnectionInfo.単足_植_根中央_接続 || 接続 == ConnectionInfo.単足_植_根内右_接続 || 接続 == ConnectionInfo.単足_植_根外右_接続 || 接続 == ConnectionInfo.頭頂_宇_頭部後_接続 || (num * 1.1).Lot()))
		{
			l = 1.0;
		}
		for (int j = 0; (double)j < l; j++)
		{
			EleD e = Get接続肢(母方, 父方, 右, i, 接続, 要素構成, 接続構成, 変異率, j, 原種モード);
			if (e != null)
			{
				yield return e;
			}
			if (e is 角1D || e is 耳D || e is 触覚D || e is 腿D || e is 尾_蜘D || e is 尾_鳥D)
			{
				break;
			}
		}
	}

	public static int 接続数(this ConnectionInfo 接続情報, 腰D 母方, 腰D 父方)
	{
		if (接続範囲.ContainsKey(接続情報))
		{
			IEnumerable<EleD> source = from e in 母方.EnumEleD().Concat(父方.EnumEleD())
				where e.Enum接続情報().Contains(接続情報)
				select e;
			int num = source.Count();
			if (num != 0)
			{
				return source.ElementAt(RNG.XS.Next(num)).Get接続(接続情報).Count((EleD e) => 接続範囲[接続情報].Contains(e.GetType().ToString()));
			}
			return 1;
		}
		return 0;
	}

	public static EleD Get接続肢(腰D 母方, 腰D 父方, bool 右, int i, ConnectionInfo 接続, Type[] 要素構成, Dictionary<ConnectionInfo, List<Type>> 接続構成, double 変異率, int j, bool 原種モード)
	{
		EleD eleD = Get要素(母方, 父方, 右, i, 接続, 要素構成, 接続構成, 変異率, j, 原種モード);
		if (eleD != null)
		{
			foreach (ConnectionInfo item in eleD.Enum接続情報())
			{
				string text = item.ToString();
				if (text.Contains("左"))
				{
					ConnectionInfo 接続情報2 = item;
					ConnectionInfo 接続情報3 = text.Replace("左", "右").To接続情報();
					foreach (EleD item2 in Enum接続肢(母方, 父方, 右: false, i, item, 要素構成, 接続構成, 変異率, 原種モード))
					{
						if (item2 != null)
						{
							eleD.接続(接続情報2, item2);
							eleD.接続(接続情報3, item2.Get逆());
						}
					}
				}
				else if (!text.Contains("右"))
				{
					EleD eleD2 = Get接続肢(母方, 父方, 右, i, item, 要素構成, 接続構成, 変異率, j, 原種モード);
					if (eleD2 != null)
					{
						eleD.接続(item, eleD2);
					}
				}
			}
		}
		return eleD;
	}

	public static EleD Get要素(腰D 母方, 腰D 父方, bool 右, int i, ConnectionInfo 接続, Type[] 要素構成, Dictionary<ConnectionInfo, List<Type>> 接続構成, double 変異率, int j, bool 原種モード)
	{
		if (!原種モード && 変異率.Lot())
		{
			return Get要素1(母方, 父方, 右, i, 接続, 要素構成, j, 原種モード);
		}
		return Get要素0(母方, 父方, 右, i, 接続, 接続構成, j, 原種モード);
	}

	public static EleD Get要素1(腰D 母方, 腰D 父方, bool 右, int i, ConnectionInfo 接続, Type[] 要素構成, int j, bool 原種モード)
	{
		if (接続範囲.ContainsKey(接続))
		{
			IEnumerable<Type> source = 要素構成.Where((Type e) => 接続範囲[接続].Contains(e.ToString()));
			int num = source.Count();
			if (num > j && j > -1)
			{
				return Mix(母方, 父方, 右, i, source.ElementAt(j), 原種モード);
			}
			if (num > 0)
			{
				return Mix(母方, 父方, 右, i, source.ElementAt(RNG.XS.Next(num)), 原種モード);
			}
		}
		return null;
	}

	public static EleD Get要素0(腰D 母方, 腰D 父方, bool 右, int i, ConnectionInfo 接続, Dictionary<ConnectionInfo, List<Type>> 接続構成, int j, bool 原種モード)
	{
		if (接続構成.ContainsKey(接続))
		{
			List<Type> list = 接続構成[接続];
			int count = list.Count;
			if (count > j && j > -1)
			{
				return Mix(母方, 父方, 右, i, list[j], 原種モード);
			}
			if (count > 0)
			{
				return Mix(母方, 父方, 右, i, list[RNG.XS.Next(count)], 原種モード);
			}
		}
		return null;
	}

	public static ChaD Mix(this ChaD 母方, ChaD 父方, bool 原種モード)
	{
		double num = Mix(母方.魔力濃度, 父方.魔力濃度, 1.0);
		腰D d;
		return new ChaD(d = Mix(母方.body_tree, 父方.body_tree, num, 原種モード), Mix(母方.body_color, 父方.body_color, num, d))
		{
			Lust = Mix(母方.Lust, 父方.Lust, 0.6),
			Affection = Mix(母方.Affection, 父方.Affection, 0.6),
			Taming = Mix(母方.Taming, 父方.Taming, 0.6),
			SkillL = Mix(母方.SkillL, 父方.SkillL, 0.6),
			Sesnsitivities = new Dictionary<ContactType, double>
			{
				{
					ContactType.Head,
					Mix(母方.Sesnsitivities[ContactType.Head], 父方.Sesnsitivities[ContactType.Head], 0.6)
				},
				{
					ContactType.Face,
					Mix(母方.Sesnsitivities[ContactType.Face], 父方.Sesnsitivities[ContactType.Face], 0.6)
				},
				{
					ContactType.Ear,
					Mix(母方.Sesnsitivities[ContactType.Ear], 父方.Sesnsitivities[ContactType.Ear], 0.6)
				},
				{
					ContactType.Mouth,
					Mix(母方.Sesnsitivities[ContactType.Mouth], 父方.Sesnsitivities[ContactType.Mouth], 0.6)
				},
				{
					ContactType.Hair,
					Mix(母方.Sesnsitivities[ContactType.Hair], 父方.Sesnsitivities[ContactType.Hair], 0.6)
				},
				{
					ContactType.Neck,
					Mix(母方.Sesnsitivities[ContactType.Neck], 父方.Sesnsitivities[ContactType.Neck], 0.6)
				},
				{
					ContactType.Shoulder,
					Mix(母方.Sesnsitivities[ContactType.Shoulder], 父方.Sesnsitivities[ContactType.Shoulder], 0.6)
				},
				{
					ContactType.Chest,
					Mix(母方.Sesnsitivities[ContactType.Chest], 父方.Sesnsitivities[ContactType.Chest], 0.6)
				},
				{
					ContactType.Milk,
					Mix(母方.Sesnsitivities[ContactType.Milk], 父方.Sesnsitivities[ContactType.Milk], 0.6)
				},
				{
					ContactType.Side,
					Mix(母方.Sesnsitivities[ContactType.Side], 父方.Sesnsitivities[ContactType.Side], 0.6)
				},
				{
					ContactType.Stomache,
					Mix(母方.Sesnsitivities[ContactType.Stomache], 父方.Sesnsitivities[ContactType.Stomache], 0.6)
				},
				{
					ContactType.Crotch,
					Mix(母方.Sesnsitivities[ContactType.Crotch], 父方.Sesnsitivities[ContactType.Crotch], 0.6)
				},
				{
					ContactType.Sex,
					Mix(母方.Sesnsitivities[ContactType.Sex], 父方.Sesnsitivities[ContactType.Sex], 0.6)
				},
				{
					ContactType.Vagina,
					Mix(母方.Sesnsitivities[ContactType.Vagina], 父方.Sesnsitivities[ContactType.Vagina], 0.6)
				},
				{
					ContactType.Nucleus,
					Mix(母方.Sesnsitivities[ContactType.Nucleus], 父方.Sesnsitivities[ContactType.Nucleus], 0.6)
				},
				{
					ContactType.Anal,
					Mix(母方.Sesnsitivities[ContactType.Anal], 父方.Sesnsitivities[ContactType.Anal], 0.6)
				},
				{
					ContactType.Thread,
					Mix(母方.Sesnsitivities[ContactType.Thread], 父方.Sesnsitivities[ContactType.Thread], 0.6)
				},
				{
					ContactType.Thigh,
					Mix(母方.Sesnsitivities[ContactType.Thigh], 父方.Sesnsitivities[ContactType.Thigh], 0.6)
				},
				{
					ContactType.Feet,
					Mix(母方.Sesnsitivities[ContactType.Feet], 父方.Sesnsitivities[ContactType.Feet], 0.6)
				},
				{
					ContactType.Hand,
					Mix(母方.Sesnsitivities[ContactType.Hand], 父方.Sesnsitivities[ContactType.Hand], 0.6)
				},
				{
					ContactType.Awareness,
					Mix(母方.Sesnsitivities[ContactType.Awareness], 父方.Sesnsitivities[ContactType.Awareness], 0.6)
				},
				{
					ContactType.Touch,
					Mix(母方.Sesnsitivities[ContactType.Touch], 父方.Sesnsitivities[ContactType.Touch], 0.6)
				},
				{
					ContactType.Tail,
					Mix(母方.Sesnsitivities[ContactType.Tail], 父方.Sesnsitivities[ContactType.Tail], 0.6)
				},
				{
					ContactType.Wing,
					Mix(母方.Sesnsitivities[ContactType.Wing], 父方.Sesnsitivities[ContactType.Wing], 0.6)
				},
				{
					ContactType.Fin,
					Mix(母方.Sesnsitivities[ContactType.Fin], 父方.Sesnsitivities[ContactType.Fin], 0.6)
				},
				{
					ContactType.Other,
					Mix(母方.Sesnsitivities[ContactType.Other], 父方.Sesnsitivities[ContactType.Other], 0.6)
				}
			},
			最乳首 = Mix(母方.最乳首, 父方.最乳首, 1.0),
			最乳房 = Mix(母方.最乳房, 父方.最乳房, 1.0),
			最陰核 = Mix(母方.最陰核, 父方.最陰核, 1.0),
			素乳首濃度 = 0.3 + Mix(母方.素乳首濃度, 父方.素乳首濃度, 0.5),
			最乳首濃度 = Mix(母方.最乳首濃度, 父方.最乳首濃度, 0.19999999999999996),
			素性器濃度 = 0.3 + Mix(母方.素性器濃度, 父方.素性器濃度, 0.5),
			最性器濃度 = Mix(母方.最性器濃度, 父方.最性器濃度, 0.19999999999999996),
			素肛門濃度 = 0.3 + Mix(母方.素肛門濃度, 父方.素肛門濃度, 0.5),
			最肛門濃度 = Mix(母方.最肛門濃度, 父方.最肛門濃度, 0.19999999999999996),
			最陰毛濃度 = Mix(母方.最陰毛濃度, 父方.最陰毛濃度, 1.0),
			固有値 = Mix(母方.固有値, 父方.固有値, 1.0),
			魔力濃度 = num
		};
	}

	private static double Mix(double 母方, double 父方, double max)
	{
		return RNG.XS.Next(4) switch
		{
			0 => (母方 + (double)RNG.XS.NextSign() * RNG.XS.NextDouble(0.15)).Clamp(0.0, max), 
			1 => (父方 + (double)RNG.XS.NextSign() * RNG.XS.NextDouble(0.15)).Clamp(0.0, max), 
			2 => ((母方 + 父方) * 0.5 + (double)RNG.XS.NextSign() * RNG.XS.NextDouble(0.15)).Clamp(0.0, max), 
			_ => RNG.XS.NextDouble(max), 
		};
	}

	public static Unit Mix(this Unit 母方, Unit 父方, bool 原種モード)
	{
		Unit unit = new Unit();
		unit.Mother = 母方;
		unit.Father = 父方;
		unit.ChaD = 母方.ChaD.Mix(父方.ChaD, 原種モード);
		if (母方.Race != 父方.Race)
		{
			unit.Race = GameText.ミックス;
		}
		else
		{
			unit.Race = 母方.Race;
		}
		unit.Name = unit.Race;
		unit.種族情報 = 母方.種族情報.Mix(父方.種族情報);
		unit.妊娠進行期間 = (母方.妊娠進行期間 + 父方.妊娠進行期間) / 2;
		foreach (EleD item in unit.ChaD.body_tree.EnumEleD())
		{
			item.SetValuesD("傷", false);
			item.欠損 = false;
		}
		unit.Set衣装();
		unit.Set交配素質();
		unit.Set構成特性();
		return unit;
	}

	public static RaceInformation Mix(this RaceInformation 母方, RaceInformation 父方)
	{
		return new RaceInformation((母方.希少 + 父方.希少) / 2, (母方.需要 + 父方.需要) / 2, (母方.危険 + 父方.危険) / 2, Mix(母方.一般, 父方.一般, 9), Mix(母方.娼婦, 父方.娼婦, 9));
	}

	private static int Mix(int 母方, int 父方, int max)
	{
		return RNG.XS.Next(4) switch
		{
			0 => (母方 + RNG.XS.NextSign()).Clamp(1, max), 
			1 => (父方 + RNG.XS.NextSign()).Clamp(1, max), 
			2 => ((母方 + 父方) / 2 + RNG.XS.NextSign()).Clamp(1, max), 
			_ => RNG.XS.NextM(max).Clamp(1, max), 
		};
	}
}
