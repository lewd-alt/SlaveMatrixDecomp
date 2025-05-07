using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _2DGAMELIB
{
    public class Buts
    {
    	private OrderedDictionary<string, But> buts = new OrderedDictionary<string, But>();

    	public But this[string Name] => buts[Name];

    	public IEnumerable<But> EnumBut => buts.Values;

    	public void Add(string Name, But But)
    	{
    		buts.Add(Name, But);
    	}

    	public void Down(ref Color HitColor)
    	{
    		using IEnumerator<But> enumerator = buts.Values.GetEnumerator();
    		while (enumerator.MoveNext() && !enumerator.Current.Down(ref HitColor))
    		{
    		}
    	}

    	public void Up(ref Color HitColor)
    	{
    		using IEnumerator<But> enumerator = buts.Values.GetEnumerator();
    		while (enumerator.MoveNext() && !enumerator.Current.Up(ref HitColor))
    		{
    		}
    	}

    	public void Move(ref Color HitColor)
    	{
    		foreach (But value in buts.Values)
    		{
    			value.Move(ref HitColor);
    		}
    	}

    	public void Leave()
    	{
    		using IEnumerator<But> enumerator = buts.Values.GetEnumerator();
    		while (enumerator.MoveNext() && !enumerator.Current.Leave())
    		{
    		}
    	}

    	public void SetHitColor(Med Med)
    	{
    		foreach (But item in EnumBut)
    		{
    			item.SetHitColor(Med);
    		}
    	}

    	public void Draw(Are Are)
    	{
    		foreach (But value in buts.Values)
    		{
    			value.Draw(Are);
    		}
    	}

    	public void Draw(AreM AreM)
    	{
    		foreach (But value in buts.Values)
    		{
    			value.Draw(AreM);
    		}
    	}

    	public void Dispose()
    	{
    		foreach (But value in buts.Values)
    		{
    			value.Dispose();
    		}
    	}

    	public bool IsHit(Color hc)
    	{
    		return EnumBut.Any((But e) => e.Pars.Values.First().ToPar().HitColor == hc);
    	}
    }
}
