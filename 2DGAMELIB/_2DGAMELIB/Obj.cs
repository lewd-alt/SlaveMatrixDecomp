using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;

namespace _2DGAMELIB;

[Serializable]
public class Obj
{
	public string Tag = "";

	public OrderedDictionary<string, Difs> Difss = new OrderedDictionary<string, Difs>();

	private Difs r;

	private JointsD jsd;

	public IEnumerable<string> Keys => Difss.Keys;

	public IEnumerable<Difs> Values => Difss.Values;

	public Difs this[string Name]
	{
		get
		{
			return Difss[Name];
		}
		set
		{
			Difss[Name] = value;
		}
	}

	public Difs this[int Index]
	{
		get
		{
			return Difss[Index];
		}
		set
		{
			Difss[Index] = value;
		}
	}

	public double PositionSize
	{
		set
		{
			foreach (Difs value2 in Difss.Values)
			{
				value2.PositionSize = value;
			}
		}
	}

	public Vector2D PositionVector
	{
		set
		{
			foreach (Difs value2 in Difss.Values)
			{
				value2.PositionVector = value;
			}
		}
	}

	public double AngleBase
	{
		set
		{
			foreach (Difs value2 in Difss.Values)
			{
				value2.AngleBase = value;
			}
		}
	}

	public double AngleCont
	{
		set
		{
			foreach (Difs value2 in Difss.Values)
			{
				value2.AngleCont = value;
			}
		}
	}

	public double SizeBase
	{
		set
		{
			foreach (Difs value2 in Difss.Values)
			{
				value2.SizeBase = value;
			}
		}
	}

	public double SizeCont
	{
		set
		{
			foreach (Difs value2 in Difss.Values)
			{
				value2.SizeCont = value;
			}
		}
	}

	public double SizeXBase
	{
		set
		{
			foreach (Difs value2 in Difss.Values)
			{
				value2.SizeXBase = value;
			}
		}
	}

	public double SizeXCont
	{
		set
		{
			foreach (Difs value2 in Difss.Values)
			{
				value2.SizeXCont = value;
			}
		}
	}

	public double SizeYBase
	{
		set
		{
			foreach (Difs value2 in Difss.Values)
			{
				value2.SizeYBase = value;
			}
		}
	}

	public double SizeYCont
	{
		set
		{
			foreach (Difs value2 in Difss.Values)
			{
				value2.SizeYCont = value;
			}
		}
	}

	public bool Dra
	{
		set
		{
			foreach (Difs value2 in Difss.Values)
			{
				value2.Dra = value;
			}
		}
	}

	public bool Hit
	{
		set
		{
			foreach (Difs value2 in Difss.Values)
			{
				value2.Hit = value;
			}
		}
	}

	public Difs JoinRoot => r;
	public IEnumerable<Par> EnumAllPar()
	{
		foreach (Difs value in Difss.Values)
		{
			foreach (Par item in value.EnumAllPar())
			{
				yield return item;
			}
		}
	}

	public void SetDefault()
	{
		foreach (Difs value in Difss.Values)
		{
			value.SetDefault();
		}
	}

	public Obj SetDefaultR()
	{
		foreach (Difs value in Difss.Values)
		{
			value.SetDefault();
		}
		return this;
	}

	public Obj()
	{
	}

	public Obj(Obj Obj)
	{
		Copy(Obj);
	}

	private void Copy(Obj Obj)
	{
		Tag = Obj.Tag;
		foreach (string key in Obj.Difss.Keys)
		{
			Difss.Add(key, new Difs(Obj.Difss[key]));
		}
	}

	public void Add(string Name, Difs Difs)
	{
		Difss.Add(Name, Difs);
	}

	public void Add(Difs Difs)
	{
		Difss.Add(Difs.Tag, Difs);
	}

	public void Insert(int Index, string Name, Difs Difs)
	{
		Difss.Insert(Index, Name, Difs);
	}

	public void Remove(string Name)
	{
		Difss.Remove(Name);
	}

	public void Draw(Are Are)
	{
		foreach (Difs value in Difss.Values)
		{
			value.Draw(Are);
		}
	}

