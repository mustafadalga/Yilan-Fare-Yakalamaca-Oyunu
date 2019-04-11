using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YilanFareOyunu
{
    public partial class OyunGelistiricisiHakkinda : Form
    {
        public OyunGelistiricisiHakkinda()
        {
            InitializeComponent();
        }

        private void github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mustafadalga");
        }

        private void linkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/mustafadalga");
        }
    }
}
