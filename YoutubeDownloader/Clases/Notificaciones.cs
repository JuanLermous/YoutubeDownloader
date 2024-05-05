using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace YoutubeDownloader.Clases
{
	internal class Notificaciones
	{
		
		public static void Exito(string Mensaje) {

			PopupNotifier popup = new PopupNotifier();	
			popup.BodyColor = Color.FromArgb(40, 167, 69);
			popup.TitleText = "succes";
			popup.TitleColor = Color.White;
			popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);
			popup.ContentText = Mensaje;
			popup.ContentColor = Color.White;
			popup.ContentFont = new Font("Century Gothic", 12, FontStyle.Bold);
			popup.Popup();
		}
		public static void Error(string ERROR)
		{
			PopupNotifier popup = new PopupNotifier();
			popup.BodyColor = Color.Red;
			popup.TitleText = "ERROR";
			popup.TitleColor = Color.White;
			popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);
			popup.ContentText = ERROR;
			popup.ContentColor = Color.White;
			popup.ContentFont = new Font("Century Gothic", 12, FontStyle.Bold);
			popup.Popup();
		}
	}
}
