using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMDownLoader
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();

            textBoxProxyUrl.Text = Properties.Settings.Default.ProxyPath;
            checkBoxUseProxy.Checked = Properties.Settings.Default.UseProxy;

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ProxyPath = textBoxProxyUrl.Text;
            Properties.Settings.Default.UseProxy = checkBoxUseProxy.Checked;

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
