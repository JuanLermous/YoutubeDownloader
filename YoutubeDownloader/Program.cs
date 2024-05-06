using YoutubeDownloader.Models;

namespace YoutubeDownloader
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{

			var informacionVideoModel = new VideoDataModel();
			ApplicationConfiguration.Initialize();
			Application.Run(new MainMenu(informacionVideoModel));
		}
	}
}