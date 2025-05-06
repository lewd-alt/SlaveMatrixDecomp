using System;
using System.Collections.Generic;
using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix;

public enum EmotionType
{
    none,
    Denial,
    Humiliation,
    Shame,
    Acceptance,
    Desire,
    Excitement,
    余裕,
    Happiness,
    Joy,
    Lewd,
    Other
}

public static class Reactions
{
	public const int 眉_0数 = 5;

	public static Dictionary<EmotionType, List<int>> 眉_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 3, 4 }
		},
		{
			EmotionType.Shame,
			new List<int> { 3, 4 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 0, 3, 4 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0, 3, 4 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0 }
		},
		{
			EmotionType.Joy,
			new List<int> { 0, 3, 4 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 0, 3, 4 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 眉_1数 = 2;

	public static Dictionary<EmotionType, List<int>> 眉_1感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0 }
		},
		{
			EmotionType.Shame,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 単眉_0数 = 3;

	public static Dictionary<EmotionType, List<int>> 単眉_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0 }
		},
		{
			EmotionType.Joy,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 単眉_1数 = 2;

	public static Dictionary<EmotionType, List<int>> 単眉_1感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0 }
		},
		{
			EmotionType.Shame,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 目_0数 = 4;

	public static Dictionary<EmotionType, List<int>> 目_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1, 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 0 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0 }
		},
		{
			EmotionType.Joy,
			new List<int> { 0 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 0 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 頬目_0数 = 4;

	public static Dictionary<EmotionType, List<int>> 頬目_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1, 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 0 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0 }
		},
		{
			EmotionType.Joy,
			new List<int> { 0 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 0 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 額目_0数 = 4;

	public static Dictionary<EmotionType, List<int>> 額目_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1, 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 0 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0 }
		},
		{
			EmotionType.Joy,
			new List<int> { 0 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 0 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 単目_0数 = 4;

	public static Dictionary<EmotionType, List<int>> 単目_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1, 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 0 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0 }
		},
		{
			EmotionType.Joy,
			new List<int> { 0 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 0 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	private static HashSet<string> 瞼NGパターン = new HashSet<string>
	{
		"0,1,3,3", "1,0,3,3", "1,0,1,2", "0,1,1,2", "1,0,2,1", "0,1,2,1", "0,1,2,2", "1,0,2,2", "0,1,2,0", "1,0,2,0",
		"0,1,0,2", "1,0,0,2", "1,0,2,3", "0,1,2,3", "1,0,3,2", "0,1,3,2", "0,0,2,0", "0,0,0,2", "1,0,0,3", "0,1,0,3",
		"1,0,3,0", "0,1,3,0", "0,0,0,3", "0,0,3,0", "0,0,1,2", "0,0,2,1", "1,0,1,3", "0,1,1,3", "1,0,3,1", "0,1,3,1",
		"0,0,3,2", "0,0,2,3", "0,0,3,1", "0,0,1,3", "1,0,0,0", "0,1,0,0"
	};

	public const int 瞼_0数 = 2;

	public static Dictionary<EmotionType, List<int>> 瞼_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 頬瞼_0数 = 2;

	public static Dictionary<EmotionType, List<int>> 頬瞼_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 額瞼_0数 = 2;

	public static Dictionary<EmotionType, List<int>> 額瞼_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 単瞼_0数 = 2;

	public static Dictionary<EmotionType, List<int>> 単瞼_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 瞼_1数 = 4;

	public static Dictionary<EmotionType, List<int>> 瞼_1感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2, 3 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1, 3 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 頬瞼_1数 = 4;

	public static Dictionary<EmotionType, List<int>> 頬瞼_1感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2, 3 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1, 3 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 額瞼_1数 = 4;

	public static Dictionary<EmotionType, List<int>> 額瞼_1感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2, 3 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1, 3 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 単瞼_1数 = 4;

	public static Dictionary<EmotionType, List<int>> 単瞼_1感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2, 3 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1, 3 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 口_0数 = 14;

	public static Dictionary<EmotionType, List<int>> 口_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 9, 10 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 9, 10, 11 }
		},
		{
			EmotionType.Shame,
			new List<int> { 0, 9, 10, 11 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 4 }
		},
		{
			EmotionType.Desire,
			new List<int> { 3, 5, 6, 12 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 3, 6, 12 }
		},
		{
			EmotionType.余裕,
			new List<int> { 4, 5, 6, 7 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 4, 5, 6 }
		},
		{
			EmotionType.Joy,
			new List<int> { 5, 6 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 3, 5, 6, 12 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 4 }
		}
	};

	public static HashSet<int> Tongue = new HashSet<int> { 3, 6, 12, 13 };

	public const int 舌_0数 = 2;

	public const int 耳_0数 = 3;

	public static Dictionary<EmotionType, List<int>> 耳_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 0 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 0 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 獣耳_0数 = 3;

	public static Dictionary<EmotionType, List<int>> 獣耳_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 0 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 0 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 触覚_0数 = 3;

	public static Dictionary<EmotionType, List<int>> 触覚_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 触覚甲_0数 = 3;

	public static Dictionary<EmotionType, List<int>> 触覚甲_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 大顎_0数 = 3;

	public static int[] 大顎_0基本 = new int[3] { 0, 1, 2 };

	public static Dictionary<EmotionType, List<int>> 大顎_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 虫顎_0数 = 3;

	public static int[] 虫顎_0基本 = new int[3] { 0, 1, 2 };

	public static Dictionary<EmotionType, List<int>> 虫顎_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 腕人_0数 = 19;

	public static int[] 腕人_0基本 = new int[1] { 7 };

	public static Dictionary<EmotionType, List<int>> 腕人_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 7 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1, 8 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 3, 6, 7 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 4, 5, 6, 8, 10, 11, 12 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 3, 6, 7, 18 }
		},
		{
			EmotionType.Desire,
			new List<int> { 6, 9, 13, 17 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 2, 7, 13, 18 }
		},
		{
			EmotionType.余裕,
			new List<int> { 7, 13, 14 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 3, 7 }
		},
		{
			EmotionType.Joy,
			new List<int> { 3, 4, 5, 6, 10, 11, 12, 15, 18 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 2, 6, 9, 13, 14, 15, 17, 18 }
		},
		{
			EmotionType.Other,
			new List<int> { 3, 6, 7, 14 }
		}
	};

	public const int 腕翼鳥_0数 = 7;

	public static int[] 腕翼鳥_0基本 = new int[2] { 4, 5 };

	public static Dictionary<EmotionType, List<int>> 腕翼鳥_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 4 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1, 5 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2, 3 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 5 }
		},
		{
			EmotionType.Desire,
			new List<int> { 5, 6 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0, 5, 6 }
		},
		{
			EmotionType.余裕,
			new List<int> { 4 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 4 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2, 5, 6 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 0, 1, 5, 6 }
		},
		{
			EmotionType.Other,
			new List<int> { 4, 5, 6 }
		}
	};

	public const int 腕翼獣_0数 = 5;

	public static int[] 腕翼獣_0基本 = new int[2] { 2, 3 };

	public static Dictionary<EmotionType, List<int>> 腕翼獣_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 2 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1, 3 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 3 }
		},
		{
			EmotionType.Desire,
			new List<int> { 3, 4 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0, 3, 4 }
		},
		{
			EmotionType.余裕,
			new List<int> { 2 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 3, 4 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 0, 1, 3, 4 }
		},
		{
			EmotionType.Other,
			new List<int> { 2, 3, 4 }
		}
	};

	public const int 腕獣_0数 = 3;

	public static int[] 腕獣_0基本 = new int[3] { 0, 1, 2 };

	public static Dictionary<EmotionType, List<int>> 腕獣_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 2 }
		}
	};

	public const int 脚人_0数 = 10;

	public static int[] 脚人_0基本 = new int[1] { 5 };

	public static Dictionary<EmotionType, List<int>> 脚人_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 5 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1, 2, 4 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 3, 4 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2, 4 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 3, 8 }
		},
		{
			EmotionType.Desire,
			new List<int> { 0, 7, 8, 9 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 6, 8 }
		},
		{
			EmotionType.余裕,
			new List<int> { 5, 8 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 3, 8 }
		},
		{
			EmotionType.Joy,
			new List<int> { 0, 4, 6, 8 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 0, 3, 6, 7, 8, 9 }
		},
		{
			EmotionType.Other,
			new List<int> { 4, 5 }
		}
	};

	public const int 脚獣_0数 = 3;

	public static int[] 脚獣_0基本 = new int[3] { 0, 1, 2 };

	public static Dictionary<EmotionType, List<int>> 脚獣_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Desire,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 2 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 翼鳥_0数 = 7;

	public const int 翼獣_0数 = 7;

	public static int[] 翼_0基本 = new int[2] { 0, 5 };

	public static Dictionary<EmotionType, List<int>> 翼_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 4 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1, 5 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 1, 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2, 3 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 4, 5 }
		},
		{
			EmotionType.Desire,
			new List<int> { 5, 6 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0, 5, 6 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 4, 5 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 4, 5 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2, 5, 6 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 0, 1, 5, 6 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 4, 5, 6 }
		}
	};

	public const int 鰭_0数 = 3;

	public static int[] 鰭_0基本 = new int[3] { 0, 1, 2 };

	public static Dictionary<EmotionType, List<int>> 鰭_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 2 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 2 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 2 }
		}
	};

	public const int 葉_0数 = 3;

	public static int[] 葉_0基本 = new int[3] { 0, 1, 2 };

	public static Dictionary<EmotionType, List<int>> 葉_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 2 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 2 }
		}
	};

	public const int 前翅_0数 = 3;

	public static int[] 前翅_0基本 = new int[3] { 0, 1, 2 };

	public static Dictionary<EmotionType, List<int>> 前翅_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 2 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 前翅_1数 = 3;

	public static int[] 前翅_1基本 = new int[3] { 0, 1, 2 };

	public static Dictionary<EmotionType, List<int>> 前翅_1感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0 }
		},
		{
			EmotionType.Shame,
			new List<int> { 0 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 2 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 0, 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1, 2 }
		}
	};

	public const int 後翅_0数 = 3;

	public static int[] 後翅_0基本 = new int[3] { 0, 1, 2 };

	public static Dictionary<EmotionType, List<int>> 後翅_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 2 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 後翅_1数 = 3;

	public static int[] 後翅_1基本 = new int[3] { 0, 1, 2 };

	public static Dictionary<EmotionType, List<int>> 後翅_1感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0 }
		},
		{
			EmotionType.Shame,
			new List<int> { 0 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 2 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 0, 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1, 2 }
		}
	};

	public const int 触肢蜘_0数 = 3;

	public static int[] 触肢蜘_0基本 = new int[3] { 0, 1, 2 };

	public static int[] 触肢蜘_0拘束 = new int[2] { 0, 1 };

	public static Dictionary<EmotionType, List<int>> 触肢蜘_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 2 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 触肢蠍_0数 = 3;

	public static int[] 触肢蠍_0基本 = new int[3] { 0, 1, 2 };

	public static int[] 触肢蠍_0拘束 = new int[1];

	public static Dictionary<EmotionType, List<int>> 触肢蠍_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 2 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 節足蜘_0数 = 3;

	public static int[] 節足蜘_0基本 = new int[3] { 0, 1, 2 };

	public static Dictionary<EmotionType, List<int>> 節足蜘_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 2 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 節足蠍_0数 = 3;

	public static int[] 節足蠍_0基本 = new int[3] { 0, 1, 2 };

	public static Dictionary<EmotionType, List<int>> 節足蠍_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 2 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 節足百_0数 = 3;

	public static int[] 節足百_0基本 = new int[3] { 0, 1, 2 };

	public static Dictionary<EmotionType, List<int>> 節足百_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 2 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 節尾曳_0数 = 3;

	public static int[] 節尾曳_0基本 = new int[3] { 0, 1, 2 };

	public static Dictionary<EmotionType, List<int>> 節尾曳_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 2 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 節尾鋏_0数 = 3;

	public static int[] 節尾鋏_0基本 = new int[3] { 0, 1, 2 };

	public static Dictionary<EmotionType, List<int>> 節尾鋏_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 2 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 虫鎌_0数 = 3;

	public static int[] 虫鎌_0基本 = new int[1];

	public static Dictionary<EmotionType, List<int>> 虫鎌_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Shame,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 2 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0 }
		},
		{
			EmotionType.Joy,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 0, 1, 2 }
		},
		{
			EmotionType.Other,
			new List<int> { 0 }
		}
	};

	public const int 触手_0数 = 4;

	public static int[] 触手_0基本 = new int[1] { 1 };

	public static Dictionary<EmotionType, List<int>> 触手_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 0, 2 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 0, 1, 2, 3 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 触手犬_0数 = 4;

	public static int[] 触手犬_0基本 = new int[4] { 0, 1, 2, 3 };

	public static Dictionary<EmotionType, List<int>> 触手犬_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 2 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 1, 3 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 3 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1, 2, 3 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 2, 3 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 2, 3 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 3 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 尾_0数 = 4;

	public static int[] 尾_0基本 = new int[4] { 0, 1, 2, 3 };

	public static Dictionary<EmotionType, List<int>> 尾_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2, 3 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2, 3 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 長胴_0数 = 1;

	public const int 魚_0数 = 4;

	public static int[] 魚_0基本 = new int[4] { 0, 1, 2, 3 };

	public static Dictionary<EmotionType, List<int>> 魚_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2, 3 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2, 3 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 鯨_0数 = 4;

	public static int[] 鯨_0基本 = new int[4] { 0, 1, 2, 3 };

	public static Dictionary<EmotionType, List<int>> 鯨_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2, 3 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2, 3 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 蠍_0数 = 4;

	public static int[] 蠍_0基本 = new int[4] { 0, 1, 2, 3 };

	public static Dictionary<EmotionType, List<int>> 蠍_0感情対応 = new Dictionary<EmotionType, List<int>>
	{
		{
			EmotionType.none,
			new List<int> { 0 }
		},
		{
			EmotionType.Denial,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Humiliation,
			new List<int> { 2 }
		},
		{
			EmotionType.Shame,
			new List<int> { 1, 2 }
		},
		{
			EmotionType.Acceptance,
			new List<int> { 0 }
		},
		{
			EmotionType.Desire,
			new List<int> { 1 }
		},
		{
			EmotionType.Excitement,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.余裕,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Happiness,
			new List<int> { 0, 1 }
		},
		{
			EmotionType.Joy,
			new List<int> { 1, 2, 3 }
		},
		{
			EmotionType.Lewd,
			new List<int> { 1, 2, 3 }
		},
		{
			EmotionType.Other,
			new List<int> { 0, 1 }
		}
	};

	public const int 植_0数 = 1;

	public static void SetInitialAngle(this Cha Cha)
	{
		Ele[] Elements = Cha.Bod.Elements;
		foreach (Ele obj in Elements)
		{
			obj.AngleAll = 0.0;
			obj.SetAngle0();
		}
	}

	public static void SetSymmetry(this Cha Cha)
	{
		Ele[] Elements = Cha.Bod.Elements;
		try
		{
			List<Ele> list = new List<Ele>();
			List<Ele> list2 = new List<Ele>();
			Ele[] array = Elements;
			foreach (Ele ele in array)
			{
				string text = ele.ConnectionType.ToString();
				if (!(ele is 尾_鳥) && !ele.ConnectionType.Is左右無し())
				{
					if (text.Contains("左") && (ele is 触手 || ele is 尾))
					{
						list.Add(ele);
					}
					else if (text.Contains("右") && (ele is 触手 || ele is 尾))
					{
						list2.Add(ele);
					}
				}
			}
			list.Sort((Ele x, Ele y) => x.ConnectionType.ToString().CompareTo(y.ConnectionType.ToString()));
			list2.Sort((Ele x, Ele y) => x.ConnectionType.ToString().CompareTo(y.ConnectionType.ToString()));
			if (list.Count <= list2.Count)
			{
				for (int j = 0; j < list.Count; j++)
				{
					list[j].SetAngle(list2[j]);
				}
			}
			else if (list.Count >= list2.Count)
			{
				for (int j = 0; j < list2.Count; j++)
				{
					list2[j].SetAngle(list[j]);
				}
			}
			list.Clear();
			list2.Clear();
			array = Elements;
			foreach (Ele ele2 in array)
			{
				string text = ele2.ConnectionType.ToString();
				if (!(ele2 is 尾_鳥) && !ele2.ConnectionType.Is左右無し())
				{
					if (!ele2.右 && (ele2 is 触手 || ele2 is 尾))
					{
						list.Add(ele2);
					}
					else if (ele2.右 && (ele2 is 触手 || ele2 is 尾))
					{
						list2.Add(ele2);
					}
				}
			}
			list.Sort((Ele x, Ele y) => x.ToString().CompareTo(y.ToString()));
			list2.Sort((Ele x, Ele y) => x.ToString().CompareTo(y.ToString()));
			if (list.Count <= list2.Count)
			{
				for (int j = 0; j < list.Count; j++)
				{
					list[j].SetAngle(list2[j]);
				}
			}
			else if (list.Count >= list2.Count)
			{
				for (int j = 0; j < list2.Count; j++)
				{
					list2[j].SetAngle(list[j]);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static void 重複角度処理(this Ele e)
	{
		int num = -1;
		int num2 = 0;
		bool flag = true;
		string text = e.GetType().ToString();
		foreach (Ele item in e.Par.EnumConnectionType(e.ConnectionType))
		{
			if (!(item.GetType().ToString() == text))
			{
				continue;
			}
			if (flag)
			{
				if (item != e)
				{
					num2++;
				}
				else
				{
					flag = false;
				}
			}
			num++;
		}
		if (num2 >= num)
		{
			return;
		}
		if (e.右)
		{
			if (e is 四足脇)
			{
				double num3 = (double)(num - num2) * -13.0;
				e.角度B += num3;
			}
			else if (e.Par is 多足_蛸)
			{
				double num4 = (double)num2 * -17.0;
				e.角度B += num4;
			}
			else if (e is 触手_犬)
			{
				double num5 = (double)(num - num2) * 17.0;
				e.角度B += num5;
				触手_犬 obj = (触手_犬)e;
				obj.X0Y0_脚前_上腕.AngleBase -= num5;
				obj.X0Y0_脚後_上腕.AngleBase -= num5;
			}
			else
			{
				double num6 = (double)(num - num2) * -17.0;
				e.角度B += num6;
			}
		}
		else if (e is 四足脇)
		{
			double num3 = (double)(num - num2) * 13.0;
			e.角度B += num3;
		}
		else if (e.Par is 多足_蛸)
		{
			double num7 = (double)num2 * 17.0;
			e.角度B += num7;
		}
		else if (e is 触手_犬)
		{
			double num8 = (double)(num - num2) * -17.0;
			e.角度B += num8;
			触手_犬 obj2 = (触手_犬)e;
			obj2.X0Y0_脚前_上腕.AngleBase -= num8;
			obj2.X0Y0_脚後_上腕.AngleBase -= num8;
		}
		else
		{
			double num9 = (double)(num - num2) * 17.0;
			e.角度B += num9;
		}
	}

	public static double 角度ムラ(this Cha c, int rs1, double ba1, int rs2, double ba2)
	{
		return (double)rs1 * ba1 * c.ChaD.固有値 + (double)rs2 * ba2 * RNG.XS.NextDouble();
	}

	public static void 眉_無左(this Cha Cha, double u1)
	{
		Cha.Bod.眉左.眉間_表示 = false;
		Cha.Bod.眉左.Yi = 0;
		Cha.Bod.眉左.角度B = u1;
	}

	public static void 眉_無右(this Cha Cha, double u1)
	{
		Cha.Bod.眉右.眉間_表示 = false;
		Cha.Bod.眉右.Yi = 0;
		Cha.Bod.眉右.角度B = 0.0 - u1;
	}

	public static void 眉_吊左(this Cha Cha, bool 眉間, double u1)
	{
		Cha.Bod.眉左.眉間_表示 = 眉間;
		Cha.Bod.眉左.Yi = 1;
		Cha.Bod.眉左.角度B = u1;
	}

	public static void 眉_吊右(this Cha Cha, bool 眉間, double u1)
	{
		Cha.Bod.眉右.眉間_表示 = 眉間;
		Cha.Bod.眉右.Yi = 1;
		Cha.Bod.眉右.角度B = 0.0 - u1;
	}

	public static void 眉_顰左(this Cha Cha, bool 眉間, double u1)
	{
		Cha.Bod.眉左.眉間_表示 = 眉間;
		Cha.Bod.眉左.Yi = 2;
		Cha.Bod.眉左.角度B = u1;
	}

	public static void 眉_顰右(this Cha Cha, bool 眉間, double u1)
	{
		Cha.Bod.眉右.眉間_表示 = 眉間;
		Cha.Bod.眉右.Yi = 2;
		Cha.Bod.眉右.角度B = 0.0 - u1;
	}

	public static void 両眉_無(this Cha Cha)
	{
		double u = Cha.角度ムラ(RNG.XS.NextSign(), 0.5, RNG.XS.NextSign(), 0.25);
		Cha.眉_無左(u);
		Cha.眉_無右(u);
	}

	public static void 両眉_顰(this Cha Cha)
	{
		double u = Cha.角度ムラ(RNG.XS.NextSign(), 0.5, RNG.XS.NextSign(), 0.25);
		bool flag = Cha.ChaD.固有値 * RNG.XS.NextDouble() > 0.5;
		Cha.眉_顰左(flag, u);
		Cha.眉_顰右(!flag, u);
	}

	public static void 両眉_0(this Cha Cha, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 1.0, RNG.XS.NextSign(), 0.5);
		double u = ((!同角) ? Cha.角度ムラ(RNG.XS.NextSign(), 1.0, RNG.XS.NextSign(), 0.5) : num);
		Cha.眉左_0(i1, num);
		Cha.眉右_0(i2, u);
	}

	public static void 眉左_0(this Cha c, int i, double u1)
	{
		switch (i)
		{
		case 0:
			c.眉_無左(u1);
			break;
		case 1:
			c.眉_吊左(眉間: false, u1);
			break;
		case 2:
			c.眉_吊左(眉間: true, u1);
			break;
		case 3:
			c.眉_顰左(眉間: false, u1);
			break;
		case 4:
			c.眉_顰左(眉間: true, u1);
			break;
		}
	}

	public static void 眉右_0(this Cha c, int i, double u1)
	{
		switch (i)
		{
		case 0:
			c.眉_無右(u1);
			break;
		case 1:
			c.眉_吊右(眉間: false, u1);
			break;
		case 2:
			c.眉_吊右(眉間: true, u1);
			break;
		case 3:
			c.眉_顰右(眉間: false, u1);
			break;
		case 4:
			c.眉_顰右(眉間: true, u1);
			break;
		}
	}

	public static void 眉_下左(this Cha Cha)
	{
		Cha.Bod.眉左.本体.CurJoinRoot.PositionCont = Dat.Vec2DZero;
	}

	public static void 眉_下右(this Cha Cha)
	{
		Cha.Bod.眉右.本体.CurJoinRoot.PositionCont = Dat.Vec2DZero;
	}

	public static void 眉_上左(this Cha Cha)
	{
		Cha.Bod.眉左.本体.CurJoinRoot.PositionCont = -Dat.Vec2DUnitY * 0.003;
	}

	public static void 眉_上右(this Cha Cha)
	{
		Cha.Bod.眉右.本体.CurJoinRoot.PositionCont = -Dat.Vec2DUnitY * 0.003;
	}

	public static void 両眉_下(this Cha Cha)
	{
		Cha.眉_下左();
		Cha.眉_下右();
	}

	public static void 両眉_上(this Cha Cha)
	{
		Cha.眉_上左();
		Cha.眉_上右();
	}

	public static void 両眉_1(this Cha Cha, int i1, int i2)
	{
		Cha.眉左_1(i1);
		Cha.眉右_1(i2);
	}

	public static void 眉左_1(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.眉_下左();
			break;
		case 1:
			c.眉_上左();
			break;
		}
	}

	public static void 眉右_1(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.眉_下右();
			break;
		case 1:
			c.眉_上右();
			break;
		}
	}

	public static void 単眉_無(this Cha Cha)
	{
		Cha.Bod.単眼眉.Yi = 0;
	}

	public static void 単眉_吊(this Cha Cha)
	{
		Cha.Bod.単眼眉.Yi = 1;
	}

	public static void 単眉_顰(this Cha Cha)
	{
		Cha.Bod.単眼眉.Yi = 2;
	}

	public static void 単眉_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.単眉_無();
			break;
		case 1:
			c.単眉_吊();
			break;
		case 2:
			c.単眉_顰();
			break;
		}
	}

	public static void 単眉_下(this Cha Cha)
	{
		Cha.Bod.単眼眉.本体.CurJoinRoot.PositionCont = Dat.Vec2DZero;
	}

	public static void 単眉_上(this Cha Cha)
	{
		Cha.Bod.単眼眉.本体.CurJoinRoot.PositionCont = -Dat.Vec2DUnitY * 0.003;
	}

	public static void 単眉_1(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.単眉_下();
			break;
		case 1:
			c.単眉_上();
			break;
		}
	}

	public static void 目_見つめ左(this Cha Cha)
	{
		Cha.Bod.目左.視線 = new Vector2D(0.0, -0.00023);
		Cha.Bod.目左.X0Y0_黒目_黒目.SizeXCont = 1.0;
		Cha.Bod.目左.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
	}

	public static void 目_見つめ右(this Cha Cha)
	{
		Cha.Bod.目右.視線 = new Vector2D(0.0, -0.00023);
		Cha.Bod.目右.X0Y0_黒目_黒目.SizeXCont = 1.0;
		Cha.Bod.目右.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
	}

	public static void 目_逸らし左(this Cha Cha, bool b)
	{
		Cha.Bod.目左.視線 = new Vector2D((b ? 1.0 : (-1.0)) * 0.0015, 0.0);
		Cha.Bod.目左.X0Y0_黒目_黒目.SizeXCont = 0.95;
		Cha.Bod.目左.X0Y0_黒目_瞳孔.SizeXCont = 0.95;
	}

	public static void 目_逸らし右(this Cha Cha, bool b)
	{
		Cha.Bod.目右.視線 = new Vector2D((b ? 1.0 : (-1.0)) * 0.0015, 0.0);
		Cha.Bod.目右.X0Y0_黒目_黒目.SizeXCont = 0.95;
		Cha.Bod.目右.X0Y0_黒目_瞳孔.SizeXCont = 0.95;
	}

	public static void 目_上転左(this Cha Cha)
	{
		Cha.Bod.目左.視線 = new Vector2D(0.0, -0.0021);
		Cha.Bod.目左.X0Y0_黒目_黒目.SizeXCont = 1.0;
		Cha.Bod.目左.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
	}

	public static void 目_上転右(this Cha Cha)
	{
		Cha.Bod.目右.視線 = new Vector2D(0.0, -0.002);
		Cha.Bod.目右.X0Y0_黒目_黒目.SizeXCont = 1.0;
		Cha.Bod.目右.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
	}

	public static void 両目_見つめ(this Cha Cha)
	{
		Cha.目_見つめ左();
		Cha.目_見つめ右();
	}

	public static void 両目_0(this Cha Cha, int i1, int i2)
	{
		Cha.目左_0(i1);
		Cha.目右_0(i2);
	}

	public static void 目左_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.目_見つめ左();
			break;
		case 1:
			c.目_逸らし左(b: false);
			break;
		case 2:
			c.目_逸らし左(b: true);
			break;
		case 3:
			c.目_上転左();
			break;
		}
	}

	public static void 目右_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.目_見つめ右();
			break;
		case 1:
			c.目_逸らし右(b: false);
			break;
		case 2:
			c.目_逸らし右(b: true);
			break;
		case 3:
			c.目_上転右();
			break;
		}
	}

	public static void 頬目_見つめ左(this Cha Cha)
	{
		Cha.Bod.頬目左.視線 = new Vector2D(0.0, -0.00023);
		Cha.Bod.頬目左.X0Y0_黒目_黒目.SizeXCont = 1.0;
		Cha.Bod.頬目左.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
		Cha.Bod.頬目左.X0Y0_黒目_黒目.SizeYCont = 1.0;
		Cha.Bod.頬目左.X0Y0_黒目_瞳孔.SizeYCont = 1.0;
	}

	public static void 頬目_見つめ右(this Cha Cha)
	{
		Cha.Bod.頬目右.視線 = new Vector2D(0.0, -0.00023);
		Cha.Bod.頬目右.X0Y0_黒目_黒目.SizeXCont = 1.0;
		Cha.Bod.頬目右.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
		Cha.Bod.頬目右.X0Y0_黒目_黒目.SizeYCont = 1.0;
		Cha.Bod.頬目右.X0Y0_黒目_瞳孔.SizeYCont = 1.0;
	}

	public static void 頬目_逸らし左(this Cha Cha, bool b)
	{
		Cha.Bod.頬目左.視線 = new Vector2D((b ? 1.0 : (-1.0)) * 0.0015, 0.0);
		Cha.Bod.頬目左.X0Y0_黒目_黒目.SizeXCont = 0.95;
		Cha.Bod.頬目左.X0Y0_黒目_瞳孔.SizeXCont = 0.95;
		Cha.Bod.頬目左.X0Y0_黒目_黒目.SizeYCont = 1.0;
		Cha.Bod.頬目左.X0Y0_黒目_瞳孔.SizeYCont = 1.0;
	}

	public static void 頬目_逸らし右(this Cha Cha, bool b)
	{
		Cha.Bod.頬目右.視線 = new Vector2D((b ? 1.0 : (-1.0)) * 0.0015, 0.0);
		Cha.Bod.頬目右.X0Y0_黒目_黒目.SizeXCont = 0.95;
		Cha.Bod.頬目右.X0Y0_黒目_瞳孔.SizeXCont = 0.95;
		Cha.Bod.頬目右.X0Y0_黒目_黒目.SizeYCont = 1.0;
		Cha.Bod.頬目右.X0Y0_黒目_瞳孔.SizeYCont = 1.0;
	}

	public static void 頬目_上転左(this Cha Cha)
	{
		Cha.Bod.頬目左.視線 = new Vector2D(0.0, -0.0016);
		Cha.Bod.頬目左.X0Y0_黒目_黒目.SizeXCont = 1.0;
		Cha.Bod.頬目左.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
		Cha.Bod.頬目左.X0Y0_黒目_黒目.SizeYCont = 0.75;
		Cha.Bod.頬目左.X0Y0_黒目_瞳孔.SizeYCont = 0.75;
	}

	public static void 頬目_上転右(this Cha Cha)
	{
		Cha.Bod.頬目右.視線 = new Vector2D(0.0, -0.0016);
		Cha.Bod.頬目右.X0Y0_黒目_黒目.SizeXCont = 1.0;
		Cha.Bod.頬目右.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
		Cha.Bod.頬目右.X0Y0_黒目_黒目.SizeYCont = 0.75;
		Cha.Bod.頬目右.X0Y0_黒目_瞳孔.SizeYCont = 0.75;
	}

	public static void 両頬目_見つめ(this Cha Cha)
	{
		Cha.頬目_見つめ左();
		Cha.頬目_見つめ右();
	}

	public static void 両頬目_0(this Cha Cha, int i1, int i2)
	{
		Cha.頬目左_0(i1);
		Cha.頬目右_0(i2);
	}

	public static void 頬目左_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.頬目_見つめ左();
			break;
		case 1:
			c.頬目_逸らし左(b: false);
			break;
		case 2:
			c.頬目_逸らし左(b: true);
			break;
		case 3:
			c.頬目_上転左();
			break;
		}
	}

	public static void 頬目右_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.頬目_見つめ右();
			break;
		case 1:
			c.頬目_逸らし右(b: false);
			break;
		case 2:
			c.頬目_逸らし右(b: true);
			break;
		case 3:
			c.頬目_上転右();
			break;
		}
	}

	public static void 額目_見つめ(this Cha Cha)
	{
		Cha.Bod.額目.視線 = new Vector2D(0.0, 0.0);
		Cha.Bod.額目.X0Y0_黒目_黒目.SizeXCont = 1.0;
		Cha.Bod.額目.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
		Cha.Bod.額目.X0Y0_黒目_黒目.SizeYCont = 1.0;
		Cha.Bod.額目.X0Y0_黒目_瞳孔.SizeYCont = 1.0;
	}

	public static void 額目_逸らし(this Cha Cha, bool b)
	{
		Cha.Bod.額目.視線 = new Vector2D((b ? 1.0 : (-1.0)) * 0.0014, 0.0);
		Cha.Bod.額目.X0Y0_黒目_黒目.SizeXCont = 0.9;
		Cha.Bod.額目.X0Y0_黒目_瞳孔.SizeXCont = 0.9;
		Cha.Bod.額目.X0Y0_黒目_黒目.SizeYCont = 1.0;
		Cha.Bod.額目.X0Y0_黒目_瞳孔.SizeYCont = 1.0;
	}

	public static void 額目_上転(this Cha Cha)
	{
		Cha.Bod.額目.視線 = new Vector2D(0.0, -0.0025);
		Cha.Bod.額目.X0Y0_黒目_黒目.SizeXCont = 1.0;
		Cha.Bod.額目.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
		Cha.Bod.額目.X0Y0_黒目_黒目.SizeYCont = 0.95;
		Cha.Bod.額目.X0Y0_黒目_瞳孔.SizeYCont = 0.95;
	}

	public static void 額目_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.額目_見つめ();
			break;
		case 1:
			c.額目_逸らし(b: false);
			break;
		case 2:
			c.額目_逸らし(b: true);
			break;
		case 3:
			c.額目_上転();
			break;
		}
	}

	public static void 単目_見つめ(this Cha Cha)
	{
		Cha.Bod.単眼目.視線 = new Vector2D(0.0, -0.00023);
		Cha.Bod.単眼目.X0Y0_黒目_黒目.SizeXCont = 1.0;
		Cha.Bod.単眼目.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
	}

	public static void 単目_逸らし(this Cha Cha, bool b)
	{
		Cha.Bod.単眼目.視線 = new Vector2D((b ? 1.0 : (-1.0)) * 0.0025, 0.0);
		Cha.Bod.単眼目.X0Y0_黒目_黒目.SizeXCont = 0.95;
		Cha.Bod.単眼目.X0Y0_黒目_瞳孔.SizeXCont = 0.95;
	}

	public static void 単目_上転(this Cha Cha)
	{
		Cha.Bod.単眼目.視線 = new Vector2D(0.0, -0.0035);
		Cha.Bod.単眼目.X0Y0_黒目_黒目.SizeXCont = 1.0;
		Cha.Bod.単眼目.X0Y0_黒目_瞳孔.SizeXCont = 1.0;
	}

	public static void 単目_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.単目_見つめ();
			break;
		case 1:
			c.単目_逸らし(b: false);
			break;
		case 2:
			c.単目_逸らし(b: true);
			break;
		case 3:
			c.単目_上転();
			break;
		}
	}

	public static void 瞼_普左(this Cha Cha)
	{
		Cha.Bod.瞼左.Xi = 0;
	}

	public static void 瞼_普右(this Cha Cha)
	{
		Cha.Bod.瞼右.Xi = 0;
	}

	public static void 瞼_卑左(this Cha Cha)
	{
		Cha.Bod.瞼左.Xi = 1;
	}

	public static void 瞼_卑右(this Cha Cha)
	{
		Cha.Bod.瞼右.Xi = 1;
	}

	public static void 両瞼_卑(this Cha Cha)
	{
		Cha.瞼_卑左();
		Cha.瞼_卑右();
	}

	public static void 両瞼_0(this Cha Cha, int i1, int i2)
	{
		Cha.瞼左_0(i1);
		Cha.瞼右_0(i2);
	}

	public static void 瞼左_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.瞼_普左();
			break;
		case 1:
			c.瞼_卑左();
			break;
		}
	}

	public static void 瞼右_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.瞼_普右();
			break;
		case 1:
			c.瞼_卑右();
			break;
		}
	}

	public static void 頬瞼_普左(this Cha Cha)
	{
		Cha.Bod.頬瞼左.Xi = 0;
	}

	public static void 頬瞼_普右(this Cha Cha)
	{
		Cha.Bod.頬瞼右.Xi = 0;
	}

	public static void 頬瞼_卑左(this Cha Cha)
	{
		Cha.Bod.頬瞼左.Xi = 1;
	}

	public static void 頬瞼_卑右(this Cha Cha)
	{
		Cha.Bod.頬瞼右.Xi = 1;
	}

	public static void 両頬瞼_0(this Cha Cha, int i1, int i2)
	{
		Cha.頬瞼左_0(i1);
		Cha.頬瞼右_0(i2);
	}

	public static void 頬瞼左_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.頬瞼_普左();
			break;
		case 1:
			c.頬瞼_卑左();
			break;
		}
	}

	public static void 頬瞼右_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.頬瞼_普右();
			break;
		case 1:
			c.頬瞼_卑右();
			break;
		}
	}

	public static void 額瞼_普(this Cha Cha)
	{
		Cha.Bod.額瞼.Xi = 0;
	}

	public static void 額瞼_卑(this Cha Cha)
	{
		Cha.Bod.額瞼.Xi = 1;
	}

	public static void 額瞼_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.額瞼_普();
			break;
		case 1:
			c.額瞼_卑();
			break;
		}
	}

	public static void 単瞼_普(this Cha Cha)
	{
		Cha.Bod.単眼瞼.Xi = 0;
	}

	public static void 単瞼_卑(this Cha Cha)
	{
		Cha.Bod.単眼瞼.Xi = 1;
	}

	public static void 単瞼_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.単瞼_普();
			break;
		case 1:
			c.単瞼_卑();
			break;
		}
	}

	public static void 瞼_基左(this Cha Cha)
	{
		Cha.瞼基準左 = 0.0;
	}

	public static void 瞼_基右(this Cha Cha)
	{
		Cha.瞼基準右 = 0.0;
	}

	public static void 瞼_半1左(this Cha Cha)
	{
		Cha.瞼基準左 = 0.2;
	}

	public static void 瞼_半1右(this Cha Cha)
	{
		Cha.瞼基準右 = 0.2;
	}

	public static void 瞼_半2左(this Cha Cha)
	{
		Cha.瞼基準左 = 0.4;
	}

	public static void 瞼_半2右(this Cha Cha)
	{
		Cha.瞼基準右 = 0.4;
	}

	public static void 瞼_瞑左(this Cha Cha)
	{
		Cha.瞼基準左 = 1.0;
	}

	public static void 瞼_瞑右(this Cha Cha)
	{
		Cha.瞼基準右 = 1.0;
	}

	public static void 両瞼_半1(this Cha Cha)
	{
		Cha.瞼_半1左();
		Cha.瞼_半1右();
	}

	public static void 両瞼_半2(this Cha Cha)
	{
		Cha.瞼_半2左();
		Cha.瞼_半2右();
	}

	public static void 両瞼_1(this Cha Cha, int i1, int i2)
	{
		Cha.瞼左_1(i1);
		Cha.瞼右_1(i2);
	}

	public static void 瞼左_1(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.瞼_基左();
			break;
		case 1:
			c.瞼_半1左();
			break;
		case 2:
			c.瞼_半2左();
			break;
		case 3:
			c.瞼_瞑左();
			break;
		}
	}

	public static void 瞼右_1(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.瞼_基右();
			break;
		case 1:
			c.瞼_半1右();
			break;
		case 2:
			c.瞼_半2右();
			break;
		case 3:
			c.瞼_瞑右();
			break;
		}
	}

	public static void 頬瞼_基左(this Cha Cha)
	{
		Cha.瞼基準頬左 = 0.0;
	}

	public static void 頬瞼_基右(this Cha Cha)
	{
		Cha.瞼基準頬右 = 0.0;
	}

	public static void 頬瞼_半1左(this Cha Cha)
	{
		Cha.瞼基準頬左 = 0.2;
	}

	public static void 頬瞼_半1右(this Cha Cha)
	{
		Cha.瞼基準頬右 = 0.2;
	}

	public static void 頬瞼_半2左(this Cha Cha)
	{
		Cha.瞼基準頬左 = 0.4;
	}

	public static void 頬瞼_半2右(this Cha Cha)
	{
		Cha.瞼基準頬右 = 0.4;
	}

	public static void 頬瞼_瞑左(this Cha Cha)
	{
		Cha.瞼基準頬左 = 1.0;
	}

	public static void 頬瞼_瞑右(this Cha Cha)
	{
		Cha.瞼基準頬右 = 1.0;
	}

	public static void 両頬瞼_1(this Cha Cha, int i1, int i2)
	{
		Cha.頬瞼左_1(i1);
		Cha.頬瞼右_1(i2);
	}

	public static void 頬瞼左_1(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.頬瞼_基左();
			break;
		case 1:
			c.頬瞼_半1左();
			break;
		case 2:
			c.頬瞼_半2左();
			break;
		case 3:
			c.頬瞼_瞑左();
			break;
		}
	}

	public static void 頬瞼右_1(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.頬瞼_基右();
			break;
		case 1:
			c.頬瞼_半1右();
			break;
		case 2:
			c.頬瞼_半2右();
			break;
		case 3:
			c.頬瞼_瞑右();
			break;
		}
	}

	public static void 額瞼_基(this Cha Cha)
	{
		Cha.瞼基準額 = 0.0;
	}

	public static void 額瞼_半1(this Cha Cha)
	{
		Cha.瞼基準額 = 0.2;
	}

	public static void 額瞼_半2(this Cha Cha)
	{
		Cha.瞼基準額 = 0.4;
	}

	public static void 額瞼_瞑(this Cha Cha)
	{
		Cha.瞼基準額 = 1.0;
	}

	public static void 額瞼_1(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.額瞼_基();
			break;
		case 1:
			c.額瞼_半1();
			break;
		case 2:
			c.額瞼_半2();
			break;
		case 3:
			c.額瞼_瞑();
			break;
		}
	}

	public static void 単瞼_基(this Cha Cha)
	{
		Cha.瞼基準単 = 0.0;
	}

	public static void 単瞼_半1(this Cha Cha)
	{
		Cha.瞼基準単 = 0.2;
	}

	public static void 単瞼_半2(this Cha Cha)
	{
		Cha.瞼基準単 = 0.4;
	}

	public static void 単瞼_瞑(this Cha Cha)
	{
		Cha.瞼基準単 = 1.0;
	}

	public static void 単瞼_1(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.単瞼_基();
			break;
		case 1:
			c.単瞼_半1();
			break;
		case 2:
			c.単瞼_半2();
			break;
		case 3:
			c.単瞼_瞑();
			break;
		}
	}

	public static void 口_閉じ(this Cha Cha)
	{
		Cha.Bod.口i = 10;
	}

	public static void 口_半開1(this Cha Cha)
	{
		Cha.Bod.口i = 5;
	}

	public static void 口_半開2(this Cha Cha)
	{
		Cha.Bod.口i = 6;
	}

	public static void 口_開き(this Cha Cha)
	{
		Cha.Bod.口i = 9;
	}

	public static void 口_閉笑(this Cha Cha)
	{
		Cha.Bod.口i = 4;
	}

	public static void 口_薄笑(this Cha Cha)
	{
		Cha.Bod.口i = 0;
	}

	public static void 口_笑い(this Cha Cha)
	{
		Cha.Bod.口i = 1;
	}

	public static void 口_薄笑食縛(this Cha Cha)
	{
		Cha.Bod.口i = 2;
	}

	public static void 口_笑い食縛(this Cha Cha)
	{
		Cha.Bod.口i = 3;
	}

	public static void 口_紡ぎ(this Cha Cha)
	{
		Cha.Bod.口i = 11;
	}

	public static void 口_食縛1(this Cha Cha)
	{
		Cha.Bod.口i = 7;
	}

	public static void 口_食縛2(this Cha Cha)
	{
		Cha.Bod.口i = 8;
	}

	public static void 口_咥え(this Cha Cha)
	{
		Cha.Bod.口i = 12;
	}

	public static void 口_しゃぶり(this Cha Cha)
	{
		Cha.Bod.口i = 13;
	}

	public static void 口_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.口_閉じ();
			break;
		case 1:
			c.口_半開1();
			break;
		case 2:
			c.口_半開2();
			break;
		case 3:
			c.口_開き();
			break;
		case 4:
			c.口_閉笑();
			break;
		case 5:
			c.口_薄笑();
			break;
		case 6:
			c.口_笑い();
			break;
		case 7:
			c.口_薄笑食縛();
			break;
		case 8:
			c.口_笑い食縛();
			break;
		case 9:
			c.口_紡ぎ();
			break;
		case 10:
			c.口_食縛1();
			break;
		case 11:
			c.口_食縛2();
			break;
		case 12:
			c.口_咥え();
			break;
		case 13:
			c.口_しゃぶり();
			break;
		}
	}

	public static void 口修正(this Cha c)
	{
		if (c.Bod.口i != 5 && c.Bod.口i != 6 && c.Bod.口i != 7 && c.Bod.口i != 8 && c.Bod.口i != 9 && c.Bod.口i != 12 && c.Bod.口i != 13)
		{
			return;
		}
		if (c.ChaD.Emotion < EmotionType.Acceptance)
		{
			switch (RNG.XS.Next(2))
			{
			case 0:
				c.口_閉じ();
				break;
			case 1:
				c.口_紡ぎ();
				break;
			}
			return;
		}
		switch (RNG.XS.Next(3))
		{
		case 0:
			c.口_閉笑();
			break;
		case 1:
			c.口_薄笑();
			break;
		case 2:
			c.口_笑い();
			break;
		}
	}

	public static void 舌_無し(this Cha Cha)
	{
		Cha.Bod.舌_表示 = false;
	}

	public static void 舌_出し(this Cha Cha)
	{
		Cha.Bod.舌_表示 = true;
		Cha.Bod.舌.尺度YC = 0.2 + 0.8 * RNG.XS.NextDouble();
	}

	public static void 舌_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.舌_無し();
			break;
		case 1:
			c.舌_出し();
			break;
		}
	}

	public static void 耳_人_基左(this Cha Cha)
	{
		Cha.Bod.耳左.Yi = 0;
	}

	public static void 耳_人_基右(this Cha Cha)
	{
		Cha.Bod.耳右.Yi = 0;
	}

	public static void 耳_人_半左(this Cha Cha)
	{
		Cha.Bod.耳左.Yi = 1;
	}

	public static void 耳_人_半右(this Cha Cha)
	{
		Cha.Bod.耳右.Yi = 1;
	}

	public static void 耳_人_伏左(this Cha Cha)
	{
		Cha.Bod.耳左.Yi = 2;
	}

	public static void 耳_人_伏右(this Cha Cha)
	{
		Cha.Bod.耳右.Yi = 2;
	}

	public static void 両耳_0(this Cha Cha, int i1, int i2)
	{
		Cha.耳左_0(i1);
		Cha.耳右_0(i2);
	}

	public static void 耳左_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.耳_人_基左();
			break;
		case 1:
			c.耳_人_半左();
			break;
		case 2:
			c.耳_人_伏左();
			break;
		}
	}

	public static void 耳右_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.耳_人_基右();
			break;
		case 1:
			c.耳_人_半右();
			break;
		case 2:
			c.耳_人_伏右();
			break;
		}
	}

	public static void 耳_獣_基左(this Cha Cha)
	{
		Cha.Bod.獣耳左.Yi = 0;
	}

	public static void 耳_獣_基右(this Cha Cha)
	{
		Cha.Bod.獣耳右.Yi = 0;
	}

	public static void 耳_獣_半左(this Cha Cha)
	{
		Cha.Bod.獣耳左.Yi = 1;
	}

	public static void 耳_獣_半右(this Cha Cha)
	{
		Cha.Bod.獣耳右.Yi = 1;
	}

	public static void 耳_獣_伏左(this Cha Cha)
	{
		Cha.Bod.獣耳左.Yi = 2;
	}

	public static void 耳_獣_伏右(this Cha Cha)
	{
		Cha.Bod.獣耳右.Yi = 2;
	}

	public static void 両獣耳_0(this Cha Cha, int i1, int i2)
	{
		Cha.獣耳左_0(i1);
		Cha.獣耳右_0(i2);
	}

	public static void 獣耳左_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.耳_獣_基左();
			break;
		case 1:
			c.耳_獣_半左();
			break;
		case 2:
			c.耳_獣_伏左();
			break;
		}
	}

	public static void 獣耳右_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.耳_獣_基右();
			break;
		case 1:
			c.耳_獣_半右();
			break;
		case 2:
			c.耳_獣_伏右();
			break;
		}
	}

	public static void 触覚絶頂(this Cha Cha, double a)
	{
		Cha.Bod.触覚左.角度C = a * RNG.XS.NextDouble();
		Cha.Bod.触覚右.角度C = (0.0 - a) * RNG.XS.NextDouble();
	}

	public static void 触覚甲左(this Cha Cha, double u1, double u2, double 根本角度, double 節角度)
	{
		Cha.Bod.触覚甲左.SetAngle0();
		Cha.Bod.触覚甲左.X0Y0_節0.AngleBase += 根本角度 + u1;
		Cha.Bod.触覚甲左.X0Y0_節1.AngleBase += 節角度 + u2;
	}

	public static void 触覚甲右(this Cha Cha, double u1, double u2, double 根本角度, double 節角度)
	{
		Cha.Bod.触覚甲右.SetAngle0();
		Cha.Bod.触覚甲右.X0Y0_節0.AngleBase += 0.0 - 根本角度 + (0.0 - u1);
		Cha.Bod.触覚甲右.X0Y0_節1.AngleBase += 0.0 - 節角度 + (0.0 - u2);
	}

	public static void 触覚甲_基本左(this Cha Cha, double u1, double u2)
	{
		Cha.触覚甲左(u1, u2, 0.0, 0.0);
	}

	public static void 触覚甲_基本右(this Cha Cha, double u1, double u2)
	{
		Cha.触覚甲右(u1, u2, 0.0, 0.0);
	}

	public static void 触覚甲_ピーン左(this Cha Cha, double u1, double u2)
	{
		Cha.触覚甲左(u1, u2, 20.0, -25.0);
	}

	public static void 触覚甲_ピーン右(this Cha Cha, double u1, double u2)
	{
		Cha.触覚甲右(u1, u2, 20.0, -25.0);
	}

	public static void 触覚甲_萎縮左(this Cha Cha, double u1, double u2)
	{
		Cha.触覚甲左(u1, u2, -80.0, 100.0);
	}

	public static void 触覚甲_萎縮右(this Cha Cha, double u1, double u2)
	{
		Cha.触覚甲右(u1, u2, -80.0, 100.0);
	}

	public static void 触覚甲左_0(this Cha c, int i, double u1, double u2)
	{
		switch (i)
		{
		case 0:
			c.触覚甲_基本左(u1, u2);
			break;
		case 1:
			c.触覚甲_ピーン左(u1, u2);
			break;
		case 2:
			c.触覚甲_萎縮左(u1, u2);
			break;
		}
	}

	public static void 触覚甲右_0(this Cha c, int i, double u1, double u2)
	{
		switch (i)
		{
		case 0:
			c.触覚甲_基本右(u1, u2);
			break;
		case 1:
			c.触覚甲_ピーン右(u1, u2);
			break;
		case 2:
			c.触覚甲_萎縮右(u1, u2);
			break;
		}
	}

	public static void 触覚甲絶頂(this Cha Cha, double a)
	{
		Cha.Bod.触覚甲左.角度C = a * RNG.XS.NextDouble();
		Cha.Bod.触覚甲右.角度C = (0.0 - a) * RNG.XS.NextDouble();
	}

	public static void 大顎左(this Cha Cha, int n, double u1, double 根本角度)
	{
		大顎 obj = Cha.Bod.大顎左[n];
		obj.SetAngle0();
		obj.本体.CurJoinRoot.AngleBase += 根本角度 + u1;
	}

	public static void 大顎右(this Cha Cha, int n, double u1, double 根本角度)
	{
		大顎 obj = Cha.Bod.大顎右[n];
		obj.SetAngle0();
		obj.本体.CurJoinRoot.AngleBase += 0.0 - 根本角度 + (0.0 - u1);
	}

	public static void 大顎_基本左(this Cha Cha, int n, double u1)
	{
		Cha.大顎左(n, u1, 0.0);
	}

	public static void 大顎_基本右(this Cha Cha, int n, double u1)
	{
		Cha.大顎右(n, u1, 0.0);
	}

	public static void 大顎_開き左(this Cha Cha, int n, double u1)
	{
		Cha.大顎左(n, u1, 25.0);
	}

	public static void 大顎_開き右(this Cha Cha, int n, double u1)
	{
		Cha.大顎右(n, u1, 25.0);
	}

	public static void 大顎_閉じ左(this Cha Cha, int n, double u1)
	{
		Cha.大顎左(n, u1, -15.0);
	}

	public static void 大顎_閉じ右(this Cha Cha, int n, double u1)
	{
		Cha.大顎右(n, u1, -15.0);
	}

	public static void 両大顎_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num2 = 0.0;
		num2 = ((!同角) ? Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5) : num);
		Cha.大顎左_0(i1, n, num);
		Cha.大顎右_0(i2, n, num2);
	}

	public static void 大顎左_0(this Cha c, int i, int n, double u1)
	{
		switch (i)
		{
		case 0:
			c.大顎_基本左(n, u1);
			break;
		case 1:
			c.大顎_開き左(n, u1);
			break;
		case 2:
			c.大顎_閉じ左(n, u1);
			break;
		}
	}

	public static void 大顎右_0(this Cha c, int i, int n, double u1)
	{
		switch (i)
		{
		case 0:
			c.大顎_基本右(n, u1);
			break;
		case 1:
			c.大顎_開き右(n, u1);
			break;
		case 2:
			c.大顎_閉じ右(n, u1);
			break;
		}
	}

	public static void 大顎絶頂(this Cha Cha, double a)
	{
		foreach (大顎 item in Cha.Bod.大顎左)
		{
			item.角度C = a * RNG.XS.NextDouble();
		}
		foreach (大顎 item2 in Cha.Bod.大顎右)
		{
			item2.角度C = (0.0 - a) * RNG.XS.NextDouble();
		}
	}

	public static void 虫顎左(this Cha Cha, int n, double u1, double 根本角度)
	{
		虫顎 obj = Cha.Bod.虫顎左[n];
		obj.SetAngle0();
		obj.X0Y0_顎.AngleBase += 根本角度 + u1;
	}

	public static void 虫顎右(this Cha Cha, int n, double u1, double 根本角度)
	{
		虫顎 obj = Cha.Bod.虫顎右[n];
		obj.SetAngle0();
		obj.X0Y0_顎.AngleBase += 0.0 - 根本角度 + (0.0 - u1);
	}

	public static void 虫顎_基本左(this Cha Cha, int n, double u1)
	{
		Cha.虫顎左(n, u1, 0.0);
	}

	public static void 虫顎_基本右(this Cha Cha, int n, double u1)
	{
		Cha.虫顎右(n, u1, 0.0);
	}

	public static void 虫顎_開き左(this Cha Cha, int n, double u1)
	{
		Cha.虫顎左(n, u1, 25.0);
	}

	public static void 虫顎_開き右(this Cha Cha, int n, double u1)
	{
		Cha.虫顎右(n, u1, 25.0);
	}

	public static void 虫顎_閉じ左(this Cha Cha, int n, double u1)
	{
		Cha.虫顎左(n, u1, -10.0);
	}

	public static void 虫顎_閉じ右(this Cha Cha, int n, double u1)
	{
		Cha.虫顎右(n, u1, -10.0);
	}

	public static void 両虫顎_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num2 = 0.0;
		num2 = ((!同角) ? Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5) : num);
		Cha.虫顎左_0(i1, n, num);
		Cha.虫顎右_0(i2, n, num2);
	}

	public static void 虫顎左_0(this Cha c, int i, int n, double u1)
	{
		switch (i)
		{
		case 0:
			c.虫顎_基本左(n, u1);
			break;
		case 1:
			c.虫顎_開き左(n, u1);
			break;
		case 2:
			c.虫顎_閉じ左(n, u1);
			break;
		}
	}

	public static void 虫顎右_0(this Cha c, int i, int n, double u1)
	{
		switch (i)
		{
		case 0:
			c.虫顎_基本右(n, u1);
			break;
		case 1:
			c.虫顎_開き右(n, u1);
			break;
		case 2:
			c.虫顎_閉じ右(n, u1);
			break;
		}
	}

	public static void 虫顎絶頂(this Cha Cha, double a)
	{
		foreach (虫顎 item in Cha.Bod.虫顎左)
		{
			item.角度C = a * RNG.XS.NextDouble();
		}
		foreach (虫顎 item2 in Cha.Bod.虫顎右)
		{
			item2.角度C = (0.0 - a) * RNG.XS.NextDouble();
		}
	}

	public static void 腕_人左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double 肩角度B, double 上腕角度B, double 下腕角度B, double 手角度B, double 上腕尺度XC, double 下腕尺度XC, double 手尺度XC, double 下腕尺度C, double 手尺度C, bool 上腕外線, bool 下腕外線, bool 下腕反転Y, int 手Yi, bool 前後)
	{
		腕人 腕人2 = Cha.Bod.腕人左[n];
		腕人2.肩.SetAngle0();
		腕人2.肩.角度B = 肩角度B + u1;
		if (腕人2.上腕 != null)
		{
			腕人2.上腕.肘部_外線 = 上腕外線;
			腕人2.上腕.尺度XC = 上腕尺度XC;
			腕人2.上腕.角度B = 上腕角度B + u2;
			if (腕人2.下腕 != null)
			{
				Cha.Bod.腕前後(右: false, n, 前後);
				腕人2.下腕.反転Y = false;
				腕人2.下腕.肘部_外線 = 下腕外線;
				腕人2.下腕.尺度XC = 下腕尺度XC;
				腕人2.下腕.尺度C = 下腕尺度C;
				腕人2.下腕.角度B = 下腕角度B + u3;
				腕人2.下腕.反転Y = 下腕反転Y;
				腕人2.下腕.鎖1.反転Y = 下腕反転Y;
				if (腕人2.下腕.虫鎌_接続 != null)
				{
					Ele[] 虫鎌_接続 = 腕人2.下腕.虫鎌_接続;
					foreach (Ele obj in 虫鎌_接続)
					{
						obj.尺度XC = 下腕尺度XC;
						obj.尺度C = 下腕尺度C;
						obj.反転Y = 下腕反転Y;
					}
				}
				if (腕人2.手 != null)
				{
					腕人2.手.尺度XC = 手尺度XC;
					腕人2.手.尺度C = 手尺度C;
					腕人2.手.角度B = 手角度B + u4;
					if (手Yi == 11)
					{
						腕人2.手.Yi = 3;
						bool flag = 腕人2.下腕.植性1_通常_花弁_花弁_表示 || 腕人2.下腕.植性1_欠損_花弁_花弁_表示;
						腕人2.手.角度B -= (flag ? 15.0 : 0.0);
						腕人2.手.人指_人指3_表示 = false;
						腕人2.手.中指_中指3_表示 = false;
						腕人2.手.薬指_薬指3_表示 = false;
						腕人2.手.小指_小指3_表示 = false;
						if (flag)
						{
							腕人2.手.X0Y3_小指_小指2.AngleCont = 20.0;
						}
						else
						{
							腕人2.手.X0Y3_小指_小指2.AngleCont = -20.0;
						}
					}
					else
					{
						腕人2.手.人指_人指3_表示 = true;
						if (腕人2.手.中指_中指2_表示)
						{
							腕人2.手.中指_中指3_表示 = true;
						}
						if (腕人2.手.薬指_薬指2_表示)
						{
							腕人2.手.薬指_薬指3_表示 = true;
						}
						腕人2.手.小指_小指3_表示 = true;
						腕人2.手.X0Y3_小指_小指2.AngleCont = 0.0;
						腕人2.手.Yi = 手Yi;
						if (手Yi == 9)
						{
							if (!腕人2.手.中指_中指1_表示)
							{
								腕人2.手.X0Y9_小指_小指1.AngleBase = -110.0;
								腕人2.手.X0Y9_小指_小指2.AngleBase = -70.0;
								腕人2.手.X0Y9_小指_小指3.AngleBase = -105.0;
							}
							else
							{
								腕人2.手.X0Y9_小指_小指1.AngleBase = 0.0;
								腕人2.手.X0Y9_小指_小指2.AngleBase = 0.0;
								腕人2.手.X0Y9_小指_小指3.AngleBase = 0.0;
							}
						}
					}
				}
			}
		}
		腕人2.肩.重複角度処理();
	}

	public static void 腕_人右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double 肩角度B, double 上腕角度B, double 下腕角度B, double 手角度B, double 上腕尺度XC, double 下腕尺度XC, double 手尺度XC, double 下腕尺度C, double 手尺度C, bool 上腕外線, bool 下腕外線, bool 下腕反転Y, int 手Yi, bool 前後)
	{
		腕人 腕人2 = Cha.Bod.腕人右[n];
		腕人2.肩.SetAngle0();
		腕人2.肩.角度B = 0.0 - 肩角度B + (0.0 - u1);
		if (腕人2.上腕 != null)
		{
			腕人2.上腕.肘部_外線 = 上腕外線;
			腕人2.上腕.尺度XC = 上腕尺度XC;
			腕人2.上腕.角度B = 0.0 - 上腕角度B + (0.0 - u2);
			if (腕人2.下腕 != null)
			{
				Cha.Bod.腕前後(右: true, n, 前後);
				腕人2.下腕.反転Y = false;
				腕人2.下腕.肘部_外線 = 下腕外線;
				腕人2.下腕.尺度XC = 下腕尺度XC;
				腕人2.下腕.尺度C = 下腕尺度C;
				腕人2.下腕.角度B = 0.0 - 下腕角度B + (0.0 - u3);
				腕人2.下腕.反転Y = 下腕反転Y;
				腕人2.下腕.鎖1.反転Y = 下腕反転Y;
				if (腕人2.下腕.虫鎌_接続 != null)
				{
					Ele[] 虫鎌_接続 = 腕人2.下腕.虫鎌_接続;
					foreach (Ele obj in 虫鎌_接続)
					{
						obj.尺度XC = 下腕尺度XC;
						obj.尺度C = 下腕尺度C;
						obj.反転Y = 下腕反転Y;
					}
				}
				if (腕人2.手 != null)
				{
					腕人2.手.尺度XC = 手尺度XC;
					腕人2.手.尺度C = 手尺度C;
					腕人2.手.角度B = 0.0 - 手角度B + (0.0 - u4);
					if (手Yi == 11)
					{
						腕人2.手.Yi = 3;
						bool flag = 腕人2.下腕.植性1_通常_花弁_花弁_表示 || 腕人2.下腕.植性1_欠損_花弁_花弁_表示;
						腕人2.手.角度B -= (flag ? (-15.0) : 0.0);
						腕人2.手.人指_人指3_表示 = false;
						腕人2.手.中指_中指3_表示 = false;
						腕人2.手.薬指_薬指3_表示 = false;
						腕人2.手.小指_小指3_表示 = false;
						if (flag)
						{
							腕人2.手.X0Y3_小指_小指2.AngleCont = -20.0;
						}
						else
						{
							腕人2.手.X0Y3_小指_小指2.AngleCont = 20.0;
						}
					}
					else
					{
						腕人2.手.人指_人指3_表示 = true;
						if (腕人2.手.中指_中指2_表示)
						{
							腕人2.手.中指_中指3_表示 = true;
						}
						if (腕人2.手.薬指_薬指2_表示)
						{
							腕人2.手.薬指_薬指3_表示 = true;
						}
						腕人2.手.小指_小指3_表示 = true;
						腕人2.手.X0Y3_小指_小指2.AngleCont = 0.0;
						腕人2.手.Yi = 手Yi;
						if (手Yi == 9)
						{
							if (!腕人2.手.中指_中指1_表示)
							{
								腕人2.手.X0Y9_小指_小指1.AngleBase = 110.0;
								腕人2.手.X0Y9_小指_小指2.AngleBase = 70.0;
								腕人2.手.X0Y9_小指_小指3.AngleBase = 105.0;
							}
							else
							{
								腕人2.手.X0Y9_小指_小指1.AngleBase = 0.0;
								腕人2.手.X0Y9_小指_小指2.AngleBase = 0.0;
								腕人2.手.X0Y9_小指_小指3.AngleBase = 0.0;
							}
						}
					}
				}
			}
		}
		腕人2.肩.重複角度処理();
	}

	public static void 腕_人_腕置き左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -30.0, 130.0, 0.0, 0.95, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: false, 0, 前後: false);
	}

	public static void 腕_人_腕置き右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -30.0, 130.0, 0.0, 0.95, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: false, 0, 前後: false);
	}

	public static void 腕_人_胸庇い左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -80.0, -230.0, 35.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 1, 前後: false);
	}

	public static void 腕_人_胸庇い右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -80.0, -230.0, 35.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 1, 前後: false);
	}

	public static void 腕_人_体支え左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -60.0, 360.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: false, 下腕外線: false, 下腕反転Y: true, 2, 前後: true);
	}

	public static void 腕_人_体支え右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -60.0, 360.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: false, 下腕外線: false, 下腕反転Y: true, 2, 前後: true);
	}

	public static void 腕_人_胸乗せ左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, 5.0, -80.0, 185.0, 45.0, 1.0, 0.85, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: false, 3, 前後: false);
	}

	public static void 腕_人_胸乗せ右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, 5.0, -80.0, 185.0, 45.0, 1.0, 0.85, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: false, 3, 前後: false);
	}

	public static void 腕_人_顔隠し左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, 10.0, -109.0, -202.0, -13.0, 0.8, 0.95, 1.0, 1.1, 1.0, 上腕外線: true, 下腕外線: true, 下腕反転Y: true, 4, 前後: false);
	}

	public static void 腕_人_顔隠し右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, 10.0, -109.0, -202.0, -13.0, 0.8, 0.95, 1.0, 1.1, 1.0, 上腕外線: true, 下腕外線: true, 下腕反転Y: true, 4, 前後: false);
	}

	public static void 腕_人_チラ見左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, 10.0, -109.0, -202.0, -6.0, 1.0, 0.9, 1.0, 1.1, 1.0, 上腕外線: true, 下腕外線: true, 下腕反転Y: true, 10, 前後: false);
	}

	public static void 腕_人_チラ見右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, 10.0, -109.0, -202.0, -6.0, 1.0, 0.9, 1.0, 1.1, 1.0, 上腕外線: true, 下腕外線: true, 下腕反転Y: true, 10, 前後: false);
	}

	public static void 腕_人_指咥え左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, 10.0, -102.0, -194.0, 39.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 5, 前後: false);
	}

	public static void 腕_人_指咥え右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, 10.0, -102.0, -194.0, 39.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 5, 前後: false);
	}

	public static void 腕_人_腕下げ左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, -5.0, -75.0, 350.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: false, 下腕外線: false, 下腕反転Y: true, 6, 前後: true);
	}

	public static void 腕_人_腕下げ右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, -5.0, -75.0, 350.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: false, 下腕外線: false, 下腕反転Y: true, 6, 前後: true);
	}

	public static void 腕_人_股隠し左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -91.0, -331.0, 23.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 4, 前後: false);
	}

	public static void 腕_人_股隠し右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -91.0, -331.0, 23.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 4, 前後: false);
	}

	public static void 腕_人_開帳左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, 10.0, -101.0, -330.0, 33.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 10, 前後: false);
	}

	public static void 腕_人_開帳右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, 10.0, -101.0, -330.0, 33.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 10, 前後: false);
	}

	public static void 腕_人_口押さえ1左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, 10.0, -102.0, -194.0, 39.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 4, 前後: false);
	}

	public static void 腕_人_口押さえ1右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, 10.0, -102.0, -194.0, 39.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 4, 前後: false);
	}

	public static void 腕_人_口押さえ2左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.Bod.腕左右前後 = false;
		Cha.腕_人左(n, u1, u2, u3, u4, 10.0, -102.0, -194.0, 39.0, 0.9, 0.9, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 4, 前後: false);
	}

	public static void 腕_人_口押さえ2右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.Bod.腕左右前後 = true;
		Cha.腕_人右(n, u1, u2, u3, u4, 10.0, -102.0, -194.0, 39.0, 0.9, 0.9, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 4, 前後: false);
	}

	public static void 腕_人_口押さえ3左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.Bod.腕左右前後 = false;
		Cha.腕_人左(n, u1, u2, u3, u4, 10.0, -102.0, -204.0, -19.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 4, 前後: false);
	}

	public static void 腕_人_口押さえ3右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.Bod.腕左右前後 = true;
		Cha.腕_人右(n, u1, u2, u3, u4, 10.0, -102.0, -204.0, -19.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 4, 前後: false);
	}

	public static void 腕_人_脇見せ左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, 20.0, 25.0, 135.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: false, 0, 前後: true);
	}

	public static void 腕_人_脇見せ右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, 20.0, 25.0, 135.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: false, 0, 前後: true);
	}

	public static void 腕_人_腰手当左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -43.0, 90.0, -30.0, 1.0, 0.85, 0.8, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 7, 前後: false);
	}

	public static void 腕_人_腰手当右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -43.0, 90.0, -30.0, 1.0, 0.85, 0.8, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 7, 前後: false);
	}

	public static void 腕_人_ピース左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -35.0, 160.0, -50.0, 0.9, 0.9, 1.0, 1.0, 1.05, 上腕外線: true, 下腕外線: false, 下腕反転Y: false, 9, 前後: false);
	}

	public static void 腕_人_ピース右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -35.0, 160.0, -50.0, 0.9, 0.9, 1.0, 1.0, 1.05, 上腕外線: true, 下腕外線: false, 下腕反転Y: false, 9, 前後: false);
	}

	public static void 腕_人_手コキ左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -60.0, -160.0, 30.0, 0.8, 0.84, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: false, 11, 前後: false);
	}

	public static void 腕_人_手コキ右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -60.0, -160.0, 30.0, 0.8, 0.84, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: false, 11, 前後: false);
	}

	public static void 腕_人_パイズリ左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -45.0, 155.0, 15.0, 1.0, 0.55, 0.6, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 8, 前後: false);
	}

	public static void 腕_人_パイズリ右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -45.0, 155.0, 15.0, 1.0, 0.55, 0.6, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: true, 8, 前後: false);
	}

	public static void 腕_人_腕上げ左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人左(n, u1, u2, u3, u4, 0.0, -20.0, 120.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: false, 0, 前後: false);
	}

	public static void 腕_人_腕上げ右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_人右(n, u1, u2, u3, u4, 0.0, -20.0, 120.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 上腕外線: true, 下腕外線: false, 下腕反転Y: false, 0, 前後: false);
	}

	public static void 両腕_人_腕下げ(this Cha Cha, int n, bool 左右, bool 前後)
	{
		double u = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		Cha.Bod.腕左右前後 = 前後;
		if (左右)
		{
			Cha.腕_人_腕下げ右(n, u, u2, u3, u4);
			Cha.腕_人_腕下げ左(n, u, u2, u3, u4);
		}
		else
		{
			Cha.腕_人_腕下げ左(n, u, u2, u3, u4);
			Cha.腕_人_腕下げ右(n, u, u2, u3, u4);
		}
	}

	public static void 両腕_人_パイズリ(this Cha Cha, int n, bool 左右, bool 前後)
	{
		double u = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		Cha.Bod.腕左右前後 = 前後;
		if (左右)
		{
			Cha.腕_人_パイズリ右(n, u, u2, u3, u4);
			Cha.腕_人_パイズリ左(n, u, u2, u3, u4);
		}
		else
		{
			Cha.腕_人_パイズリ左(n, u, u2, u3, u4);
			Cha.腕_人_パイズリ右(n, u, u2, u3, u4);
		}
	}

	public static void 両腕_人_腕上げ(this Cha Cha, int n, bool 左右, bool 前後)
	{
		double u = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		Cha.Bod.腕左右前後 = 前後;
		Cha.腕_人_腕上げ右(n, u, u2, u3, u4);
		Cha.腕_人_腕上げ左(n, u, u2, u3, u4);
		if (左右)
		{
			Cha.腕_人_腕上げ右(n, u, u2, u3, u4);
			Cha.腕_人_腕上げ左(n, u, u2, u3, u4);
		}
		else
		{
			Cha.腕_人_腕上げ左(n, u, u2, u3, u4);
			Cha.腕_人_腕上げ右(n, u, u2, u3, u4);
		}
	}

	public static void 両腕人_0(this Cha Cha, int n, bool 前後, bool 同角, bool 左右, int i1, int i2)
	{
		Cha.Bod.腕左右前後 = 前後;
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 0.25, RNG.XS.NextSign(), 0.125);
		double num2 = Cha.角度ムラ(RNG.XS.NextSign(), 0.25, RNG.XS.NextSign(), 0.125);
		double num3 = Cha.角度ムラ(RNG.XS.NextSign(), 1.5, RNG.XS.NextSign(), 0.75);
		double num4 = Cha.角度ムラ(RNG.XS.NextSign(), 1.5, RNG.XS.NextSign(), 0.75);
		double u;
		double u2;
		double u3;
		double u4;
		if (同角)
		{
			u = num;
			u2 = num2;
			u3 = num3;
			u4 = num4;
		}
		else
		{
			u = Cha.角度ムラ(RNG.XS.NextSign(), 0.25, RNG.XS.NextSign(), 0.125);
			u2 = Cha.角度ムラ(RNG.XS.NextSign(), 0.5, RNG.XS.NextSign(), 0.25);
			u3 = Cha.角度ムラ(RNG.XS.NextSign(), 1.5, RNG.XS.NextSign(), 0.75);
			u4 = Cha.角度ムラ(RNG.XS.NextSign(), 1.5, RNG.XS.NextSign(), 0.75);
		}
		if (左右)
		{
			Cha.腕人右_0(i1, n, num, num2, num3, num4);
			Cha.腕人左_0(i2, n, u, u2, u3, u4);
		}
		else
		{
			Cha.腕人左_0(i1, n, num, num2, num3, num4);
			Cha.腕人右_0(i2, n, u, u2, u3, u4);
		}
	}

	public static void 腕人左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
	{
		switch (i)
		{
		case 0:
			c.腕_人_腕置き左(n, u1, u2, u3, u4);
			break;
		case 1:
			c.腕_人_胸庇い左(n, u1, u2, u3, u4);
			break;
		case 2:
			c.腕_人_体支え左(n, u1, u2, u3, u4);
			break;
		case 3:
			c.腕_人_胸乗せ左(n, u1, u2, u3, u4);
			break;
		case 4:
			c.腕_人_顔隠し左(n, u1, u2, u3, u4);
			break;
		case 5:
			c.腕_人_チラ見左(n, u1, u2, u3, u4);
			break;
		case 6:
			c.腕_人_指咥え左(n, u1, u2, u3, u4);
			break;
		case 7:
			c.腕_人_腕下げ左(n, u1, u2, u3, u4);
			break;
		case 8:
			c.腕_人_股隠し左(n, u1, u2, u3, u4);
			break;
		case 9:
			c.腕_人_開帳左(n, 0.0, 0.0, 0.0, 0.0);
			break;
		case 10:
			c.腕_人_口押さえ1左(n, u1, u2, u3, u4);
			break;
		case 11:
			c.腕_人_口押さえ2左(n, u1, u2, u3, u4);
			break;
		case 12:
			c.腕_人_口押さえ3左(n, u1, u2, u3, u4);
			break;
		case 13:
			c.腕_人_脇見せ左(n, u1, u2, u3, u4);
			break;
		case 14:
			c.腕_人_腰手当左(n, u1, u2, u3, u4);
			break;
		case 15:
			c.腕_人_ピース左(n, u1, u2, u3, u4);
			break;
		case 16:
			c.腕_人_手コキ左(n, u1, u2, u3, u4);
			break;
		case 17:
			c.腕_人_パイズリ左(n, u1, u2, u3, u4);
			break;
		case 18:
			c.腕_人_腕上げ左(n, u1, u2, u3, u4);
			break;
		}
	}

	public static void 腕人右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
	{
		switch (i)
		{
		case 0:
			c.腕_人_腕置き右(n, u1, u2, u3, u4);
			break;
		case 1:
			c.腕_人_胸庇い右(n, u1, u2, u3, u4);
			break;
		case 2:
			c.腕_人_体支え右(n, u1, u2, u3, u4);
			break;
		case 3:
			c.腕_人_胸乗せ右(n, u1, u2, u3, u4);
			break;
		case 4:
			c.腕_人_顔隠し右(n, u1, u2, u3, u4);
			break;
		case 5:
			c.腕_人_チラ見右(n, u1, u2, u3, u4);
			break;
		case 6:
			c.腕_人_指咥え右(n, u1, u2, u3, u4);
			break;
		case 7:
			c.腕_人_腕下げ右(n, u1, u2, u3, u4);
			break;
		case 8:
			c.腕_人_股隠し右(n, u1, u2, u3, u4);
			break;
		case 9:
			c.腕_人_開帳右(n, 0.0, 0.0, 0.0, 0.0);
			break;
		case 10:
			c.腕_人_口押さえ1右(n, u1, u2, u3, u4);
			break;
		case 11:
			c.腕_人_口押さえ2右(n, u1, u2, u3, u4);
			break;
		case 12:
			c.腕_人_口押さえ3右(n, u1, u2, u3, u4);
			break;
		case 13:
			c.腕_人_脇見せ右(n, u1, u2, u3, u4);
			break;
		case 14:
			c.腕_人_腰手当右(n, u1, u2, u3, u4);
			break;
		case 15:
			c.腕_人_ピース右(n, u1, u2, u3, u4);
			break;
		case 16:
			c.腕_人_手コキ右(n, u1, u2, u3, u4);
			break;
		case 17:
			c.腕_人_パイズリ右(n, u1, u2, u3, u4);
			break;
		case 18:
			c.腕_人_腕上げ右(n, u1, u2, u3, u4);
			break;
		}
	}

	public static void 腕人絶頂(this Cha Cha, double a)
	{
		foreach (腕人 item in Cha.Bod.腕人左)
		{
			item.肩.角度C = a * RNG.XS.NextDouble();
			if (item.上腕 == null)
			{
				continue;
			}
			item.上腕.角度C = a * RNG.XS.NextDouble();
			if (item.下腕 != null)
			{
				item.下腕.角度C = a * RNG.XS.NextDouble();
				if (item.手 != null)
				{
					item.手.角度C = a * RNG.XS.NextDouble();
				}
			}
		}
		foreach (腕人 item2 in Cha.Bod.腕人右)
		{
			item2.肩.角度C = (0.0 - a) * RNG.XS.NextDouble();
			if (item2.上腕 == null)
			{
				continue;
			}
			item2.上腕.角度C = (0.0 - a) * RNG.XS.NextDouble();
			if (item2.下腕 != null)
			{
				item2.下腕.角度C = (0.0 - a) * RNG.XS.NextDouble();
				if (item2.手 != null)
				{
					item2.手.角度C = (0.0 - a) * RNG.XS.NextDouble();
				}
			}
		}
	}

	public static void 腕_翼鳥左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double 上腕展開, double 下腕展開, double 手展開, double 肩角度B, double 上腕角度B, double 下腕角度B, double 手角度B)
	{
		腕翼鳥 腕翼鳥2 = Cha.Bod.腕翼鳥左[n];
		腕翼鳥2.肩.SetAngle0();
		if (n == 0)
		{
			腕翼鳥2.肩.角度B = 肩角度B + u1;
		}
		if (腕翼鳥2.上腕 != null)
		{
			腕翼鳥2.上腕.SetAngle0();
			腕翼鳥2.上腕.展開 = 上腕展開;
			腕翼鳥2.上腕.角度B += 上腕角度B + u2;
			if (腕翼鳥2.下腕 != null)
			{
				腕翼鳥2.下腕.SetAngle0();
				腕翼鳥2.下腕.展開 = 下腕展開;
				腕翼鳥2.下腕.角度B += 下腕角度B + u3;
				if (腕翼鳥2.手 != null)
				{
					腕翼鳥2.手.SetAngle0();
					腕翼鳥2.手.展開 = 手展開;
					腕翼鳥2.手.角度B += 手角度B + u4;
				}
			}
		}
		腕翼鳥2.肩.重複角度処理();
	}

	public static void 腕_翼鳥右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double 上腕展開, double 下腕展開, double 手展開, double 肩角度B, double 上腕角度B, double 下腕角度B, double 手角度B)
	{
		腕翼鳥 腕翼鳥2 = Cha.Bod.腕翼鳥右[n];
		腕翼鳥2.肩.SetAngle0();
		if (n == 0)
		{
			腕翼鳥2.肩.角度B = 0.0 - 肩角度B + (0.0 - u1);
		}
		if (腕翼鳥2.上腕 != null)
		{
			腕翼鳥2.上腕.SetAngle0();
			腕翼鳥2.上腕.展開 = 上腕展開;
			腕翼鳥2.上腕.角度B += 0.0 - 上腕角度B + (0.0 - u2);
			if (腕翼鳥2.下腕 != null)
			{
				腕翼鳥2.下腕.SetAngle0();
				腕翼鳥2.下腕.展開 = 下腕展開;
				腕翼鳥2.下腕.角度B += 0.0 - 下腕角度B + (0.0 - u3);
				if (腕翼鳥2.手 != null)
				{
					腕翼鳥2.手.SetAngle0();
					腕翼鳥2.手.展開 = 手展開;
					腕翼鳥2.手.角度B += 0.0 - 手角度B + (0.0 - u4);
				}
			}
		}
		腕翼鳥2.肩.重複角度処理();
	}

	public static void 腕_翼鳥_脱力左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼鳥左(n, u1, u2, u3, u4, 0.0, 0.25, 0.25, 0.0, -1.0, 0.0, 0.0);
	}

	public static void 腕_翼鳥_脱力右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼鳥右(n, u1, u2, u3, u4, 0.0, 0.25, 0.25, 0.0, -1.0, 0.0, 0.0);
	}

	public static void 腕_翼鳥_強張り左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼鳥左(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 0.0, -5.0, 10.0, 0.0);
	}

	public static void 腕_翼鳥_強張り右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼鳥右(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 0.0, -5.0, 10.0, 0.0);
	}

	public static void 腕_翼鳥_恥じらい左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼鳥左(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 8.0, -13.0, 13.0, 0.0);
	}

	public static void 腕_翼鳥_恥じらい右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼鳥右(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 8.0, -13.0, 13.0, 0.0);
	}

	public static void 腕_翼鳥_顔隠し左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼鳥左(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 5.0, -10.0, 15.0, 0.0);
	}

	public static void 腕_翼鳥_顔隠し右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼鳥右(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 5.0, -10.0, 15.0, 0.0);
	}

	public static void 腕_翼鳥_閉じ左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼鳥左(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 腕_翼鳥_閉じ右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼鳥右(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 腕_翼鳥_半開き左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼鳥左(n, u1, u2, u3, u4, 0.25, 0.25, 0.25, -3.0, 0.0, 0.0, 0.0);
	}

	public static void 腕_翼鳥_半開き右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼鳥右(n, u1, u2, u3, u4, 0.25, 0.25, 0.25, -3.0, 0.0, 0.0, 0.0);
	}

	public static void 腕_翼鳥_全開左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼鳥左(n, u1, u2, u3, u4, 1.0, 1.0, 1.0, 6.0, 3.0, 0.0, 0.0);
	}

	public static void 腕_翼鳥_全開右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼鳥右(n, u1, u2, u3, u4, 1.0, 1.0, 1.0, 6.0, 3.0, 0.0, 0.0);
	}

	public static void 両腕翼鳥_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 0.5, RNG.XS.NextSign(), 0.25);
		double num2 = Cha.角度ムラ(RNG.XS.NextSign(), 0.5, RNG.XS.NextSign(), 0.25);
		double num3 = Cha.角度ムラ(RNG.XS.NextSign(), 1.0, RNG.XS.NextSign(), 0.5);
		double num4 = Cha.角度ムラ(RNG.XS.NextSign(), 1.0, RNG.XS.NextSign(), 0.5);
		double u;
		double u2;
		double u3;
		double u4;
		if (同角)
		{
			u = num;
			u2 = num2;
			u3 = num3;
			u4 = num4;
		}
		else
		{
			u = Cha.角度ムラ(RNG.XS.NextSign(), 0.5, RNG.XS.NextSign(), 0.25);
			u2 = Cha.角度ムラ(RNG.XS.NextSign(), 0.5, RNG.XS.NextSign(), 0.25);
			u3 = Cha.角度ムラ(RNG.XS.NextSign(), 1.0, RNG.XS.NextSign(), 0.5);
			u4 = Cha.角度ムラ(RNG.XS.NextSign(), 1.0, RNG.XS.NextSign(), 0.5);
		}
		Cha.腕翼鳥左_0(i1, n, num, num2, num3, num4);
		Cha.腕翼鳥右_0(i2, n, u, u2, u3, u4);
	}

	public static void 腕翼鳥左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
	{
		switch (i)
		{
		case 0:
			c.腕_翼鳥_脱力左(n, u1, u2, u3, u4);
			break;
		case 1:
			c.腕_翼鳥_強張り左(n, u1, u2, u3, u4);
			break;
		case 2:
			c.腕_翼鳥_恥じらい左(n, u1, u2, u3, u4);
			break;
		case 3:
			c.腕_翼鳥_顔隠し左(n, u1, u2, u3, u4);
			break;
		case 4:
			c.腕_翼鳥_閉じ左(n, u1, u2, u3, u4);
			break;
		case 5:
			c.腕_翼鳥_半開き左(n, u1, u2, u3, u4);
			break;
		case 6:
			c.腕_翼鳥_全開左(n, u1, u2, u3, u4);
			break;
		}
	}

	public static void 腕翼鳥右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
	{
		switch (i)
		{
		case 0:
			c.腕_翼鳥_脱力右(n, u1, u2, u3, u4);
			break;
		case 1:
			c.腕_翼鳥_強張り右(n, u1, u2, u3, u4);
			break;
		case 2:
			c.腕_翼鳥_恥じらい右(n, u1, u2, u3, u4);
			break;
		case 3:
			c.腕_翼鳥_顔隠し右(n, u1, u2, u3, u4);
			break;
		case 4:
			c.腕_翼鳥_閉じ右(n, u1, u2, u3, u4);
			break;
		case 5:
			c.腕_翼鳥_半開き右(n, u1, u2, u3, u4);
			break;
		case 6:
			c.腕_翼鳥_全開右(n, u1, u2, u3, u4);
			break;
		}
	}

	public static void 腕翼鳥絶頂(this Cha Cha, double a)
	{
		foreach (腕翼鳥 item in Cha.Bod.腕翼鳥左)
		{
			item.肩.角度C = a * RNG.XS.NextDouble();
		}
		foreach (腕翼鳥 item2 in Cha.Bod.腕翼鳥右)
		{
			item2.肩.角度C = (0.0 - a) * RNG.XS.NextDouble();
		}
	}

	public static void 腕_翼獣左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double 上腕展開, double 下腕展開, double 手展開, double 肩角度B, double 上腕角度B, double 下腕角度B, double 手角度B)
	{
		腕翼獣 腕翼獣2 = Cha.Bod.腕翼獣左[n];
		腕翼獣2.肩.SetAngle0();
		if (n == 0)
		{
			腕翼獣2.肩.角度B = 肩角度B + u1;
		}
		if (腕翼獣2.上腕 != null)
		{
			腕翼獣2.上腕.SetAngle0();
			腕翼獣2.上腕.展開 = 上腕展開;
			腕翼獣2.上腕.角度B += 上腕角度B + u2;
			if (腕翼獣2.下腕 != null)
			{
				腕翼獣2.下腕.SetAngle0();
				腕翼獣2.下腕.展開 = 下腕展開;
				腕翼獣2.下腕.角度B += 下腕角度B + u3;
				if (腕翼獣2.手 != null)
				{
					腕翼獣2.手.SetAngle0();
					腕翼獣2.手.展開 = 手展開;
					腕翼獣2.手.角度B += 手角度B + u4;
				}
			}
		}
		腕翼獣2.肩.重複角度処理();
	}

	public static void 腕_翼獣右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double 上腕展開, double 下腕展開, double 手展開, double 肩角度B, double 上腕角度B, double 下腕角度B, double 手角度B)
	{
		腕翼獣 腕翼獣2 = Cha.Bod.腕翼獣右[n];
		腕翼獣2.肩.SetAngle0();
		if (n == 0)
		{
			腕翼獣2.肩.角度B = 0.0 - 肩角度B + (0.0 - u1);
		}
		if (腕翼獣2.上腕 != null)
		{
			腕翼獣2.上腕.SetAngle0();
			腕翼獣2.上腕.展開 = 上腕展開;
			腕翼獣2.上腕.角度B += 0.0 - 上腕角度B + (0.0 - u2);
			if (腕翼獣2.下腕 != null)
			{
				腕翼獣2.下腕.SetAngle0();
				腕翼獣2.下腕.展開 = 下腕展開;
				腕翼獣2.下腕.角度B += 0.0 - 下腕角度B + (0.0 - u3);
				if (腕翼獣2.手 != null)
				{
					腕翼獣2.手.SetAngle0();
					腕翼獣2.手.展開 = 手展開;
					腕翼獣2.手.角度B += 0.0 - 手角度B + (0.0 - u4);
				}
			}
		}
		腕翼獣2.肩.重複角度処理();
	}

	public static void 腕_翼獣_脱力左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼獣左(n, u1, u2, u3, u4, 0.0, 0.25, 0.25, 0.0, -1.0, 0.0, 0.0);
	}

	public static void 腕_翼獣_脱力右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼獣右(n, u1, u2, u3, u4, 0.0, 0.25, 0.25, 0.0, -1.0, 0.0, 0.0);
	}

	public static void 腕_翼獣_強張り左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼獣左(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 0.0, -10.0, 10.0, 0.0);
	}

	public static void 腕_翼獣_強張り右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼獣右(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 0.0, -10.0, 10.0, 0.0);
	}

	public static void 腕_翼獣_閉じ左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼獣左(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 腕_翼獣_閉じ右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼獣右(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 腕_翼獣_半開き左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼獣左(n, u1, u2, u3, u4, 0.25, 0.25, 0.25, -3.0, 0.0, 0.0, 0.0);
	}

	public static void 腕_翼獣_半開き右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼獣右(n, u1, u2, u3, u4, 0.25, 0.25, 0.25, -3.0, 0.0, 0.0, 0.0);
	}

	public static void 腕_翼獣_全開左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼獣左(n, u1, u2, u3, u4, 1.0, 1.0, 1.0, 6.0, 3.0, 0.0, 0.0);
	}

	public static void 腕_翼獣_全開右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_翼獣右(n, u1, u2, u3, u4, 1.0, 1.0, 1.0, 6.0, 3.0, 0.0, 0.0);
	}

	public static void 両腕翼獣_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 2.0, RNG.XS.NextSign(), 1.0);
		double num2 = Cha.角度ムラ(RNG.XS.NextSign(), 2.0, RNG.XS.NextSign(), 1.0);
		double num3 = Cha.角度ムラ(RNG.XS.NextSign(), 2.0, RNG.XS.NextSign(), 1.0);
		double num4 = Cha.角度ムラ(RNG.XS.NextSign(), 0.0, RNG.XS.NextSign(), 0.25);
		double u;
		double u2;
		double u3;
		double u4;
		if (同角)
		{
			u = num;
			u2 = num2;
			u3 = num3;
			u4 = num4;
		}
		else
		{
			u = Cha.角度ムラ(RNG.XS.NextSign(), 2.0, RNG.XS.NextSign(), 1.0);
			u2 = Cha.角度ムラ(RNG.XS.NextSign(), 2.0, RNG.XS.NextSign(), 1.0);
			u3 = Cha.角度ムラ(RNG.XS.NextSign(), 2.0, RNG.XS.NextSign(), 1.0);
			u4 = Cha.角度ムラ(RNG.XS.NextSign(), 0.0, RNG.XS.NextSign(), 0.25);
		}
		Cha.腕翼獣左_0(i1, n, num, num2, num3, num4);
		Cha.腕翼獣右_0(i2, n, u, u2, u3, u4);
	}

	public static void 腕翼獣左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
	{
		switch (i)
		{
		case 0:
			c.腕_翼獣_脱力左(n, u1, u2, u3, u4);
			break;
		case 1:
			c.腕_翼獣_強張り左(n, u1, u2, u3, u4);
			break;
		case 2:
			c.腕_翼獣_閉じ左(n, u1, u2, u3, u4);
			break;
		case 3:
			c.腕_翼獣_半開き左(n, u1, u2, u3, u4);
			break;
		case 4:
			c.腕_翼獣_全開左(n, u1, u2, u3, u4);
			break;
		}
	}

	public static void 腕翼獣右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
	{
		switch (i)
		{
		case 0:
			c.腕_翼獣_脱力右(n, u1, u2, u3, u4);
			break;
		case 1:
			c.腕_翼獣_強張り右(n, u1, u2, u3, u4);
			break;
		case 2:
			c.腕_翼獣_閉じ右(n, u1, u2, u3, u4);
			break;
		case 3:
			c.腕_翼獣_半開き右(n, u1, u2, u3, u4);
			break;
		case 4:
			c.腕_翼獣_全開右(n, u1, u2, u3, u4);
			break;
		}
	}

	public static void 腕翼獣絶頂(this Cha Cha, double a)
	{
		foreach (腕翼獣 item in Cha.Bod.腕翼獣左)
		{
			item.肩.角度C = a * RNG.XS.NextDouble();
		}
		foreach (腕翼獣 item2 in Cha.Bod.腕翼獣右)
		{
			item2.肩.角度C = (0.0 - a) * RNG.XS.NextDouble();
		}
	}

	public static void 腕_獣左(this Cha Cha, int n, double u2, double u3, double u4, double 上腕角度B, double 下腕角度B, double 手角度B, double 上腕尺度XC, double 下腕尺度XC, double 手尺度XC)
	{
		腕獣 腕獣2 = Cha.Bod.腕獣左[n];
		腕獣2.肩.SetAngle0();
		if (腕獣2.上腕 != null)
		{
			腕獣2.上腕.SetAngle0();
			腕獣2.上腕.尺度XC = 上腕尺度XC;
			腕獣2.上腕.角度B += 上腕角度B + u2;
			if (腕獣2.下腕 != null)
			{
				腕獣2.下腕.SetAngle0();
				腕獣2.下腕.尺度XC = 下腕尺度XC;
				腕獣2.下腕.角度B += 下腕角度B + u3;
				if (腕獣2.手 != null)
				{
					腕獣2.手.SetAngle0();
					腕獣2.手.尺度XC = 手尺度XC;
					腕獣2.手.角度B += 手角度B + u4;
				}
			}
		}
		腕獣2.肩.重複角度処理();
	}

	public static void 腕_獣右(this Cha Cha, int n, double u2, double u3, double u4, double 上腕角度B, double 下腕角度B, double 手角度B, double 上腕尺度XC, double 下腕尺度XC, double 手尺度XC)
	{
		腕獣 腕獣2 = Cha.Bod.腕獣右[n];
		腕獣2.肩.SetAngle0();
		if (腕獣2.上腕 != null)
		{
			腕獣2.上腕.SetAngle0();
			腕獣2.上腕.尺度XC = 上腕尺度XC;
			腕獣2.上腕.角度B += 0.0 - 上腕角度B + (0.0 - u2);
			if (腕獣2.下腕 != null)
			{
				腕獣2.下腕.SetAngle0();
				腕獣2.下腕.尺度XC = 下腕尺度XC;
				腕獣2.下腕.角度B += 0.0 - 下腕角度B + (0.0 - u3);
				if (腕獣2.手 != null)
				{
					腕獣2.手.SetAngle0();
					腕獣2.手.尺度XC = 手尺度XC;
					腕獣2.手.角度B += 0.0 - 手角度B + (0.0 - u4);
				}
			}
		}
		腕獣2.肩.重複角度処理();
	}

	public static void 腕_獣_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_獣左(n, u2, u3, u4, 0.0, 0.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 腕_獣_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_獣右(n, u2, u3, u4, 0.0, 0.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 腕_獣_脱力左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_獣左(n, u2, u3, u4, 0.0, -25.0, 30.0, 0.9, 0.8, 1.0);
	}

	public static void 腕_獣_脱力右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_獣右(n, u2, u3, u4, 0.0, -25.0, 30.0, 0.9, 0.8, 1.0);
	}

	public static void 腕_獣_媚び左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_獣左(n, u2, u3, u4, -25.0, 33.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 腕_獣_媚び右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.腕_獣右(n, u2, u3, u4, -25.0, 33.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 両腕獣_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u;
		double u2;
		double u3;
		double u4;
		if (同角)
		{
			u = num;
			u2 = num2;
			u3 = num3;
			u4 = num4;
		}
		else
		{
			u = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		}
		Cha.腕獣左_0(i1, n, num, num2, num3, num4);
		Cha.腕獣右_0(i2, n, u, u2, u3, u4);
	}

	public static void 腕獣左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
	{
		switch (i)
		{
		case 0:
			c.腕_獣_基本左(n, u1, u2, u3, u4);
			break;
		case 1:
			c.腕_獣_脱力左(n, u1, u2, u3, u4);
			break;
		case 2:
			c.腕_獣_媚び左(n, u1, u2, u3, u4);
			break;
		}
	}

	public static void 腕獣右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
	{
		switch (i)
		{
		case 0:
			c.腕_獣_基本右(n, u1, u2, u3, u4);
			break;
		case 1:
			c.腕_獣_脱力右(n, u1, u2, u3, u4);
			break;
		case 2:
			c.腕_獣_媚び右(n, u1, u2, u3, u4);
			break;
		}
	}

	public static void 腕獣絶頂(this Cha Cha, double a)
	{
		foreach (腕獣 item in Cha.Bod.腕獣左)
		{
			if (item.上腕 == null)
			{
				continue;
			}
			item.上腕.角度C = a * RNG.XS.NextDouble();
			if (item.下腕 != null)
			{
				item.下腕.角度C = a * RNG.XS.NextDouble();
				if (item.手 != null)
				{
					item.手.角度C = a * RNG.XS.NextDouble();
				}
			}
		}
		foreach (腕獣 item2 in Cha.Bod.腕獣右)
		{
			if (item2.上腕 == null)
			{
				continue;
			}
			item2.上腕.角度C = (0.0 - a) * RNG.XS.NextDouble();
			if (item2.下腕 != null)
			{
				item2.下腕.角度C = (0.0 - a) * RNG.XS.NextDouble();
				if (item2.手 != null)
				{
					item2.手.角度C = (0.0 - a) * RNG.XS.NextDouble();
				}
			}
		}
	}

	public static void 脚_人左(this Cha Cha, int n, double u1, double u2, double u3, double 腿角度B, double 脚角度B, double 足角度B, double 腿尺度YC, double 脚尺度YC, double 足尺度YC)
	{
		脚人 脚人2 = Cha.Bod.脚人左[n];
		脚人2.腿.SetAngle0();
		脚人2.腿.尺度YC = 腿尺度YC;
		脚人2.腿.角度B += 腿角度B + u1;
		if (脚人2.脚 != null)
		{
			脚人2.脚.SetAngle0();
			脚人2.脚.角度B = 0.0 - 脚人2.腿.角度B;
			脚人2.脚.尺度YC = 脚尺度YC;
			脚人2.脚.角度B += 脚角度B + u2;
			if (脚人2.足 != null)
			{
				脚人2.足.SetAngle0();
				脚人2.足.角度B = 0.0;
				脚人2.足.尺度YC = 足尺度YC;
				脚人2.足.角度B += 足角度B + u3;
			}
		}
	}

	public static void 脚_人右(this Cha Cha, int n, double u1, double u2, double u3, double 腿角度B, double 脚角度B, double 足角度B, double 腿尺度YC, double 脚尺度YC, double 足尺度YC)
	{
		脚人 脚人2 = Cha.Bod.脚人右[n];
		脚人2.腿.SetAngle0();
		脚人2.腿.尺度YC = 腿尺度YC;
		脚人2.腿.角度B += 0.0 - 腿角度B + (0.0 - u1);
		if (脚人2.脚 != null)
		{
			脚人2.脚.SetAngle0();
			脚人2.脚.角度B = 0.0 - 脚人2.腿.角度B;
			脚人2.脚.尺度YC = 脚尺度YC;
			脚人2.脚.角度B += 0.0 - 脚角度B + (0.0 - u2);
			if (脚人2.足 != null)
			{
				脚人2.足.SetAngle0();
				脚人2.足.角度B = 0.0;
				脚人2.足.尺度YC = 足尺度YC;
				脚人2.足.角度B += 0.0 - 足角度B + (0.0 - u3);
			}
		}
	}

	public static void 脚_人_上開き左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.左腿開きi = 3;
		Cha.脚_人左(n, u1, u2, u3, 0.0, 5.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_上開き右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.右腿開きi = 3;
		Cha.脚_人右(n, u1, u2, u3, 0.0, 5.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_上閉じ左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.左腿開きi = 4;
		Cha.脚_人左(n, u1, u2, u3, 3.0, 0.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_上閉じ右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.右腿開きi = 4;
		Cha.脚_人右(n, u1, u2, u3, 3.0, 0.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_上閉じ内左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.左腿開きi = 4;
		Cha.脚_人左(n, u1, u2, u3, 3.0, 10.0, -15.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_上閉じ内右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.右腿開きi = 4;
		Cha.脚_人右(n, u1, u2, u3, 3.0, 10.0, -15.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_脱力左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.左腿開きi = 1;
		Cha.脚_人左(n, u1, u2, u3, 0.0, -5.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_脱力右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.右腿開きi = 1;
		Cha.脚_人右(n, u1, u2, u3, 0.0, -5.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_内股左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.左腿開きi = 0;
		Cha.脚_人左(n, u1, u2, u3, -5.0, 15.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_内股右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.右腿開きi = 0;
		Cha.脚_人右(n, u1, u2, u3, -5.0, 15.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_直立左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.左腿開きi = 0;
		Cha.脚_人左(n, u1, u2, u3, 0.0, 0.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_直立右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.右腿開きi = 0;
		Cha.脚_人右(n, u1, u2, u3, 0.0, 0.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_がに股左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.左腿開きi = 2;
		Cha.脚_人左(n, u1, u2, u3, 0.0, -10.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_がに股右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.右腿開きi = 2;
		Cha.脚_人右(n, u1, u2, u3, 0.0, -10.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_おっぴろげ左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.左腿開きi = 2;
		Cha.脚_人左(n, u1, u2, u3, 10.0, 10.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_おっぴろげ右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.右腿開きi = 2;
		Cha.脚_人右(n, u1, u2, u3, 10.0, 10.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_M字開脚左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.左腿開きi = 3;
		Cha.脚_人左(n, u1, u2, u3, -10.0, 10.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_M字開脚右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.右腿開きi = 3;
		Cha.脚_人右(n, u1, u2, u3, -10.0, 10.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_足コキ左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.左腿開きi = 2;
		Cha.脚_人左(n, u1, u2, u3, -23.0, -68.0, 47.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_人_足コキ右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.Bod.右腿開きi = 2;
		Cha.脚_人右(n, u1, u2, u3, -23.0, -68.0, 47.0, 1.0, 1.0, 1.0);
	}

	public static void 両脚_人_足コキ(this Cha Cha, int n)
	{
		double u = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		Cha.Bod.腿開きi = 2;
		Cha.脚_人_足コキ左(n, u, u2, u3);
		Cha.脚_人_足コキ右(n, u, u2, u3);
	}

	public static void 両脚人_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double ba;
		double ba2;
		if (i1 == 5)
		{
			ba = 1.0;
			ba2 = 1.0;
		}
		else
		{
			ba = 3.0;
			ba2 = 1.5;
		}
		double num = Cha.角度ムラ(RNG.XS.NextSign(), ba, RNG.XS.NextSign(), ba2);
		double num2 = Cha.角度ムラ(RNG.XS.NextSign(), ba, RNG.XS.NextSign(), ba2);
		double num3 = Cha.角度ムラ(RNG.XS.NextSign(), ba, RNG.XS.NextSign(), ba2);
		double u;
		double u2;
		double u3;
		if (同角)
		{
			u = num;
			u2 = num2;
			u3 = num3;
		}
		else
		{
			if (i2 == 5)
			{
				ba = 1.0;
				ba2 = 1.0;
			}
			else
			{
				ba = 3.0;
				ba2 = 1.5;
			}
			u = Cha.角度ムラ(RNG.XS.NextSign(), ba, RNG.XS.NextSign(), ba2);
			u2 = Cha.角度ムラ(RNG.XS.NextSign(), ba, RNG.XS.NextSign(), ba2);
			u3 = Cha.角度ムラ(RNG.XS.NextSign(), ba, RNG.XS.NextSign(), ba2);
		}
		Cha.脚人左_0(i1, n, num, num2, num3);
		Cha.脚人右_0(i2, n, u, u2, u3);
	}

	public static void 脚人左_0(this Cha c, int i, int n, double u1, double u2, double u3)
	{
		switch (i)
		{
		case 0:
			c.脚_人_上開き左(n, u1, u2, u3);
			break;
		case 1:
			c.脚_人_上閉じ左(n, u1, u2, u3);
			break;
		case 2:
			c.脚_人_上閉じ内左(n, u1, u2, u3);
			break;
		case 3:
			c.脚_人_脱力左(n, u1, u2, u3);
			break;
		case 4:
			c.脚_人_内股左(n, u1, u2, u3);
			break;
		case 5:
			c.脚_人_直立左(n, u1, u2, u3);
			break;
		case 6:
			c.脚_人_がに股左(n, u1, u2, u3);
			break;
		case 7:
			c.脚_人_おっぴろげ左(n, u1, u2, u3);
			break;
		case 8:
			c.脚_人_M字開脚左(n, u1, u2, u3);
			break;
		case 9:
			c.脚_人_足コキ左(n, u1, u2, u3);
			break;
		}
	}

	public static void 脚人右_0(this Cha c, int i, int n, double u1, double u2, double u3)
	{
		switch (i)
		{
		case 0:
			c.脚_人_上開き右(n, u1, u2, u3);
			break;
		case 1:
			c.脚_人_上閉じ右(n, u1, u2, u3);
			break;
		case 2:
			c.脚_人_上閉じ内右(n, u1, u2, u3);
			break;
		case 3:
			c.脚_人_脱力右(n, u1, u2, u3);
			break;
		case 4:
			c.脚_人_内股右(n, u1, u2, u3);
			break;
		case 5:
			c.脚_人_直立右(n, u1, u2, u3);
			break;
		case 6:
			c.脚_人_がに股右(n, u1, u2, u3);
			break;
		case 7:
			c.脚_人_おっぴろげ右(n, u1, u2, u3);
			break;
		case 8:
			c.脚_人_M字開脚右(n, u1, u2, u3);
			break;
		case 9:
			c.脚_人_足コキ右(n, u1, u2, u3);
			break;
		}
	}

	public static void 脚人絶頂(this Cha Cha, double a)
	{
		foreach (脚人 item in Cha.Bod.脚人左)
		{
			item.腿.角度C = a * RNG.XS.NextDouble();
			if (item.脚 != null)
			{
				item.脚.角度C = a * RNG.XS.NextDouble();
				if (item.足 != null)
				{
					item.足.角度C = a * RNG.XS.NextDouble();
				}
			}
		}
		foreach (脚人 item2 in Cha.Bod.脚人右)
		{
			item2.腿.角度C = (0.0 - a) * RNG.XS.NextDouble();
			if (item2.脚 != null)
			{
				item2.脚.角度C = (0.0 - a) * RNG.XS.NextDouble();
				if (item2.足 != null)
				{
					item2.足.角度C = (0.0 - a) * RNG.XS.NextDouble();
				}
			}
		}
	}

	public static void 脚_獣左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double 腿角度B, double 脚角度B, double 足角度B, double 腿尺度YC, double 脚尺度YC, double 足尺度YC)
	{
		脚獣 脚獣2 = Cha.Bod.脚獣左[n];
		if (脚獣2.腿 != null)
		{
			脚獣2.腿.SetAngle0();
			脚獣2.腿.尺度YC = 腿尺度YC;
			脚獣2.腿.角度B += 腿角度B + u1;
		}
		if (脚獣2.脚 == null)
		{
			return;
		}
		脚獣2.脚.SetAngle0();
		脚獣2.脚.尺度YC = 脚尺度YC;
		if (脚獣2.腿 == null)
		{
			脚獣2.脚.角度B += 145.0;
		}
		脚獣2.脚.角度B += 脚角度B + u2;
		if (脚獣2.足 != null)
		{
			脚獣2.足.SetAngle0();
			脚獣2.足.尺度YC = 足尺度YC;
			脚獣2.足.角度B += 足角度B + u3;
			if (脚獣2.足 is 足_鳥)
			{
				足_鳥 obj = (足_鳥)脚獣2.足;
				obj.X0Y0_足首.AngleCont = -25.0 * u4;
				obj.X0Y0_親指_指1.AngleCont = 45.0 * u4;
				obj.X0Y0_人指_指1.AngleCont = -60.0 * u4;
				obj.X0Y0_人指_指2.AngleCont = -60.0 * u4;
				obj.X0Y0_薬指_指1.AngleCont = -45.0 * u4;
				obj.X0Y0_薬指_指2.AngleCont = -45.0 * u4;
				obj.X0Y0_薬指_指3.AngleCont = -45.0 * u4;
				obj.X0Y0_中指_指1.AngleCont = -45.0 * u4;
				obj.X0Y0_中指_指2.AngleCont = -45.0 * u4;
				obj.X0Y0_中指_指3.AngleCont = -45.0 * u4;
			}
		}
	}

	public static void 脚_獣右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double 腿角度B, double 脚角度B, double 足角度B, double 腿尺度YC, double 脚尺度YC, double 足尺度YC)
	{
		脚獣 脚獣2 = Cha.Bod.脚獣右[n];
		if (脚獣2.腿 != null)
		{
			脚獣2.腿.SetAngle0();
			脚獣2.腿.尺度YC = 腿尺度YC;
			脚獣2.腿.角度B += 0.0 - 腿角度B + (0.0 - u1);
		}
		if (脚獣2.脚 == null)
		{
			return;
		}
		脚獣2.脚.SetAngle0();
		脚獣2.脚.尺度YC = 脚尺度YC;
		if (脚獣2.腿 == null)
		{
			脚獣2.脚.角度B += -145.0;
		}
		脚獣2.脚.角度B += 0.0 - 脚角度B + (0.0 - u2);
		if (脚獣2.足 != null)
		{
			脚獣2.足.SetAngle0();
			脚獣2.足.尺度YC = 足尺度YC;
			脚獣2.足.角度B += 0.0 - 足角度B + (0.0 - u3);
			if (脚獣2.足 is 足_鳥)
			{
				足_鳥 obj = (足_鳥)脚獣2.足;
				obj.X0Y0_足首.AngleCont = 25.0 * u4;
				obj.X0Y0_親指_指1.AngleCont = -45.0 * u4;
				obj.X0Y0_人指_指1.AngleCont = 60.0 * u4;
				obj.X0Y0_人指_指2.AngleCont = 60.0 * u4;
				obj.X0Y0_薬指_指1.AngleCont = 45.0 * u4;
				obj.X0Y0_薬指_指2.AngleCont = 45.0 * u4;
				obj.X0Y0_薬指_指3.AngleCont = 45.0 * u4;
				obj.X0Y0_中指_指1.AngleCont = 45.0 * u4;
				obj.X0Y0_中指_指2.AngleCont = 45.0 * u4;
				obj.X0Y0_中指_指3.AngleCont = 45.0 * u4;
			}
		}
	}

	public static void 脚_獣_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.脚_獣左(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_獣_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.脚_獣右(n, u1, u2, u3, u4, 0.0, 0.0, 0.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_獣_萎縮左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.脚_獣左(n, u1, u2, u3, u4, 12.0, -12.0, 12.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_獣_萎縮右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.脚_獣右(n, u1, u2, u3, u4, 12.0, -12.0, 12.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_獣_脱力左(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.脚_獣左(n, u1, u2, u3, u4, -10.0, 10.0, -10.0, 1.0, 1.0, 1.0);
	}

	public static void 脚_獣_脱力右(this Cha Cha, int n, double u1, double u2, double u3, double u4)
	{
		Cha.脚_獣右(n, u1, u2, u3, u4, -10.0, 10.0, -10.0, 1.0, 1.0, 1.0);
	}

	public static void 両脚獣_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num4 = RNG.XS.NextDouble();
		double u;
		double u2;
		double u3;
		double u4;
		if (同角)
		{
			u = num;
			u2 = num2;
			u3 = num3;
			u4 = num4;
		}
		else
		{
			u = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u4 = RNG.XS.NextDouble();
		}
		Cha.脚獣左_0(i1, n, num, num2, num3, num4);
		Cha.脚獣右_0(i2, n, u, u2, u3, u4);
	}

	public static void 脚獣左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
	{
		switch (i)
		{
		case 0:
			c.脚_獣_基本左(n, u1, u2, u3, u4);
			break;
		case 1:
			c.脚_獣_萎縮左(n, u1, u2, u3, u4);
			break;
		case 2:
			c.脚_獣_脱力左(n, u1, u2, u3, u4);
			break;
		}
	}

	public static void 脚獣右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4)
	{
		switch (i)
		{
		case 0:
			c.脚_獣_基本右(n, u1, u2, u3, u4);
			break;
		case 1:
			c.脚_獣_萎縮右(n, u1, u2, u3, u4);
			break;
		case 2:
			c.脚_獣_脱力右(n, u1, u2, u3, u4);
			break;
		}
	}

	public static void 脚獣絶頂(this Cha Cha, double a)
	{
		foreach (脚獣 item in Cha.Bod.脚獣左)
		{
			if (item.腿 != null)
			{
				item.腿.角度C = a * RNG.XS.NextDouble();
			}
			if (item.脚 != null)
			{
				item.脚.角度C = a * RNG.XS.NextDouble();
				if (item.足 != null)
				{
					item.足.角度C = a * RNG.XS.NextDouble();
				}
			}
		}
		foreach (脚獣 item2 in Cha.Bod.脚獣右)
		{
			if (item2.腿 != null)
			{
				item2.腿.角度C = (0.0 - a) * RNG.XS.NextDouble();
			}
			if (item2.脚 != null)
			{
				item2.脚.角度C = (0.0 - a) * RNG.XS.NextDouble();
				if (item2.足 != null)
				{
					item2.足.角度C = (0.0 - a) * RNG.XS.NextDouble();
				}
			}
		}
	}

	public static void 翼鳥左(this Cha Cha, int n, double u1, double u2, double u3, double 上腕展開, double 下腕展開, double 手展開, double 上腕角度B, double 下腕角度B, double 手角度B)
	{
		翼鳥 翼鳥2 = Cha.Bod.翼鳥左[n];
		翼鳥2.上腕.SetAngle0();
		翼鳥2.上腕.展開 = 上腕展開;
		翼鳥2.上腕.角度B += 上腕角度B + u1;
		if (翼鳥2.下腕 != null)
		{
			翼鳥2.下腕.SetAngle0();
			翼鳥2.下腕.展開 = 下腕展開;
			翼鳥2.下腕.角度B += 下腕角度B + u2;
			if (翼鳥2.手 != null)
			{
				翼鳥2.手.SetAngle0();
				翼鳥2.手.展開 = 手展開;
				翼鳥2.手.角度B += 手角度B + u3;
			}
		}
		翼鳥2.上腕.重複角度処理();
	}

	public static void 翼鳥右(this Cha Cha, int n, double u1, double u2, double u3, double 上腕展開, double 下腕展開, double 手展開, double 上腕角度B, double 下腕角度B, double 手角度B)
	{
		翼鳥 翼鳥2 = Cha.Bod.翼鳥右[n];
		翼鳥2.上腕.SetAngle0();
		翼鳥2.上腕.展開 = 上腕展開;
		翼鳥2.上腕.角度B += 0.0 - 上腕角度B + (0.0 - u1);
		if (翼鳥2.下腕 != null)
		{
			翼鳥2.下腕.SetAngle0();
			翼鳥2.下腕.展開 = 下腕展開;
			翼鳥2.下腕.角度B += 0.0 - 下腕角度B + (0.0 - u2);
			if (翼鳥2.手 != null)
			{
				翼鳥2.手.SetAngle0();
				翼鳥2.手.展開 = 手展開;
				翼鳥2.手.角度B += 0.0 - 手角度B + (0.0 - u3);
			}
		}
		翼鳥2.上腕.重複角度処理();
	}

	public static void 翼鳥_脱力左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼鳥左(n, u1, u2, u3, 0.0, 0.25, 0.25, -1.0, 5.0, 0.0);
	}

	public static void 翼鳥_脱力右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼鳥右(n, u1, u2, u3, 0.0, 0.25, 0.25, -1.0, 5.0, 0.0);
	}

	public static void 翼鳥_強張り左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼鳥左(n, u1, u2, u3, 0.0, 0.0, 0.0, -10.0, 10.0, 0.0);
	}

	public static void 翼鳥_強張り右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼鳥右(n, u1, u2, u3, 0.0, 0.0, 0.0, -10.0, 10.0, 0.0);
	}

	public static void 翼鳥_恥じらい左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼鳥左(n, u1, u2, u3, 0.0, 0.0, 0.0, -20.0, 15.0, 0.0);
	}

	public static void 翼鳥_恥じらい右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼鳥右(n, u1, u2, u3, 0.0, 0.0, 0.0, -20.0, 15.0, 0.0);
	}

	public static void 翼鳥_顔隠し左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼鳥左(n, u1, u2, u3, 0.0, 0.0, 0.0, -20.0, 20.0, 0.0);
	}

	public static void 翼鳥_顔隠し右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼鳥右(n, u1, u2, u3, 0.0, 0.0, 0.0, -20.0, 20.0, 0.0);
	}

	public static void 翼鳥_閉じ左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼鳥左(n, u1, u2, u3, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 翼鳥_閉じ右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼鳥右(n, u1, u2, u3, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 翼鳥_半開き左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼鳥左(n, u1, u2, u3, 0.25, 0.25, 0.25, 0.0, 0.0, 0.0);
	}

	public static void 翼鳥_半開き右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼鳥右(n, u1, u2, u3, 0.25, 0.25, 0.25, 0.0, 0.0, 0.0);
	}

	public static void 翼鳥_全開左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼鳥左(n, u1, u2, u3, 1.0, 1.0, 1.0, 3.0, 0.0, 0.0);
	}

	public static void 翼鳥_全開右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼鳥右(n, u1, u2, u3, 1.0, 1.0, 1.0, 3.0, 0.0, 0.0);
	}

	public static void 両翼鳥_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u;
		double u2;
		double u3;
		if (同角)
		{
			u = num;
			u2 = num2;
			u3 = num3;
		}
		else
		{
			u = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		}
		Cha.翼鳥左_0(i1, n, num, num2, num3);
		Cha.翼鳥右_0(i2, n, u, u2, u3);
	}

	public static void 翼鳥左_0(this Cha c, int i, int n, double u1, double u2, double u3)
	{
		switch (i)
		{
		case 0:
			c.翼鳥_脱力左(n, u1, u2, u3);
			break;
		case 1:
			c.翼鳥_強張り左(n, u1, u2, u3);
			break;
		case 2:
			c.翼鳥_恥じらい左(n, u1, u2, u3);
			break;
		case 3:
			c.翼鳥_顔隠し左(n, u1, u2, u3);
			break;
		case 4:
			c.翼鳥_閉じ左(n, u1, u2, u3);
			break;
		case 5:
			c.翼鳥_半開き左(n, u1, u2, u3);
			break;
		case 6:
			c.翼鳥_全開左(n, u1, u2, u3);
			break;
		}
	}

	public static void 翼鳥右_0(this Cha c, int i, int n, double u1, double u2, double u3)
	{
		switch (i)
		{
		case 0:
			c.翼鳥_脱力右(n, u1, u2, u3);
			break;
		case 1:
			c.翼鳥_強張り右(n, u1, u2, u3);
			break;
		case 2:
			c.翼鳥_恥じらい右(n, u1, u2, u3);
			break;
		case 3:
			c.翼鳥_顔隠し右(n, u1, u2, u3);
			break;
		case 4:
			c.翼鳥_閉じ右(n, u1, u2, u3);
			break;
		case 5:
			c.翼鳥_半開き右(n, u1, u2, u3);
			break;
		case 6:
			c.翼鳥_全開右(n, u1, u2, u3);
			break;
		}
	}

	public static void 翼獣左(this Cha Cha, int n, double u1, double u2, double u3, double 上腕展開, double 下腕展開, double 手展開, double 上腕角度B, double 下腕角度B, double 手角度B)
	{
		翼獣 翼獣2 = Cha.Bod.翼獣左[n];
		翼獣2.上腕.SetAngle0();
		翼獣2.上腕.展開 = 上腕展開;
		翼獣2.上腕.角度B += 上腕角度B + u1;
		if (翼獣2.下腕 != null)
		{
			翼獣2.下腕.SetAngle0();
			翼獣2.下腕.展開 = 下腕展開;
			翼獣2.下腕.角度B += 下腕角度B + u2;
			if (翼獣2.手 != null)
			{
				翼獣2.手.SetAngle0();
				翼獣2.手.展開 = 手展開;
				翼獣2.手.角度B += 手角度B + u3;
			}
		}
		翼獣2.上腕.重複角度処理();
	}

	public static void 翼獣右(this Cha Cha, int n, double u1, double u2, double u3, double 上腕展開, double 下腕展開, double 手展開, double 上腕角度B, double 下腕角度B, double 手角度B)
	{
		翼獣 翼獣2 = Cha.Bod.翼獣右[n];
		翼獣2.上腕.SetAngle0();
		翼獣2.上腕.展開 = 上腕展開;
		翼獣2.上腕.角度B += 0.0 - 上腕角度B + (0.0 - u1);
		if (翼獣2.下腕 != null)
		{
			翼獣2.下腕.SetAngle0();
			翼獣2.下腕.展開 = 下腕展開;
			翼獣2.下腕.角度B += 0.0 - 下腕角度B + (0.0 - u2);
			if (翼獣2.手 != null)
			{
				翼獣2.手.SetAngle0();
				翼獣2.手.展開 = 手展開;
				翼獣2.手.角度B += 0.0 - 手角度B + (0.0 - u3);
			}
		}
		翼獣2.上腕.重複角度処理();
	}

	public static void 翼獣_脱力左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼獣左(n, u1, u2, u3, 0.0, 0.25, 0.25, -1.0, 5.0, 0.0);
	}

	public static void 翼獣_脱力右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼獣右(n, u1, u2, u3, 0.0, 0.25, 0.25, -1.0, 5.0, 0.0);
	}

	public static void 翼獣_強張り左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼獣左(n, u1, u2, u3, 0.0, 0.0, 0.0, -10.0, 10.0, 0.0);
	}

	public static void 翼獣_強張り右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼獣右(n, u1, u2, u3, 0.0, 0.0, 0.0, -10.0, 10.0, 0.0);
	}

	public static void 翼獣_恥じらい左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼獣左(n, u1, u2, u3, 0.0, 0.0, 0.0, -20.0, 15.0, 0.0);
	}

	public static void 翼獣_恥じらい右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼獣右(n, u1, u2, u3, 0.0, 0.0, 0.0, -20.0, 15.0, 0.0);
	}

	public static void 翼獣_顔隠し左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼獣左(n, u1, u2, u3, 0.0, 0.0, 0.0, -20.0, 20.0, 0.0);
	}

	public static void 翼獣_顔隠し右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼獣右(n, u1, u2, u3, 0.0, 0.0, 0.0, -20.0, 20.0, 0.0);
	}

	public static void 翼獣_閉じ左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼獣左(n, u1, u2, u3, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 翼獣_閉じ右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼獣右(n, u1, u2, u3, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 翼獣_半開き左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼獣左(n, u1, u2, u3, 0.25, 0.25, 0.25, 0.0, 0.0, 0.0);
	}

	public static void 翼獣_半開き右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼獣右(n, u1, u2, u3, 0.25, 0.25, 0.25, 0.0, 0.0, 0.0);
	}

	public static void 翼獣_全開左(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼獣左(n, u1, u2, u3, 1.0, 1.0, 1.0, 3.0, 0.0, 0.0);
	}

	public static void 翼獣_全開右(this Cha Cha, int n, double u1, double u2, double u3)
	{
		Cha.翼獣右(n, u1, u2, u3, 1.0, 1.0, 1.0, 3.0, 0.0, 0.0);
	}

	public static void 両翼獣_閉じ(this Cha Cha, int n)
	{
		double u = Cha.角度ムラ(RNG.XS.NextSign(), 2.0, RNG.XS.NextSign(), 1.0);
		double u2 = Cha.角度ムラ(RNG.XS.NextSign(), 2.0, RNG.XS.NextSign(), 1.0);
		double u3 = Cha.角度ムラ(RNG.XS.NextSign(), 0.0, RNG.XS.NextSign(), 0.25);
		Cha.翼獣_閉じ左(n, u, u2, u3);
		Cha.翼獣_閉じ右(n, u, u2, u3);
	}

	public static void 両翼獣_半開き(this Cha Cha, int n)
	{
		double u = Cha.角度ムラ(RNG.XS.NextSign(), 2.0, RNG.XS.NextSign(), 1.0);
		double u2 = Cha.角度ムラ(RNG.XS.NextSign(), 2.0, RNG.XS.NextSign(), 1.0);
		double u3 = Cha.角度ムラ(RNG.XS.NextSign(), 0.0, RNG.XS.NextSign(), 0.25);
		Cha.翼獣_半開き左(n, u, u2, u3);
		Cha.翼獣_半開き右(n, u, u2, u3);
	}

	public static void 両翼獣_全開(this Cha Cha, int n)
	{
		double u = Cha.角度ムラ(RNG.XS.NextSign(), 2.0, RNG.XS.NextSign(), 1.0);
		double u2 = Cha.角度ムラ(RNG.XS.NextSign(), 2.0, RNG.XS.NextSign(), 1.0);
		double u3 = Cha.角度ムラ(RNG.XS.NextSign(), 0.0, RNG.XS.NextSign(), 0.25);
		Cha.翼獣_全開左(n, u, u2, u3);
		Cha.翼獣_全開右(n, u, u2, u3);
	}

	public static void 両翼獣_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 2.0, RNG.XS.NextSign(), 1.0);
		double num2 = Cha.角度ムラ(RNG.XS.NextSign(), 2.0, RNG.XS.NextSign(), 1.0);
		double num3 = Cha.角度ムラ(RNG.XS.NextSign(), 0.0, RNG.XS.NextSign(), 0.25);
		double u;
		double u2;
		double u3;
		if (同角)
		{
			u = num;
			u2 = num2;
			u3 = num3;
		}
		else
		{
			u = Cha.角度ムラ(RNG.XS.NextSign(), 2.0, RNG.XS.NextSign(), 1.0);
			u2 = Cha.角度ムラ(RNG.XS.NextSign(), 2.0, RNG.XS.NextSign(), 1.0);
			u3 = Cha.角度ムラ(RNG.XS.NextSign(), 0.0, RNG.XS.NextSign(), 0.25);
		}
		Cha.翼獣左_0(i1, n, num, num2, num3);
		Cha.翼獣右_0(i2, n, u, u2, u3);
	}

	public static void 翼獣左_0(this Cha c, int i, int n, double u1, double u2, double u3)
	{
		switch (i)
		{
		case 0:
			c.翼獣_脱力左(n, u1, u2, u3);
			break;
		case 1:
			c.翼獣_強張り左(n, u1, u2, u3);
			break;
		case 2:
			c.翼獣_恥じらい左(n, u1, u2, u3);
			break;
		case 3:
			c.翼獣_顔隠し左(n, u1, u2, u3);
			break;
		case 4:
			c.翼獣_閉じ左(n, u1, u2, u3);
			break;
		case 5:
			c.翼獣_半開き左(n, u1, u2, u3);
			break;
		case 6:
			c.翼獣_全開左(n, u1, u2, u3);
			break;
		}
	}

	public static void 翼獣右_0(this Cha c, int i, int n, double u1, double u2, double u3)
	{
		switch (i)
		{
		case 0:
			c.翼獣_脱力右(n, u1, u2, u3);
			break;
		case 1:
			c.翼獣_強張り右(n, u1, u2, u3);
			break;
		case 2:
			c.翼獣_恥じらい右(n, u1, u2, u3);
			break;
		case 3:
			c.翼獣_顔隠し右(n, u1, u2, u3);
			break;
		case 4:
			c.翼獣_閉じ右(n, u1, u2, u3);
			break;
		case 5:
			c.翼獣_半開き右(n, u1, u2, u3);
			break;
		case 6:
			c.翼獣_全開右(n, u1, u2, u3);
			break;
		}
	}

	public static void 鰭左(this Cha Cha, int n, double u1, double 根本角度)
	{
		鰭 鰭2 = Cha.Bod.鰭左[n];
		鰭2.SetAngle0();
		鰭2.角度B += 根本角度 + u1;
		if (鰭2 is 鰭_魚 && 根本角度 < 0.0)
		{
			((鰭_魚)鰭2).X0Y0_鰭1_鰭膜.AngleBase += (0.0 - 根本角度) * 0.5;
		}
	}

	public static void 鰭右(this Cha Cha, int n, double u1, double 根本角度)
	{
		鰭 鰭2 = Cha.Bod.鰭右[n];
		鰭2.SetAngle0();
		鰭2.角度B += 0.0 - 根本角度 + (0.0 - u1);
		if (鰭2 is 鰭_魚 && 根本角度 < 0.0)
		{
			((鰭_魚)鰭2).X0Y0_鰭1_鰭膜.AngleBase += 根本角度 * 0.5;
		}
	}

	public static void 鰭_基本左(this Cha Cha, int n, double u1)
	{
		Cha.鰭左(n, 0.0, u1);
	}

	public static void 鰭_基本右(this Cha Cha, int n, double u1)
	{
		Cha.鰭右(n, 0.0, u1);
	}

	public static void 鰭_上げ左(this Cha Cha, int n, double u1)
	{
		Cha.鰭左(n, 25.0, u1);
	}

	public static void 鰭_上げ右(this Cha Cha, int n, double u1)
	{
		Cha.鰭右(n, 25.0, u1);
	}

	public static void 鰭_下げ左(this Cha Cha, int n, double u1)
	{
		Cha.鰭左(n, -25.0, u1);
	}

	public static void 鰭_下げ右(this Cha Cha, int n, double u1)
	{
		Cha.鰭右(n, -25.0, u1);
	}

	public static void 両鰭_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u = ((!同角) ? Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5) : num);
		Cha.鰭左_0(i1, n, num);
		Cha.鰭右_0(i2, n, u);
	}

	public static void 鰭左_0(this Cha c, int i, int n, double u1)
	{
		switch (i)
		{
		case 0:
			c.鰭_基本左(n, u1);
			break;
		case 1:
			c.鰭_上げ左(n, u1);
			break;
		case 2:
			c.鰭_下げ左(n, u1);
			break;
		}
	}

	public static void 鰭右_0(this Cha c, int i, int n, double u1)
	{
		switch (i)
		{
		case 0:
			c.鰭_基本右(n, u1);
			break;
		case 1:
			c.鰭_上げ右(n, u1);
			break;
		case 2:
			c.鰭_下げ右(n, u1);
			break;
		}
	}

	public static void 鰭絶頂(this Cha Cha, double a)
	{
		foreach (鰭 item in Cha.Bod.鰭左)
		{
			item.角度C = a * RNG.XS.NextDouble();
		}
		foreach (鰭 item2 in Cha.Bod.鰭右)
		{
			item2.角度C = (0.0 - a) * RNG.XS.NextDouble();
		}
	}

	public static void 葉左(this Cha Cha, int n, double u1, double 根本角度)
	{
		葉 obj = Cha.Bod.葉左[n];
		obj.SetAngle0();
		obj.角度B += 根本角度 + u1;
	}

	public static void 葉右(this Cha Cha, int n, double u1, double 根本角度)
	{
		葉 obj = Cha.Bod.葉右[n];
		obj.SetAngle0();
		obj.角度B += 0.0 - 根本角度 + (0.0 - u1);
	}

	public static void 葉_基本左(this Cha Cha, int n, double u1)
	{
		Cha.葉左(n, 0.0, u1);
	}

	public static void 葉_基本右(this Cha Cha, int n, double u1)
	{
		Cha.葉右(n, 0.0, u1);
	}

	public static void 葉_上げ左(this Cha Cha, int n, double u1)
	{
		Cha.葉左(n, 25.0, u1);
	}

	public static void 葉_上げ右(this Cha Cha, int n, double u1)
	{
		Cha.葉右(n, 25.0, u1);
	}

	public static void 葉_下げ左(this Cha Cha, int n, double u1)
	{
		Cha.葉左(n, -25.0, u1);
	}

	public static void 葉_下げ右(this Cha Cha, int n, double u1)
	{
		Cha.葉右(n, -25.0, u1);
	}

	public static void 両葉_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u = ((!同角) ? Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5) : num);
		Cha.葉左_0(i1, n, num);
		Cha.葉右_0(i2, n, u);
	}

	public static void 葉左_0(this Cha c, int i, int n, double u1)
	{
		switch (i)
		{
		case 0:
			c.葉_基本左(n, u1);
			break;
		case 1:
			c.葉_上げ左(n, u1);
			break;
		case 2:
			c.葉_下げ左(n, u1);
			break;
		}
	}

	public static void 葉右_0(this Cha c, int i, int n, double u1)
	{
		switch (i)
		{
		case 0:
			c.葉_基本右(n, u1);
			break;
		case 1:
			c.葉_上げ右(n, u1);
			break;
		case 2:
			c.葉_下げ右(n, u1);
			break;
		}
	}

	public static void 葉絶頂(this Cha Cha, double a)
	{
		foreach (葉 item in Cha.Bod.葉左)
		{
			item.角度C = a * RNG.XS.NextDouble();
		}
		foreach (葉 item2 in Cha.Bod.葉右)
		{
			item2.角度C = (0.0 - a) * RNG.XS.NextDouble();
		}
	}

	public static void 前翅1左(this Cha Cha, int n, double u1, double 根本角度)
	{
		前翅 obj = Cha.Bod.前翅1左[n];
		obj.SetAngle0();
		obj.角度B += 根本角度 + u1;
	}

	public static void 前翅1右(this Cha Cha, int n, double u1, double 根本角度)
	{
		前翅 obj = Cha.Bod.前翅1右[n];
		obj.SetAngle0();
		obj.角度B += 0.0 - 根本角度 + (0.0 - u1);
	}

	public static void 前翅1_基本左(this Cha Cha, int n, double u1)
	{
		Cha.前翅1左(n, 0.0, u1);
	}

	public static void 前翅1_基本右(this Cha Cha, int n, double u1)
	{
		Cha.前翅1右(n, 0.0, u1);
	}

	public static void 前翅1_上げ左(this Cha Cha, int n, double u1)
	{
		Cha.前翅1左(n, 15.0, u1);
	}

	public static void 前翅1_上げ右(this Cha Cha, int n, double u1)
	{
		Cha.前翅1右(n, 15.0, u1);
	}

	public static void 前翅1_下げ左(this Cha Cha, int n, double u1)
	{
		Cha.前翅1左(n, -15.0, u1);
	}

	public static void 前翅1_下げ右(this Cha Cha, int n, double u1)
	{
		Cha.前翅1右(n, -15.0, u1);
	}

	public static void 両前翅_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u = ((!同角) ? Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5) : num);
		Cha.前翅左_0(i1, n, num);
		Cha.前翅右_0(i2, n, u);
	}

	public static void 前翅左_0(this Cha c, int i, int n, double u1)
	{
		switch (i)
		{
		case 0:
			c.前翅1_基本左(n, u1);
			break;
		case 1:
			c.前翅1_上げ左(n, u1);
			break;
		case 2:
			c.前翅1_下げ左(n, u1);
			break;
		}
	}

	public static void 前翅右_0(this Cha c, int i, int n, double u1)
	{
		switch (i)
		{
		case 0:
			c.前翅1_基本右(n, u1);
			break;
		case 1:
			c.前翅1_上げ右(n, u1);
			break;
		case 2:
			c.前翅1_下げ右(n, u1);
			break;
		}
	}

	public static void 前翅絶頂(this Cha Cha, double a)
	{
		foreach (前翅 item in Cha.Bod.前翅1左)
		{
			item.角度C = a * RNG.XS.NextDouble();
		}
		foreach (前翅 item2 in Cha.Bod.前翅1右)
		{
			item2.角度C = (0.0 - a) * RNG.XS.NextDouble();
		}
	}

	public static void 前翅2左(this Cha Cha, int n, double 展開)
	{
		前翅 前翅2 = Cha.Bod.前翅2左[n];
		if (前翅2 is 前翅_甲)
		{
			if (展開 != 0.5)
			{
				前翅2.SetAngle0();
				((前翅_甲)前翅2).展開 = 展開;
			}
		}
		else if (前翅2 is 前翅_草)
		{
			前翅2.SetAngle0();
			((前翅_草)前翅2).展開 = 展開;
		}
	}

	public static void 前翅2右(this Cha Cha, int n, double 展開)
	{
		前翅 前翅2 = Cha.Bod.前翅2右[n];
		if (前翅2 is 前翅_甲)
		{
			if (展開 != 0.5)
			{
				前翅2.SetAngle0();
				((前翅_甲)前翅2).展開 = 展開;
			}
		}
		else if (前翅2 is 前翅_草)
		{
			前翅2.SetAngle0();
			((前翅_草)前翅2).展開 = 展開;
		}
	}

	public static void 前翅2_基本左(this Cha Cha, int n)
	{
		Cha.前翅2左(n, 0.0);
	}

	public static void 前翅2_基本右(this Cha Cha, int n)
	{
		Cha.前翅2右(n, 0.0);
	}

	public static void 前翅2_半開左(this Cha Cha, int n)
	{
		Cha.前翅2左(n, 0.5);
	}

	public static void 前翅2_半開右(this Cha Cha, int n)
	{
		Cha.前翅2右(n, 0.5);
	}

	public static void 前翅2_全開左(this Cha Cha, int n)
	{
		Cha.前翅2左(n, 1.0);
	}

	public static void 前翅2_全開右(this Cha Cha, int n)
	{
		Cha.前翅2右(n, 1.0);
	}

	public static void 両前翅_1(this Cha Cha, int n, int i1, int i2)
	{
		Cha.前翅左_1(i1, n);
		Cha.前翅右_1(i2, n);
	}

	public static void 前翅左_1(this Cha c, int i, int n)
	{
		switch (i)
		{
		case 0:
			c.前翅2_基本左(n);
			break;
		case 1:
			c.前翅2_半開左(n);
			break;
		case 2:
			c.前翅2_全開左(n);
			break;
		}
	}

	public static void 前翅右_1(this Cha c, int i, int n)
	{
		switch (i)
		{
		case 0:
			c.前翅2_基本右(n);
			break;
		case 1:
			c.前翅2_半開右(n);
			break;
		case 2:
			c.前翅2_全開右(n);
			break;
		}
	}

	public static void 後翅1左(this Cha Cha, int n, double u1, double 根本角度)
	{
		後翅 obj = Cha.Bod.後翅1左[n];
		obj.SetAngle0();
		obj.角度B += 根本角度 + u1;
	}

	public static void 後翅1右(this Cha Cha, int n, double u1, double 根本角度)
	{
		後翅 obj = Cha.Bod.後翅1右[n];
		obj.SetAngle0();
		obj.角度B += 0.0 - 根本角度 + (0.0 - u1);
	}

	public static void 後翅1_基本左(this Cha Cha, int n, double u1)
	{
		Cha.後翅1左(n, 0.0, u1);
	}

	public static void 後翅1_基本右(this Cha Cha, int n, double u1)
	{
		Cha.後翅1右(n, 0.0, u1);
	}

	public static void 後翅1_上げ左(this Cha Cha, int n, double u1)
	{
		Cha.後翅1左(n, 15.0, u1);
	}

	public static void 後翅1_上げ右(this Cha Cha, int n, double u1)
	{
		Cha.後翅1右(n, 15.0, u1);
	}

	public static void 後翅1_下げ左(this Cha Cha, int n, double u1)
	{
		Cha.後翅1左(n, -15.0, u1);
	}

	public static void 後翅1_下げ右(this Cha Cha, int n, double u1)
	{
		Cha.後翅1右(n, -15.0, u1);
	}

	public static void 両後翅_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u = ((!同角) ? Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5) : num);
		Cha.後翅左_0(i1, n, num);
		Cha.後翅右_0(i2, n, u);
	}

	public static void 後翅左_0(this Cha c, int i, int n, double u1)
	{
		switch (i)
		{
		case 0:
			c.後翅1_基本左(n, u1);
			break;
		case 1:
			c.後翅1_上げ左(n, u1);
			break;
		case 2:
			c.後翅1_下げ左(n, u1);
			break;
		}
	}

	public static void 後翅右_0(this Cha c, int i, int n, double u1)
	{
		switch (i)
		{
		case 0:
			c.後翅1_基本右(n, u1);
			break;
		case 1:
			c.後翅1_上げ右(n, u1);
			break;
		case 2:
			c.後翅1_下げ右(n, u1);
			break;
		}
	}

	public static void 後翅絶頂(this Cha Cha, double a)
	{
		foreach (後翅 item in Cha.Bod.後翅1左)
		{
			item.角度C = a * RNG.XS.NextDouble();
		}
		foreach (後翅 item2 in Cha.Bod.後翅1右)
		{
			item2.角度C = (0.0 - a) * RNG.XS.NextDouble();
		}
	}

	public static void 後翅2左(this Cha Cha, int n, double 展開)
	{
		後翅 後翅2 = Cha.Bod.後翅2左[n];
		if (後翅2 is 後翅_甲)
		{
			if (展開 != 0.5)
			{
				後翅2.SetAngle0();
				((後翅_甲)後翅2).展開 = 展開;
			}
		}
		else if (後翅2 is 後翅_草)
		{
			後翅2.SetAngle0();
			((後翅_草)後翅2).展開 = 展開;
		}
	}

	public static void 後翅2右(this Cha Cha, int n, double 展開)
	{
		後翅 後翅2 = Cha.Bod.後翅2右[n];
		if (後翅2 is 後翅_甲)
		{
			if (展開 != 0.5)
			{
				後翅2.SetAngle0();
				((後翅_甲)後翅2).展開 = 展開;
			}
		}
		else if (後翅2 is 後翅_草)
		{
			後翅2.SetAngle0();
			((後翅_草)後翅2).展開 = 展開;
		}
	}

	public static void 後翅2_基本左(this Cha Cha, int n)
	{
		Cha.後翅2左(n, 0.0);
	}

	public static void 後翅2_基本右(this Cha Cha, int n)
	{
		Cha.後翅2右(n, 0.0);
	}

	public static void 後翅2_半開左(this Cha Cha, int n)
	{
		Cha.後翅2左(n, 0.5);
	}

	public static void 後翅2_半開右(this Cha Cha, int n)
	{
		Cha.後翅2右(n, 0.5);
	}

	public static void 後翅2_全開左(this Cha Cha, int n)
	{
		Cha.後翅2左(n, 1.0);
	}

	public static void 後翅2_全開右(this Cha Cha, int n)
	{
		Cha.後翅2右(n, 1.0);
	}

	public static void 両後翅_1(this Cha Cha, int n, int i1, int i2)
	{
		Cha.後翅左_1(i1, n);
		Cha.後翅右_1(i2, n);
	}

	public static void 後翅左_1(this Cha c, int i, int n)
	{
		switch (i)
		{
		case 0:
			c.後翅2_基本左(n);
			break;
		case 1:
			c.後翅2_半開左(n);
			break;
		case 2:
			c.後翅2_全開左(n);
			break;
		}
	}

	public static void 後翅右_1(this Cha c, int i, int n)
	{
		switch (i)
		{
		case 0:
			c.後翅2_基本右(n);
			break;
		case 1:
			c.後翅2_半開右(n);
			break;
		case 2:
			c.後翅2_全開右(n);
			break;
		}
	}

	public static void 触肢蜘左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double 基節角度, double 転節角度, double 腿節角度, double 膝節角度, double 脛節角度, double 蹠節角度)
	{
		触肢_肢蜘 obj = Cha.Bod.触肢蜘左[n];
		obj.SetAngle0();
		obj.X0Y0_基節.AngleBase += 基節角度 + u1;
		obj.X0Y0_転節.AngleBase += 転節角度 + u2;
		obj.X0Y0_腿節.AngleBase += 腿節角度 + u3;
		obj.X0Y0_膝節.AngleBase += 膝節角度 + u4;
		obj.X0Y0_脛節.AngleBase += 脛節角度 + u5;
		obj.X0Y0_蹠節.AngleBase += 蹠節角度 + u6;
	}

	public static void 触肢蜘右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double 基節角度, double 転節角度, double 腿節角度, double 膝節角度, double 脛節角度, double 蹠節角度)
	{
		触肢_肢蜘 obj = Cha.Bod.触肢蜘右[n];
		obj.SetAngle0();
		obj.X0Y0_基節.AngleBase += 0.0 - 基節角度 + (0.0 - u1);
		obj.X0Y0_転節.AngleBase += 0.0 - 転節角度 + (0.0 - u2);
		obj.X0Y0_腿節.AngleBase += 0.0 - 腿節角度 + (0.0 - u3);
		obj.X0Y0_膝節.AngleBase += 0.0 - 膝節角度 + (0.0 - u4);
		obj.X0Y0_脛節.AngleBase += 0.0 - 脛節角度 + (0.0 - u5);
		obj.X0Y0_蹠節.AngleBase += 0.0 - 蹠節角度 + (0.0 - u6);
	}

	public static void 触肢蜘_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
	{
		Cha.触肢蜘左(n, u1, u2, u3, u4, u5, u6, -30.0, 0.0, 0.0, -45.0, 0.0, 30.0);
	}

	public static void 触肢蜘_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
	{
		Cha.触肢蜘右(n, u1, u2, u3, u4, u5, u6, -30.0, 0.0, 0.0, -45.0, 0.0, 30.0);
	}

	public static void 触肢蜘_萎縮左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
	{
		Cha.触肢蜘左(n, u1, u2, u3, u4, u5, u6, -10.0, 0.0, 0.0, -8.0, 0.0, 25.0);
	}

	public static void 触肢蜘_萎縮右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
	{
		Cha.触肢蜘右(n, u1, u2, u3, u4, u5, u6, -10.0, 0.0, 0.0, -8.0, 0.0, 25.0);
	}

	public static void 触肢蜘_開く左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
	{
		Cha.触肢蜘左(n, u1, u2, u3, u4, u5, u6, -40.0, 0.0, 0.0, -100.0, 0.0, -30.0);
	}

	public static void 触肢蜘_開く右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
	{
		Cha.触肢蜘右(n, u1, u2, u3, u4, u5, u6, -40.0, 0.0, 0.0, -100.0, 0.0, -30.0);
	}

	public static void 両触肢蜘_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u3;
		double u4;
		double u5;
		double u6;
		if (同角)
		{
			u3 = num;
			u4 = num2;
			u5 = num3;
			u6 = num4;
		}
		else
		{
			u3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u5 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u6 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		}
		Cha.触肢蜘左_0(i1, n, num, num2, num3, num4, u, u2);
		Cha.触肢蜘右_0(i2, n, u3, u4, u5, u6, u, u2);
	}

	public static void 触肢蜘左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6)
	{
		switch (i)
		{
		case 0:
			c.触肢蜘_基本左(n, u1, u2, u3, u4, u5, u6);
			break;
		case 1:
			c.触肢蜘_萎縮左(n, u1, u2, u3, u4, u5, u6);
			break;
		case 2:
			c.触肢蜘_開く左(n, u1, u2, u3, u4, u5, u6);
			break;
		}
	}

	public static void 触肢蜘右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6)
	{
		switch (i)
		{
		case 0:
			c.触肢蜘_基本右(n, u1, u2, u3, u4, u5, u6);
			break;
		case 1:
			c.触肢蜘_萎縮右(n, u1, u2, u3, u4, u5, u6);
			break;
		case 2:
			c.触肢蜘_開く右(n, u1, u2, u3, u4, u5, u6);
			break;
		}
	}

	public static void 触肢蜘絶頂(this Cha Cha, double a)
	{
		foreach (触肢_肢蜘 item in Cha.Bod.触肢蜘左)
		{
			item.X0Y0_基節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_転節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_腿節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_膝節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脛節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_蹠節.AngleCont = a * RNG.XS.NextDouble();
		}
		foreach (触肢_肢蜘 item2 in Cha.Bod.触肢蜘右)
		{
			item2.X0Y0_基節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_転節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_腿節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_膝節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_脛節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_蹠節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
		}
	}

	public static void 触肢蠍左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double 転節角度, double 腿節角度, double 膝節角度, double 爪1角度, double 爪2角度)
	{
		触肢_肢蠍 触肢_肢蠍2 = Cha.Bod.触肢蠍左[n];
		触肢_肢蠍2.SetAngle0();
		触肢_肢蠍2.X0Y0_転節.AngleBase += 転節角度 + u1;
		触肢_肢蠍2.X0Y0_腿節.AngleBase += 腿節角度 + u2;
		触肢_肢蠍2.X0Y0_膝節.AngleBase += 膝節角度 + u3;
		触肢_肢蠍2.X0Y0_爪1.AngleBase += 爪1角度 + u4;
		if (触肢_肢蠍2.拘束)
		{
			触肢_肢蠍2.X0Y0_爪2.AngleBase = 0.0;
		}
		else
		{
			触肢_肢蠍2.X0Y0_爪2.AngleBase += 爪2角度 + u5;
		}
	}

	public static void 触肢蠍右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double 転節角度, double 腿節角度, double 膝節角度, double 爪1角度, double 爪2角度)
	{
		触肢_肢蠍 触肢_肢蠍2 = Cha.Bod.触肢蠍右[n];
		触肢_肢蠍2.SetAngle0();
		触肢_肢蠍2.X0Y0_転節.AngleBase += 0.0 - 転節角度 + (0.0 - u1);
		触肢_肢蠍2.X0Y0_腿節.AngleBase += 0.0 - 腿節角度 + (0.0 - u2);
		触肢_肢蠍2.X0Y0_膝節.AngleBase += 0.0 - 膝節角度 + (0.0 - u3);
		触肢_肢蠍2.X0Y0_爪1.AngleBase += 0.0 - 爪1角度 + (0.0 - u4);
		if (触肢_肢蠍2.拘束)
		{
			触肢_肢蠍2.X0Y0_爪2.AngleBase = 0.0;
		}
		else
		{
			触肢_肢蠍2.X0Y0_爪2.AngleBase += 0.0 - 爪2角度 + (0.0 - u5);
		}
	}

	public static void 触肢蠍_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
	{
		Cha.触肢蠍左(n, u1, u2, u3, u4, u5, 0.0, 0.0, -5.0, 20.0, 10.0);
	}

	public static void 触肢蠍_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
	{
		Cha.触肢蠍右(n, u1, u2, u3, u4, u5, 0.0, 0.0, -5.0, 20.0, 10.0);
	}

	public static void 触肢蠍_萎縮左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
	{
		Cha.触肢蠍左(n, u1, u2, u3, u4, u5, -25.0, 5.0, 5.0, 35.0, 15.0);
	}

	public static void 触肢蠍_萎縮右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
	{
		Cha.触肢蠍右(n, u1, u2, u3, u4, u5, -25.0, 5.0, 5.0, 35.0, 15.0);
	}

	public static void 触肢蠍_開く左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
	{
		Cha.触肢蠍左(n, u1, u2, u3, u4, u5, 10.0, -5.0, -20.0, -5.0, -10.0);
	}

	public static void 触肢蠍_開く右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6)
	{
		Cha.触肢蠍右(n, u1, u2, u3, u4, u5, 10.0, -5.0, -20.0, -5.0, -10.0);
	}

	public static void 両触肢蠍_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u3;
		double u4;
		double u5;
		double u6;
		if (同角)
		{
			u3 = num;
			u4 = num2;
			u5 = num3;
			u6 = num4;
		}
		else
		{
			u3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u5 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u6 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		}
		Cha.触肢蠍左_0(i1, n, num, num2, num3, num4, u, u2);
		Cha.触肢蠍右_0(i2, n, u3, u4, u5, u6, u, u2);
	}

	public static void 触肢蠍左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6)
	{
		switch (i)
		{
		case 0:
			c.触肢蠍_基本左(n, u1, u2, u3, u4, u5, u6);
			break;
		case 1:
			c.触肢蠍_萎縮左(n, u1, u2, u3, u4, u5, u6);
			break;
		case 2:
			c.触肢蠍_開く左(n, u1, u2, u3, u4, u5, u6);
			break;
		}
	}

	public static void 触肢蠍右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6)
	{
		switch (i)
		{
		case 0:
			c.触肢蠍_基本右(n, u1, u2, u3, u4, u5, u6);
			break;
		case 1:
			c.触肢蠍_萎縮右(n, u1, u2, u3, u4, u5, u6);
			break;
		case 2:
			c.触肢蠍_開く右(n, u1, u2, u3, u4, u5, u6);
			break;
		}
	}

	public static void 触肢蠍絶頂(this Cha Cha, double a)
	{
		foreach (触肢_肢蠍 item in Cha.Bod.触肢蠍左)
		{
			item.X0Y0_転節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_腿節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_膝節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_爪1.AngleCont = a * RNG.XS.NextDouble();
			if (!item.拘束)
			{
				item.X0Y0_爪2.AngleCont = a * RNG.XS.NextDouble();
			}
		}
		foreach (触肢_肢蠍 item2 in Cha.Bod.触肢蠍右)
		{
			item2.X0Y0_転節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_腿節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_膝節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_爪1.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			if (!item2.拘束)
			{
				item2.X0Y0_爪2.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			}
		}
	}

	public static void 節足蜘左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8, double 基節角度, double 転節角度, double 腿節角度, double 膝節角度, double 脛節角度, double 蹠節角度, double 跗節1角度, double 跗節2角度)
	{
		節足_足蜘 節足_足蜘2 = Cha.Bod.節足蜘左[n];
		節足_足蜘2.SetAngle0();
		switch (節足_足蜘2.ConnectionType)
		{
		case ConnectionInfo.多足_蜘_節足左1_接続:
			節足_足蜘2.角度B += 0.0;
			break;
		case ConnectionInfo.多足_蜘_節足左2_接続:
			節足_足蜘2.角度B += -20.0;
			break;
		case ConnectionInfo.多足_蜘_節足左3_接続:
			節足_足蜘2.角度B += -40.0;
			break;
		case ConnectionInfo.多足_蜘_節足左4_接続:
			節足_足蜘2.角度B += -60.0;
			break;
		}
		if (節足_足蜘2.反転Y)
		{
			節足_足蜘2.X0Y0_基節.AngleBase += 0.0 - 基節角度 + (0.0 - u1);
			節足_足蜘2.X0Y0_転節.AngleBase += 0.0 - 転節角度 + (0.0 - u2);
			節足_足蜘2.X0Y0_腿節.AngleBase += 0.0 - 腿節角度 + (0.0 - u3);
			節足_足蜘2.X0Y0_膝節.AngleBase += 0.0 - 膝節角度 + (0.0 - u4);
			節足_足蜘2.X0Y0_脛節.AngleBase += 0.0 - 脛節角度 + (0.0 - u5);
			節足_足蜘2.X0Y0_蹠節.AngleBase += 0.0 - 蹠節角度 + (0.0 - u6);
			節足_足蜘2.X0Y0_跗節1.AngleBase += 0.0 - 跗節1角度 + (0.0 - u7);
			節足_足蜘2.X0Y0_跗節2.AngleBase += 0.0 - 跗節2角度 + (0.0 - u8);
		}
		else
		{
			節足_足蜘2.X0Y0_基節.AngleBase += 基節角度 + u1;
			節足_足蜘2.X0Y0_転節.AngleBase += 転節角度 + u2;
			節足_足蜘2.X0Y0_腿節.AngleBase += 腿節角度 + u3;
			節足_足蜘2.X0Y0_膝節.AngleBase += 膝節角度 + u4;
			節足_足蜘2.X0Y0_脛節.AngleBase += 脛節角度 + u5;
			節足_足蜘2.X0Y0_蹠節.AngleBase += 蹠節角度 + u6;
			節足_足蜘2.X0Y0_跗節1.AngleBase += 跗節1角度 + u7;
			節足_足蜘2.X0Y0_跗節2.AngleBase += 跗節2角度 + u8;
		}
	}

	public static void 節足蜘右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8, double 基節角度, double 転節角度, double 腿節角度, double 膝節角度, double 脛節角度, double 蹠節角度, double 跗節1角度, double 跗節2角度)
	{
		節足_足蜘 節足_足蜘2 = Cha.Bod.節足蜘右[n];
		節足_足蜘2.SetAngle0();
		switch (節足_足蜘2.ConnectionType)
		{
		case ConnectionInfo.多足_蜘_節足右1_接続:
			節足_足蜘2.角度B += 0.0;
			break;
		case ConnectionInfo.多足_蜘_節足右2_接続:
			節足_足蜘2.角度B += 20.0;
			break;
		case ConnectionInfo.多足_蜘_節足右3_接続:
			節足_足蜘2.角度B += 40.0;
			break;
		case ConnectionInfo.多足_蜘_節足右4_接続:
			節足_足蜘2.角度B += 60.0;
			break;
		}
		if (節足_足蜘2.反転Y)
		{
			節足_足蜘2.X0Y0_基節.AngleBase += 基節角度 + u1;
			節足_足蜘2.X0Y0_転節.AngleBase += 転節角度 + u2;
			節足_足蜘2.X0Y0_腿節.AngleBase += 腿節角度 + u3;
			節足_足蜘2.X0Y0_膝節.AngleBase += 膝節角度 + u4;
			節足_足蜘2.X0Y0_脛節.AngleBase += 脛節角度 + u5;
			節足_足蜘2.X0Y0_蹠節.AngleBase += 蹠節角度 + u6;
			節足_足蜘2.X0Y0_跗節1.AngleBase += 跗節1角度 + u7;
			節足_足蜘2.X0Y0_跗節2.AngleBase += 跗節2角度 + u8;
		}
		else
		{
			節足_足蜘2.X0Y0_基節.AngleBase += 0.0 - 基節角度 + (0.0 - u1);
			節足_足蜘2.X0Y0_転節.AngleBase += 0.0 - 転節角度 + (0.0 - u2);
			節足_足蜘2.X0Y0_腿節.AngleBase += 0.0 - 腿節角度 + (0.0 - u3);
			節足_足蜘2.X0Y0_膝節.AngleBase += 0.0 - 膝節角度 + (0.0 - u4);
			節足_足蜘2.X0Y0_脛節.AngleBase += 0.0 - 脛節角度 + (0.0 - u5);
			節足_足蜘2.X0Y0_蹠節.AngleBase += 0.0 - 蹠節角度 + (0.0 - u6);
			節足_足蜘2.X0Y0_跗節1.AngleBase += 0.0 - 跗節1角度 + (0.0 - u7);
			節足_足蜘2.X0Y0_跗節2.AngleBase += 0.0 - 跗節2角度 + (0.0 - u8);
		}
	}

	public static void 節足蜘_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足蜘左(n, u1, u2, u3, u4, u5, u6, u7, u8, 0.0, 0.0, 0.0, 15.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 節足蜘_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足蜘右(n, u1, u2, u3, u4, u5, u6, u7, u8, 0.0, 0.0, 0.0, 15.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 節足蜘_萎縮左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足蜘左(n, u1, u2, u3, u4, u5, u6, u7, u8, 0.0, 0.0, 0.0, 45.0, -15.0, 45.0, 0.0, 0.0);
	}

	public static void 節足蜘_萎縮右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足蜘右(n, u1, u2, u3, u4, u5, u6, u7, u8, 0.0, 0.0, 0.0, 45.0, -15.0, 45.0, 0.0, 0.0);
	}

	public static void 節足蜘_開く左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足蜘左(n, u1, u2, u3, u4, u5, u6, u7, u8, 20.0, 0.0, 0.0, -25.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 節足蜘_開く右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足蜘右(n, u1, u2, u3, u4, u5, u6, u7, u8, 20.0, 0.0, 0.0, -25.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 両節足蜘_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u5;
		double u6;
		double u7;
		double u8;
		if (同角)
		{
			u5 = num;
			u6 = num2;
			u7 = num3;
			u8 = num4;
		}
		else
		{
			u5 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u6 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u7 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u8 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		}
		Cha.節足蜘左_0(i1, n, num, num2, num3, num4, u, u2, u3, u4);
		Cha.節足蜘右_0(i2, n, u5, u6, u7, u8, u, u2, u3, u4);
	}

	public static void 節足蜘左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		switch (i)
		{
		case 0:
			c.節足蜘_基本左(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		case 1:
			c.節足蜘_萎縮左(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		case 2:
			c.節足蜘_開く左(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		}
	}

	public static void 節足蜘右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		switch (i)
		{
		case 0:
			c.節足蜘_基本右(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		case 1:
			c.節足蜘_萎縮右(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		case 2:
			c.節足蜘_開く右(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		}
	}

	public static void 節足蜘絶頂(this Cha Cha, double a)
	{
		foreach (節足_足蜘 item in Cha.Bod.節足蜘左)
		{
			item.X0Y0_基節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_転節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_腿節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_膝節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脛節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_蹠節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_跗節1.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_跗節2.AngleCont = a * RNG.XS.NextDouble();
		}
		foreach (節足_足蜘 item2 in Cha.Bod.節足蜘右)
		{
			item2.X0Y0_基節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_転節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_腿節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_膝節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_脛節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_蹠節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_跗節1.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_跗節2.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
		}
	}

	public static void 節足蠍_蠍左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double 転節角度, double 腿節角度, double 膝節角度, double 脛節角度, double 蹠節角度, double 跗節1角度, double 跗節2角度)
	{
		節足_足蠍 節足_足蠍2 = Cha.Bod.節足蠍左[n];
		節足_足蠍2.SetAngle0();
		switch (節足_足蠍2.ConnectionType)
		{
		case ConnectionInfo.多足_蠍_節足左1_接続:
			節足_足蠍2.角度B += 2.0;
			break;
		case ConnectionInfo.多足_蠍_節足左2_接続:
			節足_足蠍2.角度B += 16.0;
			break;
		case ConnectionInfo.多足_蠍_節足左3_接続:
			節足_足蠍2.角度B += 26.0;
			break;
		case ConnectionInfo.多足_蠍_節足左4_接続:
			節足_足蠍2.角度B += 20.0;
			break;
		}
		if (節足_足蠍2.反転Y)
		{
			節足_足蠍2.X0Y0_転節.AngleBase += 0.0 - 転節角度 + (0.0 - u1);
			節足_足蠍2.X0Y0_腿節.AngleBase += 0.0 - 腿節角度 + (0.0 - u2);
			節足_足蠍2.X0Y0_膝節.AngleBase += 0.0 - 膝節角度 + (0.0 - u3);
			節足_足蠍2.X0Y0_脛節.AngleBase += 0.0 - 脛節角度 + (0.0 - u4);
			節足_足蠍2.X0Y0_蹠節.AngleBase += 0.0 - 蹠節角度 + (0.0 - u5);
			節足_足蠍2.X0Y0_跗節1.AngleBase += 0.0 - 跗節1角度 + (0.0 - u6);
			節足_足蠍2.X0Y0_跗節2.AngleBase += 0.0 - 跗節2角度 + (0.0 - u7);
		}
		else
		{
			節足_足蠍2.X0Y0_転節.AngleBase += 転節角度 + u1;
			節足_足蠍2.X0Y0_腿節.AngleBase += 腿節角度 + u2;
			節足_足蠍2.X0Y0_膝節.AngleBase += 膝節角度 + u3;
			節足_足蠍2.X0Y0_脛節.AngleBase += 脛節角度 + u4;
			節足_足蠍2.X0Y0_蹠節.AngleBase += 蹠節角度 + u5;
			節足_足蠍2.X0Y0_跗節1.AngleBase += 跗節1角度 + u6;
			節足_足蠍2.X0Y0_跗節2.AngleBase += 跗節2角度 + u7;
		}
	}

	public static void 節足蠍_蠍右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double 転節角度, double 腿節角度, double 膝節角度, double 脛節角度, double 蹠節角度, double 跗節1角度, double 跗節2角度)
	{
		節足_足蠍 節足_足蠍2 = Cha.Bod.節足蠍右[n];
		節足_足蠍2.SetAngle0();
		switch (節足_足蠍2.ConnectionType)
		{
		case ConnectionInfo.多足_蠍_節足右1_接続:
			節足_足蠍2.角度B += -2.0;
			break;
		case ConnectionInfo.多足_蠍_節足右2_接続:
			節足_足蠍2.角度B += -16.0;
			break;
		case ConnectionInfo.多足_蠍_節足右3_接続:
			節足_足蠍2.角度B += -26.0;
			break;
		case ConnectionInfo.多足_蠍_節足右4_接続:
			節足_足蠍2.角度B += -20.0;
			break;
		}
		if (節足_足蠍2.反転Y)
		{
			節足_足蠍2.X0Y0_転節.AngleBase += 転節角度 + u1;
			節足_足蠍2.X0Y0_腿節.AngleBase += 腿節角度 + u2;
			節足_足蠍2.X0Y0_膝節.AngleBase += 膝節角度 + u3;
			節足_足蠍2.X0Y0_脛節.AngleBase += 脛節角度 + u4;
			節足_足蠍2.X0Y0_蹠節.AngleBase += 蹠節角度 + u5;
			節足_足蠍2.X0Y0_跗節1.AngleBase += 跗節1角度 + u6;
			節足_足蠍2.X0Y0_跗節2.AngleBase += 跗節2角度 + u7;
		}
		else
		{
			節足_足蠍2.X0Y0_転節.AngleBase += 0.0 - 転節角度 + (0.0 - u1);
			節足_足蠍2.X0Y0_腿節.AngleBase += 0.0 - 腿節角度 + (0.0 - u2);
			節足_足蠍2.X0Y0_膝節.AngleBase += 0.0 - 膝節角度 + (0.0 - u3);
			節足_足蠍2.X0Y0_脛節.AngleBase += 0.0 - 脛節角度 + (0.0 - u4);
			節足_足蠍2.X0Y0_蹠節.AngleBase += 0.0 - 蹠節角度 + (0.0 - u5);
			節足_足蠍2.X0Y0_跗節1.AngleBase += 0.0 - 跗節1角度 + (0.0 - u6);
			節足_足蠍2.X0Y0_跗節2.AngleBase += 0.0 - 跗節2角度 + (0.0 - u7);
		}
	}

	public static void 節足蠍_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足蠍_蠍左(n, u1, u2, u3, u4, u5, u6, u7, -15.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 節足蠍_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足蠍_蠍右(n, u1, u2, u3, u4, u5, u6, u7, -15.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 節足蠍_萎縮左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足蠍_蠍左(n, u1, u2, u3, u4, u5, u6, u7, -20.0, 0.0, 45.0, 25.0, 0.0, 0.0, 0.0);
	}

	public static void 節足蠍_萎縮右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足蠍_蠍右(n, u1, u2, u3, u4, u5, u6, u7, -20.0, 0.0, 45.0, 25.0, 0.0, 0.0, 0.0);
	}

	public static void 節足蠍_開く左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足蠍_蠍左(n, u1, u2, u3, u4, u5, u6, u7, 0.0, 0.0, -15.0, -25.0, 0.0, 0.0, 0.0);
	}

	public static void 節足蠍_開く右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足蠍_蠍右(n, u1, u2, u3, u4, u5, u6, u7, 0.0, 0.0, -15.0, -25.0, 0.0, 0.0, 0.0);
	}

	public static void 両節足蠍_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u5;
		double u6;
		double u7;
		double u8;
		if (同角)
		{
			u5 = num;
			u6 = num2;
			u7 = num3;
			u8 = num4;
		}
		else
		{
			u5 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u6 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u7 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u8 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		}
		Cha.節足蠍左_0(i1, n, num, num2, num3, num4, u, u2, u3, u4);
		Cha.節足蠍右_0(i2, n, u5, u6, u7, u8, u, u2, u3, u4);
	}

	public static void 節足蠍左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		switch (i)
		{
		case 0:
			c.節足蠍_基本左(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		case 1:
			c.節足蠍_萎縮左(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		case 2:
			c.節足蠍_開く左(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		}
	}

	public static void 節足蠍右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		switch (i)
		{
		case 0:
			c.節足蠍_基本右(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		case 1:
			c.節足蠍_萎縮右(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		case 2:
			c.節足蠍_開く右(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		}
	}

	public static void 節足蠍絶頂(this Cha Cha, double a)
	{
		foreach (節足_足蠍 item in Cha.Bod.節足蠍左)
		{
			item.X0Y0_転節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_腿節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_膝節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脛節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_蹠節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_跗節1.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_跗節2.AngleCont = a * RNG.XS.NextDouble();
		}
		foreach (節足_足蠍 item2 in Cha.Bod.節足蠍右)
		{
			item2.X0Y0_転節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_腿節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_膝節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_脛節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_蹠節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_跗節1.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_跗節2.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
		}
	}

	public static void 節足百左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double 基節角度, double 転節角度, double 前腿節角度, double 腿節角度, double 脛節角度, double 跗節1角度, double 跗節2角度)
	{
		節足_足百 節足_足百2 = Cha.Bod.節足百左[n];
		節足_足百2.SetAngle0();
		if (節足_足百2.反転Y)
		{
			節足_足百2.X0Y0_基節.AngleBase += 0.0 - 基節角度 + (0.0 - u1);
			節足_足百2.X0Y0_転節.AngleBase += 0.0 - 転節角度 + (0.0 - u2);
			節足_足百2.X0Y0_前腿節.AngleBase += 0.0 - 前腿節角度 + (0.0 - u3);
			節足_足百2.X0Y0_腿節.AngleBase += 0.0 - 腿節角度 + (0.0 - u4);
			節足_足百2.X0Y0_脛節.AngleBase += 0.0 - 脛節角度 + (0.0 - u5);
			節足_足百2.X0Y0_跗節1.AngleBase += 0.0 - 跗節1角度 + (0.0 - u6);
			節足_足百2.X0Y0_跗節2.AngleBase += 0.0 - 跗節2角度 + (0.0 - u7);
		}
		else
		{
			節足_足百2.X0Y0_基節.AngleBase += 基節角度 + u1;
			節足_足百2.X0Y0_転節.AngleBase += 転節角度 + u2;
			節足_足百2.X0Y0_前腿節.AngleBase += 前腿節角度 + u3;
			節足_足百2.X0Y0_腿節.AngleBase += 腿節角度 + u4;
			節足_足百2.X0Y0_脛節.AngleBase += 脛節角度 + u5;
			節足_足百2.X0Y0_跗節1.AngleBase += 跗節1角度 + u6;
			節足_足百2.X0Y0_跗節2.AngleBase += 跗節2角度 + u7;
		}
	}

	public static void 節足百右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double 基節角度, double 転節角度, double 前腿節角度, double 腿節角度, double 脛節角度, double 跗節1角度, double 跗節2角度)
	{
		節足_足百 節足_足百2 = Cha.Bod.節足百右[n];
		節足_足百2.SetAngle0();
		if (節足_足百2.反転Y)
		{
			節足_足百2.X0Y0_基節.AngleBase += 基節角度 + u1;
			節足_足百2.X0Y0_転節.AngleBase += 転節角度 + u2;
			節足_足百2.X0Y0_前腿節.AngleBase += 前腿節角度 + u3;
			節足_足百2.X0Y0_腿節.AngleBase += 腿節角度 + u4;
			節足_足百2.X0Y0_脛節.AngleBase += 脛節角度 + u5;
			節足_足百2.X0Y0_跗節1.AngleBase += 跗節1角度 + u6;
			節足_足百2.X0Y0_跗節2.AngleBase += 跗節2角度 + u7;
		}
		else
		{
			節足_足百2.X0Y0_基節.AngleBase += 0.0 - 基節角度 + (0.0 - u1);
			節足_足百2.X0Y0_転節.AngleBase += 0.0 - 転節角度 + (0.0 - u2);
			節足_足百2.X0Y0_前腿節.AngleBase += 0.0 - 前腿節角度 + (0.0 - u3);
			節足_足百2.X0Y0_腿節.AngleBase += 0.0 - 腿節角度 + (0.0 - u4);
			節足_足百2.X0Y0_脛節.AngleBase += 0.0 - 脛節角度 + (0.0 - u5);
			節足_足百2.X0Y0_跗節1.AngleBase += 0.0 - 跗節1角度 + (0.0 - u6);
			節足_足百2.X0Y0_跗節2.AngleBase += 0.0 - 跗節2角度 + (0.0 - u7);
		}
	}

	public static void 節足百_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足百左(n, u1, u2, u3, u4, u5, u6, u7, 0.0, 0.0, 15.0, 0.0, -15.0, 0.0, 0.0);
	}

	public static void 節足百_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足百右(n, u1, u2, u3, u4, u5, u6, u7, 0.0, 0.0, 15.0, 0.0, -15.0, 0.0, 0.0);
	}

	public static void 節足百_萎縮左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足百左(n, u1, u2, u3, u4, u5, u6, u7, 0.0, 0.0, 5.0, -25.0, -35.0, -25.0, 0.0);
	}

	public static void 節足百_萎縮右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足百右(n, u1, u2, u3, u4, u5, u6, u7, 0.0, 0.0, 5.0, -25.0, -35.0, -25.0, 0.0);
	}

	public static void 節足百_開く左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足百左(n, u1, u2, u3, u4, u5, u6, u7, 0.0, 0.0, 15.0, 5.0, 5.0, 5.0, 0.0);
	}

	public static void 節足百_開く右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		Cha.節足百右(n, u1, u2, u3, u4, u5, u6, u7, 0.0, 0.0, 15.0, 5.0, 5.0, 5.0, 0.0);
	}

	public static void 両節足百_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u5;
		double u6;
		double u7;
		double u8;
		if (同角)
		{
			u5 = num;
			u6 = num2;
			u7 = num3;
			u8 = num4;
		}
		else
		{
			u5 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u6 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u7 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u8 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		}
		Cha.節足百左_0(i1, n, num, num2, num3, num4, u, u2, u3, u4);
		Cha.節足百右_0(i2, n, u5, u6, u7, u8, u, u2, u3, u4);
	}

	public static void 節足百左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		switch (i)
		{
		case 0:
			c.節足百_基本左(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		case 1:
			c.節足百_萎縮左(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		case 2:
			c.節足百_開く左(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		}
	}

	public static void 節足百右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double u8)
	{
		switch (i)
		{
		case 0:
			c.節足百_基本右(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		case 1:
			c.節足百_萎縮右(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		case 2:
			c.節足百_開く右(n, u1, u2, u3, u4, u5, u6, u7, u8);
			break;
		}
	}

	public static void 節足百絶頂(this Cha Cha, double a)
	{
		foreach (節足_足百 item in Cha.Bod.節足百左)
		{
			item.X0Y0_基節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_転節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_前腿節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_腿節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脛節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_跗節1.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_跗節2.AngleCont = a * RNG.XS.NextDouble();
		}
		foreach (節足_足百 item2 in Cha.Bod.節足百右)
		{
			item2.X0Y0_基節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_転節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_前腿節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_腿節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_脛節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_跗節1.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_跗節2.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
		}
	}

	public static void 節尾曳左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double 根本角度, double 節角度1, double 節角度2, double 節角度3, double 節角度4)
	{
		節尾_曳航 obj = Cha.Bod.節尾曳左[n];
		obj.SetAngle0();
		obj.X0Y0_前腿節.AngleBase += 根本角度 + u1;
		obj.X0Y0_腿節.AngleBase += 節角度1 + u2;
		obj.X0Y0_脛節.AngleBase += 節角度2 + u3;
		obj.X0Y0_付節1.AngleBase += 節角度3 + u4;
		obj.X0Y0_付節2.AngleBase += 節角度4 + u5;
	}

	public static void 節尾曳右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double 根本角度, double 節角度1, double 節角度2, double 節角度3, double 節角度4)
	{
		節尾_曳航 obj = Cha.Bod.節尾曳右[n];
		obj.SetAngle0();
		obj.X0Y0_前腿節.AngleBase += 0.0 - 根本角度 + (0.0 - u1);
		obj.X0Y0_腿節.AngleBase += 0.0 - 節角度1 + (0.0 - u2);
		obj.X0Y0_脛節.AngleBase += 0.0 - 節角度2 + (0.0 - u3);
		obj.X0Y0_付節1.AngleBase += 0.0 - 節角度3 + (0.0 - u4);
		obj.X0Y0_付節2.AngleBase += 0.0 - 節角度4 + (0.0 - u5);
	}

	public static void 節尾曳_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
	{
		Cha.節尾曳左(n, u1, u2, u3, u4, u5, 10.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 節尾曳_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
	{
		Cha.節尾曳右(n, u1, u2, u3, u4, u5, 10.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 節尾曳_閉じ左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
	{
		Cha.節尾曳左(n, u1, u2, u3, u4, u5, 45.0, -25.0, -45.0, -45.0, 0.0);
	}

	public static void 節尾曳_閉じ右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
	{
		Cha.節尾曳右(n, u1, u2, u3, u4, u5, 45.0, -25.0, -45.0, -45.0, 0.0);
	}

	public static void 節尾曳_開き左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
	{
		Cha.節尾曳左(n, u1, u2, u3, u4, u5, 25.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 節尾曳_開き右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
	{
		Cha.節尾曳右(n, u1, u2, u3, u4, u5, 25.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 両節尾曳_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num5 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u;
		double u2;
		double u3;
		double u4;
		double u5;
		if (同角)
		{
			u = num;
			u2 = num2;
			u3 = num3;
			u4 = num4;
			u5 = num5;
		}
		else
		{
			u = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u5 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		}
		Cha.節尾曳左_0(i1, n, num, num2, num3, num4, num5);
		Cha.節尾曳右_0(i2, n, u, u2, u3, u4, u5);
	}

	public static void 節尾曳左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5)
	{
		switch (i)
		{
		case 0:
			c.節尾曳_基本左(n, u1, u2, u3, u4, u5);
			break;
		case 1:
			c.節尾曳_閉じ左(n, u1, u2, u3, u4, u5);
			break;
		case 2:
			c.節尾曳_開き左(n, u1, u2, u3, u4, u5);
			break;
		}
	}

	public static void 節尾曳右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5)
	{
		switch (i)
		{
		case 0:
			c.節尾曳_基本右(n, u1, u2, u3, u4, u5);
			break;
		case 1:
			c.節尾曳_閉じ右(n, u1, u2, u3, u4, u5);
			break;
		case 2:
			c.節尾曳_開き右(n, u1, u2, u3, u4, u5);
			break;
		}
	}

	public static void 節尾曳絶頂(this Cha Cha, double a)
	{
		foreach (節尾_曳航 item in Cha.Bod.節尾曳左)
		{
			item.X0Y0_前腿節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_腿節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脛節.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_付節1.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_付節2.AngleCont = a * RNG.XS.NextDouble();
		}
		foreach (節尾_曳航 item2 in Cha.Bod.節尾曳右)
		{
			item2.X0Y0_前腿節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_腿節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_脛節.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_付節1.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item2.X0Y0_付節2.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
		}
	}

	public static void 節尾鋏左(this Cha Cha, int n, double u1, double 根本角度)
	{
		節尾_鋏 obj = Cha.Bod.節尾鋏左[n];
		obj.SetAngle0();
		obj.X0Y0_牙.AngleBase += 根本角度 + u1;
	}

	public static void 節尾鋏右(this Cha Cha, int n, double u1, double 根本角度)
	{
		節尾_鋏 obj = Cha.Bod.節尾鋏右[n];
		obj.SetAngle0();
		obj.X0Y0_牙.AngleBase += 0.0 - 根本角度 + (0.0 - u1);
	}

	public static void 節尾鋏_基本左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
	{
		Cha.節尾鋏左(n, u1, 0.0);
	}

	public static void 節尾鋏_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
	{
		Cha.節尾鋏右(n, u1, 0.0);
	}

	public static void 節尾鋏_閉じ左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
	{
		Cha.節尾鋏左(n, u1, -15.0);
	}

	public static void 節尾鋏_閉じ右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
	{
		Cha.節尾鋏右(n, u1, -15.0);
	}

	public static void 節尾鋏_開き左(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
	{
		Cha.節尾鋏左(n, u1, 25.0);
	}

	public static void 節尾鋏_開き右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5)
	{
		Cha.節尾鋏右(n, u1, 25.0);
	}

	public static void 両節尾鋏_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double num5 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u;
		double u2;
		double u3;
		double u4;
		double u5;
		if (同角)
		{
			u = num;
			u2 = num2;
			u3 = num3;
			u4 = num4;
			u5 = num5;
		}
		else
		{
			u = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u2 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u3 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			u5 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		}
		Cha.節尾鋏左_0(i1, n, num, num2, num3, num4, num5);
		Cha.節尾鋏右_0(i2, n, u, u2, u3, u4, u5);
	}

	public static void 節尾鋏左_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5)
	{
		switch (i)
		{
		case 0:
			c.節尾鋏_基本左(n, u1, u2, u3, u4, u5);
			break;
		case 1:
			c.節尾鋏_閉じ左(n, u1, u2, u3, u4, u5);
			break;
		case 2:
			c.節尾鋏_開き左(n, u1, u2, u3, u4, u5);
			break;
		}
	}

	public static void 節尾鋏右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5)
	{
		switch (i)
		{
		case 0:
			c.節尾鋏_基本右(n, u1, u2, u3, u4, u5);
			break;
		case 1:
			c.節尾鋏_閉じ右(n, u1, u2, u3, u4, u5);
			break;
		case 2:
			c.節尾鋏_開き右(n, u1, u2, u3, u4, u5);
			break;
		}
	}

	public static void 節尾鋏絶頂(this Cha Cha, double a)
	{
		foreach (節尾_鋏 item in Cha.Bod.節尾鋏左)
		{
			item.X0Y0_牙.AngleCont = a * RNG.XS.NextDouble();
		}
		foreach (節尾_鋏 item2 in Cha.Bod.節尾鋏右)
		{
			item2.X0Y0_牙.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
		}
	}

	public static void 虫鎌左(this Cha Cha, int n, double u1, double 根本角度)
	{
		虫鎌 虫鎌2 = Cha.Bod.虫鎌左[n];
		if (虫鎌2.拘束)
		{
			虫鎌2.SetAngle0();
			return;
		}
		虫鎌2.SetAngle0();
		if (虫鎌2.反転Y)
		{
			虫鎌2.X0Y0_虫鎌1.AngleBase += 0.0 - 根本角度 + (0.0 - u1);
		}
		else
		{
			虫鎌2.X0Y0_虫鎌1.AngleBase += 根本角度 + u1;
		}
	}

	public static void 虫鎌右(this Cha Cha, int n, double u1, double 根本角度)
	{
		虫鎌 虫鎌2 = Cha.Bod.虫鎌右[n];
		if (虫鎌2.拘束)
		{
			虫鎌2.SetAngle0();
			return;
		}
		虫鎌2.SetAngle0();
		if (虫鎌2.反転Y)
		{
			虫鎌2.X0Y0_虫鎌1.AngleBase += 根本角度 + u1;
		}
		else
		{
			虫鎌2.X0Y0_虫鎌1.AngleBase += 0.0 - 根本角度 + (0.0 - u1);
		}
	}

	public static void 虫鎌_基本左(this Cha Cha, int n, double u1)
	{
		Cha.虫鎌左(n, u1, 0.0);
	}

	public static void 虫鎌_基本右(this Cha Cha, int n, double u1)
	{
		Cha.虫鎌右(n, u1, 0.0);
	}

	public static void 虫鎌_半開左(this Cha Cha, int n, double u1)
	{
		Cha.虫鎌左(n, u1, 45.0);
	}

	public static void 虫鎌_半開右(this Cha Cha, int n, double u1)
	{
		Cha.虫鎌右(n, u1, 45.0);
	}

	public static void 虫鎌_全開左(this Cha Cha, int n, double u1)
	{
		Cha.虫鎌左(n, u1, 90.0);
	}

	public static void 虫鎌_全開右(this Cha Cha, int n, double u1)
	{
		Cha.虫鎌右(n, u1, 90.0);
	}

	public static void 両虫鎌_0(this Cha Cha, int n, bool 同角, int i1, int i2)
	{
		double num = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		double u = ((!同角) ? Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5) : num);
		Cha.虫鎌左_0(i1, n, num);
		Cha.虫鎌右_0(i2, n, u);
	}

	public static void 虫鎌左_0(this Cha c, int i, int n, double u1)
	{
		switch (i)
		{
		case 0:
			c.虫鎌_基本左(n, 0.0);
			break;
		case 1:
			c.虫鎌_半開左(n, u1);
			break;
		case 2:
			c.虫鎌_全開左(n, u1);
			break;
		}
	}

	public static void 虫鎌右_0(this Cha c, int i, int n, double u1)
	{
		switch (i)
		{
		case 0:
			c.虫鎌_基本右(n, 0.0);
			break;
		case 1:
			c.虫鎌_半開右(n, u1);
			break;
		case 2:
			c.虫鎌_全開右(n, u1);
			break;
		}
	}

	public static void 虫鎌絶頂(this Cha Cha, double a)
	{
		foreach (虫鎌 item in Cha.Bod.虫鎌左)
		{
			if (!item.拘束)
			{
				item.角度C = a * RNG.XS.NextDouble();
			}
		}
		foreach (虫鎌 item2 in Cha.Bod.虫鎌右)
		{
			if (!item2.拘束)
			{
				item2.角度C = (0.0 - a) * RNG.XS.NextDouble();
			}
		}
	}

	public static void 触手左(this Cha Cha, int n, int si, double u1, double u2, double u3, double 根本角度, double 開口, params Func<int, double>[] angs)
	{
		触手 触手2 = Cha.Bod.触手左[n];
		触手2.SetAngle0();
		if (angs.Length != 0)
		{
			Par[] array = 触手2.Enum軸().ToArray();
			if (array.Length != 0)
			{
				int num = 0;
				int num2 = array.Length / angs.Length;
				double num3 = (double)array.Length * 0.1;
				foreach (Par item in array.Skip(1))
				{
					item.AngleBase = (double)si * (angs[(num / num2).Limit(0, angs.Length)](num) / num3 + u2);
					num++;
				}
				array[0].AngleBase = (double)si * (根本角度 + u1);
			}
		}
		if (触手2 is 触手_蔦)
		{
			if (触手2.拘束)
			{
				触手_蔦 触手_蔦2 = (触手_蔦)触手2;
				if (触手_蔦2.先端_上顎_顎_表示)
				{
					触手_蔦2.X0Y0_先端_上顎_顎.AngleBase = 0.0;
				}
				if (触手_蔦2.先端_下顎_顎_表示)
				{
					触手_蔦2.X0Y0_先端_下顎_顎.AngleBase = 0.0;
				}
			}
			else
			{
				触手_蔦 触手_蔦3 = (触手_蔦)触手2;
				if (触手_蔦3.先端_上顎_顎_表示)
				{
					触手_蔦3.X0Y0_先端_上顎_顎.AngleBase = 15.0 * 開口 + u3;
				}
				if (触手_蔦3.先端_下顎_顎_表示)
				{
					触手_蔦3.X0Y0_先端_下顎_顎.AngleBase = -15.0 * 開口 + (0.0 - u3);
				}
			}
		}
		触手2.重複角度処理();
	}

	public static void 触手右(this Cha Cha, int n, int si, double u1, double u2, double u3, double 根本角度, double 開口, params Func<int, double>[] angs)
	{
		触手 触手2 = Cha.Bod.触手右[n];
		触手2.SetAngle0();
		if (angs.Length != 0)
		{
			Par[] array = 触手2.Enum軸().ToArray();
			if (array.Length != 0)
			{
				int num = 0;
				int num2 = array.Length / angs.Length;
				double num3 = (double)array.Length * 0.1;
				foreach (Par item in array.Skip(1))
				{
					item.AngleBase = (double)si * ((0.0 - angs[(num / num2).Limit(0, angs.Length)](num)) / num3 + (0.0 - u2));
					num++;
				}
				array[0].AngleBase = (double)si * (0.0 - 根本角度 + (0.0 - u1));
			}
		}
		if (触手2 is 触手_蔦)
		{
			if (触手2.拘束)
			{
				触手_蔦 触手_蔦2 = (触手_蔦)触手2;
				if (触手_蔦2.先端_上顎_顎_表示)
				{
					触手_蔦2.X0Y0_先端_上顎_顎.AngleBase = 0.0;
				}
				if (触手_蔦2.先端_下顎_顎_表示)
				{
					触手_蔦2.X0Y0_先端_下顎_顎.AngleBase = 0.0;
				}
			}
			else
			{
				触手_蔦 触手_蔦3 = (触手_蔦)触手2;
				if (触手_蔦3.先端_上顎_顎_表示)
				{
					触手_蔦3.X0Y0_先端_上顎_顎.AngleBase = -15.0 * 開口 + (0.0 - u3);
				}
				if (触手_蔦3.先端_下顎_顎_表示)
				{
					触手_蔦3.X0Y0_先端_下顎_顎.AngleBase = 15.0 * 開口 + u3;
				}
			}
		}
		触手2.重複角度処理();
	}

	public static void 触手_基本左(this Cha Cha, int n, int s, double u1, double u2, double u3)
	{
		Cha.触手左(n, s, u1, u2, u3, 20.0.GetRanAngle(), 0.0);
	}

	public static void 触手_基本右(this Cha Cha, int n, int s, double u1, double u2, double u3)
	{
		Cha.触手右(n, s, u1, u2, u3, 20.0.GetRanAngle(), 0.0);
	}

	public static void 触手_S字左(this Cha Cha, int n, int s, double u1, double u2, double u3)
	{
		Cha.触手左(n, s, u1, u2, u3, 20.0.GetRanAngle(), 0.25, (int i) => 35.0, (int i) => -35.0);
	}

	public static void 触手_S字右(this Cha Cha, int n, int s, double u1, double u2, double u3)
	{
		Cha.触手右(n, s, u1, u2, u3, 20.0.GetRanAngle(), 0.25, (int i) => 35.0, (int i) => -35.0);
	}

	public static void 触手_波左(this Cha Cha, int n, int s, double u1, double u2, double u3)
	{
		Cha.触手左(n, s, u1, u2, u3, 20.0.GetRanAngle(), 0.25, (int i) => System.Math.Sin(i) * 80.0);
	}

	public static void 触手_波右(this Cha Cha, int n, int s, double u1, double u2, double u3)
	{
		Cha.触手右(n, s, u1, u2, u3, 20.0.GetRanAngle(), 0.25, (int i) => System.Math.Sin(i) * 80.0);
	}

	public static void 触手_ピーン左(this Cha Cha, int n, int s, double u1, double u2, double u3)
	{
		Cha.触手左(n, s, u1, u2, u3, 20.0.GetRanAngle(), 0.0, (int i) => 0.0, (int i) => 25.0.GetRanAngle());
	}

	public static void 触手_ピーン右(this Cha Cha, int n, int s, double u1, double u2, double u3)
	{
		Cha.触手右(n, s, u1, u2, u3, 20.0.GetRanAngle(), 0.0, (int i) => 0.0, (int i) => 25.0.GetRanAngle());
	}

	public static void 両触手_S字(this Cha Cha, int n)
	{
		double u = Cha.角度ムラ(RNG.XS.NextSign(), 1.5, RNG.XS.NextSign(), 0.75);
		double u2 = Cha.角度ムラ(RNG.XS.NextSign(), 1.5, RNG.XS.NextSign(), 0.75);
		double u3 = Cha.角度ムラ(RNG.XS.NextSign(), 1.5, RNG.XS.NextSign(), 0.75);
		int s = RNG.XS.NextSign();
		Cha.触手_S字左(n, s, u, u2, u3);
		Cha.触手_S字右(n, s, u, u2, u3);
	}

	public static void 両触手_0(this Cha Cha, int n, int i2)
	{
		Cha.触手右_0(i2, n, RNG.XS.NextSign(), Cha.角度ムラ(RNG.XS.NextSign(), 1.5, RNG.XS.NextSign(), 0.25), Cha.角度ムラ(RNG.XS.NextSign(), 1.5, RNG.XS.NextSign(), 0.25), Cha.角度ムラ(RNG.XS.NextSign(), 1.5, RNG.XS.NextSign(), 0.25));
	}

	public static void 触手左_0(this Cha c, int i, int n, int s, double u1, double u2, double u3)
	{
		switch (i)
		{
		case 0:
			c.触手_基本左(n, s, u1, u2, u3);
			break;
		case 1:
			c.触手_S字左(n, s, u1, u2, u3);
			break;
		case 2:
			c.触手_波左(n, s, u1, u2, u3);
			break;
		case 3:
			c.触手_ピーン左(n, s, u1, u2, u3);
			break;
		}
	}

	public static void 触手右_0(this Cha c, int i, int n, int s, double u1, double u2, double u3)
	{
		switch (i)
		{
		case 0:
			c.触手_基本右(n, s, u1, u2, u3);
			break;
		case 1:
			c.触手_S字右(n, s, u1, u2, u3);
			break;
		case 2:
			c.触手_波右(n, s, u1, u2, u3);
			break;
		case 3:
			c.触手_ピーン右(n, s, u1, u2, u3);
			break;
		}
	}

	public static void 触手絶頂(this Cha Cha, double a)
	{
		foreach (触手 item in Cha.Bod.触手左)
		{
			foreach (Par item2 in item.Enum軸())
			{
				item2.AngleCont = a * RNG.XS.NextDouble();
			}
			if (!item.拘束 && item is 触手_蔦)
			{
				触手_蔦 触手_蔦2 = (触手_蔦)item;
				if (触手_蔦2.先端_上顎_顎_表示)
				{
					触手_蔦2.X0Y0_先端_上顎_顎.AngleCont = a * RNG.XS.NextDouble();
				}
				if (触手_蔦2.先端_下顎_顎_表示)
				{
					触手_蔦2.X0Y0_先端_下顎_顎.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
				}
			}
		}
		foreach (触手 item3 in Cha.Bod.触手右)
		{
			foreach (Par item4 in item3.Enum軸())
			{
				item4.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			}
			if (!item3.拘束 && item3 is 触手_蔦)
			{
				触手_蔦 触手_蔦3 = (触手_蔦)item3;
				if (触手_蔦3.先端_上顎_顎_表示)
				{
					触手_蔦3.X0Y0_先端_上顎_顎.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
				}
				if (触手_蔦3.先端_下顎_顎_表示)
				{
					触手_蔦3.X0Y0_先端_下顎_顎.AngleCont = a * RNG.XS.NextDouble();
				}
			}
		}
	}

	public static void 触手犬右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7, double 根本角度, double 上腕角度, double 下腕角度, double 手角度, double 開口, double 開指, params Func<int, double>[] angs)
	{
		触手_犬 触手_犬2 = Cha.Bod.触手犬右[n];
		触手_犬2.SetAngle0();
		触手_犬2.X0Y0_脚後_上腕.AngleBase -= 触手_犬2.X0Y0_胴_節9_胴.Angle;
		触手_犬2.X0Y0_脚前_上腕.AngleBase -= 触手_犬2.X0Y0_胴_節9_胴.Angle;
		触手_犬2.X0Y0_頭_口膜_口膜1.AngleBase -= 17.0;
		触手_犬2.X0Y0_脚後_上腕.AngleBase += 0.0 - 上腕角度 + (0.0 - u1);
		触手_犬2.X0Y0_脚後_下腕.AngleBase += 0.0 - 下腕角度 + (0.0 - u2);
		触手_犬2.X0Y0_脚後_手_手.AngleBase += 0.0 - 手角度 + (0.0 - u3);
		触手_犬2.X0Y0_脚前_上腕.AngleBase += 0.0 - 上腕角度 + u1;
		触手_犬2.X0Y0_脚前_下腕.AngleBase += 0.0 - 下腕角度 + u2;
		触手_犬2.X0Y0_脚前_手_手.AngleBase += 0.0 - 手角度 + u3;
		if (触手_犬2.拘束)
		{
			触手_犬2.X0Y0_頭_上顎_眼下_眼下.AngleBase = 0.0;
			触手_犬2.X0Y0_頭_下顎_眼下_眼下.AngleBase = 0.0;
		}
		else
		{
			触手_犬2.X0Y0_頭_上顎_眼下_眼下.AngleBase += -10.0 * 開口 + (0.0 - u4);
			触手_犬2.X0Y0_頭_下顎_眼下_眼下.AngleBase += 10.0 * 開口 + u4;
		}
		触手_犬2.X0Y0_脚後_手_親指_爪.AngleBase += 30.0 * 開指 + (0.0 - u5);
		触手_犬2.X0Y0_脚後_手_人指_指.AngleBase += 15.0 * 開指 + (0.0 - u5);
		触手_犬2.X0Y0_脚後_手_中指_指.AngleBase += -0.0 * 開指 + (0.0 - u5);
		触手_犬2.X0Y0_脚後_手_薬指_指.AngleBase += -15.0 * 開指 + (0.0 - u5);
		触手_犬2.X0Y0_脚後_手_小指_指.AngleBase += -30.0 * 開指 + (0.0 - u5);
		触手_犬2.X0Y0_脚前_手_親指_爪.AngleBase += -30.0 * 開指 + u5;
		触手_犬2.X0Y0_脚前_手_人指_指.AngleBase += -15.0 * 開指 + u5;
		触手_犬2.X0Y0_脚前_手_中指_指.AngleBase += -0.0 * 開指 + u5;
		触手_犬2.X0Y0_脚前_手_薬指_指.AngleBase += 15.0 * 開指 + u5;
		触手_犬2.X0Y0_脚前_手_小指_指.AngleBase += 30.0 * 開指 + u5;
		if (angs.Length != 0)
		{
			Par[] array = 触手_犬2.Enum軸().ToArray();
			if (array.Length != 0)
			{
				int num = 0;
				int num2 = array.Length / angs.Length;
				double num3 = (double)array.Length * 0.1;
				foreach (Par item in array.Skip(1))
				{
					item.AngleBase += (0.0 - angs[(num / num2).Limit(0, angs.Length)](num)) / num3 + (0.0 - u7);
					num++;
				}
				array[0].AngleBase += 0.0 - 根本角度 + (0.0 - u6);
			}
		}
		触手_犬2.重複角度処理();
	}

	public static void 触手犬_基本右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7)
	{
		Cha.触手犬右(n, u1, u2, u3, u4, u5, u6, u7, 5.0.GetRanAngle(), 10.0, 0.0, 0.0, 0.0, 0.0);
	}

	public static void 触手犬_伏せ右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7)
	{
		Cha.触手犬右(n, u1, u2, u3, u4, u5, u6, u7, 5.0.GetRanAngle(), -35.0, 130.0, -80.0, 0.0, 0.0, (int i) => 8.0, (int i) => -10.0);
	}

	public static void 触手犬_威嚇右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7)
	{
		Cha.触手犬右(n, u1, u2, u3, u4, u5, u6, u7, 5.0.GetRanAngle(), -20.0, 65.0, -40.0, 1.0, 1.0, (int i) => 2.5);
	}

	public static void 触手犬_竦み右(this Cha Cha, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7)
	{
		Cha.触手犬右(n, u1, u2, u3, u4, u5, u6, u7, 2.0.GetRanAngle(), -40.0, 130.0, -80.0, 0.0, 0.0, (int i) => 8.0);
	}

	public static void 両触手犬_0(this Cha Cha, int n, int i2)
	{
		Cha.触手犬右_0(i2, n, Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5), Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5), Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5), Cha.角度ムラ(RNG.XS.NextSign(), 0.5, RNG.XS.NextSign(), 0.5), Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5), Cha.角度ムラ(RNG.XS.NextSign(), 1.0, RNG.XS.NextSign(), 0.5), Cha.角度ムラ(RNG.XS.NextSign(), 1.0, RNG.XS.NextSign(), 0.5));
	}

	public static void 触手犬右_0(this Cha c, int i, int n, double u1, double u2, double u3, double u4, double u5, double u6, double u7)
	{
		switch (i)
		{
		case 0:
			c.触手犬_基本右(n, u1, u2, u3, u4, u5, u6, u7);
			break;
		case 1:
			c.触手犬_伏せ右(n, u1, u2, u3, u4, u5, u6, u7);
			break;
		case 2:
			c.触手犬_威嚇右(n, u1, u2, u3, u4, u5, u6, u7);
			break;
		case 3:
			c.触手犬_竦み右(n, u1, u2, u3, u4, u5, u6, u7);
			break;
		}
	}

	public static void 触手犬絶頂(this Cha Cha, double a)
	{
		foreach (触手_犬 item in Cha.Bod.触手犬左)
		{
			item.X0Y0_脚後_上腕.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脚前_上腕.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_頭_口膜_口膜1.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脚後_上腕.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脚後_下腕.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脚後_手_手.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脚前_上腕.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脚前_下腕.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脚前_手_手.AngleCont = a * RNG.XS.NextDouble();
			if (!item.拘束)
			{
				item.X0Y0_頭_上顎_眼下_眼下.AngleCont = a * RNG.XS.NextDouble();
				item.X0Y0_頭_下顎_眼下_眼下.AngleCont = a * RNG.XS.NextDouble();
			}
			item.X0Y0_脚後_手_親指_爪.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脚後_手_人指_指.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脚後_手_中指_指.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脚後_手_薬指_指.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脚後_手_小指_指.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脚前_手_親指_爪.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脚前_手_人指_指.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脚前_手_中指_指.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脚前_手_薬指_指.AngleCont = a * RNG.XS.NextDouble();
			item.X0Y0_脚前_手_小指_指.AngleCont = a * RNG.XS.NextDouble();
			foreach (Par item2 in item.Enum軸())
			{
				item2.AngleCont = a * RNG.XS.NextDouble();
			}
		}
		foreach (触手_犬 item3 in Cha.Bod.触手犬右)
		{
			item3.X0Y0_脚後_上腕.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_脚前_上腕.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_頭_口膜_口膜1.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_脚後_上腕.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_脚後_下腕.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_脚後_手_手.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_脚前_上腕.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_脚前_下腕.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_脚前_手_手.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			if (!item3.拘束)
			{
				item3.X0Y0_頭_上顎_眼下_眼下.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
				item3.X0Y0_頭_下顎_眼下_眼下.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			}
			item3.X0Y0_脚後_手_親指_爪.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_脚後_手_人指_指.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_脚後_手_中指_指.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_脚後_手_薬指_指.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_脚後_手_小指_指.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_脚前_手_親指_爪.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_脚前_手_人指_指.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_脚前_手_中指_指.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_脚前_手_薬指_指.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			item3.X0Y0_脚前_手_小指_指.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			foreach (Par item4 in item3.Enum軸())
			{
				item4.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
			}
		}
	}

	public static void 尾(this Cha Cha, int n, int s, double 展開, double 根本角度, params Func<int, double>[] angs)
	{
		尾 尾2 = Cha.Bod.尾[n];
		string text = 尾2.ConnectionType.ToString();
		if (text.Contains("左"))
		{
			return;
		}
		尾2.SetAngle0();
		Par[] array = 尾2.Enum軸().ToArray();
		double num = ((尾2 is 尾_蟲) ? 0.3 : 1.0);
		if (angs.Length != 0 && array.Length != 0)
		{
			int num2 = 0;
			int num3 = array.Length / angs.Length;
			if (num3 == 0)
			{
				num3 = 1;
			}
			double num4 = (double)array.Length * 0.1;
			double num5 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Par[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].AngleBase = ((double)s * angs[(num2 / num3).Limit(0, angs.Length)](num2) / num4 + num5) * num;
				num2++;
			}
			if (尾2 is 尾_鳥)
			{
				array[0].AngleBase = 0.0;
			}
			else
			{
				array[0].AngleBase = 根本角度 + Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			}
		}
		if (text.Contains("後髪0_肢系"))
		{
			double num6 = 1.0;
			foreach (Par item in array.Take(array.Length / 2))
			{
				item.AngleBase = item.AngleBase / num6 * num;
				num6 += 1.0;
			}
		}
		尾鰭_魚 ele = 尾2.EnumEle().GetEle<尾鰭_魚>();
		if (ele != null)
		{
			ele.展開 = 展開 * Cha.ChaD.固有値 * RNG.XS.NextDouble();
		}
		else if (尾2 is 尾_鳥)
		{
			((尾_鳥)尾2).展開 = 展開 * Cha.ChaD.固有値 * RNG.XS.NextDouble();
		}
		if (尾2.EnumEle().IsEle<尾鰭>())
		{
			尾2.Set尾先角度();
		}
	}

	public static void 尾_基本(this Cha Cha, int n)
	{
		Cha.尾(n, RNG.XS.NextSign(), RNG.XS.NextDouble(), 0.0);
	}

	public static void 尾_S字(this Cha Cha, int n)
	{
		Cha.尾(n, RNG.XS.NextSign(), 0.5, 10.0.GetRanAngle(), (int i) => 25.0, (int i) => -25.0);
	}

	public static void 尾_波(this Cha Cha, int n)
	{
		Cha.尾(n, RNG.XS.NextSign(), 0.5, 10.0.GetRanAngle(), (int i) => System.Math.Sin(i) * 40.0);
	}

	public static void 尾_ピーン(this Cha Cha, int n)
	{
		Cha.尾(n, RNG.XS.NextSign(), 1.0, 10.0.GetRanAngle(), (int i) => 0.0, (int i) => 25.0.GetRanAngle());
	}

	public static void 尾_0(this Cha c, int n, int i)
	{
		switch (i)
		{
		case 0:
			c.尾_基本(n);
			break;
		case 1:
			c.尾_S字(n);
			break;
		case 2:
			c.尾_波(n);
			break;
		case 3:
			c.尾_ピーン(n);
			break;
		}
	}

	public static void 尾絶頂(this Cha Cha, double a)
	{
		double 展開 = a * 0.015 * RNG.XS.NextDouble();
		foreach (尾 item in Cha.Bod.尾)
		{
			if (item.右)
			{
				foreach (Par item2 in item.Enum軸())
				{
					item2.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
				}
				尾鰭_魚 ele = item.EnumEle().GetEle<尾鰭_魚>();
				if (ele != null)
				{
					ele.展開 = 展開;
				}
				else if (item is 尾_鳥)
				{
					((尾_鳥)item).展開 = 展開;
				}
				continue;
			}
			foreach (Par item3 in item.Enum軸())
			{
				item3.AngleCont = a * RNG.XS.NextDouble();
			}
			尾鰭_魚 ele2 = item.EnumEle().GetEle<尾鰭_魚>();
			if (ele2 != null)
			{
				ele2.展開 = 展開;
			}
			else if (item is 尾_鳥)
			{
				((尾_鳥)item).展開 = 展開;
			}
		}
	}

	public static void 長胴(this Cha Cha, int si, params Func<int, double>[] angs)
	{
		if (angs.Length == 0)
		{
			return;
		}
		int num = 0;
		int num2 = Cha.Bod.長胴n / angs.Length;
		if (num2 == 0)
		{
			num2 = 1;
		}
		double num3 = (double)Cha.Bod.長胴n * 0.1;
		double num4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
		foreach (長胴 item in Cha.Bod.長胴.Skip(1))
		{
			item.角度B = (double)si * angs[(num / num2).Limit(0, angs.Length)](num) / num3 + num4;
			num++;
		}
	}

	public static void 長胴_基本(this Cha Cha)
	{
		Cha.長胴(RNG.XS.NextSign(), (int i) => 4.0.GetRanAngle());
	}

	public static void 魚(this Cha Cha, int s, params Func<int, double>[] angs)
	{
		Par[] array = Cha.Bod.魚.軸列挙().ToArray();
		if (angs.Length != 0)
		{
			int num = 0;
			int num2 = array.Length / angs.Length;
			double num3 = (double)array.Length * 0.1;
			double num4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Par[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].AngleBase = (double)s * angs[(num / num2).Limit(0, angs.Length)](num) / num3 + num4;
				num++;
			}
		}
	}

	public static void 魚_基本(this Cha Cha)
	{
		Cha.魚(RNG.XS.NextSign(), (int i) => 5.0.GetRanAngle());
	}

	public static void 魚_S字(this Cha Cha)
	{
		Cha.魚(RNG.XS.NextSign(), (int i) => 5.0, (int i) => -5.0);
	}

	public static void 魚_波(this Cha Cha)
	{
		Cha.魚(RNG.XS.NextSign(), (int i) => System.Math.Sin(i) * 5.0);
	}

	public static void 魚_ピーン(this Cha Cha)
	{
		Cha.魚(RNG.XS.NextSign(), (int i) => 0.0, (int i) => 5.0.GetRanAngle());
	}

	public static void 魚_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.魚_基本();
			break;
		case 1:
			c.魚_S字();
			break;
		case 2:
			c.魚_波();
			break;
		case 3:
			c.魚_ピーン();
			break;
		}
	}

	public static void 鯨(this Cha Cha, int s, params Func<int, double>[] angs)
	{
		Par[] array = Cha.Bod.鯨.軸列挙().ToArray();
		if (angs.Length != 0)
		{
			int num = 0;
			int num2 = array.Length / angs.Length;
			double num3 = (double)array.Length * 0.1;
			double num4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Par[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].AngleBase = (double)s * angs[(num / num2).Limit(0, angs.Length)](num) / num3 + num4;
				num++;
			}
		}
	}

	public static void 鯨_基本(this Cha Cha)
	{
		Cha.鯨(RNG.XS.NextSign(), (int i) => 5.0.GetRanAngle());
	}

	public static void 鯨_S字(this Cha Cha)
	{
		Cha.鯨(RNG.XS.NextSign(), (int i) => 5.0, (int i) => -5.0);
	}

	public static void 鯨_波(this Cha Cha)
	{
		Cha.鯨(RNG.XS.NextSign(), (int i) => System.Math.Sin(i) * 5.0);
	}

	public static void 鯨_ピーン(this Cha Cha)
	{
		Cha.鯨(RNG.XS.NextSign(), (int i) => 0.0, (int i) => 5.0.GetRanAngle());
	}

	public static void 鯨_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.鯨_基本();
			break;
		case 1:
			c.鯨_S字();
			break;
		case 2:
			c.鯨_波();
			break;
		case 3:
			c.鯨_ピーン();
			break;
		}
	}

	public static void 蠍(this Cha Cha, int s, params Func<int, double>[] angs)
	{
		Par[] array = Cha.Bod.蠍.軸列挙().ToArray();
		if (angs.Length != 0)
		{
			int num = 0;
			int num2 = array.Length / angs.Length;
			double num3 = (double)array.Length * 0.1;
			double num4 = Cha.角度ムラ(RNG.XS.NextSign(), 3.0, RNG.XS.NextSign(), 1.5);
			Par[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].AngleBase = (double)s * angs[(num / num2).Limit(0, angs.Length)](num) / num3 + num4;
				num++;
			}
		}
	}

	public static void 蠍_基本(this Cha Cha)
	{
		Cha.蠍(RNG.XS.NextSign(), (int i) => 5.0.GetRanAngle());
	}

	public static void 蠍_S字(this Cha Cha)
	{
		Cha.蠍(RNG.XS.NextSign(), (int i) => 5.0, (int i) => -5.0);
	}

	public static void 蠍_波(this Cha Cha)
	{
		Cha.蠍(RNG.XS.NextSign(), (int i) => System.Math.Sin(i) * 5.0);
	}

	public static void 蠍_ピーン(this Cha Cha)
	{
		Cha.蠍(RNG.XS.NextSign(), (int i) => 0.0, (int i) => 5.0.GetRanAngle());
	}

	public static void 蠍_0(this Cha c, int i)
	{
		switch (i)
		{
		case 0:
			c.蠍_基本();
			break;
		case 1:
			c.蠍_S字();
			break;
		case 2:
			c.蠍_波();
			break;
		case 3:
			c.蠍_ピーン();
			break;
		}
	}

	public static void 植(this Cha Cha, int si, double 角度)
	{
		Cha.Bod.植.X0Y0_幹下.AngleBase = (double)si * 角度 + Cha.角度ムラ(RNG.XS.NextSign(), 10.0, RNG.XS.NextSign(), 5.0);
	}

	public static void 植_基本(this Cha Cha)
	{
		Cha.植(RNG.XS.NextSign(), 5.0.GetRanAngle());
	}

	public static void 植絶頂(this Cha Cha, double a)
	{
		if (Cha.Bod.植.右)
		{
			Cha.Bod.植.X0Y0_幹下.AngleCont = (0.0 - a) * RNG.XS.NextDouble();
		}
		else
		{
			Cha.Bod.植.X0Y0_幹下.AngleCont = a * RNG.XS.NextDouble();
		}
	}

	public static void 表情_基本0(this Cha c)
	{
		c.両眉_無();
		c.両眉_下();
		c.両瞼_半1();
		c.両瞼_卑();
		c.口_閉笑();
	}

	public static void 表情_基本1(this Cha c)
	{
		c.両眉_無();
		c.両眉_下();
		c.両瞼_半1();
		c.両瞼_卑();
		c.口_薄笑();
	}

	public static void 表情_基本1眉上(this Cha c)
	{
		c.両眉_無();
		c.両眉_上();
		c.両瞼_半1();
		c.両瞼_卑();
		c.口_薄笑();
	}

	public static void 表情_不敵0(this Cha c)
	{
		c.両眉_無();
		c.両眉_下();
		c.両瞼_半2();
		c.両瞼_卑();
		c.口_閉笑();
	}

	public static void 表情_不敵0眉上(this Cha c)
	{
		c.両眉_無();
		c.両眉_上();
		c.両瞼_半2();
		c.両瞼_卑();
		c.口_閉笑();
	}

	public static void 表情_不敵1(this Cha c)
	{
		c.両眉_無();
		c.両眉_下();
		c.両瞼_半2();
		c.両瞼_卑();
		c.口_薄笑();
	}

	public static void 表情_不敵1眉上(this Cha c)
	{
		c.両眉_無();
		c.両眉_上();
		c.両瞼_半2();
		c.両瞼_卑();
		c.口_薄笑();
	}

	public static void 表情_困り顔0(this Cha c)
	{
		c.両眉_顰();
		c.両眉_下();
		c.両瞼_半1();
		c.両瞼_卑();
		c.口_閉笑();
	}

	public static void 表情_困り顔1(this Cha c)
	{
		c.両眉_顰();
		c.両眉_下();
		c.両瞼_半1();
		c.両瞼_卑();
		c.口_薄笑();
	}

	public static void 表情_卑屈(this Cha c)
	{
		c.両眉_顰();
		c.両眉_下();
		c.両瞼_半2();
		c.両瞼_卑();
		c.口_薄笑();
	}

	public static void 表情_素0(this Cha c)
	{
		c.両眉_無();
		c.両眉_下();
		c.両瞼_半2();
		c.両瞼_卑();
		c.口_閉じ();
	}

	public static void 表情_素0眉上(this Cha c)
	{
		c.両眉_無();
		c.両眉_上();
		c.両瞼_半2();
		c.両瞼_卑();
		c.口_閉じ();
	}

	public static void 表情_素1(this Cha c)
	{
		c.両眉_無();
		c.両眉_下();
		c.両瞼_半1();
		c.両瞼_卑();
		c.口_半開1();
	}

	public static void SetInitialExpression(this Cha c)
	{
		c.眉();
		c.目();
		c.瞼();
		c.口();
		c.耳();
		c.顎();
	}

	public static void UpdateExpression(this Cha c)
	{
		switch (RNG.XS.Next(6))
		{
		case 0:
			c.眉();
			break;
		case 1:
			c.目();
			break;
		case 2:
			c.瞼();
			break;
		case 3:
			c.口();
			break;
		case 4:
			c.耳();
			break;
		case 5:
			c.顎();
			break;
		}
	}

	public static void 眉(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		if (c.Bod.Is双眉)
		{
			if (状態 == EmotionType.Acceptance || 状態 == EmotionType.Desire || 状態 == EmotionType.Excitement || 状態 == EmotionType.余裕 || 状態 == EmotionType.Happiness || 状態 == EmotionType.Joy || 状態 == EmotionType.Lewd || 状態 == EmotionType.Other)
			{
				int num = 眉_0感情対応[状態][RNG.XS.Next(眉_0感情対応[状態].Count)];
				c.両眉_0(RNG.XS.NextBool(), num, num switch
				{
					4 => 3, 
					3 => 4, 
					2 => 1, 
					1 => 2, 
					_ => num, 
				});
				num = 眉_1感情対応[状態][RNG.XS.Next(眉_1感情対応[状態].Count)];
				c.両眉_1(num, num);
			}
			else
			{
				c.両眉_0(RNG.XS.NextBool(), 眉_0感情対応[状態][RNG.XS.Next(眉_0感情対応[状態].Count)], 眉_0感情対応[状態][RNG.XS.Next(眉_0感情対応[状態].Count)]);
				c.両眉_1(眉_1感情対応[状態][RNG.XS.Next(眉_1感情対応[状態].Count)], 眉_1感情対応[状態][RNG.XS.Next(眉_1感情対応[状態].Count)]);
			}
		}
		else if (c.Bod.Is単眉)
		{
			c.単眉_0(単眉_0感情対応[状態][RNG.XS.Next(単眉_0感情対応[状態].Count)]);
			c.単眉_1(単眉_1感情対応[状態][RNG.XS.Next(単眉_1感情対応[状態].Count)]);
		}
	}

	public static void 目(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		if (c.Bod.Is双眼 || c.Bod.Is単眼 || c.Bod.Is頬眼 || c.Bod.Is額眼)
		{
			int num = 目_0感情対応[状態][RNG.XS.Next(目_0感情対応[状態].Count)];
			if (c.ChaD.Stamina < 0.3 && c.ChaD.Sensitivity > 0.8 && c.ChaD.Excitement > 0.8 && c.ChaD.Taming > 0.8 && 0.5.Lot())
			{
				num = 3;
			}
			if (c.Bod.Is双眼)
			{
				c.両目_0(num, num);
			}
			else if (c.Bod.Is単眼)
			{
				c.単目_0(num);
			}
			if (c.Bod.Is頬眼)
			{
				c.両頬目_0(num, num);
			}
			if (c.Bod.Is額眼)
			{
				c.額目_0(num);
			}
		}
	}

	public static void 瞼(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		if (c.Bod.Is双眼)
		{
			int num = 瞼_0感情対応[状態][RNG.XS.Next(瞼_0感情対応[状態].Count)];
			c.両瞼_0(num, num);
			int num2 = (c.Bod.目隠帯_表示 ? 3 : 瞼_1感情対応[状態][RNG.XS.Next(瞼_1感情対応[状態].Count)]);
			c.両瞼_1(num2, num2);
		}
		else if (c.Bod.Is単眼)
		{
			c.単瞼_0(単瞼_0感情対応[状態][RNG.XS.Next(単瞼_0感情対応[状態].Count)]);
			c.単瞼_1(c.Bod.目隠帯_表示 ? 3 : 単瞼_1感情対応[状態][RNG.XS.Next(単瞼_1感情対応[状態].Count)]);
		}
		if (c.Bod.Is頬眼)
		{
			int num = 頬瞼_0感情対応[状態][RNG.XS.Next(頬瞼_0感情対応[状態].Count)];
			c.両頬瞼_0(num, num);
			int num2 = (c.Bod.目隠帯_表示 ? 3 : 頬瞼_1感情対応[状態][RNG.XS.Next(頬瞼_1感情対応[状態].Count)]);
			c.両頬瞼_1(num2, num2);
		}
		if (c.Bod.Is額眼)
		{
			c.額瞼_0(額瞼_0感情対応[状態][RNG.XS.Next(額瞼_0感情対応[状態].Count)]);
			c.額瞼_1(c.Bod.目隠帯_表示 ? 3 : 額瞼_1感情対応[状態][RNG.XS.Next(額瞼_1感情対応[状態].Count)]);
		}
	}

	public static void 口(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		if (!Player.UI.Is口挿入 && !c.Bod.玉口枷_表示)
		{
			int num = 口_0感情対応[状態][RNG.XS.Next(口_0感情対応[状態].Count)];
			c.口_0(num);
			num = ((c.Med.Mode == "Training" && Tongue.Contains(num) && c.ChaD.Sesnsitivities[ContactType.Mouth] > 0.6 && c.ChaD.Sensitivity > 0.6 && c.ChaD.Excitement > 0.6 && c.ChaD.Tension < 0.5 && c.ChaD.Pride == 0.0 && c.ChaD.Lust > 0.6 && c.ChaD.Taming > 0.5 && 0.5.Lot()) ? 1 : 0);
			c.舌_0(num);
		}
	}

	public static void 耳(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		if (c.Bod.Is人耳)
		{
			int num = 耳_0感情対応[状態][RNG.XS.Next(耳_0感情対応[状態].Count)];
			c.両耳_0(num, num);
		}
		else if (c.Bod.Is獣耳)
		{
			c.両獣耳_0(獣耳_0感情対応[状態][RNG.XS.Next(獣耳_0感情対応[状態].Count)], 獣耳_0感情対応[状態][RNG.XS.Next(獣耳_0感情対応[状態].Count)]);
		}
	}

	public static void 顎(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		if (c.Bod.虫顎n > 0)
		{
			int num = 虫顎_0感情対応[状態][RNG.XS.Next(虫顎_0感情対応[状態].Count)];
			for (int i = 0; i < c.Bod.虫顎n; i++)
			{
				c.両虫顎_0(i, 同角: true, num, num);
			}
		}
		if (c.Bod.大顎n > 0)
		{
			int num = 大顎_0感情対応[状態][RNG.XS.Next(大顎_0感情対応[状態].Count)];
			if (Player.UI.Is口挿入 || c.Bod.Is拘束)
			{
				num = 1;
			}
			for (int i = 0; i < c.Bod.大顎n; i++)
			{
				c.両大顎_0(i, 同角: true, num, num);
			}
		}
	}

	public static void SetInitialPosture(this Cha c)
	{
		if (Sta.GameData.拘束具)
		{
			c.Set調教拘束姿勢(b: true);
			return;
		}
		c.Bod.腿左右前後 = RNG.XS.NextBool();
		c.腕();
		c.脚();
		c.翼();
		c.鰭();
		c.葉();
		c.翅();
		c.触肢();
		c.節足();
		c.節尾();
		c.虫鎌();
		c.触手();
		c.尾();
		c.半身();
		c.SetSymmetry();
		c.Bod.Update();
	}

	public static void UpdatePosture(this Cha c)
	{
		if (Sta.GameData.拘束具)
		{
			c.Set調教拘束姿勢(0.2.Lot());
			return;
		}
		if (0.35.Lot())
		{
			c.Bod.腿左右前後 = RNG.XS.NextBool();
		}
		switch (RNG.XS.Next(13))
		{
		case 0:
			c.腕();
			break;
		case 1:
			c.脚();
			break;
		case 2:
			c.翼();
			break;
		case 3:
			c.鰭();
			break;
		case 4:
			c.葉();
			break;
		case 5:
			c.翅();
			break;
		case 6:
			c.触肢();
			break;
		case 7:
			c.節足();
			break;
		case 8:
			c.節尾();
			break;
		case 9:
			c.虫鎌();
			break;
		case 10:
			if (0.1.Lot())
			{
				c.触手();
				c.SetSymmetry();
			}
			break;
		case 11:
			c.尾();
			c.SetSymmetry();
			break;
		case 12:
			c.半身();
			break;
		}
		c.Bod.Update();
	}

	public static void 腕(this Cha c)
	{
		if (Player.UI.ペニス処理.手コキ.Run || Player.UI.ペニス処理.Isパイズリ他動)
		{
			return;
		}
		EmotionType 状態 = c.ChaD.Emotion;
		if (c.Bod.腕人n > 0 && !Player.UI.ペニス処理.手固定)
		{
			int[] array = null;
			if (c.ChaD.撮影ピース経験)
			{
				IEnumerable<int> source;
				if (!c.Bod.Is獣 && !c.Is放尿() && !Player.Is性器接触)
				{
					IEnumerable<int> enumerable = 腕人_0感情対応[状態];
					source = enumerable;
				}
				else
				{
					source = 腕人_0感情対応[状態].Where((int e) => e != 8 && e != 9);
				}
				array = source.ToArray();
			}
			else
			{
				IEnumerable<int> source2;
				if (!c.Bod.Is獣 && !c.Is放尿() && !Player.Is性器接触)
				{
					IEnumerable<int> enumerable = 腕人_0感情対応[状態];
					source2 = enumerable;
				}
				else
				{
					source2 = 腕人_0感情対応[状態].Where((int e) => e != 8 && e != 9);
				}
				array = source2.Where((int e) => e != 15).ToArray();
			}
			bool flag = false;
			if (Player.UI.Is口挿入 || (flag = Player.UI.ペニス処理.Is手コキ || Player.UI.ペニス処理.Isパイズリ || Player.UI.ハンド処理.Is乳繰り || Player.UI.ハンド処理.Is乳摘み || Player.UI.ハンド処理.Is乳捏ね || Player.CurrentContactType == ContactType.Milk))
			{
				IEnumerable<int> source3 = array.Where((int e) => e != 4 && e != 5 && e != 6 && e != 10 && e != 11 && e != 12);
				if (flag)
				{
					source3 = source3.Where((int e) => e != 1 && e != 3 && e != 16 && e != 17);
				}
				array = source3.ToArray();
				if (array.Length == 0)
				{
					array = (flag ? new int[5] { 0, 2, 7, 13, 18 } : new int[7] { 0, 1, 2, 3, 7, 13, 18 });
				}
			}
			for (int i = 0; i < c.Bod.腕人n; i++)
			{
				c.両腕人_0(i, RNG.XS.NextBool(), RNG.XS.NextBool(), RNG.XS.NextBool(), array[RNG.XS.Next(array.Length)], array[RNG.XS.Next(array.Length)]);
			}
		}
		if (c.Bod.腕翼鳥n > 0)
		{
			int num = 腕翼鳥_0感情対応[状態][RNG.XS.Next(腕翼鳥_0感情対応[状態].Count)];
			for (int i = 0; i < c.Bod.腕翼鳥n; i++)
			{
				c.両腕翼鳥_0(i, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.腕翼獣n > 0)
		{
			int num = 腕翼獣_0感情対応[状態][RNG.XS.Next(腕翼獣_0感情対応[状態].Count)];
			for (int i = 0; i < c.Bod.腕翼獣n; i++)
			{
				c.両腕翼獣_0(i, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.腕獣n > 0)
		{
			int num = 腕獣_0感情対応[状態][RNG.XS.Next(腕獣_0感情対応[状態].Count)];
			for (int i = 0; i < c.Bod.腕獣n; i++)
			{
				c.両腕獣_0(i, RNG.XS.NextBool(), num, num);
			}
		}
	}

	public static void 脚(this Cha c)
	{
		if (Player.UI.ペニス処理.足コキ.Run)
		{
			return;
		}
		EmotionType 状態 = c.ChaD.Emotion;
		int num = 0;
		if (c.Bod.脚人n > 0 && !Player.UI.ペニス処理.足固定 && !c.Bod.Is粘 && !c.Bod.Is植)
		{
			if (Player.UI.Is脚修正1)
			{
				if (脚人_0感情対応[状態].Any((int e) => e != 1 && e != 2 && e != 4 && e != 5))
				{
					do
					{
						num = 脚人_0感情対応[状態][RNG.XS.Next(脚人_0感情対応[状態].Count)];
					}
					while (num == 1 || num == 2 || num == 4 || num == 5);
				}
				else
				{
					switch (RNG.XS.Next(5))
					{
					case 0:
						num = 0;
						break;
					case 1:
						num = 3;
						break;
					case 2:
						num = 6;
						break;
					case 3:
						num = 7;
						break;
					case 4:
						num = 8;
						break;
					}
				}
			}
			else if (Player.UI.Is脚修正2)
			{
				if (脚人_0感情対応[状態].Any((int e) => e != 1 && e != 2))
				{
					do
					{
						num = 脚人_0感情対応[状態][RNG.XS.Next(脚人_0感情対応[状態].Count)];
					}
					while (num == 1 || num == 2);
				}
				else
				{
					switch (RNG.XS.Next(7))
					{
					case 0:
						num = 0;
						break;
					case 1:
						num = 3;
						break;
					case 2:
						num = 4;
						break;
					case 3:
						num = 5;
						break;
					case 4:
						num = 6;
						break;
					case 5:
						num = 7;
						break;
					case 6:
						num = 8;
						break;
					}
				}
			}
			else
			{
				num = 脚人_0感情対応[状態][RNG.XS.Next(脚人_0感情対応[状態].Count)];
			}
			for (int i = 0; i < c.Bod.脚人n; i++)
			{
				c.両脚人_0(0, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.脚獣n > 0)
		{
			num = 脚獣_0感情対応[状態][RNG.XS.Next(脚獣_0感情対応[状態].Count)];
			for (int i = 0; i < c.Bod.脚獣n; i++)
			{
				c.両脚獣_0(i, RNG.XS.NextBool(), num, num);
			}
		}
	}

	public static void 翼(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		if (c.Bod.翼鳥n > 0)
		{
			int num = 翼_0感情対応[状態][RNG.XS.Next(翼_0感情対応[状態].Count)];
			for (int i = 0; i < c.Bod.翼鳥n; i++)
			{
				c.両翼鳥_0(i, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.翼獣n > 0)
		{
			int num2 = 翼_0感情対応[状態][RNG.XS.Next(翼_0感情対応[状態].Count)];
			for (int j = 0; j < c.Bod.翼獣n; j++)
			{
				c.両翼獣_0(j, RNG.XS.NextBool(), num2, num2);
			}
		}
	}

	public static void 鰭(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		if (c.Bod.鰭n > 0)
		{
			int num = 鰭_0感情対応[状態][RNG.XS.Next(鰭_0感情対応[状態].Count)];
			for (int i = 0; i < c.Bod.鰭n; i++)
			{
				c.両鰭_0(i, RNG.XS.NextBool(), num, num);
			}
		}
	}

	public static void 葉(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		if (c.Bod.葉n > 0)
		{
			int num = 葉_0感情対応[状態][RNG.XS.Next(葉_0感情対応[状態].Count)];
			for (int i = 0; i < c.Bod.葉n; i++)
			{
				c.両葉_0(i, RNG.XS.NextBool(), num, num);
			}
		}
	}

	public static void 翅(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		int num;
		if (c.Bod.前翅1n > 0 || c.Bod.後翅1n > 0)
		{
			num = 前翅_0感情対応[状態][RNG.XS.Next(前翅_0感情対応[状態].Count)];
			if (c.Bod.前翅1n > 0)
			{
				for (int i = 0; i < c.Bod.前翅1n; i++)
				{
					c.両前翅_0(i, 同角: true, num, num);
				}
			}
			if (c.Bod.後翅1n > 0)
			{
				for (int i = 0; i < c.Bod.後翅1n; i++)
				{
					c.両後翅_0(i, 同角: true, num, num);
				}
			}
		}
		if (c.Bod.前翅2n <= 0 && c.Bod.後翅2n <= 0)
		{
			return;
		}
		num = 前翅_1感情対応[状態][RNG.XS.Next(前翅_1感情対応[状態].Count)];
		if (c.Bod.前翅2n > 0)
		{
			for (int i = 0; i < c.Bod.前翅2n; i++)
			{
				c.両前翅_1(i, num, num);
			}
		}
		if (c.Bod.後翅2n > 0)
		{
			for (int i = 0; i < c.Bod.後翅2n; i++)
			{
				c.両後翅_1(i, num, num);
			}
		}
	}

	public static void 触肢(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		if (c.Bod.触肢蜘n > 0)
		{
			int num = 触肢蜘_0感情対応[状態][RNG.XS.Next(触肢蜘_0感情対応[状態].Count)];
			for (int i = 0; i < c.Bod.触肢蜘n; i++)
			{
				c.両触肢蜘_0(i, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.触肢蠍n > 0)
		{
			int num = 触肢蠍_0感情対応[状態][RNG.XS.Next(触肢蠍_0感情対応[状態].Count)];
			for (int i = 0; i < c.Bod.触肢蠍n; i++)
			{
				c.両触肢蠍_0(i, RNG.XS.NextBool(), num, num);
			}
		}
	}

	public static void 節足(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		if (c.Bod.節足蜘n > 0)
		{
			int num = 節足蜘_0感情対応[状態][RNG.XS.Next(節足蜘_0感情対応[状態].Count)];
			for (int i = 0; i < c.Bod.節足蜘n; i++)
			{
				c.両節足蜘_0(i, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.節足蠍n > 0)
		{
			int num = 節足蠍_0感情対応[状態][RNG.XS.Next(節足蠍_0感情対応[状態].Count)];
			for (int i = 0; i < c.Bod.節足蠍n; i++)
			{
				c.両節足蠍_0(i, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.節足百n > 0)
		{
			int num = 節足百_0感情対応[状態][RNG.XS.Next(節足百_0感情対応[状態].Count)];
			for (int i = 0; i < c.Bod.節足百n; i++)
			{
				c.両節足百_0(i, RNG.XS.NextBool(), num, num);
			}
		}
	}

	public static void 節尾(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		if (c.Bod.節尾曳n > 0)
		{
			int num = 節尾曳_0感情対応[状態][RNG.XS.Next(節尾曳_0感情対応[状態].Count)];
			for (int i = 0; i < c.Bod.節尾曳n; i++)
			{
				c.両節尾曳_0(i, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.節尾鋏n > 0)
		{
			int num = 節尾鋏_0感情対応[状態][RNG.XS.Next(節尾鋏_0感情対応[状態].Count)];
			for (int i = 0; i < c.Bod.節尾鋏n; i++)
			{
				c.両節尾鋏_0(i, RNG.XS.NextBool(), num, num);
			}
		}
	}

	public static void 虫鎌(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		if (c.Bod.虫鎌n > 0)
		{
			int num = 虫鎌_0感情対応[状態][RNG.XS.Next(虫鎌_0感情対応[状態].Count)];
			for (int i = 0; i < c.Bod.虫鎌n; i++)
			{
				c.両虫鎌_0(i, RNG.XS.NextBool(), num, num);
			}
		}
	}

	public static void 触手(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		if (c.Bod.触手n > 0)
		{
			for (int i = 0; i < c.Bod.触手n; i++)
			{
				c.両触手_0(i, 触手_0感情対応[状態][RNG.XS.Next(触手_0感情対応[状態].Count)]);
			}
		}
		if (c.Bod.触手犬n > 0)
		{
			for (int i = 0; i < c.Bod.触手犬n; i++)
			{
				c.両触手犬_0(i, 触手犬_0感情対応[状態][RNG.XS.Next(触手犬_0感情対応[状態].Count)]);
			}
		}
	}

	public static void 尾(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		if (c.Bod.尾n > 0)
		{
			int i = 尾_0感情対応[状態][RNG.XS.Next(尾_0感情対応[状態].Count)];
			int num = 0;
			for (num = 0; num < c.Bod.尾n; num++)
			{
				c.尾_0(num, i);
			}
		}
	}

	public static void 半身(this Cha c)
	{
		EmotionType 状態 = c.ChaD.Emotion;
		if (c.Bod.長胴n > 0)
		{
			c.長胴_基本();
		}
		if (c.Bod.Is魚)
		{
			c.魚_0(魚_0感情対応[状態][RNG.XS.Next(魚_0感情対応[状態].Count)]);
		}
		if (c.Bod.Is鯨)
		{
			c.鯨_0(鯨_0感情対応[状態][RNG.XS.Next(鯨_0感情対応[状態].Count)]);
		}
		if (c.Bod.Is蠍)
		{
			c.蠍_0(蠍_0感情対応[状態][RNG.XS.Next(蠍_0感情対応[状態].Count)]);
		}
		if (c.Bod.Is植)
		{
			c.植_基本();
		}
		if (c.Bod.Is粘)
		{
			c.Bod.粘.尺度C = 0.9 + 0.1 * RNG.XS.NextDouble();
		}
	}

	public static void Set基本姿勢(this Cha c)
	{
		if (0.35.Lot())
		{
			c.Bod.腿左右前後 = RNG.XS.NextBool();
		}
		if (c.Bod.腕人n > 0)
		{
			int num = 7;
			for (int i = 0; i < c.Bod.腕人n; i++)
			{
				c.両腕人_0(i, RNG.XS.NextBool(), 同角: true, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.腕翼鳥n > 0)
		{
			int num = 腕翼鳥_0基本[RNG.XS.Next(腕翼鳥_0基本.Length)];
			for (int j = 0; j < c.Bod.腕翼鳥n; j++)
			{
				c.両腕翼鳥_0(j, 同角: true, num, num);
			}
		}
		if (c.Bod.腕翼獣n > 0)
		{
			int num = 腕翼獣_0基本[RNG.XS.Next(腕翼獣_0基本.Length)];
			for (int k = 0; k < c.Bod.腕翼獣n; k++)
			{
				c.両腕翼獣_0(k, 同角: true, num, num);
			}
		}
		if (c.Bod.腕獣n > 0)
		{
			int num = 腕獣_0基本[RNG.XS.Next(腕獣_0基本.Length)];
			for (int l = 0; l < c.Bod.腕獣n; l++)
			{
				c.両腕獣_0(l, 同角: true, num, num);
			}
		}
		if (!c.Bod.Is粘 && !c.Bod.Is植 && c.Bod.脚人n > 0)
		{
			for (int m = 0; m < c.Bod.脚人n; m++)
			{
				c.両脚人_0(0, 同角: true, 脚人_0基本[RNG.XS.Next(脚人_0基本.Length)], 脚人_0基本[RNG.XS.Next(脚人_0基本.Length)]);
			}
		}
		if (c.Bod.脚獣n > 0)
		{
			int num = 脚獣_0基本[RNG.XS.Next(脚獣_0基本.Length)];
			for (int n = 0; n < c.Bod.脚獣n; n++)
			{
				c.両脚獣_0(n, 同角: true, num, num);
			}
		}
		if (c.Bod.翼鳥n > 0)
		{
			int num = 翼_0基本[RNG.XS.Next(翼_0基本.Length)];
			for (int num2 = 0; num2 < c.Bod.翼鳥n; num2++)
			{
				c.両翼鳥_0(num2, 同角: true, num, num);
			}
		}
		if (c.Bod.翼獣n > 0)
		{
			int num = 翼_0基本[RNG.XS.Next(翼_0基本.Length)];
			for (int num3 = 0; num3 < c.Bod.翼獣n; num3++)
			{
				c.両翼獣_0(num3, 同角: true, num, num);
			}
		}
		if (c.Bod.鰭n > 0)
		{
			int num = 鰭_0基本[RNG.XS.Next(鰭_0基本.Length)];
			for (int num4 = 0; num4 < c.Bod.鰭n; num4++)
			{
				c.両鰭_0(num4, 同角: true, num, num);
			}
		}
		if (c.Bod.葉n > 0)
		{
			int num = 葉_0基本[RNG.XS.Next(葉_0基本.Length)];
			for (int num5 = 0; num5 < c.Bod.葉n; num5++)
			{
				c.両葉_0(num5, 同角: true, num, num);
			}
		}
		if (c.Bod.前翅1n > 0 || c.Bod.後翅1n > 0)
		{
			int num = 前翅_0基本[RNG.XS.Next(前翅_0基本.Length)];
			if (c.Bod.前翅1n > 0)
			{
				for (int num6 = 0; num6 < c.Bod.前翅1n; num6++)
				{
					c.両前翅_0(num6, 同角: true, num, num);
				}
			}
			if (c.Bod.後翅1n > 0)
			{
				for (int num7 = 0; num7 < c.Bod.後翅1n; num7++)
				{
					c.両後翅_0(num7, 同角: true, num, num);
				}
			}
		}
		if (c.Bod.前翅2n > 0 || c.Bod.後翅2n > 0)
		{
			int num8 = 前翅_1基本[RNG.XS.Next(前翅_1基本.Length)];
			if (c.Bod.前翅2n > 0)
			{
				for (int num9 = 0; num9 < c.Bod.前翅2n; num9++)
				{
					c.両前翅_1(num9, num8, num8);
				}
			}
			if (c.Bod.後翅2n > 0)
			{
				for (int num10 = 0; num10 < c.Bod.後翅2n; num10++)
				{
					c.両後翅_1(num10, num8, num8);
				}
			}
		}
		if (c.Bod.触肢蜘n > 0)
		{
			int num = 触肢蜘_0基本[RNG.XS.Next(触肢蜘_0基本.Length)];
			for (int num11 = 0; num11 < c.Bod.触肢蜘n; num11++)
			{
				c.両触肢蜘_0(num11, 同角: true, num, num);
			}
		}
		if (c.Bod.触肢蠍n > 0)
		{
			int num = 触肢蠍_0基本[RNG.XS.Next(触肢蠍_0基本.Length)];
			for (int num12 = 0; num12 < c.Bod.触肢蠍n; num12++)
			{
				c.両触肢蠍_0(num12, 同角: true, num, num);
			}
		}
		if (c.Bod.節足蜘n > 0)
		{
			int num = 節足蜘_0基本[RNG.XS.Next(節足蜘_0基本.Length)];
			for (int num13 = 0; num13 < c.Bod.節足蜘n; num13++)
			{
				c.両節足蜘_0(num13, 同角: true, num, num);
			}
		}
		if (c.Bod.節足蠍n > 0)
		{
			int num = 節足蠍_0基本[RNG.XS.Next(節足蠍_0基本.Length)];
			for (int num14 = 0; num14 < c.Bod.節足蠍n; num14++)
			{
				c.両節足蠍_0(num14, 同角: true, num, num);
			}
		}
		if (c.Bod.節足百n > 0)
		{
			int num = 節足百_0基本[RNG.XS.Next(節足百_0基本.Length)];
			for (int num15 = 0; num15 < c.Bod.節足百n; num15++)
			{
				c.両節足百_0(num15, 同角: true, num, num);
			}
		}
		if (c.Bod.節尾曳n > 0)
		{
			int num = 節尾曳_0基本[RNG.XS.Next(節尾曳_0基本.Length)];
			for (int num16 = 0; num16 < c.Bod.節尾曳n; num16++)
			{
				c.両節尾曳_0(num16, 同角: true, num, num);
			}
		}
		if (c.Bod.節尾鋏n > 0)
		{
			int num = 節尾鋏_0基本[RNG.XS.Next(節尾鋏_0基本.Length)];
			for (int num17 = 0; num17 < c.Bod.節尾鋏n; num17++)
			{
				c.両節尾鋏_0(num17, 同角: true, num, num);
			}
		}
		if (c.Bod.虫鎌n > 0)
		{
			int num = 虫鎌_0基本[RNG.XS.Next(虫鎌_0基本.Length)];
			for (int num18 = 0; num18 < c.Bod.虫鎌n; num18++)
			{
				c.両虫鎌_0(num18, 同角: true, num, num);
			}
		}
		if (c.Bod.触手n > 0)
		{
			for (int num19 = 0; num19 < c.Bod.触手n; num19++)
			{
				c.両触手_0(num19, 触手_0基本[RNG.XS.Next(触手_0基本.Length)]);
			}
		}
		if (c.Bod.触手犬n > 0)
		{
			for (int num20 = 0; num20 < c.Bod.触手犬n; num20++)
			{
				c.両触手犬_0(num20, 触手犬_0基本[RNG.XS.Next(触手犬_0基本.Length)]);
			}
		}
		if (c.Bod.尾n > 0)
		{
			int num = 尾_0基本[RNG.XS.Next(尾_0基本.Length)];
			for (int num21 = 0; num21 < c.Bod.尾n; num21++)
			{
				c.尾_0(num21, num);
			}
		}
		if (c.Bod.触手n > 0 || c.Bod.触手犬n > 0 || c.Bod.尾n > 0)
		{
			c.SetSymmetry();
		}
		if (c.Bod.長胴n > 0)
		{
			c.長胴_基本();
		}
		if (c.Bod.Is魚)
		{
			c.魚_0(魚_0基本[RNG.XS.Next(魚_0基本.Length)]);
		}
		if (c.Bod.Is鯨)
		{
			c.鯨_0(鯨_0基本[RNG.XS.Next(鯨_0基本.Length)]);
		}
		if (c.Bod.Is蠍)
		{
			c.蠍_0(蠍_0基本[RNG.XS.Next(蠍_0基本.Length)]);
		}
		if (c.Bod.Is植)
		{
			c.植_基本();
		}
		if (c.Bod.Is粘)
		{
			c.Bod.粘.尺度C = 0.9 + 0.1 * RNG.XS.NextDouble();
		}
		c.Bod.Update();
	}

	public static void Set拘束姿勢(this Cha c)
	{
		if (0.35.Lot())
		{
			c.Bod.腿左右前後 = RNG.XS.NextBool();
		}
		if (c.Bod.腕人n > 0)
		{
			int num = 7;
			for (int i = 0; i < c.Bod.腕人n; i++)
			{
				c.両腕人_0(i, RNG.XS.NextBool(), 同角: true, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.腕翼鳥n > 0)
		{
			int num = 4;
			for (int j = 0; j < c.Bod.腕翼鳥n; j++)
			{
				c.両腕翼鳥_0(j, 同角: true, num, num);
			}
		}
		if (c.Bod.腕翼獣n > 0)
		{
			int num = 2;
			for (int k = 0; k < c.Bod.腕翼獣n; k++)
			{
				c.両腕翼獣_0(k, 同角: true, num, num);
			}
		}
		if (c.Bod.腕獣n > 0)
		{
			int num = 腕獣_0基本[RNG.XS.Next(腕獣_0基本.Length)];
			for (int l = 0; l < c.Bod.腕獣n; l++)
			{
				c.両腕獣_0(l, 同角: true, num, num);
			}
		}
		if (!c.Bod.Is粘 && !c.Bod.Is植 && c.Bod.脚人n > 0)
		{
			for (int m = 0; m < c.Bod.脚人n; m++)
			{
				c.両脚人_0(0, 同角: true, 脚人_0基本[RNG.XS.Next(脚人_0基本.Length)], 脚人_0基本[RNG.XS.Next(脚人_0基本.Length)]);
			}
		}
		if (c.Bod.脚獣n > 0)
		{
			int num = 脚獣_0基本[RNG.XS.Next(脚獣_0基本.Length)];
			for (int n = 0; n < c.Bod.脚獣n; n++)
			{
				c.両脚獣_0(n, 同角: true, num, num);
			}
		}
		if (c.Bod.翼鳥n > 0)
		{
			int num = 4;
			for (int num2 = 0; num2 < c.Bod.翼鳥n; num2++)
			{
				c.両翼鳥_0(num2, 同角: true, num, num);
			}
		}
		if (c.Bod.翼獣n > 0)
		{
			int num = 4;
			for (int num3 = 0; num3 < c.Bod.翼獣n; num3++)
			{
				c.両翼獣_0(num3, 同角: true, num, num);
			}
		}
		if (c.Bod.鰭n > 0)
		{
			int num = 鰭_0基本[RNG.XS.Next(鰭_0基本.Length)];
			for (int num4 = 0; num4 < c.Bod.鰭n; num4++)
			{
				c.両鰭_0(num4, 同角: true, num, num);
			}
		}
		if (c.Bod.葉n > 0)
		{
			int num = 葉_0基本[RNG.XS.Next(葉_0基本.Length)];
			for (int num5 = 0; num5 < c.Bod.葉n; num5++)
			{
				c.両葉_0(num5, 同角: true, num, num);
			}
		}
		if (c.Bod.前翅1n > 0 || c.Bod.後翅1n > 0)
		{
			int num = 前翅_0基本[RNG.XS.Next(前翅_0基本.Length)];
			if (c.Bod.前翅1n > 0)
			{
				for (int num6 = 0; num6 < c.Bod.前翅1n; num6++)
				{
					c.両前翅_0(num6, 同角: true, num, num);
				}
			}
			if (c.Bod.後翅1n > 0)
			{
				for (int num7 = 0; num7 < c.Bod.後翅1n; num7++)
				{
					c.両後翅_0(num7, 同角: true, num, num);
				}
			}
		}
		if (c.Bod.前翅2n > 0 || c.Bod.後翅2n > 0)
		{
			int num8 = 0;
			if (c.Bod.前翅2n > 0)
			{
				for (int num9 = 0; num9 < c.Bod.前翅2n; num9++)
				{
					c.両前翅_1(num9, num8, num8);
				}
			}
			if (c.Bod.後翅2n > 0)
			{
				for (int num10 = 0; num10 < c.Bod.後翅2n; num10++)
				{
					c.両後翅_1(num10, num8, num8);
				}
			}
		}
		if (c.Bod.触肢蜘n > 0)
		{
			int num = 触肢蜘_0拘束[RNG.XS.Next(触肢蜘_0拘束.Length)];
			for (int num11 = 0; num11 < c.Bod.触肢蜘n; num11++)
			{
				c.両触肢蜘_0(num11, 同角: true, num, num);
			}
		}
		if (c.Bod.触肢蠍n > 0)
		{
			int num = 触肢蠍_0拘束[RNG.XS.Next(触肢蠍_0拘束.Length)];
			for (int num12 = 0; num12 < c.Bod.触肢蠍n; num12++)
			{
				c.両触肢蠍_0(num12, 同角: true, num, num);
			}
		}
		if (c.Bod.節足蜘n > 0)
		{
			int num = 節足蜘_0基本[RNG.XS.Next(節足蜘_0基本.Length)];
			for (int num13 = 0; num13 < c.Bod.節足蜘n; num13++)
			{
				c.両節足蜘_0(num13, 同角: true, num, num);
			}
		}
		if (c.Bod.節足蠍n > 0)
		{
			int num = 節足蠍_0基本[RNG.XS.Next(節足蠍_0基本.Length)];
			for (int num14 = 0; num14 < c.Bod.節足蠍n; num14++)
			{
				c.両節足蠍_0(num14, 同角: true, num, num);
			}
		}
		if (c.Bod.節足百n > 0)
		{
			int num = 節足百_0基本[RNG.XS.Next(節足百_0基本.Length)];
			for (int num15 = 0; num15 < c.Bod.節足百n; num15++)
			{
				c.両節足百_0(num15, 同角: true, num, num);
			}
		}
		if (c.Bod.節尾曳n > 0)
		{
			int num = 節尾曳_0基本[RNG.XS.Next(節尾曳_0基本.Length)];
			for (int num16 = 0; num16 < c.Bod.節尾曳n; num16++)
			{
				c.両節尾曳_0(num16, 同角: true, num, num);
			}
		}
		if (c.Bod.節尾鋏n > 0)
		{
			int num = 節尾鋏_0基本[RNG.XS.Next(節尾鋏_0基本.Length)];
			for (int num17 = 0; num17 < c.Bod.節尾鋏n; num17++)
			{
				c.両節尾鋏_0(num17, 同角: true, num, num);
			}
		}
		if (c.Bod.虫鎌n > 0)
		{
			int num = 0;
			for (int num18 = 0; num18 < c.Bod.虫鎌n; num18++)
			{
				c.両虫鎌_0(num18, 同角: true, num, num);
			}
		}
		if (c.Bod.触手n > 0)
		{
			for (int num19 = 0; num19 < c.Bod.触手n; num19++)
			{
				c.両触手_0(num19, 触手_0基本[RNG.XS.Next(触手_0基本.Length)]);
			}
		}
		if (c.Bod.触手犬n > 0)
		{
			for (int num20 = 0; num20 < c.Bod.触手犬n; num20++)
			{
				c.両触手犬_0(num20, 触手犬_0基本[RNG.XS.Next(触手犬_0基本.Length)]);
			}
		}
		if (c.Bod.尾n > 0)
		{
			int num = 尾_0基本[RNG.XS.Next(尾_0基本.Length)];
			for (int num21 = 0; num21 < c.Bod.尾n; num21++)
			{
				c.尾_0(num21, num);
			}
		}
		if (c.Bod.触手n > 0 || c.Bod.触手犬n > 0 || c.Bod.尾n > 0)
		{
			c.SetSymmetry();
		}
		if (c.Bod.長胴n > 0)
		{
			c.長胴_基本();
		}
		if (c.Bod.Is魚)
		{
			c.魚_0(魚_0基本[RNG.XS.Next(魚_0基本.Length)]);
		}
		if (c.Bod.Is鯨)
		{
			c.鯨_0(鯨_0基本[RNG.XS.Next(鯨_0基本.Length)]);
		}
		if (c.Bod.Is蠍)
		{
			c.蠍_0(蠍_0基本[RNG.XS.Next(蠍_0基本.Length)]);
		}
		if (c.Bod.Is植)
		{
			c.植_基本();
		}
		if (c.Bod.Is粘)
		{
			c.Bod.粘.尺度C = 0.9 + 0.1 * RNG.XS.NextDouble();
		}
		c.Bod.Update();
	}

	public static void Set調教拘束姿勢(this Cha c, bool b)
	{
		if (0.35.Lot())
		{
			c.Bod.腿左右前後 = RNG.XS.NextBool();
		}
		if (c.Bod.腕人n > 0)
		{
			int num = 18;
			for (int i = 0; i < c.Bod.腕人n; i++)
			{
				c.両腕人_0(i, RNG.XS.NextBool(), RNG.XS.NextBool(), RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.腕翼鳥n > 0)
		{
			int num = 4;
			for (int j = 0; j < c.Bod.腕翼鳥n; j++)
			{
				c.両腕翼鳥_0(j, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.腕翼獣n > 0)
		{
			int num = 2;
			for (int k = 0; k < c.Bod.腕翼獣n; k++)
			{
				c.両腕翼獣_0(k, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.腕獣n > 0)
		{
			int num = 0;
			for (int l = 0; l < c.Bod.腕獣n; l++)
			{
				c.両腕獣_0(l, RNG.XS.NextBool(), num, num);
			}
		}
		if (!c.Bod.Is粘 && !c.Bod.Is植 && c.Bod.脚人n > 0)
		{
			int num = 8;
			for (int m = 0; m < c.Bod.脚人n; m++)
			{
				c.両脚人_0(0, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.脚獣n > 0)
		{
			int num = 0;
			for (int n = 0; n < c.Bod.脚獣n; n++)
			{
				c.両脚獣_0(n, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.翼鳥n > 0)
		{
			int num = 4;
			for (int num2 = 0; num2 < c.Bod.翼鳥n; num2++)
			{
				c.両翼鳥_0(num2, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.翼獣n > 0)
		{
			int num = 4;
			for (int num3 = 0; num3 < c.Bod.翼獣n; num3++)
			{
				c.両翼獣_0(num3, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.鰭n > 0)
		{
			int num = 鰭_0基本[RNG.XS.Next(鰭_0基本.Length)];
			for (int num4 = 0; num4 < c.Bod.鰭n; num4++)
			{
				c.両鰭_0(num4, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.葉n > 0)
		{
			int num = 葉_0基本[RNG.XS.Next(葉_0基本.Length)];
			for (int num5 = 0; num5 < c.Bod.葉n; num5++)
			{
				c.両葉_0(num5, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.前翅1n > 0 || c.Bod.後翅1n > 0)
		{
			int num = 前翅_0基本[RNG.XS.Next(前翅_0基本.Length)];
			if (c.Bod.前翅1n > 0)
			{
				for (int num6 = 0; num6 < c.Bod.前翅1n; num6++)
				{
					c.両前翅_0(num6, 同角: true, num, num);
				}
			}
			if (c.Bod.後翅1n > 0)
			{
				for (int num7 = 0; num7 < c.Bod.後翅1n; num7++)
				{
					c.両後翅_0(num7, 同角: true, num, num);
				}
			}
		}
		if (c.Bod.前翅2n > 0 || c.Bod.後翅2n > 0)
		{
			int num8 = 0;
			if (c.Bod.前翅2n > 0)
			{
				for (int num9 = 0; num9 < c.Bod.前翅2n; num9++)
				{
					c.両前翅_1(num9, num8, num8);
				}
			}
			if (c.Bod.後翅2n > 0)
			{
				for (int num10 = 0; num10 < c.Bod.後翅2n; num10++)
				{
					c.両後翅_1(num10, num8, num8);
				}
			}
		}
		if (c.Bod.触肢蜘n > 0)
		{
			int num = 0;
			for (int num11 = 0; num11 < c.Bod.触肢蜘n; num11++)
			{
				c.両触肢蜘_0(num11, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.触肢蠍n > 0)
		{
			int num = 0;
			for (int num12 = 0; num12 < c.Bod.触肢蠍n; num12++)
			{
				c.両触肢蠍_0(num12, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.節足蜘n > 0)
		{
			int num = 0;
			for (int num13 = 0; num13 < c.Bod.節足蜘n; num13++)
			{
				c.両節足蜘_0(num13, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.節足蠍n > 0)
		{
			int num = 0;
			for (int num14 = 0; num14 < c.Bod.節足蠍n; num14++)
			{
				c.両節足蠍_0(num14, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.節足百n > 0)
		{
			int num = 0;
			for (int num15 = 0; num15 < c.Bod.節足百n; num15++)
			{
				c.両節足百_0(num15, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.節尾曳n > 0)
		{
			int num = 0;
			for (int num16 = 0; num16 < c.Bod.節尾曳n; num16++)
			{
				c.両節尾曳_0(num16, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.節尾鋏n > 0)
		{
			int num = 0;
			for (int num17 = 0; num17 < c.Bod.節尾鋏n; num17++)
			{
				c.両節尾鋏_0(num17, RNG.XS.NextBool(), num, num);
			}
		}
		if (c.Bod.虫鎌n > 0)
		{
			int num = 0;
			for (int num18 = 0; num18 < c.Bod.虫鎌n; num18++)
			{
				c.両虫鎌_0(num18, RNG.XS.NextBool(), num, num);
			}
		}
		if (b)
		{
			_ = c.Bod.触手n;
			_ = 0;
			if (c.Bod.触手犬n > 0)
			{
				for (int num19 = 0; num19 < c.Bod.触手犬n; num19++)
				{
					c.両触手犬_0(num19, 触手犬_0基本[RNG.XS.Next(触手犬_0基本.Length)]);
				}
			}
			if (c.Bod.尾n > 0)
			{
				int num = 尾_0基本[RNG.XS.Next(尾_0基本.Length)];
				for (int num20 = 0; num20 < c.Bod.尾n; num20++)
				{
					c.尾_0(num20, num);
				}
			}
		}
		if ((b && (c.Bod.触手n > 0 || c.Bod.触手犬n > 0)) || c.Bod.尾n > 0)
		{
			c.SetSymmetry();
		}
		if (c.Bod.Is魚)
		{
			c.魚_0(魚_0基本[RNG.XS.Next(魚_0基本.Length)]);
		}
		if (c.Bod.Is鯨)
		{
			c.鯨_0(鯨_0基本[RNG.XS.Next(鯨_0基本.Length)]);
		}
		if (c.Bod.Is蠍)
		{
			c.蠍_0(蠍_0基本[RNG.XS.Next(蠍_0基本.Length)]);
		}
		if (c.Bod.Is植)
		{
			c.植_基本();
		}
		c.Bod.Update();
	}

	public static void Setダブルピース(this Cha c)
	{
		if (c.Bod.腕人n > 0)
		{
			int num = 15;
			for (int i = 0; i < c.Bod.腕人n; i++)
			{
				c.両腕人_0(i, RNG.XS.NextBool(), RNG.XS.NextBool(), RNG.XS.NextBool(), num, num);
			}
		}
	}
}
