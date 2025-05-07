using System;
using System.Collections.Generic;
using _2DGAMELIB;

namespace SlaveMatrix
{
    public class EleI : IDisposable
    {
    	public Vector2D Position = Dat.Vec2DZero;

    	public Vector2D PositionCont = Dat.Vec2DZero;

    	public Are Lay;

    	public bool Updatef = true;

    	public Action<Are> 描画処理;

    	public HashSet<Ele> ElesH;


    	public void AddRange(IEnumerable<Ele> es)
    	{
    		foreach (Ele e in es)
    		{
    			ElesH.Add(e);
    		}
    	}

    	public bool IsUpdate(Ele e)
    	{
    		if (Updatef)
    		{
    			return ElesH.Contains(e);
    		}
    		return false;
    	}

    	public EleI(Med Med)
    	{
    		Lay = new Are(Med.Unit, Med.Base.XRatio, Med.Base.YRatio, Med.Base.Size + 0.0025, Med.DisQuality, Med.HitAccuracy);
    		Lay.Setting();
    		ElesH = new HashSet<Ele>();
    	}

    	public void 描画(Are Are)
    	{
    		Vec.Add(ref Position, ref PositionCont, out Lay.Position);
    		Are.Draw(Lay);
    	}

    	public void Update()
    	{
    		if (Updatef)
    		{
    			Lay.Clear();
    			描画処理(Lay);
    			Updatef = false;
    		}
    	}

    	public void Dispose()
    	{
    		Lay.Dispose();
    	}

    	public bool IsHeavy()
    	{
    		if (!ElesH.IsEle<触手>())
    		{
    			return ElesH.IsEle<尾>();
    		}
    		return true;
    	}
    }
}
