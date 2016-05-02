// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HtmlWebsiteDownloadForm.cs" author="Pedro Magueija">
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//   
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace HtmlWebsiteDownload
{
    using System;
    using System.Windows.Forms;

    public partial class HtmlWebsiteDownloadForm : Form
    {
        private readonly HtmlDownloadService browser = new HtmlDownloadService();

        private readonly LetterCounterService letterCounter = new LetterCounterService();

        public HtmlWebsiteDownloadForm()
        {
            InitializeComponent();
        }

        private async void OnDownloadButtonClick(object sender, EventArgs e)
        {
            ClearAllContents();

            downloadedContentTextBox.Text = await browser.Download(urlTextBox.Text);

            statsListBox.DataSource = await letterCounter.CountAsync(downloadedContentTextBox.Text);
        }

        private void ClearAllContents()
        {
            downloadedContentTextBox.Clear();
            statsListBox.DataSource = null;
        }
    }
}