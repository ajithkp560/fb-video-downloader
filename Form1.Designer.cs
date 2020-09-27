namespace FacebookVideoDownloader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.urlBox = new System.Windows.Forms.TextBox();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.sourceText = new System.Windows.Forms.TextBox();
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.urlBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.urlBox.Location = new System.Drawing.Point(17, 16);
            this.urlBox.Margin = new System.Windows.Forms.Padding(4);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(1055, 35);
            this.urlBox.TabIndex = 0;
            this.urlBox.Text = "Enter public video URL...";
            this.urlBox.Enter += new System.EventHandler(this.urlBox_Enter);
            this.urlBox.Leave += new System.EventHandler(this.urlBox_Leave);
            // 
            // downloadBtn
            // 
            this.downloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.downloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadBtn.Location = new System.Drawing.Point(17, 390);
            this.downloadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(1056, 38);
            this.downloadBtn.TabIndex = 1;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = false;
            this.downloadBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // sourceText
            // 
            this.sourceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.sourceText.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.sourceText.Location = new System.Drawing.Point(17, 62);
            this.sourceText.Margin = new System.Windows.Forms.Padding(4);
            this.sourceText.Multiline = true;
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(1055, 320);
            this.sourceText.TabIndex = 2;
            this.sourceText.Text = "Enter source code if the video is not public.";
            this.sourceText.Enter += new System.EventHandler(this.sourceText_Enter);
            this.sourceText.Leave += new System.EventHandler(this.sourceText_Leave);
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(17, 438);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(1055, 23);
            this.downloadProgress.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(1087, 473);
            this.Controls.Add(this.downloadProgress);
            this.Controls.Add(this.sourceText);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.urlBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1105, 520);
            this.MinimumSize = new System.Drawing.Size(1105, 520);
            this.Name = "Form1";
            this.Text = "Facebook Video Downloader : http://terminalcoders.blogspot.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.TextBox sourceText;
        private System.Windows.Forms.ProgressBar downloadProgress;
    }
}

