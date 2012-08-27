using System;
using System.Collections.Generic;
using System.Net;

namespace TSPTest
{
    internal class HTTPDownloader : Downloader
    {
       private readonly WebClient webClient = new WebClient();
        public string download(string url)
        {
            return webClient.DownloadString(url);
        }
    }
}