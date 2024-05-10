using YoutubeDownloader.Models;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using NAudio.Wave;
using NReco.VideoConverter;
using System.Diagnostics;

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
					Notificaciones.Exito("Iniciando descarga...");
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
					Notificaciones.Exito("Iniciando descarga...");
					var streamManifest = await _youtubeClient.Videos.Streams.GetManifestAsync(_ModeloInformacion.Id);
					var streamInfoVideo = streamManifest.GetVideoOnlyStreams().Where(s => s.Container == Container.Mp4).GetWithHighestVideoQuality();
					await _youtubeClient.Videos.Streams.DownloadAsync(streamInfoVideo, Path.Combine(_ModeloInformacion.RutaDescarga, _ModeloInformacion.Title + ".mp4"));

					//string rutaTemporalVideo = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".mp4");
					//string rutaTemporalAudio = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".mp3");
					//string rutaArchivoFinal = Path.Combine(_ModeloInformacion.RutaDescarga, _ModeloInformacion.Title + ".mp4");

					//var streamInfoVideo = streamManifest.GetVideoOnlyStreams().Where(s => s.Container == Container.Mp4).GetWithHighestVideoQuality();
					//await _youtubeClient.Videos.Streams.DownloadAsync(streamInfoVideo, rutaTemporalVideo);

					//var streamInfoAudio = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
					//await _youtubeClient.Videos.Streams.DownloadAsync(streamInfoAudio,rutaTemporalAudio);


					//await ConvertMp4(rutaTemporalVideo,rutaTemporalAudio,rutaArchivoFinal);

					//File.Delete(rutaTemporalVideo);
					//File.Delete(rutaTemporalAudio);
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
		public async Task ConvertMp4(string rutaTemporalVideo, string rutaTemporalAudio, string rutaArchivoFinal)
		{
			string? directorioDestino = Path.GetDirectoryName(rutaArchivoFinal);
			string args = $"/c ffmpeg -i \"{rutaTemporalVideo}\" -i \"{rutaTemporalAudio}\" -shortest \"{rutaArchivoFinal}\"";

			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.CreateNoWindow = false;
			startInfo.FileName = "cmd.exe";
			startInfo.WorkingDirectory = @"" + directorioDestino;
			startInfo.Arguments = args;
			using Process? exeProcess = Process.Start(startInfo);
			await exeProcess.WaitForExitAsync();
		}
	}
}


