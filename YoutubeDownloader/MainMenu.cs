using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using YoutubeDownloader.Clases;
using YoutubeDownloader.Models;
using YoutubeExplode.Videos;

namespace YoutubeDownloader
{
	public partial class MainMenu : Form
	{
		InformacionVideoModel InformacionVideoModelo = new InformacionVideoModel();
		public MainMenu()
		{
			InitializeComponent();
		}
		private void buttonBuscar_Click(object sender, EventArgs e)
		{
			ObtenerInformacionDeUrl();

		}
		private void buttonDescargar_Click(object sender, EventArgs e)
		{
			if (radioButtonMP3.Checked)
				DescargarMP3();
			else if (radioButtonMP4.Checked)
				DescargarMP4();
			else if (!radioButtonMP3.Checked && !radioButtonMP4.Checked)
				Notificaciones.Error("Elige un tipo de descarga");	

		}
		public async void ObtenerInformacionDeUrl()
		{			
			string videoUrl = textUrl.Text.Trim();
			InformacionVideoModelo.Id = MetodosBuscar.ExtraerIdVideo(videoUrl);
			if (InformacionVideoModelo.Id == null)
			{
				Notificaciones.Error("Error al convertir la URL");
				return;
			}
			try
			{
				await InformacionDelVideo();
			}
			catch (Exception ex)
			{
				Notificaciones.Error("Error al obtener la información del video: " + ex.Message);
			}
		}

		public async Task InformacionDelVideo()
		{
			var youtubeClient = new YoutubeClient();
			var videoInfo = await youtubeClient.Videos.GetAsync(InformacionVideoModelo.Id);
			if (videoInfo == null)
			{
				Notificaciones.Error("No se pudo obtener la información del video");
				return;
			}
			Notificaciones.Exito("Información obtenida");
			groupBoxInformacionBusqueda.Visible = true;
			InformacionVideoModelo.Title = videoInfo.Title;
			InformacionVideoModelo.Author = videoInfo.Author.ToString();
			InformacionVideoModelo.Duration = videoInfo.Duration.ToString();
			LlenarTextBoxes();
			var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(InformacionVideoModelo.Id);
			var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
			textBoxTamaño.Text = streamInfo.Size.ToString();
		}
	

		public async Task DescargarMP3()
		{
			var youtubeClient = new YoutubeClient();
			var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(InformacionVideoModelo.Id);
			var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
			string downloadPath = "C:\\Users\\ladol\\OneDrive\\Desktop";
			string fileName = $"{InformacionVideoModelo.Title}.{streamInfo.Container}";
			await youtubeClient.Videos.Streams.DownloadAsync(streamInfo, Path.Combine(downloadPath, fileName));
			Notificaciones.Exito("Descarga completa");
		}
		public async Task DescargarMP4()
		{

		}
		public void LlenarTextBoxes()
		{
			textBoxTitulo.Text = InformacionVideoModelo.Title;
			textBoxDuracion.Text = InformacionVideoModelo.Duration;
			textBoxAutor.Text = InformacionVideoModelo.Author;
		}
	}
}
