using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment10
{
    class WebCrawler
    {
        private string beginUrl;

        public event Action<string, string> GetCrawlInfo;

        public event Action CrawlEnd;

        private string HostFilterRegex;

        private ConcurrentQueue<string> pending = new ConcurrentQueue<string>();

        private ConcurrentDictionary<string, bool> DownloadedPages { get; }

        public WebCrawler(string beginUrl)
        {
            this.beginUrl = beginUrl;
            HostFilterRegex = "^" + new Uri(beginUrl).Host + "$";
            DownloadedPages = new ConcurrentDictionary<string, bool>();
        }

        public async Task Crawl()
        {
            DownloadedPages.Clear();
            while (pending.TryDequeue(out string result)) { }
            pending.Enqueue(beginUrl);

            while(DownloadedPages.Count <= 10 && pending.Count > 0)
            {
                if(DownloadedPages.Count > 100)
                {
                    await Task.Delay(100);
                    continue;
                }
                string url;
                pending.TryDequeue(out url);
                try
                {
                    string html = await DownLoad(url);
                    DownloadedPages[url] = true;
                    GetCrawlInfo(url, " SUCCESS!");
                    Parse(html, url);
                }catch(Exception e)
                {
                    GetCrawlInfo(url, " ERROR: " + e.Message);
                }
            }
            CrawlEnd();
        }
        
        private async Task<string> DownLoad(string url)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = await webClient.DownloadStringTaskAsync(url);
            string fileName = DownloadedPages.Count.ToString();
            await Task.Factory.StartNew(() => File.WriteAllText(fileName, html, Encoding.UTF8));
            return html;
        }

        public void Parse(string html, string current)
        {
            string herfRegx = @"(href|HREF)[]*=[]*[""'][^""'#>]+(htm|html|aspx|jsp)[""']";
            MatchCollection matches = new Regex(herfRegx).Matches(html);
            foreach(Match match in matches)
            {
                string strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;

                strRef = ConverToAbsoluteUrl(strRef, current);

                if(Regex.IsMatch(new Uri(strRef).Host, HostFilterRegex) && !DownloadedPages.ContainsKey(strRef))
                {
                    pending.Enqueue(strRef);
                }
            }

        }

        private String ConverToAbsoluteUrl(string strRef, string current)
        {
            Uri currentUri = new Uri(current);
            Uri refUri = null;
            try
            {
                refUri = new Uri(strRef);
                if (refUri.IsAbsoluteUri) return strRef;
                else
                {
                    refUri = new Uri(currentUri, strRef);
                    return refUri.ToString();
                }
            }catch(UriFormatException ex)
            {
                refUri = new Uri(currentUri, strRef);
                return refUri.ToString();
            }
        }
    }
}
