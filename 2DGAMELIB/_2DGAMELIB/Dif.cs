using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Documents;

namespace _2DGAMELIB;

[Serializable]
public class Dif
{
	public string Tag = "";

	private List<Pars> parss = new List<Pars>();

	public List<Pars> Parss => parss;

	public int Count => parss.Count;

	public Pars this[int Index]
	{
		get
		{
			return parss[Index];
		}
		set
		{
			parss[Index] = value;
		}
	}

	public double PositionSize
	{
		set
		{
			foreach (Pars item in parss)
			{
				item.PositionSize = value;
			}
		}
	}

	public Vector2D PositionVector
	{
		set
		{
			foreach (Pars item in parss)
			{
				item.PositionVector = value;
			}
		}
	}

	public double AngleBase
	{
		set
		{
			foreach (Pars item in parss)
			{
				item.AngleBase = value;
			}
		}
	}

	public double AngleCont
	{
		set
		{
			foreach (Pars item in parss)
			{
				item.AngleCont = value;
			}
		}
	}

	public double SizeBase
	{
		set
		{
			foreach (Pars item in parss)
			{
				item.SizeBase = value;
			}
		}
	}

	public double SizeCont
	{
		set
		{
			foreach (Pars item in parss)
			{
				item.SizeCont = value;
			}
		}
	}

	public double SizeXBase
	{
		set
		{
			foreach (Pars item in parss)
			{
				item.SizeXBase = value;
			}
		}
	}

	public double SizeXCont
	{
		set
		{
			foreach (Pars item in parss)
			{
				item.SizeXCont = value;
			}
		}
	}

	public double SizeYBase
	{
		set
		{
			foreach (Pars item in parss)
			{
				item.SizeYBase = value;
			}
		}
	}

	public double SizeYCont
	{
		set
		{
			foreach (Pars item in parss)
			{
				item.SizeYCont = value;
			}
		}
	}

	public bool Dra
	{
		set
		{
			foreach (Pars item in parss)
			{
				item.Dra = value;
			}
		}
	}

	public bool Hit
	{
		set
		{
			foreach (Pars item in parss)
			{
				item.Hit = value;
			}
		}
	}

	public IEnumerable<Par> EnumAllPar()
	{
		foreach (Pars item in parss)
		{
			foreach (Par item2 in item.EnumAllPar())
			{
				yield return item2;
			}
		}
	}

	public void SetDefault()
	{
		foreach (Pars item in parss)
		{
			item.SetDefault();
		}
	}

	public Dif()
	{
	}

	public Dif(Dif Dif)
	{
		Copy(Dif);
	}

	private void Copy(Dif Dif)
	{
		Tag = Dif.Tag;
		foreach (Pars item in Dif.parss)
		{
			parss.Add(new Pars(item));
		}
	}

	public void Add(Pars Pars)
	{
		parss.Add(Pars);
	}

	public void Insert(int Index, Pars Pars)
	{
		parss.Insert(Index, Pars);
	}

	public void Remove(Pars Pars)
	{
		parss.Remove(Pars);
	}

	public void RemoveAt(int Index)
	{
		parss.RemoveAt(Index);
	}

	public void Draws(Are Are)
	{
		foreach (Pars item in parss)
		{
			Are.Draw(item);
		}
	}

	public void Draws(AreM AreM)
	{
		foreach (Pars item in parss)
		{
			AreM.Draw(item);
		}
	}

	public List<string> GetHitTags(ref Color HitColor)
	{
		List<string> list = new List<string>();
		foreach (Pars item in parss)
		{
			list.AddRange(item.GetHitTags(ref HitColor));
		}
		return list;
	}

	public List<Par> GetHitPars(ref Color HitColor)
	{
		List<Par> list = new List<Par>();
		foreach (Pars item in parss)
		{
			list.AddRange(item.GetHitPars(ref HitColor));
		}
		return list;
	}

	public bool IsHit(ref Color HitColor)
	{
		foreach (Pars item in parss)
		{
			if (item.IsHit(ref HitColor))
			{
				return true;
			}
		}
		return false;
	}

	public void ReverseX()
	{
		foreach (Pars item in parss)
		{
			item.ReverseX();
		}
	}

	public void ReverseY()
	{
		foreach (Pars item in parss)
		{
			item.ReverseY();
		}
	}

	public void Dispose()
	{
		foreach (Pars item in parss)
		{
			item.Dispose();
		}
	}
}
