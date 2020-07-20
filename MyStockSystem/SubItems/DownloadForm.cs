﻿using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace MyStockSystem.SubItems
{
    public partial class DownloadForm : MetroForm
    {
        public string ParentUrl { get; set; }

        WebClient client;
        
        public DownloadForm()
        {
            InitializeComponent();
        }

        private void DownloadForm_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //MessageBox.Show("Download Done");
            string fileName = ParentUrl.Substring(ParentUrl.IndexOf('=') + 1);
            pictureBox1.Load(Environment.CurrentDirectory + $"\\{fileName}");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                //프로그레스 값이 올라감
                progressBar1.Value = e.ProgressPercentage;

                //용량이 같아지면
                //if (e.BytesReceived == e.TotalBytesToReceive)
                //{
                //    Client_DownloadFileCompleted(sender, null);
                //}
            }));
        }

        private void DownloadForm_Shown(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(startDownload));
            thread.Start();
        }

        private void startDownload()
        {
            //그림이름 가져오기
            Uri uri = new Uri(ParentUrl);
            string fileName = ParentUrl.Substring(ParentUrl.IndexOf('=') + 1);
            client.DownloadFileAsync(uri, Environment.CurrentDirectory + $"\\{fileName}");
        }
    }
}
