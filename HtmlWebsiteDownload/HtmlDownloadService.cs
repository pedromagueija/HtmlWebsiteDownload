namespace HtmlWebsiteDownload
{
    using System;
    using System.Net;
    using System.Threading.Tasks;

    internal class HtmlDownloadService
    {
        public async Task<string> Download(string url)
        {
            using (WebClient webClient = new WebClient())
            {
                var uri = new Uri(url);
                return await webClient.DownloadStringTaskAsync(uri);
            }
        }
    }
}