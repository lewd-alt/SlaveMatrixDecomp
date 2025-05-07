using System.Linq;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class 四足腰 : Ele
    {
    	public Par X0Y0_腰;

    	public Par X0Y0_股;

    	public Par X0Y0_下腹;

    	public Par X0Y0_腰皺;

    	public Par X0Y0_筋肉_筋肉下;

    	public Par X0Y0_筋肉_筋肉左;

    	public Par X0Y0_筋肉_筋肉右;

    	public Par X0Y0_筋肉_筋上左;

    	public Par X0Y0_筋肉_筋上右;

    	public Par X0Y0_筋肉_筋下左;

    	public Par X0Y0_筋肉_筋下右;

    	public Par X0Y0_臍;

    	public Par X0Y0_紋柄_紋左_紋1;

    	public Par X0Y0_紋柄_紋左_紋2;

    	public Par X0Y0_紋柄_紋左_紋3;

    	public Par X0Y0_紋柄_紋右_紋1;

    	public Par X0Y0_紋柄_紋右_紋2;

    	public Par X0Y0_紋柄_紋右_紋3;

    	public Par X0Y0_虎柄_虎左;

    	public Par X0Y0_虎柄_虎右;

    	public Par X0Y0_竜性_中_鱗1;

    	public Par X0Y0_竜性_中_鱗2;

    	public Par X0Y0_竜性_中_鱗3;

    	public Par X0Y0_竜性_中_鱗4;

    	public Par X0Y0_竜性_左_鱗1;

    	public Par X0Y0_竜性_左_鱗2;

    	public Par X0Y0_竜性_右_鱗1;

    	public Par X0Y0_竜性_右_鱗2;

    	public Par X0Y1_腰;

    	public Par X0Y1_股;

    	public Par X0Y1_下腹;

    	public Par X0Y1_腰皺;

    	public Par X0Y1_筋肉_筋肉下;

    	public Par X0Y1_筋肉_筋肉左;

    	public Par X0Y1_筋肉_筋肉右;

    	public Par X0Y1_筋肉_筋上左;

    	public Par X0Y1_筋肉_筋上右;

    	public Par X0Y1_筋肉_筋下左;

    	public Par X0Y1_筋肉_筋下右;

    	public Par X0Y1_臍;

    	public Par X0Y1_紋柄_紋左_紋1;

    	public Par X0Y1_紋柄_紋左_紋2;

    	public Par X0Y1_紋柄_紋左_紋3;

    	public Par X0Y1_紋柄_紋右_紋1;

    	public Par X0Y1_紋柄_紋右_紋2;

    	public Par X0Y1_紋柄_紋右_紋3;

    	public Par X0Y1_虎柄_虎左;

    	public Par X0Y1_虎柄_虎右;

    	public Par X0Y1_竜性_中_鱗1;

    	public Par X0Y1_竜性_中_鱗2;

    	public Par X0Y1_竜性_中_鱗3;

    	public Par X0Y1_竜性_中_鱗4;

    	public Par X0Y1_竜性_左_鱗1;

    	public Par X0Y1_竜性_左_鱗2;

    	public Par X0Y1_竜性_右_鱗1;

    	public Par X0Y1_竜性_右_鱗2;

    	public Par X0Y2_腰;

    	public Par X0Y2_股;

    	public Par X0Y2_下腹;

    	public Par X0Y2_腰皺;

    	public Par X0Y2_筋肉_筋肉下;

    	public Par X0Y2_筋肉_筋肉左;

    	public Par X0Y2_筋肉_筋肉右;

    	public Par X0Y2_筋肉_筋上左;

    	public Par X0Y2_筋肉_筋上右;

    	public Par X0Y2_筋肉_筋下左;

    	public Par X0Y2_筋肉_筋下右;

    	public Par X0Y2_臍;

    	public Par X0Y2_紋柄_紋左_紋1;

    	public Par X0Y2_紋柄_紋左_紋2;

    	public Par X0Y2_紋柄_紋左_紋3;

    	public Par X0Y2_紋柄_紋右_紋1;

    	public Par X0Y2_紋柄_紋右_紋2;

    	public Par X0Y2_紋柄_紋右_紋3;

    	public Par X0Y2_虎柄_虎左;

    	public Par X0Y2_虎柄_虎右;

    	public Par X0Y2_竜性_中_鱗1;

    	public Par X0Y2_竜性_中_鱗2;

    	public Par X0Y2_竜性_中_鱗3;

    	public Par X0Y2_竜性_中_鱗4;

    	public Par X0Y2_竜性_左_鱗1;

    	public Par X0Y2_竜性_左_鱗2;

    	public Par X0Y2_竜性_右_鱗1;

    	public Par X0Y2_竜性_右_鱗2;

    	public Par X0Y3_腰;

    	public Par X0Y3_股;

    	public Par X0Y3_下腹;

    	public Par X0Y3_腰皺;

    	public Par X0Y3_筋肉_筋肉下;

    	public Par X0Y3_筋肉_筋肉左;

    	public Par X0Y3_筋肉_筋肉右;

    	public Par X0Y3_筋肉_筋上左;

    	public Par X0Y3_筋肉_筋上右;

    	public Par X0Y3_筋肉_筋下左;

    	public Par X0Y3_筋肉_筋下右;

    	public Par X0Y3_臍;

    	public Par X0Y3_紋柄_紋左_紋1;

    	public Par X0Y3_紋柄_紋左_紋2;

    	public Par X0Y3_紋柄_紋左_紋3;

    	public Par X0Y3_紋柄_紋右_紋1;

    	public Par X0Y3_紋柄_紋右_紋2;

    	public Par X0Y3_紋柄_紋右_紋3;

    	public Par X0Y3_虎柄_虎左;

    	public Par X0Y3_虎柄_虎右;

    	public Par X0Y3_竜性_中_鱗1;

    	public Par X0Y3_竜性_中_鱗2;

    	public Par X0Y3_竜性_中_鱗3;

    	public Par X0Y3_竜性_中_鱗4;

    	public Par X0Y3_竜性_左_鱗1;

    	public Par X0Y3_竜性_左_鱗2;

    	public Par X0Y3_竜性_右_鱗1;

    	public Par X0Y3_竜性_右_鱗2;

    	public Par X0Y4_腰;

    	public Par X0Y4_股;

    	public Par X0Y4_下腹;

    	public Par X0Y4_腰皺;

    	public Par X0Y4_筋肉_筋肉下;

    	public Par X0Y4_筋肉_筋肉左;

    	public Par X0Y4_筋肉_筋肉右;

    	public Par X0Y4_筋肉_筋上左;

    	public Par X0Y4_筋肉_筋上右;

    	public Par X0Y4_筋肉_筋下左;

    	public Par X0Y4_筋肉_筋下右;

    	public Par X0Y4_臍;

    	public Par X0Y4_紋柄_紋左_紋1;

    	public Par X0Y4_紋柄_紋左_紋2;

    	public Par X0Y4_紋柄_紋左_紋3;

    	public Par X0Y4_紋柄_紋右_紋1;

    	public Par X0Y4_紋柄_紋右_紋2;

    	public Par X0Y4_紋柄_紋右_紋3;

    	public Par X0Y4_虎柄_虎左;

    	public Par X0Y4_虎柄_虎右;

    	public Par X0Y4_竜性_中_鱗1;

    	public Par X0Y4_竜性_中_鱗2;

    	public Par X0Y4_竜性_中_鱗3;

    	public Par X0Y4_竜性_中_鱗4;

    	public Par X0Y4_竜性_左_鱗1;

    	public Par X0Y4_竜性_左_鱗2;

    	public Par X0Y4_竜性_右_鱗1;

    	public Par X0Y4_竜性_右_鱗2;

    	public ColorD 腰CD;

    	public ColorD 股CD;

    	public ColorD 下腹CD;

    	public ColorD 腰皺CD;

    	public ColorD 筋肉_筋肉下CD;

    	public ColorD 筋肉_筋肉左CD;

    	public ColorD 筋肉_筋肉右CD;

    	public ColorD 筋肉_筋上左CD;

    	public ColorD 筋肉_筋上右CD;

    	public ColorD 筋肉_筋下左CD;

    	public ColorD 筋肉_筋下右CD;

    	public ColorD 臍CD;

    	public ColorD 紋柄_紋左_紋1CD;

    	public ColorD 紋柄_紋左_紋2CD;

    	public ColorD 紋柄_紋左_紋3CD;

    	public ColorD 紋柄_紋右_紋1CD;

    	public ColorD 紋柄_紋右_紋2CD;

    	public ColorD 紋柄_紋右_紋3CD;

    	public ColorD 虎柄_虎左CD;

    	public ColorD 虎柄_虎右CD;

    	public ColorD 竜性_中_鱗1CD;

    	public ColorD 竜性_中_鱗2CD;

    	public ColorD 竜性_中_鱗3CD;

    	public ColorD 竜性_中_鱗4CD;

    	public ColorD 竜性_左_鱗1CD;

    	public ColorD 竜性_左_鱗2CD;

    	public ColorD 竜性_右_鱗1CD;

    	public ColorD 竜性_右_鱗2CD;

    	public ColorP X0Y0_腰CP;

    	public ColorP X0Y0_股CP;

    	public ColorP X0Y0_下腹CP;

    	public ColorP X0Y0_腰皺CP;

    	public ColorP X0Y0_筋肉_筋肉下CP;

    	public ColorP X0Y0_筋肉_筋肉左CP;

    	public ColorP X0Y0_筋肉_筋肉右CP;

    	public ColorP X0Y0_筋肉_筋上左CP;

    	public ColorP X0Y0_筋肉_筋上右CP;

    	public ColorP X0Y0_筋肉_筋下左CP;

    	public ColorP X0Y0_筋肉_筋下右CP;

    	public ColorP X0Y0_臍CP;

    	public ColorP X0Y0_紋柄_紋左_紋1CP;

    	public ColorP X0Y0_紋柄_紋左_紋2CP;

    	public ColorP X0Y0_紋柄_紋左_紋3CP;

    	public ColorP X0Y0_紋柄_紋右_紋1CP;

    	public ColorP X0Y0_紋柄_紋右_紋2CP;

    	public ColorP X0Y0_紋柄_紋右_紋3CP;

    	public ColorP X0Y0_虎柄_虎左CP;

    	public ColorP X0Y0_虎柄_虎右CP;

    	public ColorP X0Y0_竜性_中_鱗1CP;

    	public ColorP X0Y0_竜性_中_鱗2CP;

    	public ColorP X0Y0_竜性_中_鱗3CP;

    	public ColorP X0Y0_竜性_中_鱗4CP;

    	public ColorP X0Y0_竜性_左_鱗1CP;

    	public ColorP X0Y0_竜性_左_鱗2CP;

    	public ColorP X0Y0_竜性_右_鱗1CP;

    	public ColorP X0Y0_竜性_右_鱗2CP;

    	public ColorP X0Y1_腰CP;

    	public ColorP X0Y1_股CP;

    	public ColorP X0Y1_下腹CP;

    	public ColorP X0Y1_腰皺CP;

    	public ColorP X0Y1_筋肉_筋肉下CP;

    	public ColorP X0Y1_筋肉_筋肉左CP;

    	public ColorP X0Y1_筋肉_筋肉右CP;

    	public ColorP X0Y1_筋肉_筋上左CP;

    	public ColorP X0Y1_筋肉_筋上右CP;

    	public ColorP X0Y1_筋肉_筋下左CP;

    	public ColorP X0Y1_筋肉_筋下右CP;

    	public ColorP X0Y1_臍CP;

    	public ColorP X0Y1_紋柄_紋左_紋1CP;

    	public ColorP X0Y1_紋柄_紋左_紋2CP;

    	public ColorP X0Y1_紋柄_紋左_紋3CP;

    	public ColorP X0Y1_紋柄_紋右_紋1CP;

    	public ColorP X0Y1_紋柄_紋右_紋2CP;

    	public ColorP X0Y1_紋柄_紋右_紋3CP;

    	public ColorP X0Y1_虎柄_虎左CP;

    	public ColorP X0Y1_虎柄_虎右CP;

    	public ColorP X0Y1_竜性_中_鱗1CP;

    	public ColorP X0Y1_竜性_中_鱗2CP;

    	public ColorP X0Y1_竜性_中_鱗3CP;

    	public ColorP X0Y1_竜性_中_鱗4CP;

    	public ColorP X0Y1_竜性_左_鱗1CP;

    	public ColorP X0Y1_竜性_左_鱗2CP;

    	public ColorP X0Y1_竜性_右_鱗1CP;

    	public ColorP X0Y1_竜性_右_鱗2CP;

    	public ColorP X0Y2_腰CP;

    	public ColorP X0Y2_股CP;

    	public ColorP X0Y2_下腹CP;

    	public ColorP X0Y2_腰皺CP;

    	public ColorP X0Y2_筋肉_筋肉下CP;

    	public ColorP X0Y2_筋肉_筋肉左CP;

    	public ColorP X0Y2_筋肉_筋肉右CP;

    	public ColorP X0Y2_筋肉_筋上左CP;

    	public ColorP X0Y2_筋肉_筋上右CP;

    	public ColorP X0Y2_筋肉_筋下左CP;

    	public ColorP X0Y2_筋肉_筋下右CP;

    	public ColorP X0Y2_臍CP;

    	public ColorP X0Y2_紋柄_紋左_紋1CP;

    	public ColorP X0Y2_紋柄_紋左_紋2CP;

    	public ColorP X0Y2_紋柄_紋左_紋3CP;

    	public ColorP X0Y2_紋柄_紋右_紋1CP;

    	public ColorP X0Y2_紋柄_紋右_紋2CP;

    	public ColorP X0Y2_紋柄_紋右_紋3CP;

    	public ColorP X0Y2_虎柄_虎左CP;

    	public ColorP X0Y2_虎柄_虎右CP;

    	public ColorP X0Y2_竜性_中_鱗1CP;

    	public ColorP X0Y2_竜性_中_鱗2CP;

    	public ColorP X0Y2_竜性_中_鱗3CP;

    	public ColorP X0Y2_竜性_中_鱗4CP;

    	public ColorP X0Y2_竜性_左_鱗1CP;

    	public ColorP X0Y2_竜性_左_鱗2CP;

    	public ColorP X0Y2_竜性_右_鱗1CP;

    	public ColorP X0Y2_竜性_右_鱗2CP;

    	public ColorP X0Y3_腰CP;

    	public ColorP X0Y3_股CP;

    	public ColorP X0Y3_下腹CP;

    	public ColorP X0Y3_腰皺CP;

    	public ColorP X0Y3_筋肉_筋肉下CP;

    	public ColorP X0Y3_筋肉_筋肉左CP;

    	public ColorP X0Y3_筋肉_筋肉右CP;

    	public ColorP X0Y3_筋肉_筋上左CP;

    	public ColorP X0Y3_筋肉_筋上右CP;

    	public ColorP X0Y3_筋肉_筋下左CP;

    	public ColorP X0Y3_筋肉_筋下右CP;

    	public ColorP X0Y3_臍CP;

    	public ColorP X0Y3_紋柄_紋左_紋1CP;

    	public ColorP X0Y3_紋柄_紋左_紋2CP;

    	public ColorP X0Y3_紋柄_紋左_紋3CP;

    	public ColorP X0Y3_紋柄_紋右_紋1CP;

    	public ColorP X0Y3_紋柄_紋右_紋2CP;

    	public ColorP X0Y3_紋柄_紋右_紋3CP;

    	public ColorP X0Y3_虎柄_虎左CP;

    	public ColorP X0Y3_虎柄_虎右CP;

    	public ColorP X0Y3_竜性_中_鱗1CP;

    	public ColorP X0Y3_竜性_中_鱗2CP;

    	public ColorP X0Y3_竜性_中_鱗3CP;

    	public ColorP X0Y3_竜性_中_鱗4CP;

    	public ColorP X0Y3_竜性_左_鱗1CP;

    	public ColorP X0Y3_竜性_左_鱗2CP;

    	public ColorP X0Y3_竜性_右_鱗1CP;

    	public ColorP X0Y3_竜性_右_鱗2CP;

    	public ColorP X0Y4_腰CP;

    	public ColorP X0Y4_股CP;

    	public ColorP X0Y4_下腹CP;

    	public ColorP X0Y4_腰皺CP;

    	public ColorP X0Y4_筋肉_筋肉下CP;

    	public ColorP X0Y4_筋肉_筋肉左CP;

    	public ColorP X0Y4_筋肉_筋肉右CP;

    	public ColorP X0Y4_筋肉_筋上左CP;

    	public ColorP X0Y4_筋肉_筋上右CP;

    	public ColorP X0Y4_筋肉_筋下左CP;

    	public ColorP X0Y4_筋肉_筋下右CP;

    	public ColorP X0Y4_臍CP;

    	public ColorP X0Y4_紋柄_紋左_紋1CP;

    	public ColorP X0Y4_紋柄_紋左_紋2CP;

    	public ColorP X0Y4_紋柄_紋左_紋3CP;

    	public ColorP X0Y4_紋柄_紋右_紋1CP;

    	public ColorP X0Y4_紋柄_紋右_紋2CP;

    	public ColorP X0Y4_紋柄_紋右_紋3CP;

    	public ColorP X0Y4_虎柄_虎左CP;

    	public ColorP X0Y4_虎柄_虎右CP;

    	public ColorP X0Y4_竜性_中_鱗1CP;

    	public ColorP X0Y4_竜性_中_鱗2CP;

    	public ColorP X0Y4_竜性_中_鱗3CP;

    	public ColorP X0Y4_竜性_中_鱗4CP;

    	public ColorP X0Y4_竜性_左_鱗1CP;

    	public ColorP X0Y4_竜性_左_鱗2CP;

    	public ColorP X0Y4_竜性_右_鱗1CP;

    	public ColorP X0Y4_竜性_右_鱗2CP;

    	public Ele[] 腿左_接続;

    	public Ele[] 腿右_接続;

    	public Ele[] 膣基_接続;

    	public Ele[] 肛門_接続;

    	public Ele[] 尾_接続;

    	public Ele[] 半身_接続;

    	public Ele[] 上着_接続;

    	public Ele[] 肌_接続;

    	public Ele[] 翼左_接続;

    	public Ele[] 翼右_接続;

    	public override bool 欠損
    	{
    		get
    		{
    			return 欠損_;
    		}
    		set
    		{
    			欠損_ = value;
    		}
    	}

    	public override bool 筋肉
    	{
    		get
    		{
    			return 筋肉_;
    		}
    		set
    		{
    			筋肉_ = value;
    			筋肉_筋肉下_表示 = 筋肉_;
    			筋肉_筋肉左_表示 = 筋肉_;
    			筋肉_筋肉右_表示 = 筋肉_;
    			筋肉_筋上左_表示 = 筋肉_;
    			筋肉_筋上右_表示 = 筋肉_;
    			筋肉_筋下左_表示 = 筋肉_;
    			筋肉_筋下右_表示 = 筋肉_;
    		}
    	}

    	public override bool 拘束
    	{
    		get
    		{
    			return 拘束_;
    		}
    		set
    		{
    			拘束_ = value;
    		}
    	}

    	public bool 腰_表示
    	{
    		get
    		{
    			return X0Y0_腰.Dra;
    		}
    		set
    		{
    			X0Y0_腰.Dra = value;
    			X0Y1_腰.Dra = value;
    			X0Y2_腰.Dra = value;
    			X0Y3_腰.Dra = value;
    			X0Y4_腰.Dra = value;
    			X0Y0_腰.Hit = value;
    			X0Y1_腰.Hit = value;
    			X0Y2_腰.Hit = value;
    			X0Y3_腰.Hit = value;
    			X0Y4_腰.Hit = value;
    		}
    	}

    	public bool 股_表示
    	{
    		get
    		{
    			return X0Y0_股.Dra;
    		}
    		set
    		{
    			X0Y0_股.Dra = value;
    			X0Y1_股.Dra = value;
    			X0Y2_股.Dra = value;
    			X0Y3_股.Dra = value;
    			X0Y4_股.Dra = value;
    			X0Y0_股.Hit = value;
    			X0Y1_股.Hit = value;
    			X0Y2_股.Hit = value;
    			X0Y3_股.Hit = value;
    			X0Y4_股.Hit = value;
    		}
    	}

    	public bool 下腹_表示
    	{
    		get
    		{
    			return X0Y0_下腹.Dra;
    		}
    		set
    		{
    			X0Y0_下腹.Dra = value;
    			X0Y1_下腹.Dra = value;
    			X0Y2_下腹.Dra = value;
    			X0Y3_下腹.Dra = value;
    			X0Y4_下腹.Dra = value;
    			X0Y0_下腹.Hit = value;
    			X0Y1_下腹.Hit = value;
    			X0Y2_下腹.Hit = value;
    			X0Y3_下腹.Hit = value;
    			X0Y4_下腹.Hit = value;
    		}
    	}

    	public bool 腰皺_表示
    	{
    		get
    		{
    			return X0Y0_腰皺.Dra;
    		}
    		set
    		{
    			X0Y0_腰皺.Dra = value;
    			X0Y1_腰皺.Dra = value;
    			X0Y2_腰皺.Dra = value;
    			X0Y3_腰皺.Dra = value;
    			X0Y4_腰皺.Dra = value;
    			X0Y0_腰皺.Hit = value;
    			X0Y1_腰皺.Hit = value;
    			X0Y2_腰皺.Hit = value;
    			X0Y3_腰皺.Hit = value;
    			X0Y4_腰皺.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉下_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉下.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉下.Dra = value;
    			X0Y1_筋肉_筋肉下.Dra = value;
    			X0Y2_筋肉_筋肉下.Dra = value;
    			X0Y3_筋肉_筋肉下.Dra = value;
    			X0Y4_筋肉_筋肉下.Dra = value;
    			X0Y0_筋肉_筋肉下.Hit = value;
    			X0Y1_筋肉_筋肉下.Hit = value;
    			X0Y2_筋肉_筋肉下.Hit = value;
    			X0Y3_筋肉_筋肉下.Hit = value;
    			X0Y4_筋肉_筋肉下.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉左_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉左.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉左.Dra = value;
    			X0Y1_筋肉_筋肉左.Dra = value;
    			X0Y2_筋肉_筋肉左.Dra = value;
    			X0Y3_筋肉_筋肉左.Dra = value;
    			X0Y4_筋肉_筋肉左.Dra = value;
    			X0Y0_筋肉_筋肉左.Hit = value;
    			X0Y1_筋肉_筋肉左.Hit = value;
    			X0Y2_筋肉_筋肉左.Hit = value;
    			X0Y3_筋肉_筋肉左.Hit = value;
    			X0Y4_筋肉_筋肉左.Hit = value;
    		}
    	}

    	public bool 筋肉_筋肉右_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋肉右.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋肉右.Dra = value;
    			X0Y1_筋肉_筋肉右.Dra = value;
    			X0Y2_筋肉_筋肉右.Dra = value;
    			X0Y3_筋肉_筋肉右.Dra = value;
    			X0Y4_筋肉_筋肉右.Dra = value;
    			X0Y0_筋肉_筋肉右.Hit = value;
    			X0Y1_筋肉_筋肉右.Hit = value;
    			X0Y2_筋肉_筋肉右.Hit = value;
    			X0Y3_筋肉_筋肉右.Hit = value;
    			X0Y4_筋肉_筋肉右.Hit = value;
    		}
    	}

    	public bool 筋肉_筋上左_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋上左.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋上左.Dra = value;
    			X0Y1_筋肉_筋上左.Dra = value;
    			X0Y2_筋肉_筋上左.Dra = value;
    			X0Y3_筋肉_筋上左.Dra = value;
    			X0Y4_筋肉_筋上左.Dra = value;
    			X0Y0_筋肉_筋上左.Hit = value;
    			X0Y1_筋肉_筋上左.Hit = value;
    			X0Y2_筋肉_筋上左.Hit = value;
    			X0Y3_筋肉_筋上左.Hit = value;
    			X0Y4_筋肉_筋上左.Hit = value;
    		}
    	}

    	public bool 筋肉_筋上右_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋上右.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋上右.Dra = value;
    			X0Y1_筋肉_筋上右.Dra = value;
    			X0Y2_筋肉_筋上右.Dra = value;
    			X0Y3_筋肉_筋上右.Dra = value;
    			X0Y4_筋肉_筋上右.Dra = value;
    			X0Y0_筋肉_筋上右.Hit = value;
    			X0Y1_筋肉_筋上右.Hit = value;
    			X0Y2_筋肉_筋上右.Hit = value;
    			X0Y3_筋肉_筋上右.Hit = value;
    			X0Y4_筋肉_筋上右.Hit = value;
    		}
    	}

    	public bool 筋肉_筋下左_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋下左.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋下左.Dra = value;
    			X0Y1_筋肉_筋下左.Dra = value;
    			X0Y2_筋肉_筋下左.Dra = value;
    			X0Y3_筋肉_筋下左.Dra = value;
    			X0Y4_筋肉_筋下左.Dra = value;
    			X0Y0_筋肉_筋下左.Hit = value;
    			X0Y1_筋肉_筋下左.Hit = value;
    			X0Y2_筋肉_筋下左.Hit = value;
    			X0Y3_筋肉_筋下左.Hit = value;
    			X0Y4_筋肉_筋下左.Hit = value;
    		}
    	}

    	public bool 筋肉_筋下右_表示
    	{
    		get
    		{
    			return X0Y0_筋肉_筋下右.Dra;
    		}
    		set
    		{
    			X0Y0_筋肉_筋下右.Dra = value;
    			X0Y1_筋肉_筋下右.Dra = value;
    			X0Y2_筋肉_筋下右.Dra = value;
    			X0Y3_筋肉_筋下右.Dra = value;
    			X0Y4_筋肉_筋下右.Dra = value;
    			X0Y0_筋肉_筋下右.Hit = value;
    			X0Y1_筋肉_筋下右.Hit = value;
    			X0Y2_筋肉_筋下右.Hit = value;
    			X0Y3_筋肉_筋下右.Hit = value;
    			X0Y4_筋肉_筋下右.Hit = value;
    		}
    	}

    	public bool 臍_表示
    	{
    		get
    		{
    			return X0Y0_臍.Dra;
    		}
    		set
    		{
    			X0Y0_臍.Dra = value;
    			X0Y1_臍.Dra = value;
    			X0Y2_臍.Dra = value;
    			X0Y3_臍.Dra = value;
    			X0Y4_臍.Dra = value;
    			X0Y0_臍.Hit = value;
    			X0Y1_臍.Hit = value;
    			X0Y2_臍.Hit = value;
    			X0Y3_臍.Hit = value;
    			X0Y4_臍.Hit = value;
    		}
    	}

    	public bool 紋柄_紋左_紋1_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋左_紋1.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋左_紋1.Dra = value;
    			X0Y1_紋柄_紋左_紋1.Dra = value;
    			X0Y2_紋柄_紋左_紋1.Dra = value;
    			X0Y3_紋柄_紋左_紋1.Dra = value;
    			X0Y4_紋柄_紋左_紋1.Dra = value;
    			X0Y0_紋柄_紋左_紋1.Hit = value;
    			X0Y1_紋柄_紋左_紋1.Hit = value;
    			X0Y2_紋柄_紋左_紋1.Hit = value;
    			X0Y3_紋柄_紋左_紋1.Hit = value;
    			X0Y4_紋柄_紋左_紋1.Hit = value;
    		}
    	}

    	public bool 紋柄_紋左_紋2_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋左_紋2.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋左_紋2.Dra = value;
    			X0Y1_紋柄_紋左_紋2.Dra = value;
    			X0Y2_紋柄_紋左_紋2.Dra = value;
    			X0Y3_紋柄_紋左_紋2.Dra = value;
    			X0Y4_紋柄_紋左_紋2.Dra = value;
    			X0Y0_紋柄_紋左_紋2.Hit = value;
    			X0Y1_紋柄_紋左_紋2.Hit = value;
    			X0Y2_紋柄_紋左_紋2.Hit = value;
    			X0Y3_紋柄_紋左_紋2.Hit = value;
    			X0Y4_紋柄_紋左_紋2.Hit = value;
    		}
    	}

    	public bool 紋柄_紋左_紋3_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋左_紋3.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋左_紋3.Dra = value;
    			X0Y1_紋柄_紋左_紋3.Dra = value;
    			X0Y2_紋柄_紋左_紋3.Dra = value;
    			X0Y3_紋柄_紋左_紋3.Dra = value;
    			X0Y4_紋柄_紋左_紋3.Dra = value;
    			X0Y0_紋柄_紋左_紋3.Hit = value;
    			X0Y1_紋柄_紋左_紋3.Hit = value;
    			X0Y2_紋柄_紋左_紋3.Hit = value;
    			X0Y3_紋柄_紋左_紋3.Hit = value;
    			X0Y4_紋柄_紋左_紋3.Hit = value;
    		}
    	}

    	public bool 紋柄_紋右_紋1_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋右_紋1.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋右_紋1.Dra = value;
    			X0Y1_紋柄_紋右_紋1.Dra = value;
    			X0Y2_紋柄_紋右_紋1.Dra = value;
    			X0Y3_紋柄_紋右_紋1.Dra = value;
    			X0Y4_紋柄_紋右_紋1.Dra = value;
    			X0Y0_紋柄_紋右_紋1.Hit = value;
    			X0Y1_紋柄_紋右_紋1.Hit = value;
    			X0Y2_紋柄_紋右_紋1.Hit = value;
    			X0Y3_紋柄_紋右_紋1.Hit = value;
    			X0Y4_紋柄_紋右_紋1.Hit = value;
    		}
    	}

    	public bool 紋柄_紋右_紋2_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋右_紋2.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋右_紋2.Dra = value;
    			X0Y1_紋柄_紋右_紋2.Dra = value;
    			X0Y2_紋柄_紋右_紋2.Dra = value;
    			X0Y3_紋柄_紋右_紋2.Dra = value;
    			X0Y4_紋柄_紋右_紋2.Dra = value;
    			X0Y0_紋柄_紋右_紋2.Hit = value;
    			X0Y1_紋柄_紋右_紋2.Hit = value;
    			X0Y2_紋柄_紋右_紋2.Hit = value;
    			X0Y3_紋柄_紋右_紋2.Hit = value;
    			X0Y4_紋柄_紋右_紋2.Hit = value;
    		}
    	}

    	public bool 紋柄_紋右_紋3_表示
    	{
    		get
    		{
    			return X0Y0_紋柄_紋右_紋3.Dra;
    		}
    		set
    		{
    			X0Y0_紋柄_紋右_紋3.Dra = value;
    			X0Y1_紋柄_紋右_紋3.Dra = value;
    			X0Y2_紋柄_紋右_紋3.Dra = value;
    			X0Y3_紋柄_紋右_紋3.Dra = value;
    			X0Y4_紋柄_紋右_紋3.Dra = value;
    			X0Y0_紋柄_紋右_紋3.Hit = value;
    			X0Y1_紋柄_紋右_紋3.Hit = value;
    			X0Y2_紋柄_紋右_紋3.Hit = value;
    			X0Y3_紋柄_紋右_紋3.Hit = value;
    			X0Y4_紋柄_紋右_紋3.Hit = value;
    		}
    	}

    	public bool 虎柄_虎左_表示
    	{
    		get
    		{
    			return X0Y0_虎柄_虎左.Dra;
    		}
    		set
    		{
    			X0Y0_虎柄_虎左.Dra = value;
    			X0Y1_虎柄_虎左.Dra = value;
    			X0Y2_虎柄_虎左.Dra = value;
    			X0Y3_虎柄_虎左.Dra = value;
    			X0Y4_虎柄_虎左.Dra = value;
    			X0Y0_虎柄_虎左.Hit = value;
    			X0Y1_虎柄_虎左.Hit = value;
    			X0Y2_虎柄_虎左.Hit = value;
    			X0Y3_虎柄_虎左.Hit = value;
    			X0Y4_虎柄_虎左.Hit = value;
    		}
    	}

    	public bool 虎柄_虎右_表示
    	{
    		get
    		{
    			return X0Y0_虎柄_虎右.Dra;
    		}
    		set
    		{
    			X0Y0_虎柄_虎右.Dra = value;
    			X0Y1_虎柄_虎右.Dra = value;
    			X0Y2_虎柄_虎右.Dra = value;
    			X0Y3_虎柄_虎右.Dra = value;
    			X0Y4_虎柄_虎右.Dra = value;
    			X0Y0_虎柄_虎右.Hit = value;
    			X0Y1_虎柄_虎右.Hit = value;
    			X0Y2_虎柄_虎右.Hit = value;
    			X0Y3_虎柄_虎右.Hit = value;
    			X0Y4_虎柄_虎右.Hit = value;
    		}
    	}

    	public bool 竜性_中_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_竜性_中_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_中_鱗1.Dra = false;
    			X0Y1_竜性_中_鱗1.Dra = false;
    			X0Y2_竜性_中_鱗1.Dra = false;
    			X0Y3_竜性_中_鱗1.Dra = false;
    			X0Y4_竜性_中_鱗1.Dra = false;
    			X0Y0_竜性_中_鱗1.Hit = false;
    			X0Y1_竜性_中_鱗1.Hit = false;
    			X0Y2_竜性_中_鱗1.Hit = false;
    			X0Y3_竜性_中_鱗1.Hit = false;
    			X0Y4_竜性_中_鱗1.Hit = false;
    		}
    	}

    	public bool 竜性_中_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_竜性_中_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_中_鱗2.Dra = false;
    			X0Y1_竜性_中_鱗2.Dra = false;
    			X0Y2_竜性_中_鱗2.Dra = false;
    			X0Y3_竜性_中_鱗2.Dra = false;
    			X0Y4_竜性_中_鱗2.Dra = false;
    			X0Y0_竜性_中_鱗2.Hit = false;
    			X0Y1_竜性_中_鱗2.Hit = false;
    			X0Y2_竜性_中_鱗2.Hit = false;
    			X0Y3_竜性_中_鱗2.Hit = false;
    			X0Y4_竜性_中_鱗2.Hit = false;
    		}
    	}

    	public bool 竜性_中_鱗3_表示
    	{
    		get
    		{
    			return X0Y0_竜性_中_鱗3.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_中_鱗3.Dra = false;
    			X0Y1_竜性_中_鱗3.Dra = false;
    			X0Y2_竜性_中_鱗3.Dra = false;
    			X0Y3_竜性_中_鱗3.Dra = false;
    			X0Y4_竜性_中_鱗3.Dra = false;
    			X0Y0_竜性_中_鱗3.Hit = false;
    			X0Y1_竜性_中_鱗3.Hit = false;
    			X0Y2_竜性_中_鱗3.Hit = false;
    			X0Y3_竜性_中_鱗3.Hit = false;
    			X0Y4_竜性_中_鱗3.Hit = false;
    		}
    	}

    	public bool 竜性_中_鱗4_表示
    	{
    		get
    		{
    			return X0Y0_竜性_中_鱗4.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_中_鱗4.Dra = false;
    			X0Y1_竜性_中_鱗4.Dra = false;
    			X0Y2_竜性_中_鱗4.Dra = false;
    			X0Y3_竜性_中_鱗4.Dra = false;
    			X0Y4_竜性_中_鱗4.Dra = false;
    			X0Y0_竜性_中_鱗4.Hit = false;
    			X0Y1_竜性_中_鱗4.Hit = false;
    			X0Y2_竜性_中_鱗4.Hit = false;
    			X0Y3_竜性_中_鱗4.Hit = false;
    			X0Y4_竜性_中_鱗4.Hit = false;
    		}
    	}

    	public bool 竜性_左_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_竜性_左_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_左_鱗1.Dra = value;
    			X0Y1_竜性_左_鱗1.Dra = value;
    			X0Y2_竜性_左_鱗1.Dra = value;
    			X0Y3_竜性_左_鱗1.Dra = value;
    			X0Y4_竜性_左_鱗1.Dra = value;
    			X0Y0_竜性_左_鱗1.Hit = value;
    			X0Y1_竜性_左_鱗1.Hit = value;
    			X0Y2_竜性_左_鱗1.Hit = value;
    			X0Y3_竜性_左_鱗1.Hit = value;
    			X0Y4_竜性_左_鱗1.Hit = value;
    		}
    	}

    	public bool 竜性_左_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_竜性_左_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_左_鱗2.Dra = value;
    			X0Y1_竜性_左_鱗2.Dra = value;
    			X0Y2_竜性_左_鱗2.Dra = value;
    			X0Y3_竜性_左_鱗2.Dra = value;
    			X0Y4_竜性_左_鱗2.Dra = value;
    			X0Y0_竜性_左_鱗2.Hit = value;
    			X0Y1_竜性_左_鱗2.Hit = value;
    			X0Y2_竜性_左_鱗2.Hit = value;
    			X0Y3_竜性_左_鱗2.Hit = value;
    			X0Y4_竜性_左_鱗2.Hit = value;
    		}
    	}

    	public bool 竜性_右_鱗1_表示
    	{
    		get
    		{
    			return X0Y0_竜性_右_鱗1.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_右_鱗1.Dra = value;
    			X0Y1_竜性_右_鱗1.Dra = value;
    			X0Y2_竜性_右_鱗1.Dra = value;
    			X0Y3_竜性_右_鱗1.Dra = value;
    			X0Y4_竜性_右_鱗1.Dra = value;
    			X0Y0_竜性_右_鱗1.Hit = value;
    			X0Y1_竜性_右_鱗1.Hit = value;
    			X0Y2_竜性_右_鱗1.Hit = value;
    			X0Y3_竜性_右_鱗1.Hit = value;
    			X0Y4_竜性_右_鱗1.Hit = value;
    		}
    	}

    	public bool 竜性_右_鱗2_表示
    	{
    		get
    		{
    			return X0Y0_竜性_右_鱗2.Dra;
    		}
    		set
    		{
    			X0Y0_竜性_右_鱗2.Dra = value;
    			X0Y1_竜性_右_鱗2.Dra = value;
    			X0Y2_竜性_右_鱗2.Dra = value;
    			X0Y3_竜性_右_鱗2.Dra = value;
    			X0Y4_竜性_右_鱗2.Dra = value;
    			X0Y0_竜性_右_鱗2.Hit = value;
    			X0Y1_竜性_右_鱗2.Hit = value;
    			X0Y2_竜性_右_鱗2.Hit = value;
    			X0Y3_竜性_右_鱗2.Hit = value;
    			X0Y4_竜性_右_鱗2.Hit = value;
    		}
    	}

    	public double 筋肉濃度
    	{
    		get
    		{
    			return 筋肉_筋肉下CD.不透明度;
    		}
    		set
    		{
    			筋肉_筋肉下CD.不透明度 = value;
    			筋肉_筋肉左CD.不透明度 = value;
    			筋肉_筋肉右CD.不透明度 = value;
    			筋肉_筋上左CD.不透明度 = value;
    			筋肉_筋上右CD.不透明度 = value;
    			筋肉_筋下左CD.不透明度 = value;
    			筋肉_筋下右CD.不透明度 = value;
    		}
    	}

    	public override bool 表示
    	{
    		get
    		{
    			return 腰_表示;
    		}
    		set
    		{
    			腰_表示 = value;
    			股_表示 = value;
    			下腹_表示 = value;
    			腰皺_表示 = value;
    			筋肉_筋肉下_表示 = value;
    			筋肉_筋肉左_表示 = value;
    			筋肉_筋肉右_表示 = value;
    			筋肉_筋上左_表示 = value;
    			筋肉_筋上右_表示 = value;
    			筋肉_筋下左_表示 = value;
    			筋肉_筋下右_表示 = value;
    			臍_表示 = value;
    			紋柄_紋左_紋1_表示 = value;
    			紋柄_紋左_紋2_表示 = value;
    			紋柄_紋左_紋3_表示 = value;
    			紋柄_紋右_紋1_表示 = value;
    			紋柄_紋右_紋2_表示 = value;
    			紋柄_紋右_紋3_表示 = value;
    			虎柄_虎左_表示 = value;
    			虎柄_虎右_表示 = value;
    			竜性_中_鱗1_表示 = value;
    			竜性_中_鱗2_表示 = value;
    			竜性_中_鱗3_表示 = value;
    			竜性_中_鱗4_表示 = value;
    			竜性_左_鱗1_表示 = value;
    			竜性_左_鱗2_表示 = value;
    			竜性_右_鱗1_表示 = value;
    			竜性_右_鱗2_表示 = value;
    		}
    	}

    	public override double 濃度
    	{
    		get
    		{
    			return 腰CD.不透明度;
    		}
    		set
    		{
    			腰CD.不透明度 = value;
    			股CD.不透明度 = value;
    			下腹CD.不透明度 = value;
    			腰皺CD.不透明度 = value;
    			筋肉_筋肉下CD.不透明度 = value;
    			筋肉_筋肉左CD.不透明度 = value;
    			筋肉_筋肉右CD.不透明度 = value;
    			筋肉_筋上左CD.不透明度 = value;
    			筋肉_筋上右CD.不透明度 = value;
    			筋肉_筋下左CD.不透明度 = value;
    			筋肉_筋下右CD.不透明度 = value;
    			臍CD.不透明度 = value;
    			紋柄_紋左_紋1CD.不透明度 = value;
    			紋柄_紋左_紋2CD.不透明度 = value;
    			紋柄_紋左_紋3CD.不透明度 = value;
    			紋柄_紋右_紋1CD.不透明度 = value;
    			紋柄_紋右_紋2CD.不透明度 = value;
    			紋柄_紋右_紋3CD.不透明度 = value;
    			虎柄_虎左CD.不透明度 = value;
    			虎柄_虎右CD.不透明度 = value;
    			竜性_中_鱗1CD.不透明度 = value;
    			竜性_中_鱗2CD.不透明度 = value;
    			竜性_中_鱗3CD.不透明度 = value;
    			竜性_中_鱗4CD.不透明度 = value;
    			竜性_左_鱗1CD.不透明度 = value;
    			竜性_左_鱗2CD.不透明度 = value;
    			竜性_右_鱗1CD.不透明度 = value;
    			竜性_右_鱗2CD.不透明度 = value;
    		}
    	}

    	public JointS 腿左_接続点 => new JointS(本体, X0Y0_腰, 0);

    	public JointS 腿右_接続点 => new JointS(本体, X0Y0_腰, 1);

    	public JointS 膣基_接続点 => new JointS(本体, X0Y0_腰, 3);

    	public JointS 肛門_接続点 => new JointS(本体, X0Y0_腰, 4);

    	public JointS 尾_接続点 => new JointS(本体, X0Y0_腰, 4);

    	public JointS 半身_接続点 => new JointS(本体, X0Y0_腰, 4);

    	public JointS 上着_接続点 => new JointS(本体, X0Y0_腰, 5);

    	public JointS 肌_接続点 => new JointS(本体, X0Y0_腰, 6);

    	public JointS 翼左_接続点 => new JointS(本体, X0Y0_腰, 7);

    	public JointS 翼右_接続点 => new JointS(本体, X0Y0_腰, 8);

    	public 四足腰(double DisUnit, 配色指定 配色指定, 体配色 体配色, Med Med, 四足腰D e)
    	{
    		四足腰 四足腰2 = this;
    		ThisType = GetType();
    		本体 = new Difs(Sta.半身["四足腰"]);
    		Pars pars = 本体[0][0];
    		X0Y0_腰 = pars["腰"].ToPar();
    		X0Y0_股 = pars["股"].ToPar();
    		X0Y0_下腹 = pars["下腹"].ToPar();
    		X0Y0_腰皺 = pars["腰皺"].ToPar();
    		Pars pars2 = pars["筋肉"].ToPars();
    		X0Y0_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
    		X0Y0_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
    		X0Y0_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
    		X0Y0_筋肉_筋上左 = pars2["筋上左"].ToPar();
    		X0Y0_筋肉_筋上右 = pars2["筋上右"].ToPar();
    		X0Y0_筋肉_筋下左 = pars2["筋下左"].ToPar();
    		X0Y0_筋肉_筋下右 = pars2["筋下右"].ToPar();
    		X0Y0_臍 = pars["臍"].ToPar();
    		pars2 = pars["紋柄"].ToPars();
    		Pars pars3 = pars2["紋左"].ToPars();
    		X0Y0_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
    		X0Y0_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
    		X0Y0_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
    		pars3 = pars2["紋右"].ToPars();
    		X0Y0_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
    		X0Y0_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
    		X0Y0_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
    		pars2 = pars["虎柄"].ToPars();
    		X0Y0_虎柄_虎左 = pars2["虎左"].ToPar();
    		X0Y0_虎柄_虎右 = pars2["虎右"].ToPar();
    		pars2 = pars["鱗"].ToPars();
    		pars3 = pars2["中"].ToPars();
    		X0Y0_竜性_中_鱗1 = pars3["鱗1"].ToPar();
    		X0Y0_竜性_中_鱗2 = pars3["鱗2"].ToPar();
    		X0Y0_竜性_中_鱗3 = pars3["鱗3"].ToPar();
    		X0Y0_竜性_中_鱗4 = pars3["鱗4"].ToPar();
    		pars3 = pars2["左"].ToPars();
    		X0Y0_竜性_左_鱗1 = pars3["鱗1"].ToPar();
    		X0Y0_竜性_左_鱗2 = pars3["鱗2"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		X0Y0_竜性_右_鱗1 = pars3["鱗1"].ToPar();
    		X0Y0_竜性_右_鱗2 = pars3["鱗2"].ToPar();
    		pars = 本体[0][1];
    		X0Y1_腰 = pars["腰"].ToPar();
    		X0Y1_股 = pars["股"].ToPar();
    		X0Y1_下腹 = pars["下腹"].ToPar();
    		X0Y1_腰皺 = pars["腰皺"].ToPar();
    		pars2 = pars["筋肉"].ToPars();
    		X0Y1_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
    		X0Y1_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
    		X0Y1_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
    		X0Y1_筋肉_筋上左 = pars2["筋上左"].ToPar();
    		X0Y1_筋肉_筋上右 = pars2["筋上右"].ToPar();
    		X0Y1_筋肉_筋下左 = pars2["筋下左"].ToPar();
    		X0Y1_筋肉_筋下右 = pars2["筋下右"].ToPar();
    		X0Y1_臍 = pars["臍"].ToPar();
    		pars2 = pars["紋柄"].ToPars();
    		pars3 = pars2["紋左"].ToPars();
    		X0Y1_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
    		X0Y1_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
    		X0Y1_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
    		pars3 = pars2["紋右"].ToPars();
    		X0Y1_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
    		X0Y1_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
    		X0Y1_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
    		pars2 = pars["虎柄"].ToPars();
    		X0Y1_虎柄_虎左 = pars2["虎左"].ToPar();
    		X0Y1_虎柄_虎右 = pars2["虎右"].ToPar();
    		pars2 = pars["鱗"].ToPars();
    		pars3 = pars2["中"].ToPars();
    		X0Y1_竜性_中_鱗1 = pars3["鱗1"].ToPar();
    		X0Y1_竜性_中_鱗2 = pars3["鱗2"].ToPar();
    		X0Y1_竜性_中_鱗3 = pars3["鱗3"].ToPar();
    		X0Y1_竜性_中_鱗4 = pars3["鱗4"].ToPar();
    		pars3 = pars2["左"].ToPars();
    		X0Y1_竜性_左_鱗1 = pars3["鱗1"].ToPar();
    		X0Y1_竜性_左_鱗2 = pars3["鱗2"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		X0Y1_竜性_右_鱗1 = pars3["鱗1"].ToPar();
    		X0Y1_竜性_右_鱗2 = pars3["鱗2"].ToPar();
    		pars = 本体[0][2];
    		X0Y2_腰 = pars["腰"].ToPar();
    		X0Y2_股 = pars["股"].ToPar();
    		X0Y2_下腹 = pars["下腹"].ToPar();
    		X0Y2_腰皺 = pars["腰皺"].ToPar();
    		pars2 = pars["筋肉"].ToPars();
    		X0Y2_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
    		X0Y2_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
    		X0Y2_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
    		X0Y2_筋肉_筋上左 = pars2["筋上左"].ToPar();
    		X0Y2_筋肉_筋上右 = pars2["筋上右"].ToPar();
    		X0Y2_筋肉_筋下左 = pars2["筋下左"].ToPar();
    		X0Y2_筋肉_筋下右 = pars2["筋下右"].ToPar();
    		X0Y2_臍 = pars["臍"].ToPar();
    		pars2 = pars["紋柄"].ToPars();
    		pars3 = pars2["紋左"].ToPars();
    		X0Y2_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
    		X0Y2_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
    		X0Y2_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
    		pars3 = pars2["紋右"].ToPars();
    		X0Y2_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
    		X0Y2_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
    		X0Y2_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
    		pars2 = pars["虎柄"].ToPars();
    		X0Y2_虎柄_虎左 = pars2["虎左"].ToPar();
    		X0Y2_虎柄_虎右 = pars2["虎右"].ToPar();
    		pars2 = pars["鱗"].ToPars();
    		pars3 = pars2["中"].ToPars();
    		X0Y2_竜性_中_鱗1 = pars3["鱗1"].ToPar();
    		X0Y2_竜性_中_鱗2 = pars3["鱗2"].ToPar();
    		X0Y2_竜性_中_鱗3 = pars3["鱗3"].ToPar();
    		X0Y2_竜性_中_鱗4 = pars3["鱗4"].ToPar();
    		pars3 = pars2["左"].ToPars();
    		X0Y2_竜性_左_鱗1 = pars3["鱗1"].ToPar();
    		X0Y2_竜性_左_鱗2 = pars3["鱗2"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		X0Y2_竜性_右_鱗1 = pars3["鱗1"].ToPar();
    		X0Y2_竜性_右_鱗2 = pars3["鱗2"].ToPar();
    		pars = 本体[0][3];
    		X0Y3_腰 = pars["腰"].ToPar();
    		X0Y3_股 = pars["股"].ToPar();
    		X0Y3_下腹 = pars["下腹"].ToPar();
    		X0Y3_腰皺 = pars["腰皺"].ToPar();
    		pars2 = pars["筋肉"].ToPars();
    		X0Y3_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
    		X0Y3_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
    		X0Y3_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
    		X0Y3_筋肉_筋上左 = pars2["筋上左"].ToPar();
    		X0Y3_筋肉_筋上右 = pars2["筋上右"].ToPar();
    		X0Y3_筋肉_筋下左 = pars2["筋下左"].ToPar();
    		X0Y3_筋肉_筋下右 = pars2["筋下右"].ToPar();
    		X0Y3_臍 = pars["臍"].ToPar();
    		pars2 = pars["紋柄"].ToPars();
    		pars3 = pars2["紋左"].ToPars();
    		X0Y3_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
    		X0Y3_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
    		X0Y3_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
    		pars3 = pars2["紋右"].ToPars();
    		X0Y3_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
    		X0Y3_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
    		X0Y3_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
    		pars2 = pars["虎柄"].ToPars();
    		X0Y3_虎柄_虎左 = pars2["虎左"].ToPar();
    		X0Y3_虎柄_虎右 = pars2["虎右"].ToPar();
    		pars2 = pars["鱗"].ToPars();
    		pars3 = pars2["中"].ToPars();
    		X0Y3_竜性_中_鱗1 = pars3["鱗1"].ToPar();
    		X0Y3_竜性_中_鱗2 = pars3["鱗2"].ToPar();
    		X0Y3_竜性_中_鱗3 = pars3["鱗3"].ToPar();
    		X0Y3_竜性_中_鱗4 = pars3["鱗4"].ToPar();
    		pars3 = pars2["左"].ToPars();
    		X0Y3_竜性_左_鱗1 = pars3["鱗1"].ToPar();
    		X0Y3_竜性_左_鱗2 = pars3["鱗2"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		X0Y3_竜性_右_鱗1 = pars3["鱗1"].ToPar();
    		X0Y3_竜性_右_鱗2 = pars3["鱗2"].ToPar();
    		pars = 本体[0][4];
    		X0Y4_腰 = pars["腰"].ToPar();
    		X0Y4_股 = pars["股"].ToPar();
    		X0Y4_下腹 = pars["下腹"].ToPar();
    		X0Y4_腰皺 = pars["腰皺"].ToPar();
    		pars2 = pars["筋肉"].ToPars();
    		X0Y4_筋肉_筋肉下 = pars2["筋肉下"].ToPar();
    		X0Y4_筋肉_筋肉左 = pars2["筋肉左"].ToPar();
    		X0Y4_筋肉_筋肉右 = pars2["筋肉右"].ToPar();
    		X0Y4_筋肉_筋上左 = pars2["筋上左"].ToPar();
    		X0Y4_筋肉_筋上右 = pars2["筋上右"].ToPar();
    		X0Y4_筋肉_筋下左 = pars2["筋下左"].ToPar();
    		X0Y4_筋肉_筋下右 = pars2["筋下右"].ToPar();
    		X0Y4_臍 = pars["臍"].ToPar();
    		pars2 = pars["紋柄"].ToPars();
    		pars3 = pars2["紋左"].ToPars();
    		X0Y4_紋柄_紋左_紋1 = pars3["紋1"].ToPar();
    		X0Y4_紋柄_紋左_紋2 = pars3["紋2"].ToPar();
    		X0Y4_紋柄_紋左_紋3 = pars3["紋3"].ToPar();
    		pars3 = pars2["紋右"].ToPars();
    		X0Y4_紋柄_紋右_紋1 = pars3["紋1"].ToPar();
    		X0Y4_紋柄_紋右_紋2 = pars3["紋2"].ToPar();
    		X0Y4_紋柄_紋右_紋3 = pars3["紋3"].ToPar();
    		pars2 = pars["虎柄"].ToPars();
    		X0Y4_虎柄_虎左 = pars2["虎左"].ToPar();
    		X0Y4_虎柄_虎右 = pars2["虎右"].ToPar();
    		pars2 = pars["鱗"].ToPars();
    		pars3 = pars2["中"].ToPars();
    		X0Y4_竜性_中_鱗1 = pars3["鱗1"].ToPar();
    		X0Y4_竜性_中_鱗2 = pars3["鱗2"].ToPar();
    		X0Y4_竜性_中_鱗3 = pars3["鱗3"].ToPar();
    		X0Y4_竜性_中_鱗4 = pars3["鱗4"].ToPar();
    		pars3 = pars2["左"].ToPars();
    		X0Y4_竜性_左_鱗1 = pars3["鱗1"].ToPar();
    		X0Y4_竜性_左_鱗2 = pars3["鱗2"].ToPar();
    		pars3 = pars2["右"].ToPars();
    		X0Y4_竜性_右_鱗1 = pars3["鱗1"].ToPar();
    		X0Y4_竜性_右_鱗2 = pars3["鱗2"].ToPar();
    		本体.SetJoints();
    		接続根 = new JointD(本体);
    		右 = e.右;
    		反転X = e.反転X;
    		反転Y = e.反転Y;
    		基準C = e.基準C;
    		位置C = e.位置C;
    		角度B = e.角度B;
    		角度C = e.角度C;
    		尺度B = e.尺度B;
    		尺度C = e.尺度C;
    		尺度XB = e.尺度XB;
    		尺度XC = e.尺度XC;
    		尺度YB = e.尺度YB;
    		尺度YC = e.尺度YC;
    		肥大 = e.肥大;
    		身長 = e.身長;
    		Xv = e.Xv;
    		Yv = e.Yv;
    		Xi = e.Xi;
    		Yi = e.Yi;
    		サイズ = e.サイズ;
    		サイズX = e.サイズX;
    		サイズY = e.サイズY;
    		腰_表示 = e.腰_表示;
    		股_表示 = e.股_表示;
    		下腹_表示 = e.下腹_表示;
    		腰皺_表示 = e.腰皺_表示;
    		筋肉_筋肉下_表示 = e.筋肉_筋肉下_表示;
    		筋肉_筋肉左_表示 = e.筋肉_筋肉左_表示;
    		筋肉_筋肉右_表示 = e.筋肉_筋肉右_表示;
    		筋肉_筋上左_表示 = e.筋肉_筋上左_表示;
    		筋肉_筋上右_表示 = e.筋肉_筋上右_表示;
    		筋肉_筋下左_表示 = e.筋肉_筋下左_表示;
    		筋肉_筋下右_表示 = e.筋肉_筋下右_表示;
    		臍_表示 = e.臍_表示;
    		紋柄_紋左_紋1_表示 = e.紋柄_紋左_紋1_表示;
    		紋柄_紋左_紋2_表示 = e.紋柄_紋左_紋2_表示;
    		紋柄_紋左_紋3_表示 = e.紋柄_紋左_紋3_表示;
    		紋柄_紋右_紋1_表示 = e.紋柄_紋右_紋1_表示;
    		紋柄_紋右_紋2_表示 = e.紋柄_紋右_紋2_表示;
    		紋柄_紋右_紋3_表示 = e.紋柄_紋右_紋3_表示;
    		虎柄_虎左_表示 = e.虎柄_虎左_表示;
    		虎柄_虎右_表示 = e.虎柄_虎右_表示;
    		竜性_中_鱗1_表示 = e.竜性_中_鱗1_表示;
    		竜性_中_鱗2_表示 = e.竜性_中_鱗2_表示;
    		竜性_中_鱗3_表示 = e.竜性_中_鱗3_表示;
    		竜性_中_鱗4_表示 = e.竜性_中_鱗4_表示;
    		竜性_左_鱗1_表示 = e.竜性_左_鱗1_表示;
    		竜性_左_鱗2_表示 = e.竜性_左_鱗2_表示;
    		竜性_右_鱗1_表示 = e.竜性_右_鱗1_表示;
    		竜性_右_鱗2_表示 = e.竜性_右_鱗2_表示;
    		欠損 = e.欠損;
    		筋肉 = e.筋肉;
    		拘束 = e.拘束;
    		if (!e.表示)
    		{
    			表示 = false;
    		}
    		Ele f;
    		if (e.腿左_接続.Count > 0)
    		{
    			腿左_接続 = e.腿左_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足腰2;
    				f.ConnectionType = ConnectionInfo.四足腰_腿左_接続;
    				f.接続(四足腰2.腿左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.腿右_接続.Count > 0)
    		{
    			腿右_接続 = e.腿右_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足腰2;
    				f.ConnectionType = ConnectionInfo.四足腰_腿右_接続;
    				f.接続(四足腰2.腿右_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.膣基_接続.Count > 0)
    		{
    			膣基_接続 = e.膣基_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足腰2;
    				f.ConnectionType = ConnectionInfo.四足腰_膣基_接続;
    				f.接続(四足腰2.膣基_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.肛門_接続.Count > 0)
    		{
    			肛門_接続 = e.肛門_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足腰2;
    				f.ConnectionType = ConnectionInfo.四足腰_肛門_接続;
    				f.接続(四足腰2.肛門_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.尾_接続.Count > 0)
    		{
    			尾_接続 = e.尾_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足腰2;
    				f.ConnectionType = ConnectionInfo.四足腰_尾_接続;
    				f.接続(四足腰2.尾_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.半身_接続.Count > 0)
    		{
    			半身_接続 = e.半身_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足腰2;
    				f.ConnectionType = ConnectionInfo.四足腰_半身_接続;
    				f.接続(四足腰2.半身_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.上着_接続.Count > 0)
    		{
    			上着_接続 = e.上着_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足腰2;
    				f.ConnectionType = ConnectionInfo.四足腰_上着_接続;
    				f.接続(四足腰2.上着_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.肌_接続.Count > 0)
    		{
    			肌_接続 = e.肌_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足腰2;
    				f.ConnectionType = ConnectionInfo.四足腰_肌_接続;
    				f.接続(四足腰2.肌_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.翼左_接続.Count > 0)
    		{
    			翼左_接続 = e.翼左_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足腰2;
    				f.ConnectionType = ConnectionInfo.四足腰_翼左_接続;
    				f.接続(四足腰2.翼左_接続点);
    				return f;
    			}).ToArray();
    		}
    		if (e.翼右_接続.Count > 0)
    		{
    			翼右_接続 = e.翼右_接続.Select(delegate(EleD g)
    			{
    				f = g.GetEle(DisUnit, Med, 体配色);
    				f.Par = 四足腰2;
    				f.ConnectionType = ConnectionInfo.四足腰_翼右_接続;
    				f.接続(四足腰2.翼右_接続点);
    				return f;
    			}).ToArray();
    		}
    		base.配色指定 = 配色指定;
    		配色(体配色);
    		X0Y0_腰CP = new ColorP(X0Y0_腰, 腰CD, DisUnit, abj: true);
    		X0Y0_股CP = new ColorP(X0Y0_股, 股CD, DisUnit, abj: false);
    		X0Y0_下腹CP = new ColorP(X0Y0_下腹, 下腹CD, DisUnit, abj: false);
    		X0Y0_腰皺CP = new ColorP(X0Y0_腰皺, 腰皺CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉下CP = new ColorP(X0Y0_筋肉_筋肉下, 筋肉_筋肉下CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉左CP = new ColorP(X0Y0_筋肉_筋肉左, 筋肉_筋肉左CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋肉右CP = new ColorP(X0Y0_筋肉_筋肉右, 筋肉_筋肉右CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋上左CP = new ColorP(X0Y0_筋肉_筋上左, 筋肉_筋上左CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋上右CP = new ColorP(X0Y0_筋肉_筋上右, 筋肉_筋上右CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋下左CP = new ColorP(X0Y0_筋肉_筋下左, 筋肉_筋下左CD, DisUnit, abj: false);
    		X0Y0_筋肉_筋下右CP = new ColorP(X0Y0_筋肉_筋下右, 筋肉_筋下右CD, DisUnit, abj: false);
    		X0Y0_臍CP = new ColorP(X0Y0_臍, 臍CD, DisUnit, abj: false);
    		X0Y0_紋柄_紋左_紋1CP = new ColorP(X0Y0_紋柄_紋左_紋1, 紋柄_紋左_紋1CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋左_紋2CP = new ColorP(X0Y0_紋柄_紋左_紋2, 紋柄_紋左_紋2CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋左_紋3CP = new ColorP(X0Y0_紋柄_紋左_紋3, 紋柄_紋左_紋3CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋右_紋1CP = new ColorP(X0Y0_紋柄_紋右_紋1, 紋柄_紋右_紋1CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋右_紋2CP = new ColorP(X0Y0_紋柄_紋右_紋2, 紋柄_紋右_紋2CD, DisUnit, abj: true);
    		X0Y0_紋柄_紋右_紋3CP = new ColorP(X0Y0_紋柄_紋右_紋3, 紋柄_紋右_紋3CD, DisUnit, abj: true);
    		X0Y0_虎柄_虎左CP = new ColorP(X0Y0_虎柄_虎左, 虎柄_虎左CD, DisUnit, abj: true);
    		X0Y0_虎柄_虎右CP = new ColorP(X0Y0_虎柄_虎右, 虎柄_虎右CD, DisUnit, abj: true);
    		X0Y0_竜性_中_鱗1CP = new ColorP(X0Y0_竜性_中_鱗1, 竜性_中_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_中_鱗2CP = new ColorP(X0Y0_竜性_中_鱗2, 竜性_中_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_中_鱗3CP = new ColorP(X0Y0_竜性_中_鱗3, 竜性_中_鱗3CD, DisUnit, abj: true);
    		X0Y0_竜性_中_鱗4CP = new ColorP(X0Y0_竜性_中_鱗4, 竜性_中_鱗4CD, DisUnit, abj: true);
    		X0Y0_竜性_左_鱗1CP = new ColorP(X0Y0_竜性_左_鱗1, 竜性_左_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_左_鱗2CP = new ColorP(X0Y0_竜性_左_鱗2, 竜性_左_鱗2CD, DisUnit, abj: true);
    		X0Y0_竜性_右_鱗1CP = new ColorP(X0Y0_竜性_右_鱗1, 竜性_右_鱗1CD, DisUnit, abj: true);
    		X0Y0_竜性_右_鱗2CP = new ColorP(X0Y0_竜性_右_鱗2, 竜性_右_鱗2CD, DisUnit, abj: true);
    		X0Y1_腰CP = new ColorP(X0Y1_腰, 腰CD, DisUnit, abj: true);
    		X0Y1_股CP = new ColorP(X0Y1_股, 股CD, DisUnit, abj: false);
    		X0Y1_下腹CP = new ColorP(X0Y1_下腹, 下腹CD, DisUnit, abj: false);
    		X0Y1_腰皺CP = new ColorP(X0Y1_腰皺, 腰皺CD, DisUnit, abj: false);
    		X0Y1_筋肉_筋肉下CP = new ColorP(X0Y1_筋肉_筋肉下, 筋肉_筋肉下CD, DisUnit, abj: false);
    		X0Y1_筋肉_筋肉左CP = new ColorP(X0Y1_筋肉_筋肉左, 筋肉_筋肉左CD, DisUnit, abj: false);
    		X0Y1_筋肉_筋肉右CP = new ColorP(X0Y1_筋肉_筋肉右, 筋肉_筋肉右CD, DisUnit, abj: false);
    		X0Y1_筋肉_筋上左CP = new ColorP(X0Y1_筋肉_筋上左, 筋肉_筋上左CD, DisUnit, abj: false);
    		X0Y1_筋肉_筋上右CP = new ColorP(X0Y1_筋肉_筋上右, 筋肉_筋上右CD, DisUnit, abj: false);
    		X0Y1_筋肉_筋下左CP = new ColorP(X0Y1_筋肉_筋下左, 筋肉_筋下左CD, DisUnit, abj: false);
    		X0Y1_筋肉_筋下右CP = new ColorP(X0Y1_筋肉_筋下右, 筋肉_筋下右CD, DisUnit, abj: false);
    		X0Y1_臍CP = new ColorP(X0Y1_臍, 臍CD, DisUnit, abj: false);
    		X0Y1_紋柄_紋左_紋1CP = new ColorP(X0Y1_紋柄_紋左_紋1, 紋柄_紋左_紋1CD, DisUnit, abj: true);
    		X0Y1_紋柄_紋左_紋2CP = new ColorP(X0Y1_紋柄_紋左_紋2, 紋柄_紋左_紋2CD, DisUnit, abj: true);
    		X0Y1_紋柄_紋左_紋3CP = new ColorP(X0Y1_紋柄_紋左_紋3, 紋柄_紋左_紋3CD, DisUnit, abj: true);
    		X0Y1_紋柄_紋右_紋1CP = new ColorP(X0Y1_紋柄_紋右_紋1, 紋柄_紋右_紋1CD, DisUnit, abj: true);
    		X0Y1_紋柄_紋右_紋2CP = new ColorP(X0Y1_紋柄_紋右_紋2, 紋柄_紋右_紋2CD, DisUnit, abj: true);
    		X0Y1_紋柄_紋右_紋3CP = new ColorP(X0Y1_紋柄_紋右_紋3, 紋柄_紋右_紋3CD, DisUnit, abj: true);
    		X0Y1_虎柄_虎左CP = new ColorP(X0Y1_虎柄_虎左, 虎柄_虎左CD, DisUnit, abj: true);
    		X0Y1_虎柄_虎右CP = new ColorP(X0Y1_虎柄_虎右, 虎柄_虎右CD, DisUnit, abj: true);
    		X0Y1_竜性_中_鱗1CP = new ColorP(X0Y1_竜性_中_鱗1, 竜性_中_鱗1CD, DisUnit, abj: true);
    		X0Y1_竜性_中_鱗2CP = new ColorP(X0Y1_竜性_中_鱗2, 竜性_中_鱗2CD, DisUnit, abj: true);
    		X0Y1_竜性_中_鱗3CP = new ColorP(X0Y1_竜性_中_鱗3, 竜性_中_鱗3CD, DisUnit, abj: true);
    		X0Y1_竜性_中_鱗4CP = new ColorP(X0Y1_竜性_中_鱗4, 竜性_中_鱗4CD, DisUnit, abj: true);
    		X0Y1_竜性_左_鱗1CP = new ColorP(X0Y1_竜性_左_鱗1, 竜性_左_鱗1CD, DisUnit, abj: true);
    		X0Y1_竜性_左_鱗2CP = new ColorP(X0Y1_竜性_左_鱗2, 竜性_左_鱗2CD, DisUnit, abj: true);
    		X0Y1_竜性_右_鱗1CP = new ColorP(X0Y1_竜性_右_鱗1, 竜性_右_鱗1CD, DisUnit, abj: true);
    		X0Y1_竜性_右_鱗2CP = new ColorP(X0Y1_竜性_右_鱗2, 竜性_右_鱗2CD, DisUnit, abj: true);
    		X0Y2_腰CP = new ColorP(X0Y2_腰, 腰CD, DisUnit, abj: true);
    		X0Y2_股CP = new ColorP(X0Y2_股, 股CD, DisUnit, abj: false);
    		X0Y2_下腹CP = new ColorP(X0Y2_下腹, 下腹CD, DisUnit, abj: false);
    		X0Y2_腰皺CP = new ColorP(X0Y2_腰皺, 腰皺CD, DisUnit, abj: false);
    		X0Y2_筋肉_筋肉下CP = new ColorP(X0Y2_筋肉_筋肉下, 筋肉_筋肉下CD, DisUnit, abj: false);
    		X0Y2_筋肉_筋肉左CP = new ColorP(X0Y2_筋肉_筋肉左, 筋肉_筋肉左CD, DisUnit, abj: false);
    		X0Y2_筋肉_筋肉右CP = new ColorP(X0Y2_筋肉_筋肉右, 筋肉_筋肉右CD, DisUnit, abj: false);
    		X0Y2_筋肉_筋上左CP = new ColorP(X0Y2_筋肉_筋上左, 筋肉_筋上左CD, DisUnit, abj: false);
    		X0Y2_筋肉_筋上右CP = new ColorP(X0Y2_筋肉_筋上右, 筋肉_筋上右CD, DisUnit, abj: false);
    		X0Y2_筋肉_筋下左CP = new ColorP(X0Y2_筋肉_筋下左, 筋肉_筋下左CD, DisUnit, abj: false);
    		X0Y2_筋肉_筋下右CP = new ColorP(X0Y2_筋肉_筋下右, 筋肉_筋下右CD, DisUnit, abj: false);
    		X0Y2_臍CP = new ColorP(X0Y2_臍, 臍CD, DisUnit, abj: false);
    		X0Y2_紋柄_紋左_紋1CP = new ColorP(X0Y2_紋柄_紋左_紋1, 紋柄_紋左_紋1CD, DisUnit, abj: true);
    		X0Y2_紋柄_紋左_紋2CP = new ColorP(X0Y2_紋柄_紋左_紋2, 紋柄_紋左_紋2CD, DisUnit, abj: true);
    		X0Y2_紋柄_紋左_紋3CP = new ColorP(X0Y2_紋柄_紋左_紋3, 紋柄_紋左_紋3CD, DisUnit, abj: true);
    		X0Y2_紋柄_紋右_紋1CP = new ColorP(X0Y2_紋柄_紋右_紋1, 紋柄_紋右_紋1CD, DisUnit, abj: true);
    		X0Y2_紋柄_紋右_紋2CP = new ColorP(X0Y2_紋柄_紋右_紋2, 紋柄_紋右_紋2CD, DisUnit, abj: true);
    		X0Y2_紋柄_紋右_紋3CP = new ColorP(X0Y2_紋柄_紋右_紋3, 紋柄_紋右_紋3CD, DisUnit, abj: true);
    		X0Y2_虎柄_虎左CP = new ColorP(X0Y2_虎柄_虎左, 虎柄_虎左CD, DisUnit, abj: true);
    		X0Y2_虎柄_虎右CP = new ColorP(X0Y2_虎柄_虎右, 虎柄_虎右CD, DisUnit, abj: true);
    		X0Y2_竜性_中_鱗1CP = new ColorP(X0Y2_竜性_中_鱗1, 竜性_中_鱗1CD, DisUnit, abj: true);
    		X0Y2_竜性_中_鱗2CP = new ColorP(X0Y2_竜性_中_鱗2, 竜性_中_鱗2CD, DisUnit, abj: true);
    		X0Y2_竜性_中_鱗3CP = new ColorP(X0Y2_竜性_中_鱗3, 竜性_中_鱗3CD, DisUnit, abj: true);
    		X0Y2_竜性_中_鱗4CP = new ColorP(X0Y2_竜性_中_鱗4, 竜性_中_鱗4CD, DisUnit, abj: true);
    		X0Y2_竜性_左_鱗1CP = new ColorP(X0Y2_竜性_左_鱗1, 竜性_左_鱗1CD, DisUnit, abj: true);
    		X0Y2_竜性_左_鱗2CP = new ColorP(X0Y2_竜性_左_鱗2, 竜性_左_鱗2CD, DisUnit, abj: true);
    		X0Y2_竜性_右_鱗1CP = new ColorP(X0Y2_竜性_右_鱗1, 竜性_右_鱗1CD, DisUnit, abj: true);
    		X0Y2_竜性_右_鱗2CP = new ColorP(X0Y2_竜性_右_鱗2, 竜性_右_鱗2CD, DisUnit, abj: true);
    		X0Y3_腰CP = new ColorP(X0Y3_腰, 腰CD, DisUnit, abj: true);
    		X0Y3_股CP = new ColorP(X0Y3_股, 股CD, DisUnit, abj: false);
    		X0Y3_下腹CP = new ColorP(X0Y3_下腹, 下腹CD, DisUnit, abj: false);
    		X0Y3_腰皺CP = new ColorP(X0Y3_腰皺, 腰皺CD, DisUnit, abj: false);
    		X0Y3_筋肉_筋肉下CP = new ColorP(X0Y3_筋肉_筋肉下, 筋肉_筋肉下CD, DisUnit, abj: false);
    		X0Y3_筋肉_筋肉左CP = new ColorP(X0Y3_筋肉_筋肉左, 筋肉_筋肉左CD, DisUnit, abj: false);
    		X0Y3_筋肉_筋肉右CP = new ColorP(X0Y3_筋肉_筋肉右, 筋肉_筋肉右CD, DisUnit, abj: false);
    		X0Y3_筋肉_筋上左CP = new ColorP(X0Y3_筋肉_筋上左, 筋肉_筋上左CD, DisUnit, abj: false);
    		X0Y3_筋肉_筋上右CP = new ColorP(X0Y3_筋肉_筋上右, 筋肉_筋上右CD, DisUnit, abj: false);
    		X0Y3_筋肉_筋下左CP = new ColorP(X0Y3_筋肉_筋下左, 筋肉_筋下左CD, DisUnit, abj: false);
    		X0Y3_筋肉_筋下右CP = new ColorP(X0Y3_筋肉_筋下右, 筋肉_筋下右CD, DisUnit, abj: false);
    		X0Y3_臍CP = new ColorP(X0Y3_臍, 臍CD, DisUnit, abj: false);
    		X0Y3_紋柄_紋左_紋1CP = new ColorP(X0Y3_紋柄_紋左_紋1, 紋柄_紋左_紋1CD, DisUnit, abj: true);
    		X0Y3_紋柄_紋左_紋2CP = new ColorP(X0Y3_紋柄_紋左_紋2, 紋柄_紋左_紋2CD, DisUnit, abj: true);
    		X0Y3_紋柄_紋左_紋3CP = new ColorP(X0Y3_紋柄_紋左_紋3, 紋柄_紋左_紋3CD, DisUnit, abj: true);
    		X0Y3_紋柄_紋右_紋1CP = new ColorP(X0Y3_紋柄_紋右_紋1, 紋柄_紋右_紋1CD, DisUnit, abj: true);
    		X0Y3_紋柄_紋右_紋2CP = new ColorP(X0Y3_紋柄_紋右_紋2, 紋柄_紋右_紋2CD, DisUnit, abj: true);
    		X0Y3_紋柄_紋右_紋3CP = new ColorP(X0Y3_紋柄_紋右_紋3, 紋柄_紋右_紋3CD, DisUnit, abj: true);
    		X0Y3_虎柄_虎左CP = new ColorP(X0Y3_虎柄_虎左, 虎柄_虎左CD, DisUnit, abj: true);
    		X0Y3_虎柄_虎右CP = new ColorP(X0Y3_虎柄_虎右, 虎柄_虎右CD, DisUnit, abj: true);
    		X0Y3_竜性_中_鱗1CP = new ColorP(X0Y3_竜性_中_鱗1, 竜性_中_鱗1CD, DisUnit, abj: true);
    		X0Y3_竜性_中_鱗2CP = new ColorP(X0Y3_竜性_中_鱗2, 竜性_中_鱗2CD, DisUnit, abj: true);
    		X0Y3_竜性_中_鱗3CP = new ColorP(X0Y3_竜性_中_鱗3, 竜性_中_鱗3CD, DisUnit, abj: true);
    		X0Y3_竜性_中_鱗4CP = new ColorP(X0Y3_竜性_中_鱗4, 竜性_中_鱗4CD, DisUnit, abj: true);
    		X0Y3_竜性_左_鱗1CP = new ColorP(X0Y3_竜性_左_鱗1, 竜性_左_鱗1CD, DisUnit, abj: true);
    		X0Y3_竜性_左_鱗2CP = new ColorP(X0Y3_竜性_左_鱗2, 竜性_左_鱗2CD, DisUnit, abj: true);
    		X0Y3_竜性_右_鱗1CP = new ColorP(X0Y3_竜性_右_鱗1, 竜性_右_鱗1CD, DisUnit, abj: true);
    		X0Y3_竜性_右_鱗2CP = new ColorP(X0Y3_竜性_右_鱗2, 竜性_右_鱗2CD, DisUnit, abj: true);
    		X0Y4_腰CP = new ColorP(X0Y4_腰, 腰CD, DisUnit, abj: true);
    		X0Y4_股CP = new ColorP(X0Y4_股, 股CD, DisUnit, abj: false);
    		X0Y4_下腹CP = new ColorP(X0Y4_下腹, 下腹CD, DisUnit, abj: false);
    		X0Y4_腰皺CP = new ColorP(X0Y4_腰皺, 腰皺CD, DisUnit, abj: false);
    		X0Y4_筋肉_筋肉下CP = new ColorP(X0Y4_筋肉_筋肉下, 筋肉_筋肉下CD, DisUnit, abj: false);
    		X0Y4_筋肉_筋肉左CP = new ColorP(X0Y4_筋肉_筋肉左, 筋肉_筋肉左CD, DisUnit, abj: false);
    		X0Y4_筋肉_筋肉右CP = new ColorP(X0Y4_筋肉_筋肉右, 筋肉_筋肉右CD, DisUnit, abj: false);
    		X0Y4_筋肉_筋上左CP = new ColorP(X0Y4_筋肉_筋上左, 筋肉_筋上左CD, DisUnit, abj: false);
    		X0Y4_筋肉_筋上右CP = new ColorP(X0Y4_筋肉_筋上右, 筋肉_筋上右CD, DisUnit, abj: false);
    		X0Y4_筋肉_筋下左CP = new ColorP(X0Y4_筋肉_筋下左, 筋肉_筋下左CD, DisUnit, abj: false);
    		X0Y4_筋肉_筋下右CP = new ColorP(X0Y4_筋肉_筋下右, 筋肉_筋下右CD, DisUnit, abj: false);
    		X0Y4_臍CP = new ColorP(X0Y4_臍, 臍CD, DisUnit, abj: false);
    		X0Y4_紋柄_紋左_紋1CP = new ColorP(X0Y4_紋柄_紋左_紋1, 紋柄_紋左_紋1CD, DisUnit, abj: true);
    		X0Y4_紋柄_紋左_紋2CP = new ColorP(X0Y4_紋柄_紋左_紋2, 紋柄_紋左_紋2CD, DisUnit, abj: true);
    		X0Y4_紋柄_紋左_紋3CP = new ColorP(X0Y4_紋柄_紋左_紋3, 紋柄_紋左_紋3CD, DisUnit, abj: true);
    		X0Y4_紋柄_紋右_紋1CP = new ColorP(X0Y4_紋柄_紋右_紋1, 紋柄_紋右_紋1CD, DisUnit, abj: true);
    		X0Y4_紋柄_紋右_紋2CP = new ColorP(X0Y4_紋柄_紋右_紋2, 紋柄_紋右_紋2CD, DisUnit, abj: true);
    		X0Y4_紋柄_紋右_紋3CP = new ColorP(X0Y4_紋柄_紋右_紋3, 紋柄_紋右_紋3CD, DisUnit, abj: true);
    		X0Y4_虎柄_虎左CP = new ColorP(X0Y4_虎柄_虎左, 虎柄_虎左CD, DisUnit, abj: true);
    		X0Y4_虎柄_虎右CP = new ColorP(X0Y4_虎柄_虎右, 虎柄_虎右CD, DisUnit, abj: true);
    		X0Y4_竜性_中_鱗1CP = new ColorP(X0Y4_竜性_中_鱗1, 竜性_中_鱗1CD, DisUnit, abj: true);
    		X0Y4_竜性_中_鱗2CP = new ColorP(X0Y4_竜性_中_鱗2, 竜性_中_鱗2CD, DisUnit, abj: true);
    		X0Y4_竜性_中_鱗3CP = new ColorP(X0Y4_竜性_中_鱗3, 竜性_中_鱗3CD, DisUnit, abj: true);
    		X0Y4_竜性_中_鱗4CP = new ColorP(X0Y4_竜性_中_鱗4, 竜性_中_鱗4CD, DisUnit, abj: true);
    		X0Y4_竜性_左_鱗1CP = new ColorP(X0Y4_竜性_左_鱗1, 竜性_左_鱗1CD, DisUnit, abj: true);
    		X0Y4_竜性_左_鱗2CP = new ColorP(X0Y4_竜性_左_鱗2, 竜性_左_鱗2CD, DisUnit, abj: true);
    		X0Y4_竜性_右_鱗1CP = new ColorP(X0Y4_竜性_右_鱗1, 竜性_右_鱗1CD, DisUnit, abj: true);
    		X0Y4_竜性_右_鱗2CP = new ColorP(X0Y4_竜性_右_鱗2, 竜性_右_鱗2CD, DisUnit, abj: true);
    		筋肉濃度 = e.筋肉濃度;
    		濃度 = e.濃度;
    		尺度YB = 0.96;
    		double num = 1.0025;
    		X0Y0_臍.BasePointBase = new Vector2D(X0Y0_臍.BasePointBase.X, 0.363998381176966);
    		X0Y1_臍.BasePointBase = new Vector2D(X0Y1_臍.BasePointBase.X, 0.363099175689868);
    		X0Y2_臍.BasePointBase = new Vector2D(X0Y2_臍.BasePointBase.X, 0.362199970202771);
    		X0Y3_臍.BasePointBase = new Vector2D(X0Y3_臍.BasePointBase.X, 0.361300764715674);
    		X0Y4_臍.BasePointBase = new Vector2D(X0Y4_臍.BasePointBase.X, 0.360401559228577);
    		num = 1.5;
    		X0Y0_臍.SizeBase *= num;
    		X0Y1_臍.SizeBase *= num;
    		X0Y2_臍.SizeBase *= num;
    		X0Y3_臍.SizeBase *= num;
    		X0Y4_臍.SizeBase *= num;
    		num = 0.6;
    		X0Y0_臍.SizeXBase *= num;
    		X0Y1_臍.SizeXBase *= num;
    		X0Y2_臍.SizeXBase *= num;
    		X0Y3_臍.SizeXBase *= num;
    		X0Y4_臍.SizeXBase *= num;
    	}

    	public override void 色更新()
    	{
    		switch (本体.IndexY)
    		{
    		case 0:
    			X0Y0_腰CP.Update();
    			X0Y0_股CP.Update();
    			X0Y0_下腹CP.Update();
    			X0Y0_腰皺CP.Update();
    			X0Y0_筋肉_筋肉下CP.Update();
    			X0Y0_筋肉_筋肉左CP.Update();
    			X0Y0_筋肉_筋肉右CP.Update();
    			X0Y0_筋肉_筋上左CP.Update();
    			X0Y0_筋肉_筋上右CP.Update();
    			X0Y0_筋肉_筋下左CP.Update();
    			X0Y0_筋肉_筋下右CP.Update();
    			X0Y0_臍CP.Update();
    			X0Y0_紋柄_紋左_紋1CP.Update();
    			X0Y0_紋柄_紋左_紋2CP.Update();
    			X0Y0_紋柄_紋左_紋3CP.Update();
    			X0Y0_紋柄_紋右_紋1CP.Update();
    			X0Y0_紋柄_紋右_紋2CP.Update();
    			X0Y0_紋柄_紋右_紋3CP.Update();
    			X0Y0_虎柄_虎左CP.Update();
    			X0Y0_虎柄_虎右CP.Update();
    			X0Y0_竜性_中_鱗1CP.Update();
    			X0Y0_竜性_中_鱗2CP.Update();
    			X0Y0_竜性_中_鱗3CP.Update();
    			X0Y0_竜性_中_鱗4CP.Update();
    			X0Y0_竜性_左_鱗1CP.Update();
    			X0Y0_竜性_左_鱗2CP.Update();
    			X0Y0_竜性_右_鱗1CP.Update();
    			X0Y0_竜性_右_鱗2CP.Update();
    			break;
    		case 1:
    			X0Y1_腰CP.Update();
    			X0Y1_股CP.Update();
    			X0Y1_下腹CP.Update();
    			X0Y1_腰皺CP.Update();
    			X0Y1_筋肉_筋肉下CP.Update();
    			X0Y1_筋肉_筋肉左CP.Update();
    			X0Y1_筋肉_筋肉右CP.Update();
    			X0Y1_筋肉_筋上左CP.Update();
    			X0Y1_筋肉_筋上右CP.Update();
    			X0Y1_筋肉_筋下左CP.Update();
    			X0Y1_筋肉_筋下右CP.Update();
    			X0Y1_臍CP.Update();
    			X0Y1_紋柄_紋左_紋1CP.Update();
    			X0Y1_紋柄_紋左_紋2CP.Update();
    			X0Y1_紋柄_紋左_紋3CP.Update();
    			X0Y1_紋柄_紋右_紋1CP.Update();
    			X0Y1_紋柄_紋右_紋2CP.Update();
    			X0Y1_紋柄_紋右_紋3CP.Update();
    			X0Y1_虎柄_虎左CP.Update();
    			X0Y1_虎柄_虎右CP.Update();
    			X0Y1_竜性_中_鱗1CP.Update();
    			X0Y1_竜性_中_鱗2CP.Update();
    			X0Y1_竜性_中_鱗3CP.Update();
    			X0Y1_竜性_中_鱗4CP.Update();
    			X0Y1_竜性_左_鱗1CP.Update();
    			X0Y1_竜性_左_鱗2CP.Update();
    			X0Y1_竜性_右_鱗1CP.Update();
    			X0Y1_竜性_右_鱗2CP.Update();
    			break;
    		case 2:
    			X0Y2_腰CP.Update();
    			X0Y2_股CP.Update();
    			X0Y2_下腹CP.Update();
    			X0Y2_腰皺CP.Update();
    			X0Y2_筋肉_筋肉下CP.Update();
    			X0Y2_筋肉_筋肉左CP.Update();
    			X0Y2_筋肉_筋肉右CP.Update();
    			X0Y2_筋肉_筋上左CP.Update();
    			X0Y2_筋肉_筋上右CP.Update();
    			X0Y2_筋肉_筋下左CP.Update();
    			X0Y2_筋肉_筋下右CP.Update();
    			X0Y2_臍CP.Update();
    			X0Y2_紋柄_紋左_紋1CP.Update();
    			X0Y2_紋柄_紋左_紋2CP.Update();
    			X0Y2_紋柄_紋左_紋3CP.Update();
    			X0Y2_紋柄_紋右_紋1CP.Update();
    			X0Y2_紋柄_紋右_紋2CP.Update();
    			X0Y2_紋柄_紋右_紋3CP.Update();
    			X0Y2_虎柄_虎左CP.Update();
    			X0Y2_虎柄_虎右CP.Update();
    			X0Y2_竜性_中_鱗1CP.Update();
    			X0Y2_竜性_中_鱗2CP.Update();
    			X0Y2_竜性_中_鱗3CP.Update();
    			X0Y2_竜性_中_鱗4CP.Update();
    			X0Y2_竜性_左_鱗1CP.Update();
    			X0Y2_竜性_左_鱗2CP.Update();
    			X0Y2_竜性_右_鱗1CP.Update();
    			X0Y2_竜性_右_鱗2CP.Update();
    			break;
    		case 3:
    			X0Y3_腰CP.Update();
    			X0Y3_股CP.Update();
    			X0Y3_下腹CP.Update();
    			X0Y3_腰皺CP.Update();
    			X0Y3_筋肉_筋肉下CP.Update();
    			X0Y3_筋肉_筋肉左CP.Update();
    			X0Y3_筋肉_筋肉右CP.Update();
    			X0Y3_筋肉_筋上左CP.Update();
    			X0Y3_筋肉_筋上右CP.Update();
    			X0Y3_筋肉_筋下左CP.Update();
    			X0Y3_筋肉_筋下右CP.Update();
    			X0Y3_臍CP.Update();
    			X0Y3_紋柄_紋左_紋1CP.Update();
    			X0Y3_紋柄_紋左_紋2CP.Update();
    			X0Y3_紋柄_紋左_紋3CP.Update();
    			X0Y3_紋柄_紋右_紋1CP.Update();
    			X0Y3_紋柄_紋右_紋2CP.Update();
    			X0Y3_紋柄_紋右_紋3CP.Update();
    			X0Y3_虎柄_虎左CP.Update();
    			X0Y3_虎柄_虎右CP.Update();
    			X0Y3_竜性_中_鱗1CP.Update();
    			X0Y3_竜性_中_鱗2CP.Update();
    			X0Y3_竜性_中_鱗3CP.Update();
    			X0Y3_竜性_中_鱗4CP.Update();
    			X0Y3_竜性_左_鱗1CP.Update();
    			X0Y3_竜性_左_鱗2CP.Update();
    			X0Y3_竜性_右_鱗1CP.Update();
    			X0Y3_竜性_右_鱗2CP.Update();
    			break;
    		default:
    			X0Y4_腰CP.Update();
    			X0Y4_股CP.Update();
    			X0Y4_下腹CP.Update();
    			X0Y4_腰皺CP.Update();
    			X0Y4_筋肉_筋肉下CP.Update();
    			X0Y4_筋肉_筋肉左CP.Update();
    			X0Y4_筋肉_筋肉右CP.Update();
    			X0Y4_筋肉_筋上左CP.Update();
    			X0Y4_筋肉_筋上右CP.Update();
    			X0Y4_筋肉_筋下左CP.Update();
    			X0Y4_筋肉_筋下右CP.Update();
    			X0Y4_臍CP.Update();
    			X0Y4_紋柄_紋左_紋1CP.Update();
    			X0Y4_紋柄_紋左_紋2CP.Update();
    			X0Y4_紋柄_紋左_紋3CP.Update();
    			X0Y4_紋柄_紋右_紋1CP.Update();
    			X0Y4_紋柄_紋右_紋2CP.Update();
    			X0Y4_紋柄_紋右_紋3CP.Update();
    			X0Y4_虎柄_虎左CP.Update();
    			X0Y4_虎柄_虎右CP.Update();
    			X0Y4_竜性_中_鱗1CP.Update();
    			X0Y4_竜性_中_鱗2CP.Update();
    			X0Y4_竜性_中_鱗3CP.Update();
    			X0Y4_竜性_中_鱗4CP.Update();
    			X0Y4_竜性_左_鱗1CP.Update();
    			X0Y4_竜性_左_鱗2CP.Update();
    			X0Y4_竜性_右_鱗1CP.Update();
    			X0Y4_竜性_右_鱗2CP.Update();
    			break;
    		}
    	}

    	private void 配色(体配色 体配色)
    	{
    		switch (配色指定)
    		{
    		case 配色指定.N0:
    			配色N0(体配色);
    			break;
    		case 配色指定.T0:
    			配色T0(体配色);
    			break;
    		case 配色指定.T1:
    			配色T1(体配色);
    			break;
    		default:
    			配色N0(体配色);
    			break;
    		}
    	}

    	private void 配色N0(体配色 体配色)
    	{
    		腰CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		股CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		下腹CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		腰皺CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋上左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋上右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋下左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋下右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		臍CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		紋柄_紋左_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		虎柄_虎左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		虎柄_虎右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		竜性_中_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性_中_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性_中_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性_中_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性_左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    	}

    	private void 配色T0(体配色 体配色)
    	{
    		腰CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		股CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		下腹CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		腰皺CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋上左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋上右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋下左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋下右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		臍CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		紋柄_紋左_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		虎柄_虎左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		虎柄_虎右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		竜性_中_鱗1CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_中_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性_中_鱗3CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_中_鱗4CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性_左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    	}

    	private void 配色T1(体配色 体配色)
    	{
    		腰CD = new ColorD(ref Col.Black, ref 体配色.毛0O);
    		股CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		下腹CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		腰皺CD = new ColorD(ref 体配色.薄線, ref Color2.Empty);
    		筋肉_筋肉下CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋肉右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋上左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋上右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋下左CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		筋肉_筋下右CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		臍CD = new ColorD(ref 体配色.薄線, ref 体配色.毛0O);
    		紋柄_紋左_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋左_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋1CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋2CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		紋柄_紋右_紋3CD = new ColorD(ref Col.Empty, ref 体配色.紋O);
    		虎柄_虎左CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		虎柄_虎右CD = new ColorD(ref Col.Black, ref 体配色.刺青);
    		竜性_中_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性_中_鱗2CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_中_鱗3CD = new ColorD(ref Col.Black, ref 体配色.鱗1O);
    		竜性_中_鱗4CD = new ColorD(ref Col.Black, ref 体配色.刺青O);
    		竜性_左_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_左_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_右_鱗1CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    		竜性_右_鱗2CD = new ColorD(ref Col.Black, ref 体配色.鱗0O);
    	}
    }
}
