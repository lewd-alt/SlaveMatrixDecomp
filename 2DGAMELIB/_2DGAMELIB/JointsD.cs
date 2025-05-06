using System;
using System.Collections.Generic;

namespace _2DGAMELIB;

[Serializable]
public class JointsD
{
	public List<JointD> Joins = new List<JointD>();

	public void JoinP()
	{
		foreach (JointD join in Joins)
		{
			join.JoinP();
		}
	}

	public void JoinPA()
	{
		foreach (JointD join in Joins)
		{
			join.JoinPA();
		}
	}

	public void JoinPall()
	{
		foreach (JointD join in Joins)
		{
			join.JoinPall();
		}
	}

	public void JoinPAall()
	{
		foreach (JointD join in Joins)
		{
			join.JoinPAall();
		}
	}
}
