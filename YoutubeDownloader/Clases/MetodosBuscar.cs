using YoutubeDownloader.Models;
using System.Text.RegularExpressions;

namespace YoutubeDownloader.Clases
{
    internal class MetodosBuscar
    {

        public  static string ExtraerIdVideo(string url)
        {
            string pattern = @"(?:https?:\/\/)?(?:www\.)?(?:youtube\.com\/(?:[^\/\n\s]+\/\S+\/|(?:v|e(?:mbed)?)\/|\S*?[?&]v=)|youtu\.be\/)([a-zA-Z0-9_-]{11})";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(url);

            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return null;
            }
        }
    }
}
