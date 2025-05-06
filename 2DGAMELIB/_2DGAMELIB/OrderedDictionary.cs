using System;
using System.Collections.Generic;
using System.Linq;

namespace _2DGAMELIB;

[Serializable]
public class OrderedDictionary<T1, T2>
{
	private List<T1> keys;

	private Dictionary<T1, T2> values;

	public T2 this[T1 Key]
	{
		get
		{
			return values[Key];
		}
		set
		{
			values[Key] = value;
		}
	}

	public T2 this[int Index]
	{
		get
		{
			return values[keys[Index]];
		}
		set
		{
			values[keys[Index]] = value;
		}
	}

	public IEnumerable<T1> Keys => keys;

	public IEnumerable<T2> Values
	{
		get
		{
			foreach (T1 key in keys)
			{
				yield return values[key];
			}
		}
	}

	public int Count => keys.Count;

	public OrderedDictionary()
	{
		keys = new List<T1>();
		values = new Dictionary<T1, T2>();
	}

	public OrderedDictionary(int capacity)
	{
		keys = new List<T1>(capacity);
		values = new Dictionary<T1, T2>(capacity);
	}

	public int IndexOf(T1 Key)
	{
		return keys.IndexOf(Key);
	}

	public int IndexOf(ref T1 Key)
	{
		return keys.IndexOf(Key);
	}

	public int IndexOf(T2 Value)
	{
		int num = 0;
		foreach (T2 value in Values)
		{
			if (value.Equals(Value))
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	public int IndexOf(ref T2 Value)
	{
		int num = 0;
		foreach (T2 value in Values)
		{
			if (value.Equals(Value))
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	public int LastIndexOf(T1 Key)
	{
		return keys.LastIndexOf(Key);
	}

	public int LastIndexOf(ref T1 Key)
	{
		return keys.LastIndexOf(Key);
	}

	public int LastIndexOf(T2 Value)
	{
		int num = keys.Count - 1;
		foreach (T2 item in Values.Reverse())
		{
			if (item.Equals(Value))
			{
				return num;
			}
			num--;
		}
		return -1;
	}

	public int LastIndexOf(ref T2 Value)
	{
		int num = keys.Count - 1;
		foreach (T2 item in Values.Reverse())
		{
			if (item.Equals(Value))
			{
				return num;
			}
			num--;
		}
		return -1;
	}

	public void Add(T1 Key, T2 Value)
	{
		keys.Add(Key);
		values.Add(Key, Value);
	}

	public void Add(ref T1 Key, ref T2 Value)
	{
		keys.Add(Key);
		values.Add(Key, Value);
	}

	public void Insert(int Index, T1 Key, T2 Value)
	{
		keys.Insert(Index, Key);
		values.Add(Key, Value);
	}

	public void Insert(int Index, ref T1 Key, ref T2 Value)
	{
		keys.Insert(Index, Key);
		values.Add(Key, Value);
	}

	public void Remove(T1 Key)
	{
		keys.Remove(Key);
		values.Remove(Key);
	}

	public void Remove(ref T1 Key)
	{
		keys.Remove(Key);
		values.Remove(Key);
	}

	public void Reverse()
	{
		keys.Reverse();
	}

	public void Reverse(int Index, int Count)
	{
		keys.Reverse(Index, Count);
	}

	public bool ContainsKey(T1 Key)
	{
		return values.ContainsKey(Key);
	}

	public bool ContainsKey(ref T1 Key)
	{
		return values.ContainsKey(Key);
	}

	public bool ContainsValue(T2 Value)
	{
		return values.ContainsValue(Value);
	}

	public bool ContainsValue(ref T2 Value)
	{
		return values.ContainsValue(Value);
	}
}
