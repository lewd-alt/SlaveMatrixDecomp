using System;
using System.Windows.Forms;
using _2DGAMELIB;

namespace SlaveMatrix;

internal static class Program
{
	public static bool biggerWindow;

	[STAThread]
	private static void Main(string[] A_0)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);

        Sta.LoadConfig();

        double percent = 35.0;
        if (Sta.BigWindow)
        {
            percent = 47.0;
            biggerWindow = true;
        }

        Med med = new Med
		{
			UITitle = GameText.スレイブマトリクス,
			Unit = Sta.HighQuality ? 2203.0 : 1101.5,
			ShowFPS = Sta.ShowFPS,
			Base = new Rect(4.0, 3.0, percent / 100.0),
            DisQuality = 1.0,
			HitAccuracy = 0.3
        };

		med.InitializeModes("Start", Mods.GetMods);

		UI uI = new UI(med);
		uI.Text = GameText.スレイブマトリクス;
		uI.Show();

		//main loop
		med.Drawing();


		if (Mods.t1 != null)
		{
			Mods.t1.Wait();
		}
		med.Dispose();
		Sta.Disposes();
	}
}
