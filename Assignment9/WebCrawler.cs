using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment9
{
    class WebCrawler
    {
        private Hashtable urls;

        private string beginUrl;

        private int count;

        public Action<string, string> GetCrawlInfo;

        public WebCrawler(string beginUrl)
        {
            this.beginUrl = beginUrl;
            urls = new Hashtable();
            urls.Add(beginUrl, false);
            count = 0;
        }

        public void Crawl()
        {
            while (true)
            {
                string current = null;
                string html = null;
                foreach(string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }
                if (current == null || count > 10) break;
                try
                {
                    html = DownLoad(current);
                    ++count;
                    GetCrawlInfo(current, "Crawler Success!");
                }catch(Exception ex)
                {
                    GetCrawlInfo(current, "Crawler Failure! The Details: " + ex.Message);
                }
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Parse(string html, string current)
        {
            string herfRegx = @"(href|HREF)[]*=[]*[""'][^""'#>]+(htm|html|aspx|jsp)[""']";
            string HostFilterRegex = "^" + new Uri(beginUrl).Host + "$";
            MatchCollection matches = new Regex(herfRegx).Matches(html);
            foreach(Match match in matches)
            {
                string strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if(urls[strRef] == null && Regex.IsMatch(new Uri(strRef).Host, HostFilterRegex))
                {
                    urls[strRef] = false;
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
