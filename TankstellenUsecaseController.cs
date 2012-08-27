using System;
using System.Linq.Expressions;
using System.Linq;

namespace TSPTest
{
    public class TankstellenUsecaseController
    {
        private readonly Downloader downloader;
        private readonly HTMLParser htmlParser;
        private TankstellenEntry oldEntry;
        private readonly EntryAuditor entryAuditor;

        private const string Url =
            @"http://auto.freenet.de/freenet/servlet/external?url=http%3A%2F%2Fnn3.freenet.de%2Fclevertanken%2Fmain.php%3Fcm%3D1%26sprit%3DSuper%26ort%3D";
        private string downloadUrl;

        public TankstellenUsecaseController(Downloader downloader, HTMLParser htmlParser, string ort, EntryAuditor entryAuditor)
        {
            this.downloader = downloader;
            this.htmlParser = htmlParser;
            downloadUrl = Url + ort;
            this.entryAuditor = entryAuditor;
        }

        public void NotificateIfNew(Action<string> notification)
        {
            TankstellenEntry entry = htmlParser.parse(downloader.download(downloadUrl)).First(x => x.IsPmOrStar());
            if (entry.IsNewerThan(oldEntry))
            {
                oldEntry = entry;
                notification(entry.ToString());
                entryAuditor.WriteEntry(entry);
            }
        }
    }
}