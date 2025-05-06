using _2DGAMELIB;

namespace SlaveMatrix;

public struct ContactD
{
	public ContactType c;

	public Ele e;

	public Par p;

	public override string ToString()
	{
		return ("接触:" + c).ToString() + "\r\n" + ("Ele:" + ((e == null) ? "null" : e.ToString())).ToString() + "\r\n" + ("Par:" + ((p == null) ? "null" : p.ToString())).ToString();
	}
}
