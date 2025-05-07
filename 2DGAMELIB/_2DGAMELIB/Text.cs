using System.IO;
using System.Text;

namespace _2DGAMELIB
{
    public static class Text
    {
    	public static void ToText(this string str, string Path, Encoding Encoding)
    	{
    		using StreamWriter streamWriter = new StreamWriter(Path, append: false, Encoding);
    		streamWriter.Write(str);
    	}

    	public static string FromText(this string Path)
    	{
    		using FileStream fileStream = new FileStream(Path, FileMode.Open, FileAccess.Read);
    		byte[] array = new byte[fileStream.Length];
    		fileStream.Read(array, 0, array.Length);
    		using StreamReader streamReader = new StreamReader(new MemoryStream(array), array.GetEncoding());
    		return streamReader.ReadToEnd();
    	}

    	public static string[] ReadLines(this string Path)
    	{
    		return Path.FromText().Replace("\r", "").Split('\n');
    	}
    }
}
