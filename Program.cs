using System;
using System.Windows.Forms;

namespace WindowsFormsMMSF
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MMSF3home());
		}
	}
}