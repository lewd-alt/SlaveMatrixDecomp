using System.Collections.Generic;
using System.Drawing;

namespace _2DGAMELIB
{
    public class Labs
    {
    	private OrderedDictionary<string, Lab> labs = new OrderedDictionary<string, Lab>();

    	private Med Med;

    	private Are Are;

    	public Lab this[string Name] => labs[Name];

    	public Labs(Med Med, Are Are)
    	{
    		this.Med = Med;
    		this.Are = Are;
    	}

    	public void Add(string Name, Vector2D Position, double Size, double Width, Font Font, double TextSize, string Text, Color TextColor, Color ShadColor, Color BackColor, Color FramColor, bool Input)
    	{
    		labs.Add(Name, new Lab(Med, Are, Name, ref Position, Size, Width, Font, TextSize, Text, ref TextColor, ref ShadColor, ref BackColor, ref FramColor, Input));
    	}

    	public void Add(string Name, ref Vector2D Position, double Size, double Width, Font Font, double TextSize, string Text, ref Color TextColor, ref Color ShadColor, ref Color BackColor, ref Color FramColor, bool Input)
    	{
    		labs.Add(Name, new Lab(Med, Are, Name, ref Position, Size, Width, Font, TextSize, Text, ref TextColor, ref ShadColor, ref BackColor, ref FramColor, Input));
    	}

    	public void Double(ref Color HitColor)
    	{
    		using IEnumerator<Lab> enumerator = labs.Values.GetEnumerator();
    		while (enumerator.MoveNext() && !enumerator.Current.Double(ref HitColor))
    		{
    		}
    	}

    	public void Click(ref Color HitColor)
    	{
    		foreach (Lab value in labs.Values)
    		{
    			value.Click(ref HitColor);
    		}
    	}

    	public void SetHitColor(Med Med)
    	{
    		foreach (Lab value in labs.Values)
    		{
    			value.SetHitColor(Med);
    		}
    	}

    	public void Draw(Are Are)
    	{
    		foreach (Lab value in labs.Values)
    		{
    			Are.Draw(value.ParT);
    		}
    	}

    	public void Draw(AreM AreM)
    	{
    		foreach (Lab value in labs.Values)
    		{
    			AreM.Draw(value.ParT);
    		}
    	}

    	public void Dispose()
    	{
    		foreach (Lab value in labs.Values)
    		{
    			value.Dispose();
    		}
    	}
    }
}
