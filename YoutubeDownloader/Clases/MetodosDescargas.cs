using YoutubeDownloader.Models;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
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
                if ((_ModeloInformacion.Id != null) && (_ModeloInformacion.RutaDescarga != null) && (_ModeloInformacion.Title != null))
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
                    string WindowsPath = GetWindowsFolderPath();
                    bool ffmepg = FFMEPGExist(WindowsPath);
                    if (!ffmepg)
                    {
                        DialogResult result =
                        MessageBox.Show("No se encontro ffmpeg.exe en tu computadora. Es necesario para que los videos se descarguen correctamente.\n"+
                        "Para instalar ffmpeg en tu pc sigue las instrucciones que se encuentran en la carpeta del programa" ,
                         "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Question);  
                            return;
                    }
                    
                    var streamManifest = await _youtubeClient.Videos.Streams.GetManifestAsync(_ModeloInformacion.Id);
                   
                    string rutaTemporalVideo = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".mp4");
                    string rutaTemporalAudio = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".mp3");
                    
                    string rutaArchivoFinal = Path.Combine(_ModeloInformacion.RutaDescarga, _ModeloInformacion.Title + ".mp4");
                    Notificaciones.Exito("Iniciando descarga...");
                    var streamInfoVideo = streamManifest.GetVideoOnlyStreams().Where(s => s.Container == Container.Mp4).GetWithHighestVideoQuality();
                    await _youtubeClient.Videos.Streams.DownloadAsync(streamInfoVideo, rutaTemporalVideo);

                    var streamInfoAudio = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
                    await _youtubeClient.Videos.Streams.DownloadAsync(streamInfoAudio, rutaTemporalAudio);


                    await convertMp4(rutaTemporalVideo, rutaTemporalAudio, rutaArchivoFinal);

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
        public async Task convertMp4(string rutaTemporalVideo, string rutaTemporalAudio, string rutaArchivoFinal)
        {
            Notificaciones.Exito("Iniciando combinacion de audio y video...");	
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

        public string GetWindowsFolderPath()
        {
            var systemFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
            var parentDirectory = Directory.GetParent(systemFolderPath);
            string targetPath = parentDirectory?.FullName ?? "NOT FOUND";

            if (targetPath.Equals("NOT FOUND"))
                return "";
            else
                return targetPath;
        }

        public bool FFMEPGExist(string windowsPath)
        {
            bool fileExist = File.Exists(windowsPath + "\\ffmpeg.exe");

            if (fileExist)
                return true;
            else
                return false;
        }
    }
}


