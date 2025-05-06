namespace _2DGAMELIB;

public class ConstProp
{
	private int c = -1;

	public bool GetFlag(double Proportion)
	{
		c++;
		return c % (int)(1.0 / Proportion) == 0;
	}

	public void Reset()
	{
		c = -1;
	}
}
