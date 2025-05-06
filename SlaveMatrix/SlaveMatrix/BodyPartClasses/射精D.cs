using System;

namespace SlaveMatrix;

[Serializable]
public class 射精D : EleD
{
	public bool 精液_表示 = true;

	public bool 精液掛け_表示 = true;

	public 射精D()
	{
		ThisType = GetType();
	}
}
