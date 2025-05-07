using System;

namespace _2DGAMELIB
{
    public class Mot : MotV
    {
    	public Action<Mot> Staing;

    	public Action<Mot> Runing;

    	public Action<Mot> Reaing;

    	public Action<Mot> Rouing;

    	public Action<Mot> Ending;

    	private bool run;

    	private bool rou;

    	public bool Run => run;

    	public Mot(double Min, double Max)
    		: base(Min, Max)
    	{
    	}

    	public new void GetValue(FPS FPS)
    	{
    		if (!run)
    		{
    			return;
    		}
    		base.GetValue(FPS);
    		if (Runing != null)
    		{
    			Runing(this);
    		}
    		if (Value == min)
    		{
    			if (rou && Rouing != null)
    			{
    				Rouing(this);
    			}
    			rou = false;
    		}
    		else if (Value == max)
    		{
    			if (Reaing != null)
    			{
    				Reaing(this);
    			}
    			rou = true;
    		}
    	}

    	public void Start()
    	{
    		if (Staing != null)
    		{
    			Staing(this);
    		}
    		run = true;
    	}

    	public void End()
    	{
    		run = false;
    		if (Ending != null)
    		{
    			Ending(this);
    		}
    		ResetValue();
    		rou = false;
    	}
    }
}
