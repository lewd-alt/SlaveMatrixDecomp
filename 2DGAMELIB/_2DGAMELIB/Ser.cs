using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace _2DGAMELIB
{

    //serialization stuff
    public static class Ser
    {
    	private static SerializableAttribute s = new SerializableAttribute();

    	public static T DeepCopy<T>(this T Object)
    	{
    		BinaryFormatter binaryFormatter = new BinaryFormatter();
    		using MemoryStream memoryStream = new MemoryStream();
    		binaryFormatter.Serialize(memoryStream, Object);
    		memoryStream.Position = 0L;
    		return (T)binaryFormatter.Deserialize(memoryStream);
    	}

    	public static byte[] ToSerialBytes<T>(this T Object)
    	{
    		using MemoryStream memoryStream = new MemoryStream();
    		new BinaryFormatter().Serialize(memoryStream, Object);
    		return memoryStream.ToArray();
    	}

    	public static T ToDeserialObject<T>(this byte[] Bytes)
    	{
    		using MemoryStream serializationStream = new MemoryStream(Bytes);
    		return (T)new BinaryFormatter().Deserialize(serializationStream);
    	}

    	public static void Save<T>(this T Object, string Path)
    	{
    		using FileStream serializationStream = new FileStream(Path, FileMode.Create, FileAccess.Write);
    		new BinaryFormatter().Serialize(serializationStream, Object);
    	}

    	public static T Load<T>(this string Path)
    	{
    		using FileStream serializationStream = new FileStream(Path, FileMode.Open, FileAccess.Read);
    		return (T)new BinaryFormatter().Deserialize(serializationStream);
    	}

    	public static T Load<T>(this byte[] bd)
    	{
    		using MemoryStream serializationStream = new MemoryStream(bd);
    		return (T)new BinaryFormatter().Deserialize(serializationStream);
    	}
    	/*
    	public static void ToXml<T>(this T Object, string Path)
    	{
    		using FileStream output = new FileStream(Path, FileMode.Create, FileAccess.Write);
    		using XmlWriter writer = XmlWriter.Create(output, new XmlWriterSettings
    		{
    			Indent = true
    		});
    		new DataContractSerializer(typeof(T)).WriteObject(writer, Object);
    	}

    	public static T FromXml<T>(this string Path)
    	{
    		using FileStream input = new FileStream(Path, FileMode.Open, FileAccess.Read);
    		using XmlReader reader = XmlReader.Create(input);
    		return (T)new DataContractSerializer(typeof(T)).ReadObject(reader);
    	}
    	*/
    	static Ser(){}

    	public static void ToJson<T>(this T Object, string Path)
    	{
    		using StreamWriter textWriter = File.CreateText(Path);
    		JsonSerializer jsonSerializer = new JsonSerializer();
    		jsonSerializer.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
    		jsonSerializer.TypeNameHandling = TypeNameHandling.All;
    		jsonSerializer.Formatting = Newtonsoft.Json.Formatting.Indented;
    		jsonSerializer.Serialize(textWriter, Object);
    	}

    	public static T UnJson<T>(string Path)
    	{
    		using StreamReader reader = File.OpenText(Path);
    		return (T)new JsonSerializer
    		{
    			NullValueHandling = NullValueHandling.Ignore,
    			TypeNameHandling = TypeNameHandling.All
    		}.Deserialize(reader, typeof(T));
    	}
    }
}
