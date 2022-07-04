using System;
using System.ComponentModel;

using System.Text;
using System.Windows.Forms;

using System.IO;						// For use in using the Stream class to read the users selected file
using System.Security.Cryptography;		// For use to gain access to the Hash, MD5 and SHA1 classes
using System.Text.RegularExpressions;   // For use in checking the validity of hashes to be compared
using System.Net;

namespace TMDownLoader
{

	public partial class mainForm : Form
    {
        WebClient client;
        WebProxy proxy;

        public mainForm() {
			// Form object is created

			InitializeComponent();          // Call for initialising the form

            client = new WebClient();

            if ( Properties.Settings.Default.UseProxy )
            {
                proxy = new WebProxy(Properties.Settings.Default.ProxyPath); 
                client.Proxy = proxy;
            }

            

            // Add a user agent header in case the
            // requested URI contains a query.
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            //client.Proxy

            // setup ToolTips
            toolTips.AutoPopDelay = 5000;
            toolTips.ShowAlways = true;
            // Add a tooltip to the listbox
            toolTips.SetToolTip(this.listBoxRelFiles, "Click to delete");

            toolTips.SetToolTip(this.textBoxRelFilePath, "pattern/vsapi659.zip");
            listBoxRelFiles.Items.Add("server.ini");
        }

        string UrlPath = "http://osce14-p.activeupdate.trendmicro.com/activeupdate/server.ini";
        string FilePath = "d:\\temp\\serverini";


        private void buttonDownload_Click(object sender, EventArgs e)
        {
            string relFilePath = "";
            string DirectoryPath = "";

            //relFilePath = "server.ini";
            //relFilePath = "pattern/vsapi659.zip";

           int PercentDone = 0;

            progressBarDownload.Value = 0;

            for (int i = 0; i < listBoxRelFiles.Items.Count; i++)
            {
                relFilePath = listBoxRelFiles.Items[i].ToString();

                UrlPath = textBoxURLBase.Text + "/" + relFilePath;
                FilePath = textBoxDownloadBasePath.Text + "\\" + relFilePath;

                // Build the directory path. 
                DirectoryPath = System.IO.Path.GetDirectoryName(FilePath); // Cut filename


                // Determine whether the directory exists.
                if (!Directory.Exists(DirectoryPath))
                {
                    // Try to create the directory.
                    System.IO.Directory.CreateDirectory(DirectoryPath);
                }


                try
                {  
                    client.DownloadFile(UrlPath, FilePath);

                    // build the path for the coresponding .sig file
                    UrlPath = System.IO.Path.ChangeExtension(UrlPath,".sig" );
                    FilePath = System.IO.Path.ChangeExtension(FilePath,".sig");

                    client.DownloadFile(UrlPath, FilePath);

                }
                catch (WebException webEx)
                {
                    MessageBox.Show(webEx.Message);
                    //if (webEx.Status == WebExceptionStatus.ConnectFailure)
                }

                PercentDone = (100 * (i+1)) / listBoxRelFiles.Items.Count;
                progressBarDownload.Value = PercentDone;
                

            }
            
            MessageBox.Show("Download finished");
            progressBarDownload.Value = 0;
        }


        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDownloadBasePath.Text = folderBrowserDialog.SelectedPath;
            }

        }


        private void buttonListboxAdd_Click(object sender, EventArgs e)
        {
            if (textBoxRelFilePath.Text.Length > 4)
            {
                listBoxRelFiles.Items.Add(textBoxRelFilePath.Text);

            }

        }



        /// <summary>
        /// exitToolStripMenuIte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// aboutToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instantiate window
            AboutBox dlg = new AboutBox();

            dlg.StartPosition = FormStartPosition.CenterParent; 

            // Show window modally
            // NOTE: Returns only when window is closed
            dlg.ShowDialog();

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void listBoxRelFiles_MouseDown(object sender, MouseEventArgs e)
        {
            // MessageBox.Show( "mouse down and index is: " + listBoxRelFiles.SelectedIndex);
            if (listBoxRelFiles.SelectedIndex >= 0)
            {

                listBoxRelFiles.Items.RemoveAt(listBoxRelFiles.SelectedIndex);
            }

            //if (e.Button == System.Windows.Forms.MouseButtons.Right)

            //foreach (ListViewItem item in listBoxRelFiles.SelectedItems)
            //{
            //    item.Remove();
            //}
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instantiate window
            OptionForm dlg = new OptionForm();

            dlg.StartPosition = FormStartPosition.CenterParent;

            // Show window modally
            // NOTE: Returns only when window is closed
            dlg.ShowDialog();

        }
    }
}
