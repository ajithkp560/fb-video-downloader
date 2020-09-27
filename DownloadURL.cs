using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookVideoDownloader
{
    class DownloadURL
    {
        public String url = "";
        ProgressBar pb = null;
        public DownloadURL(String url)
        {
            this.url = url;
        }

        public void setProgressBar(ProgressBar pb)
        {
            this.pb = pb;
        }

        public String parseUrl()
        {
            String source = "";
            try
            {
                WebClient wc = new WebClient();
                wc.Headers.Add("user-agent", "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.74 Safari/537.36 Edg/79.0.309.43");
                wc.Encoding = System.Text.Encoding.UTF8;
                return wc.DownloadString(url);
                //MessageBox.Show(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return source;
        }
        public void downloadFile()
        {
            try
            {
                //pb.Visible = true;
                WebClient wc = new WebClient();
                wc.Headers.Add("user-agent", "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.74 Safari/537.36 Edg/79.0.309.43");
                wc.Encoding = System.Text.Encoding.UTF8;
                int indexStart = url.LastIndexOf("/") + 1;
                int indexEnd = url.IndexOf("?");
                String fileName = url.Substring(indexStart, (indexEnd - indexStart));
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(dowloadProgress);
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadCompleted);
                wc.DownloadFileAsync(new Uri(url), fileName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dowloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            pb.Value = e.ProgressPercentage;
        }
        private void downloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("The download cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (e.Error != null)
            {
                MessageBox.Show("An error occurred while downloading file.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("File downloaded successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start("explorer.exe", @".");
        }
    }
}
