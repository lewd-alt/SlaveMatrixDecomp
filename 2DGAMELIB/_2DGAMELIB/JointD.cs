using System;
using System.Collections.Generic;

namespace _2DGAMELIB;

[Serializable]
public class JointD
{
	public Difs Difs0;

	public List<int> Path0;

	public int Index;

	public Difs Difs1;

	public JointD(Difs Difs0, Par Par0, int Index, Difs Difs1)
	{
		this.Difs0 = Difs0;
		Path0 = Par0.GetPath();
		this.Index = Index;
		this.Difs1 = Difs1;
	}

	public JointD(Difs Difs1)
	{
		this.Difs1 = Difs1;
	}

	public void JoinP()
	{
		Difs0.Current.GetPar(Path0).SetJointP(Index, Difs1.CurJoinRoot);
		Difs1.JoinPA();
	}

	public void JoinPA()
	{
		Difs0.Current.GetPar(Path0).SetJointPA(Index, Difs1.CurJoinRoot);
		Difs1.JoinPA();
	}

	public void JoinPall()
	{
		foreach (Par item in Difs1.EnumJoinRoot)
		{
			Difs0.Current.GetPar(Path0).SetJointP(Index, item);
		}
		foreach (Pars item2 in Difs1.EnumAllPars())
		{
			Difs1.JoinPA(item2);
		}
	}

	public void JoinPAall()
	{
		foreach (Par item in Difs1.EnumJoinRoot)
		{
			Difs0.Current.GetPar(Path0).SetJointPA(Index, item);
		}
		foreach (Pars item2 in Difs1.EnumAllPars())
		{
			Difs1.JoinPA(item2);
		}
	}

	public void Set(JointS 接続元)
	{
		Difs0 = 接続元.Difs;
		Path0 = 接続元.Path;
		Index = 接続元.Index;
	}
}
