using System;
using System.Collections.Generic;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2DGAMELIB;


//outline/path/line basically represents a curve :3
[Serializable]
public class Out
{
	public List<Vector2D> ps = new List<Vector2D>();

	public float Tension = 0.5f;
    public bool Outline = true;

	public Out()
	{
	}

	public Out(Out Out)
	{
		ps = new List<Vector2D>(Out.ps);
		Tension = Out.Tension;
		Outline = Out.Outline;
	}
}
