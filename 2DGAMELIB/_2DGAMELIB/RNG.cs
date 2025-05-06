using System;
using System.Globalization;

namespace _2DGAMELIB;

public static class RNG
{
	public static MyRandom XS = new MyRandom((uint)(Environment.TickCount + DateTime.Now.ToBinary()));
}
