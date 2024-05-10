using YoutubeDownloader.Models;
using YoutubeExplode;
namespace YoutubeDownloader.Clases
{
    internal class InformacionVideoID 
    {
		private VideoDataModel _ModeloInformacion;
		private readonly YoutubeClient _youtubeClient;
		public InformacionVideoID(VideoDataModel ModeloMainMenu)
        {
            this._ModeloInformacion = ModeloMainMenu;
			this._youtubeClient = new YoutubeClient();
		}

		public async Task ObtenerInformacionDelVideoAsync(string videoID)
		{
			try
			{
				Notificaciones.Exito("Buscando...");
				var video = await _youtubeClient.Videos.GetAsync(videoID);
				if (video != null)
				{
											
					_ModeloInformacion.Id = video.Id;
					_ModeloInformacion.Title = video.Title;
					_ModeloInformacion.Author = video.Author.ToString();
					_ModeloInformacion.Duration = video.Duration.ToString();
					Notificaciones.Exito("Informacion del Video Obtenida");
				}
				else
				{
					Notificaciones.Error("No se encontró información para el video con el ID proporcionado.");
				}
			}
			catch (HttpRequestException ex)
			{			
				Notificaciones.Error("Error al realizar la solicitud HTTP: " + ex.Message);
			}
			catch (OperationCanceledException ex)
			{
				Notificaciones.Error("La solicitud fue cancelada debido a un tiempo de espera agotado." +ex.Message);
			}
			catch (Exception ex)
			{
				Notificaciones.Error("Se produjo un error inesperado: " + ex.Message);
			}
		}
	}
}
