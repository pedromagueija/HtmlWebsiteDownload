// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HtmlDownloadService.cs" author="Pedro Magueija">
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//   
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace HtmlWebsiteDownload
{
    using System;
    using System.Net;
    using System.Threading.Tasks;

    internal class HtmlDownloadService
    {
        public async Task<string> Download(string url)
        {
            using (var webClient = new WebClient())
            {
                var uri = new Uri(url);
                return await webClient.DownloadStringTaskAsync(uri);
            }
        }
    }
}