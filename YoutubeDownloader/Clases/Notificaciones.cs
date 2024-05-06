using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace YoutubeDownloader.Clases
{
	internal class Notificaciones
	{
		
		public static void Exito(string Mensaje) {

			PopupNotifier popup = new PopupNotifier();
			Bitmap resizedImage = new Bitmap(Resources.comprobado, new Size(45, 45));
			popup.Image = resizedImage;
			popup.BodyColor = Color.FromArgb(40, 167, 69);
			popup.TitleText = "EXITO";
			popup.TitleColor = Color.White;
			popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);
			popup.ContentText = Mensaje;
			popup.ContentColor = Color.White;
			popup.ContentFont = new Font("Century Gothic", 12, FontStyle.Bold);
			popup.Popup();
			SoundPlayer simpleSound = new SoundPlayer(Resources.SoundNotification);
			simpleSound.Play();
		}
		public static void Error(string ERROR)
		{
			PopupNotifier popup = new PopupNotifier();
			Bitmap resizedImage = new Bitmap(Resources.Error, new Size(45, 45));
			popup.Image = resizedImage;
			popup.BodyColor = Color.Red;
			popup.TitleText = "ERROR";
			popup.TitleColor = Color.White;
			popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);
			popup.ContentText = ERROR;
			popup.ContentColor = Color.White;
			popup.ContentFont = new Font("Century Gothic", 12, FontStyle.Bold);
			popup.Popup();
			SoundPlayer simpleSound = new SoundPlayer(Resources.SoundNotification);
			simpleSound.Play();
		
		}
	}
}
