using System;
using System.IO;

namespace _2DGAMELIB;


//its the position of a joint
[Serializable]
public class Joi
{
	public Vector2D Joint = Dat.Vec2DZero;

	public Joi()
	{
	}

	public Joi(Joi Joi)
	{
		Joint = Joi.Joint;
	}

	public Joi(Vector2D Joint)
	{
		this.Joint = Joint;
	}

	public Joi(ref Vector2D Joint)
	{
		this.Joint = Joint;
	}
}
