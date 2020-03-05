using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Forms.UI.Controls;

namespace EdgeBrowserInWinForms
{
    public partial class EdgeControl : Form
    {
        [Obsolete]
        private WebView web;
        public EdgeControl()
        {
            InitializeComponent();
            web = new WebView();

            this.Controls.Add(web);

            InitWebView();
        }

        private void InitWebView()
        {
            web.Size = new Size((int)(this.Width * 0.75), this.Height);
            web.Source = new Uri("https://www.google.rs");
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            string link = tbxLink.Text;

            tbxLink.Clear();

            if (!link.Contains("https://"))
            {
                link = "https://" + link;
            }
            web.Source = new Uri(link);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string link = "https://www.whatsmybrowser.org/";

            web.Source = new Uri(link);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string link = "https://www.youtube.com/";

            web.Source = new Uri(link);
        }
    }
}
