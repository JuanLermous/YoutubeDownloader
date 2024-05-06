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
//_ModeloInformacion.Id = InformacionVideoID.ExtraerIdVideo(textBoxUrl.Trim());
//if (_ModeloInformacion.Id == null)
//{
//	Notificaciones.Error("Error al convertir la URL");
//	return;
//}
//try
//{
//	await InformacionDelVideo();
//}
//catch (Exception ex)
//{
//	Notificaciones.Error("Error al obtener la información del video: " + ex.Message);
//}


//public async Task InformacionDelVideo()
//{
//	var videoInfo = await youtubeClient.Videos.GetAsync(_ModeloInformacion.Id);
//	if (videoInfo == null)
//	{
//		Notificaciones.Error("No se pudo obtener la información del video");
//		return;
//	}
//	Notificaciones.Exito("Información obtenida");		
//	_ModeloInformacion.Title = videoInfo.Title;
//	_ModeloInformacion.Author = videoInfo.Author.ToString();
//	_ModeloInformacion.Duration = videoInfo.Duration.ToString();
//	var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(_ModeloInformacion.Id);
//	var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
//	_ModeloInformacion.TamañoMB = streamInfo.ToString();

//}