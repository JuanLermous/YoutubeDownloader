using YoutubeDownloader.Clases;
using YoutubeDownloader.Models;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace YoutubeDownloader
{
	public partial class MainMenu : Form
	{
		private VideoDataModel _ModeloInformacion;
		private InformacionVideoID _ExtraccionInformacion;
		private MetodosDescargas _MetodosDescargas;
		private FolderBrowserDialog _FolderBrowserDialog = new FolderBrowserDialog();
		// Importar funciones para permitir el arrastre manual del formulario
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		const int WM_NCLBUTTONDOWN = 0xA1;
		const int HT_CAPTION = 0x2;
		public MainMenu(VideoDataModel modelo)
		{
			InitializeComponent();
			tabControl1.SizeMode = TabSizeMode.Fixed;
			tabControl1.ItemSize = new Size(0, 1);
			this._ModeloInformacion = modelo;
			this._ExtraccionInformacion = new InformacionVideoID(_ModeloInformacion);
			this._MetodosDescargas = new MetodosDescargas(_ModeloInformacion);
		}
		private void labelTittle_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(this.Handle, 0x112, 0xf012, 0);
			}
		}
		private void label4_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabControl1.TabPages[0];
		}

		private void button2_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabControl1.TabPages[0];
		}
		private void labelDescargas_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabControl1.TabPages[1];
		}

		private void button1_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabControl1.TabPages[1];
		}
		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void buttonMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private async void buttonBuscar_Click(object sender, EventArgs e)
		{
			this.buttonBuscar.Enabled = false;
			string VideoID = ExtraerVideoID(this.textBoxUrl.Text);
			await _ExtraccionInformacion.ObtenerInformacionDelVideoAsync(VideoID);
			LlenarConInformacionObtenida();
			this.buttonBuscar.Enabled = true;
		}
		private void buttonRutaDescarga_Click(object sender, EventArgs e)
		{
			SeleccionarRutaDescarga();
		}

		private async void buttonDescargar_Click(object sender, EventArgs e)
		{
			this.buttonDescargar.Enabled = false;
			if (radioButtonMP3.Checked)
				await _MetodosDescargas.DescargarMP3();
			else if (radioButtonMP4.Checked)
				await _MetodosDescargas.DescargarMP4();
			else if (!radioButtonMP3.Checked && !radioButtonMP4.Checked)
				Notificaciones.Error("Elige un tipo de descarga");
			this.buttonDescargar.Enabled = true;
		}


		public static string ExtraerVideoID(string url)
		{
			string pattern = @"(?:https?:\/\/)?(?:www\.)?(?:youtube\.com\/(?:[^\/\n\s]+\/\S+\/|(?:v|e(?:mbed)?)\/|\S*?[?&]v=)|youtu\.be\/)([a-zA-Z0-9_-]{11})";
			Regex regex = new Regex(pattern);
			Match match = regex.Match(url);
			if (match.Success)
				return match.Groups[1].Value;
			else
				return "";
		}
		public void LlenarConInformacionObtenida()
		{
			this.groupBoxInformacionBusqueda.Visible = true;
			this.textBoxTitulo.Text = _ModeloInformacion.Title;
			this.textBoxDuracion.Text = _ModeloInformacion.Duration;
			this.textBoxAutor.Text = _ModeloInformacion.Author;
			//this.textBoxTamaño.Text = _ModeloInformacion.TamañoMB;
		}
		public void SeleccionarRutaDescarga()
		{
			if (_FolderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				this.textBoxRutaDescarga.Text = _FolderBrowserDialog.SelectedPath;
				_ModeloInformacion.RutaDescarga = _FolderBrowserDialog.SelectedPath;
				this.buttonDescargar.Enabled = true;
			}
			else
				textBoxRutaDescarga.Text = "No seleccionaste una ruta de descarga";
		}
	}
}
