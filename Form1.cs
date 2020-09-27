using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;

namespace FacebookVideoDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.ActiveControl = downloadBtn;
            sourceText.MaxLength = 99999999;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String url = urlBox.Text;
                String source = sourceText.Text;
                String video_url = "";
                if (sourceText.Text == "Enter source code if the video is not public.")
                {
                    DownloadURL du = new DownloadURL(url);
                    du.setProgressBar(downloadProgress);
                    source = du.parseUrl();
                    bool old = false;
                    MatchCollection sdMatch1 = Regex.Matches(source, "sd_src:\"([^\"]*)\"");
                    MatchCollection hdMatch1 = Regex.Matches(source, "hd_src:\"([^\"]*)\"");

                    MatchCollection sdMatch2 = Regex.Matches(source, "\"playable_url\":\"([^\"]*)\"");
                    MatchCollection hdMatch2 = Regex.Matches(source, "\"playable_url_quality_hd\":\"([^\"]*)\"");

                    old = !(sdMatch1.Count == 0 && hdMatch1.Count == 0);

                    if (old)
                    {
                        video_url = sdMatch1[0].Value.Replace("sd_src:", "").Replace("\"", "");
                        if (hdMatch1.Count > 0)
                        {
                            DialogResult hd = MessageBox.Show("HD Video is available. Do you want to download HD version?", "HD or SD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (hd == DialogResult.Yes)
                            {
                                String hd_url = hdMatch1[0].Value.Replace("hd_src:", "").Replace("\"", "");
                                video_url = hd_url;
                            }
                        }
                    }
                    else
                    {
                        video_url = sdMatch2[0].Value.Replace("\"playable_url\":", "").Replace("\"", "");
                        if (hdMatch2.Count > 0)
                        {
                            DialogResult hd = MessageBox.Show("HD Video is available. Do you want to download HD version?", "HD or SD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (hd == DialogResult.Yes)
                            {
                                String hd_url = hdMatch2[0].Value.Replace("\"playable_url_quality_hd\":", "").Replace("\"", "");
                                video_url = hd_url;
                            }
                        }
                    }
                }
                else
                {
                    source = source.Trim();
                    bool old = false;
                    MatchCollection sdMatch1 = Regex.Matches(source, "sd_src:\"([^\"]*)\"");
                    MatchCollection hdMatch1 = Regex.Matches(source, "hd_src:\"([^\"]*)\"");

                    MatchCollection sdMatch2 = Regex.Matches(source, "\"playable_url\":\"([^\"]*)\"");
                    MatchCollection hdMatch2 = Regex.Matches(source, "\"playable_url_quality_hd\":\"([^\"]*)\"");

                    old = !(sdMatch1.Count == 0 && hdMatch1.Count == 0);

                    if (old)
                    {
                        video_url = sdMatch1[0].Value.Replace("sd_src:", "").Replace("\"", "");
                        if (hdMatch1.Count > 0)
                        {
                            DialogResult hd = MessageBox.Show("HD Video is available. Do you want to download HD version?", "HD or SD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (hd == DialogResult.Yes)
                            {
                                String hd_url = hdMatch1[0].Value.Replace("hd_src:", "").Replace("\"", "");
                                video_url = hd_url;
                            }
                        }
                    }
                    else
                    {
                        video_url = sdMatch2[0].Value.Replace("\"playable_url\":", "").Replace("\"", "");
                        if (hdMatch2.Count > 0)
                        {
                            DialogResult hd = MessageBox.Show("HD Video is available. Do you want to download HD version?", "HD or SD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (hd == DialogResult.Yes)
                            {
                                String hd_url = hdMatch2[0].Value.Replace("\"playable_url_quality_hd\":", "").Replace("\"", "");
                                video_url = hd_url;
                            }
                        }
                    }
                }
                if(video_url == "")
                {
                    MessageBox.Show("The video not found. Please try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                video_url = video_url.Replace("\\", "");
                DownloadURL dUrl = new DownloadURL(video_url);
                dUrl.setProgressBar(downloadProgress);
                ThreadStart threadStart = new ThreadStart(dUrl.downloadFile);
                Thread thread = new Thread(threadStart);
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The videois not able to extract. If you enter URL, Please check the privacy of video. Public videos only can be extracted from URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sourceText_Enter(object sender, EventArgs e)
        {
            if (sourceText.Text == "Enter source code if the video is not public.")
            {
                sourceText.Text = "";
            }
        }

        private void sourceText_Leave(object sender, EventArgs e)
        {
            if (sourceText.Text == "")
            {
                sourceText.Text = "Enter source code if the video is not public.";
            }
        }

        private void urlBox_Enter(object sender, EventArgs e)
        {
            if (urlBox.Text == "Enter public video URL...")
            {
                urlBox.Text = "";
            }
        }

        private void urlBox_Leave(object sender, EventArgs e)
        {
            if (urlBox.Text == "")
            {
                urlBox.Text = "Enter public video URL...";
            }
        }
    }
}
