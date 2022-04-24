using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Assignment10
{
    public partial class Form1 : Form
    {
        private Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Uri beginUri = new Uri(UrlBox.Text);
            }
            catch(UriFormatException ex)
            {
                MessageBox.Show("Please enter a valid url!\nThe failure details: " + ex.Message);
                UrlBox.Clear();
                return;
            }

            WebCrawler webCrawler = new WebCrawler(UrlBox.Text);
            webCrawler.GetCrawlInfo += this.GetCrawlInfo;
            webCrawler.CrawlEnd += this.crawlEnd;

            ResultBox.Clear();
            ResultBox.AppendText("START CRAWLING!!!\n");

            sw.Start();
            webCrawler.Crawl();
        }

        private void GetCrawlInfo(string url, string info)
        {
            if (this.ResultBox.InvokeRequired)
            {
                Action<string, string> action = this.AddInfo;
                this.Invoke(action, new object[] { url, info });
            }else
            {
                AddInfo(url, info);
            }          
        }

        private void AddInfo(string url, string info)
        {
            ResultBox.AppendText($"URL: {url}\nINFORMATION: {info}\n\n");
        }

        private void crawlEnd()
        {
            Action action = new Action(() =>
            {
                sw.Stop();
                ResultBox.AppendText($"DURATION: {sw.ElapsedMilliseconds}\n");
                ResultBox.AppendText("THE WEB CRAWL IS OVER!\n");
            });
            if (ResultBox.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
