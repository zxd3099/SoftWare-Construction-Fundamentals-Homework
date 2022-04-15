using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment9
{
    public partial class Form1 : Form
    {
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

            ResultBox.Clear();
            ResultBox.AppendText("START CRAWLING!!!\n");
            webCrawler.Crawl();
            ResultBox.AppendText("END CRAWLING!!!\n");
        }

        private void GetCrawlInfo(string url, string info)
        {
            ResultBox.AppendText($"URL: {url}\nINFORMATION: {info}\n\n");
        }
    }
}
