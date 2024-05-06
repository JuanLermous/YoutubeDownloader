using NReco.VideoConverter;
using YoutubeDownloader.Models;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YoutubeDownloader.Clases
{
	internal class MetodosDescargas
	{
		private VideoDataModel _ModeloInformacion;
		private readonly YoutubeClient _youtubeClient;
		public MetodosDescargas(VideoDataModel ModeloMainMenu)
		{
			this._ModeloInformacion = ModeloMainMenu;
			this._youtubeClient = new YoutubeClient();

		}
		public async Task DescargarMP3()
		{
			try
			{
				if( (_ModeloInformacion.Id != null) && (_ModeloInformacion.RutaDescarga != null) && (_ModeloInformacion.Title != null))
				{
					var streamManifest = await _youtubeClient.Videos.Streams.GetManifestAsync(_ModeloInformacion.Id);
					var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
					await _youtubeClient.Videos.Streams.DownloadAsync(streamInfo, Path.Combine(_ModeloInformacion.RutaDescarga, _ModeloInformacion.Title + ".mp3"));		
					Notificaciones.Exito("Descarga completa");
				}
				else
				{
					Notificaciones.Error("Error al obtener informacion de descarga, volver a buscar");
				}		
			}
			catch (HttpRequestException ex)
			{
				Notificaciones.Error("Error al realizar la solicitud HTTP: " + ex.Message);
			}
			catch (OperationCanceledException ex)
			{
				Notificaciones.Error("La solicitud fue cancelada debido a un tiempo de espera agotado." + ex.Message);
			}
			catch (Exception ex)
			{
				Notificaciones.Error("Se produjo un error inesperado: " + ex.Message);
			}
		
		}
	
		public async Task DescargarMP4()
		{
			try
			{
				if ((_ModeloInformacion.Id != null) && (_ModeloInformacion.RutaDescarga != null) && (_ModeloInformacion.Title != null))
				{
					var streamManifest = await _youtubeClient.Videos.Streams.GetManifestAsync(_ModeloInformacion.Id);
					string rutaTemporalVideo = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".mp4");
					string rutaTemporalAudio = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".mp3");
					string rutaArchivoFinal = Path.Combine(_ModeloInformacion.RutaDescarga, _ModeloInformacion.Title + ".mp4");

					var streamInfoVideo = streamManifest.GetVideoOnlyStreams().Where(s => s.Container == Container.Mp4).GetWithHighestVideoQuality();
					await _youtubeClient.Videos.Streams.DownloadAsync(streamInfoVideo, rutaTemporalVideo);
					
					var streamInfoAudio = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
					await _youtubeClient.Videos.Streams.DownloadAsync(streamInfoAudio,rutaTemporalAudio);

					
					
			

					File.Delete(rutaTemporalVideo);
					File.Delete(rutaTemporalAudio);

					Notificaciones.Exito("Descarga completa");	
				}
				else
				{
					Notificaciones.Error("Error al obtener informacion de descarga, volver a buscar");
				}
			}
			catch (HttpRequestException ex)
			{
				Notificaciones.Error("Error al realizar la solicitud HTTP: " + ex.Message);
			}
			catch (OperationCanceledException ex)
			{
				Notificaciones.Error("La solicitud fue cancelada debido a un tiempo de espera agotado." + ex.Message);
			}
			catch (Exception ex)
			{
				Notificaciones.Error("Se produjo un error inesperado: " + ex.Message);
			}
		}
		public void CombinarMP4yMP3(string archivoMP4, string archivoMP3, string archivoSalida)
		{
			// Creamos un objeto FFMpegConverter
			var ffmpeg = new FFMpegConverter();

			// Combinamos el archivo MP4 con el archivo MP3
			ffmpeg.JoinMedia(new[] { archivoMP4, archivoMP3 }, archivoSalida, Format.mp4);

			Console.WriteLine("Combinación completa");
		}

	}
}

