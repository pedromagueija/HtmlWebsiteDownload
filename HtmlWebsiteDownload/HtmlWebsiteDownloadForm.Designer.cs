namespace HtmlWebsiteDownload
{
    partial class HtmlWebsiteDownloadForm
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
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.downloadedContentTextBox = new System.Windows.Forms.RichTextBox();
            this.statsListBox = new System.Windows.Forms.ListBox();
            this.contentsLabel = new System.Windows.Forms.Label();
            this.statsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(14, 15);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 13);
            this.urlLabel.TabIndex = 0;
            this.urlLabel.Text = "URL";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(49, 12);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(596, 20);
            this.urlTextBox.TabIndex = 1;
            this.urlTextBox.Text = "https://en.wikipedia.org/wiki/1918_New_Year_Honours";
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(570, 38);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.OnDownloadButtonClick);
            // 
            // downloadedContentTextBox
            // 
            this.downloadedContentTextBox.Location = new System.Drawing.Point(17, 67);
            this.downloadedContentTextBox.Name = "downloadedContentTextBox";
            this.downloadedContentTextBox.ReadOnly = true;
            this.downloadedContentTextBox.Size = new System.Drawing.Size(321, 381);
            this.downloadedContentTextBox.TabIndex = 3;
            this.downloadedContentTextBox.Text = "";
            // 
            // statsListBox
            // 
            this.statsListBox.FormattingEnabled = true;
            this.statsListBox.Location = new System.Drawing.Point(344, 67);
            this.statsListBox.Name = "statsListBox";
            this.statsListBox.Size = new System.Drawing.Size(301, 381);
            this.statsListBox.TabIndex = 4;
            // 
            // contentsLabel
            // 
            this.contentsLabel.AutoSize = true;
            this.contentsLabel.Location = new System.Drawing.Point(14, 48);
            this.contentsLabel.Name = "contentsLabel";
            this.contentsLabel.Size = new System.Drawing.Size(49, 13);
            this.contentsLabel.TabIndex = 5;
            this.contentsLabel.Text = "Contents";
            // 
            // statsLabel
            // 
            this.statsLabel.AutoSize = true;
            this.statsLabel.Location = new System.Drawing.Point(341, 48);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(31, 13);
            this.statsLabel.TabIndex = 6;
            this.statsLabel.Text = "Stats";
            // 
            // HtmlWebsiteDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 465);
            this.Controls.Add(this.statsLabel);
            this.Controls.Add(this.contentsLabel);
            this.Controls.Add(this.statsListBox);
            this.Controls.Add(this.downloadedContentTextBox);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.urlLabel);
            this.Name = "HtmlWebsiteDownloadForm";
            this.Text = "Html Website Download [Practice for 70-483]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.RichTextBox downloadedContentTextBox;
        private System.Windows.Forms.ListBox statsListBox;
        private System.Windows.Forms.Label contentsLabel;
        private System.Windows.Forms.Label statsLabel;
    }
}