	public void Draws(Are Are)
	{
		foreach (Difs value in Difss.Values)
		{
			value.Draws(Are);
		}
	}

	public void Draw(AreM AreM)
	{
		foreach (Difs value in Difss.Values)
		{
			value.Draw(AreM);
		}
	}

	public void Draws(AreM AreM)
	{
		foreach (Difs value in Difss.Values)
		{
			value.Draws(AreM);
		}
	}

	private Difs GetJoinRootDifs()
	{
		Difs[] array = Difss.Values.ToArray();
		if (array.Length <= 1)
		{
			return array.FirstOrDefault();
		}
		Par[] pa = EnumAllPar().ToArray();
		Difs[] array2 = array;
		Vector2D p;
		foreach (Difs difs in array2)
		{
			if (difs.EnumJoinRoot.All(delegate(Par p0)
			{
				p = p0.Position;
				return pa.All((Par p1) => p0 == p1 || p1.JP.All((Joi j) => !(p1.ToGlobal(j.Joint).DistanceSquared(p) <= Join.IdentityDistance)));
			}))
			{
				return difs;
			}
		}
		return array.First();
	}

	public void SetJoints()
	{
		Difs[] array = Difss.Values.ToArray();
		Difs[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i].SetJoints();
		}
		r = GetJoinRootDifs();
		if (r != null)
		{
			jsd = r.GetJointsD(array);
		}
	}

	public void SetJoints(string Name)
	{
		Difs[] array = Difss.Values.ToArray();
		Difs[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i].SetJoints();
		}
		r = Difss[Name];
		if (r != null)
		{
			jsd = r.GetJointsD(array);
		}
	}

	public void JoinP()
	{
		if (r != null)
		{
			r.JoinPA();
			jsd.JoinP();
		}
	}

	public void JoinPA()
	{
		if (r != null)
		{
			r.JoinPA();
			jsd.JoinPA();
		}
	}

	public void JoinPall()
	{
		if (r != null)
		{
			r.JoinPA();
			jsd.JoinPall();
		}
	}

	public void JoinPAall()
	{
		if (r != null)
		{
			r.JoinPA();
			jsd.JoinPAall();
		}
	}

	public HashSet<string> GetHitDifsTagsCur(ref Color HitColor)
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (Difs value in Values)
		{
			if (value.Current.IsHit(ref HitColor))
			{
				hashSet.Add(value.Tag);
			}
		}
		return hashSet;
	}

	public List<Difs> GetHitDifssCur(ref Color HitColor)
	{
		List<Difs> list = new List<Difs>();
		foreach (Difs value in Values)
		{
			if (value.Current.IsHit(ref HitColor))
			{
				list.Add(value);
			}
		}
		return list;
	}

	public HashSet<string> GetHitParTagsCur(ref Color HitColor)
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (Difs value in Values)
		{
			foreach (string hitTag in value.Current.GetHitTags(ref HitColor))
			{
				hashSet.Add(hitTag);
			}
		}
		return hashSet;
	}

	public List<Par> GetHitParsCur(ref Color HitColor)
	{
		List<Par> list = new List<Par>();
		foreach (Difs value in Values)
		{
			list.AddRange(value.Current.GetHitPars(ref HitColor));
		}
		return list;
	}

	public bool IsHitCur(ref Color HitColor)
	{
		foreach (Difs value in Values)
		{
			if (value.IsHit(ref HitColor))
			{
				return true;
			}
		}
		return false;
	}

	public HashSet<string> GetHitDifsTags(ref Color HitColor)
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (Difs value in Values)
		{
			if (value.IsHit(ref HitColor))
			{
				hashSet.Add(value.Tag);
			}
		}
		return hashSet;
	}

	public List<Difs> GetHitDifss(ref Color HitColor)
	{
		List<Difs> list = new List<Difs>();
		foreach (Difs value in Values)
		{
			if (value.IsHit(ref HitColor))
			{
				list.Add(value);
			}
		}
		return list;
	}

	public HashSet<string> GetHitParTags(ref Color HitColor)
	{
		HashSet<string> hashSet = new HashSet<string>();
		foreach (Difs value in Values)
		{
			foreach (string hitTag in value.GetHitTags(ref HitColor))
			{
				hashSet.Add(hitTag);
			}
		}
		return hashSet;
	}

	public List<Par> GetHitPars(ref Color HitColor)
	{
		List<Par> list = new List<Par>();
		foreach (Difs value in Values)
		{
			list.AddRange(value.GetHitPars(ref HitColor));
		}
		return list;
	}

	public bool IsHit(ref Color HitColor)
	{
		foreach (Difs value in Values)
		{
			if (value.IsHit(ref HitColor))
			{
				return true;
			}
		}
		return false;
	}

	public void Symmetrization(string[] Names)
	{
		Difs[] array = Difss.Values.ToArray();
		Difs[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i].SetJoints();
		}
		JointsD jointsD = GetJoinRootDifs().GetJointsD(array);
		foreach (string name in Names)
		{
			symmetrization(name, array, jointsD);
		}
	}

	public void Symmetrization(string Name, string[] Names)
	{
		Difs[] array = Difss.Values.ToArray();
		Difs[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i].SetJoints();
		}
		JointsD jointsD = Difss[Name].GetJointsD(array);
		foreach (string name in Names)
		{
			symmetrization(name, array, jointsD);
		}
	}

	private void symmetrization(string Name, Difs[] da, JointsD jsdb)
	{
		Difs difs = Difss[Name];
		JointsD jointsD = difs.GetJointsD(da);
		Difs difs2 = new Difs(difs);
		difs2.SetJoints();
		difs2.ReverseX();
		TagReplace(difs2);
		SetPos(difs2, GetSymPos(difs, jsdb) - difs2.CurJoinRoot.Position);
		foreach (Pars item in difs2.EnumAllPars())
		{
			difs2.JoinP(item);
		}
		Difss.Add(difs2.Tag, difs2);
		string key = null;
		foreach (JointD join in jointsD.Joins)
		{
			difs2 = new Difs(join.Difs1);
			difs2.SetJoints();
			difs2.ReverseX();
			TagReplace(difs2);
			if (join.Difs0.Tag.Contains("左"))
			{
				key = join.Difs0.Tag.Replace("左", "右");
			}
			else if (join.Difs0.Tag.Contains("右"))
			{
				key = join.Difs0.Tag.Replace("右", "左");
			}
			Par par = Difss[key].Current.GetPar(join.Path0);
			SetPos(difs2, par.ToGlobal(par.JP[join.Index].Joint) - difs2.CurJoinRoot.Position);
			foreach (Pars item2 in difs2.EnumAllPars())
			{
				difs2.JoinP(item2);
			}
			Difss.Add(difs2.Tag, difs2);
		}
	}

	private void TagReplace(Difs ds)
	{
		if (ds.Tag.Contains("左"))
		{
			ds.Tag = ds.Tag.Replace("左", "右");
		}
		else if (ds.Tag.Contains("右"))
		{
			ds.Tag = ds.Tag.Replace("右", "左");
		}
	}

	private Vector2D GetSymPos(Difs r, JointsD jsdb)
	{
		JointD jointD = null;
		foreach (JointD join in jsdb.Joins)
		{
			if (join.Difs1 == r)
			{
				jointD = join;
				break;
			}
		}
		Vector2D position = r.CurJoinRoot.Position;
		Par par = jointD.Difs0.Current.GetPar(jointD.Path0);
		Joi joi = par.JP[jointD.Index];
		foreach (Joi item in par.JP)
		{
			Vector2D result = par.ToGlobal(item.Joint);
			if (item != joi && System.Math.Abs(result.Y - position.Y) < 1E-06)
			{
				return result;
			}
		}
		return Dat.Vec2DZero;
	}

	private void SetPos(Difs ds, Vector2D v)
	{
		foreach (Par item in ds.EnumAllPar())
		{
			item.PositionBase += v;
		}
	}

	public void Dispose()
	{
		foreach (Difs value in Difss.Values)
		{
			value.Dispose();
		}
	}
}
