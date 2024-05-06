using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader.Models
{
	public class VideoDataModel
	{
		public string? Title { get; set; }
		public string? Author { get; set; }
		public string? Duration { get; set; }
		public string? Id { get; set; }
		public string? TamañoMB { get; set; }
		public string? RutaDescarga { get; set; }	
	}
}
