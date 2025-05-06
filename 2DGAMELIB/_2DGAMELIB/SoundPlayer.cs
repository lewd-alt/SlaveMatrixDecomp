using System;
using System.Windows.Media;

namespace _2DGAMELIB;

public class SoundPlayer
{
	public MediaPlayer mp = new MediaPlayer();

	private bool l;

	private TimeSpan ts = new TimeSpan(0L);

	public bool Loop
	{
		get
		{
			return l;
		}
		set
		{
			if (value)
			{
				if (l != value)
				{
					mp.MediaEnded += loop;
				}
			}
			else if (l != value)
			{
				mp.MediaEnded -= loop;
			}
			l = value;
		}
	}

	public SoundPlayer(string Path)
	{
		mp.Open(new Uri(Path));
		mp.Volume = 1.0;
	}

	public SoundPlayer(string Path, bool Loop)
	{
		mp.Open(new Uri(Path));
		this.Loop = Loop;
		mp.Volume = 1.0;
	}

	private void loop(object s, EventArgs e)
	{
		mp.Position = ts;
		mp.Play();
	}

	public void Play()
	{
		mp.Play();
	}

	public void Stop()
	{
		mp.Stop();
	}

	public void Pause()
	{
		mp.Pause();
	}

	public void Close()
	{
		mp.Close();
	}
}
